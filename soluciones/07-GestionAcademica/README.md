# 🎓 Sistema de Gestión Académica

Arquitectura robusta de tres capas para la gestión de Estudiantes y Docentes mediante estructuras de datos propias e inmutabilidad.

## 🏗️ Arquitectura y Dependencias
El sistema implementa un diseño desacoplado donde la lógica de negocio orquestra la validación, la gestión de errores y la persistencia sobre estructuras propias.

```mermaid
graph TD
    subgraph Capa_Presentacion [Capa de Presentación - UI]
        Program[Program.cs]
    end

    subgraph Capa_Negocio [Capa de Lógica de Negocio - BLL]
        Service[PersonasService]
        Val[Validadores Polimórficos]
        Exc[Excepciones de Dominio]
    end

    subgraph Capa_Datos [Capa de Acceso a Datos - DAL]
        Repo[PersonasRepository]
        Lista[ILista~T~ / Lista Enlazada Genérica]
    end

    subgraph Capa_Modelo [Dominio - Models]
        Models[Records, Enums e Interfaces]
    end

    %% Flujo de Llamadas
    Program -- "1. Solicita Operación" --> Service
    Service -- "2. Valida Datos" --> Val
    Service -- "3. Lanza/Controla" --> Exc
    Service -- "4. Persiste/Recupera" --> Repo
    Repo -- "5. Almacena en Nodo~T~" --> Lista
```

## 🧬 Jerarquía de Modelos y Dominio
```mermaid
classDiagram
    class Persona {
        <<Abstract Record>>
        +int Id
        +string Dni
        +string Nombre
        +string Apellidos
        +string NombreCompleto (Calculada)
        +DateTime CreatedAt
        +DateTime UpdatedAt
        +bool IsDeleted
    }

    class IEstudiar {
        <<Interface>>
        +Estudiar()
    }

    class IDocente {
        <<Interface>>
        +ImpartirClase()
    }

    class Estudiante {
        <<Sealed Record>>
        +double Calificacion
        +Ciclo Ciclo
        +Curso Curso
        +string CalificacionCualitativa
        +Estudiar()
    }

    class Docente {
        <<Sealed Record>>
        +int Experiencia
        +string Especialidad
        +Ciclo Ciclo
        +ImpartirClase()
    }

    class Ciclo {
        <<Enumeration>>
        DAM, DAW, ASIR
    }

    class Curso {
        <<Enumeration>>
        Primero, Segundo
    }

    class InformeEstudiante {
        <<Sealed Record>>
        +ILista~Estudiante~ PorNota
        +int TotalEstudiantes
        +int Aprobados
        +int Suspensos
        +double NotaMedia
    }

    class InformeDocente {
        <<Sealed Record>>
        +ILista~Docente~ PorExperiencia
        +int TotalDocentes
        +double ExperienciaMedia
    }

    Persona <|-- Estudiante
    Persona <|-- Docente
    Estudiante ..|> IEstudiar
    Docente ..|> IDocente
    Estudiante --> Ciclo
    Estudiante --> Curso
    Docente --> Ciclo
    InformeEstudiante o-- Estudiante
    InformeDocente o-- Docente
```

## ⚠️ Gestión de Errores (Domain Exceptions)
El sistema utiliza una jerarquía de excepciones propia para comunicar errores de lógica de negocio de forma semántica, utilizando **clases anidadas** para agrupar los fallos relacionados con cada dominio.

```mermaid
classDiagram
    class DomainException { <<Abstract>> }
    class PersonasException { <<Abstract>> }
    class NotFound { <<Sealed>> }
    class Validation { <<Sealed>> }
    class AlreadyExists { <<Sealed>> }

    Exception <|-- DomainException
    DomainException <|-- PersonasException
    PersonasException <|-- NotFound
    PersonasException <|-- Validation
    PersonasException <|-- AlreadyExists
```

### Importancia Pedagógica:
1.  **Semántica**: Se lanzan errores específicos como `PersonasException.NotFound` en lugar de errores genéricos del sistema.
2.  **Desacoplamiento**: La interfaz de usuario no depende de excepciones de infraestructura. Solo conoce los errores que el dominio académico define.
3.  **Encapsulación**: Las clases anidadas permiten organizar los errores bajo un mismo espacio de nombres ('PersonasException.Tipo').

## 🔄 Flujos de Secuencia (Estudiantes)

### 1. Listar Estudiantes (Filtrado y Ordenación)
```mermaid
sequenceDiagram
    participant P as Program
    participant S as PersonasService
    participant R as PersonasRepository

    P->>S: GetEstudiantesOrderBy(criterio)
    S->>S: GetAllOrderBy(criterio)
    S->>R: GetAll()
    R-->>S: ILista~Persona~
    Note over S: Filtrar por tipo 'Estudiante'
    Note over S: Algoritmo Burbuja Polimórfico
    S-->>P: ILista~Estudiante~ (Ordenada)
```

### 2. Buscar Estudiante por DNI
```mermaid
sequenceDiagram
    participant P as Program
    participant S as PersonasService
    participant R as PersonasRepository

    P->>S: GetByDni(dni)
    S->>R: GetByDni(dni)
    
    alt Existe
        R-->>S: Record
        S-->>P: Persona (Ficha)
    else No Existe
        R-->>S: null
        S-->>P: throw PersonasException.NotFound
    end
```

### 3. Registrar Nuevo Estudiante (Alta)
```mermaid
sequenceDiagram
    participant P as Program
    participant S as PersonasService
    participant V as ValidadorEstudiante
    participant R as PersonasRepository

    P->>P: Mostrar Ficha Temporal
    P->>P: Confirmación Usuario (S/N)
    P->>S: Save(estudiante)
    S->>V: Validar(estudiante)
    V-->>S: ILista~string~ errores
    
    alt errores.Contar() > 0
        S-->>P: throw PersonasException.Validation(errores)
    else Éxito Validación
        S->>R: Create(estudiante)
        alt DNI Duplicado
            R-->>S: null
            S-->>P: throw PersonasException.AlreadyExists
        else Éxito Persistencia
            R-->>S: Record (ID/UTC)
            S-->>P: Estudiante Creado (Ficha)
        end
    end
```

### 4. Actualizar Estudiante
```mermaid
sequenceDiagram
    participant P as Program
    participant S as PersonasService
    participant V as ValidadorEstudiante
    participant R as PersonasRepository

    P->>P: Mostrar Cambios Propuestos
    P->>P: Confirmación Usuario (S/N)
    P->>S: Update(estudianteAct)
    S->>V: Validar(estudianteAct)
    V-->>S: ILista~string~ errores
    
    alt errores.Contar() > 0
        S-->>P: throw PersonasException.Validation(errores)
    else Éxito Validación
        S->>R: Update(id, estudianteAct)
        alt No Encontrado
            R-->>S: null
            S-->>P: throw PersonasException.NotFound
        else Éxito
            R-->>S: Record Actualizado (UTC)
            S-->>P: Estudiante Actualizado (Ficha)
        end
    end
```

### 5. Eliminar Estudiante (Borrado Físico)
```mermaid
sequenceDiagram
    participant P as Program
    participant S as PersonasService
    participant R as PersonasRepository

    P->>P: Mostrar Ficha del Registro
    P->>P: Confirmación Usuario (S/N)
    P->>S: Delete(id)
    S->>R: Delete(id)
    
    alt No Existe
        R-->>S: null
        S-->>P: throw PersonasException.NotFound
    else Existe
        R->>R: Eliminar Nodo de Lista Enlazada
        R-->>S: Record (IsDeleted=true)
        S-->>P: Confirmación de Borrado (Ficha)
    end
```

### 6. Informe Académico de Estudiantes
```mermaid
sequenceDiagram
    participant P as Program
    participant S as PersonasService
    participant R as PersonasRepository

    P->>S: GenerarInformeEstudiante(ciclo, curso)
    S->>R: GetAll()
    R-->>S: ILista~Persona~
    Note over S: Filtrar por Ciclo/Curso
    Note over S: Procesar Aprobados/Medias
    Note over S: Ordenar por Nota
    S-->>P: InformeEstudiante (Sealed Record)
```

## 📝 Especificaciones Técnicas
- **Inmutabilidad**: Uso de `records` con propiedades `init`. Las actualizaciones generan nuevas instancias mediante el operador `with`.
- **Validaciones Acumulativas**: Los validadores no se detienen en el primer fallo; coleccionan todos los errores en una lista para informar al usuario de forma integral.
- **Campos Calculados**: La entidad `Persona` expone `NombreCompleto`, centralizando la lógica de visualización para las tablas.
- **Gestión Temporal (UTC)**: Auditoría gestionada en UTC (`DateTime.UtcNow`). Visualización formateada mediante `.ToLocalTime()` y `CultureInfo` (`es-ES`).
- **Patrón Singleton**: Repositorio seguro para entornos multihilo mediante `Lazy<T>` y propiedad estática `Instance`.