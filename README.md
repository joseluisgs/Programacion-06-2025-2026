# Programación - 06 Programación con Genéricos. Programación Funcional. Uso de TDAs y Colecciones

Tema 06 Programación con Genéricos. Programación Funcional. Uso de TDAs y Colecciones. 1DAW. Curso 2025/2026.

![imagen](https://raw.githubusercontent.com/joseluisgs/Programacion-00-2022-2023/master/images/programacion.png)

- [Programación - 06 Programación con Genéricos. Programación Funcional. Uso de TDAs y Colecciones](#programación---06-programación-con-genéricos-programación-funcional-uso-de-tdas-y-colecciones)
  - [Contenido en Youtube](#contenido-en-youtube)
  - [1. Introducción](#1-introducción)
    - [1.1. Relación entre programación funcional, genéricos y colecciones](#11-relación-entre-programación-funcional-genéricos-y-colecciones)
    - [1.3. Paradigmas de programación en C#](#13-paradigmas-de-programación-en-c)
  - [2. Tipos Genéricos en C#](#2-tipos-genéricos-en-c)
    - [2.1. Introducción a los Genéricos](#21-introducción-a-los-genéricos)
      - [2.1.1. ¿Qué son y para qué sirven?](#211-qué-son-y-para-qué-sirven)
      - [2.1.2. Ventajas:  reutilización, type-safety, rendimiento](#212-ventajas--reutilización-type-safety-rendimiento)
      - [2.1.3. Historia y evolución en C#](#213-historia-y-evolución-en-c)
    - [2.2. Clases Genéricas](#22-clases-genéricas)
      - [2.2.1. Definición y sintaxis](#221-definición-y-sintaxis)
      - [2.2.2. Parámetros de tipo único](#222-parámetros-de-tipo-único)
      - [2.2.3. Parámetros de tipo múltiples](#223-parámetros-de-tipo-múltiples)
      - [2.2.4. Clases genéricas anidadas](#224-clases-genéricas-anidadas)
    - [2.3. Métodos Genéricos](#23-métodos-genéricos)
      - [2.3.1. Sintaxis y casos de uso](#231-sintaxis-y-casos-de-uso)
      - [2.3.2. Inferencia de tipos](#232-inferencia-de-tipos)
      - [2.3.3. Métodos genéricos en clases no genéricas](#233-métodos-genéricos-en-clases-no-genéricas)
      - [2.3.4. Métodos genéricos estáticos](#234-métodos-genéricos-estáticos)
    - [2.4. Varianza en Genéricos](#24-varianza-en-genéricos)
      - [2.4.1. Conceptos Fundamentales](#241-conceptos-fundamentales)
      - [2.4.2. Invarianza (comportamiento por defecto)](#242-invarianza-comportamiento-por-defecto)
      - [2.4.3. Covarianza (`out`)](#243-covarianza-out)
      - [2.4.4. Contravarianza (`in`)](#244-contravarianza-in)
      - [2.4.5. Tabla Comparativa y Guía de Uso](#245-tabla-comparativa-y-guía-de-uso)
    - [2.5. Restricciones de Tipos (Constraints)](#25-restricciones-de-tipos-constraints)
      - [2.5.1. Restricciones básicas](#251-restricciones-básicas)
      - [2.5. 2. Múltiples restricciones combinadas](#25-2-múltiples-restricciones-combinadas)
      - [2.5.3. Restricciones con múltiples parámetros de tipo](#253-restricciones-con-múltiples-parámetros-de-tipo)
      - [2.5.4. Ejemplos prácticos avanzados](#254-ejemplos-prácticos-avanzados)
    - [2.6. Tipos Genéricos Anulables](#26-tipos-genéricos-anulables)
      - [2.6.1. `Nullable<T>` y la sintaxis `T?`](#261-nullablet-y-la-sintaxis-t)
      - [2.6.2. Uso exclusivo con tipos de valor (`struct`)](#262-uso-exclusivo-con-tipos-de-valor-struct)
      - [2.6.3. Propiedades:   `HasValue`, `Value`](#263-propiedades---hasvalue-value)
      - [2.6.4. Operadores y conversiones](#264-operadores-y-conversiones)
  - [3. Programación Funcional en C#](#3-programación-funcional-en-c)
    - [3.1. Conceptos Fundamentales](#31-conceptos-fundamentales)
      - [3.1.1. Funciones como ciudadanos de primera clase](#311-funciones-como-ciudadanos-de-primera-clase)
      - [3.1.2. Inmutabilidad](#312-inmutabilidad)
      - [3.1.3. Funciones puras vs. funciones con efectos secundarios](#313-funciones-puras-vs-funciones-con-efectos-secundarios)
      - [3.1.4. Transparencia referencial](#314-transparencia-referencial)
    - [3.2. Delegates (Delegados)](#32-delegates-delegados)
      - [3.2.1. Fundamentos](#321-fundamentos)
      - [3.2.2. Delegates Personalizados](#322-delegates-personalizados)
      - [3.2.3. Delegates Genéricos Predefinidos](#323-delegates-genéricos-predefinidos)
      - [3.2.4. Multicast Delegates](#324-multicast-delegates)
    - [3.3. Expresiones Lambda](#33-expresiones-lambda)
      - [3.3.1. Sintaxis Básica](#331-sintaxis-básica)
      - [3.3.2. Variantes Sintácticas](#332-variantes-sintácticas)
      - [3.3.3. Captura de Variables (Closures)](#333-captura-de-variables-closures)
    - [3.4. Funciones Anónimas](#34-funciones-anónimas)
      - [3.4.1. Métodos anónimos con `delegate`](#341-métodos-anónimos-con-delegate)
      - [3.4.2. Comparación con expresiones lambda](#342-comparación-con-expresiones-lambda)
      - [3.4.3. Cuándo usar métodos anónimos vs.  lambdas](#343-cuándo-usar-métodos-anónimos-vs--lambdas)
    - [3.5. Funciones de Orden Superior](#35-funciones-de-orden-superior)
      - [3.5.1. Funciones que Reciben Funciones](#351-funciones-que-reciben-funciones)
      - [3.5.2. Funciones que Devuelven Funciones](#352-funciones-que-devuelven-funciones)
      - [3.5.3. Implementación de Operaciones Funcionales Básicas (sobre Arrays)](#353-implementación-de-operaciones-funcionales-básicas-sobre-arrays)
      - [3. 5. 4.  Composición de Operaciones](#3-5-4--composición-de-operaciones)
    - [3.6. Métodos de Extensión](#36-métodos-de-extensión)
      - [3.6.1. Fundamentos](#361-fundamentos)
      - [3.6.2. Extensión de Tipos Incorporados](#362-extensión-de-tipos-incorporados)
      - [3.6.3. Métodos de Extensión Genéricos](#363-métodos-de-extensión-genéricos)
      - [3.6.4. Crear Operaciones Funcionales como Extensiones (sobre Arrays)](#364-crear-operaciones-funcionales-como-extensiones-sobre-arrays)
    - [3.7. Sobrecarga de Operadores](#37-sobrecarga-de-operadores)
      - [3.7.1. Fundamentos](#371-fundamentos)
      - [3.7.2. Operadores Aritméticos](#372-operadores-aritméticos)
      - [3.7.3. Operadores de Comparación](#373-operadores-de-comparación)
      - [3.7.4. Operadores Lógicos](#374-operadores-lógicos)
      - [3.7.5. Operadores de Conversión](#375-operadores-de-conversión)
      - [3.7.6. Buenas Prácticas](#376-buenas-prácticas)
  - [4. Comparación y Ordenación](#4-comparación-y-ordenación)
    - [4.1.  Interfaz `IComparable<T>`](#41--interfaz-icomparablet)
      - [4.1.1. Fundamentos](#411-fundamentos)
      - [4.1.2. Implementación](#412-implementación)
      - [4.1.3. Uso con Arrays](#413-uso-con-arrays)
    - [4.2. Interfaz `IComparer<T>`](#42-interfaz-icomparert)
      - [4.2.1. Fundamentos](#421-fundamentos)
      - [4.2.2. Implementación](#422-implementación)
      - [4.2.3. Uso con Arrays](#423-uso-con-arrays)
      - [4.2.4. Ejemplos Prácticos con Arrays](#424-ejemplos-prácticos-con-arrays)
    - [4.3. Interfaz `IEquatable<T>`](#43-interfaz-iequatablet)
      - [4.3.1. Fundamentos](#431-fundamentos)
      - [4.3.2. Implementación](#432-implementación)
      - [4.3.3. Uso con Arrays](#433-uso-con-arrays)
    - [4.4. Métodos y Propiedades Auxiliares](#44-métodos-y-propiedades-auxiliares)
      - [4.4.1. `Comparer<T>.Default`](#441-comparertdefault)
      - [4.4.2. `EqualityComparer<T>. Default`](#442-equalitycomparert-default)
      - [4.4.3. Comparadores Especiales](#443-comparadores-especiales)
    - [4.5. Ordenación con Arrays](#45-ordenación-con-arrays)
      - [4.5.1.  Métodos de Ordenación](#451--métodos-de-ordenación)
      - [4.5.2. Ordenación con Lambdas](#452-ordenación-con-lambdas)
      - [4.5.3. Ordenación Parcial](#453-ordenación-parcial)
      - [4.5.4. Ordenación Estable vs.  Inestable](#454-ordenación-estable-vs--inestable)
      - [4.5.5. Rendimiento de Ordenación](#455-rendimiento-de-ordenación)
    - [4.6. Búsqueda en Arrays Ordenados](#46-búsqueda-en-arrays-ordenados)
      - [4.6.1. `Array.BinarySearch`](#461-arraybinarysearch)
      - [4.6.2. Búsqueda con Comparadores](#462-búsqueda-con-comparadores)
      - [4.6.3. Rendimiento de Búsqueda](#463-rendimiento-de-búsqueda)
    - [4.7. Resumen y Mejores Prácticas](#47-resumen-y-mejores-prácticas)
      - [4.7.1. Cuándo Usar Cada Interfaz](#471-cuándo-usar-cada-interfaz)
      - [4.7.2. Decisiones de Diseño](#472-decisiones-de-diseño)
      - [4.7.3. Errores Comunes](#473-errores-comunes)
  - [5. Colecciones en C#](#5-colecciones-en-c)
    - [5.1. Introducción a las Colecciones](#51-introducción-a-las-colecciones)
      - [5.1.1. ¿Qué son las colecciones?](#511-qué-son-las-colecciones)
      - [5.1.2. Namespaces Importantes](#512-namespaces-importantes)
      - [5.1.3. Jerarquía de Interfaces](#513-jerarquía-de-interfaces)
      - [5.1.4. Colecciones Genéricas vs. No Genéricas](#514-colecciones-genéricas-vs-no-genéricas)
      - [5.1.5. Resumen de Colecciones en C#](#515-resumen-de-colecciones-en-c)
    - [5.2. List](#52-list)
      - [5.2.1. Características](#521-características)
      - [5.2.2. Creación e Inicialización](#522-creación-e-inicialización)
      - [5.2.3. Operaciones Básicas](#523-operaciones-básicas)
      - [5.2.4. Búsqueda y Verificación](#524-búsqueda-y-verificación)
      - [5.2.5. Ordenación](#525-ordenación)
      - [5.2.6. Conversiones](#526-conversiones)
      - [5.2.7. Capacidad y Rendimiento](#527-capacidad-y-rendimiento)
    - [5.3. Dictionary\<TKey, TValue\>](#53-dictionarytkey-tvalue)
      - [5.3.1. Características](#531-características)
      - [5.3.2. Creación e Inicialización](#532-creación-e-inicialización)
      - [5.3.3. Operaciones Básicas](#533-operaciones-básicas)
      - [5.3.4. Recorrer Diccionarios](#534-recorrer-diccionarios)
      - [5.3.5. Propiedades Keys y Values](#535-propiedades-keys-y-values)
      - [5.3.6. Ejemplos Prácticos](#536-ejemplos-prácticos)
      - [5.3.7. Rendimiento y Comparadores](#537-rendimiento-y-comparadores)
    - [5.4. HashSet](#54-hashset)
      - [5.4.1. Características](#541-características)
      - [5.4.2. Creación y Operaciones Básicas](#542-creación-y-operaciones-básicas)
      - [5.4.3. Operaciones de Conjuntos](#543-operaciones-de-conjuntos)
      - [5.4.4. Ejemplos Prácticos](#544-ejemplos-prácticos)
    - [5.5. Queue](#55-queue)
      - [5.5.1. Características](#551-características)
      - [5.5.2. Operaciones Básicas](#552-operaciones-básicas)
      - [5.5.3. Ejemplos Prácticos](#553-ejemplos-prácticos)
    - [5.6. Stack](#56-stack)
      - [5.6.1. Características](#561-características)
      - [5.6.2. Operaciones Básicas](#562-operaciones-básicas)
      - [5.6.3. Ejemplos Prácticos](#563-ejemplos-prácticos)
      - [5.7.3. Con Comparador Personalizado](#573-con-comparador-personalizado)
    - [5.8. SortedDictionary\<TKey, TValue\>](#58-sorteddictionarytkey-tvalue)
      - [5.8.1. Características](#581-características)
      - [5.8.2. Operaciones Básicas](#582-operaciones-básicas)
    - [5.9. LinkedList](#59-linkedlist)
      - [5.9.1. Características](#591-características)
      - [5.9.2. Operaciones Básicas](#592-operaciones-básicas)
    - [5.10. Colecciones No Genéricas (Legacy)](#510-colecciones-no-genéricas-legacy)
      - [5.10.1. ¿Qué son y por qué evitarlas?](#5101-qué-son-y-por-qué-evitarlas)
      - [5.10.2. ArrayList](#5102-arraylist)
      - [5.10.3. Hashtable](#5103-hashtable)
      - [5.10.4. Stack y Queue No Genéricas](#5104-stack-y-queue-no-genéricas)
      - [5.10.5. Tabla de Migración](#5105-tabla-de-migración)
    - [5.11. Colecciones de Solo Lectura (Read-Only)](#511-colecciones-de-solo-lectura-read-only)
      - [5.11.1. ¿Qué son las colecciones de solo lectura?](#5111-qué-son-las-colecciones-de-solo-lectura)
      - [5.11.2. IReadOnlyList e IReadOnlyCollection](#5112-ireadonlylist-e-ireadonlycollection)
      - [5.11.3. ReadOnlyCollection](#5113-readonlycollection)
      - [5.11.4. AsReadOnly()](#5114-asreadonly)
      - [5.11.5. Casos de Uso](#5115-casos-de-uso)
    - [5.12. Colecciones Inmutables (System.Collections.Immutable)](#512-colecciones-inmutables-systemcollectionsimmutable)
      - [5.12.1. ¿Qué son las colecciones inmutables?](#5121-qué-son-las-colecciones-inmutables)
      - [5.12.2. Instalación](#5122-instalación)
      - [5.12.3. ImmutableList](#5123-immutablelist)
      - [5.12.4. ImmutableDictionary\<TKey, TValue\>](#5124-immutabledictionarytkey-tvalue)
      - [5.12.5. Otras Colecciones Inmutables](#5125-otras-colecciones-inmutables)
      - [5.12.6. Builder Pattern para Rendimiento](#5126-builder-pattern-para-rendimiento)
      - [5.12.7. Casos de Uso](#5127-casos-de-uso)
    - [5.13. Colecciones Concurrentes (Thread-Safe)](#513-colecciones-concurrentes-thread-safe)
      - [5.13.1. ¿Qué son las colecciones concurrentes?](#5131-qué-son-las-colecciones-concurrentes)
      - [5.13.2. ConcurrentBag](#5132-concurrentbag)
      - [5.13.3. ConcurrentQueue](#5133-concurrentqueue)
      - [5.13.4. ConcurrentStack](#5134-concurrentstack)
      - [5.13.5. ConcurrentDictionary\<TKey, TValue\>](#5135-concurrentdictionarytkey-tvalue)
      - [5.13.6. BlockingCollection](#5136-blockingcollection)
      - [5.13.7. Cuándo Usar Colecciones Concurrentes](#5137-cuándo-usar-colecciones-concurrentes)
    - [5.14. Jerarquía y Diagramas de Colecciones](#514-jerarquía-y-diagramas-de-colecciones)
      - [5.14.1. Jerarquía de Interfaces de Colecciones](#5141-jerarquía-de-interfaces-de-colecciones)
      - [5.14.2. Listado Completo de Colecciones Genéricas](#5142-listado-completo-de-colecciones-genéricas)
      - [5.14.3. Listado con Colecciones Especializadas](#5143-listado-con-colecciones-especializadas)
      - [5.14.4. Diagrama de Colecciones por Namespace](#5144-diagrama-de-colecciones-por-namespace)
    - [5.15. Guía de Selección de Colecciones](#515-guía-de-selección-de-colecciones)
      - [5.15.1. Flujo de Decisión](#5151-flujo-de-decisión)
      - [5.15.3. Tabla de Decisión Completa](#5153-tabla-de-decisión-completa)
      - [5.15.4. Comparación de Complejidad (Big O)](#5154-comparación-de-complejidad-big-o)
      - [5.15.5. Casos de Uso Prácticos por Escenario](#5155-casos-de-uso-prácticos-por-escenario)
    - [5.16. Resumen de Todas las Colecciones](#516-resumen-de-todas-las-colecciones)
      - [5.16.1. Tabla Resumen Maestra](#5161-tabla-resumen-maestra)
      - [5.16.2. Resumen por Namespace](#5162-resumen-por-namespace)
      - [5.16.3. Recomendaciones Finales](#5163-recomendaciones-finales)
      - [5.16.4. Checklist de Selección Rápida](#5164-checklist-de-selección-rápida)
  - [6. Formateadores y Localización](#6-formateadores-y-localización)
    - [6.1. Introducción](#61-introducción)
    - [6.2. CultureInfo](#62-cultureinfo)
    - [6.3. Formateo de Números](#63-formateo-de-números)
    - [6.4. Formateo de Fechas](#64-formateo-de-fechas)
    - [6.5. Métodos de Extensión para Formateo](#65-métodos-de-extensión-para-formateo)
  - [7. Buenas Prácticas y Recomendaciones](#7-buenas-prácticas-y-recomendaciones)
    - [7.1. Colecciones](#71-colecciones)
    - [7.2. Programación Funcional](#72-programación-funcional)
    - [7.3. Comparación y Ordenación](#73-comparación-y-ordenación)
    - [7.4. Genéricos](#74-genéricos)
  - [Autor](#autor)
    - [Contacto](#contacto)
  - [Licencia de uso](#licencia-de-uso)



---

## Contenido en Youtube

- [Podcast](#)
- [Resumen](#)
- [Programación con Genéricos](#)
- [Programación Funcional](#)
- [Listas](#)
- [Diccionarios](#)
- [Sets](#)
- [Colas y Pilas](#)
- [Lista de Reproducción](https://www.youtube.com/watch?v=wKCdgacEr4Q&list=PLGIH-7eZDbVw6q2AdcAUe2r6YxJYBkfCi)


---

## 1. Introducción

Este tema abarca tres conceptos fundamentales en la programación moderna con C# y .NET:

**Tipos Genéricos**:  Aprenderás a escribir código reutilizable y seguro en cuanto a tipos, evitando la duplicación de código y mejorando el rendimiento de tus aplicaciones.

**Programación Funcional**: Descubrirás un nuevo paradigma de programación que te permitirá escribir código más expresivo, conciso y fácil de mantener, tratando las funciones como elementos de primera clase.

**Colecciones**: Dominarás las estructuras de datos que C# y .NET ponen a tu disposición para almacenar, organizar y manipular conjuntos de datos de manera eficiente. 

Estos tres conceptos están profundamente interrelacionados.  Los genéricos nos permiten crear colecciones que funcionan con cualquier tipo de dato manteniendo la seguridad de tipos. La programación funcional nos proporciona herramientas poderosas para manipular estas colecciones de manera elegante y eficiente.  Y las colecciones son el terreno perfecto donde aplicar tanto genéricos como técnicas funcionales.

### 1.1. Relación entre programación funcional, genéricos y colecciones

Imagina que tienes un array de números y quieres: 
- Filtrar solo los números pares
- Multiplicar cada uno por 2
- Sumar todos los resultados

Sin las herramientas que aprenderás en este tema, necesitarías escribir bucles anidados, variables temporales y mucho código imperativo. Con genéricos, programación funcional y un buen conocimiento de las colecciones, podrás expresar esta operación de manera clara y concisa.

Es decir antes harías algo así:

```csharp
int[] numeros = { 1, 2, 3, 4, 5, 6 };
int suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        suma += numeros[i] * 2;
    }
}

```

Ahora, con las herramientas que aprenderás, podrías hacerlo así:

```csharp
int[] numeros = { 1, 2, 3, 4, 5, 6 };
int resultado = numeros
    .Where(n => n % 2 == 0)   // Filtrar pares
    .Select(n => n * 2)       // Multiplicar por 2
    .Sum();                    // Sumar resultados

```

Este código será: 
- **Declarativo**: Expresa QUÉ quieres hacer, no CÓMO hacerlo
- **Legible**: Cualquiera puede entender la intención
- **Reutilizable**: Cada operación es independiente
- **Seguro**: Los genéricos garantizan que trabajas con el tipo correcto

### 1.3. Paradigmas de programación en C#

C# es un lenguaje **multiparadigma**, lo que significa que soporta diferentes estilos de programación:

**Programación Imperativa**: Le dices al ordenador paso a paso qué hacer. 

```csharp
int suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        suma += numeros[i] * 2;
    }
}

```

**Programación Orientada a Objetos (POO)**: Organizas el código en clases y objetos con estado y comportamiento.

```csharp
public class CalculadoraNumeros
{
    public int CalcularSumaParesDobles(int[] numeros)
    {
        // ... 
    }
}

```

**Programación Funcional**:  Tratas las funciones como valores, evitas el estado mutable y prefieres composición de funciones.

```csharp
Func<int, bool> esPar = n => n % 2 == 0;
Func<int, int> duplicar = n => n * 2;

// Cuando veamos colecciones
int resultado = numeros
    .Where(esPar)
    .Select(duplicar)
    .Sum();

```

En este tema nos centraremos especialmente en la **programación funcional**, pero verás cómo C# te permite combinar lo mejor de cada paradigma según tus necesidades.

---

## 2. Tipos Genéricos en C#

### 2.1. Introducción a los Genéricos

#### 2.1.1. ¿Qué son y para qué sirven?

Los **genéricos** (generics en inglés) son una característica del lenguaje que te permite escribir código que funciona con diferentes tipos de datos sin perder la seguridad de tipos (type safety) y sin duplicar código. 

Imagina que necesitas crear una clase que almacene un valor.  Podrías hacerlo así:

```csharp
// Clase que almacena un entero
public class CajaDeEnteros
{
    private int valor;
    
    public CajaDeEnteros(int valor)
    {
        this. valor = valor;
    }
    
    public int ObtenerValor()
    {
        return valor;
    }
}

```

Pero, ¿qué pasa si ahora necesitas una caja para strings?  ¿Y para doubles? ¿Y para objetos de tu clase Persona?  Tendrías que crear una clase diferente para cada tipo: 

```csharp
public class CajaDeStrings { /* ... */ }
public class CajaDeDoubles { /* ... */ }
public class CajaDePersonas { /* ... */ }

```

Esto es tedioso, propenso a errores y difícil de mantener. **Los genéricos resuelven este problema**.

Con genéricos, puedes escribir una única clase que funciona con cualquier tipo:

```csharp
// Clase genérica que funciona con cualquier tipo T
public class Caja<T>
{
    private T valor;
    
    public Caja(T valor)
    {
        this.valor = valor;
    }
    
    public T ObtenerValor()
    {
        return valor;
    }
}

```

Ahora puedes usar esta clase con cualquier tipo:

```csharp
Caja<int> cajaEntero = new Caja<int>(42);
int numeroGuardado = cajaEntero. ObtenerValor(); // 42

Caja<string> cajaTexto = new Caja<string>("Hola");
string textoGuardado = cajaTexto.ObtenerValor(); // "Hola"

Caja<Persona> cajaPersona = new Caja<Persona>(new Persona("Ana", 25));
Persona personaGuardada = cajaPersona.ObtenerValor();

```

La letra `T` es un **parámetro de tipo** (type parameter). Es como una variable, pero para tipos en lugar de valores.  Por convención, se suele usar `T` (de "Type"), aunque puedes usar cualquier identificador válido.

#### 2.1.2. Ventajas:  reutilización, type-safety, rendimiento

Los genéricos proporcionan tres ventajas fundamentales:

**1. Reutilización de código**

Escribes el código una sola vez y funciona con múltiples tipos.  Esto reduce la duplicación y facilita el mantenimiento.

```csharp
// Una sola clase genérica para todos los tipos
public class Pila<T>
{
    private T[] elementos;
    private int contador;
    
    public void Push(T elemento) { /* ... */ }
    public T Pop() { /* ... */ }
}

// Uso con diferentes tipos
Pila<int> pilaNumeros = new Pila<int>();
Pila<string> pilaTextos = new Pila<string>();
Pila<Persona> pilaPersonas = new Pila<Persona>();

```

**2. Type-safety (Seguridad de tipos)**

El compilador verifica en tiempo de compilación que estás usando los tipos correctamente, evitando errores en tiempo de ejecución.

Sin genéricos (usando object):

```csharp
// Enfoque antiguo:  usar object
public class CajaSinGenericos
{
    private object valor;
    
    public CajaSinGenericos(object valor)
    {
        this.valor = valor;
    }
    
    public object ObtenerValor()
    {
        return valor;
    }
}

// Uso:  propenso a errores
CajaSinGenericos caja = new CajaSinGenericos(42);
string texto = (string)caja.ObtenerValor(); // ¡ERROR en tiempo de ejecución!
// InvalidCastException: Unable to cast object of type 'System.Int32' to type 'System. String'

```

Con genéricos:

```csharp
Caja<int> caja = new Caja<int>(42);
string texto = caja.ObtenerValor(); // ERROR en tiempo de COMPILACIÓN
// Cannot implicitly convert type 'int' to 'string'

```

Es mucho mejor que el compilador te avise del error antes de ejecutar el programa.

**3. Rendimiento**

Los genéricos evitan el **boxing** y **unboxing** de tipos valor, mejorando significativamente el rendimiento.

**Boxing** es el proceso de convertir un tipo valor (como `int`, `double`, `bool`) en un objeto de tipo referencia (almacenándolo en el heap). **Unboxing** es el proceso inverso.

Sin genéricos: 

```csharp
// Sin genéricos: boxing y unboxing
ArrayList lista = new ArrayList(); // Colección antigua no genérica
lista.Add(42);        // Boxing:  int -> object
int numero = (int)lista[0]; // Unboxing: object -> int

// Con 1 millón de elementos, esto genera 2 millones de operaciones costosas

```

Con genéricos:

```csharp
// Con genéricos: sin boxing ni unboxing
List<int> lista = new List<int>();
lista.Add(42);        // Sin boxing, se almacena directamente como int
int numero = lista[0]; // Sin unboxing, se recupera directamente como int

```

Ejemplo comparativo de rendimiento:

```csharp
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

// Código ejecutable
const int ELEMENTOS = 1000000;

// Sin genéricos (ArrayList)
Stopwatch sw1 = Stopwatch.StartNew();
ArrayList listaSinGenericos = new ArrayList();
for (int i = 0; i < ELEMENTOS; i++)
{
    listaSinGenericos.Add(i); // Boxing en cada iteración
}
int suma1 = 0;
for (int i = 0; i < ELEMENTOS; i++)
{
    suma1 += (int)listaSinGenericos[i]; // Unboxing en cada iteración
}
sw1.Stop();

// Con genéricos (List<T>)
Stopwatch sw2 = Stopwatch.StartNew();
List<int> listaConGenericos = new List<int>();
for (int i = 0; i < ELEMENTOS; i++)
{
    listaConGenericos.Add(i); // Sin boxing
}
int suma2 = 0;
for (int i = 0; i < ELEMENTOS; i++)
{
    suma2 += listaConGenericos[i]; // Sin unboxing
}
sw2.Stop();

Console.WriteLine($"Sin genéricos: {sw1.ElapsedMilliseconds} ms");
Console.WriteLine($"Con genéricos: {sw2.ElapsedMilliseconds} ms");
Console.WriteLine($"Mejora: {sw1.ElapsedMilliseconds / (double)sw2.ElapsedMilliseconds:F2}x más rápido");

// Salida típica:
// Sin genéricos: 250 ms
// Con genéricos: 45 ms
// Mejora:  5. 56x más rápido
```

#### 2.1.3. Historia y evolución en C#

Los genéricos se introdujeron en **C# 2.0** (2005) junto con . NET Framework 2.0. Antes de esto, los desarrolladores tenían que elegir entre:

1. **Duplicar código** para cada tipo
2. **Usar `object`** y perder type-safety y rendimiento
3. **Usar colecciones no genéricas** como `ArrayList`, `Hashtable`, etc.

La introducción de genéricos fue revolucionaria y permitió crear: 
- Colecciones genéricas:  `List<T>`, `Dictionary<TKey, TValue>`, etc.
- Delegates genéricos: `Action<T>`, `Func<T, TResult>`, etc.
- Interfaces genéricas: `IEnumerable<T>`, `IComparable<T>`, etc.

Desde entonces, los genéricos han evolucionado: 

- **C# 3.0**:  Mejoras en inferencia de tipos con genéricos
- **C# 4.0**: Varianza en genéricos (covarianza y contravarianza)
- **C# 7.0**: Mejoras en inferencia de tipos de retorno
- **C# 8.0**: Restricciones `notnull` en genéricos
- **C# 9.0**: Covarianza en tipos de retorno
- **C# 11.0**: Mejoras en operadores matemáticos genéricos

Los genéricos son ahora parte fundamental del lenguaje y están en todas partes:  colecciones, LINQ, async/await, etc. 

---

### 2.2. Clases Genéricas

#### 2.2.1. Definición y sintaxis

Una **clase genérica** es una clase que tiene uno o más parámetros de tipo. La sintaxis básica es:

```csharp
public class NombreClase<T>
{
    // Usar T como si fuera un tipo normal
}

```

Donde:  
- `NombreClase` es el nombre de tu clase
- `<T>` declara un parámetro de tipo llamado `T`
- Dentro de la clase, puedes usar `T` como cualquier otro tipo

Veamos un ejemplo completo de una clase genérica:

```csharp
// Clase genérica que representa una caja que puede contener cualquier tipo de objeto
public class Caja<T>
{
    // Campo privado del tipo genérico T
    private T contenido;
    
    // Constructor que acepta un parámetro del tipo T
    public Caja(T contenidoInicial)
    {
        contenido = contenidoInicial;
    }
    
    // Método que devuelve el tipo T
    public T ObtenerContenido()
    {
        return contenido;
    }
    
    // Método que acepta un parámetro del tipo T
    public void EstablecerContenido(T nuevoContenido)
    {
        contenido = nuevoContenido;
    }
    
    // Método que muestra información (T. ToString() siempre está disponible)
    public void MostrarInfo()
    {
        Console. WriteLine($"La caja contiene: {contenido}");
        Console.WriteLine($"Tipo del contenido: {typeof(T).Name}");
    }
}

```

Uso de la clase genérica:

```csharp
// Código ejecutable
// Caja de enteros
Caja<int> cajaNumero = new Caja<int>(42);
cajaNumero.MostrarInfo();
// Salida: 
// La caja contiene:  42
// Tipo del contenido: Int32

int numero = cajaNumero.ObtenerContenido();
Console.WriteLine($"Número extraído: {numero}"); // 42

cajaNumero.EstablecerContenido(100);
Console.WriteLine($"Nuevo contenido: {cajaNumero.ObtenerContenido()}"); // 100

Console.WriteLine();

// Caja de strings
Caja<string> cajaTexto = new Caja<string>("Hola Mundo");
cajaTexto.MostrarInfo();
// Salida:
// La caja contiene: Hola Mundo
// Tipo del contenido: String

string texto = cajaTexto.ObtenerContenido();
Console.WriteLine($"Texto extraído: {texto}"); // Hola Mundo

Console.WriteLine();

// Caja de objetos personalizados
Persona persona = new Persona { Nombre = "Ana", Edad = 25 };
Caja<Persona> cajaPersona = new Caja<Persona>(persona);
cajaPersona.MostrarInfo();
// Salida:  
// La caja contiene:  Persona:  Ana (25 años)
// Tipo del contenido: Persona

Persona personaExtraida = cajaPersona. ObtenerContenido();
Console.WriteLine($"Persona extraída: {personaExtraida.Nombre}"); // Ana

// Clase auxiliar para el ejemplo
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    
    public override string ToString()
    {
        return $"Persona: {Nombre} ({Edad} años)";
    }
}
```

#### 2.2.2. Parámetros de tipo único

El caso más común es una clase con un solo parámetro de tipo. Veamos más ejemplos prácticos:

**Ejemplo 1: Resultado de Operación (Result Pattern)**

```csharp
// Clase genérica que representa el resultado de una operación que puede fallar
public class Resultado<T>
{
    public bool Exito { get; private set; }
    public T Valor { get; private set; }
    public string MensajeError { get; private set; }
    // Constructor privado
    private Resultado(bool exito, T valor, string mensajeError)
    {
        Exito = exito;
        Valor = valor;
        MensajeError = mensajeError;
    }
    // Método estático para crear un resultado exitoso
    public static Resultado<T> CrearExito(T valor)
    {
        return new Resultado<T>(true, valor, null);
    }
    // Método estático para crear un resultado fallido
    public static Resultado<T> CrearError(string mensajeError)
    {
        return new Resultado<T>(false, default(T), mensajeError);
    }
    // Método para ejecutar una acción solo si el resultado fue exitoso
    public Resultado<T> SiExito(Action<T> accion)
    {
        if (Exito)
        {
            accion(Valor);
        }
        return this;
    }
    // Método para ejecutar una acción solo si hubo error
    public Resultado<T> SiError(Action<string> accion)
    {
        if (! Exito)
        {
            accion(MensajeError);
        }
        return this;
    }
}
// Uso del patrón Resultado

// Código ejecutable
// Operación exitosa
Resultado<int> resultadoDivision = Dividir(10, 2);

resultadoDivision
    .SiExito(valor => Console.WriteLine($"Resultado: {valor}"))
    .SiError(error => Console.WriteLine($"Error: {error}"));
// Salida:  Resultado: 5

// Operación con error
Resultado<int> resultadoError = Dividir(10, 0);

resultadoError
    .SiExito(valor => Console.WriteLine($"Resultado: {valor}"))
    .SiError(error => Console.WriteLine($"Error: {error}"));
// Salida: Error:  No se puede dividir por cero

// Funciones locales
Resultado<int> Dividir(int numerador, int denominador)
{
    if (denominador == 0)
    {
        return Resultado<int>.CrearError("No se puede dividir por cero");
    }
    
    return Resultado<int>.CrearExito(numerador / denominador);
}
```

**Ejemplo 2: Nodo de Lista Enlazada**

```csharp
// Nodo genérico para construir una lista enlazada
public class Nodo<T>
{
    public T Dato { get; set; }
    public Nodo<T> Siguiente { get; set; }
    public Nodo(T dato)
    {
        Dato = dato;
        Siguiente = null;
    }
    public override string ToString()
    {
        return $"Nodo({Dato})";
    }
}
// Lista enlazada simple genérica
public class ListaEnlazada<T>
{
    private Nodo<T> cabeza;
    private int contador;
    public int Cantidad => contador;
    // Agregar al inicio
    public void AgregarAlInicio(T dato)
    {
        Nodo<T> nuevoNodo = new Nodo<T>(dato);
        nuevoNodo.Siguiente = cabeza;
        cabeza = nuevoNodo;
        contador++;
    }
    // Agregar al final
    public void AgregarAlFinal(T dato)
    {
        Nodo<T> nuevoNodo = new Nodo<T>(dato);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo<T> actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual. Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
        contador++;
    }
    // Mostrar todos los elementos
    public void Mostrar()
    {
        Nodo<T> actual = cabeza;
        Console.Write("Lista:  ");
        while (actual != null)
        {
            Console. Write($"{actual.Dato} -> ");
            actual = actual. Siguiente;
        }
        Console.WriteLine("null");
    }
    // Buscar un elemento
    public bool Contiene(T dato)
    {
        Nodo<T> actual = cabeza;
        while (actual != null)
        {
            if (actual.Dato. Equals(dato))
            {
                return true;
            }
            actual = actual.Siguiente;
        }
        return false;
    }
}
// Uso de la lista enlazada genérica

// Código ejecutable
// Lista de enteros
ListaEnlazada<int> listaNumeros = new ListaEnlazada<int>();
listaNumeros.AgregarAlFinal(10);
listaNumeros.AgregarAlFinal(20);
listaNumeros.AgregarAlInicio(5);
listaNumeros. Mostrar();
// Salida: Lista: 5 -> 10 -> 20 -> null

Console.WriteLine($"¿Contiene 20? {listaNumeros. Contiene(20)}"); // True
Console.WriteLine($"¿Contiene 100? {listaNumeros. Contiene(100)}"); // False

Console.WriteLine();

// Lista de strings
ListaEnlazada<string> listaTextos = new ListaEnlazada<string>();
listaTextos.AgregarAlFinal("Hola");
listaTextos.AgregarAlFinal("Mundo");
listaTextos.AgregarAlInicio("¡");
listaTextos. Mostrar();
// Salida: Lista: ¡ -> Hola -> Mundo -> null
```

#### 2.2.3. Parámetros de tipo múltiples

No estamos limitados a usar un solo tipo genérico (T). Podemos manipular información relacionando distintos tipos de datos en un mismo método o clase. Por ejemplo, un método que transforma un tipo en otro o una clase que guarda un par de valores: public `class Pareja<T, U> { ... }`. Esto permite crear estructuras mucho más flexibles para procesar datos complejos sin necesidad de recurrir a la herencia.

```csharp
public class NombreClase<T1, T2, T3>
{
    // Usar T1, T2 y T3 como tipos
}

```

**Ejemplo 1: Par de valores (Tupla de 2 elementos)**

```csharp
// Clase genérica con dos parámetros de tipo
public class Par<T1, T2>
{
    public T1 Primero { get; set; }
    public T2 Segundo { get; set; }
    public Par(T1 primero, T2 segundo)
    {
        Primero = primero;
        Segundo = segundo;
    }
    // Deconstructor (permite usar deconstrucción)
    public void Deconstruct(out T1 primero, out T2 segundo)
    {
        primero = Primero;
        segundo = Segundo;
    }
    public override string ToString()
    {
        return $"({Primero}, {Segundo})";
    }
    // Método para intercambiar los valores
    public Par<T2, T1> Intercambiar()
    {
        return new Par<T2, T1>(Segundo, Primero);
    }
}
// Uso de la clase Par

// Código ejecutable
// Par de int y string
Par<int, string> par1 = new Par<int, string>(1, "Uno");
Console.WriteLine(par1); // (1, Uno)

// Acceso a los valores
Console.WriteLine($"Primero: {par1.Primero}, Segundo: {par1.Segundo}");

// Deconstrucción
var (numero, texto) = par1;
Console.WriteLine($"Número: {numero}, Texto: {texto}");

// Intercambiar
Par<string, int> par2 = par1.Intercambiar();
Console.WriteLine(par2); // (Uno, 1)

Console.WriteLine();

// Par de string y double (para coordenadas nombradas)
Par<string, double>[] coordenadas = new Par<string, double>[]
{
    new Par<string, double>("X", 10.5),
    new Par<string, double>("Y", 20.3),
    new Par<string, double>("Z", 5.7)
};

Console.WriteLine("Coordenadas:");
foreach (var coord in coordenadas)
{
    Console.WriteLine($"  {coord.Primero} = {coord.Segundo}");
}
```

**Ejemplo 2: Diccionario simple (estructura clave-valor)**

```csharp
// Entrada de diccionario con clave y valor genéricos
public class Entrada<TKey, TValue>
{
    public TKey Clave { get; set; }
    public TValue Valor { get; set; }
    public Entrada(TKey clave, TValue valor)
    {
        Clave = clave;
        Valor = valor;
    }
    public override string ToString()
    {
        return $"[{Clave}] => {Valor}";
    }
}
// Diccionario simple genérico
public class DiccionarioSimple<TKey, TValue>
{
    private Entrada<TKey, TValue>[] entradas;
    private int contador;
    public int Cantidad => contador;
    public DiccionarioSimple(int capacidadInicial = 10)
    {
        entradas = new Entrada<TKey, TValue>[capacidadInicial];
        contador = 0;
    }
    // Agregar o actualizar una entrada
    public void Agregar(TKey clave, TValue valor)
    {
        // Buscar si la clave ya existe
        for (int i = 0; i < contador; i++)
        {
            if (entradas[i]. Clave. Equals(clave))
            {
                // Actualizar valor existente
                entradas[i].Valor = valor;
                return;
            }
        }
        // Agregar nueva entrada
        if (contador == entradas.Length)
        {
            // Redimensionar el array
            Array.Resize(ref entradas, entradas.Length * 2);
        }
        entradas[contador] = new Entrada<TKey, TValue>(clave, valor);
        contador++;
    }

    // Obtener valor por clave
    public TValue Obtener(TKey clave)
    {
        for (int i = 0; i < contador; i++)
        {
            if (entradas[i]. Clave.Equals(clave))
            {
                return entradas[i].Valor;
            }
        }
        throw new KeyNotFoundException($"La clave '{clave}' no existe en el diccionario");
    }
    // Intentar obtener valor
    public bool TryGetValue(TKey clave, out TValue valor)
    {
        for (int i = 0; i < contador; i++)
        {
            if (entradas[i].Clave.Equals(clave))
            {
                valor = entradas[i]. Valor;
                return true;
            }
        }
        valor = default(TValue);
        return false;
    }
    // Verificar si existe una clave
    public bool ContieneClave(TKey clave)
    {
        for (int i = 0; i < contador; i++)
        {
            if (entradas[i].Clave.Equals(clave))
            {
                return true;
            }
        }
        return false;
    }
    // Mostrar todas las entradas
    public void Mostrar()
    {
        Console.WriteLine($"Diccionario ({contador} entradas):");
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"  {entradas[i]}");
        }
    }
}
// Uso del diccionario genérico

// Código ejecutable
// Diccionario de string a int (contar palabras)
DiccionarioSimple<string, int> contadorPalabras = new DiccionarioSimple<string, int>();

string[] palabras = { "hola", "mundo", "hola", "csharp", "mundo", "hola" };

foreach (string palabra in palabras)
{
    if (contadorPalabras. TryGetValue(palabra, out int cuenta))
    {
        contadorPalabras.Agregar(palabra, cuenta + 1);
    }
    else
    {
        contadorPalabras.Agregar(palabra, 1);
    }
}

contadorPalabras. Mostrar();
// Salida: 
// Diccionario (3 entradas):
//   [hola] => 3
//   [mundo] => 2
//   [csharp] => 1

Console.WriteLine();

// Diccionario de int a string (mapeo de códigos)
DiccionarioSimple<int, string> codigosEstado = new DiccionarioSimple<int, string>();
codigosEstado.Agregar(200, "OK");
codigosEstado.Agregar(404, "Not Found");
codigosEstado.Agregar(500, "Internal Server Error");

codigosEstado.Mostrar();

Console.WriteLine($"\nCódigo 404 significa: {codigosEstado. Obtener(404)}");
```

#### 2.2.4. Clases genéricas anidadas

Puedes tener clases genéricas dentro de otras clases genéricas, lo que permite estructuras de datos muy flexibles. 

```csharp
// Clase externa genérica
public class Coleccion<T>
{
    private T[] elementos;
    private int contador;
    public int Cantidad => contador;
    public Coleccion(int capacidadInicial = 10)
    {
        elementos = new T[capacidadInicial];
        contador = 0;
    }
    public void Agregar(T elemento)
    {
        if (contador == elementos.Length)
        {
            Array.Resize(ref elementos, elementos.Length * 2);
        }
        elementos[contador++] = elemento;
    }
    public T this[int indice]
    {
        get
        {
            if (indice < 0 || indice >= contador)
                throw new IndexOutOfRangeException();
            return elementos[indice];
        }
        set
        {
            if (indice < 0 || indice >= contador)
                throw new IndexOutOfRangeException();
            elementos[indice] = value;
        }
    }
    // Clase interna genérica (anidada)
    public class Iterador<TElemento>
    {
        private TElemento[] elementos;
        private int posicion;
        private int limite;
        public Iterador(TElemento[] elementos, int limite)
        {
            this. elementos = elementos;
            this. posicion = 0;
            this.limite = limite;
        }
        public bool TieneSiguiente()
        {
            return posicion < limite;
        }
        public TElemento Siguiente()
        {
            if (! TieneSiguiente())
            {
                throw new InvalidOperationException("No hay más elementos");
            }
            return elementos[posicion++];
        }
        public void Reiniciar()
        {
            posicion = 0;
        }
    }
    // Método que retorna un iterador
    public Iterador<T> ObtenerIterador()
    {
        return new Iterador<T>(elementos, contador);
    }
    // Otro ejemplo de clase anidada:  Nodo para una estructura de árbol
    public class NodoArbol<TValor>
    {
        public TValor Valor { get; set; }
        public NodoArbol<TValor> Izquierdo { get; set; }
        public NodoArbol<TValor> Derecho { get; set; }
        public NodoArbol(TValor valor)
        {
            Valor = valor;
            Izquierdo = null;
            Derecho = null;
        }
        public bool EsHoja()
        {
            return Izquierdo == null && Derecho == null;
        }
    }
}
// Uso de clases genéricas anidadas

// Código ejecutable
// Usar la colección y su iterador
Coleccion<string> nombres = new Coleccion<string>();
nombres.Agregar("Ana");
nombres.Agregar("Juan");
nombres.Agregar("María");
nombres.Agregar("Pedro");

Console.WriteLine("Iterando con el iterador personalizado:");
Coleccion<string>.Iterador<string> iterador = nombres.ObtenerIterador();

while (iterador.TieneSiguiente())
{
    Console. WriteLine($"  - {iterador.Siguiente()}");
}

Console.WriteLine("\nReiniciando iterador e iterando de nuevo:");
iterador.Reiniciar();

while (iterador. TieneSiguiente())
{
    Console.WriteLine($"  - {iterador.Siguiente()}");
}

Console.WriteLine();

// Usar el nodo de árbol anidado
Coleccion<int>. NodoArbol<int> raiz = new Coleccion<int>.NodoArbol<int>(10);
raiz.Izquierdo = new Coleccion<int>.NodoArbol<int>(5);
raiz.Derecho = new Coleccion<int>.NodoArbol<int>(15);
raiz.Izquierdo.Izquierdo = new Coleccion<int>.NodoArbol<int>(3);
raiz.Izquierdo.Derecho = new Coleccion<int>.NodoArbol<int>(7);

Console.WriteLine("Árbol binario:");
MostrarArbol(raiz, 0);

Console.WriteLine($"\n¿El nodo raíz es hoja? {raiz.EsHoja()}");
Console.WriteLine($"¿El nodo 3 es hoja? {raiz.Izquierdo. Izquierdo.EsHoja()}");
```

Salida:
```
Iterando con el iterador personalizado: 
  - Ana
  - Juan
  - María
  - Pedro

Reiniciando iterador e iterando de nuevo:
  - Ana
  - Juan
  - María
  - Pedro

Árbol binario:
        15
    10
            7
        5
            3

¿El nodo raíz es hoja? False
¿El nodo 3 es hoja? True
```

### 2.3. Métodos Genéricos

Los métodos genéricos son métodos que declaran sus propios parámetros de tipo, independientemente de si la clase que los contiene es genérica o no. 

#### 2.3.1. Sintaxis y casos de uso

La sintaxis básica de un método genérico es:

```csharp
public TipoRetorno NombreMetodo<T>(T parametro)
{
    // Usar T en el cuerpo del método
}

```

**Ejemplo básico:**

```csharp
public class UtilidadesGenericas
{
    // Método genérico que intercambia dos valores
    public static void Intercambiar<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
    // Método genérico que muestra información de un valor
    public static void MostrarInfo<T>(T valor)
    {
        Console.WriteLine($"Valor: {valor}");
        Console.WriteLine($"Tipo: {typeof(T).Name}");
        Console.WriteLine($"Tipo completo: {typeof(T).FullName}");
    }
    // Método genérico que retorna el primer elemento de un array
    public static T PrimerElemento<T>(T[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("El array no puede estar vacío");
        }
        return array[0];
    }
    // Método genérico que retorna el último elemento de un array
    public static T UltimoElemento<T>(T[] array)
    {
        if (array == null || array. Length == 0)
        {
            throw new ArgumentException("El array no puede estar vacío");
        }
        return array[array.Length - 1];
    }
}
// Uso de métodos genéricos

// Código ejecutable
// Intercambiar enteros
int num1 = 10;
int num2 = 20;
Console.WriteLine($"Antes: num1={num1}, num2={num2}");
UtilidadesGenericas. Intercambiar(ref num1, ref num2);
Console.WriteLine($"Después: num1={num1}, num2={num2}");

Console.WriteLine();

// Intercambiar strings
string texto1 = "Hola";
string texto2 = "Mundo";
Console. WriteLine($"Antes: texto1={texto1}, texto2={texto2}");
UtilidadesGenericas.Intercambiar(ref texto1, ref texto2);
Console.WriteLine($"Después: texto1={texto1}, texto2={texto2}");

Console.WriteLine();

// Mostrar información de diferentes tipos
UtilidadesGenericas.MostrarInfo(42);
Console.WriteLine();
UtilidadesGenericas.MostrarInfo("Hola");
Console.WriteLine();
UtilidadesGenericas.MostrarInfo(3.14);
Console.WriteLine();

// Primero y último elemento
int[] numeros = { 1, 2, 3, 4, 5 };
Console.WriteLine($"Primer número: {UtilidadesGenericas.PrimerElemento(numeros)}");
Console.WriteLine($"Último número: {UtilidadesGenericas.UltimoElemento(numeros)}");

string[] palabras = { "uno", "dos", "tres" };
Console.WriteLine($"Primera palabra: {UtilidadesGenericas.PrimerElemento(palabras)}");
Console.WriteLine($"Última palabra: {UtilidadesGenericas.UltimoElemento(palabras)}");
```

#### 2.3.2. Inferencia de tipos

Una de las características más útiles de los métodos genéricos es la **inferencia de tipos**. El compilador puede deducir automáticamente el tipo genérico a partir de los argumentos que pasas al método, sin necesidad de especificarlo explícitamente.

```csharp
public class UtilidadesInferencia
{
    // Método genérico simple
    public static void Imprimir<T>(T valor)
    {
        Console.WriteLine($"Valor: {valor}, Tipo: {typeof(T).Name}");
    }
    // Método genérico que retorna un array
    public static T[] CrearArray<T>(T valor1, T valor2, T valor3)
    {
        return new T[] { valor1, valor2, valor3 };
    }
    // Método genérico que compara dos valores
    public static bool SonIguales<T>(T a, T b)
    {
        return a. Equals(b);
    }
}

// Código ejecutable
// Inferencia de tipos:  el compilador deduce que T es int
UtilidadesInferencia. Imprimir(42);
// Equivalente explícito: UtilidadesInferencia.Imprimir<int>(42);

// Inferencia de tipos: el compilador deduce que T es string
UtilidadesInferencia.Imprimir("Hola");
// Equivalente explícito: UtilidadesInferencia.Imprimir<string>("Hola");

// Crear array con inferencia de tipos
int[] numeros = UtilidadesInferencia.CrearArray(1, 2, 3);
// Equivalente explícito: UtilidadesInferencia. CrearArray<int>(1, 2, 3);

string[] palabras = UtilidadesInferencia.CrearArray("uno", "dos", "tres");

// Comparar con inferencia de tipos
bool iguales1 = UtilidadesInferencia.SonIguales(10, 10); // true
bool iguales2 = UtilidadesInferencia.SonIguales("Hola", "Mundo"); // false

Console.WriteLine($"10 == 10: {iguales1}");
Console.WriteLine($"'Hola' == 'Mundo': {iguales2}");
```

La inferencia de tipos funciona cuando el compilador puede deducir sin ambigüedad el tipo a partir de los argumentos.  Si hay ambigüedad o el método no tiene parámetros del tipo genérico, debes especificar el tipo explícitamente.

```csharp
public class EjemplosInferencia
{
    // Método sin parámetros del tipo genérico
    public static T CrearValorPorDefecto<T>()
    {
        return default(T);
    }
    // Método con múltiples tipos genéricos
    public static void ProcesarPar<T1, T2>(T1 primero, T2 segundo)
    {
        Console.WriteLine($"Primero: {primero} (tipo {typeof(T1).Name})");
        Console.WriteLine($"Segundo: {segundo} (tipo {typeof(T2).Name})");
    }
}

// Código ejecutable
// Aquí DEBES especificar el tipo explícitamente porque no hay parámetros
int valorInt = EjemplosInferencia.CrearValorPorDefecto<int>();
string valorString = EjemplosInferencia.CrearValorPorDefecto<string>();

Console.WriteLine($"Valor int por defecto: {valorInt}"); // 0
Console.WriteLine($"Valor string por defecto: {valorString ??  "null"}"); // null

// Con múltiples tipos genéricos, el compilador puede inferir ambos
EjemplosInferencia.ProcesarPar(42, "Hola");
// Equivalente explícito: EjemplosInferencia.ProcesarPar<int, string>(42, "Hola");

EjemplosInferencia.ProcesarPar(3.14, true);
// Equivalente explícito: EjemplosInferencia.ProcesarPar<double, bool>(3.14, true);
```

#### 2.3.3. Métodos genéricos en clases no genéricas

Un método genérico puede existir en una clase no genérica.  Esto es muy útil cuando solo necesitas que un método específico sea genérico, no toda la clase.

```csharp
// Clase NO genérica con métodos genéricos
public class Utilidades
{
    // Método genérico que convierte a array
    public T[] ConvertirAArray<T>(T elemento, int cantidad)
    {
        T[] array = new T[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            array[i] = elemento;
        }
        return array;
    }
    // Método genérico que busca un elemento
    public int BuscarIndice<T>(T[] array, T elementoBuscado)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]. Equals(elementoBuscado))
            {
                return i;
            }
        }
        return -1;
    }
    // Método genérico que cuenta ocurrencias
    public int ContarOcurrencias<T>(T[] array, T elementoBuscado)
    {
        int contador = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(elementoBuscado))
            {
                contador++;
            }
        }
        return contador;
    }
}

// Código ejecutable
Utilidades util = new Utilidades();

// Crear array de elementos repetidos
int[] numerosRepetidos = util.ConvertirAArray(7, 5);
Console.WriteLine($"Array de 7 repetido 5 veces: [{string.Join(", ", numerosRepetidos)}]");

string[] textosRepetidos = util.ConvertirAArray("Hola", 3);
Console.WriteLine($"Array de 'Hola' repetido 3 veces: [{string.Join(", ", textosRepetidos)}]");

Console.WriteLine();

// Buscar índice
int[] numeros = { 10, 20, 30, 40, 50 };
int indice = util.BuscarIndice(numeros, 30);
Console.WriteLine($"El número 30 está en el índice: {indice}");

string[] palabras = { "uno", "dos", "tres", "dos", "cuatro" };
int indiceStr = util.BuscarIndice(palabras, "dos");
Console.WriteLine($"La palabra 'dos' está en el índice: {indiceStr}");

Console.WriteLine();

// Contar ocurrencias
int ocurrencias = util.ContarOcurrencias(palabras, "dos");
Console.WriteLine($"La palabra 'dos' aparece {ocurrencias} veces");
```

#### 2.3.4. Métodos genéricos estáticos

Los métodos genéricos pueden ser estáticos, lo cual es muy común para métodos de utilidad que no necesitan estado de instancia.

```csharp
public class OperacionesArray
{
    // Método estático genérico que invierte un array
    public static void Invertir<T>(T[] array)
    {
        int izquierda = 0;
        int derecha = array.Length - 1;
        while (izquierda < derecha)
        {
            T temp = array[izquierda];
            array[izquierda] = array[derecha];
            array[derecha] = temp;
            izquierda++;
            derecha--;
        }
    }
    // Método estático genérico que copia un array
    public static T[] Copiar<T>(T[] original)
    {
        T[] copia = new T[original.Length];
        for (int i = 0; i < original.Length; i++)
        {
            copia[i] = original[i];
        }
        return copia;
    }
    // Método estático genérico que combina dos arrays
    public static T[] Concatenar<T>(T[] array1, T[] array2)
    {
        T[] resultado = new T[array1.Length + array2.Length];
        // Copiar primer array
        for (int i = 0; i < array1.Length; i++)
        {
            resultado[i] = array1[i];
        }
        // Copiar segundo array
        for (int i = 0; i < array2.Length; i++)
        {
            resultado[array1.Length + i] = array2[i];
        }
        return resultado;
    }
    // Método estático genérico que obtiene una subsección
    public static T[] ObtenerSubArray<T>(T[] array, int inicio, int longitud)
    {
        if (inicio < 0 || inicio >= array.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(inicio));
        }
        if (inicio + longitud > array.Length)
        {
            throw new ArgumentException("La longitud excede los límites del array");
        }
        T[] subArray = new T[longitud];
        for (int i = 0; i < longitud; i++)
        {
            subArray[i] = array[inicio + i];
        }
        return subArray;
    }
    // Método estático genérico que llena un array con un valor
    public static void Llenar<T>(T[] array, T valor)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = valor;
        }
    }
}

// Código ejecutable
// Invertir array de enteros
int[] numeros = { 1, 2, 3, 4, 5 };
Console.WriteLine($"Original: [{string.Join(", ", numeros)}]");
OperacionesArray.Invertir(numeros);
Console.WriteLine($"Invertido: [{string.Join(", ", numeros)}]");

Console.WriteLine();

// Copiar array de strings
string[] palabras = { "uno", "dos", "tres" };
string[] palabrasCopia = OperacionesArray.Copiar(palabras);
Console.WriteLine($"Original: [{string.Join(", ", palabras)}]");
Console.WriteLine($"Copia: [{string.Join(", ", palabrasCopia)}]");

Console.WriteLine();

// Concatenar arrays
int[] array1 = { 1, 2, 3 };
int[] array2 = { 4, 5, 6 };
int[] concatenado = OperacionesArray. Concatenar(array1, array2);
Console.WriteLine($"Concatenado: [{string.Join(", ", concatenado)}]");

Console.WriteLine();

// Obtener subarray
int[] numerosGrandes = { 10, 20, 30, 40, 50, 60, 70 };
int[] subArray = OperacionesArray.ObtenerSubArray(numerosGrandes, 2, 3);
Console.WriteLine($"SubArray (desde índice 2, longitud 3): [{string.Join(", ", subArray)}]");

Console.WriteLine();

// Llenar array
int[] arrayVacio = new int[5];
OperacionesArray.Llenar(arrayVacio, 99);
Console.WriteLine($"Array llenado con 99: [{string.Join(", ", arrayVacio)}]");
```



---

### 2.4. Varianza en Genéricos

La varianza es uno de los conceptos más avanzados y potentes de los genéricos en C#. Nos permite definir cómo se relacionan los tipos genéricos entre sí cuando hay jerarquías de herencia.

#### 2.4.1. Conceptos Fundamentales

**Tipos y subtipos**

En programación orientada a objetos, tenemos relaciones de herencia entre tipos.  Por ejemplo: 

```csharp
// Jerarquía de clases
public class Animal
{
    public string Nombre { get; set; }
    
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}

public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console. WriteLine("Guau guau");
    }
}

public class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Miau miau");
    }
}

```

Sabemos que podemos hacer esto: 

```csharp
Animal animal = new Perro(); // Un Perro ES UN Animal
animal.HacerSonido(); // Guau guau

```

Esto funciona porque `Perro` es un subtipo de `Animal`.

**¿Qué es la varianza?**

La varianza describe cómo se relacionan los tipos genéricos cuando hay relaciones de herencia entre sus parámetros de tipo. Hay tres tipos de varianza:

1. **Invarianza**: No hay relación entre `Contenedor<Perro>` y `Contenedor<Animal>`
2. **Covarianza**: `Contenedor<Perro>` puede usarse como `Contenedor<Animal>` (producción/salida)
3. **Contravarianza**: `Contenedor<Animal>` puede usarse como `Contenedor<Perro>` (consumo/entrada)

**Importancia en el diseño de APIs**

La varianza es fundamental para: 
- Diseñar interfaces y delegates flexibles
- Permitir polimorfismo con tipos genéricos
- Crear código más reutilizable y expresivo
- Evitar duplicación de código

#### 2.4.2. Invarianza (comportamiento por defecto)

Por defecto, los tipos genéricos en C# son **invariantes**. Esto significa que no existe relación de conversión entre tipos genéricos aunque sus parámetros de tipo estén relacionados.

```csharp
public class Caja<T>
{
    public T Contenido { get; set; }
    public Caja(T contenido)
    {
        Contenido = contenido;
    }
}

// Código ejecutable
// Esto funciona:  Perro es subtipo de Animal
Animal animal = new Perro();
animal.HacerSonido();

// Pero esto NO funciona: Caja<Perro> NO es subtipo de Caja<Animal>
Caja<Perro> cajaPerro = new Caja<Perro>(new Perro());
// Caja<Animal> cajaAnimal = cajaPerro; // ERROR de compilación

// Esto se debe a que Caja<T> es invariante
```

**¿Por qué la invarianza es el comportamiento por defecto?**

La razón es la seguridad de tipos. Si permitiéramos esto:

```csharp
Caja<Perro> cajaPerro = new Caja<Perro>(new Perro());
Caja<Animal> cajaAnimal = cajaPerro; // Si esto fuera posible... 
cajaAnimal. Contenido = new Gato();   // ¡Podríamos poner un Gato en una caja de Perros! 
Perro perro = cajaPerro.Contenido;   // ¡ERROR en tiempo de ejecución!

```

**Limitaciones con tipos genéricos invariantes**

```csharp
public class ContenedorInvariante<T>
{
    private T[] elementos;
    private int contador;
    public ContenedorInvariante(int capacidad)
    {
        elementos = new T[capacidad];
        contador = 0;
    }
    // Podemos tanto leer como escribir
    public void Agregar(T elemento)
    {
        elementos[contador++] = elemento;
    }
    public T Obtener(int indice)
    {
        return elementos[indice];
    }
}

// Código ejecutable
ContenedorInvariante<Perro> contenedorPerros = new ContenedorInvariante<Perro>(10);
contenedorPerros.Agregar(new Perro { Nombre = "Firulais" });
contenedorPerros.Agregar(new Perro { Nombre = "Rex" });
contenedorPerros.Agregar(new Perro { Nombre = "Buddy" });

// Esto NO funciona debido a la invarianza
// ProcesarAnimales(contenedorPerros); // ERROR de compilación

// Tendríamos que crear una versión específica para Perro
// o duplicar el código

// Funciones locales
void ProcesarAnimales(ContenedorInvariante<Animal> contenedor)
{
    // Trabajar con animales
    for (int i = 0; i < 3; i++)
    {
        Animal animal = contenedor.Obtener(i);
        animal.HacerSonido();
    }
}
```

**Cuándo aplicar invarianza**

La invarianza es apropiada cuando:
- Tu tipo genérico permite tanto lectura como escritura
- Necesitas garantizar la seguridad de tipos completa
- Trabajas con colecciones mutables

#### 2.4.3. Covarianza (`out`)

La **covarianza** permite que un tipo genérico con un parámetro de tipo más derivado se use donde se espera un tipo genérico con un parámetro de tipo más general.

Se declara usando la palabra clave `out` en la definición del parámetro de tipo. 

**Características de la covarianza:**
- El tipo genérico solo puede **producir/devolver** valores del tipo `T` (salida)
- NO puede **aceptar/consumir** valores del tipo `T` como parámetros de entrada
- Solo funciona con tipos de referencia (interfaces y delegates)

```csharp
// Interfaz covariante:  solo produce valores de T
public interface IProductor<out T>
{
    T Producir();           // ✓ Permitido:  devuelve T
    // void Consumir(T item);  // ✗ NO permitido: acepta T como parámetro
}
// Implementación para Animal
public class ProductorAnimal : IProductor<Animal>
{
    public Animal Producir()
    {
        return new Animal { Nombre = "Animal genérico" };
    }
}
// Implementación para Perro
public class ProductorPerro : IProductor<Perro>
{
    public Perro Producir()
    {
        return new Perro { Nombre = "Firulais" };
    }
}

// Código ejecutable
// Gracias a la covarianza, esto funciona
IProductor<Perro> productorPerro = new ProductorPerro();
IProductor<Animal> productorAnimal = productorPerro; // ✓ Conversión válida

// Podemos pasar un IProductor<Perro> donde se espera IProductor<Animal>
ProcesarProductor(productorPerro); // ✓ Funciona gracias a covarianza

IProductor<Gato> productorGato = new ProductorGato();
ProcesarProductor(productorGato); // ✓ También funciona

// Funciones locales
void ProcesarProductor(IProductor<Animal> productor)
{
    Animal animal = productor.Producir();
    Console.WriteLine($"Animal producido: {animal.Nombre}");
    animal.HacerSonido();
}


public class Gato : Animal
{
    public override void HacerSonido()
    {
        Console. WriteLine("Miau miau");
    }
}

public class ProductorGato : IProductor<Gato>
{
    public Gato Producir()
    {
        return new Gato { Nombre = "Michi" };
    }
}
```

**Ejemplo práctico: Repositorio de solo lectura**

```csharp
// Interfaz covariante para repositorio de solo lectura
public interface IRepositorioLectura<out T>
{
    T ObtenerPorId(int id);
    T[] ObtenerTodos();
    int Contar();
}
// Implementación para Perro
public class RepositorioPerros : IRepositorioLectura<Perro>
{
    private Perro[] perros;
    public RepositorioPerros()
    {
        perros = new Perro[]
        {
            new Perro { Nombre = "Firulais" },
            new Perro { Nombre = "Rex" },
            new Perro { Nombre = "Buddy" }
        };
    }
    public Perro ObtenerPorId(int id)
    {
        return perros[id];
    }
    public Perro[] ObtenerTodos()
    {
        return perros;
    }
    public int Contar()
    {
        return perros.Length;
    }
}

// Código ejecutable
    IRepositorioLectura<Perro> repoPerros = new RepositorioPerros();
    
    // Gracias a la covarianza, podemos usar un repositorio de Perros
    // donde se espera un repositorio de Animales
    MostrarAnimales(repoPerros); // ✓ Funciona

// Funciones locales
void MostrarAnimales(IRepositorioLectura<Animal> repositorio)
{
    Console.WriteLine($"Total de animales: {repositorio. Contar()}");
    
    Animal[] animales = repositorio.ObtenerTodos();
    foreach (Animal animal in animales)
    {
        Console.WriteLine($"- {animal. Nombre}");
        animal.HacerSonido();
    }
}
```

**Restricciones de covarianza**

Solo en posición de salida: 

```csharp
public interface ICovariante<out T>
{
    // ✓ Permitido: T en posición de retorno
    T Obtener();
    T[] ObtenerArray();
    IEnumerable<T> ObtenerEnumerable();
    
    // ✗ NO permitido: T en posición de parámetro
    // void Establecer(T valor);
    // void Procesar(T item);
    
    // ✓ Permitido: T dentro de otro tipo genérico covariante
    IEnumerable<T> ObtenerColeccion();
    
    // ✗ NO permitido: T dentro de tipo genérico invariante
    // List<T> ObtenerLista();
}

```

**Ejemplos prácticos con jerarquías de clases**

```csharp
// Jerarquía más completa
public class Animal
{
    public string Nombre { get; set; }
    public virtual void HacerSonido() => Console.WriteLine("Sonido genérico");
}
public class Mamifero : Animal
{
    public override void HacerSonido() => Console.WriteLine("Sonido de mamífero");
}
public class Perro : Mamifero
{
    public override void HacerSonido() => Console.WriteLine("Guau guau");
}
public class Chihuahua : Perro
{
    public override void HacerSonido() => Console.WriteLine("Yip yip");
}
// Interfaz covariante
public interface IFabrica<out T> where T : Animal
{
    T Crear(string nombre);
    T[] CrearMultiples(int cantidad);
}
public class FabricaChihuahuas : IFabrica<Chihuahua>
{
    public Chihuahua Crear(string nombre)
    {
        return new Chihuahua { Nombre = nombre };
    }
    public Chihuahua[] CrearMultiples(int cantidad)
    {
        Chihuahua[] chihuahuas = new Chihuahua[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            chihuahuas[i] = new Chihuahua { Nombre = $"Chihuahua-{i + 1}" };
        }
        return chihuahuas;
    }
}

// Código ejecutable
IFabrica<Chihuahua> fabricaChihuahuas = new FabricaChihuahuas();

// Gracias a la covarianza, podemos usar la fábrica de Chihuahuas
// en todos estos contextos
UsarFabricaDeAnimales(fabricaChihuahuas);   // ✓ Chihuahua → Animal
UsarFabricaDeMamiferos(fabricaChihuahuas);  // ✓ Chihuahua → Mamifero
UsarFabricaDePerros(fabricaChihuahuas);     // ✓ Chihuahua → Perro

// Funciones locales
void UsarFabricaDeAnimales(IFabrica<Animal> fabrica)
{
    Animal animal = fabrica.Crear("Ejemplo");
    Console.WriteLine($"Animal creado: {animal.Nombre}");
    animal.HacerSonido();
}

void UsarFabricaDeMamiferos(IFabrica<Mamifero> fabrica)
{
    Mamifero mamifero = fabrica.Crear("Ejemplo");
    Console.WriteLine($"Mamífero creado: {mamifero.Nombre}");
    mamifero.HacerSonido();
}

void UsarFabricaDePerros(IFabrica<Perro> fabrica)
{
    Perro perro = fabrica.Crear("Ejemplo");
    Console.WriteLine($"Perro creado: {perro. Nombre}");
    perro.HacerSonido();
}
```

#### 2.4.4. Contravarianza (`in`)

La **contravarianza** es lo opuesto a la covarianza. Permite que un tipo genérico con un parámetro de tipo más general se use donde se espera un tipo genérico con un parámetro de tipo más derivado.

Se declara usando la palabra clave `in` en la definición del parámetro de tipo.

**Características de la contravarianza:**
- El tipo genérico solo puede **consumir/aceptar** valores del tipo `T` (entrada)
- NO puede **producir/devolver** valores del tipo `T` como resultado
- Solo funciona con tipos de referencia (interfaces y delegates)

```csharp
// Interfaz contravariante: solo consume valores de T
public interface IConsumidor<in T>
{
    void Consumir(T item);      // ✓ Permitido: acepta T como parámetro
    // T Producir();            // ✗ NO permitido: devuelve T
}
// Implementación para Animal
public class ConsumidorAnimal :  IConsumidor<Animal>
{
    public void Consumir(Animal animal)
    {
        Console.WriteLine($"Procesando animal: {animal.Nombre}");
        animal.HacerSonido();
    }
}
// Implementación para Perro
public class ConsumidorPerro : IConsumidor<Perro>
{
    public void Consumir(Perro perro)
    {
        Console.WriteLine($"Procesando perro: {perro.Nombre}");
        perro.HacerSonido();
    }
}

// Código ejecutable
Perro[] perros = new Perro[]
{
    new Perro { Nombre = "Firulais" },
    new Perro { Nombre = "Rex" }
};

// Un consumidor de Animal puede consumir Perros
IConsumidor<Animal> consumidorAnimal = new ConsumidorAnimal();
IConsumidor<Perro> consumidorPerro = consumidorAnimal; // ✓ Conversión válida

// Gracias a la contravarianza, esto funciona
ProcesarPerros(consumidorAnimal, perros); // ✓ Funciona

// Funciones locales
void ProcesarPerros(IConsumidor<Perro> consumidor, Perro[] perros)
{
    foreach (Perro perro in perros)
    {
        consumidor.Consumir(perro);
    }
}
```

**¿Por qué funciona la contravarianza?**

Si tienes un `IConsumidor<Animal>`, significa que puede procesar cualquier `Animal`. Como `Perro` es un `Animal`, entonces ese consumidor también puede procesar `Perro`. Por lo tanto, tiene sentido que `IConsumidor<Animal>` se pueda usar como `IConsumidor<Perro>`.

**Ejemplo práctico: Comparador**

```csharp
// Interfaz contravariante para comparadores
public interface IComparadorPersonalizado<in T>
{
    int Comparar(T x, T y);
    bool SonIguales(T x, T y);
}
// Comparador de animales por nombre
public class ComparadorAnimales : IComparadorPersonalizado<Animal>
{
    public int Comparar(Animal x, Animal y)
    {
        return string.Compare(x.Nombre, y.Nombre, StringComparison. Ordinal);
    }
    public bool SonIguales(Animal x, Animal y)
    {
        return x. Nombre == y.Nombre;
    }
}

// Código ejecutable
Perro[] perros = new Perro[]
{
    new Perro { Nombre = "Rex" },
    new Perro { Nombre = "Buddy" },
    new Perro { Nombre = "Firulais" }
};

Console.WriteLine("Antes de ordenar:");
foreach (Perro p in perros)
{
    Console.WriteLine($"- {p.Nombre}");
}

// Gracias a la contravarianza, podemos usar un comparador de Animal
// para ordenar Perros
IComparadorPersonalizado<Animal> comparadorAnimal = new ComparadorAnimales();
OrdenarPerros(perros, comparadorAnimal); // ✓ Funciona

Console.WriteLine("\nDespués de ordenar:");
foreach (Perro p in perros)
{
    Console.WriteLine($"- {p. Nombre}");
}

// Funciones locales
void OrdenarPerros(Perro[] perros, IComparadorPersonalizado<Perro> comparador)
{
    // Ordenamiento burbuja simple
    for (int i = 0; i < perros.Length - 1; i++)
    {
        for (int j = 0; j < perros.Length - i - 1; j++)
        {
            if (comparador.Comparar(perros[j], perros[j + 1]) > 0)
            {
                Perro temp = perros[j];
                perros[j] = perros[j + 1];
                perros[j + 1] = temp;
            }
        }
    }
}
```

**Restricciones de contravarianza**

Solo en posición de entrada:

```csharp
public interface IContravariante<in T>
{
    // ✓ Permitido:  T en posición de parámetro
    void Procesar(T item);
    void ProcesarMultiples(T[] items);
    void ComparCon(T otro);
    
    // ✗ NO permitido: T en posición de retorno
    // T Obtener();
    // T[] ObtenerArray();
    
    // ✓ Permitido: T dentro de Action (que es contravariante)
    void EjecutarAccion(Action<T> accion);
    
    // ✗ NO permitido: T dentro de Func (covariante en el resultado)
    // void EjecutarFunc(Func<T> func);
}

```

**Ejemplo práctico con jerarquías**

```csharp
// Interfaz contravariante para validadores
public interface IValidador<in T>
{
    bool EsValido(T item);
    string ObtenerMensajeError(T item);
}
// Validador genérico de animales
public class ValidadorAnimal : IValidador<Animal>
{
    public bool EsValido(Animal animal)
    {
        return ! string.IsNullOrWhiteSpace(animal.Nombre) && 
               animal.Nombre.Length >= 2;
    }
    public string ObtenerMensajeError(Animal animal)
    {
        if (string.IsNullOrWhiteSpace(animal.Nombre))
            return "El nombre no puede estar vacío";
        if (animal.Nombre.Length < 2)
            return "El nombre debe tener al menos 2 caracteres";
        return "Válido";
    }
}
// Validador específico de perros (más estricto)
public class ValidadorPerro : IValidador<Perro>
{
    public bool EsValido(Perro perro)
    {
        return ! string.IsNullOrWhiteSpace(perro.Nombre) && 
               perro. Nombre.Length >= 3 &&
               perro.Nombre. Length <= 20;
    }
    public string ObtenerMensajeError(Perro perro)
    {
        if (string.IsNullOrWhiteSpace(perro.Nombre))
            return "El nombre del perro no puede estar vacío";
        if (perro. Nombre.Length < 3)
            return "El nombre del perro debe tener al menos 3 caracteres";
        if (perro.Nombre.Length > 20)
            return "El nombre del perro no puede superar los 20 caracteres";
        return "Válido";
    }
}

// Código ejecutable
Chihuahua[] chihuahuas = new Chihuahua[]
{
    new Chihuahua { Nombre = "Tiny" },
    new Chihuahua { Nombre = "P" },      // Inválido (muy corto)
    new Chihuahua { Nombre = "" }        // Inválido (vacío)
};

Console.WriteLine("=== Validación con ValidadorAnimal ===");
IValidador<Animal> validadorAnimal = new ValidadorAnimal();
ValidarChihuahuas(chihuahuas, validadorAnimal); // ✓ Funciona

Console.WriteLine("\n=== Validación con ValidadorPerro ===");
IValidador<Perro> validadorPerro = new ValidadorPerro();
ValidarChihuahuas(chihuahuas, validadorPerro); // ✓ Funciona

// Gracias a la contravarianza: 
// - IValidador<Animal> puede validar Chihuahuas
// - IValidador<Perro> puede validar Chihuahuas
// Porque Chihuahua ES UN Perro ES UN Animal

// Funciones locales
void ValidarChihuahuas(Chihuahua[] chihuahuas, IValidador<Chihuahua> validador)
{
    foreach (Chihuahua chihuahua in chihuahuas)
    {
        bool esValido = validador.EsValido(chihuahua);
        string mensaje = validador.ObtenerMensajeError(chihuahua);
        
        Console.WriteLine($"Chihuahua '{chihuahua.Nombre}':  {(esValido ? "✓" : "✗")} - {mensaje}");
    }
}
```

#### 2.4.5. Tabla Comparativa y Guía de Uso

**Tabla comparativa de varianza:**

| Aspecto               | Invarianza        | Covarianza (`out`) | Contravarianza (`in`) |
| --------------------- | ----------------- | ------------------ | --------------------- |
| **Palabra clave**     | Ninguna           | `out`              | `in`                  |
| **Conversión**        | No hay conversión | De derivado a base | De base a derivado    |
| **Uso del parámetro** | Entrada y salida  | Solo salida        | Solo entrada          |
| **Ejemplo típico**    | `List<T>`         | `IEnumerable<T>`   | `IComparer<T>`        |
| **Delegates**         | `Func<T, T>`      | `Func<T>`          | `Action<T>`           |
| **Seguridad**         | Máxima            | Alta               | Alta                  |
| **Flexibilidad**      | Mínima            | Media              | Media                 |

**Cuándo usar cada tipo de varianza:**

**Usar Invarianza cuando:**
- Necesitas tanto leer como escribir el tipo genérico
- Trabajas con colecciones mutables
- La seguridad de tipos es crítica y no puedes comprometer
- Ejemplo: `List<T>`, `Dictionary<K,V>`, clases genéricas con estado mutable

**Usar Covarianza (`out`) cuando:**
- Solo produces/devuelves valores del tipo genérico
- Trabajas con colecciones de solo lectura
- Quieres flexibilidad al devolver tipos más específicos
- Ejemplo: `IEnumerable<T>`, `IReadOnlyList<T>`, fábricas, repositorios de lectura

**Usar Contravarianza (`in`) cuando:**
- Solo consumes/aceptas valores del tipo genérico como parámetros
- Trabajas con comparadores, validadores, procesadores
- Quieres flexibilidad al aceptar tipos más generales
- Ejemplo: `IComparer<T>`, `Action<T>`, validadores, manejadores

**Reglas nemotécnicas:**

1. **Covarianza (out)**: 
   - "**Out**put" (salida)
   - Piensa en una **caja que solo produce**:  puedes sacar cosas más específicas y tratarlas como más generales
   - `IProductor<Perro>` → `IProductor<Animal>` (sale un Perro, lo tratas como Animal)

2. **Contravarianza (in)**:
   - "**In**put" (entrada)
   - Piensa en una **máquina que solo consume**: si procesa animales, puede procesar perros
   - `IConsumidor<Animal>` → `IConsumidor<Perro>` (entra un Perro, se procesa como Animal)

**Errores comunes:**

```csharp
// ❌ ERROR: Intentar usar 'out' en posición de entrada
public interface IIncorrecto1<out T>
{
    void Agregar(T item); // ERROR: T está en posición de entrada
}

// ❌ ERROR: Intentar usar 'in' en posición de salida
public interface IIncorrecto2<in T>
{
    T Obtener(); // ERROR: T está en posición de salida
}

// ✓ CORRECTO: Invariante (sin out ni in) permite ambos
public interface ICorrecto1<T>
{
    void Agregar(T item);
    T Obtener();
}

// ✓ CORRECTO:  Covariante solo en salida
public interface ICorrecto2<out T>
{
    T Obtener();
    IEnumerable<T> ObtenerTodos();
}

// ✓ CORRECTO: Contravariante solo en entrada
public interface ICorrecto3<in T>
{
    void Agregar(T item);
    void Procesar(T item);
}

```

**Ejemplo integrador de los tres tipos:**

```csharp
// Invariante:  permite lectura y escritura
public class Repositorio<T>
{
    private List<T> items = new List<T>();
    public void Agregar(T item) => items.Add(item);
    public T Obtener(int indice) => items[indice];
}
// Covariante: solo lectura
public interface IRepositorioLectura<out T>
{
    T Obtener(int indice);
    IEnumerable<T> ObtenerTodos();
}
// Contravariante: solo escritura
public interface IRepositorioEscritura<in T>
{
    void Agregar(T item);
    void Actualizar(int indice, T item);
}
// Combinación:  usa ambos separadamente
public interface IRepositorioCompleto<T> : 
    IRepositorioLectura<T>, 
    IRepositorioEscritura<T>
{
    // T aparece tanto en entrada como en salida en interfaces separadas
    // pero la interfaz combinada es invariante
}

// Código ejecutable
// Repositorio invariante
Repositorio<Perro> repoPerros = new Repositorio<Perro>();
repoPerros.Agregar(new Perro { Nombre = "Firulais" });

// Si implementamos las interfaces variantes... 
// IRepositorioLectura<Perro> lectura = repoPerros;
// LeerAnimales(lectura); // ✓ Funciona por covarianza

// IRepositorioEscritura<Animal> escritura = new RepositorioEscrituraAnimal();
// EscribirPerros(escritura); // ✓ Funciona por contravarianza

// Funciones locales
void LeerAnimales(IRepositorioLectura<Animal> repo)
{
    foreach (Animal animal in repo.ObtenerTodos())
    {
        Console.WriteLine($"- {animal.Nombre}");
    }
}

void EscribirPerros(IRepositorioEscritura<Perro> repo)
{
    repo.Agregar(new Perro { Nombre = "Nuevo perro" });
}
```

---

### 2.5. Restricciones de Tipos (Constraints)

Las **restricciones de tipos** (type constraints) permiten especificar requisitos que debe cumplir un parámetro de tipo genérico.  Esto te da más control y seguridad al trabajar con genéricos.

#### 2.5.1. Restricciones básicas

**`where T : class` (tipo referencia)**

Restringe el tipo genérico a tipos de referencia (clases, interfaces, delegates, arrays).

```csharp
// Solo acepta tipos de referencia
public class ContenedorReferencia<T> where T : class
{
    private T item;
    public ContenedorReferencia(T item)
    {
        this.item = item;
    }
    public bool EsNulo()
    {
        return item == null; // Esto solo tiene sentido con tipos de referencia
    }
    public T ObtenerOPorDefecto()
    {
        return item ?? default(T); // null para tipos de referencia
    }
}

// Código ejecutable
// ✓ Funciona: string es tipo de referencia
ContenedorReferencia<string> contenedor1 = new ContenedorReferencia<string>("Hola");

// ✓ Funciona:  Persona es tipo de referencia (clase)
ContenedorReferencia<Persona> contenedor2 = new ContenedorReferencia<Persona>(null);
Console.WriteLine($"¿Es nulo? {contenedor2.EsNulo()}"); // True

// ✗ NO funciona: int es tipo de valor
// ContenedorReferencia<int> contenedor3 = new ContenedorReferencia<int>(42); // ERROR
```

**`where T : struct` (tipo valor)**

Restringe el tipo genérico a tipos de valor (int, double, bool, enum, struct, etc.). Excluye `Nullable<T>`.

```csharp
// Solo acepta tipos de valor
public class ContenedorValor<T> where T : struct
{
    private T valor;
    public ContenedorValor(T valor)
    {
        this.valor = valor;
    }
    public T Valor => valor;
    // Con tipos de valor, podemos hacer operaciones específicas
    public Nullable<T> ObtenerNullable()
    {
        return new Nullable<T>(valor);
    }
    public int TamañoEnBytes()
    {
        return System.Runtime.InteropServices.Marshal.SizeOf(valor);
    }
}

// Código ejecutable
// ✓ Funciona: int es tipo de valor
ContenedorValor<int> contenedor1 = new ContenedorValor<int>(42);
Console.WriteLine($"Valor: {contenedor1.Valor}");
Console.WriteLine($"Tamaño: {contenedor1.TamañoEnBytes()} bytes");

// ✓ Funciona:  DateTime es tipo de valor (struct)
ContenedorValor<DateTime> contenedor2 = new ContenedorValor<DateTime>(DateTime.Now);

// ✓ Funciona: bool es tipo de valor
ContenedorValor<bool> contenedor3 = new ContenedorValor<bool>(true);

// ✗ NO funciona: string es tipo de referencia
// ContenedorValor<string> contenedor4 = new ContenedorValor<string>("Hola"); // ERROR
```

**`where T : new()` (constructor sin parámetros)**

Restringe el tipo genérico a tipos que tengan un constructor público sin parámetros.  Esto te permite crear instancias del tipo genérico. 

```csharp
// Puede crear instancias de T
public class Fabrica<T> where T : new()
{
    public T Crear()
    {
        return new T(); // Esto solo es posible con la restricción new()
    }
    public T[] CrearMultiples(int cantidad)
    {
        T[] array = new T[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            array[i] = new T();
        }
        return array;
    }
}
// Clases de ejemplo
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    // Constructor sin parámetros (requerido)
    public Persona()
    {
        Nombre = "Sin nombre";
        Edad = 0;
    }
}
public class Producto
{
    public string Codigo { get; set; }
    public decimal Precio { get; set; }
    // Constructor sin parámetros
    public Producto()
    {
        Codigo = "N/A";
        Precio = 0;
    }
}
public class Cliente
{
    public string NIF { get; set; }
    // NO tiene constructor sin parámetros
    public Cliente(string nif)
    {
        NIF = nif;
    }
}

// Código ejecutable
// ✓ Funciona: Persona tiene constructor sin parámetros
Fabrica<Persona> fabricaPersonas = new Fabrica<Persona>();
Persona persona = fabricaPersonas.Crear();
Console.WriteLine($"Persona creada: {persona.Nombre}");

// ✓ Funciona: Producto tiene constructor sin parámetros
Fabrica<Producto> fabricaProductos = new Fabrica<Producto>();
Producto[] productos = fabricaProductos.CrearMultiples(3);
Console.WriteLine($"Productos creados: {productos.Length}");

// ✗ NO funciona: Cliente no tiene constructor sin parámetros
// Fabrica<Cliente> fabricaClientes = new Fabrica<Cliente>(); // ERROR
```

**`where T : <clase base>` (herencia de clase)**

Restringe el tipo genérico a una clase específica o sus clases derivadas. 

```csharp
// Clase base
public abstract class Animal
{
    public string Nombre { get; set; }
    public abstract void HacerSonido();
    public void Dormir()
    {
        Console.WriteLine($"{Nombre} está durmiendo...  Zzz");
    }
}
public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} dice:  Guau guau");
    }
}
public class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} dice: Miau miau");
    }
}
// Solo acepta Animal o sus derivados
public class Veterinaria<T> where T : Animal
{
    private T[] pacientes;
    private int contador;
    public Veterinaria(int capacidad)
    {
        pacientes = new T[capacidad];
        contador = 0;
    }
    public void RegistrarPaciente(T paciente)
    {
        if (contador < pacientes.Length)
        {
            pacientes[contador++] = paciente;
        }
    }
    // Podemos usar métodos de Animal porque T :  Animal
    public void RevisarTodos()
    {
        Console.WriteLine($"\n=== Revisión de {contador} pacientes ===");
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"\nPaciente {i + 1}:");
            pacientes[i].HacerSonido(); // Podemos llamar esto porque es un Animal
            pacientes[i].Dormir();       // Y esto también
        }
    }
}

// Código ejecutable
// ✓ Funciona:  Perro hereda de Animal
Veterinaria<Perro> vetPerros = new Veterinaria<Perro>(5);
vetPerros.RegistrarPaciente(new Perro { Nombre = "Firulais" });
vetPerros. RegistrarPaciente(new Perro { Nombre = "Rex" });
vetPerros.RevisarTodos();

// ✓ Funciona: Gato hereda de Animal
Veterinaria<Gato> vetGatos = new Veterinaria<Gato>(5);
vetGatos.RegistrarPaciente(new Gato { Nombre = "Michi" });
vetGatos.RevisarTodos();

// ✗ NO funciona: string no hereda de Animal
// Veterinaria<string> vetStrings = new Veterinaria<string>(5); // ERROR
```

**`where T : <interfaz>` (implementación de interfaz)**

Restringe el tipo genérico a tipos que implementen una interfaz específica.

```csharp
// Interfaz de ejemplo
public interface IIdentificable
{
    int Id { get; set; }
    string ObtenerIdentificador();
}

public interface IDescriptible
{
    string Descripcion { get; set; }
    string ObtenerDescripcionCompleta();
}

// Clases que implementan las interfaces
public class Producto : IIdentificable, IDescriptible
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    
    public string ObtenerIdentificador()
    {
        return $"PROD-{Id: D6}";
    }
    
    public string ObtenerDescripcionCompleta()
    {
        return $"{Nombre}:  {Descripcion} (${Precio})";
    }
}

public class Cliente : IIdentificable
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    
    public string ObtenerIdentificador()
    {
        return $"CLI-{Id: D6}";
    }
}

// Repositorio genérico que requiere IIdentificable
public class Repositorio<T> where T :  IIdentificable
{
    private List<T> items = new List<T>();
    
    public void Agregar(T item)
    {
        items. Add(item);
    }
    
    // Podemos usar métodos de IIdentificable porque T : IIdentificable
    public T BuscarPorId(int id)
    {
        foreach (T item in items)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return default(T);
    }
    
    public void MostrarTodos()
    {
        Console.WriteLine($"\n=== Repositorio con {items.Count} elementos ===");
        foreach (T item in items)
        {
            Console.WriteLine($"  {item.ObtenerIdentificador()}");
        }
    }
}

// ✓ Funciona:  Producto implementa IIdentificable
Repositorio<Producto> repoProductos = new Repositorio<Producto>();
repoProductos.Agregar(new Producto 
{ 
    Id = 1, 
    Nombre = "Laptop", 
    Descripcion = "Portátil gaming",
    Precio = 1200 
});
repoProductos.Agregar(new Producto 
{ 
    Id = 2, 
    Nombre = "Mouse", 
    Descripcion = "Inalámbrico",
    Precio = 25 
});
repoProductos.MostrarTodos();

// ✓ Funciona: Cliente implementa IIdentificable
Repositorio<Cliente> repoClientes = new Repositorio<Cliente>();
repoClientes.Agregar(new Cliente { Id = 100, Nombre = "Ana García" });
repoClientes.MostrarTodos();

// ✗ NO funciona: string no implementa IIdentificable
// Repositorio<string> repoStrings = new Repositorio<string>(); // ERROR

```

**`where T : notnull` (C# 8+)**

Restringe el tipo genérico a tipos no anulables (tanto tipos de valor como tipos de referencia no anulables).

```csharp
#nullable enable
// Solo acepta tipos no anulables
public class ContenedorNoNulo<T> where T : notnull
{
    private T valor;
    public ContenedorNoNulo(T valor)
    {
        this. valor = valor;
    }
    public T Valor
    {
        get => valor;
        set => valor = value; // Garantizado que no es null
    }
    public void Mostrar()
    {
        // Seguro:  valor nunca será null
        Console.WriteLine($"Valor: {valor. ToString()}");
    }
}

// Código ejecutable
// ✓ Funciona: int no es anulable
ContenedorNoNulo<int> contenedor1 = new ContenedorNoNulo<int>(42);

// ✓ Funciona: string no anulable
ContenedorNoNulo<string> contenedor2 = new ContenedorNoNulo<string>("Hola");

// ✗ NO funciona: int?  es anulable
// ContenedorNoNulo<int? > contenedor3 = new ContenedorNoNulo<int?>(null); // ERROR

// ✗ Advertencia: string?  es anulable
// ContenedorNoNulo<string? > contenedor4 = new ContenedorNoNulo<string?>(null); // ADVERTENCIA
```

**`where T : unmanaged` (tipos no administrados)**

Restringe el tipo genérico a tipos no administrados (tipos de valor que no contienen referencias).

```csharp
// Solo acepta tipos no administrados
public class BufferSeguro<T> where T : unmanaged
{
    private T[] buffer;
    public BufferSeguro(int tamaño)
    {
        buffer = new T[tamaño];
    }
    public unsafe void CopiarDesdeMemoria(T* fuente, int cantidad)
    {
        // Operaciones unsafe permitidas con tipos unmanaged
        for (int i = 0; i < cantidad && i < buffer.Length; i++)
        {
            buffer[i] = fuente[i];
        }
    }
    public int TamañoEnBytes()
    {
        return System.Runtime. InteropServices.Marshal.SizeOf<T>() * buffer.Length;
    }
}
struct Punto
{
    public int X;
    public int Y;
}
struct Rectangulo
{
    public Punto Superior;
    public Punto Inferior;
}

// Código ejecutable
// ✓ Funciona: int es unmanaged
BufferSeguro<int> buffer1 = new BufferSeguro<int>(100);
Console.WriteLine($"Buffer de int: {buffer1.TamañoEnBytes()} bytes");

// ✓ Funciona:  Punto es unmanaged (solo contiene ints)
BufferSeguro<Punto> buffer2 = new BufferSeguro<Punto>(50);
Console.WriteLine($"Buffer de Punto: {buffer2.TamañoEnBytes()} bytes");

// ✓ Funciona: Rectangulo es unmanaged
BufferSeguro<Rectangulo> buffer3 = new BufferSeguro<Rectangulo>(25);

// ✗ NO funciona: string es tipo de referencia (managed)
// BufferSeguro<string> buffer4 = new BufferSeguro<string>(10); // ERROR
```

#### 2.5. 2. Múltiples restricciones combinadas

Puedes combinar varias restricciones para el mismo parámetro de tipo.  El orden importa: 

1.  Primero: `class` o `struct`
2. Luego: clase base
3. Después: interfaces (puedes especificar varias)
4. Finalmente: `new()` (debe ser la última)

```csharp
// Ejemplo con múltiples restricciones
public class RepositorioCompleto<T> 
    where T : class, IIdentificable, IDescriptible, new()
{
    private List<T> items = new List<T>();
    public T CrearNuevo()
    {
        // Podemos crear instancias (new())
        T nuevoItem = new T();
        return nuevoItem;
    }
    public void Agregar(T item)
    {
        // T es class:  puede ser null
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }
        items.Add(item);
    }
    public T BuscarPorId(int id)
    {
        // Podemos usar IIdentificable
        foreach (T item in items)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return default(T); // null para tipos de referencia
    }
    public void MostrarDescripciones()
    {
        // Podemos usar IDescriptible
        foreach (T item in items)
        {
            Console. WriteLine($"  [{item.ObtenerIdentificador()}] {item.ObtenerDescripcionCompleta()}");
        }
    }
}
// Producto cumple todas las restricciones
public class Producto : IIdentificable, IDescriptible
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    // Constructor sin parámetros requerido por new()
    public Producto()
    {
        Nombre = "Producto nuevo";
        Descripcion = "Sin descripción";
        Precio = 0;
    }
    public string ObtenerIdentificador()
    {
        return $"PROD-{Id: D6}";
    }
    public string ObtenerDescripcionCompleta()
    {
        return $"{Nombre}:  {Descripcion} (${Precio})";
    }
}

// Código ejecutable
        RepositorioCompleto<Producto> repo = new RepositorioCompleto<Producto>();
        
        // Crear instancia (gracias a new())
        Producto producto1 = repo.CrearNuevo();
        producto1.Id = 1;
        producto1.Nombre = "Laptop";
        producto1.Descripcion = "Portátil de alto rendimiento";
        producto1.Precio = 1500;
        
        repo.Agregar(producto1);
        
        Producto producto2 = repo.CrearNuevo();
        producto2.Id = 2;
        producto2.Nombre = "Teclado mecánico";
        producto2.Descripcion = "RGB, switches azules";
        producto2.Precio = 120;
        
        repo. Agregar(producto2);
        
        Console.WriteLine("=== Productos en el repositorio ===");
        repo.MostrarDescripciones();
        
        Console.WriteLine("\n=== Buscar producto por ID ===");
        Producto encontrado = repo.BuscarPorId(1);
        if (encontrado != null)
        {
            Console.WriteLine($"Encontrado: {encontrado.ObtenerDescripcionCompleta()}");
        }
```

#### 2.5.3. Restricciones con múltiples parámetros de tipo

Cuando tienes varios parámetros de tipo, cada uno puede tener sus propias restricciones:

```csharp
// Múltiples parámetros de tipo con restricciones diferentes
public class Mapeador<TEntrada, TSalida>
    where TEntrada : class, IIdentificable
    where TSalida : class, new()
{
    public TSalida Mapear(TEntrada entrada, Action<TEntrada, TSalida> configurador)
    {
        if (entrada == null)
        {
            throw new ArgumentNullException(nameof(entrada));
        }
        // Crear instancia de salida (gracias a new())
        TSalida salida = new TSalida();
        // Configurar usando el delegate
        configurador(entrada, salida);
        return salida;
    }
    public TSalida[] MapearColeccion(TEntrada[] entradas, Action<TEntrada, TSalida> configurador)
    {
        TSalida[] salidas = new TSalida[entradas.Length];
        for (int i = 0; i < entradas.Length; i++)
        {
            salidas[i] = Mapear(entradas[i], configurador);
        }
        return salidas;
    }
}
// Clases de ejemplo
public class ProductoDTO :  IIdentificable
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string ObtenerIdentificador()
    {
        return $"PROD-{Id:D6}";
    }
}
public class ProductoViewModel
{
    public string Identificador { get; set; }
    public string NombreCompleto { get; set; }
    public string PrecioFormateado { get; set; }
    // Constructor sin parámetros requerido
    public ProductoViewModel()
    {
    }
}

// Código ejecutable
        Mapeador<ProductoDTO, ProductoViewModel> mapeador = 
            new Mapeador<ProductoDTO, ProductoViewModel>();
        
        ProductoDTO[] productosDTO = new ProductoDTO[]
        {
            new ProductoDTO { Id = 1, Nombre = "Laptop", Precio = 1200 },
            new ProductoDTO { Id = 2, Nombre = "Mouse", Precio = 25 },
            new ProductoDTO { Id = 3, Nombre = "Teclado", Precio = 75 }
        };
        
        // Mapear con configurador personalizado
        ProductoViewModel[] viewModels = mapeador.MapearColeccion(productosDTO, (dto, vm) =>
        {
            vm. Identificador = dto.ObtenerIdentificador();
            vm.NombreCompleto = dto. Nombre. ToUpper();
            vm.PrecioFormateado = $"${dto.Precio:F2}";
        });
        
        Console.WriteLine("=== Productos mapeados ===");
        foreach (ProductoViewModel vm in viewModels)
        {
            Console.WriteLine($"{vm.Identificador}: {vm.NombreCompleto} - {vm.PrecioFormateado}");
        }
```

#### 2.5.4. Ejemplos prácticos avanzados

**Ejemplo 1: Conversor genérico con restricciones**

```csharp
// Conversor que requiere que ambos tipos implementen IConvertible
public class Conversor<TEntrada, TSalida>
    where TEntrada : IConvertible
    where TSalida : IConvertible
{
    public TSalida Convertir(TEntrada valor)
    {
        try
        {
            // IConvertible proporciona métodos de conversión
            return (TSalida)Convert.ChangeType(valor, typeof(TSalida));
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException(
                $"No se puede convertir {typeof(TEntrada).Name} a {typeof(TSalida).Name}", 
                ex);
        }
    }
    public TSalida[] ConvertirArray(TEntrada[] valores)
    {
        TSalida[] resultado = new TSalida[valores. Length];
        for (int i = 0; i < valores.Length; i++)
        {
            resultado[i] = Convertir(valores[i]);
        }
        return resultado;
    }
    public bool TryConvertir(TEntrada valor, out TSalida resultado)
    {
        try
        {
            resultado = Convertir(valor);
            return true;
        }
        catch
        {
            resultado = default(TSalida);
            return false;
        }
    }
}

// Código ejecutable
// Convertir int a double
Conversor<int, double> conversor1 = new Conversor<int, double>();
double resultado1 = conversor1.Convertir(42);
Console.WriteLine($"int 42 como double: {resultado1}");

// Convertir string a int
Conversor<string, int> conversor2 = new Conversor<string, int>();
int[] numeros = conversor2.ConvertirArray(new string[] { "10", "20", "30" });
Console.WriteLine($"Strings convertidos a ints: [{string.Join(", ", numeros)}]");

// Intentar convertir de forma segura
if (conversor2.TryConvertir("123", out int valor))
{
    Console. WriteLine($"Conversión exitosa: {valor}");
}

if (! conversor2.TryConvertir("abc", out int valor2))
{
    Console. WriteLine("Conversión fallida para 'abc'");
        }
```

**Ejemplo 2: Caché genérica con restricciones**

```csharp
// Caché que requiere IIdentificable y ICloneable
public class Cache<T> 
    where T : class, IIdentificable, ICloneable
{
    private Dictionary<int, T> cache = new Dictionary<int, T>();
    private int hits = 0;
    private int misses = 0;
    public void Almacenar(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }
        // Clonar para evitar modificaciones externas
        T clon = (T)item.Clone();
        cache[item.Id] = clon;
    }
    public T Obtener(int id)
    {
        if (cache.ContainsKey(id))
        {
            hits++;
            // Devolver un clon para proteger el caché
            return (T)cache[id].Clone();
        }
        misses++;
        return null;
    }
    public bool Existe(int id)
    {
        return cache.ContainsKey(id);
    }
    public void Limpiar()
    {
        cache.Clear();
        hits = 0;
        misses = 0;
    }
    public void MostrarEstadisticas()
    {
        int total = hits + misses;
        double tasaAciertos = total > 0 ? (hits * 100.0 / total) : 0;
        Console.WriteLine($"\n=== Estadísticas del Caché ===");
        Console.WriteLine($"Elementos almacenados: {cache.Count}");
        Console.WriteLine($"Aciertos (hits): {hits}");
        Console.WriteLine($"Fallos (misses): {misses}");
        Console.WriteLine($"Tasa de aciertos:  {tasaAciertos: F2}%");
    }
}
// Clase que cumple las restricciones
public class DocumentoCacheable :  IIdentificable, ICloneable
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Contenido { get; set; }
    public string ObtenerIdentificador()
    {
        return $"DOC-{Id:D6}";
    }
    public object Clone()
    {
        return new DocumentoCacheable
        {
            Id = this.Id,
            Titulo = this.Titulo,
            Contenido = this.Contenido
        };
    }
    public override string ToString()
    {
        return $"[{ObtenerIdentificador()}] {Titulo}";
    }
}

// Código ejecutable
Cache<DocumentoCacheable> cache = new Cache<DocumentoCacheable>();

// Almacenar documentos
cache.Almacenar(new DocumentoCacheable 
{ 
    Id = 1, 
    Titulo = "Documento 1", 
    Contenido = "Contenido del documento 1" 
});

cache.Almacenar(new DocumentoCacheable 
{ 
    Id = 2, 
    Titulo = "Documento 2", 
    Contenido = "Contenido del documento 2" 
});

// Acceder a documentos
Console.WriteLine("=== Accediendo a documentos ===");

DocumentoCacheable doc1 = cache.Obtener(1);
Console.WriteLine(doc1 != null ? $"Encontrado: {doc1}" : "No encontrado");

DocumentoCacheable doc2 = cache.Obtener(2);
Console.WriteLine(doc2 != null ? $"Encontrado: {doc2}" : "No encontrado");

DocumentoCacheable doc1Again = cache.Obtener(1);
Console.WriteLine(doc1Again != null ? $"Encontrado nuevamente: {doc1Again}" :  "No encontrado");

DocumentoCacheable doc3 = cache.Obtener(3);
Console.WriteLine(doc3 != null ? $"Encontrado: {doc3}" : "No encontrado (miss)");

cache.MostrarEstadisticas();
```

---

### 2.6. Tipos Genéricos Anulables

Los tipos genéricos anulables (`Nullable<T>`) permiten que los tipos de valor puedan representar la ausencia de un valor (null).

#### 2.6.1. `Nullable<T>` y la sintaxis `T?`

```csharp
// Sintaxis completa
Nullable<int> numero1 = null;
Nullable<int> numero2 = 42;

// Sintaxis abreviada (más común)
int? numero3 = null;
int? numero4 = 100;

// Ejemplos con diferentes tipos de valor
double? precio = null;
bool? activo = true;
DateTime? fechaNacimiento = null;

// NO funciona con tipos de referencia (antes de C# 8)
// string? texto = null; // Esto es diferente en C# 8+

```

#### 2.6.2. Uso exclusivo con tipos de valor (`struct`)

`Nullable<T>` solo funciona con tipos de valor (struct). Los tipos de referencia ya pueden ser null por naturaleza.

```csharp
struct Punto
{
    public int X;
    public int Y;
    public Punto(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

// Código ejecutable
        // ✓ Funciona:  int es tipo de valor
        int? numeroNullable = null;
        
        // ✓ Funciona: Punto es struct (tipo de valor)
        Punto? puntoNullable = null;
        
        puntoNullable = new Punto(10, 20);
        Console.WriteLine($"Punto: {puntoNullable}");
        
        // ✗ NO funciona: string ya es tipo de referencia
        // Nullable<string> textoNullable = null; // ERROR de compilación
```

#### 2.6.3. Propiedades:   `HasValue`, `Value`

```csharp
// Código ejecutable
        int? numero = null;
        
        // Verificar si tiene valor
        if (numero.HasValue)
        {
            Console.WriteLine($"El número tiene valor: {numero.Value}");
        }
        else
        {
            Console.WriteLine("El número es null");
        }
        
        // Asignar un valor
        numero = 42;
        
        if (numero.HasValue)
        {
            Console.WriteLine($"El número tiene valor: {numero. Value}");
            Console.WriteLine($"También puedes acceder así: {numero}");
        }
        
        // Cuidado con Value cuando es null
        int? otroNumero = null;
        // int valor = otroNumero.Value; // ¡EXCEPCIÓN!  InvalidOperationException
        
        // Forma segura
        int valorSeguro = otroNumero.HasValue ? otroNumero.Value : 0;
        Console.WriteLine($"Valor seguro: {valorSeguro}");
```

#### 2.6.4. Operadores y conversiones

**Operador de coalescencia nula (`??`)**

```csharp
// Código ejecutable
        int? numeroNullable = null;
        
        // Si es null, usar valor por defecto
        int numero = numeroNullable ?? 0;
        Console.WriteLine($"Número: {numero}"); // 0
        
        numeroNullable = 42;
        numero = numeroNullable ?? 0;
        Console.WriteLine($"Número: {numero}"); // 42
        
        // Encadenar coalescencia
        int? a = null;
        int? b = null;
        int? c = 100;
        
        int resultado = a ?? b ?? c ??  -1;
        Console.WriteLine($"Resultado: {resultado}"); // 100
```

**Operador de asignación con coalescencia (`??=`)**

```csharp
// Código ejecutable
        int? numero = null;
        
        // Asignar solo si es null
        numero ??= 50;
        Console.WriteLine($"Número: {numero}"); // 50
        
        numero ??= 100; // No cambia porque ya no es null
        Console.WriteLine($"Número: {numero}"); // 50
```

**Conversiones implícitas y explícitas**

```csharp
// Código ejecutable
        // Conversión implícita de T a T?
        int numero = 42;
        int? numeroNullable = numero; // ✓ Implícita
        Console.WriteLine($"Nullable: {numeroNullable}");
        
        // Conversión explícita de T? a T
        int? otroNumeroNullable = 100;
        int otroNumero = (int)otroNumeroNullable; // ✓ Explícita (cast)
        Console.WriteLine($"No nullable: {otroNumero}");
        
        // Si es null, el cast lanza excepción
        int? nulo = null;
        // int valor = (int)nulo; // ¡EXCEPCIÓN! InvalidOperationException
```

**Operadores aritméticos con nullables**

```csharp
// Código ejecutable
int? a = 10;
int? b = 20;
int? c = null;

// Operaciones con valores
int?  suma1 = a + b;
Console.WriteLine($"10 + 20 = {suma1}"); // 30

// Operaciones con null:  resultado es null
int? suma2 = a + c;
Console.WriteLine($"10 + null = {suma2}"); // (vacío, es null)
Console.WriteLine($"10 + null = {suma2 ?? -1}"); // -1

// Operaciones lógicas
bool? booleano1 = true;
bool? booleano2 = false;
bool? booleano3 = null;

bool?  and1 = booleano1 & booleano2; // false
bool? and2 = booleano1 & booleano3; // null
bool? or1 = booleano1 | booleano2;  // true
bool? or2 = booleano2 | booleano3;  // null

Console. WriteLine($"true & false = {and1}");
Console.WriteLine($"true & null = {and2 ?? false}");
Console.WriteLine($"true | false = {or1}");
Console.WriteLine($"false | null = {or2 ??  false}");
```

**Método `GetValueOrDefault()`**

```csharp
// Código ejecutable
int? numero = null;

// Obtener valor o el default del tipo
int valor1 = numero.GetValueOrDefault(); // 0 (default de int)
Console.WriteLine($"Valor por defecto: {valor1}");

// Obtener valor o un default personalizado
int valor2 = numero.GetValueOrDefault(100);
Console.WriteLine($"Valor personalizado: {valor2}");

numero = 42;
int valor3 = numero.GetValueOrDefault(100);
Console.WriteLine($"Valor existente: {valor3}"); // 42
```

**Ejemplo práctico: Búsqueda con resultado nullable**

```csharp
public class Buscador
{
    private int[] numeros = { 10, 20, 30, 40, 50 };
    public int? BuscarMayorQue(int limite)
    {
        foreach (int numero in numeros)
        {
            if (numero > limite)
            {
                return numero; // Encontrado
            }
        }
        return null; // No encontrado
    }
    public int? BuscarEnIndice(int indice)
    {
        if (indice >= 0 && indice < numeros.Length)
        {
            return numeros[indice];
        }
        return null; // Índice inválido
    }
}

// Código ejecutable
Buscador buscador = new Buscador();

// Búsqueda exitosa
int? resultado1 = buscador.BuscarMayorQue(25);
if (resultado1.HasValue)
{
    Console.WriteLine($"Encontrado: {resultado1.Value}");
}
else
{
    Console.WriteLine("No encontrado");
}

// Búsqueda sin resultado
int? resultado2 = buscador.BuscarMayorQue(100);
Console.WriteLine($"Búsqueda mayor que 100: {resultado2 ?? -1}");

// Usar con operador ??
int valor = buscador.BuscarMayorQue(15) ?? 0;
Console. WriteLine($"Valor encontrado o 0: {valor}");
```

## 3. Programación Funcional en C#

### 3.1. Conceptos Fundamentales

La programación funcional es un paradigma que trata las funciones como **ciudadanos de primera clase**. Esto significa que las funciones pueden: 

- **Asignarse a variables**
- **Pasarse como argumentos** a otras funciones
- **Devolverse como resultado** de otras funciones
- **Almacenarse en estructuras de datos**

#### 3.1.1. Funciones como ciudadanos de primera clase

En C#, las funciones son ciudadanos de primera clase gracias a los **delegates**.  Veamos qué significa esto en la práctica:

**Asignar funciones a variables:**

```csharp
// Código ejecutable
// Asignar la función a una variable
Func<int, int, int> operacion = Sumar;

// Usar la variable como si fuera la función
int resultado = operacion(5, 3);
Console.WriteLine($"Resultado: {resultado}"); // 8

// Cambiar la función asignada
operacion = Restar;
resultado = operacion(5, 3);
Console.WriteLine($"Resultado: {resultado}"); // 2

// Funciones locales
// Método tradicional
int Sumar(int a, int b)
{
    return a + b;
}

int Restar(int a, int b)
{
    return a - b;
}
```

**Pasar funciones como argumentos:**

```csharp
// Código ejecutable
// Pasar diferentes funciones como argumentos
EjecutarOperacion(10, 5, Multiplicar); // Resultado: 50
EjecutarOperacion(10, 5, Dividir);     // Resultado: 2

// También podemos pasar lambdas
EjecutarOperacion(10, 5, (x, y) => x + y);     // Resultado: 15
EjecutarOperacion(10, 5, (x, y) => x - y);     // Resultado: 5
EjecutarOperacion(10, 5, (x, y) => x % y);     // Resultado: 0

// Funciones locales
// Función que RECIBE otra función como parámetro
void EjecutarOperacion(int a, int b, Func<int, int, int> operacion)
{
    int resultado = operacion(a, b);
    Console.WriteLine($"Resultado de la operación: {resultado}");
}

int Multiplicar(int a, int b)
{
    return a * b;
}

int Dividir(int a, int b)
{
    return a / b;
}
```

**Devolver funciones como resultado:**

```csharp
// Código ejecutable
// Crear funciones personalizadas
Func<int, int> duplicar = CrearMultiplicador(2);
Func<int, int> triplicar = CrearMultiplicador(3);
Func<int, int> sumarDiez = CrearSumador(10);

Console.WriteLine($"Duplicar 5: {duplicar(5)}");     // 10
Console.WriteLine($"Triplicar 5: {triplicar(5)}");   // 15
Console.WriteLine($"Sumar 10 a 5: {sumarDiez(5)}");  // 15

// Componer funciones
int resultado = sumarDiez(duplicar(5)); // (5 * 2) + 10 = 20
Console.WriteLine($"Duplicar y luego sumar 10 a 5: {resultado}");

// Funciones locales
    // Función que DEVUELVE otra función
    Func<int, int> CrearMultiplicador(int factor)
    {
        // Devuelve una función que multiplica por el factor
        return (numero) => numero * factor;
    }

    Func<int, int> CrearSumador(int incremento)
    {
        // Devuelve una función que suma el incremento
        return (numero) => numero + incremento;
    }
```

**Almacenar funciones en estructuras de datos:**

```csharp
// Código ejecutable
        // Diccionario de operaciones
        Dictionary<string, Func<int, int, int>> calculadora = 
            new Dictionary<string, Func<int, int, int>>
        {
            { "suma", Sumar },
            { "resta", Restar },
            { "multiplicacion", Multiplicar },
            { "division", Dividir }
        };
        
        // Usar las funciones almacenadas
        int a = 20;
        int b = 5;
        
        foreach (var operacion in calculadora)
        {
            int resultado = operacion.Value(a, b);
            Console.WriteLine($"{operacion.Key}: {a} y {b} = {resultado}");
        }
        
        // Array de transformaciones
        Func<int, int>[] transformaciones = new Func<int, int>[]
        {
            x => x * 2,        // Duplicar
            x => x + 10,       // Sumar 10
            x => x * x,        // Elevar al cuadrado
            x => x / 2         // Dividir entre 2
        };
        
        int valor = 5;
        Console.WriteLine($"\nValor inicial: {valor}");
        
        foreach (var transformacion in transformaciones)
        {
            valor = transformacion(valor);
            Console.WriteLine($"Después de transformación: {valor}");
        }

// Funciones locales
    int Sumar(int a, int b) => a + b;

    int Restar(int a, int b) => a - b;

    int Multiplicar(int a, int b) => a * b;

    int Dividir(int a, int b) => a / b;
```

#### 3.1.2. Inmutabilidad

La inmutabilidad es un principio clave en programación funcional. Significa que una vez que un valor se crea, no se puede modificar.  En lugar de modificar valores existentes, creamos nuevos valores.

**Ejemplo SIN inmutabilidad (imperativo):**

```csharp
class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public void CumplirAños()
    {
        Edad++; // Modifica el estado interno
    }
}

// Código ejecutable
        Persona persona = new Persona { Nombre = "Ana", Edad = 25 };
        Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años");
        
        persona.CumplirAños(); // Muta el objeto
        Console.WriteLine($"{persona.Nombre} tiene {persona. Edad} años");
        
        // Problema: el objeto original cambió
```

**Ejemplo CON inmutabilidad (funcional):**

```csharp
// Clase inmutable
class PersonaInmutable
{
    public string Nombre { get; }
    public int Edad { get; }
    public PersonaInmutable(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
    // En lugar de modificar, devuelve una nueva instancia
    public PersonaInmutable CumplirAños()
    {
        return new PersonaInmutable(Nombre, Edad + 1);
    }
    public PersonaInmutable CambiarNombre(string nuevoNombre)
    {
        return new PersonaInmutable(nuevoNombre, Edad);
    }
}

// Código ejecutable
        PersonaInmutable persona1 = new PersonaInmutable("Ana", 25);
        Console.WriteLine($"{persona1.Nombre} tiene {persona1.Edad} años");
        
        // No modifica persona1, crea una nueva
        PersonaInmutable persona2 = persona1.CumplirAños();
        Console.WriteLine($"{persona2.Nombre} tiene {persona2.Edad} años");
        
        // persona1 sigue igual (inmutable)
        Console.WriteLine($"Original: {persona1.Nombre} tiene {persona1.Edad} años");
        
        // Encadenar operaciones
        PersonaInmutable persona3 = persona1
            .CumplirAños()
            .CumplirAños()
            .CambiarNombre("Ana María");
        
        Console.WriteLine($"{persona3.Nombre} tiene {persona3.Edad} años");
```

**Records (C# 9+): Inmutabilidad simplificada**

```csharp
// Record inmutable por defecto
record Punto(int X, int Y);
// Record con métodos
record PersonaRecord(string Nombre, int Edad)
{
    public PersonaRecord CumplirAños() => this with { Edad = Edad + 1 };
}

// Código ejecutable
        Punto p1 = new Punto(10, 20);
        Console.WriteLine($"Punto 1: {p1}"); // Punto { X = 10, Y = 20 }
        
        // Crear una copia modificada con 'with'
        Punto p2 = p1 with { X = 30 };
        Console.WriteLine($"Punto 2: {p2}"); // Punto { X = 30, Y = 20 }
        Console.WriteLine($"Punto 1: {p1}"); // Punto { X = 10, Y = 20 } (sin cambios)
        
        // Con personas
        PersonaRecord persona1 = new PersonaRecord("Carlos", 30);
        PersonaRecord persona2 = persona1.CumplirAños();
        
        Console.WriteLine($"Persona 1: {persona1}"); // PersonaRecord { Nombre = Carlos, Edad = 30 }
        Console.WriteLine($"Persona 2: {persona2}"); // PersonaRecord { Nombre = Carlos, Edad = 31 }
```

#### 3.1.3. Funciones puras vs. funciones con efectos secundarios

**Función pura:** 
- Siempre devuelve el mismo resultado para los mismos argumentos
- No tiene efectos secundarios (no modifica estado externo, no hace I/O, etc.)
- Es predecible y fácil de probar

**Función impura (con efectos secundarios):**
- Puede devolver resultados diferentes para los mismos argumentos
- Modifica estado externo, lee/escribe archivos, accede a la red, etc.
- Es impredecible y más difícil de probar

```csharp
// Código ejecutable
        // Función pura:  mismos argumentos = mismo resultado
        Console.WriteLine("=== Función pura ===");
        Console.WriteLine(SumarPura(5, 3)); // 8
        Console.WriteLine(SumarPura(5, 3)); // 8
        Console.WriteLine(SumarPura(5, 3)); // 8
        
        // Función impura: puede dar resultados diferentes
        Console.WriteLine("\n=== Función impura ===");
        Console.WriteLine(SumarImpura(5, 3)); // 8 (pero modifica contador)
        Console.WriteLine(SumarImpura(5, 3)); // 8 (pero modifica contador)
        Console.WriteLine(SumarConContadorImpura(5)); // Diferente cada vez
        Console.WriteLine(SumarConContadorImpura(5)); // Diferente cada vez

// Funciones locales
    
    // ❌ FUNCIÓN IMPURA:  tiene efecto secundario (modifica estado global)
    int SumarImpura(int a, int b)
    {
        contador++; // Efecto secundario
        Console.WriteLine($"Llamada #{contador}"); // Efecto secundario (I/O)
        return a + b;
    }

    
    // ✓ FUNCIÓN PURA: sin efectos secundarios
    int SumarPura(int a, int b)
    {
        return a + b; // Solo depende de los argumentos
    }

    
    // ❌ FUNCIÓN IMPURA:  depende del estado externo
    int SumarConContadorImpura(int a)
    {
        return a + contador; // Depende de estado externo
    }

    
    // ✓ FUNCIÓN PURA: recibe todo lo que necesita
    int SumarConContadorPura(int a, int contadorParam)
    {
        return a + contadorParam; // Solo depende de los argumentos
    }

    
    // ❌ FUNCIÓN IMPURA: usa Random (no determinista)
    int GenerarAleatorioImpura()
    {
        Random random = new Random();
        return random.Next(1, 100);
    }

    
    // ✓ FUNCIÓN MÁS PURA: recibe el generador como parámetro
    int GenerarAleatorioPura(Random random)
    {
        return random. Next(1, 100);
    }
```

**Ventajas de las funciones puras:**

```csharp
// Código ejecutable
        decimal precio = 100m;
        decimal[] descuentos = { 10, 5, 2 }; // 10%, 5%, 2%
        
        // Siempre da el mismo resultado
        decimal precioFinal1 = AplicarDescuentos(precio, descuentos);
        decimal precioFinal2 = AplicarDescuentos(precio, descuentos);
        
        Console.WriteLine($"Precio final 1: ${precioFinal1:F2}");
        Console.WriteLine($"Precio final 2: ${precioFinal2:F2}");
        Console.WriteLine($"¿Son iguales? {precioFinal1 == precioFinal2}");
        
        // Fácil de probar
        decimal esperado = 100m * 0.9m * 0.95m * 0.98m;
        bool testPasado = Math.Abs(precioFinal1 - esperado) < 0.01m;
        Console.WriteLine($"Test:  {(testPasado ? "✓ PASÓ" : "✗ FALLÓ")}");

// Funciones locales
    // Función pura para calcular descuento
    decimal CalcularPrecioConDescuento(decimal precioBase, decimal porcentajeDescuento)
    {
        return precioBase * (1 - porcentajeDescuento / 100);
    }

    
    // Función pura para aplicar múltiples descuentos
    decimal AplicarDescuentos(decimal precio, decimal[] descuentos)
    {
        decimal precioFinal = precio;
        
        foreach (decimal descuento in descuentos)
        {
            precioFinal = CalcularPrecioConDescuento(precioFinal, descuento);
        }
        
        return precioFinal;
    }
```

#### 3.1.4. Transparencia referencial

Una expresión tiene **transparencia referencial** si puede ser reemplazada por su valor sin cambiar el comportamiento del programa.  Esto solo es posible con funciones puras. 

```csharp
// Código ejecutable
        // Con transparencia referencial
        int resultado1 = Cuadrado(5) + Cuadrado(5);
        
        // Podemos reemplazar Cuadrado(5) por su valor (25)
        int resultado2 = 25 + 25;
        
        Console.WriteLine($"Resultado 1: {resultado1}");
        Console.WriteLine($"Resultado 2: {resultado2}");
        Console.WriteLine($"¿Son iguales? {resultado1 == resultado2}");
        
        // Sin transparencia referencial
        Console.WriteLine("\nSin transparencia referencial:");
        int resultado3 = CuadradoConLog(5) + CuadradoConLog(5);
        // Aquí NO podemos reemplazar directamente porque tiene efectos secundarios
        // Si lo hacemos, perderíamos los mensajes de log

// Funciones locales
    // Función con transparencia referencial
    int Cuadrado(int x)
    {
        return x * x;
    }

    
    // Función SIN transparencia referencial
    int CuadradoConLog(int x)
    {
        Console.WriteLine($"Calculando cuadrado de {x}");
        return x * x;
    }
```

---

### 3.2. Delegates (Delegados)

Los **delegates** son el mecanismo de C# que permite tratar las funciones como ciudadanos de primera clase. Un delegate es un tipo que representa referencias a métodos con una firma específica.

#### 3.2.1. Fundamentos

**¿Qué es un delegate?**

Un delegate es un tipo que define la firma de un método (parámetros y tipo de retorno). Puedes crear variables de ese tipo que "apunten" a cualquier método que coincida con esa firma.

```csharp
// Definir un delegate
delegate int OperacionMatematica(int a, int b);

// Código ejecutable
        // Crear instancia del delegate apuntando a Sumar
        OperacionMatematica operacion = Sumar;
        
        // Invocar el delegate (llama a Sumar)
        int resultado = operacion(10, 5);
        Console.WriteLine($"Resultado: {resultado}"); // 15
        
        // Cambiar a qué método apunta
        operacion = Multiplicar;
        resultado = operacion(10, 5);
        Console.WriteLine($"Resultado: {resultado}"); // 50

// Funciones locales
    int Sumar(int a, int b)
    {
        return a + b;
    }

    int Multiplicar(int a, int b)
    {
        return a * b;
    }
```

**Definición y sintaxis**

```csharp
// Sintaxis básica
delegate TipoRetorno NombreDelegate(TipoParam1 param1, TipoParam2 param2, ... );

// Ejemplos
delegate void AccionSimple();                          // Sin parámetros, sin retorno
delegate int Operacion(int x, int y);                  // Dos parámetros, retorna int
delegate string Transformador(string texto);            // Un parámetro, retorna string
delegate bool Predicado(int numero);                   // Un parámetro, retorna bool
delegate void Notificador(string mensaje, int nivel);  // Múltiples parámetros, sin retorno

```

**Delegates como tipos**

```csharp
delegate int Calculadora(int a, int b);

// Código ejecutable
        // Usar delegate como variable
        Calculadora miCalculo = Sumar;
        Console.WriteLine(miCalculo(10, 5)); // 15
        
        // Pasar delegate como argumento
        EjecutarCalculo(10, 5, Sumar);         // 15
        EjecutarCalculo(10, 5, Restar);        // 5
        EjecutarCalculo(10, 5, Multiplicar);   // 50
        
        // Recibir delegate como retorno
        Calculadora operacion = ObtenerOperacion("multiplicacion");
        Console.WriteLine(operacion(6, 7)); // 42

// Funciones locales
    int Sumar(int a, int b) => a + b;

    int Restar(int a, int b) => a - b;

    int Multiplicar(int a, int b) => a * b;

    
    // Método que recibe un delegate como parámetro
    void EjecutarCalculo(int x, int y, Calculadora calc)
    {
        int resultado = calc(x, y);
        Console.WriteLine($"Resultado: {resultado}");
    }

    
    // Método que retorna un delegate
    Calculadora ObtenerOperacion(string tipo)
    {
        switch (tipo)
        {
            case "suma":
                return Sumar;
            case "resta":
                return Restar;
            case "multiplicacion":
                return Multiplicar;
            default: 
                return (a, b) => 0;
        }
    }
```

#### 3.2.2. Delegates Personalizados

Puedes crear tus propios delegates para situaciones específicas. 

```csharp
// Delegates personalizados
delegate void ProcesadorElemento<T>(T elemento, int indice);
delegate bool FiltroAvanzado<T>(T elemento, int indice, T[] arrayCompleto);
delegate TResult Transformador<TInput, TResult>(TInput entrada);

// Código ejecutable
        int[] numeros = { 10, 20, 30, 40, 50 };
        
        // Usar delegate personalizado
        Console.WriteLine("=== Procesando array ===");
        ProcesarArray(numeros, (elemento, indice) =>
        {
            Console.WriteLine($"[{indice}] = {elemento}");
        });
        
        // Filtro avanzado:  solo elementos mayores que el promedio
        Console.WriteLine("\n=== Filtrado avanzado ===");
        int[] mayoresQuePromedio = FiltrarAvanzado(numeros, (elemento, indice, arrayCompleto) =>
        {
            double promedio = arrayCompleto.Average();
            return elemento > promedio;
        });
        
        Console.WriteLine($"Mayores que promedio: [{string.Join(", ", mayoresQuePromedio)}]");
        
        // Transformador personalizado
        Transformador<int, string> formatear = numero => $"#{numero:D4}";
        
        Console.WriteLine("\n=== Transformación ===");
        foreach (int numero in numeros)
        {
            Console.WriteLine(formatear(numero));
        }
```

**Casos de uso de delegates personalizados:**

```csharp
// Delegate para validación con contexto
delegate bool Validador<T>(T item, out string mensajeError);
// Delegate para comparación personalizada
delegate int ComparadorComplejo<T>(T x, T y, bool ascendente);
// Delegate para eventos personalizados
delegate void ManejadorCambio<T>(T valorAntiguo, T valorNuevo);
class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
}

// Código ejecutable
        Producto[] productos = new Producto[]
        {
            new Producto { Id = 1, Nombre = "Laptop", Precio = 1200 },
            new Producto { Id = 2, Nombre = "", Precio = 50 },
            new Producto { Id = 3, Nombre = "Mouse", Precio = -10 },
            new Producto { Id = 4, Nombre = "Teclado", Precio = 75 }
        };
        
        Console.WriteLine("=== Validación de productos ===");
        ProcesarProductos(productos, ValidarProducto);

// Funciones locales
    bool ValidarProducto(Producto producto, out string mensajeError)
    {
        if (producto == null)
        {
            mensajeError = "El producto no puede ser null";
            return false;
        }
        
        if (string.IsNullOrWhiteSpace(producto.Nombre))
        {
            mensajeError = "El nombre no puede estar vacío";
            return false;
        }
        
        if (producto.Precio <= 0)
        {
            mensajeError = "El precio debe ser mayor que cero";
            return false;
        }
        
        mensajeError = string.Empty;
        return true;
    }

    void ProcesarProductos(Producto[] productos, Validador<Producto> validador)
    {
        foreach (Producto producto in productos)
        {
            if (validador(producto, out string error))
            {
                Console. WriteLine($"✓ Producto válido: {producto.Nombre}");
            }
            else
            {
                Console.WriteLine($"✗ Producto inválido: {error}");
            }
        }
    }
```

**Buenas prácticas de nomenclatura:**

```csharp
// ✓ Nombres descriptivos que indican qué hace el delegate
delegate bool EsValido<T>(T item);
delegate void AlModificar<T>(T item);
delegate T Transformar<T>(T input);
delegate int Comparar<T>(T x, T y);
delegate void Notificar(string mensaje);

// ✓ Usar sufijos comunes
delegate void ManejadorEvento(object sender, EventArgs e);  // Handler
delegate bool Predicado<T>(T item);                         // Predicate
delegate void Accion();                                     // Action
delegate T Funcion<T>();                                    // Function
delegate void Callback();                                   // Callback

// ✗ Evitar nombres genéricos o poco claros
delegate void Hacer();           // Poco claro
delegate bool Revisar(int x);    // Poco descriptivo
delegate void Cosa<T>(T item);   // Muy genérico

```

#### 3.2.3. Delegates Genéricos Predefinidos

C# proporciona tres delegates genéricos que cubren la mayoría de casos de uso, eliminando la necesidad de definir delegates personalizados en muchas situaciones.

**`Action` y sus variantes genéricas**

`Action` representa un método que **no retorna nada** (void) y puede tener de 0 a 16 parámetros. 

```csharp
// Código ejecutable
        // Action sin parámetros
        Action saludar = () => Console.WriteLine("¡Hola!");
        saludar(); // ¡Hola! 
        
        // Action con 1 parámetro
        Action<string> saludarConNombre = nombre => 
            Console.WriteLine($"¡Hola, {nombre}!");
        saludarConNombre("Ana"); // ¡Hola, Ana!
        
        // Action con 2 parámetros
        Action<string, int> mostrarInfo = (nombre, edad) => 
            Console.WriteLine($"{nombre} tiene {edad} años");
        mostrarInfo("Carlos", 30); // Carlos tiene 30 años
        
        // Action con 3 parámetros
        Action<int, int, string> mostrarOperacion = (a, b, operador) =>
        {
            int resultado = operador == "+" ? a + b : a - b;
            Console.WriteLine($"{a} {operador} {b} = {resultado}");
        };
        mostrarOperacion(10, 5, "+"); // 10 + 5 = 15
        mostrarOperacion(10, 5, "-"); // 10 - 5 = 5
        
        // Usar Action con métodos
        Action<string> escribir = Console.WriteLine;
        escribir("Mensaje desde Action");
```

**Variantes de Action:**

```csharp
Action              // Sin parámetros
Action<T>           // 1 parámetro
Action<T1, T2>      // 2 parámetros
Action<T1, T2, T3>  // 3 parámetros
// ... hasta Action<T1, T2, .. ., T16>

```

**Ejemplo práctico con Action:**

```csharp
// Código ejecutable
        int[] numeros = { 10, 20, 30, 40, 50 };
        
        Console.WriteLine("=== Mostrar con índice ===");
        ProcesarNumeros(numeros, (numero, indice) =>
        {
            Console.WriteLine($"[{indice}] = {numero}");
        });
        
        Console.WriteLine("\n=== Mostrar solo pares ===");
        ProcesarNumeros(numeros, (numero, indice) =>
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine($"Par encontrado: {numero}");
            }
        });
        
        Console.WriteLine("\n=== Sumar acumulado ===");
        int suma = 0;
        ProcesarNumeros(numeros, (numero, indice) =>
        {
            suma += numero;
            Console.WriteLine($"Suma acumulada: {suma}");
        });

// Funciones locales
    void ProcesarNumeros(int[] numeros, Action<int, int> accion)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            accion(numeros[i], i);
        }
    }
```

**`Func<TResult>` y sus variantes**

`Func` representa un método que **retorna un valor**. Puede tener de 0 a 16 parámetros de entrada, y el último parámetro genérico es siempre el tipo de retorno. 

```csharp
// Código ejecutable
        // Func sin parámetros, retorna int
        Func<int> obtenerNumeroAleatorio = () =>
        {
            Random random = new Random();
            return random. Next(1, 100);
        };
        Console.WriteLine($"Número aleatorio: {obtenerNumeroAleatorio()}");
        
        // Func con 1 parámetro, retorna bool
        Func<int, bool> esPar = numero => numero % 2 == 0;
        Console.WriteLine($"¿10 es par? {esPar(10)}"); // True
        Console.WriteLine($"¿7 es par? {esPar(7)}");   // False
        
        // Func con 2 parámetros, retorna int
        Func<int, int, int> sumar = (a, b) => a + b;
        Console.WriteLine($"5 + 3 = {sumar(5, 3)}"); // 8
        
        // Func con 2 parámetros, retorna string
        Func<string, string, string> concatenar = (a, b) => $"{a} {b}";
        Console. WriteLine(concatenar("Hola", "Mundo")); // Hola Mundo
        
        // Func más compleja
        Func<int, int, string, string> formatearOperacion = (a, b, operador) =>
        {
            int resultado = operador == "+" ? a + b : a * b;
            return $"{a} {operador} {b} = {resultado}";
        };
        Console.WriteLine(formatearOperacion(5, 3, "+")); // 5 + 3 = 8
        Console.WriteLine(formatearOperacion(5, 3, "*")); // 5 * 3 = 15
```

**Variantes de Func:**

```csharp
Func<TResult>                    // Sin parámetros, retorna TResult
Func<T, TResult>                 // 1 parámetro, retorna TResult
Func<T1, T2, TResult>            // 2 parámetros, retorna TResult
Func<T1, T2, T3, TResult>        // 3 parámetros, retorna TResult
// ... hasta Func<T1, T2, ..., T16, TResult>

```

**Ejemplo práctico con Func:**

```csharp
// Código ejecutable
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Transformar:  duplicar cada número
        int[] duplicados = TransformarArray(numeros, n => n * 2);
        Console.WriteLine($"Duplicados: [{string.Join(", ", duplicados)}]");
        
        // Transformar: convertir a string
        string[] textos = TransformarArray(numeros, n => $"Número {n}");
        Console.WriteLine($"Textos: [{string.Join(", ", textos)}]");
        
        // Filtrar: solo pares
        int[] pares = FiltrarArray(numeros, n => n % 2 == 0);
        Console.WriteLine($"Pares: [{string.Join(", ", pares)}]");
        
        // Filtrar: mayores que 5
        int[] mayores = FiltrarArray(numeros, n => n > 5);
        Console.WriteLine($"Mayores que 5: [{string.Join(", ", mayores)}]");
```

**`Predicate<T>`**

`Predicate<T>` es un delegate especial que representa un método que recibe un parámetro de tipo `T` y retorna `bool`. Es equivalente a `Func<T, bool>`, pero semánticamente indica que se está evaluando una condición.

```csharp
// Código ejecutable
        // Predicate<T> es equivalente a Func<T, bool>
        Predicate<int> esPar = numero => numero % 2 == 0;
        
        Console.WriteLine($"¿10 es par? {esPar(10)}"); // True
        Console.WriteLine($"¿7 es par? {esPar(7)}");   // False
        
        // Más predicados
        Predicate<string> esLargo = texto => texto.Length > 5;
        Predicate<int> esPositivo = numero => numero > 0;
        Predicate<int> esMultiploDe3 = numero => numero % 3 == 0;
        
        Console.WriteLine($"¿'Hola' es largo? {esLargo("Hola")}");           // False
        Console.WriteLine($"¿'Bienvenido' es largo? {esLargo("Bienvenido")}"); // True
        Console.WriteLine($"¿5 es positivo? {esPositivo(5)}");                // True
        Console.WriteLine($"¿-3 es positivo? {esPositivo(-3)}");              // False
        Console.WriteLine($"¿9 es múltiplo de 3? {esMultiploDe3(9)}");        // True
```

**Array con métodos que usan Predicate:**

```csharp
// Código ejecutable
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Array. Exists: verifica si existe algún elemento que cumpla
        bool hayPares = Array.Exists(numeros, n => n % 2 == 0);
        Console.WriteLine($"¿Hay números pares? {hayPares}"); // True
        
        // Array.Find: encuentra el primer elemento que cumple
        int primerPar = Array.Find(numeros, n => n % 2 == 0);
        Console.WriteLine($"Primer par: {primerPar}"); // 2
        
        // Array.FindAll: encuentra todos los elementos que cumplen
        int[] pares = Array.FindAll(numeros, n => n % 2 == 0);
        Console.WriteLine($"Todos los pares: [{string.Join(", ", pares)}]");
        
        // Array.TrueForAll: verifica si todos los elementos cumplen
        bool todosPositivos = Array.TrueForAll(numeros, n => n > 0);
        Console.WriteLine($"¿Todos son positivos? {todosPositivos}"); // True
        
        bool todosMayoresDe5 = Array.TrueForAll(numeros, n => n > 5);
        Console.WriteLine($"¿Todos son mayores de 5? {todosMayoresDe5}"); // False
```

**`Comparison<T>`**

`Comparison<T>` representa un método que compara dos objetos del mismo tipo y retorna un entero que indica su orden relativo.

```csharp
// Código ejecutable
        string[] palabras = { "banana", "manzana", "cereza", "durazno", "arándano" };
        
        Console.WriteLine($"Original: [{string.Join(", ", palabras)}]");
        
        // Ordenar alfabéticamente (ascendente)
        Array.Sort(palabras, (a, b) => string.Compare(a, b, StringComparison.Ordinal));
        Console.WriteLine($"Ascendente: [{string.Join(", ", palabras)}]");
        
        // Ordenar alfabéticamente (descendente)
        Array.Sort(palabras, (a, b) => string.Compare(b, a, StringComparison.Ordinal));
        Console.WriteLine($"Descendente: [{string.Join(", ", palabras)}]");
        
        // Ordenar por longitud
        Array.Sort(palabras, (a, b) => a.Length.CompareTo(b. Length));
        Console.WriteLine($"Por longitud: [{string.Join(", ", palabras)}]");
        
        // Ordenar por longitud descendente
        Array.Sort(palabras, (a, b) => b.Length.CompareTo(a.Length));
        Console.WriteLine($"Por longitud desc: [{string.Join(", ", palabras)}]");
```

**Cuándo usar cada uno:**

| Delegate     | Cuándo usar                                      | Ejemplo                                                       |
| ------------ | ------------------------------------------------ | ------------------------------------------------------------- |
| `Action`     | Método que realiza una acción sin retornar valor | `Action<string> log = mensaje => Console.WriteLine(mensaje);` |
| `Func`       | Método que calcula y retorna un valor            | `Func<int, int, int> sumar = (a, b) => a + b;`                |
| `Predicate`  | Método que evalúa una condición (retorna bool)   | `Predicate<int> esPar = n => n % 2 == 0;`                     |
| `Comparison` | Método que compara dos objetos del mismo tipo    | `Comparison<int> comparar = (a, b) => a. CompareTo(b);`       |

**Ejemplo integrador:**

```csharp
class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public override string ToString()
    {
        return $"{Nombre} (${Precio}, Stock: {Stock})";
    }
}

// Código ejecutable
        Producto[] productos = new Producto[]
        {
            new Producto { Nombre = "Laptop", Precio = 1200, Stock = 5 },
            new Producto { Nombre = "Mouse", Precio = 25, Stock = 50 },
            new Producto { Nombre = "Teclado", Precio = 75, Stock = 0 },
            new Producto { Nombre = "Monitor", Precio = 300, Stock = 10 },
            new Producto { Nombre = "Webcam", Precio = 80, Stock = 0 }
        };
        
        // Action: mostrar cada producto
        Action<Producto> mostrar = p => Console.WriteLine($"  - {p}");
        
        Console.WriteLine("=== Todos los productos ===");
        Array.ForEach(productos, mostrar);
        
        // Predicate: encontrar productos sin stock
        Predicate<Producto> sinStock = p => p.Stock == 0;
        Producto[] productosAgotados = Array.FindAll(productos, sinStock);
        
        Console.WriteLine("\n=== Productos agotados ===");
        Array.ForEach(productosAgotados, mostrar);
        
        // Func: calcular valor total del inventario
        Func<Producto, decimal> valorInventario = p => p.Precio * p.Stock;
        
        decimal totalInventario = 0;
        foreach (Producto p in productos)
        {
            totalInventario += valorInventario(p);
        }
        Console.WriteLine($"\n=== Valor total del inventario: ${totalInventario} ===");
        
        // Comparison: ordenar por precio
        Comparison<Producto> compararPorPrecio = (p1, p2) => p1.Precio.CompareTo(p2.Precio);
        Array.Sort(productos, compararPorPrecio);
        
        Console.WriteLine("\n=== Productos ordenados por precio ===");
        Array.ForEach(productos, mostrar);
```

#### 3.2.4. Multicast Delegates

Los delegates en C# pueden apuntar a **múltiples métodos** a la vez. Cuando invocas un multicast delegate, se ejecutan todos los métodos en el orden en que fueron agregados.

**Combinación de delegates:**

```csharp
// Código ejecutable
        // Crear delegate apuntando a un método
        Action delegado = Metodo1;
        
        // Invocar
        Console.WriteLine("=== Invocando un solo método ===");
        delegado();
        
        // Agregar más métodos con +=
        delegado += Metodo2;
        delegado += Metodo3;
        
        // Ahora invoca los tres métodos
        Console.WriteLine("\n=== Invocando multicast delegate ===");
        delegado();
        
        // Quitar un método con -=
        delegado -= Metodo2;
        
        Console.WriteLine("\n=== Después de quitar Método 2 ===");
        delegado();

// Funciones locales
    void Metodo1()
    {
        Console.WriteLine("Ejecutando Método 1");
    }

    void Metodo2()
    {
        Console.WriteLine("Ejecutando Método 2");
    }

    void Metodo3()
    {
        Console.WriteLine("Ejecutando Método 3");
    }
```

**Operadores `+`, `+=`, `-`, `-=`:**

```csharp
// Código ejecutable
        Action saludar = null;
        
        // Operador +=:  agregar método
        saludar += SaludarEspañol;
        saludar += SaludarIngles;
        saludar += SaludarFrances;
        
        Console.WriteLine("=== Saludos en 3 idiomas ===");
        saludar();
        
        // Operador -=:  quitar método
        saludar -= SaludarIngles;
        
        Console. WriteLine("\n=== Sin inglés ===");
        saludar();
        
        // Operador +: crear nuevo delegate combinado (sin modificar el original)
        Action saludarMas = saludar + SaludarIngles;
        
        Console. WriteLine("\n=== Delegate original (sin cambios) ===");
        saludar();
        
        Console.WriteLine("\n=== Delegate nuevo (con inglés) ===");
        saludarMas();

// Funciones locales
    void SaludarEspañol()
    {
        Console.WriteLine("¡Hola!");
    }

    void SaludarIngles()
    {
        Console.WriteLine("Hello!");
    }

    void SaludarFrances()
    {
        Console. WriteLine("Bonjour!");
    }
```

**Orden de invocación:**

Los métodos se ejecutan en el orden en que fueron agregados (FIFO - First In, First Out).

```csharp
// Código ejecutable
        Action pipeline = null;
        
        // El orden importa
        pipeline += Paso1;
        pipeline += Paso2;
        pipeline += Paso3;
        
        Console.WriteLine("=== Ejecutar pipeline ===");
        pipeline();
        // Salida: 
        // 1. Inicializar
        // 2. Procesar
        // 3. Finalizar

// Funciones locales
    void Paso1() => Console.WriteLine("1. Inicializar");

    void Paso2() => Console.WriteLine("2. Procesar");

    void Paso3() => Console.WriteLine("3. Finalizar");
```

**Manejo de valores de retorno:**

Con multicast delegates que retornan valores, **solo se obtiene el valor del último método** ejecutado.

```csharp
// Código ejecutable
        Func<int> delegado = Metodo1;
        delegado += Metodo2;
        delegado += Metodo3;
        
        Console.WriteLine("=== Invocando multicast delegate con retorno ===");
        int resultado = delegado();
        
        // Se ejecutan todos los métodos, pero solo se retorna el último valor
        Console.WriteLine($"\nResultado obtenido: {resultado}"); // 30
        
        // Para obtener todos los valores, usar GetInvocationList()
        Console.WriteLine("\n=== Obteniendo todos los valores de retorno ===");
        foreach (Func<int> metodo in delegado.GetInvocationList())
        {
            int valor = metodo();
            Console.WriteLine($"Valor retornado:  {valor}");
        }

// Funciones locales
    int Metodo1()
    {
        Console.WriteLine("Método 1 ejecutado");
        return 10;
    }

    int Metodo2()
    {
        Console.WriteLine("Método 2 ejecutado");
        return 20;
    }

    int Metodo3()
    {
        Console.WriteLine("Método 3 ejecutado");
        return 30;
    }
```

**Ejemplo práctico: Sistema de notificaciones:**

```csharp
class SistemaNotificaciones
{
    // Delegate para notificaciones
    private Action<string> notificadores;
    // Agregar notificador
    public void SuscribirNotificador(Action<string> notificador)
    {
        notificadores += notificador;
    }
    // Quitar notificador
    public void DesuscribirNotificador(Action<string> notificador)
    {
        notificadores -= notificador;
    }
    // Enviar notificación a todos
    public void Notificar(string mensaje)
    {
        if (notificadores != null)
        {
            notificadores(mensaje);
        }
        else
        {
            Console. WriteLine("No hay notificadores suscritos");
        }
    }
}

// Código ejecutable
        SistemaNotificaciones sistema = new SistemaNotificaciones();
        
        // Suscribir notificadores
        sistema.SuscribirNotificador(NotificadorEmail);
        sistema.SuscribirNotificador(NotificadorSMS);
        sistema.SuscribirNotificador(NotificadorPush);
        
        // Enviar notificación (llega a todos)
        Console.WriteLine("=== Notificación 1 ===");
        sistema.Notificar("¡Nuevo mensaje!");
        
        // Desuscribir SMS
        sistema.DesuscribirNotificador(NotificadorSMS);
        
        // Enviar otra notificación
        Console.WriteLine("\n=== Notificación 2 (sin SMS) ===");
        sistema.Notificar("¡Actualización disponible!");
        
        // Agregar otro notificador
        sistema.SuscribirNotificador(NotificadorConsola);
        
        // Enviar tercera notificación
        Console. WriteLine("\n=== Notificación 3 (con Consola) ===");
        sistema.Notificar("¡Sistema reiniciado!");

// Funciones locales
    void NotificadorEmail(string mensaje)
    {
        Console.WriteLine($"📧 Email:  {mensaje}");
    }

    void NotificadorSMS(string mensaje)
    {
        Console.WriteLine($"📱 SMS: {mensaje}");
    }

    void NotificadorPush(string mensaje)
    {
        Console.WriteLine($"🔔 Push: {mensaje}");
    }

    void NotificadorConsola(string mensaje)
    {
        Console.WriteLine($"💻 Consola: {mensaje}");
    }
```

**Ejemplo práctico: Pipeline de procesamiento:**

```csharp
// Código ejecutable
        // Crear pipeline de procesamiento
        ProcesadorDatos pipeline = ValidarDatos;
        pipeline += TransformarMayusculas;
        pipeline += AgregarTimestamp;
        pipeline += LogearProceso;
        
        // Ejecutar con diferentes datos
        Console.WriteLine("=== Procesamiento 1 ===");
        EjecutarPipeline("hola mundo", pipeline);
        
        Console.WriteLine("\n=== Procesamiento 2 ===");
        EjecutarPipeline("", pipeline);

// Funciones locales
    void ValidarDatos(ref string datos)
    {
        Console.WriteLine("  [1] Validando datos...");
        if (string.IsNullOrWhiteSpace(datos))
        {
            datos = "DATOS_INVALIDOS";
        }
    }

    void TransformarMayusculas(ref string datos)
    {
        Console.WriteLine("  [2] Transformando a mayúsculas...");
        datos = datos.ToUpper();
    }

    void AgregarTimestamp(ref string datos)
    {
        Console.WriteLine("  [3] Agregando timestamp.. .");
        datos = $"[{DateTime.Now:HH:mm:ss}] {datos}";
    }

    void LogearProceso(ref string datos)
    {
        Console.WriteLine("  [4] Logeando proceso...");
        Console.WriteLine($"      Dato procesado: {datos}");
    }

    void EjecutarPipeline(string datosIniciales, ProcesadorDatos pipeline)
    {
        string datos = datosIniciales;
        Console.WriteLine($"Datos iniciales: '{datos}'");
        Console.WriteLine("Iniciando pipeline:");
        
        if (pipeline != null)
        {
            pipeline(ref datos);
        }
        
        Console.WriteLine($"Datos finales: '{datos}'");
    }
```

### 3.3. Expresiones Lambda

Las expresiones lambda son una forma concisa de escribir funciones anónimas.  Son la sintaxis más moderna y práctica para trabajar con delegates en C#.

#### 3.3.1. Sintaxis Básica

La sintaxis general de una expresión lambda es: 

```
(parámetros) => expresión
```

o

```
(parámetros) => { bloque de código }
```

**Forma general:  `(parámetros) => expresión`**

```csharp
// Código ejecutable
        // Lambda simple:  un parámetro, una expresión
        Func<int, int> cuadrado = x => x * x;
        Console.WriteLine($"Cuadrado de 5: {cuadrado(5)}"); // 25
        
        // Lambda:  dos parámetros, una expresión
        Func<int, int, int> sumar = (a, b) => a + b;
        Console.WriteLine($"5 + 3 = {sumar(5, 3)}"); // 8
        
        // Lambda:  sin parámetros
        Func<int> obtenerCuarenta = () => 40 + 2;
        Console.WriteLine($"Resultado: {obtenerCuarenta()}"); // 42
```

**Lambda con un parámetro:  `x => x * 2`**

Cuando hay un solo parámetro, los paréntesis son opcionales:

```csharp
// Código ejecutable
        // Con paréntesis (opcional)
        Func<int, int> duplicar1 = (x) => x * 2;
        
        // Sin paréntesis (más común)
        Func<int, int> duplicar2 = x => x * 2;
        
        Console.WriteLine(duplicar1(5)); // 10
        Console.WriteLine(duplicar2(5)); // 10
        
        // Más ejemplos con un parámetro
        Func<string, int> longitud = texto => texto.Length;
        Func<int, bool> esPar = numero => numero % 2 == 0;
        Func<double, double> raizCuadrada = x => Math.Sqrt(x);
        
        Console.WriteLine($"Longitud de 'Hola': {longitud("Hola")}"); // 4
        Console.WriteLine($"¿8 es par? {esPar(8)}"); // True
        Console.WriteLine($"Raíz de 16: {raizCuadrada(16)}"); // 4
```

**Lambda sin parámetros: `() => Console.WriteLine("Hola")`**

Los paréntesis vacíos son obligatorios cuando no hay parámetros:

```csharp
// Código ejecutable
        // Sin parámetros
        Action saludar = () => Console.WriteLine("¡Hola!");
        Func<int> obtenerNumeroAleatorio = () => new Random().Next(1, 100);
        Func<DateTime> obtenerFechaActual = () => DateTime.Now;
        
        saludar(); // ¡Hola!
        Console.WriteLine($"Número aleatorio: {obtenerNumeroAleatorio()}");
        Console.WriteLine($"Fecha actual: {obtenerFechaActual()}");
```

#### 3.3.2. Variantes Sintácticas

**Lambda con múltiples parámetros:  `(x, y) => x + y`**

Con dos o más parámetros, los paréntesis son obligatorios:

```csharp
// Código ejecutable
        // Dos parámetros
        Func<int, int, int> multiplicar = (a, b) => a * b;
        Console.WriteLine($"5 * 3 = {multiplicar(5, 3)}"); // 15
        
        // Tres parámetros
        Func<int, int, int, int> sumarTres = (a, b, c) => a + b + c;
        Console.WriteLine($"1 + 2 + 3 = {sumarTres(1, 2, 3)}"); // 6
        
        // Cuatro parámetros
        Func<string, string, string, string, string> concatenar = 
            (a, b, c, d) => $"{a} {b} {c} {d}";
        Console.WriteLine(concatenar("La", "programación", "es", "genial"));
        
        // Parámetros de diferentes tipos
        Func<string, int, bool, string> formatear = 
            (nombre, edad, activo) => $"{nombre}, {edad} años, {(activo ? "Activo" : "Inactivo")}";
        Console. WriteLine(formatear("Ana", 25, true));
```

**Lambda con cuerpo de expresión (expression body)**

Cuando la lambda consiste en una sola expresión, se puede escribir sin llaves ni `return`:

```csharp
// Código ejecutable
        // Expression body (sin llaves)
        Func<int, int, int> maximo = (a, b) => a > b ? a : b;
        
        // Equivalente con statement body
        Func<int, int, int> maximoExplicito = (a, b) =>
        {
            return a > b ? a : b;
        };
        
        Console.WriteLine($"Máximo entre 10 y 5: {maximo(10, 5)}"); // 10
        
        // Más ejemplos de expression body
        Func<string, string> aMayusculas = texto => texto.ToUpper();
        Func<int, int> absoluto = x => x < 0 ? -x : x;
        Func<string, bool> esVacio = texto => string.IsNullOrEmpty(texto);
        
        Console.WriteLine(aMayusculas("hola")); // HOLA
        Console.WriteLine($"Absoluto de -5: {absoluto(-5)}"); // 5
        Console.WriteLine($"¿'' es vacío? {esVacio("")}"); // True
```

**Lambda con cuerpo de bloque (statement body)**

Cuando necesitas varias líneas de código, usa llaves y `return` explícito:

```csharp
// Código ejecutable
        // Statement body (con llaves)
        Func<int, int, string> compararNumeros = (a, b) =>
        {
            if (a > b)
            {
                return $"{a} es mayor que {b}";
            }
            else if (a < b)
            {
                return $"{a} es menor que {b}";
            }
            else
            {
                return $"{a} es igual a {b}";
            }
        };
        
        Console.WriteLine(compararNumeros(10, 5));  // 10 es mayor que 5
        Console.WriteLine(compararNumeros(3, 8));   // 3 es menor que 8
        Console.WriteLine(compararNumeros(7, 7));   // 7 es igual a 7
        
        // Lambda compleja con múltiples líneas
        Func<int[], string> analizarArray = numeros =>
        {
            if (numeros == null || numeros.Length == 0)
            {
                return "Array vacío";
            }
            
            int suma = 0;
            int maximo = numeros[0];
            int minimo = numeros[0];
            
            foreach (int numero in numeros)
            {
                suma += numero;
                if (numero > maximo) maximo = numero;
                if (numero < minimo) minimo = numero;
            }
            
            double promedio = suma / (double)numeros.Length;
            
            return $"Elementos: {numeros.Length}, Suma: {suma}, Promedio: {promedio:F2}, " +
                   $"Máximo: {maximo}, Mínimo: {minimo}";
        };
        
        int[] datos = { 5, 2, 8, 1, 9, 3 };
        Console.WriteLine(analizarArray(datos));
```

**Action con statement body:**

```csharp
// Código ejecutable
        // Action con statement body
        Action<int[]> mostrarEstadisticas = numeros =>
        {
            Console.WriteLine("=== Estadísticas ===");
            Console.WriteLine($"Cantidad de elementos: {numeros.Length}");
            
            int suma = 0;
            foreach (int n in numeros)
            {
                suma += n;
            }
            
            double promedio = suma / (double)numeros.Length;
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine("====================");
        };
        
        int[] numeros = { 10, 20, 30, 40, 50 };
        mostrarEstadisticas(numeros);
```

**Inferencia de tipos en parámetros**

El compilador puede inferir los tipos de los parámetros lambda:

```csharp
// Código ejecutable
        // El compilador infiere que x es int, y es int
        Func<int, int, int> sumar = (x, y) => x + y;
        
        // El compilador infiere que texto es string
        Func<string, int> longitud = texto => texto. Length;
        
        // Inferencia con múltiples parámetros de diferentes tipos
        Func<string, int, bool> verificarLongitud = (texto, longitudMinima) => 
            texto.Length >= longitudMinima;
        
        Console.WriteLine(sumar(5, 3)); // 8
        Console.WriteLine(longitud("Hola")); // 4
        Console.WriteLine(verificarLongitud("Programación", 10)); // True
```

**Tipos explícitos en parámetros**

Puedes especificar explícitamente los tipos si lo prefieres o si el compilador no puede inferirlos:

```csharp
// Código ejecutable
        // Con tipos explícitos
        Func<int, int, int> dividir = (int a, int b) => a / b;
        
        // Con tipos explícitos (más verboso)
        Func<string, string, bool> sonIguales = 
            (string texto1, string texto2) => texto1 == texto2;
        
        Console.WriteLine(dividir(10, 2)); // 5
        Console.WriteLine(sonIguales("hola", "hola")); // True
        
        // A veces es necesario para evitar ambigüedad
        Func<object, string> convertir = (object obj) => obj.ToString();
        Console.WriteLine(convertir(42)); // "42"
```

#### 3.3.3. Captura de Variables (Closures)

Las lambdas pueden **capturar** variables del ámbito externo.  Esto se conoce como **closure**.

**Variables locales capturadas:**

```csharp
// Código ejecutable
        int multiplicador = 10;
        
        // La lambda captura 'multiplicador'
        Func<int, int> multiplicar = x => x * multiplicador;
        
        Console.WriteLine(multiplicar(5)); // 50
        
        // Si cambiamos multiplicador, la lambda ve el cambio
        multiplicador = 20;
        Console.WriteLine(multiplicar(5)); // 100
        
        // Otro ejemplo
        string prefijo = "Señor";
        
        Func<string, string> saludar = nombre => $"Hola, {prefijo} {nombre}";
        Console.WriteLine(saludar("García")); // Hola, Señor García
        
        prefijo = "Doctor";
        Console.WriteLine(saludar("García")); // Hola, Doctor García
```

**Captura de variables en bucles:**

⚠️ **CUIDADO**:  Capturar variables de bucle puede causar comportamientos inesperados: 

```csharp
// Código ejecutable
        // ❌ INCORRECTO: captura la variable del bucle
        List<Func<int>> funciones1 = new List<Func<int>>();
        
        for (int i = 0; i < 5; i++)
        {
            // PROBLEMA: todas las lambdas capturan la MISMA variable 'i'
            funciones1.Add(() => i);
        }
        
        Console.WriteLine("=== Incorrecto ===");
        foreach (var func in funciones1)
        {
            Console.WriteLine(func()); // Imprime 5, 5, 5, 5, 5 (todas capturan el valor final)
        }
        
        // ✓ CORRECTO: usar variable local
        List<Func<int>> funciones2 = new List<Func<int>>();
        
        for (int i = 0; i < 5; i++)
        {
            int capturada = i; // Variable local diferente en cada iteración
            funciones2.Add(() => capturada);
        }
        
        Console.WriteLine("\n=== Correcto ===");
        foreach (var func in funciones2)
        {
            Console.WriteLine(func()); // Imprime 0, 1, 2, 3, 4
        }
```

**Variables de instancia:**

```csharp
class Contador
{
    private int cuenta = 0;
    public Func<int> Incrementar { get; private set; }
    public Func<int> Obtener { get; private set; }
    public Action Reiniciar { get; private set; }
    public Contador()
    {
        // Las lambdas capturan 'cuenta' (campo de instancia)
        Incrementar = () => ++cuenta;
        Obtener = () => cuenta;
        Reiniciar = () => cuenta = 0;
    }
}

// Código ejecutable
        Contador contador = new Contador();
        
        Console.WriteLine($"Cuenta inicial: {contador.Obtener()}"); // 0
        
        contador. Incrementar();
        contador.Incrementar();
        contador.Incrementar();
        
        Console.WriteLine($"Después de incrementar:  {contador.Obtener()}"); // 3
        
        contador.Reiniciar();
        Console.WriteLine($"Después de reiniciar: {contador.Obtener()}"); // 0
```

**Ciclo de vida de variables capturadas:**

```csharp
// Código ejecutable
        Func<int> contador1 = CrearContador();
        Func<int> contador2 = CrearContador();
        
        // Cada contador tiene su propia variable 'cuenta' capturada
        Console.WriteLine($"Contador 1: {contador1()}"); // 1
        Console.WriteLine($"Contador 1: {contador1()}"); // 2
        Console.WriteLine($"Contador 1: {contador1()}"); // 3
        
        Console.WriteLine($"Contador 2: {contador2()}"); // 1
        Console.WriteLine($"Contador 2: {contador2()}"); // 2
        
        // Los contadores son independientes
        Console.WriteLine($"Contador 1: {contador1()}"); // 4

// Funciones locales
    Func<int> CrearContador()
    {
        int cuenta = 0; // Variable local
        
        // La lambda captura 'cuenta'
        // La variable 'cuenta' sobrevive mientras exista la lambda
        return () => ++cuenta;
    }
```

**Precauciones y buenas prácticas:**

```csharp
// Código ejecutable
        // ✓ BUENA PRÁCTICA: Variables inmutables
        int valorFijo = 10;
        Func<int, int> multiplicar = x => x * valorFijo;
        // valorFijo no cambia, comportamiento predecible
        
        // ⚠️ PRECAUCIÓN: Variables mutables
        int contador = 0;
        Action incrementar = () => contador++;
        // contador puede cambiar, puede causar efectos secundarios
        
        // ✓ BUENA PRÁCTICA: Documentar closures complejos
        string configuracion = "modo-simple";
        
        Func<string, string> procesar = datos =>
        {
            // Esta lambda captura 'configuracion'
            // Si 'configuracion' cambia externamente, el comportamiento cambia
            return configuracion == "modo-simple" 
                ? datos. ToLower() 
                : datos. ToUpper();
        };
        
        Console.WriteLine(procesar("HOLA")); // hola
        
        configuracion = "modo-avanzado";
        Console.WriteLine(procesar("HOLA")); // HOLA
        
        // ✓ BUENA PRÁCTICA: Evitar capturar muchas variables
        // Es mejor pasar las variables como parámetros cuando sea posible
        int a = 10, b = 20, c = 30; // Muchas variables
        
        // Evitar esto:
        Func<int> calcularMalo = () => a + b + c;
        
        // Mejor esto:
        Func<int, int, int, int> calcularBueno = (x, y, z) => x + y + z;
        Console.WriteLine(calcularBueno(a, b, c));
```

**Ejemplo práctico:  Factory de funciones con closures:**

```csharp
// Código ejecutable
        // Crear validadores personalizados
        var validarEdad = CrearValidadorRango(0, 120);
        var validarMes = CrearValidadorRango(1, 12);
        var validarPorcentaje = CrearValidadorRango(0, 100);
        
        Console.WriteLine($"¿25 es edad válida? {validarEdad(25)}");     // True
        Console.WriteLine($"¿150 es edad válida? {validarEdad(150)}");   // False
        Console.WriteLine($"¿6 es mes válido? {validarMes(6)}");         // True
        Console.WriteLine($"¿13 es mes válido? {validarMes(13)}");       // False
        
        // Crear formateadores personalizados
        var formatearHTML = CrearFormateador("<b>", "</b>");
        var formatearParentesis = CrearFormateador("(", ")");
        
        Console.WriteLine(formatearHTML("importante"));       // <b>importante</b>
        Console.WriteLine(formatearParentesis("opcional"));   // (opcional)
        
        // Crear acumuladores
        var acumulador1 = CrearAcumulador(0);
        var acumulador2 = CrearAcumulador(100);
        
        Console.WriteLine($"Acumulador 1: {acumulador1(5)}");   // 5
        Console.WriteLine($"Acumulador 1: {acumulador1(3)}");   // 8
        Console.WriteLine($"Acumulador 1: {acumulador1(2)}");   // 10
        
        Console.WriteLine($"Acumulador 2: {acumulador2(10)}");  // 110
        Console.WriteLine($"Acumulador 2: {acumulador2(5)}");   // 115

// Funciones locales
    // Factory que crea funciones de validación
    Func<int, bool> CrearValidadorRango(int minimo, int maximo)
    {
        // Las variables 'minimo' y 'maximo' son capturadas
        return valor => valor >= minimo && valor <= maximo;
    }

    
    // Factory que crea funciones de transformación
    Func<string, string> CrearFormateador(string prefijo, string sufijo)
    {
        // Captura 'prefijo' y 'sufijo'
        return texto => $"{prefijo}{texto}{sufijo}";
    }

    
    // Factory que crea acumuladores
    Func<int, int> CrearAcumulador(int valorInicial)
    {
        int acumulado = valorInicial; // Capturada y mutable
        return incremento =>
        {
            acumulado += incremento;
            return acumulado;
        };
    }
```

---

### 3.4. Funciones Anónimas

Las **funciones anónimas** usando la palabra clave `delegate` son una forma más antigua de crear delegates sin nombre.  Las lambdas son más modernas y concisas, pero las funciones anónimas todavía se encuentran en código legacy.

#### 3.4.1. Métodos anónimos con `delegate`

**Sintaxis:  `delegate (parámetros) { ...  }`**

```csharp
// Código ejecutable
        // Función anónima con delegate
        Func<int, int, int> sumar = delegate(int a, int b)
        {
            return a + b;
        };
        
        Console.WriteLine($"5 + 3 = {sumar(5, 3)}"); // 8
        
        // Sin parámetros
        Action saludar = delegate()
        {
            Console.WriteLine("¡Hola desde función anónima!");
        };
        
        saludar();
        
        // Con un parámetro
        Action<string> mostrar = delegate(string mensaje)
        {
            Console.WriteLine($"Mensaje: {mensaje}");
        };
        
        mostrar("Esto es una función anónima");
```

**Ejemplo con múltiples líneas:**

```csharp
// Código ejecutable
        // Función anónima compleja
        Func<int, int, string> operacion = delegate(int a, int b)
        {
            int suma = a + b;
            int producto = a * b;
            int diferencia = a - b;
            
            return $"Suma: {suma}, Producto: {producto}, Diferencia: {diferencia}";
        };
        
        Console.WriteLine(operacion(10, 5));
        // Suma: 15, Producto: 50, Diferencia: 5
```

#### 3.4.2. Comparación con expresiones lambda

```csharp
// Código ejecutable
        // ===  FUNCIÓN ANÓNIMA (delegate) ===
        Func<int, int> cuadradoDelegate = delegate(int x)
        {
            return x * x;
        };
        
        // === LAMBDA (moderna) ===
        Func<int, int> cuadradoLambda = x => x * x;
        
        Console.WriteLine($"Delegate: {cuadradoDelegate(5)}"); // 25
        Console.WriteLine($"Lambda: {cuadradoLambda(5)}");     // 25
        
        // Ambas hacen lo mismo, pero lambda es más concisa
        
        // === Comparación con múltiples líneas ===
        
        // Función anónima
        Func<int, bool> esPrimoDelegate = delegate(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        };
        
        // Lambda equivalente
        Func<int, bool> esPrimoLambda = numero =>
        {
            if (numero < 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        };
        
        Console.WriteLine($"¿7 es primo? (delegate): {esPrimoDelegate(7)}");
        Console.WriteLine($"¿7 es primo? (lambda): {esPrimoLambda(7)}");
```

**Tabla comparativa:**

| Aspecto                   | Función Anónima (delegate)          | Lambda          |
| ------------------------- | ----------------------------------- | --------------- |
| **Sintaxis**              | `delegate(int x) { return x * 2; }` | `x => x * 2`    |
| **Verbosidad**            | Más verbosa                         | Más concisa     |
| **Legibilidad**           | Menos legible                       | Más legible     |
| **Uso moderno**           | Legacy, poco usada                  | Estándar actual |
| **Parámetros opcionales** | Permite omitir lista de parámetros  | No permite      |
| **Introducción**          | C# 2.0 (2005)                       | C# 3.0 (2007)   |

#### 3.4.3. Cuándo usar métodos anónimos vs.  lambdas

**Usar lambdas (recomendado):**

```csharp
// Código ejecutable
        // ✓ Lambdas para código moderno
        Func<int, int> duplicar = x => x * 2;
        Action<string> log = mensaje => Console.WriteLine(mensaje);
        Predicate<int> esPar = n => n % 2 == 0;
        
        // ✓ Lambdas con operaciones LINQ
        int[] numeros = { 1, 2, 3, 4, 5 };
        var pares = Array.FindAll(numeros, n => n % 2 == 0);
        
        // ✓ Lambdas en APIs modernas
        Task. Run(() => Console.WriteLine("Tarea asíncrona"));
```

**Usar funciones anónimas (casos específicos):**

```csharp
// Código ejecutable
        // Caso 1: Omitir lista de parámetros cuando no se usan
        // (raro, pero posible)
        EventHandler manejador = delegate
        {
            Console.WriteLine("Evento disparado");
        };
        
        // Caso 2: Código legacy que ya las usa
        // (mantener consistencia)
        
        // Caso 3: Preferencia del equipo en proyectos antiguos
```

**Recomendación general:**

✓ **Usar lambdas** en código nuevo - son más concisas y modernas
✓ **Usar lambdas** en proyectos modernos de C#
✓ **Mantener funciones anónimas** solo en código legacy existente
✓ **Migrar** de funciones anónimas a lambdas cuando se refactorice código

---

### 3.5. Funciones de Orden Superior

Las **funciones de orden superior** son funciones que: 
- **Reciben** otras funciones como parámetros, o
- **Devuelven** funciones como resultado

Este es uno de los pilares de la programación funcional. 

#### 3.5.1. Funciones que Reciben Funciones

**Concepto y utilidad:**

Una función de orden superior acepta una o más funciones como parámetros, lo que permite **parametrizar el comportamiento**. 

```csharp
// Código ejecutable
        // Pasar diferentes funciones para diferentes comportamientos
        EjecutarOperacion(10, 5, (a, b) => a + b);  // Suma
        EjecutarOperacion(10, 5, (a, b) => a - b);  // Resta
        EjecutarOperacion(10, 5, (a, b) => a * b);  // Multiplicación
        EjecutarOperacion(10, 5, (a, b) => a / b);  // División

// Funciones locales
    // Función de orden superior:  recibe una función como parámetro
    void EjecutarOperacion(int a, int b, Func<int, int, int> operacion)
    {
        int resultado = operacion(a, b);
        Console.WriteLine($"Resultado: {resultado}");
    }
```

**Ejemplos básicos con `Action` y `Func`:**

```csharp
// Código ejecutable
        // Usar RepetirAccion
        Console.WriteLine("=== Repetir acción ===");
        RepetirAccion(5, i => Console.WriteLine($"Iteración {i}"));
        
        // Usar TransformarArray
        int[] numeros = { 1, 2, 3, 4, 5 };
        string[] textos = TransformarArray(numeros, n => $"#{n}");
        Console.WriteLine($"\nTextos: [{string.Join(", ", textos)}]");
        
        // Usar TodosCumplen
        bool todosPositivos = TodosCumplen(numeros, n => n > 0);
        Console.WriteLine($"\n¿Todos positivos? {todosPositivos}");

// Funciones locales
    // Función de orden superior con Action
    void RepetirAccion(int veces, Action<int> accion)
    {
        for (int i = 0; i < veces; i++)
        {
            accion(i);
        }
    }
```

**Patrones comunes:**

```csharp
// Código ejecutable
        // Ejecutar con timeout
        bool completado = EjecutarConTimeout(
            () => {
                System.Threading.Thread.Sleep(100);
                Console.WriteLine("Operación completada");
            },
            200
        );
        Console.WriteLine($"¿Completado? {completado}");
        
        // Medir tiempo
        int resultado = MedirTiempo(
            () => {
                int suma = 0;
                for (int i = 0; i < 1000000; i++) suma += i;
                return suma;
            },
            out long tiempo
        );
        Console.WriteLine($"Resultado: {resultado}, Tiempo: {tiempo}ms");

// Funciones locales
    // Patrón:  Ejecutar con timeout
    bool EjecutarConTimeout(Action accion, int milisegundos)
    {
        var tarea = Task.Run(accion);
        return tarea.Wait(milisegundos);
    }
```

#### 3.5.2. Funciones que Devuelven Funciones

**Currying y aplicación parcial:**

```csharp
// Código ejecutable
        // Crear funciones personalizadas
        var sumar5 = CrearSumador(5);
        var sumar10 = CrearSumador(10);
        var duplicar = CrearMultiplicador(2);
        var triplicar = CrearMultiplicador(3);
        
        Console.WriteLine($"sumar5(3) = {sumar5(3)}");     // 8
        Console.WriteLine($"sumar10(3) = {sumar10(3)}");   // 13
        Console.WriteLine($"duplicar(7) = {duplicar(7)}"); // 14
        Console.WriteLine($"triplicar(7) = {triplicar(7)}"); // 21
        
        // Usar función curried
        var sumarCurried = SumarCurried();
        var sumar20 = sumarCurried(20);
        Console.WriteLine($"sumar20(5) = {sumar20(5)}");   // 25
        
        // O en una línea
        Console.WriteLine($"3 + 4 = {SumarCurried()(3)(4)}"); // 7

// Funciones locales
    // Devuelve una función que "recuerda" el primer parámetro
    Func<int, int> CrearSumador(int valor)
    {
        return x => x + valor;
    }

    
    // Devuelve una función que "recuerda" el multiplicador
    Func<int, int> CrearMultiplicador(int factor)
    {
        return x => x * factor;
    }

    
    // Currying: convertir una función de múltiples parámetros
    // en una cadena de funciones de un parámetro
    Func<int, Func<int, int>> SumarCurried()
    {
        return a => b => a + b;
    }
```

**Factory de funciones:**

```csharp
// Código ejecutable
        // Crear validadores específicos
        var esEdadValida = CrearValidadorRango(0, 120);
        var esPorcentaje = CrearValidadorRango(0, 100);
        var esMesValido = CrearValidadorRango(1, 12);
        
        Console.WriteLine($"¿25 es edad válida? {esEdadValida(25)}");
        Console.WriteLine($"¿150 es edad válida? {esEdadValida(150)}");
        Console.WriteLine($"¿50 es porcentaje válido? {esPorcentaje(50)}");
        
        // Crear formateadores
        var formatearMoneda = CrearFormateadorNumero(2, " €");
        var formatearPorcentaje = CrearFormateadorNumero(1, "%");
        
        Console.WriteLine($"Precio:  {formatearMoneda(1234.567)}");
        Console.WriteLine($"Descuento: {formatearPorcentaje(15. 5)}");
        
        // Combinar filtros
        Func<int, bool> esPar = n => n % 2 == 0;
        Func<int, bool> esMayorQue10 = n => n > 10;
        var esParYMayorQue10 = CombinarFiltros(esPar, esMayorQue10);
        
        int[] numeros = { 5, 12, 7, 16, 20, 3 };
        foreach (int n in numeros)
        {
            if (esParYMayorQue10(n))
            {
                Console.WriteLine($"{n} es par y mayor que 10");
            }
        }

// Funciones locales
    // Factory que crea validadores
    Func<int, bool> CrearValidadorRango(int min, int max)
    {
        return valor => valor >= min && valor <= max;
    }

    
    // Factory que crea formateadores
    Func<double, string> CrearFormateadorNumero(int decimales, string sufijo)
    {
        return numero => $"{numero. ToString($"F{decimales}")}{sufijo}";
    }
```

**Composición de funciones:**

```csharp
// Código ejecutable
        // Funciones individuales
        Func<int, int> duplicar = x => x * 2;
        Func<int, int> sumar10 = x => x + 10;
        Func<int, string> aTexto = x => $"Resultado: {x}";
        
        // Componer funciones
        var duplicarYSumar = Componer(duplicar, sumar10);
        var procesarCompleto = Componer(duplicarYSumar, aTexto);
        
        Console.WriteLine(duplicarYSumar(5));    // (5 * 2) + 10 = 20
        Console.WriteLine(procesarCompleto(5));  // "Resultado: 20"
        
        // Otro ejemplo: pipeline de transformación de texto
        Func<string, string> aMayusculas = s => s.ToUpper();
        Func<string, string> quitarEspacios = s => s.Replace(" ", "");
        Func<string, string> agregarPrefijo = s => $">>>  {s}";
        
        var transformarTexto = Componer(
            Componer(aMayusculas, quitarEspacios),
            agregarPrefijo
        );
        
        Console. WriteLine(transformarTexto("hola mundo"));
        // >>> HOLAMUNDO
```

#### 3.5.3. Implementación de Operaciones Funcionales Básicas (sobre Arrays)

Vamos a implementar las operaciones funcionales más comunes trabajando **exclusivamente con arrays**, ya que aún no hemos visto las colecciones genéricas.

**Implementación de Filter (Where)**

```csharp
class OperacionesFuncionales
{
    // Filter: devuelve un nuevo array con los elementos que cumplen la condición
    public static T[] Filter<T>(T[] array, Func<T, bool> predicado)
    {
        // Primero contamos cuántos elementos cumplen
        int contador = 0;
        foreach (T elemento in array)
        {
            if (predicado(elemento))
            {
                contador++;
            }
        }
        // Crear array del tamaño correcto
        T[] resultado = new T[contador];
        int indice = 0;
        // Llenar el array resultado
        foreach (T elemento in array)
        {
            if (predicado(elemento))
            {
                resultado[indice++] = elemento;
            }
        }
        return resultado;
    }
}

// Código ejecutable
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Filtrar números pares
        int[] pares = OperacionesFuncionales.Filter(numeros, n => n % 2 == 0);
        Console.WriteLine($"Pares: [{string.Join(", ", pares)}]");
        // Pares: [2, 4, 6, 8, 10]
        
        // Filtrar números mayores que 5
        int[] mayores = OperacionesFuncionales.Filter(numeros, n => n > 5);
        Console.WriteLine($"Mayores que 5: [{string.Join(", ", mayores)}]");
        // Mayores que 5: [6, 7, 8, 9, 10]
        
        // Filtrar múltiplos de 3
        int[] multiplosDe3 = OperacionesFuncionales.Filter(numeros, n => n % 3 == 0);
        Console.WriteLine($"Múltiplos de 3: [{string.Join(", ", multiplosDe3)}]");
        // Múltiplos de 3: [3, 6, 9]
        
        // Con strings
        string[] palabras = { "casa", "sol", "programación", "luz", "computadora" };
        string[] largas = OperacionesFuncionales.Filter(palabras, p => p.Length > 4);
        Console.WriteLine($"Palabras largas: [{string.Join(", ", largas)}]");
        // Palabras largas: [programación, computadora]
```

**Implementación de Map (Select)**

```csharp
class OperacionesFuncionales
{
    // Map: transforma cada elemento del array usando una función
    public static TResult[] Map<T, TResult>(T[] array, Func<T, TResult> transformador)
    {
        TResult[] resultado = new TResult[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            resultado[i] = transformador(array[i]);
        }
        return resultado;
    }
}

// Código ejecutable
        int[] numeros = { 1, 2, 3, 4, 5 };
        
        // Duplicar cada número
        int[] duplicados = OperacionesFuncionales.Map(numeros, n => n * 2);
        Console.WriteLine($"Duplicados: [{string.Join(", ", duplicados)}]");
        // Duplicados: [2, 4, 6, 8, 10]
        
        // Elevar al cuadrado
        int[] cuadrados = OperacionesFuncionales.Map(numeros, n => n * n);
        Console.WriteLine($"Cuadrados: [{string.Join(", ", cuadrados)}]");
        // Cuadrados: [1, 4, 9, 16, 25]
        
        // Convertir a strings
        string[] textos = OperacionesFuncionales.Map(numeros, n => $"Número {n}");
        Console.WriteLine($"Textos: [{string.Join(", ", textos)}]");
        // Textos: [Número 1, Número 2, Número 3, Número 4, Número 5]
        
        // Transformar strings
        string[] palabras = { "hola", "mundo", "csharp" };
        string[] mayusculas = OperacionesFuncionales.Map(palabras, p => p.ToUpper());
        Console.WriteLine($"Mayúsculas: [{string.Join(", ", mayusculas)}]");
        // Mayúsculas: [HOLA, MUNDO, CSHARP]
        
        // Obtener longitudes
        int[] longitudes = OperacionesFuncionales.Map(palabras, p => p.Length);
        Console.WriteLine($"Longitudes: [{string.Join(", ", longitudes)}]");
        // Longitudes: [4, 5, 6]
```

**Implementación de Reduce (Aggregate)**

```csharp
class OperacionesFuncionales
{
    // Reduce: reduce el array a un único valor usando una función acumuladora
    public static TResult Reduce<T, TResult>(
        T[] array,
        TResult valorInicial,
        Func<TResult, T, TResult> acumulador)
    {
        TResult resultado = valorInicial;
        foreach (T elemento in array)
        {
            resultado = acumulador(resultado, elemento);
        }
        return resultado;
    }
}

// Código ejecutable
        int[] numeros = { 1, 2, 3, 4, 5 };
        
        // Sumar todos los números
        int suma = OperacionesFuncionales.Reduce(numeros, 0, (acum, n) => acum + n);
        Console.WriteLine($"Suma: {suma}");
        // Suma: 15
        
        // Multiplicar todos los números (factorial)
        int producto = OperacionesFuncionales.Reduce(numeros, 1, (acum, n) => acum * n);
        Console.WriteLine($"Producto: {producto}");
        // Producto: 120
        
        // Encontrar el máximo
        int maximo = OperacionesFuncionales.Reduce(numeros, int.MinValue, 
            (acum, n) => n > acum ? n : acum);
        Console.WriteLine($"Máximo: {maximo}");
        // Máximo:  5
        
        // Concatenar strings
        string[] palabras = { "Hola", "desde", "C#" };
        string frase = OperacionesFuncionales.Reduce(palabras, "", 
            (acum, palabra) => acum + (acum == "" ? "" : " ") + palabra);
        Console.WriteLine($"Frase: {frase}");
        // Frase: Hola desde C#
        
        // Contar elementos que cumplen condición
        int pares = OperacionesFuncionales.Reduce(numeros, 0,
            (acum, n) => n % 2 == 0 ? acum + 1 : acum);
        Console.WriteLine($"Cantidad de pares: {pares}");
        // Cantidad de pares: 2
        
        // Crear un string con los números
        string numerosTexto = OperacionesFuncionales.Reduce(numeros, "[",
            (acum, n) => acum + n + (n == numeros[numeros.Length - 1] ? "]" : ", "));
        Console.WriteLine($"Números: {numerosTexto}");
        // Números: [1, 2, 3, 4, 5]
```

**Ejemplos de transformación de datos:**

```csharp
class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public override string ToString()
    {
        return $"{Nombre} (${Precio}, Stock: {Stock})";
    }
}

// Código ejecutable
        Producto[] productos = new Producto[]
        {
            new Producto { Nombre = "Laptop", Precio = 1200, Stock = 5 },
            new Producto { Nombre = "Mouse", Precio = 25, Stock = 50 },
            new Producto { Nombre = "Teclado", Precio = 75, Stock = 30 },
            new Producto { Nombre = "Monitor", Precio = 300, Stock = 10 }
        };
        
        // Filtrar productos caros (más de $100)
        var productosCaros = OperacionesFuncionales.Filter(productos, p => p. Precio > 100);
        Console.WriteLine("=== Productos caros ===");
        foreach (var p in productosCaros)
        {
            Console.WriteLine($"  - {p}");
        }
        
        // Transformar a nombres
        var nombres = OperacionesFuncionales.Map(productos, p => p.Nombre);
        Console.WriteLine($"\nNombres: [{string. Join(", ", nombres)}]");
        
        // Transformar a precios con descuento del 10%
        var preciosConDescuento = OperacionesFuncionales.Map(productos, 
            p => p.Precio * 0.9m);
        Console.WriteLine($"\nPrecios con descuento: [{string.Join(", ", preciosConDescuento)}]");
        
        // Calcular valor total del inventario
        decimal valorTotal = OperacionesFuncionales.Reduce(productos, 0m,
            (acum, p) => acum + (p.Precio * p.Stock));
        Console.WriteLine($"\nValor total del inventario:  ${valorTotal}");
        
        // Encontrar el producto más caro
        Producto masCaro = OperacionesFuncionales.Reduce(productos, productos[0],
            (acum, p) => p.Precio > acum.Precio ? p : acum);
        Console.WriteLine($"\nProducto más caro: {masCaro. Nombre} (${masCaro. Precio})");
```

**Implementación de Count con Condición**

```csharp
class OperacionesFuncionales
{
    // Count: cuenta cuántos elementos cumplen una condición
    public static int Count<T>(T[] array, Func<T, bool> predicado)
    {
        int contador = 0;
        foreach (T elemento in array)
        {
            if (predicado(elemento))
            {
                contador++;
            }
        }
        return contador;
    }
}

// Código ejecutable
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Contar pares
        int cantidadPares = OperacionesFuncionales.Count(numeros, n => n % 2 == 0);
        Console.WriteLine($"Cantidad de pares: {cantidadPares}");
        // Cantidad de pares: 5
        
        // Contar mayores que 5
        int mayoresQue5 = OperacionesFuncionales.Count(numeros, n => n > 5);
        Console.WriteLine($"Mayores que 5: {mayoresQue5}");
        // Mayores que 5: 5
        
        // Contar múltiplos de 3
        int multiplosDe3 = OperacionesFuncionales.Count(numeros, n => n % 3 == 0);
        Console.WriteLine($"Múltiplos de 3: {multiplosDe3}");
        // Múltiplos de 3: 3
        
        // Con strings
        string[] palabras = { "casa", "sol", "programación", "luz", "computadora" };
        int palabrasLargas = OperacionesFuncionales.Count(palabras, p => p.Length > 5);
        Console.WriteLine($"Palabras con más de 5 letras: {palabrasLargas}");
        // Palabras con más de 5 letras: 2
```

**Otras Operaciones Funcionales (sobre Arrays)**

```csharp
class OperacionesFuncionales
{
    // ForEach: aplica una acción a cada elemento
    public static void ForEach<T>(T[] array, Action<T> accion)
    {
        foreach (T elemento in array)
        {
            accion(elemento);
        }
    }
    // Any: verifica si algún elemento cumple la condición
    public static bool Any<T>(T[] array, Func<T, bool> predicado)
    {
        foreach (T elemento in array)
        {
            if (predicado(elemento))
            {
                return true;
            }
        }
        return false;
    }
    // All: verifica si todos los elementos cumplen la condición
    public static bool All<T>(T[] array, Func<T, bool> predicado)
    {
        foreach (T elemento in array)
        {
            if (!predicado(elemento))
            {
                return false;
            }
        }
        return true;
    }
    // Find/First: encuentra el primer elemento que cumple la condición
    public static T Find<T>(T[] array, Func<T, bool> predicado)
    {
        foreach (T elemento in array)
        {
            if (predicado(elemento))
            {
                return elemento;
            }
        }
        throw new InvalidOperationException("Ningún elemento cumple la condición");
    }
    // TryFind: intenta encontrar el primer elemento que cumple la condición
    public static bool TryFind<T>(T[] array, Func<T, bool> predicado, out T resultado)
    {
        foreach (T elemento in array)
        {
            if (predicado(elemento))
            {
                resultado = elemento;
                return true;
            }
        }
        resultado = default(T);
        return false;
    }
    // Take: toma los primeros n elementos
    public static T[] Take<T>(T[] array, int cantidad)
    {
        int cantidadReal = Math.Min(cantidad, array.Length);
        T[] resultado = new T[cantidadReal];
        for (int i = 0; i < cantidadReal; i++)
        {
            resultado[i] = array[i];
        }
        return resultado;
    }
    // Skip: salta los primeros n elementos
    public static T[] Skip<T>(T[] array, int cantidad)
    {
        int cantidadASaltar = Math.Min(cantidad, array.Length);
        int tamaño = array.Length - cantidadASaltar;
        T[] resultado = new T[tamaño];
        for (int i = 0; i < tamaño; i++)
        {
            resultado[i] = array[i + cantidadASaltar];
        }
        return resultado;
    }
}

// Código ejecutable
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // ForEach
        Console.WriteLine("=== ForEach ===");
        OperacionesFuncionales.ForEach(numeros, n => Console.Write($"{n} "));
        Console.WriteLine();
        
        // Any
        bool hayPares = OperacionesFuncionales.Any(numeros, n => n % 2 == 0);
        bool hayNegativos = OperacionesFuncionales.Any(numeros, n => n < 0);
        Console.WriteLine($"\n¿Hay pares? {hayPares}");
        Console.WriteLine($"¿Hay negativos? {hayNegativos}");
        
        // All
        bool todosPositivos = OperacionesFuncionales.All(numeros, n => n > 0);
        bool todosPares = OperacionesFuncionales.All(numeros, n => n % 2 == 0);
        Console.WriteLine($"¿Todos positivos? {todosPositivos}");
        Console.WriteLine($"¿Todos pares? {todosPares}");
        
        // Find
        int primerPar = OperacionesFuncionales.Find(numeros, n => n % 2 == 0);
        Console.WriteLine($"Primer par: {primerPar}");
        
        // TryFind
        if (OperacionesFuncionales.TryFind(numeros, n => n > 100, out int mayorQue100))
        {
            Console.WriteLine($"Encontrado: {mayorQue100}");
        }
        else
        {
            Console.WriteLine("No se encontró ningún número mayor que 100");
        }
        
        // Take
        int[] primerosTres = OperacionesFuncionales.Take(numeros, 3);
        Console.WriteLine($"Primeros 3: [{string.Join(", ", primerosTres)}]");
        
        // Skip
        int[] sinPrimerosTres = OperacionesFuncionales.Skip(numeros, 3);
        Console.WriteLine($"Sin primeros 3: [{string.Join(", ", sinPrimerosTres)}]");
```


#### 3. 5. 4.  Composición de Operaciones

**Encadenar operaciones funcionales:**

```csharp
// Código ejecutable
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Encadenar Filter -> Map -> Reduce
        // 1. Filtrar pares
        int[] pares = OperacionesFuncionales.Filter(numeros, n => n % 2 == 0);
        
        // 2. Duplicar cada uno
        int[] duplicados = OperacionesFuncionales.Map(pares, n => n * 2);
        
        // 3. Sumar todos
        int suma = OperacionesFuncionales.Reduce(duplicados, 0, (acum, n) => acum + n);
        
        Console.WriteLine($"Resultado del pipeline: {suma}");
        // (2 + 4 + 6 + 8 + 10) * 2 = 60
        
        // O en forma más compacta
        int resultado = OperacionesFuncionales.Reduce(
            OperacionesFuncionales.Map(
                OperacionesFuncionales.Filter(numeros, n => n % 2 == 0),
                n => n * 2
            ),
            0,
            (acum, n) => acum + n
        );
        
        Console.WriteLine($"Resultado compacto: {resultado}");
```

**Ejemplos de pipelines de transformación:**

```csharp
// Código ejecutable
        string[] palabras = { "Casa", "PERRO", "gato", "SOL", "Luna" };
        
        // Pipeline:  filtrar cortas -> mayúsculas -> ordenar -> tomar primeras 3
        
        // 1. Filtrar palabras cortas (menos de 5 letras)
        string[] cortas = OperacionesFuncionales.Filter(palabras, p => p.Length < 5);
        
        // 2. Convertir a mayúsculas
        string[] mayusculas = OperacionesFuncionales.Map(cortas, p => p.ToUpper());
        
        // 3. Ordenar (usando Array.Sort)
        Array.Sort(mayusculas);
        
        // 4. Tomar primeras 3
        string[] primeras3 = OperacionesFuncionales.Take(mayusculas, 3);
        
        Console.WriteLine($"Resultado: [{string.Join(", ", primeras3)}]");
        
        // Pipeline con datos numéricos
        int[] datos = { 15, 8, 23, 4, 16, 42, 11, 7, 19 };
        
        // Filtrar > 10, elevar al cuadrado, tomar primeros 4, sumar
        int resultadoNumerico = OperacionesFuncionales. Reduce(
            OperacionesFuncionales.Take(
                OperacionesFuncionales.Map(
                    OperacionesFuncionales.Filter(datos, n => n > 10),
                    n => n * n
                ),
                4
            ),
            0,
            (acum, n) => acum + n
        );
        
        Console. WriteLine($"Resultado numérico: {resultadoNumerico}");
```

**Consideraciones de rendimiento:**

```csharp
// Código ejecutable
        // Cada operación crea un nuevo array intermedio
        int[] numeros = new int[1000000];
        for (int i = 0; i < numeros. Length; i++)
        {
            numeros[i] = i + 1;
        }
        
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();
        
        // Pipeline con múltiples operaciones
        int resultado = OperacionesFuncionales.Reduce(
            OperacionesFuncionales.Map(
                OperacionesFuncionales.Filter(numeros, n => n % 2 == 0),
                n => n * 2
            ),
            0,
            (acum, n) => acum + n
        );
        
        stopwatch.Stop();
        Console.WriteLine($"Resultado:  {resultado}");
        Console.WriteLine($"Tiempo:  {stopwatch.ElapsedMilliseconds}ms");
        
        // Consideraciones: 
        // - Cada operación crea un array nuevo (uso de memoria)
        // - Se recorre el array múltiples veces (tiempo de CPU)
        // - Para grandes cantidades de datos, considerar otras estrategias
        // - Más adelante veremos LINQ que optimiza estos casos
```

### 3.6. Métodos de Extensión

Los métodos de extensión permiten "añadir" métodos a tipos existentes sin modificar el código fuente original ni usar herencia. 

#### 3.6.1. Fundamentos

**¿Qué son los métodos de extensión?**

Los métodos de extensión son métodos estáticos que se pueden llamar como si fueran métodos de instancia del tipo que extienden. 

**Requisitos:**
1.  Deben estar en una **clase estática**
2. Deben ser **métodos estáticos**
3. El primer parámetro debe tener la palabra clave **`this`** antes del tipo

**Sintaxis:   palabra clave `this` en primer parámetro**

```csharp
public static class ExtensionesString
{
    // Método de extensión para string
    public static int ContarPalabras(this string texto)
    {
        if (string.IsNullOrWhiteSpace(texto))
        {
            return 0;
        }
        return texto.Split(new char[] { ' ', '\t', '\n' }, 
            StringSplitOptions. RemoveEmptyEntries).Length;
    }
}

// Código ejecutable
        string frase = "Hola mundo desde C#";
        
        // Llamar como método de instancia (gracias a la extensión)
        int palabras = frase.ContarPalabras();
        Console.WriteLine($"La frase tiene {palabras} palabras");
        
        // También se puede llamar como método estático
        int palabras2 = ExtensionesString.ContarPalabras(frase);
        Console.WriteLine($"Palabras (llamada estática): {palabras2}");
```

#### 3.6.2. Extensión de Tipos Incorporados

**Extender tipos primitivos: `int`, `string`, etc.**

```csharp
public static class ExtensionesNumericas
{
    // Extensión para int:  verificar si es par
    public static bool EsPar(this int numero)
    {
        return numero % 2 == 0;
    }
    // Extensión para int: verificar si es primo
    public static bool EsPrimo(this int numero)
    {
        if (numero < 2) return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
    // Extensión para int: factorial
    public static long Factorial(this int numero)
    {
        if (numero < 0)
        {
            throw new ArgumentException("El número debe ser no negativo");
        }
        if (numero == 0 || numero == 1)
        {
            return 1;
        }
        long resultado = 1;
        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
    // Extensión para double: redondear a n decimales
    public static double RedondearA(this double numero, int decimales)
    {
        return Math.Round(numero, decimales);
    }
}
public static class ExtensionesString
{
    // Capitalizar primera letra
    public static string Capitalizar(this string texto)
    {
        if (string.IsNullOrEmpty(texto))
        {
            return texto;
        }
        return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
    }
    // Invertir string
    public static string Invertir(this string texto)
    {
        if (string.IsNullOrEmpty(texto))
        {
            return texto;
        }
        char[] caracteres = texto.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }
    // Truncar con puntos suspensivos
    public static string Truncar(this string texto, int longitudMaxima)
    {
        if (string.IsNullOrEmpty(texto) || texto.Length <= longitudMaxima)
        {
            return texto;
        }
        return texto.Substring(0, longitudMaxima - 3) + "...";
    }
    // Repetir n veces
    public static string Repetir(this string texto, int veces)
    {
        if (veces <= 0)
        {
            return string.Empty;
        }
        string resultado = "";
        for (int i = 0; i < veces; i++)
        {
            resultado += texto;
        }
        return resultado;
    }
}

// Código ejecutable
        // Extensiones numéricas
        Console.WriteLine($"¿10 es par? {10.EsPar()}");
        Console.WriteLine($"¿7 es primo? {7.EsPrimo()}");
        Console.WriteLine($"Factorial de 5: {5.Factorial()}");
        Console.WriteLine($"3. 14159 redondeado a 2 decimales: {3.14159.RedondearA(2)}");
        
        // Extensiones de string
        Console.WriteLine($"Capitalizar 'hola': {"hola".Capitalizar()}");
        Console.WriteLine($"Invertir 'mundo': {"mundo".Invertir()}");
        Console.WriteLine($"Truncar:  {"Este es un texto muy largo".Truncar(15)}");
        Console.WriteLine($"Repetir 'Ha' 3 veces: {"Ha". Repetir(3)}");
```

**Extender arrays:**

```csharp
public static class ExtensionesArray
{
    // Imprimir array
    public static void Imprimir<T>(this T[] array)
    {
        Console.WriteLine($"[{string. Join(", ", array)}]");
    }
    // Obtener elementos en índices pares
    public static T[] IndicesPares<T>(this T[] array)
    {
        int cantidad = (array.Length + 1) / 2;
        T[] resultado = new T[cantidad];
        int indice = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            resultado[indice++] = array[i];
        }
        return resultado;
    }
    // Obtener elementos en índices impares
    public static T[] IndicesImpares<T>(this T[] array)
    {
        int cantidad = array.Length / 2;
        T[] resultado = new T[cantidad];
        int indice = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            resultado[indice++] = array[i];
        }
        return resultado;
    }
    // Intercalar dos arrays
    public static T[] Intercalar<T>(this T[] array1, T[] array2)
    {
        int longitudTotal = array1.Length + array2.Length;
        T[] resultado = new T[longitudTotal];
        int i1 = 0, i2 = 0, ir = 0;
        while (i1 < array1.Length || i2 < array2.Length)
        {
            if (i1 < array1.Length)
            {
                resultado[ir++] = array1[i1++];
            }
            if (i2 < array2.Length)
            {
                resultado[ir++] = array2[i2++];
            }
        }
        return resultado;
    }
    // Dividir array en chunks
    public static T[][] DividirEnChunks<T>(this T[] array, int tamañoChunk)
    {
        int numeroChunks = (int)Math.Ceiling(array.Length / (double)tamañoChunk);
        T[][] resultado = new T[numeroChunks][];
        for (int i = 0; i < numeroChunks; i++)
        {
            int inicio = i * tamañoChunk;
            int tamaño = Math.Min(tamañoChunk, array.Length - inicio);
            resultado[i] = new T[tamaño];
            for (int j = 0; j < tamaño; j++)
            {
                resultado[i][j] = array[inicio + j];
            }
        }
        return resultado;
    }
}

// Código ejecutable
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Imprimir
        Console.Write("Array original: ");
        numeros.Imprimir();
        
        // Índices pares
        Console.Write("Índices pares: ");
        numeros.IndicesPares().Imprimir();
        
        // Índices impares
        Console.Write("Índices impares: ");
        numeros.IndicesImpares().Imprimir();
        
        // Intercalar
        int[] array1 = { 1, 3, 5 };
        int[] array2 = { 2, 4, 6 };
        Console.Write("Intercalado: ");
        array1.Intercalar(array2).Imprimir();
        
        // Dividir en chunks
        Console. WriteLine("\nChunks de 3:");
        var chunks = numeros.DividirEnChunks(3);
        foreach (var chunk in chunks)
        {
            Console.Write("  ");
            chunk.Imprimir();
        }
```

**Ejemplos prácticos:**

```csharp
public static class ExtensionesDateTime
{
    public static bool EsFinDeSemana(this DateTime fecha)
    {
        return fecha.DayOfWeek == DayOfWeek.Saturday || 
               fecha.DayOfWeek == DayOfWeek.Sunday;
    }
    public static int EdadActual(this DateTime fechaNacimiento)
    {
        DateTime hoy = DateTime.Today;
        int edad = hoy.Year - fechaNacimiento. Year;
        if (fechaNacimiento.Date > hoy.AddYears(-edad))
        {
            edad--;
        }
        return edad;
    }
    public static string FormatoAmigable(this DateTime fecha)
    {
        TimeSpan diferencia = DateTime.Now - fecha;
        if (diferencia.TotalMinutes < 1)
            return "Hace unos segundos";
        if (diferencia.TotalMinutes < 60)
            return $"Hace {(int)diferencia.TotalMinutes} minutos";
        if (diferencia.TotalHours < 24)
            return $"Hace {(int)diferencia.TotalHours} horas";
        if (diferencia.TotalDays < 7)
            return $"Hace {(int)diferencia.TotalDays} días";
        return fecha.ToString("dd/MM/yyyy");
    }
}

// Código ejecutable
        DateTime hoy = DateTime.Today;
        Console.WriteLine($"¿Hoy es fin de semana? {hoy.EsFinDeSemana()}");
        
        DateTime fechaNacimiento = new DateTime(1990, 5, 15);
        Console.WriteLine($"Edad:  {fechaNacimiento.EdadActual()} años");
        
        DateTime hace2Horas = DateTime.Now.AddHours(-2);
        Console.WriteLine($"Formato amigable: {hace2Horas.FormatoAmigable()}");
```

#### 3.6.3. Métodos de Extensión Genéricos

**Combinación de genéricos y extensiones:**

```csharp
public static class ExtensionesGenericas
{
    // Imprimir cualquier tipo
    public static void ImprimirInfo<T>(this T item)
    {
        Console.WriteLine($"Tipo: {typeof(T).Name}");
        Console.WriteLine($"Valor: {item}");
    }
    // Clonar valor (para tipos valor)
    public static T Clonar<T>(this T valor) where T : struct
    {
        return valor;
    }
    // Ejecutar acción n veces
    public static void Repetir<T>(this T item, int veces, Action<T> accion)
    {
        for (int i = 0; i < veces; i++)
        {
            accion(item);
        }
    }
    // Aplicar transformación
    public static TResult Transformar<T, TResult>(this T item, Func<T, TResult> transformador)
    {
        return transformador(item);
    }
    // Ejecutar si cumple condición
    public static T Si<T>(this T item, Func<T, bool> condicion, Action<T> accion)
    {
        if (condicion(item))
        {
            accion(item);
        }
        return item;
    }
}

// Código ejecutable
        // Usar extensiones genéricas
        42.ImprimirInfo();
        "Hola".ImprimirInfo();
        
        // Transformar
        int resultado = 5. Transformar(x => x * x);
        Console.WriteLine($"5 al cuadrado: {resultado}");
        
        string textoMayusculas = "hola". Transformar(s => s.ToUpper());
        Console.WriteLine($"En mayúsculas: {textoMayusculas}");
        
        // Ejecutar si cumple condición
        10.Si(x => x > 5, x => Console.WriteLine($"{x} es mayor que 5"));
        3.Si(x => x > 5, x => Console.WriteLine($"{x} es mayor que 5")); // No se ejecuta
```

**Restricciones en métodos de extensión:**

```csharp
public static class ExtensionesConRestricciones
{
    // Solo para tipos que implementan IComparable
    public static bool EsMayorQue<T>(this T valor, T otro) where T : IComparable<T>
    {
        return valor.CompareTo(otro) > 0;
    }
    // Solo para tipos de referencia
    public static bool EsNulo<T>(this T objeto) where T : class
    {
        return objeto == null;
    }
    // Solo para tipos valor
    public static T?  ConvertirANullable<T>(this T valor) where T : struct
    {
        return new T?(valor);
    }
    // Solo para tipos con constructor sin parámetros
    public static T CrearNuevaInstancia<T>(this T _) where T : new()
    {
        return new T();
    }
}

// Código ejecutable
        // IComparable
        Console.WriteLine($"¿10 es mayor que 5? {10.EsMayorQue(5)}");
        Console.WriteLine($"¿'abc' es mayor que 'xyz'? {"abc".EsMayorQue("xyz")}");
        
        // Tipo de referencia
        string texto = null;
        Console.WriteLine($"¿El texto es nulo? {texto. EsNulo()}");
        
        // Tipo valor
        int numero = 42;
        int? nullable = numero.ConvertirANullable();
        Console.WriteLine($"Nullable: {nullable}");
```

**Casos de uso avanzados:**

```csharp
public static class ExtensionesAvanzadas
{
    // Encadenar validaciones
    public static T ValidarQue<T>(this T valor, Func<T, bool> validacion, string mensajeError)
    {
        if (! validacion(valor))
        {
            throw new ArgumentException(mensajeError);
        }
        return valor;
    }
    // Pipeline fluido
    public static T Aplicar<T>(this T valor, Action<T> accion)
    {
        accion(valor);
        return valor;
    }
    // Ejecutar y retornar resultado
    public static TResult Usando<T, TResult>(this T valor, Func<T, TResult> funcion)
    {
        return funcion(valor);
    }
}

// Código ejecutable
        // Validaciones encadenadas
        try
        {
            int edad = 25
                .ValidarQue(e => e >= 0, "La edad no puede ser negativa")
                .ValidarQue(e => e <= 120, "La edad no puede ser mayor a 120");
            
            Console.WriteLine($"Edad válida: {edad}");
        }
        catch (ArgumentException ex)
        {
            Console. WriteLine($"Error: {ex. Message}");
        }
        
        // Pipeline fluido
        string resultado = "hola mundo"
            .Aplicar(s => Console.WriteLine($"Original: {s}"))
            .Usando(s => s.ToUpper())
            .Aplicar(s => Console. WriteLine($"Mayúsculas: {s}"))
            .Usando(s => s.Replace(" ", "-"));
        
        Console.WriteLine($"Final: {resultado}");
```

#### 3.6.4. Crear Operaciones Funcionales como Extensiones (sobre Arrays)

Ahora vamos a convertir nuestras operaciones funcionales en métodos de extensión para arrays, lo que permite un uso más fluido. 

```csharp
public static class ExtensionesArrayFuncional
{
    // Filter como extensión
    public static T[] Filtrar<T>(this T[] array, Func<T, bool> predicado)
    {
        int contador = 0;
        foreach (T elemento in array)
        {
            if (predicado(elemento))
            {
                contador++;
            }
        }
        T[] resultado = new T[contador];
        int indice = 0;
        foreach (T elemento in array)
        {
            if (predicado(elemento))
            {
                resultado[indice++] = elemento;
            }
        }
        return resultado;
    }
    // Map como extensión
    public static TResult[] Mapear<T, TResult>(this T[] array, Func<T, TResult> transformador)
    {
        TResult[] resultado = new TResult[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            resultado[i] = transformador(array[i]);
        }
        return resultado;
    }
    // Reduce como extensión
    public static TResult Reducir<T, TResult>(
        this T[] array,
        TResult valorInicial,
        Func<TResult, T, TResult> acumulador)
    {
        TResult resultado = valorInicial;
        foreach (T elemento in array)
        {
            resultado = acumulador(resultado, elemento);
        }
        return resultado;
    }
    // ForEach como extensión
    public static T[] ParaCadaElemento<T>(this T[] array, Action<T> accion)
    {
        foreach (T elemento in array)
        {
            accion(elemento);
        }
        return array; // Retornar el array para encadenar
    }
    // Count como extensión
    public static int Contar<T>(this T[] array, Func<T, bool> predicado)
    {
        int contador = 0;
        foreach (T elemento in array)
        {
            if (predicado(elemento))
            {
                contador++;
            }
        }
        return contador;
    }
    // Any como extensión
    public static bool Alguno<T>(this T[] array, Func<T, bool> predicado)
    {
        foreach (T elemento in array)
        {
            if (predicado(elemento))
            {
                return true;
            }
        }
        return false;
    }
    // All como extensión
    public static bool Todos<T>(this T[] array, Func<T, bool> predicado)
    {
        foreach (T elemento in array)
        {
            if (!predicado(elemento))
            {
                return false;
            }
        }
        return true;
    }
}

// Código ejecutable
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        Console.WriteLine("=== Uso fluido con extensiones ===");
        
        // Encadenar operaciones de manera fluida
        int resultado = numeros
            .Filtrar(n => n % 2 == 0)                    // Solo pares
            .Mapear(n => n * n)                           // Elevar al cuadrado
            . ParaCadaElemento(n => Console.Write($"{n} ")) // Mostrar cada uno
            .Reducir(0, (acum, n) => acum + n);          // Sumar todos
        
        Console. WriteLine($"\n\nResultado final: {resultado}");
        
        // Más ejemplos fluidos
        string[] palabras = { "casa", "sol", "programación", "luz", "computadora" };
        
        int palabrasLargas = palabras
            . Filtrar(p => p.Length > 4)
            .Contar(_ => true); // Contar todas (después del filtro)
        
        Console. WriteLine($"Palabras largas: {palabrasLargas}");
        
        // Verificaciones
        bool hayPares = numeros.Alguno(n => n % 2 == 0);
        bool todosPositivos = numeros.Todos(n => n > 0);
        
        Console.WriteLine($"¿Hay pares? {hayPares}");
        Console.WriteLine($"¿Todos positivos? {todosPositivos}");
```

**Ventajas de esta aproximación:**

```csharp
// Código ejecutable
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // ✓ Sintaxis fluida y legible
        var resultado1 = numeros
            . Filtrar(n => n > 5)
            .Mapear(n => n * 2);
        
        // vs.  sintaxis anidada (menos legible)
        var resultado2 = OperacionesFuncionales. Map(
            OperacionesFuncionales.Filter(numeros, n => n > 5),
            n => n * 2
        );
        
        // ✓ Fácil de leer de arriba a abajo
        var pipeline = numeros
            .Filtrar(n => n % 2 == 0)     // Paso 1: filtrar pares
            . Mapear(n => n * n)            // Paso 2: elevar al cuadrado
            . Filtrar(n => n > 10)          // Paso 3: solo mayores que 10
            . Mapear(n => $"Número:  {n}");  // Paso 4: convertir a string
        
        Console.WriteLine("Pipeline procesado:");
        foreach (string item in pipeline)
        {
            Console.WriteLine($"  {item}");
        }
        
        // ✓ Fácil de componer y reutilizar
        Func<int[], int[]> procesarPares = arr => arr
            .Filtrar(n => n % 2 == 0)
            .Mapear(n => n * 2);
        
        var pares = procesarPares(numeros);
        Console.WriteLine($"\nPares procesados: [{string.Join(", ", pares)}]");
```

**Ejemplos de uso fluido:**

```csharp
class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string Categoria { get; set; }
    public int Stock { get; set; }
    public override string ToString()
    {
        return $"{Nombre} - ${Precio} ({Categoria})";
    }
}

// Código ejecutable
        Producto[] productos = new Producto[]
        {
            new Producto { Nombre = "Laptop", Precio = 1200, Categoria = "Electrónica", Stock = 5 },
            new Producto { Nombre = "Mouse", Precio = 25, Categoria = "Electrónica", Stock = 50 },
            new Producto { Nombre = "Libro C#", Precio = 45, Categoria = "Libros", Stock = 20 },
            new Producto { Nombre = "Teclado", Precio = 75, Categoria = "Electrónica", Stock = 30 },
            new Producto { Nombre = "Monitor", Precio = 300, Categoria = "Electrónica", Stock = 10 }
        };
        
        // Pipeline completo:  filtrar categoría -> ordenar por precio -> tomar primeros 3
        var topElectronica = productos
            .Filtrar(p => p.Categoria == "Electrónica")
            .Filtrar(p => p.Precio > 50);
        
        Console.WriteLine("=== Electrónica cara ===");
        topElectronica.ParaCadaElemento(p => Console.WriteLine($"  {p}"));
        
        // Calcular valor total del inventario
        decimal valorTotal = productos
            .Mapear(p => p.Precio * p.Stock)
            .Reducir(0m, (acum, valor) => acum + valor);
        
        Console.WriteLine($"\n=== Valor total del inventario:  ${valorTotal} ===");
        
        // Verificar si hay productos agotados
        bool hayAgotados = productos.Alguno(p => p.Stock == 0);
        Console.WriteLine($"¿Hay productos agotados? {hayAgotados}");
        
        // Obtener nombres de productos caros (> $100)
        string[] nombresCaros = productos
            .Filtrar(p => p.Precio > 100)
            .Mapear(p => p.Nombre);
        
        Console.WriteLine($"\nProductos caros: [{string.Join(", ", nombresCaros)}]");
```

---

### 3.7. Sobrecarga de Operadores

La sobrecarga de operadores permite definir el comportamiento de los operadores estándar (como `+`, `-`, `*`, `==`, etc.) para tus propios tipos.

#### 3.7.1. Fundamentos

**¿Qué operadores se pueden sobrecargar?**

✓ **Sobrecargables:**
- Aritméticos: `+`, `-`, `*`, `/`, `%`
- Unarios: `+`, `-`, `!`, `~`, `++`, `--`
- Comparación: `==`, `!=`, `<`, `>`, `<=`, `>=`
- Lógicos: `&`, `|`, `^`
- Conversión: `implicit`, `explicit`

✗ **NO sobrecargables:**
- Asignación: `=`
- Acceso a miembro: `.`
- Invocación de método: `()`
- Indexación: `[]`
- Condicionales: `&&`, `||`
- Otros: `??`, `?.`, `=>`, etc.

**Sintaxis:   `public static` + `operator`**

```csharp
public static TipoResultado operator +(Tipo1 a, Tipo2 b)
{
    // Implementación
}

```

**Restricciones y requisitos:**

1.  Debe ser `public` y `static`
2. Al menos uno de los parámetros debe ser del tipo que contiene la sobrecarga
3. Algunos operadores deben sobrecargarse en pares (`==` con `!=`, `<` con `>`, etc.)
4. Si sobrecargas `==` y `!=`, también debes sobrescribir `Equals()` y `GetHashCode()`

#### 3.7.2. Operadores Aritméticos

**`+`, `-`, `*`, `/`, `%`**

```csharp
public class Vector2D
{
    public double X { get; set; }
    public double Y { get; set; }
    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }
    // Sobrecarga del operador +
    public static Vector2D operator +(Vector2D a, Vector2D b)
    {
        return new Vector2D(a.X + b. X, a.Y + b. Y);
    }
    // Sobrecarga del operador -
    public static Vector2D operator -(Vector2D a, Vector2D b)
    {
        return new Vector2D(a.X - b.X, a.Y - b.Y);
    }
    // Sobrecarga del operador * (escalar)
    public static Vector2D operator *(Vector2D v, double escalar)
    {
        return new Vector2D(v.X * escalar, v.Y * escalar);
    }
    // Sobrecarga del operador * (producto punto)
    public static double operator *(Vector2D a, Vector2D b)
    {
        return a.X * b.X + a.Y * b.Y;
    }
    // Sobrecarga del operador / (división por escalar)
    public static Vector2D operator /(Vector2D v, double escalar)
    {
        if (escalar == 0)
        {
            throw new DivideByZeroException("No se puede dividir por cero");
        }
        return new Vector2D(v.X / escalar, v. Y / escalar);
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

// Código ejecutable
        Vector2D v1 = new Vector2D(3, 4);
        Vector2D v2 = new Vector2D(1, 2);
        
        // Usar operadores sobrecargados
        Vector2D suma = v1 + v2;
        Console.WriteLine($"v1 + v2 = {suma}"); // (4, 6)
        
        Vector2D resta = v1 - v2;
        Console. WriteLine($"v1 - v2 = {resta}"); // (2, 2)
        
        Vector2D multiplicacion = v1 * 2;
        Console.WriteLine($"v1 * 2 = {multiplicacion}"); // (6, 8)
        
        double productoPunto = v1 * v2;
        Console.WriteLine($"v1 · v2 = {productoPunto}"); // 11
        
        Vector2D division = v1 / 2;
        Console.WriteLine($"v1 / 2 = {division}"); // (1.5, 2)
```

**Operadores unarios:   `+`, `-`, `++`, `--`**

```csharp
public class Contador
{
    public int Valor { get; private set; }
    public Contador(int valor)
    {
        Valor = valor;
    }
    // Operador unario +
    public static Contador operator +(Contador c)
    {
        return new Contador(Math. Abs(c.Valor));
    }
    // Operador unario -
    public static Contador operator -(Contador c)
    {
        return new Contador(-c.Valor);
    }
    // Operador ++
    public static Contador operator ++(Contador c)
    {
        return new Contador(c.Valor + 1);
    }
    // Operador --
    public static Contador operator --(Contador c)
    {
        return new Contador(c.Valor - 1);
    }
    public override string ToString()
    {
        return Valor.ToString();
    }
}

// Código ejecutable
        Contador c1 = new Contador(-5);
        Console.WriteLine($"c1 = {c1}"); // -5
        
        Contador c2 = +c1; // Valor absoluto
        Console.WriteLine($"+c1 = {c2}"); // 5
        
        Contador c3 = -c1; // Negar
        Console.WriteLine($"-c1 = {c3}"); // 5
        
        Contador c4 = new Contador(10);
        c4++; // Incrementar
        Console.WriteLine($"c4++ = {c4}"); // 11
        
        c4--; // Decrementar
        Console.WriteLine($"c4-- = {c4}"); // 10
```

**Ejemplos con tipos personalizados (Vector, Matriz, Fracción):**

```csharp
public class Fraccion
{
    public int Numerador { get; private set; }
    public int Denominador { get; private set; }
    public Fraccion(int numerador, int denominador)
    {
        if (denominador == 0)
        {
            throw new ArgumentException("El denominador no puede ser cero");
        }
        // Simplificar la fracción
        int mcd = MCD(Math.Abs(numerador), Math.Abs(denominador));
        Numerador = numerador / mcd;
        Denominador = denominador / mcd;
        // Mantener el signo en el numerador
        if (Denominador < 0)
        {
            Numerador = -Numerador;
            Denominador = -Denominador;
        }
    }
    // Máximo Común Divisor
    private static int MCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    // Operador +
    public static Fraccion operator +(Fraccion f1, Fraccion f2)
    {
        int nuevoNumerador = f1.Numerador * f2.Denominador + f2.Numerador * f1.Denominador;
        int nuevoDenominador = f1.Denominador * f2.Denominador;
        return new Fraccion(nuevoNumerador, nuevoDenominador);
    }
    // Operador -
    public static Fraccion operator -(Fraccion f1, Fraccion f2)
    {
        int nuevoNumerador = f1.Numerador * f2.Denominador - f2.Numerador * f1.Denominador;
        int nuevoDenominador = f1.Denominador * f2.Denominador;
        return new Fraccion(nuevoNumerador, nuevoDenominador);
    }
    // Operador *
    public static Fraccion operator *(Fraccion f1, Fraccion f2)
    {
        return new Fraccion(f1.Numerador * f2.Numerador, f1.Denominador * f2.Denominador);
    }
    // Operador /
    public static Fraccion operator /(Fraccion f1, Fraccion f2)
    {
        if (f2.Numerador == 0)
        {
            throw new DivideByZeroException("No se puede dividir por cero");
        }
        return new Fraccion(f1.Numerador * f2.Denominador, f1.Denominador * f2.Numerador);
    }
    public override string ToString()
    {
        if (Denominador == 1)
        {
            return Numerador. ToString();
        }
        return $"{Numerador}/{Denominador}";
    }
    public double ToDouble()
    {
        return (double)Numerador / Denominador;
    }
}

// Código ejecutable
        Fraccion f1 = new Fraccion(1, 2);  // 1/2
        Fraccion f2 = new Fraccion(1, 3);  // 1/3
        
        Console.WriteLine($"f1 = {f1}");
        Console.WriteLine($"f2 = {f2}");
        
        Fraccion suma = f1 + f2;
        Console.WriteLine($"f1 + f2 = {suma} = {suma.ToDouble()}"); // 5/6 = 0.8333... 
        
        Fraccion resta = f1 - f2;
        Console.WriteLine($"f1 - f2 = {resta} = {resta.ToDouble()}"); // 1/6 = 0.1666...
        
        Fraccion multiplicacion = f1 * f2;
        Console.WriteLine($"f1 * f2 = {multiplicacion} = {multiplicacion.ToDouble()}"); // 1/6
        
        Fraccion division = f1 / f2;
        Console.WriteLine($"f1 / f2 = {division} = {division.ToDouble()}"); // 3/2 = 1.5
        
        // Operaciones encadenadas
        Fraccion resultado = f1 + f2 * new Fraccion(2, 1);
        Console.WriteLine($"f1 + f2 * 2 = {resultado} = {resultado.ToDouble()}");
```

#### 3.7.3. Operadores de Comparación

**`==`, `!=`, `<`, `>`, `<=`, `>=`**

```csharp
public class Dinero
{
    public decimal Cantidad { get; private set; }
    public string Moneda { get; private set; }
    public Dinero(decimal cantidad, string moneda)
    {
        Cantidad = cantidad;
        Moneda = moneda. ToUpper();
    }
    // Operador == (debe sobrecargarse con !=)
    public static bool operator ==(Dinero d1, Dinero d2)
    {
        if (ReferenceEquals(d1, d2)) return true;
        if (ReferenceEquals(d1, null) || ReferenceEquals(d2, null)) return false;
        return d1.Cantidad == d2.Cantidad && d1.Moneda == d2.Moneda;
    }
    // Operador !=
    public static bool operator ! =(Dinero d1, Dinero d2)
    {
        return !(d1 == d2);
    }
    // Operador < (debe sobrecargarse con >)
    public static bool operator <(Dinero d1, Dinero d2)
    {
        if (d1.Moneda != d2.Moneda)
        {
            throw new InvalidOperationException("No se pueden comparar cantidades de diferentes monedas");
        }
        return d1.Cantidad < d2.Cantidad;
    }
    // Operador >
    public static bool operator >(Dinero d1, Dinero d2)
    {
        if (d1.Moneda != d2.Moneda)
        {
            throw new InvalidOperationException("No se pueden comparar cantidades de diferentes monedas");
        }
        return d1.Cantidad > d2.Cantidad;
    }
    // Operador <= (debe sobrecargarse con >=)
    public static bool operator <=(Dinero d1, Dinero d2)
    {
        return d1 < d2 || d1 == d2;
    }
    // Operador >=
    public static bool operator >=(Dinero d1, Dinero d2)
    {
        return d1 > d2 || d1 == d2;
    }
    // Sobrescribir Equals (requerido al sobrecargar ==)
    public override bool Equals(object obj)
    {
        if (obj is Dinero otro)
        {
            return this == otro;
        }
        return false;
    }
    // Sobrescribir GetHashCode (requerido al sobrescribir Equals)
    public override int GetHashCode()
    {
        return HashCode.Combine(Cantidad, Moneda);
    }
    public override string ToString()
    {
        return $"{Cantidad: F2} {Moneda}";
    }
}

// Código ejecutable
        Dinero d1 = new Dinero(100, "EUR");
        Dinero d2 = new Dinero(150, "EUR");
        Dinero d3 = new Dinero(100, "EUR");
        Dinero d4 = new Dinero(100, "USD");
        
        // Operadores de igualdad
        Console.WriteLine($"{d1} == {d3}:  {d1 == d3}"); // True
        Console.WriteLine($"{d1} == {d2}: {d1 == d2}"); // False
        Console.WriteLine($"{d1} != {d2}: {d1 != d2}"); // True
        
        // Operadores de comparación
        Console.WriteLine($"{d1} < {d2}: {d1 < d2}");   // True
        Console.WriteLine($"{d1} > {d2}: {d1 > d2}");   // False
        Console.WriteLine($"{d1} <= {d3}: {d1 <= d3}"); // True
        Console.WriteLine($"{d2} >= {d1}: {d2 >= d1}"); // True
        
        // Intentar comparar diferentes monedas (lanza excepción)
        try
        {
            bool resultado = d1 < d4;
        }
        catch (InvalidOperationException ex)
        {
            Console. WriteLine($"\nError: {ex.Message}");
        }
```

**Requisito de implementar en pares:**

Los siguientes operadores DEBEN implementarse en pares:  
- `==` con `!=`
- `<` con `>`
- `<=` con `>=`

Si implementas uno, DEBES implementar el otro. 

**Relación con `Equals` y `GetHashCode`:**

Si sobrecargas `==` y `!=`, **debes** sobrescribir `Equals()` y `GetHashCode()`:

```csharp
public class Punto
{
    public int X { get; set; }
    public int Y { get; set; }
    public Punto(int x, int y)
    {
        X = x;
        Y = y;
    }
    // Operadores == y !=
    public static bool operator ==(Punto p1, Punto p2)
    {
        if (ReferenceEquals(p1, p2)) return true;
        if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null)) return false;
        return p1.X == p2.X && p1.Y == p2.Y;
    }
    public static bool operator !=(Punto p1, Punto p2)
    {
        return !(p1 == p2);
    }
    // OBLIGATORIO: sobrescribir Equals
    public override bool Equals(object obj)
    {
        if (obj is Punto otro)
        {
            return this == otro;
        }
        return false;
    }
    // OBLIGATORIO: sobrescribir GetHashCode
    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

// Código ejecutable
        Punto p1 = new Punto(3, 4);
        Punto p2 = new Punto(3, 4);
        Punto p3 = new Punto(5, 6);
        
        // Usar operador ==
        Console.WriteLine($"p1 == p2: {p1 == p2}"); // True
        
        // Usar método Equals
        Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}"); // True
        
        // Usar en colecciones (requiere GetHashCode correcto)
        var conjunto = new HashSet<Punto> { p1, p2, p3 };
        Console.WriteLine($"Elementos únicos: {conjunto.Count}"); // 2 (p1 y p2 son iguales)
```

#### 3.7.4. Operadores Lógicos

**`true`, `false`, `!`, `&`, `|`, `^`**

```csharp
public class EstadoOperacion
{
    public bool Completado { get; set; }
    public bool ConErrores { get; set; }
    public EstadoOperacion(bool completado, bool conErrores)
    {
        Completado = completado;
        ConErrores = conErrores;
    }
    // Operador true (permite usar en if)
    public static bool operator true(EstadoOperacion estado)
    {
        return estado.Completado && !estado.ConErrores;
    }
    // Operador false (debe implementarse con true)
    public static bool operator false(EstadoOperacion estado)
    {
        return ! estado.Completado || estado. ConErrores;
    }
    // Operador !  (negación)
    public static EstadoOperacion operator !(EstadoOperacion estado)
    {
        return new EstadoOperacion(!estado.Completado, estado.ConErrores);
    }
    // Operador &
    public static EstadoOperacion operator &(EstadoOperacion e1, EstadoOperacion e2)
    {
        return new EstadoOperacion(
            e1.Completado && e2.Completado,
            e1.ConErrores || e2.ConErrores
        );
    }
    // Operador |
    public static EstadoOperacion operator |(EstadoOperacion e1, EstadoOperacion e2)
    {
        return new EstadoOperacion(
            e1.Completado || e2.Completado,
            e1.ConErrores && e2.ConErrores
        );
    }
    public override string ToString()
    {
        string estado = Completado ? "Completado" : "No completado";
        string errores = ConErrores ? "con errores" : "sin errores";
        return $"{estado}, {errores}";
    }
}

// Código ejecutable
        EstadoOperacion op1 = new EstadoOperacion(true, false);   // Completado sin errores
        EstadoOperacion op2 = new EstadoOperacion(true, true);    // Completado con errores
        EstadoOperacion op3 = new EstadoOperacion(false, false);  // No completado
        
        // Usar operador true/false en if
        if (op1)
        {
            Console.WriteLine("op1 es verdadero (completado sin errores)");
        }
        
        if (op2)
        {
            Console.WriteLine("op2 es verdadero");
        }
        else
        {
            Console.WriteLine("op2 es falso (tiene errores)");
        }
        
        // Operador negación
        EstadoOperacion opNegada = !op1;
        Console.WriteLine($"! op1 = {opNegada}");
        
        // Operadores lógicos
        EstadoOperacion resultadoAnd = op1 & op2;
        Console.WriteLine($"op1 & op2 = {resultadoAnd}");
        
        EstadoOperacion resultadoOr = op1 | op3;
        Console.WriteLine($"op1 | op3 = {resultadoOr}");
```

**Casos de uso:**

Sobrecargar operadores lógicos es útil para:
- Estados compuestos
- Operaciones booleanas personalizadas
- Lógica de tres valores (verdadero/falso/desconocido)

#### 3.7.5. Operadores de Conversión

Los operadores de conversión permiten definir conversiones entre tu tipo y otros tipos.

**Conversión implícita:   `implicit operator`**

La conversión implícita se realiza automáticamente, sin necesidad de un cast explícito.  Úsala cuando **la conversión siempre es segura** y no pierde información.

```csharp
public class Temperatura
{
    public double Celsius { get; private set; }
    public Temperatura(double celsius)
    {
        Celsius = celsius;
    }
    // Conversión implícita de double a Temperatura
    public static implicit operator Temperatura(double celsius)
    {
        return new Temperatura(celsius);
    }
    // Conversión implícita de Temperatura a double
    public static implicit operator double(Temperatura temp)
    {
        return temp.Celsius;
    }
    // Conversión implícita a string
    public static implicit operator string(Temperatura temp)
    {
        return $"{temp.Celsius}°C";
    }
    public override string ToString()
    {
        return $"{Celsius}°C";
    }
}

// Código ejecutable
        // Conversión implícita de double a Temperatura
        Temperatura temp1 = 25.5; // Automática, sin cast
        Console.WriteLine($"Temperatura 1: {temp1}");
        
        // Conversión implícita de Temperatura a double
        double valor = temp1; // Automática, sin cast
        Console.WriteLine($"Valor numérico: {valor}");
        
        // Conversión implícita a string
        string textoTemp = temp1;
        Console.WriteLine($"Texto: {textoTemp}");
        
        // Usar en operaciones matemáticas
        Temperatura temp2 = 30.0;
        double suma = temp1 + temp2; // Ambos se convierten a double
        Console.WriteLine($"Suma: {suma}");
```

**Conversión explícita:  `explicit operator`**

La conversión explícita requiere un cast.  Úsala cuando **la conversión puede fallar** o **perder información**.

```csharp
public class Fraccion
{
    public int Numerador { get; private set; }
    public int Denominador { get; private set; }
    public Fraccion(int numerador, int denominador)
    {
        if (denominador == 0)
        {
            throw new ArgumentException("El denominador no puede ser cero");
        }
        Numerador = numerador;
        Denominador = denominador;
    }
    // Conversión explícita de double a Fraccion (puede perder precisión)
    public static explicit operator Fraccion(double valor)
    {
        // Conversión simple (puede no ser exacta)
        const int precision = 1000000;
        int numerador = (int)(valor * precision);
        return new Fraccion(numerador, precision);
    }
    // Conversión explícita de Fraccion a int (pierde la parte fraccionaria)
    public static explicit operator int(Fraccion f)
    {
        return f.Numerador / f. Denominador;
    }
    // Conversión implícita a double (segura, no pierde información conceptual)
    public static implicit operator double(Fraccion f)
    {
        return (double)f.Numerador / f.Denominador;
    }
    public override string ToString()
    {
        return $"{Numerador}/{Denominador}";
    }
}

// Código ejecutable
        // Conversión explícita (requiere cast)
        Fraccion f1 = (Fraccion)0.5; // REQUIERE cast explícito
        Console.WriteLine($"0.5 como fracción: {f1}");
        
        Fraccion f2 = new Fraccion(7, 2);
        int entero = (int)f2; // REQUIERE cast explícito, pierde parte fraccionaria
        Console.WriteLine($"7/2 como entero: {entero}"); // 3
        
        // Conversión implícita (automática)
        double decimal1 = f2; // NO requiere cast
        Console.WriteLine($"7/2 como double: {decimal1}"); // 3.5
```

**Cuándo usar cada una:**

| Tipo          | Cuándo usar                                             | Ejemplo                                             |
| ------------- | ------------------------------------------------------- | --------------------------------------------------- |
| **Implícita** | La conversión siempre es segura y no pierde información | `int` → `long`, `Temperatura` → `double`            |
| **Explícita** | La conversión puede fallar o perder información         | `double` → `int`, `long` → `int`, `string` → número |

```csharp
public class Dinero
{
    public decimal Cantidad { get; private set; }
    public Dinero(decimal cantidad)
    {
        Cantidad = cantidad;
    }
    // Implícita: decimal a Dinero (siempre segura)
    public static implicit operator Dinero(decimal cantidad)
    {
        return new Dinero(cantidad);
    }
    // Implícita: Dinero a decimal (siempre segura)
    public static implicit operator decimal(Dinero dinero)
    {
        return dinero.Cantidad;
    }
    // Explícita: Dinero a int (pierde decimales)
    public static explicit operator int(Dinero dinero)
    {
        return (int)dinero.Cantidad;
    }
    public override string ToString()
    {
        return $"${Cantidad:F2}";
    }
}

// Código ejecutable
        // Conversión implícita
        Dinero d1 = 100.50m; // Automática
        decimal valor = d1;   // Automática
        
        Console.WriteLine($"Dinero:  {d1}");
        Console.WriteLine($"Valor decimal: {valor}");
        
        // Conversión explícita (pierde decimales)
        Dinero d2 = 99.99m;
        int valorEntero = (int)d2; // Requiere cast
        Console.WriteLine($"Valor entero (pierde decimales): {valorEntero}"); // 99
```

#### 3.7.6. Buenas Prácticas

**Coherencia semántica:**

Los operadores sobrecargados deben tener un significado intuitivo y coherente con lo que los usuarios esperan. 

```csharp
// ✓ BUENO: coherente con la semántica matemática
public class Vector
{
    // + para sumar vectores (matemáticamente correcto)
    public static Vector operator +(Vector v1, Vector v2) { /* ... */ }
    
    // * para producto escalar (matemáticamente correcto)
    public static Vector operator *(Vector v, double escalar) { /* ... */ }
}

// ✗ MALO: incoherente y confuso
public class Persona
{
    // + para concatenar nombres? ?  No tiene sentido
    public static Persona operator +(Persona p1, Persona p2) { /* ... */ }
    
    // * para...  ¿multiplicar personas?  Absurdo
    public static Persona operator *(Persona p, int n) { /* ... */ }
}

```

**Sobrecarga simétrica:**

Si tiene sentido, implementa la operación en ambas direcciones: 

```csharp
public class Vector
{
    // Simetría: vector * escalar
    public static Vector operator *(Vector v, double escalar)
    {
        return new Vector(v.X * escalar, v.Y * escalar);
    }
    
    // Simetría: escalar * vector
    public static Vector operator *(double escalar, Vector v)
    {
        return v * escalar; // Reutiliza la otra sobrecarga
    }
}

// Ahora ambas formas funcionan
Vector v = new Vector(1, 2);
Vector resultado1 = v * 3;   // ✓ Funciona
Vector resultado2 = 3 * v;   // ✓ También funciona (gracias a la simetría)

```

**Documentación clara:**

Documenta los operadores sobrecargados, especialmente si el comportamiento no es obvio: 

```csharp
/// <summary>
/// Representa una matriz 2x2.
/// </summary>
public class Matriz2x2
{
    /// <summary>
    /// Multiplica dos matrices usando el producto matricial estándar.
    /// </summary>
    /// <param name="m1">Primera matriz</param>
    /// <param name="m2">Segunda matriz</param>
    /// <returns>Matriz resultado del producto m1 * m2</returns>
    public static Matriz2x2 operator *(Matriz2x2 m1, Matriz2x2 m2)
    {
        // Implementación del producto matricial
        // ... 
    }
    
    /// <summary>
    /// Suma dos matrices elemento por elemento.
    /// </summary>
    public static Matriz2x2 operator +(Matriz2x2 m1, Matriz2x2 m2)
    {
        // ... 
    }
}

```

**Evitar efectos secundarios:**

Los operadores NO deberían modificar sus operandos:

```csharp
// ✗ MALO: modifica el operando
public static Vector operator +(Vector v1, Vector v2)
{
    v1.X += v2.X; // ¡MAL! Modifica v1
    v1.Y += v2.Y;
    return v1;
}

// ✓ BUENO: crea un nuevo objeto sin modificar los operandos
public static Vector operator +(Vector v1, Vector v2)
{
    return new Vector(v1.X + v2.X, v1.Y + v2.Y); // No modifica v1 ni v2
}

```

**Consistencia con tipos incorporados:**

Sigue las convenciones de los tipos incorporados de C#:

```csharp
// Como string usa + para concatenación, podríamos hacer:
public class Texto
{
    private string contenido;
    
    // Coherente con string
    public static Texto operator +(Texto t1, Texto t2)
    {
        return new Texto(t1.contenido + t2.contenido);
    }
}

// Como int permite comparaciones, podríamos hacer:
public class Edad
{
    private int años;
    
    // Coherente con int
    public static bool operator <(Edad e1, Edad e2)
    {
        return e1.años < e2.años;
    }
    
    public static bool operator >(Edad e1, Edad e2)
    {
        return e1.años > e2.años;
    }
}

```

--

## 4. Comparación y Ordenación

La comparación y ordenación son operaciones fundamentales en programación.  C# proporciona varias interfaces y mecanismos para definir cómo se comparan y ordenan los objetos.

### 4.1.  Interfaz `IComparable<T>`

#### 4.1.1. Fundamentos

**Propósito:   orden natural de un tipo**

La interfaz `IComparable<T>` define el **orden natural** de un tipo.  Cuando implementas esta interfaz, estás diciendo "esta es la forma estándar de ordenar objetos de mi tipo".

```csharp
public interface IComparable<T>
{
    int CompareTo(T other);
}

```

**Método `CompareTo(T other)`**

El método `CompareTo` compara el objeto actual con otro objeto del mismo tipo y retorna:
- **Número negativo**: si `this` es menor que `other`
- **Cero (0)**: si `this` es igual a `other`
- **Número positivo**: si `this` es mayor que `other`

**Valores de retorno:  negativo, cero, positivo**

```csharp
// Ejemplo conceptual
int resultado = objeto1.CompareTo(objeto2);

if (resultado < 0)
{
    // objeto1 es MENOR que objeto2
}
else if (resultado == 0)
{
    // objeto1 es IGUAL a objeto2
}
else // resultado > 0
{
    // objeto1 es MAYOR que objeto2
}

```

#### 4.1.2. Implementación

**Implementar en tipos propios:**

```csharp
public class Persona : IComparable<Persona>
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public Persona(string nombre, string apellido, int edad)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
    }
    // Implementación de IComparable<Persona>
    // Orden natural: por apellido, luego por nombre
    public int CompareTo(Persona other)
    {
        // Manejar caso null
        if (other == null)
        {
            return 1; // this es mayor que null
        }
        // Comparar por apellido primero
        int comparacionApellido = this.Apellido.CompareTo(other.Apellido);
        if (comparacionApellido != 0)
        {
            return comparacionApellido; // Apellidos diferentes
        }
        // Si apellidos son iguales, comparar por nombre
        return this. Nombre.CompareTo(other.Nombre);
    }
    public override string ToString()
    {
        return $"{Apellido}, {Nombre} ({Edad} años)";
    }
}

// Código ejecutable
        Persona p1 = new Persona("Juan", "García", 30);
        Persona p2 = new Persona("Ana", "López", 25);
        Persona p3 = new Persona("Pedro", "García", 28);
        
        // Usar CompareTo directamente
        int comparacion1 = p1.CompareTo(p2);
        Console.WriteLine($"{p1} comparado con {p2}: {comparacion1}");
        // García < López, resultado negativo
        
        int comparacion2 = p1.CompareTo(p3);
        Console.WriteLine($"{p1} comparado con {p3}:  {comparacion2}");
        // Mismo apellido, Juan > Pedro, resultado positivo
        
        int comparacion3 = p1.CompareTo(p1);
        Console.WriteLine($"{p1} comparado consigo mismo: {comparacion3}");
        // Mismo objeto, resultado 0
```

**Ejemplo con tipo numérico personalizado:**

```csharp
public class Dinero :  IComparable<Dinero>
{
    public decimal Cantidad { get; private set; }
    public string Moneda { get; private set; }
    public Dinero(decimal cantidad, string moneda)
    {
        Cantidad = cantidad;
        Moneda = moneda. ToUpper();
    }
    public int CompareTo(Dinero other)
    {
        if (other == null)
        {
            return 1;
        }
        // Solo comparar si son de la misma moneda
        if (this.Moneda != other.Moneda)
        {
            throw new ArgumentException(
                $"No se pueden comparar {this.Moneda} con {other.Moneda}");
        }
        // Comparar cantidades
        return this.Cantidad.CompareTo(other. Cantidad);
    }
    public override string ToString()
    {
        return $"{Cantidad: F2} {Moneda}";
    }
}

// Código ejecutable
        Dinero d1 = new Dinero(100, "EUR");
        Dinero d2 = new Dinero(150, "EUR");
        Dinero d3 = new Dinero(100, "USD");
        
        Console.WriteLine($"{d1} < {d2}: {d1.CompareTo(d2) < 0}"); // True
        Console.WriteLine($"{d2} > {d1}: {d2.CompareTo(d1) > 0}"); // True
        Console.WriteLine($"{d1} == {new Dinero(100, "EUR")}: {d1.CompareTo(new Dinero(100, "EUR")) == 0}"); // True
        
        // Intentar comparar diferentes monedas
        try
        {
            d1.CompareTo(d3);
        }
        catch (ArgumentException ex)
        {
            Console. WriteLine($"\nError: {ex.Message}");
        }
```

**Contrato y requisitos:**

Al implementar `IComparable<T>`, debes cumplir con estas reglas:

1. **Reflexividad**: `x.CompareTo(x)` debe retornar `0`
2. **Antisimetría**: Si `x.CompareTo(y)` retorna un valor, `y.CompareTo(x)` debe retornar el valor con signo opuesto
3. **Transitividad**: Si `x.CompareTo(y) < 0` y `y.CompareTo(z) < 0`, entonces `x.CompareTo(z) < 0`
4. **Consistencia con null**: `x.CompareTo(null)` debe retornar un valor positivo

```csharp
public class Numero : IComparable<Numero>
{
    public int Valor { get; set; }
    public Numero(int valor)
    {
        Valor = valor;
    }
    public int CompareTo(Numero other)
    {
        // Regla:  manejar null
        if (other == null)
        {
            return 1; // this > null
        }
        // Comparación simple que cumple todas las reglas
        return this. Valor.CompareTo(other.Valor);
    }
    public override string ToString()
    {
        return Valor.ToString();
    }
}

// Código ejecutable
        Numero n1 = new Numero(5);
        Numero n2 = new Numero(10);
        Numero n3 = new Numero(3);
        
        // Verificar reflexividad
        Console.WriteLine($"Reflexividad: n1.CompareTo(n1) == 0: {n1.CompareTo(n1) == 0}");
        
        // Verificar antisimetría
        int comparacion1 = n1.CompareTo(n2);
        int comparacion2 = n2.CompareTo(n1);
        Console.WriteLine($"Antisimetría: n1.CompareTo(n2) = {comparacion1}, n2.CompareTo(n1) = {comparacion2}");
        Console.WriteLine($"  Signos opuestos: {(comparacion1 < 0 && comparacion2 > 0)}");
        
        // Verificar transitividad
        bool trans1 = n3.CompareTo(n1) < 0; // 3 < 5
        bool trans2 = n1.CompareTo(n2) < 0; // 5 < 10
        bool trans3 = n3.CompareTo(n2) < 0; // 3 < 10
        Console.WriteLine($"Transitividad: {trans1} && {trans2} => {trans3}:  {trans1 && trans2 && trans3}");
        
        // Verificar consistencia con null
        Console.WriteLine($"Consistencia con null: n1.CompareTo(null) > 0: {n1.CompareTo(null) > 0}");
```

**Consistencia con `Equals`:**

Si implementas `IComparable<T>`, deberías asegurarte de que `CompareTo` sea consistente con `Equals`:

```csharp
public class Producto : IComparable<Producto>
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public Producto(int id, string nombre, decimal precio)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
    }
    // Orden natural: por precio
    public int CompareTo(Producto other)
    {
        if (other == null) return 1;
        return this.Precio.CompareTo(other.Precio);
    }
    // Equals: por Id (identidad)
    public override bool Equals(object obj)
    {
        if (obj is Producto otro)
        {
            return this.Id == otro.Id;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
    public override string ToString()
    {
        return $"{Nombre} (${Precio})";
    }
}

// Código ejecutable
        Producto p1 = new Producto(1, "Laptop", 1200);
        Producto p2 = new Producto(2, "Mouse", 25);
        Producto p3 = new Producto(1, "Laptop", 1200); // Mismo Id que p1
        
        // CompareTo por precio
        Console.WriteLine($"{p1} comparado con {p2}: {p1.CompareTo(p2)}"); // > 0 (1200 > 25)
        
        // Equals por Id
        Console.WriteLine($"{p1} equals {p3}: {p1.Equals(p3)}"); // True (mismo Id)
        
        // Nota: CompareTo y Equals pueden dar resultados "inconsistentes"
        // p1.CompareTo(p3) == 0 sería False (diferentes precios en este ejemplo hipotético)
        // pero p1.Equals(p3) == True (mismo Id)
        // Esto es aceptable si está bien documentado
```

#### 4.1.3. Uso con Arrays

**Ordenación:   `Array.Sort<T>(T[] array)`**

Cuando un tipo implementa `IComparable<T>`, puedes usar `Array.Sort` directamente:

```csharp
public class Estudiante : IComparable<Estudiante>
{
    public string Nombre { get; set; }
    public double Promedio { get; set; }
    public Estudiante(string nombre, double promedio)
    {
        Nombre = nombre;
        Promedio = promedio;
    }
    // Orden natural: por promedio (descendente)
    public int CompareTo(Estudiante other)
    {
        if (other == null) return 1;
        // Descendente: invertir la comparación
        return other. Promedio.CompareTo(this.Promedio);
    }
    public override string ToString()
    {
        return $"{Nombre}: {Promedio:F2}";
    }
}

// Código ejecutable
        Estudiante[] estudiantes = new Estudiante[]
        {
            new Estudiante("Ana", 8.5),
            new Estudiante("Juan", 9.2),
            new Estudiante("María", 7.8),
            new Estudiante("Pedro", 9.5),
            new Estudiante("Laura", 8.9)
        };
        
        Console.WriteLine("=== Antes de ordenar ===");
        foreach (var est in estudiantes)
        {
            Console.WriteLine($"  {est}");
        }
        
        // Ordenar usando el orden natural (por promedio descendente)
        Array.Sort(estudiantes);
        
        Console.WriteLine("\n=== Después de ordenar (por promedio descendente) ===");
        foreach (var est in estudiantes)
        {
            Console.WriteLine($"  {est}");
        }
```

**Ejemplos prácticos con arrays de objetos personalizados:**

```csharp
public class Libro : IComparable<Libro>
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AñoPublicacion { get; set; }
    public int Paginas { get; set; }
    public Libro(string titulo, string autor, int año, int paginas)
    {
        Titulo = titulo;
        Autor = autor;
        AñoPublicacion = año;
        Paginas = paginas;
    }
    // Orden natural: por autor, luego por título
    public int CompareTo(Libro other)
    {
        if (other == null) return 1;
        // Primero por autor
        int comparacionAutor = this.Autor. CompareTo(other.Autor);
        if (comparacionAutor != 0)
        {
            return comparacionAutor;
        }
        // Si el autor es el mismo, por título
        return this.Titulo.CompareTo(other.Titulo);
    }
    public override string ToString()
    {
        return $"\"{Titulo}\" por {Autor} ({AñoPublicacion})";
    }
}

// Código ejecutable
        Libro[] biblioteca = new Libro[]
        {
            new Libro("El Quijote", "Cervantes", 1605, 863),
            new Libro("Cien años de soledad", "García Márquez", 1967, 471),
            new Libro("1984", "Orwell", 1949, 328),
            new Libro("La sombra del viento", "Ruiz Zafón", 2001, 565),
            new Libro("Rebelión en la granja", "Orwell", 1945, 144)
        };
        
        Console.WriteLine("=== Biblioteca sin ordenar ===");
        foreach (var libro in biblioteca)
        {
            Console.WriteLine($"  {libro}");
        }
        
        // Ordenar por orden natural (autor, título)
        Array.Sort(biblioteca);
        
        Console.WriteLine("\n=== Biblioteca ordenada (por autor, título) ===");
        foreach (var libro in biblioteca)
        {
            Console. WriteLine($"  {libro}");
        }
        
        // Búsqueda binaria (requiere array ordenado)
        Libro buscado = new Libro("1984", "Orwell", 0, 0);
        int indice = Array.BinarySearch(biblioteca, buscado);
        
        if (indice >= 0)
        {
            Console. WriteLine($"\n'1984' encontrado en posición {indice}");
        }
```

**Ejemplo con fechas:**

```csharp
public class Evento : IComparable<Evento>
{
    public string Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public string Lugar { get; set; }
    public Evento(string nombre, DateTime fecha, string lugar)
    {
        Nombre = nombre;
        Fecha = fecha;
        Lugar = lugar;
    }
    // Orden natural: cronológico (por fecha)
    public int CompareTo(Evento other)
    {
        if (other == null) return 1;
        return this.Fecha.CompareTo(other.Fecha);
    }
    public override string ToString()
    {
        return $"{Nombre} - {Fecha:dd/MM/yyyy} ({Lugar})";
    }
}

// Código ejecutable
        Evento[] agenda = new Evento[]
        {
            new Evento("Conferencia C#", new DateTime(2024, 6, 15), "Madrid"),
            new Evento("Meetup . NET", new DateTime(2024, 3, 20), "Barcelona"),
            new Evento("Hackathon", new DateTime(2024, 9, 5), "Valencia"),
            new Evento("Workshop", new DateTime(2024, 1, 10), "Sevilla")
        };
        
        Console.WriteLine("=== Agenda sin ordenar ===");
        foreach (var evento in agenda)
        {
            Console.WriteLine($"  {evento}");
        }
        
        // Ordenar cronológicamente
        Array.Sort(agenda);
        
        Console. WriteLine("\n=== Agenda ordenada cronológicamente ===");
        foreach (var evento in agenda)
        {
            Console.WriteLine($"  {evento}");
        }
        
        // Encontrar próximo evento
        DateTime hoy = DateTime.Today;
        Evento proximoEvento = null;
        
        foreach (var evento in agenda)
        {
            if (evento.Fecha >= hoy)
            {
                proximoEvento = evento;
                break;
            }
        }
        
        if (proximoEvento != null)
        {
            Console.WriteLine($"\nPróximo evento: {proximoEvento}");
        }
```

---

### 4.2. Interfaz `IComparer<T>`

#### 4.2.1. Fundamentos

**Propósito:   comparadores personalizados**

Mientras que `IComparable<T>` define el orden **natural** de un tipo, `IComparer<T>` permite definir **órdenes alternativos** o personalizados.

```csharp
public interface IComparer<T>
{
    int Compare(T x, T y);
}

```

**Método `Compare(T x, T y)`**

El método `Compare` compara dos objetos del mismo tipo y retorna:
- **Número negativo**:  si `x` es menor que `y`
- **Cero (0)**: si `x` es igual a `y`
- **Número positivo**: si `x` es mayor que `y`

**Valores de retorno:  negativo, cero, positivo**

Es similar a `CompareTo`, pero opera sobre dos objetos externos en lugar de comparar `this` con otro objeto.

#### 4.2.2. Implementación

**Crear clases comparadoras personalizadas:**

```csharp
public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public Persona(string nombre, string apellido, int edad)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
    }
    public override string ToString()
    {
        return $"{Nombre} {Apellido} ({Edad} años)";
    }
}
// Comparador por edad
public class ComparadorPorEdad : IComparer<Persona>
{
    public int Compare(Persona x, Persona y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        return x.Edad.CompareTo(y.Edad);
    }
}
// Comparador por nombre
public class ComparadorPorNombre : IComparer<Persona>
{
    public int Compare(Persona x, Persona y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        return x.Nombre.CompareTo(y. Nombre);
    }
}
// Comparador por apellido
public class ComparadorPorApellido : IComparer<Persona>
{
    public int Compare(Persona x, Persona y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        return x.Apellido. CompareTo(y.Apellido);
    }
}

// Código ejecutable
        Persona[] personas = new Persona[]
        {
            new Persona("Juan", "García", 30),
            new Persona("Ana", "López", 25),
            new Persona("Pedro", "García", 28),
            new Persona("María", "Martínez", 32),
            new Persona("Carlos", "López", 27)
        };
        
        Console.WriteLine("=== Array original ===");
        foreach (var p in personas)
        {
            Console.WriteLine($"  {p}");
        }
        
        // Ordenar por edad
        Array.Sort(personas, new ComparadorPorEdad());
        Console.WriteLine("\n=== Ordenado por edad ===");
        foreach (var p in personas)
        {
            Console.WriteLine($"  {p}");
        }
        
        // Ordenar por nombre
        Array.Sort(personas, new ComparadorPorNombre());
        Console.WriteLine("\n=== Ordenado por nombre ===");
        foreach (var p in personas)
        {
            Console.WriteLine($"  {p}");
        }
        
        // Ordenar por apellido
        Array.Sort(personas, new ComparadorPorApellido());
        Console.WriteLine("\n=== Ordenado por apellido ===");
        foreach (var p in personas)
        {
            Console.WriteLine($"  {p}");
        }
```

**Múltiples criterios de ordenación:**

```csharp
public class Producto
{
    public string Nombre { get; set; }
    public string Categoria { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public Producto(string nombre, string categoria, decimal precio, int stock)
    {
        Nombre = nombre;
        Categoria = categoria;
        Precio = precio;
        Stock = stock;
    }
    public override string ToString()
    {
        return $"{Nombre} ({Categoria}) - ${Precio} [Stock: {Stock}]";
    }
}
// Comparador por categoría, luego por precio
public class ComparadorCategoriaPrecio : IComparer<Producto>
{
    public int Compare(Producto x, Producto y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        // Primero por categoría
        int comparacionCategoria = x.Categoria.CompareTo(y. Categoria);
        if (comparacionCategoria != 0)
        {
            return comparacionCategoria;
        }
        // Si categorías iguales, por precio
        return x.Precio.CompareTo(y.Precio);
    }
}
// Comparador por stock (descendente)
public class ComparadorStockDescendente : IComparer<Producto>
{
    public int Compare(Producto x, Producto y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        // Descendente: invertir la comparación
        return y.Stock.CompareTo(x.Stock);
    }
}

// Código ejecutable
        Producto[] inventario = new Producto[]
        {
            new Producto("Laptop", "Electrónica", 1200, 5),
            new Producto("Mouse", "Electrónica", 25, 50),
            new Producto("Libro C#", "Libros", 45, 20),
            new Producto("Teclado", "Electrónica", 75, 30),
            new Producto("Novela", "Libros", 15, 100)
        };
        
        Console.WriteLine("=== Inventario original ===");
        foreach (var p in inventario)
        {
            Console.WriteLine($"  {p}");
        }
        
        // Ordenar por categoría, luego por precio
        Array.Sort(inventario, new ComparadorCategoriaPrecio());
        Console.WriteLine("\n=== Ordenado por categoría y precio ===");
        foreach (var p in inventario)
        {
            Console.WriteLine($"  {p}");
        }
        
        // Ordenar por stock (descendente)
        Array.Sort(inventario, new ComparadorStockDescendente());
        Console.WriteLine("\n=== Ordenado por stock (mayor a menor) ===");
        foreach (var p in inventario)
        {
            Console.WriteLine($"  {p}");
        }
```

**Comparadores inversos:**

```csharp
// Comparador genérico que invierte cualquier otro comparador
public class ComparadorInverso<T> : IComparer<T>
{
    private IComparer<T> comparadorOriginal;
    public ComparadorInverso(IComparer<T> comparadorOriginal)
    {
        this.comparadorOriginal = comparadorOriginal;
    }
    public int Compare(T x, T y)
    {
        // Invertir el resultado del comparador original
        return comparadorOriginal.Compare(y, x);
    }
}

// Código ejecutable
        Persona[] personas = new Persona[]
        {
            new Persona("Juan", "García", 30),
            new Persona("Ana", "López", 25),
            new Persona("Pedro", "García", 28)
        };
        
        // Ordenar por edad (ascendente)
        Array.Sort(personas, new ComparadorPorEdad());
        Console.WriteLine("=== Por edad ascendente ===");
        foreach (var p in personas)
        {
            Console.WriteLine($"  {p}");
        }
        
        // Ordenar por edad (descendente) usando ComparadorInverso
        Array.Sort(personas, new ComparadorInverso<Persona>(new ComparadorPorEdad()));
        Console.WriteLine("\n=== Por edad descendente ===");
        foreach (var p in personas)
        {
            Console.WriteLine($"  {p}");
        }
```

#### 4.2.3. Uso con Arrays

**Pasar a métodos de ordenación:    `Array.Sort<T>(T[] array, IComparer<T> comparer)`**

```csharp
public class Empleado
{
    public string Nombre { get; set; }
    public string Departamento { get; set; }
    public decimal Salario { get; set; }
    public DateTime FechaContratacion { get; set; }
    public Empleado(string nombre, string departamento, decimal salario, DateTime fecha)
    {
        Nombre = nombre;
        Departamento = departamento;
        Salario = salario;
        FechaContratacion = fecha;
    }
    public override string ToString()
    {
        return $"{Nombre} ({Departamento}) - ${Salario:F0} - {FechaContratacion:dd/MM/yyyy}";
    }
}
// Comparador por salario
public class ComparadorPorSalario : IComparer<Empleado>
{
    public int Compare(Empleado x, Empleado y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        return x.Salario.CompareTo(y.Salario);
    }
}
// Comparador por antigüedad
public class ComparadorPorAntiguedad : IComparer<Empleado>
{
    public int Compare(Empleado x, Empleado y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        // Fecha más antigua primero
        return x.FechaContratacion.CompareTo(y.FechaContratacion);
    }
}

// Código ejecutable
        Empleado[] empleados = new Empleado[]
        {
            new Empleado("Ana García", "IT", 50000, new DateTime(2020, 3, 15)),
            new Empleado("Juan López", "Ventas", 45000, new DateTime(2018, 7, 1)),
            new Empleado("María Martínez", "IT", 55000, new DateTime(2019, 11, 20)),
            new Empleado("Pedro Sánchez", "RRHH", 48000, new DateTime(2021, 2, 10))
        };
        
        Console.WriteLine("=== Empleados - Lista original ===");
        MostrarEmpleados(empleados);
        
        // Ordenar por salario
        Array.Sort(empleados, new ComparadorPorSalario());
        Console.WriteLine("\n=== Ordenado por salario ===");
        MostrarEmpleados(empleados);
        
        // Ordenar por antigüedad
        Array.Sort(empleados, new ComparadorPorAntiguedad());
        Console.WriteLine("\n=== Ordenado por antigüedad (más antiguos primero) ===");
        MostrarEmpleados(empleados);

// Funciones locales
    void MostrarEmpleados(Empleado[] empleados)
    {
        foreach (var emp in empleados)
        {
            Console.WriteLine($"  {emp}");
        }
    }
```

**Comparadores con lambdas:    `Comparer<T>.Create((x, y) => ...)`**

C# proporciona una forma más concisa de crear comparadores usando lambdas:

```csharp
// Código ejecutable
        Persona[] personas = new Persona[]
        {
            new Persona("Juan", "García", 30),
            new Persona("Ana", "López", 25),
            new Persona("Pedro", "García", 28),
            new Persona("María", "Martínez", 32)
        };
        
        Console.WriteLine("=== Array original ===");
        foreach (var p in personas)
        {
            Console.WriteLine($"  {p}");
        }
        
        // Crear comparador con lambda:  ordenar por edad
        var comparadorEdad = Comparer<Persona>.Create((p1, p2) => p1.Edad.CompareTo(p2.Edad));
        Array.Sort(personas, comparadorEdad);
        
        Console.WriteLine("\n=== Ordenado por edad (con lambda) ===");
        foreach (var p in personas)
        {
            Console.WriteLine($"  {p}");
        }
        
        // Crear comparador con lambda: ordenar por longitud del nombre
        var comparadorLongitudNombre = Comparer<Persona>.Create((p1, p2) => 
            p1.Nombre. Length.CompareTo(p2.Nombre.Length));
        Array.Sort(personas, comparadorLongitudNombre);
        
        Console.WriteLine("\n=== Ordenado por longitud del nombre ===");
        foreach (var p in personas)
        {
            Console.WriteLine($"  {p}");
        }
        
        // Comparador descendente con lambda
        var comparadorEdadDesc = Comparer<Persona>. Create((p1, p2) => 
            p2.Edad.CompareTo(p1.Edad)); // Invertido
        Array.Sort(personas, comparadorEdadDesc);
        
        Console.WriteLine("\n=== Ordenado por edad descendente ===");
        foreach (var p in personas)
        {
            Console.WriteLine($"  {p}");
        }
```

#### 4.2.4. Ejemplos Prácticos con Arrays

**Ordenar por múltiples campos:**

```csharp
public class Estudiante
{
    public string Nombre { get; set; }
    public string Carrera { get; set; }
    public int Semestre { get; set; }
    public double Promedio { get; set; }
    public Estudiante(string nombre, string carrera, int semestre, double promedio)
    {
        Nombre = nombre;
        Carrera = carrera;
        Semestre = semestre;
        Promedio = promedio;
    }
    public override string ToString()
    {
        return $"{Nombre} - {Carrera} (Sem.  {Semestre}) - Promedio: {Promedio: F2}";
    }
}

// Código ejecutable
        Estudiante[] estudiantes = new Estudiante[]
        {
            new Estudiante("Ana", "Ingeniería", 5, 8.5),
            new Estudiante("Juan", "Medicina", 3, 9.2),
            new Estudiante("María", "Ingeniería", 5, 9.0),
            new Estudiante("Pedro", "Derecho", 2, 7.8),
            new Estudiante("Laura", "Ingeniería", 3, 8.9)
        };
        
        Console.WriteLine("=== Estudiantes - Lista original ===");
        MostrarEstudiantes(estudiantes);
        
        // Ordenar por carrera, luego por semestre, luego por promedio (descendente)
        var comparador = Comparer<Estudiante>.Create((e1, e2) =>
        {
            // Primero por carrera
            int comparacionCarrera = e1.Carrera.CompareTo(e2.Carrera);
            if (comparacionCarrera != 0)
            {
                return comparacionCarrera;
            }
            
            // Luego por semestre
            int comparacionSemestre = e1.Semestre.CompareTo(e2.Semestre);
            if (comparacionSemestre != 0)
            {
                return comparacionSemestre;
            }
            
            // Finalmente por promedio (descendente)
            return e2.Promedio.CompareTo(e1.Promedio);
        });
        
        Array.Sort(estudiantes, comparador);
        
        Console.WriteLine("\n=== Ordenado por carrera, semestre, promedio (desc) ===");
        MostrarEstudiantes(estudiantes);

// Funciones locales
    void MostrarEstudiantes(Estudiante[] estudiantes)
    {
        foreach (var est in estudiantes)
        {
            Console.WriteLine($"  {est}");
        }
    }
```

**Ordenación case-insensitive de strings:**

```csharp
// Código ejecutable
        string[] palabras = { "Zebra", "apple", "Banana", "CHERRY", "date" };
        
        Console. WriteLine("=== Array original ===");
        Console.WriteLine($"  [{string.Join(", ", palabras)}]");
        
        // Ordenación case-sensitive (por defecto)
        string[] palabrasCaseSensitive = (string[])palabras.Clone();
        Array.Sort(palabrasCaseSensitive);
        Console.WriteLine("\n=== Case-sensitive (por defecto) ===");
        Console.WriteLine($"  [{string.Join(", ", palabrasCaseSensitive)}]");
        // apple, Banana, CHERRY, date, Zebra (mayúsculas primero en ASCII)
        
        // Ordenación case-insensitive con StringComparer
        string[] palabrasCaseInsensitive = (string[])palabras.Clone();
        Array.Sort(palabrasCaseInsensitive, StringComparer.OrdinalIgnoreCase);
        Console.WriteLine("\n=== Case-insensitive ===");
        Console.WriteLine($"  [{string.Join(", ", palabrasCaseInsensitive)}]");
        // apple, Banana, CHERRY, date, Zebra (orden alfabético ignorando mayúsculas)
        
        // Ordenación por longitud, luego alfabética
        var comparadorLongitud = Comparer<string>.Create((s1, s2) =>
        {
            int comparacionLongitud = s1.Length.CompareTo(s2.Length);
            if (comparacionLongitud != 0)
            {
                return comparacionLongitud;
            }
            return string.Compare(s1, s2, StringComparison.OrdinalIgnoreCase);
        });
        
        string[] palabrasPorLongitud = (string[])palabras.Clone();
        Array.Sort(palabrasPorLongitud, comparadorLongitud);
        Console.WriteLine("\n=== Por longitud, luego alfabética ===");
        Console.WriteLine($"  [{string.Join(", ", palabrasPorLongitud)}]");
```

**Comparadores complejos:**

```csharp
public class Tarea
{
    public string Titulo { get; set; }
    public int Prioridad { get; set; } // 1 = Alta, 2 = Media, 3 = Baja
    public DateTime FechaVencimiento { get; set; }
    public bool Completada { get; set; }
    public Tarea(string titulo, int prioridad, DateTime fechaVencimiento, bool completada)
    {
        Titulo = titulo;
        Prioridad = prioridad;
        FechaVencimiento = fechaVencimiento;
        Completada = completada;
    }
    public override string ToString()
    {
        string prioridadTexto = Prioridad == 1 ? "Alta" :  Prioridad == 2 ?  "Media" : "Baja";
        string estadoTexto = Completada ?  "✓" : "○";
        return $"{estadoTexto} {Titulo} [Prioridad: {prioridadTexto}] - Vence: {FechaVencimiento:dd/MM/yyyy}";
    }
}

// Código ejecutable
        Tarea[] tareas = new Tarea[]
        {
            new Tarea("Preparar presentación", 1, new DateTime(2024, 6, 10), false),
            new Tarea("Revisar emails", 3, new DateTime(2024, 6, 5), false),
            new Tarea("Reunión con cliente", 1, new DateTime(2024, 6, 8), false),
            new Tarea("Documentar código", 2, new DateTime(2024, 6, 15), false),
            new Tarea("Comprar material", 2, new DateTime(2024, 6, 7), true)
        };
        
        Console.WriteLine("=== Lista de tareas original ===");
        MostrarTareas(tareas);
        
        // Ordenar tareas:   pendientes primero, luego por prioridad, luego por fecha
        var comparadorTareas = Comparer<Tarea>.Create((t1, t2) =>
        {
            // Primero:  tareas pendientes antes que completadas
            if (t1.Completada != t2.Completada)
            {
                return t1.Completada ? 1 : -1;
            }
            
            // Segundo: por prioridad (1 = alta antes que 3 = baja)
            int comparacionPrioridad = t1.Prioridad.CompareTo(t2.Prioridad);
            if (comparacionPrioridad != 0)
            {
                return comparacionPrioridad;
            }
            
            // Tercero: por fecha de vencimiento
            return t1.FechaVencimiento.CompareTo(t2.FechaVencimiento);
        });
        
        Array.Sort(tareas, comparadorTareas);
        
        Console.WriteLine("\n=== Tareas ordenadas (pendientes, prioridad, fecha) ===");
        MostrarTareas(tareas);

// Funciones locales
    void MostrarTareas(Tarea[] tareas)
    {
        foreach (var tarea in tareas)
        {
            Console.WriteLine($"  {tarea}");
        }
    }
```

---

### 4.3. Interfaz `IEquatable<T>`

#### 4.3.1. Fundamentos

**Propósito:  comparación de igualdad eficiente y fuertemente tipada**

La interfaz `IEquatable<T>` proporciona un método fuertemente tipado para comparar igualdad, evitando el boxing y siendo más eficiente que `Object. Equals(object obj)`.

```csharp
public interface IEquatable<T>
{
    bool Equals(T other);
}

```

**Método `Equals(T other)`**

Retorna `true` si el objeto actual es igual a `other`, `false` en caso contrario.

#### 4.3.2. Implementación

**Implementar en tipos propios:**

```csharp
public class Punto : IEquatable<Punto>
{
    public int X { get; set; }
    public int Y { get; set; }
    public Punto(int x, int y)
    {
        X = x;
        Y = y;
    }
    // Implementación de IEquatable<Punto>
    public bool Equals(Punto other)
    {
        // Verificar null
        if (other == null)
        {
            return false;
        }
        // Comparar campos
        return this.X == other.X && this.Y == other.Y;
    }
    // También debemos sobrescribir Object.Equals
    public override bool Equals(object obj)
    {
        // Usar Equals(Punto other) si obj es un Punto
        if (obj is Punto otroPunto)
        {
            return Equals(otroPunto);
        }
        return false;
    }
    // Y sobrescribir GetHashCode
    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

// Código ejecutable
        Punto p1 = new Punto(3, 4);
        Punto p2 = new Punto(3, 4);
        Punto p3 = new Punto(5, 6);
        
        // Usar Equals fuertemente tipado
        Console. WriteLine($"p1.Equals(p2): {p1.Equals(p2)}"); // True
        Console.WriteLine($"p1.Equals(p3): {p1.Equals(p3)}"); // False
        
        // Object.Equals también funciona
        Console.WriteLine($"p1.Equals((object)p2): {p1.Equals((object)p2)}"); // True
        
        // Operador == (si lo sobrecargamos)
        // Console.WriteLine($"p1 == p2: {p1 == p2}");
```

**Relación con `Object.Equals(object obj)`:**

Al implementar `IEquatable<T>`, siempre debes también sobrescribir `Object.Equals`:

```csharp
public class ProductoCodigo : IEquatable<ProductoCodigo>
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public ProductoCodigo(string codigo, string nombre)
    {
        Codigo = codigo;
        Nombre = nombre;
    }
    // IEquatable<ProductoCodigo>:  comparación fuertemente tipada
    public bool Equals(ProductoCodigo other)
    {
        if (other == null)
        {
            return false;
        }
        // Dos productos son iguales si tienen el mismo código
        return this.Codigo == other.Codigo;
    }
    // Object.Equals: comparación genérica
    public override bool Equals(object obj)
    {
        return Equals(obj as ProductoCodigo);
    }
    // GetHashCode: debe ser consistente con Equals
    public override int GetHashCode()
    {
        return Codigo?. GetHashCode() ?? 0;
    }
    public override string ToString()
    {
        return $"{Codigo}:  {Nombre}";
    }
}

// Código ejecutable
        ProductoCodigo prod1 = new ProductoCodigo("LAP001", "Laptop Dell");
        ProductoCodigo prod2 = new ProductoCodigo("LAP001", "Laptop HP"); // Mismo código
        ProductoCodigo prod3 = new ProductoCodigo("MOU001", "Mouse Logitech");
        
        Console.WriteLine($"prod1 == prod2 (mismo código): {prod1.Equals(prod2)}"); // True
        Console.WriteLine($"prod1 == prod3 (diferente código): {prod1.Equals(prod3)}"); // False
        
        // Importante: mismo código = mismo hash
        Console.WriteLine($"\nHash prod1: {prod1.GetHashCode()}");
        Console.WriteLine($"Hash prod2: {prod2.GetHashCode()}");
        Console.WriteLine($"¿Hashes iguales? {prod1.GetHashCode() == prod2.GetHashCode()}"); // True
```

**Sobreescribir `GetHashCode()` siempre:**

⚠️ **REGLA FUNDAMENTAL**: Si dos objetos son iguales según `Equals`, **deben** tener el mismo `GetHashCode`.

```csharp
public class Estudiante : IEquatable<Estudiante>
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public double Promedio { get; set; }
    public Estudiante(int id, string nombre, double promedio)
    {
        Id = id;
        Nombre = nombre;
        Promedio = promedio;
    }
    // Igualdad por Id
    public bool Equals(Estudiante other)
    {
        if (other == null) return false;
        return this.Id == other.Id;
    }
    public override bool Equals(object obj)
    {
        return Equals(obj as Estudiante);
    }
    // GetHashCode basado en Id (consistente con Equals)
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
    public override string ToString()
    {
        return $"[{Id}] {Nombre} - {Promedio:F2}";
    }
}

// Código ejecutable
        Estudiante e1 = new Estudiante(1, "Ana", 8.5);
        Estudiante e2 = new Estudiante(1, "Ana García", 9.0); // Mismo Id
        Estudiante e3 = new Estudiante(2, "Juan", 8.5);
        
        Console.WriteLine($"e1 equals e2: {e1.Equals(e2)}"); // True (mismo Id)
        Console.WriteLine($"e1 hash: {e1.GetHashCode()}");
        Console.WriteLine($"e2 hash: {e2.GetHashCode()}");
        Console.WriteLine($"Hashes iguales: {e1.GetHashCode() == e2.GetHashCode()}"); // True
        
        Console.WriteLine($"\ne1 equals e3: {e1.Equals(e3)}"); // False
        Console.WriteLine($"e3 hash: {e3.GetHashCode()}");
        Console.WriteLine($"Hashes diferentes: {e1.GetHashCode() != e3.GetHashCode()}"); // True
```

#### 4.3.3. Uso con Arrays

**Búsqueda eficiente:   `Array.IndexOf`, `Array.Find`**

```csharp
// Código ejecutable
        Punto[] puntos = new Punto[]
        {
            new Punto(1, 2),
            new Punto(3, 4),
            new Punto(5, 6),
            new Punto(7, 8)
        };
        
        // Buscar índice de un punto específico
        Punto buscado = new Punto(3, 4);
        int indice = Array. IndexOf(puntos, buscado);
        
        Console.WriteLine($"Buscando {buscado}:");
        if (indice >= 0)
        {
            Console.WriteLine($"  Encontrado en índice {indice}");
        }
        else
        {
            Console.WriteLine($"  No encontrado");
        }
        
        // Verificar si existe
        bool existe = Array.Exists(puntos, p => p.Equals(buscado));
        Console.WriteLine($"¿Existe {buscado}? {existe}");
        
        // Encontrar con predicado
        Punto encontrado = Array.Find(puntos, p => p.X > 4);
        Console.WriteLine($"Primer punto con X > 4: {encontrado}");
```

**Ejemplos prácticos:**

```csharp
public class Cliente : IEquatable<Cliente>
{
    public string DNI { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public Cliente(string dni, string nombre, string email)
    {
        DNI = dni;
        Nombre = nombre;
        Email = email;
    }
    // Igualdad por DNI
    public bool Equals(Cliente other)
    {
        if (other == null) return false;
        return this.DNI == other.DNI;
    }
    public override bool Equals(object obj)
    {
        return Equals(obj as Cliente);
    }
    public override int GetHashCode()
    {
        return DNI?. GetHashCode() ?? 0;
    }
    public override string ToString()
    {
        return $"{DNI} - {Nombre} ({Email})";
    }
}

// Código ejecutable
        Cliente[] clientes = new Cliente[]
        {
            new Cliente("12345678A", "Juan Pérez", "juan@email.com"),
            new Cliente("87654321B", "Ana García", "ana@email.com"),
            new Cliente("11111111C", "Pedro López", "pedro@email.com"),
            new Cliente("22222222D", "María Martínez", "maria@email.com")
        };
        
        Console.WriteLine("=== Lista de clientes ===");
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"  {cliente}");
        }
        
        // Buscar cliente por DNI
        Cliente clienteBuscado = new Cliente("87654321B", null, null);
        int indice = Array.IndexOf(clientes, clienteBuscado);
        
        Console.WriteLine($"\nBuscando cliente con DNI {clienteBuscado.DNI}:");
        if (indice >= 0)
        {
            Console.WriteLine($"  Encontrado:  {clientes[indice]}");
        }
        
        // Verificar si un DNI ya existe (evitar duplicados)
        string nuevoDNI = "12345678A";
        bool existe = Array.Exists(clientes, c => c.DNI == nuevoDNI);
        
        if (existe)
        {
            Console.WriteLine($"\nEl DNI {nuevoDNI} ya está registrado");
        }
        else
        {
            Console.WriteLine($"\nEl DNI {nuevoDNI} está disponible");
        }
        
        // Encontrar cliente por email
        Cliente clientePorEmail = Array.Find(clientes, c => c.Email == "pedro@email.com");
        Console.WriteLine($"\nCliente con email pedro@email.com: {clientePorEmail}");
```

---

### 4.4. Métodos y Propiedades Auxiliares

#### 4.4.1. `Comparer<T>.Default`

**Comparador por defecto - Usa `IComparable<T>` del tipo**

```csharp
// Código ejecutable
        // Comparer<T>.Default usa IComparable<T> si está implementado
        int[] numeros = { 5, 2, 8, 1, 9 };
        
        // Estas dos líneas son equivalentes
        Array.Sort(numeros);
        // Array.Sort(numeros, Comparer<int>.Default);
        
        Console.WriteLine($"Números ordenados: [{string.Join(", ", numeros)}]");
        
        // Con tipos personalizados
        string[] palabras = { "zebra", "apple", "banana" };
        Array.Sort(palabras, Comparer<string>.Default);
        Console.WriteLine($"Palabras ordenadas: [{string.Join(", ", palabras)}]");
```

#### 4.4.2. `EqualityComparer<T>. Default`

**Comparador de igualdad por defecto - Usa `IEquatable<T>` o `Equals/GetHashCode`**

```csharp
// Código ejecutable
        Punto p1 = new Punto(3, 4);
        Punto p2 = new Punto(3, 4);
        
        // EqualityComparer<T>.Default usa IEquatable<T> si está implementado
        var comparadorIgualdad = EqualityComparer<Punto>.Default;
        
        bool sonIguales = comparadorIgualdad.Equals(p1, p2);
        Console.WriteLine($"¿p1 y p2 son iguales? {sonIguales}");
        
        int hash1 = comparadorIgualdad.GetHashCode(p1);
        int hash2 = comparadorIgualdad.GetHashCode(p2);
        Console.WriteLine($"Hash p1: {hash1}");
        Console.WriteLine($"Hash p2: {hash2}");
```

#### 4.4.3. Comparadores Especiales

**`StringComparer`: opciones de comparación de strings**

```csharp
// Código ejecutable
        string[] palabras = { "Manzana", "banana", "CEREZA", "durazno" };
        
        Console.WriteLine("=== Original ===");
        Console.WriteLine($"  [{string.Join(", ", palabras)}]");
        
        // StringComparer.Ordinal (case-sensitive, ordinal)
        string[] palabras1 = (string[])palabras.Clone();
        Array.Sort(palabras1, StringComparer.Ordinal);
        Console.WriteLine("\n=== Ordinal (case-sensitive) ===");
        Console.WriteLine($"  [{string.Join(", ", palabras1)}]");
        
        // StringComparer.OrdinalIgnoreCase (case-insensitive)
        string[] palabras2 = (string[])palabras.Clone();
        Array.Sort(palabras2, StringComparer. OrdinalIgnoreCase);
        Console.WriteLine("\n=== OrdinalIgnoreCase ===");
        Console.WriteLine($"  [{string.Join(", ", palabras2)}]");
        
        // StringComparer. CurrentCulture (según cultura actual)
        string[] palabras3 = (string[])palabras.Clone();
        Array.Sort(palabras3, StringComparer.CurrentCulture);
        Console.WriteLine("\n=== CurrentCulture ===");
        Console.WriteLine($"  [{string.Join(", ", palabras3)}]");
        
        // StringComparer.CurrentCultureIgnoreCase
        string[] palabras4 = (string[])palabras.Clone();
        Array.Sort(palabras4, StringComparer.CurrentCultureIgnoreCase);
        Console.WriteLine("\n=== CurrentCultureIgnoreCase ===");
        Console.WriteLine($"  [{string.Join(", ", palabras4)}]");
```

**`Comparer<T>.Create`: crear desde delegate**

Ya vimos esto anteriormente, pero aquí va un resumen:

```csharp
// Código ejecutable
        int[] numeros = { 1, -5, 3, -2, 8, -9, 4 };
        
        Console.WriteLine($"Original: [{string.Join(", ", numeros)}]");
        
        // Ordenar por valor absoluto
        var comparadorAbsoluto = Comparer<int>.Create((x, y) => 
            Math.Abs(x).CompareTo(Math.Abs(y)));
        
        Array.Sort(numeros, comparadorAbsoluto);
        Console.WriteLine($"Por valor absoluto: [{string.Join(", ", numeros)}]");
```

---

### 4.5. Ordenación con Arrays

#### 4.5.1.  Métodos de Ordenación

**`Array.Sort<T>(T[] array)`**

Ordena el array completo usando el orden natural (`IComparable<T>`):

```csharp
// Código ejecutable
        int[] numeros = { 5, 2, 8, 1, 9, 3 };
        
        Console.WriteLine($"Antes:  [{string.Join(", ", numeros)}]");
        Array.Sort(numeros);
        Console.WriteLine($"Después: [{string.Join(", ", numeros)}]");
```

**`Array.Sort<T>(T[] array, IComparer<T> comparer)`**

Ordena usando un comparador personalizado:

```csharp
// Código ejecutable
        string[] palabras = { "banana", "Manzana", "cereza" };
        
        Console.WriteLine($"Antes: [{string. Join(", ", palabras)}]");
        Array.Sort(palabras, StringComparer.OrdinalIgnoreCase);
        Console.WriteLine($"Después: [{string.Join(", ", palabras)}]");
```

**`Array.Sort<T>(T[] array, Comparison<T> comparison)`**

Ordena usando un delegate `Comparison<T>`:

```csharp
// Código ejecutable
        int[] numeros = { 1, -5, 3, -2, 8 };
        
        Console.WriteLine($"Antes: [{string. Join(", ", numeros)}]");
        
        // Ordenar por valor absoluto usando Comparison
        Array.Sort(numeros, (x, y) => Math.Abs(x).CompareTo(Math.Abs(y)));
        
        Console.WriteLine($"Después: [{string.Join(", ", numeros)}]");
```

#### 4.5.2. Ordenación con Lambdas

**Uso directo de `Comparison<T>` delegate:**

```csharp
public class Archivo
{
    public string Nombre { get; set; }
    public long TamañoBytes { get; set; }
    public DateTime FechaModificacion { get; set; }
    public Archivo(string nombre, long tamaño, DateTime fecha)
    {
        Nombre = nombre;
        TamañoBytes = tamaño;
        FechaModificacion = fecha;
    }
    public override string ToString()
    {
        return $"{Nombre} ({TamañoBytes / 1024}KB) - {FechaModificacion:dd/MM/yyyy}";
    }
}

// Código ejecutable
        Archivo[] archivos = new Archivo[]
        {
            new Archivo("documento.pdf", 512000, new DateTime(2024, 3, 15)),
            new Archivo("foto.jpg", 2048000, new DateTime(2024, 1, 20)),
            new Archivo("video.mp4", 10240000, new DateTime(2024, 5, 10)),
            new Archivo("audio. mp3", 3072000, new DateTime(2024, 2, 5))
        };
        
        Console. WriteLine("=== Archivos originales ===");
        MostrarArchivos(archivos);
        
        // Ordenar por tamaño (lambda directa)
        Array.Sort(archivos, (a1, a2) => a1.TamañoBytes.CompareTo(a2.TamañoBytes));
        Console.WriteLine("\n=== Ordenado por tamaño ===");
        MostrarArchivos(archivos);
        
        // Ordenar por fecha (lambda directa)
        Array.Sort(archivos, (a1, a2) => a1.FechaModificacion.CompareTo(a2.FechaModificacion));
        Console.WriteLine("\n=== Ordenado por fecha de modificación ===");
```markdown
FechaModificacion));
        Console.WriteLine("\n=== Ordenado por fecha ===");
        MostrarArchivos(archivos);
        
        // Ordenar por nombre (lambda directa, case-insensitive)
        Array.Sort(archivos, (a1, a2) => 
            string.Compare(a1.Nombre, a2.Nombre, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("\n=== Ordenado por nombre ===");
        MostrarArchivos(archivos);
    }
    
    static void MostrarArchivos(Archivo[] archivos)
    {
        foreach (var archivo in archivos)
        {
            Console.WriteLine($"  {archivo}");
        }
    }
}
```

**Ejemplos avanzados:**

```csharp
public class Transaccion
{
    public int Id { get; set; }
    public string Tipo { get; set; } // "Ingreso" o "Egreso"
    public decimal Monto { get; set; }
    public DateTime Fecha { get; set; }
    public Transaccion(int id, string tipo, decimal monto, DateTime fecha)
    {
        Id = id;
        Tipo = tipo;
        Monto = monto;
        Fecha = fecha;
    }
    public override string ToString()
    {
        return $"[{Id}] {Tipo}:  ${Monto:F2} - {Fecha:dd/MM/yyyy}";
    }
}

// Código ejecutable
        Transaccion[] transacciones = new Transaccion[]
        {
            new Transaccion(1, "Ingreso", 1000, new DateTime(2024, 3, 15)),
            new Transaccion(2, "Egreso", 500, new DateTime(2024, 3, 10)),
            new Transaccion(3, "Ingreso", 1500, new DateTime(2024, 3, 20)),
            new Transaccion(4, "Egreso", 300, new DateTime(2024, 3, 12)),
            new Transaccion(5, "Ingreso", 800, new DateTime(2024, 3, 18))
        };
        
        Console.WriteLine("=== Transacciones originales ===");
        MostrarTransacciones(transacciones);
        
        // Ordenar primero por tipo (Ingreso antes que Egreso), luego por fecha
        Array. Sort(transacciones, (t1, t2) =>
        {
            int comparacionTipo = t1.Tipo.CompareTo(t2.Tipo);
            if (comparacionTipo != 0)
            {
                return comparacionTipo;
            }
            return t1.Fecha.CompareTo(t2.Fecha);
        });
        
        Console.WriteLine("\n=== Ordenado por tipo, luego fecha ===");
        MostrarTransacciones(transacciones);
        
        // Ordenar por monto (descendente)
        Array.Sort(transacciones, (t1, t2) => t2.Monto.CompareTo(t1.Monto));
        
        Console.WriteLine("\n=== Ordenado por monto (mayor a menor) ===");
        MostrarTransacciones(transacciones);

// Funciones locales
    void MostrarTransacciones(Transaccion[] transacciones)
    {
        foreach (var t in transacciones)
        {
            Console.WriteLine($"  {t}");
        }
    }
```

#### 4.5.3. Ordenación Parcial

**`Array.Sort<T>(T[] array, int index, int length)`**

Ordena solo una porción del array:

```csharp
// Código ejecutable
        int[] numeros = { 9, 3, 7, 1, 5, 8, 2, 6, 4 };
        
        Console.WriteLine($"Antes:   [{string.Join(", ", numeros)}]");
        
        // Ordenar solo desde índice 2, con longitud 4 (elementos 7, 1, 5, 8)
        Array.Sort(numeros, 2, 4);
        
        Console.WriteLine($"Después: [{string.Join(", ", numeros)}]");
        // Resultado: [9, 3, 1, 5, 7, 8, 2, 6, 4]
        //            [---- sin cambios ----][ordenado][sin cambios]
```

**Ejemplo práctico:**

```csharp
// Código ejecutable
        // Simular datos con encabezado y pie
        string[] datos = 
        {
            "=== ENCABEZADO ===",
            "Registro 5",
            "Registro 2",
            "Registro 8",
            "Registro 1",
            "Registro 3",
            "=== PIE DE PÁGINA ==="
        };
        
        Console.WriteLine("=== Antes de ordenar ===");
        foreach (var linea in datos)
        {
            Console.WriteLine(linea);
        }
        
        // Ordenar solo los registros (índice 1 a 5)
        Array.Sort(datos, 1, 5);
        
        Console.WriteLine("\n=== Después de ordenar (solo registros) ===");
        foreach (var linea in datos)
        {
            Console.WriteLine(linea);
        }
```

#### 4.5.4. Ordenación Estable vs.  Inestable

**Estabilidad en ordenación:**

Una ordenación es **estable** si mantiene el orden relativo de elementos iguales según el criterio de ordenación. 

```csharp
public class Producto
{
    public string Categoria { get; set; }
    public string Nombre { get; set; }
    public int Id { get; set; }
    public Producto(string categoria, string nombre, int id)
    {
        Categoria = categoria;
        Nombre = nombre;
        Id = id;
    }
    public override string ToString()
    {
        return $"[{Id}] {Categoria} - {Nombre}";
    }
}

// Código ejecutable
        Producto[] productos = new Producto[]
        {
            new Producto("Electrónica", "Laptop", 1),
            new Producto("Libros", "Novel", 2),
            new Producto("Electrónica", "Mouse", 3),
            new Producto("Libros", "Ensayo", 4),
            new Producto("Electrónica", "Teclado", 5)
        };
        
        Console.WriteLine("=== Orden original (por Id de inserción) ===");
        MostrarProductos(productos);
        
        // Array.Sort NO es estable
        Array.Sort(productos, (p1, p2) => p1.Categoria.CompareTo(p2.Categoria));
        
        Console.WriteLine("\n=== Después de ordenar por categoría ===");
        Console.WriteLine("(Nota:   Array.Sort NO garantiza estabilidad)");
        MostrarProductos(productos);
        
        // Para ordenación estable, necesitarías implementar tu propio algoritmo
        // o usar LINQ (que veremos más adelante)

// Funciones locales
    void MostrarProductos(Producto[] productos)
    {
        foreach (var p in productos)
        {
            Console.WriteLine($"  {p}");
        }
    }
```

**Nota importante:** `Array.Sort` en C# **NO garantiza estabilidad**. Si necesitas ordenación estable, debes: 
1. Incluir un campo de orden original en el comparador
2. Usar algoritmos de ordenación estable personalizados
3. Usar LINQ (que sí es estable)

#### 4.5.5. Rendimiento de Ordenación

**Complejidad de `Array.Sort`:**

- **Algoritmo**:  QuickSort (inestable) o IntroSort (híbrido)
- **Complejidad promedio**: O(n log n)
- **Complejidad peor caso**: O(n²) para QuickSort, O(n log n) para IntroSort
- **. NET usa IntroSort**:  QuickSort + HeapSort para evitar el peor caso

```csharp
using System.Diagnostics;

// Código ejecutable
        // Medir rendimiento de ordenación
        int[] tamaños = { 1000, 10000, 100000, 1000000 };
        
        foreach (int tamaño in tamaños)
        {
            int[] numeros = GenerarArrayAleatorio(tamaño);
            
            Stopwatch sw = Stopwatch. StartNew();
            Array.Sort(numeros);
            sw.Stop();
            
            Console. WriteLine($"Ordenar {tamaño: N0} elementos: {sw. ElapsedMilliseconds}ms");
        }

// Funciones locales
    int[] GenerarArrayAleatorio(int tamaño)
    {
        Random random = new Random();
        int[] array = new int[tamaño];
        
        for (int i = 0; i < tamaño; i++)
        {
            array[i] = random.Next(1, 1000000);
        }
        
        return array;
    }


// Salida típica:
// Ordenar 1,000 elementos: 0ms
// Ordenar 10,000 elementos: 2ms
// Ordenar 100,000 elementos: 15ms
// Ordenar 1,000,000 elementos: 180ms
```

**Consideraciones de rendimiento:**

```csharp
// Código ejecutable
        const int TAMAÑO = 100000;
        
        // Caso 1: Array ya ordenado
        int[] arrayOrdenado = Enumerable.Range(1, TAMAÑO).ToArray();
        var sw1 = Stopwatch.StartNew();
        Array.Sort(arrayOrdenado);
        sw1.Stop();
        Console.WriteLine($"Array ya ordenado: {sw1.ElapsedMilliseconds}ms");
        
        // Caso 2: Array en orden inverso
        int[] arrayInverso = Enumerable.Range(1, TAMAÑO).Reverse().ToArray();
        var sw2 = Stopwatch.StartNew();
        Array.Sort(arrayInverso);
        sw2.Stop();
        Console.WriteLine($"Array en orden inverso: {sw2.ElapsedMilliseconds}ms");
        
        // Caso 3: Array aleatorio
        Random random = new Random();
        int[] arrayAleatorio = Enumerable.Range(1, TAMAÑO)
            .OrderBy(x => random.Next())
            .ToArray();
        var sw3 = Stopwatch.StartNew();
        Array.Sort(arrayAleatorio);
        sw3.Stop();
        Console.WriteLine($"Array aleatorio: {sw3.ElapsedMilliseconds}ms");
```

---

### 4.6. Búsqueda en Arrays Ordenados

#### 4.6.1. `Array.BinarySearch`

**Requisito:  array ordenado**

La búsqueda binaria requiere que el array esté ordenado según el mismo criterio que usas para buscar. 

```csharp
// Código ejecutable
        int[] numeros = { 2, 5, 8, 12, 16, 23, 38, 45, 56, 67, 78 };
        
        // Buscar un elemento que existe
        int buscado1 = 23;
        int indice1 = Array.BinarySearch(numeros, buscado1);
        
        if (indice1 >= 0)
        {
            Console. WriteLine($"{buscado1} encontrado en índice {indice1}");
        }
        else
        {
            Console.WriteLine($"{buscado1} no encontrado");
        }
        
        // Buscar un elemento que no existe
        int buscado2 = 30;
        int indice2 = Array.BinarySearch(numeros, buscado2);
        
        if (indice2 >= 0)
        {
            Console.WriteLine($"{buscado2} encontrado en índice {indice2}");
        }
        else
        {
            // El complemento bit a bit (~) del valor retornado indica dónde debería insertarse
            int posicionInsercion = ~indice2;
            Console.WriteLine($"{buscado2} no encontrado.  Debería insertarse en índice {posicionInsercion}");
        }
```

**Retorno de valores:**

- **≥ 0**: Índice del elemento encontrado
- **< 0**: El complemento bit a bit (`~`) del valor indica la posición donde debería insertarse

```csharp
// Código ejecutable
        int[] numeros = { 1, 3, 5, 7, 9 };
        
        Console.WriteLine("Array:  [" + string.Join(", ", numeros) + "]");
        Console.WriteLine();
        
        // Buscar varios valores
        int[] valoresBuscar = { 5, 6, 0, 10 };
        
        foreach (int valor in valoresBuscar)
        {
            int resultado = Array.BinarySearch(numeros, valor);
            
            if (resultado >= 0)
            {
                Console.WriteLine($"{valor}:  Encontrado en índice {resultado}");
            }
            else
            {
                int posicion = ~resultado;
                Console. WriteLine($"{valor}: No encontrado. Insertar en índice {posicion}");
            }
        }

// Salida:
// Array: [1, 3, 5, 7, 9]
//
// 5: Encontrado en índice 2
// 6: No encontrado. Insertar en índice 3
// 0: No encontrado. Insertar en índice 0
// 10: No encontrado. Insertar en índice 5
```

#### 4.6.2. Búsqueda con Comparadores

**`Array.BinarySearch<T>(T[] array, T value, IComparer<T> comparer)`**

```csharp
// Código ejecutable
        string[] palabras = { "apple", "BANANA", "cherry", "DATE", "elderberry" };
        
        // Ordenar case-insensitive
        Array.Sort(palabras, StringComparer.OrdinalIgnoreCase);
        Console.WriteLine($"Array ordenado:  [{string.Join(", ", palabras)}]");
        
        // Buscar case-insensitive
        string buscada = "banana";
        int indice = Array.BinarySearch(palabras, buscada, StringComparer. OrdinalIgnoreCase);
        
        if (indice >= 0)
        {
            Console.WriteLine($"'{buscada}' encontrada en índice {indice}:  '{palabras[indice]}'");
        }
        else
        {
            Console.WriteLine($"'{buscada}' no encontrada");
        }
```

**Ejemplo con tipos personalizados:**

```csharp
public class Empleado :  IComparable<Empleado>
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Salario { get; set; }
    public Empleado(int id, string nombre, decimal salario)
    {
        Id = id;
        Nombre = nombre;
        Salario = salario;
    }
    // Orden natural: por Id
    public int CompareTo(Empleado other)
    {
        if (other == null) return 1;
        return this.Id.CompareTo(other.Id);
    }
    public override string ToString()
    {
        return $"[{Id}] {Nombre} - ${Salario:F0}";
    }
}
// Comparador por salario
public class ComparadorPorSalario : IComparer<Empleado>
{
    public int Compare(Empleado x, Empleado y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        return x.Salario.CompareTo(y.Salario);
    }
}

// Código ejecutable
        Empleado[] empleados = new Empleado[]
        {
            new Empleado(5, "Ana", 45000),
            new Empleado(2, "Juan", 50000),
            new Empleado(8, "María", 40000),
            new Empleado(1, "Pedro", 55000),
            new Empleado(3, "Laura", 48000)
        };
        
        Console.WriteLine("=== Array original ===");
        foreach (var emp in empleados)
        {
            Console.WriteLine($"  {emp}");
        }
        
        // Ordenar por Id (orden natural)
        Array.Sort(empleados);
        Console.WriteLine("\n=== Ordenado por Id ===");
        foreach (var emp in empleados)
        {
            Console. WriteLine($"  {emp}");
        }
        
        // Buscar por Id
        Empleado buscadoPorId = new Empleado(3, null, 0);
        int indicePorId = Array.BinarySearch(empleados, buscadoPorId);
        
        if (indicePorId >= 0)
        {
            Console.WriteLine($"\nEmpleado con Id 3: {empleados[indicePorId]}");
        }
        
        // Ahora ordenar por salario
        var comparadorSalario = new ComparadorPorSalario();
        Array.Sort(empleados, comparadorSalario);
        Console.WriteLine("\n=== Ordenado por salario ===");
        foreach (var emp in empleados)
        {
            Console.WriteLine($"  {emp}");
        }
        
        // Buscar por salario
        Empleado buscadoPorSalario = new Empleado(0, null, 48000);
        int indicePorSalario = Array.BinarySearch(empleados, buscadoPorSalario, comparadorSalario);
        
        if (indicePorSalario >= 0)
        {
            Console.WriteLine($"\nEmpleado con salario $48,000: {empleados[indicePorSalario]}");
        }
```

#### 4.6.3. Rendimiento de Búsqueda

**Búsqueda binaria vs. búsqueda lineal:**

```csharp
using System.Diagnostics;

// Código ejecutable
        int[] tamaños = { 1000, 10000, 100000, 1000000 };
        
        foreach (int tamaño in tamaños)
        {
            int[] numeros = Enumerable.Range(1, tamaño).ToArray();
            int buscado = numeros[tamaño - 1]; // Último elemento
            
            // Búsqueda lineal
            Stopwatch sw1 = Stopwatch.StartNew();
            int indiceLineal = Array.IndexOf(numeros, buscado);
            sw1.Stop();
            
            // Búsqueda binaria
            Stopwatch sw2 = Stopwatch.StartNew();
            int indiceBinario = Array.BinarySearch(numeros, buscado);
            sw2.Stop();
            
            Console.WriteLine($"\n=== Array de {tamaño:N0} elementos ===");
            Console. WriteLine($"Búsqueda lineal: {sw1.Elapsed.TotalMilliseconds:F4}ms");
            Console.WriteLine($"Búsqueda binaria: {sw2.Elapsed.TotalMilliseconds:F4}ms");
            Console.WriteLine($"Mejora: {sw1.Elapsed.TotalMilliseconds / sw2.Elapsed.TotalMilliseconds:F2}x");
        }

// Salida típica:
// === Array de 1,000 elementos ===
// Búsqueda lineal:  0.0080ms
// Búsqueda binaria: 0.0005ms
// Mejora: 16.00x
//
// === Array de 10,000 elementos ===
// Búsqueda lineal: 0.0800ms
// Búsqueda binaria: 0.0006ms
// Mejora: 133.33x
//
// === Array de 100,000 elementos ===
// Búsqueda lineal: 0.8000ms
// Búsqueda binaria: 0.0007ms
// Mejora: 1142.86x
//
// === Array de 1,000,000 elementos ===
// Búsqueda lineal: 8.0000ms
// Búsqueda binaria: 0.0008ms
// Mejora: 10000.00x
```

**Complejidad:**

| Operación                               | Complejidad |
| --------------------------------------- | ----------- |
| Búsqueda lineal (`Array.IndexOf`)       | O(n)        |
| Búsqueda binaria (`Array.BinarySearch`) | O(log n)    |
| Ordenación (`Array.Sort`)               | O(n log n)  |

**Cuándo usar cada una:**

```csharp
// Código ejecutable
        // Caso 1: Array pequeño, no ordenado
        // → Usar búsqueda lineal (IndexOf)
        int[] pequeño = { 5, 2, 8, 1, 9 };
        int indice1 = Array.IndexOf(pequeño, 8);
        
        // Caso 2: Array grande, ordenado, múltiples búsquedas
        // → Usar búsqueda binaria (BinarySearch)
        int[] grande = Enumerable.Range(1, 100000).ToArray();
        int indice2 = Array.BinarySearch(grande, 50000);
        
        // Caso 3: Array no ordenado, una sola búsqueda
        // → Usar búsqueda lineal (más rápido que ordenar + búsqueda binaria)
        int[] desordenado = { 9, 2, 5, 1, 7, 3, 8, 4, 6 };
        int indice3 = Array.IndexOf(desordenado, 7);
        
        // Caso 4: Array no ordenado, muchas búsquedas
        // → Ordenar una vez, luego usar búsqueda binaria
        int[] muchasBusquedas = { 9, 2, 5, 1, 7, 3, 8, 4, 6 };
        Array.Sort(muchasBusquedas);
        int indice4a = Array.BinarySearch(muchasBusquedas, 7);
        int indice4b = Array.BinarySearch(muchasBusquedas, 3);
        int indice4c = Array.BinarySearch(muchasBusquedas, 9);
```

---

### 4.7. Resumen y Mejores Prácticas

#### 4.7.1. Cuándo Usar Cada Interfaz

| Interfaz             | Cuándo Usar                             | Ejemplo                                 |
| -------------------- | --------------------------------------- | --------------------------------------- |
| **`IComparable<T>`** | Definir el **orden natural** de tu tipo | `Persona` ordenada por apellido         |
| **`IComparer<T>`**   | Definir **órdenes alternativos**        | Ordenar `Persona` por edad o por nombre |
| **`IEquatable<T>`**  | Comparación de **igualdad eficiente**   | Comparar `Punto` por coordenadas        |

#### 4.7.2. Decisiones de Diseño

**¿Implementar `IComparable<T>` o solo usar `IComparer<T>`?**

```csharp
// Opción 1: Implementar IComparable<T> si hay un orden natural obvio
public class Fecha : IComparable<Fecha>
{
    public int Año { get; set; }
    public int Mes { get; set; }
    public int Dia { get; set; }
    
    // Orden natural: cronológico
    public int CompareTo(Fecha other)
    {
        // ... 
    }
}

// Opción 2: NO implementar IComparable<T> si no hay orden natural obvio
public class Color
{
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }
    
    // ¿Orden por qué? ¿Brillo? ¿Matiz? ¿RGB?
    // No hay orden natural obvio → NO implementar IComparable<T>
    // En su lugar, proporcionar comparadores personalizados
}

public class ComparadorColorPorBrillo : IComparer<Color>
{
    public int Compare(Color x, Color y)
    {
        // Ordenar por brillo
    }
}

public class ComparadorColorPorMatiz : IComparer<Color>
{
    public int Compare(Color x, Color y)
    {
        // Ordenar por matiz
    }
}

```

**Consistencia entre `CompareTo`, `Equals` y operadores:**

```csharp
public class Version : IComparable<Version>, IEquatable<Version>
{
    public int Mayor { get; set; }
    public int Menor { get; set; }
    public int Parche { get; set; }
    public Version(int mayor, int menor, int parche)
    {
        Mayor = mayor;
        Menor = menor;
        Parche = parche;
    }
    // CompareTo
    public int CompareTo(Version other)
    {
        if (other == null) return 1;
        int comparacionMayor = this.Mayor.CompareTo(other.Mayor);
        if (comparacionMayor != 0) return comparacionMayor;
        int comparacionMenor = this.Menor. CompareTo(other.Menor);
        if (comparacionMenor != 0) return comparacionMenor;
        return this.Parche. CompareTo(other.Parche);
    }
    // Equals (consistente con CompareTo)
    public bool Equals(Version other)
    {
        if (other == null) return false;
        return this.CompareTo(other) == 0;
    }
    public override bool Equals(object obj)
    {
        return Equals(obj as Version);
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Mayor, Menor, Parche);
    }
    // Operadores (consistentes con CompareTo)
    public static bool operator ==(Version v1, Version v2)
    {
        if (ReferenceEquals(v1, v2)) return true;
        if (ReferenceEquals(v1, null) || ReferenceEquals(v2, null)) return false;
        return v1.Equals(v2);
    }
    public static bool operator !=(Version v1, Version v2)
    {
        return !(v1 == v2);
    }
    public static bool operator <(Version v1, Version v2)
    {
        if (v1 == null) throw new ArgumentNullException(nameof(v1));
        return v1.CompareTo(v2) < 0;
    }
    public static bool operator >(Version v1, Version v2)
    {
        if (v1 == null) throw new ArgumentNullException(nameof(v1));
        return v1.CompareTo(v2) > 0;
    }
    public static bool operator <=(Version v1, Version v2)
    {
        return v1 < v2 || v1 == v2;
    }
    public static bool operator >=(Version v1, Version v2)
    {
        return v1 > v2 || v1 == v2;
    }
    public override string ToString()
    {
        return $"{Mayor}.{Menor}.{Parche}";
    }
}

// Código ejecutable
        Version v1 = new Version(1, 2, 3);
        Version v2 = new Version(1, 2, 3);
        Version v3 = new Version(2, 0, 0);
        
        Console.WriteLine($"v1 == v2: {v1 == v2}");       // True
        Console.WriteLine($"v1 < v3: {v1 < v3}");         // True
        Console.WriteLine($"v3 > v1: {v3 > v1}");         // True
        Console.WriteLine($"v1.Equals(v2): {v1.Equals(v2)}"); // True
        Console.WriteLine($"v1.CompareTo(v3): {v1.CompareTo(v3)}"); // Negativo
        
        // Ordenar versiones
        Version[] versiones = 
        {
            new Version(2, 1, 0),
            new Version(1, 0, 5),
            new Version(2, 0, 3),
            new Version(1, 5, 2)
        };
        
        Array.Sort(versiones);
        Console.WriteLine("\nVersiones ordenadas:");
        foreach (var v in versiones)
        {
            Console.WriteLine($"  {v}");
        }
```

#### 4.7.3. Errores Comunes

**1. Olvidar sobrescribir `GetHashCode` al implementar `Equals`:**

```csharp
// ✗ MAL
public class Punto : IEquatable<Punto>
{
    public int X { get; set; }
    public int Y { get; set; }
    
    public bool Equals(Punto other)
    {
        if (other == null) return false;
        return X == other.X && Y == other.Y;
    }
    
    public override bool Equals(object obj)
    {
        return Equals(obj as Punto);
    }
    
    // ¡FALTA GetHashCode!
}

// ✓ BIEN
public class Punto : IEquatable<Punto>
{
    public int X { get; set; }
    public int Y { get; set; }
    
    public bool Equals(Punto other)
    {
        if (other == null) return false;
        return X == other.X && Y == other.Y;
    }
    
    public override bool Equals(object obj)
    {
        return Equals(obj as Punto);
    }
    
    // ✓ GetHashCode implementado
    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}

```

**2. `CompareTo` inconsistente:**

```csharp
// ✗ MAL:  viola antisimetría
public class Numero : IComparable<Numero>
{
    public int Valor { get; set; }
    
    public int CompareTo(Numero other)
    {
        if (other == null) return 1;
        
        // SIEMPRE retorna 1 → viola antisimetría
        return 1;
    }
}

// ✓ BIEN
public class Numero : IComparable<Numero>
{
    public int Valor { get; set; }
    
    public int CompareTo(Numero other)
    {
        if (other == null) return 1;
        return this.Valor.CompareTo(other.Valor);
    }
}

```

**3. Usar `BinarySearch` en array no ordenado:**

```csharp
// ✗ MAL
int[] numeros = { 5, 2, 8, 1, 9 }; // NO ordenado
int indice = Array.BinarySearch(numeros, 8); // Resultado incorrecto

// ✓ BIEN
int[] numeros = { 5, 2, 8, 1, 9 };
Array.Sort(numeros); // Ordenar primero
int indice = Array. BinarySearch(numeros, 8); // Ahora es correcto

```

**4. Comparadores que lanzan excepciones:**

```csharp
// ✗ MAL: lanza excepción
public class ComparadorProblematico : IComparer<int>
{
    public int Compare(int x, int y)
    {
        if (x == 0 || y == 0)
        {
            throw new ArgumentException("No se permiten ceros");
        }
        return x.CompareTo(y);
    }
}

// ✓ BIEN:  maneja casos especiales sin excepciones
public class ComparadorRobusto : IComparer<int>
{
    public int Compare(int x, int y)
    {
        // Manejar ceros de forma especial (ej:  al final)
        if (x == 0 && y == 0) return 0;
        if (x == 0) return 1;
        if (y == 0) return -1;
        
        return x.CompareTo(y);
    }
}

```

---

## 5. Colecciones en C#

### 5.1. Introducción a las Colecciones

#### 5.1.1. ¿Qué son las colecciones?

Las **colecciones** son estructuras de datos que permiten almacenar, organizar y manipular grupos de objetos relacionados. A diferencia de los arrays, las colecciones ofrecen mayor flexibilidad y funcionalidad. 

**Arrays vs.  Colecciones:**

| Aspecto           | Arrays    | Colecciones                         |
| ----------------- | --------- | ----------------------------------- |
| **Tamaño**        | Fijo      | Dinámico (en la mayoría)            |
| **Tipo**          | Homogéneo | Homogéneo (genéricas) o heterogéneo |
| **Funcionalidad** | Básica    | Rica (búsqueda, ordenación, etc.)   |
| **Sintaxis**      | `[]`      | Métodos y propiedades               |
| **Rendimiento**   | Excelente | Muy bueno (depende del tipo)        |

```csharp
// Array:  tamaño fijo
int[] arrayNumeros = new int[5];
arrayNumeros[0] = 10;
// arrayNumeros[5] = 20; // Error:  fuera de rango

// Colección:   tamaño dinámico
List<int> listaNumeros = new List<int>();
listaNumeros.Add(10);
listaNumeros.Add(20);
listaNumeros.Add(30);
// Puedes seguir agregando elementos sin límite (hasta la memoria)

```

#### 5.1.2. Namespaces Importantes

**`System.Collections. Generic`**

Contiene las colecciones genéricas (las más usadas y recomendadas):

```csharp
using System.Collections.Generic;

// Colecciones genéricas
List<int> lista = new List<int>();
Dictionary<string, int> diccionario = new Dictionary<string, int>();
HashSet<string> conjunto = new HashSet<string>();
Queue<int> cola = new Queue<int>();
Stack<int> pila = new Stack<int>();

```

**`System.Collections`**

Contiene las colecciones **no genéricas** (legacy, evitar en código nuevo):

```csharp
using System.Collections;

// Colecciones no genéricas (antiguas, evitar)
ArrayList arrayList = new ArrayList();
Hashtable hashtable = new Hashtable();
Queue queue = new Queue();
Stack stack = new Stack();

```

**`System.Collections.Specialized`**

Contiene colecciones especializadas para casos de uso específicos:

```csharp
using System.Collections. Specialized;

// Colecciones especializadas
NameValueCollection config = new NameValueCollection();
StringCollection strings = new StringCollection();
OrderedDictionary ordenado = new OrderedDictionary();

```

#### 5.1.3. Jerarquía de Interfaces

**Interfaces principales:**

```
──────────────────────────────────────────────────────────────────────────────
          📦 COLECCIONES EN C# — System.Collections.
──────────────────────────────────────────────────────────────────────────────

                          ┌─────────────────────────────┐
                          │ IEnumerable / IEnumerable<T>│
                          └─────────────┬───────────────┘
                                        │
                          ┌─────────────▼────────────────┐
                          │ ICollection / ICollection<T> │
                          └───────┬──────────────┬───────┘
                                  │              │
                     ┌────────────▼────┐   ┌─────▼──────────────────┐
                     │ IList / IList<T>│   │ ISet<T>                │
                     └──────┬──────────┘   └──────────┬─────────────┘
                            │                         │
             ┌──────────────▼──────────────┐   ┌──────▼─────────────────────┐
             │  Implementaciones de listas │   │ Implementaciones de sets   │
             └─────────────────────────────┘   └────────────────────────────┘
                     • List<T>                     • HashSet<T>
                     • ArrayList                   • SortedSet<T>
                     • LinkedList<T>               • IReadOnlySet<T>
                     • Array (no interfaz directa) • ImmutableHashSet<T> (System.Collections.Immutable)
                                                   • ImmutableSortedSet<T>

                         ┌──────────────────────────────────────────┐
                         │IDictionary / IDictionary<TKey, TValue>   │
                         └──────────────────────┬───────────────────┘
                                                │
                                     ┌──────────▼────────────┐
                                     │ Implementaciones map  │
                                     └───────────────────────┘
                                          • Dictionary<TKey, TValue>
                                          • SortedDictionary<,>
                                          • SortedList<,>
                                          • Hashtable (no genérico)

                         ┌──────────────────────────────────────────┐
                         │   Otras colecciones lineales especiales  │
                         └──────────────────────┬───────────────────┘
                                                │
                                   • Queue / Queue<T>
                                   • Stack / Stack<T>
                                   • ConcurrentQueue<T>
                                   • ConcurrentStack<T>
                                   • BlockingCollection<T>

```

**`IEnumerable<T>`** - Iteración básica


```csharp
public interface IEnumerable<T>
{
    IEnumerator<T> GetEnumerator();
}

// Permite usar foreach
IEnumerable<int> numeros = new List<int> { 1, 2, 3 };
foreach (int n in numeros)
{
    Console.WriteLine(n);
}

```

**IEnumerator y yield return**. Para recorrer información de forma avanzada C# utiliza el patrón de diseño Iterator. La interfaz `IEnumerable` nos permite usar el bucle foreach, pero internamente esto funciona gracias a un objeto `IEnumerator`. Una herramienta potente para manipular datos es el uso de yield return, que permite generar una secuencia de elementos "sobre la marcha" (evaluación perezosa). Esto permite procesar grandes volúmenes de datos sin necesidad de cargarlos todos simultáneamente en una lista en memoria.

```csharp
using System;
using System.Collections.Generic;
// Clase para demostrar el mecanismo de iteración avanzada
public class ProcesadorNumeros
{
    // Datos internos (una colección simple)
    private int[] _datos = [10, 21, 32, 43, 54, 65, 76, 87, 98];
    // Método que utiliza yield return para crear un iterador "on the fly"
    // Esto permite procesar datos sin cargarlos todos en una nueva lista (Evaluación Perezosa)
    public IEnumerable<int> ObtenerParesMayoresQue(int umbral)
    {
        Console.WriteLine($"--- Iniciando iteración con umbral: {umbral} ---");
        foreach (int numero in _datos)
        {
            // Solo "devolvemos" el dato si cumple la condición
            if (numero > umbral && numero % 2 == 0)
            {
                // yield return pausa la ejecución y devuelve el valor al foreach externo
                yield return numero; 
            }
        }
        Console.WriteLine("--- Fin de la iteración ---");
    }
}
// Ejemplo de uso en el programa principal
```


**`ICollection<T>`** - Operaciones básicas de colección

```csharp
public interface ICollection<T> : IEnumerable<T>
{
    int Count { get; }
    bool IsReadOnly { get; }
    void Add(T item);
    void Clear();
    bool Contains(T item);
    void CopyTo(T[] array, int arrayIndex);
    bool Remove(T item);
}

```

**`IList<T>`** - Lista con acceso por índice

```csharp
public interface IList<T> : ICollection<T>
{
    T this[int index] { get; set; }
    int IndexOf(T item);
    void Insert(int index, T item);
    void RemoveAt(int index);
}

```

**`IDictionary<TKey, TValue>`** - Diccionario clave-valor

```csharp
public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>
{
    TValue this[TKey key] { get; set; }
    ICollection<TKey> Keys { get; }
    ICollection<TValue> Values { get; }
    void Add(TKey key, TValue value);
    bool ContainsKey(TKey key);
    bool Remove(TKey key);
    bool TryGetValue(TKey key, out TValue value);
}

```


**El Contrato de Igualdad en Colecciones Basadas en Hash** Al almacenar información en colecciones como `HashSet<T>` o `Dictionary<K, V>`, la colección necesita una forma de identificar si un objeto es único. Si trabajamos con tipos personalizados, debemos asegurar que el método `GetHashCode()` genere una "huella digital" coherente y que `Equals()` compare correctamente los valores. Sin esto, la colección no podrá recuperar o filtrar la información de forma fiable, tratando objetos con los mismos datos como si fueran diferentes.

---

#### 5.1.4. Colecciones Genéricas vs. No Genéricas

**Ventajas de las colecciones genéricas:**

```csharp
// Código ejecutable
        // === COLECCIÓN NO GENÉRICA (antigua, evitar) ===
        ArrayList listaSinGenericos = new ArrayList();
        listaSinGenericos.Add(1);           // Boxing:  int → object
        listaSinGenericos.Add("texto");     // Permite tipos mixtos (peligroso)
        listaSinGenericos.Add(3.14);
        
        int numero = (int)listaSinGenericos[0];  // Unboxing + cast necesario
        // string texto = (string)listaSinGenericos[0]; // ¡Error en tiempo de ejecución!
        
        // === COLECCIÓN GENÉRICA (moderna, recomendada) ===
        List<int> listaConGenericos = new List<int>();
        listaConGenericos.Add(1);          // Sin boxing
        listaConGenericos.Add(2);
        // listaConGenericos.Add("texto");  // Error en tiempo de compilación (type-safe)
        
        int numero2 = listaConGenericos[0]; // Sin unboxing ni cast
        
        // Ventajas: 
        // 1. Type-safety (errores en compilación, no en ejecución)
        // 2. Sin boxing/unboxing (mejor rendimiento)
        // 3. Código más limpio (sin casts)
```

**Comparación de rendimiento:**

```csharp
using System. Diagnostics;
using System.Collections;
using System.Collections.Generic;

// Código ejecutable
        const int CANTIDAD = 1000000;
        
        // ArrayList (no genérico)
        var sw1 = Stopwatch.StartNew();
        ArrayList arrayList = new ArrayList();
        for (int i = 0; i < CANTIDAD; i++)
        {
            arrayList.Add(i); // Boxing
        }
        int suma1 = 0;
        for (int i = 0; i < CANTIDAD; i++)
        {
            suma1 += (int)arrayList[i]; // Unboxing + cast
        }
        sw1.Stop();
        
        // List<T> (genérico)
        var sw2 = Stopwatch.StartNew();
        List<int> lista = new List<int>();
        for (int i = 0; i < CANTIDAD; i++)
        {
            lista.Add(i); // Sin boxing
        }
        int suma2 = 0;
        for (int i = 0; i < CANTIDAD; i++)
        {
            suma2 += lista[i]; // Sin unboxing ni cast
        }
        sw2.Stop();
        
        Console.WriteLine($"ArrayList: {sw1.ElapsedMilliseconds}ms");
        Console.WriteLine($"List<T>: {sw2.ElapsedMilliseconds}ms");
        Console.WriteLine($"Mejora: {sw1.ElapsedMilliseconds / (double)sw2.ElapsedMilliseconds:F2}x");

// Salida típica:
// ArrayList:  180ms
// List<T>:  45ms
// Mejora: 4. 00x
```

**Regla general:**

✓ **USAR**:  Colecciones genéricas (`List<T>`, `Dictionary<K,V>`, etc.)
✗ **EVITAR**: Colecciones no genéricas (`ArrayList`, `Hashtable`, etc.)


---

#### 5.1.5. Resumen de Colecciones en C#


```
──────────────────────────────────────────────────────────────────────────────
          📦 COLECCIONES EN C# — System.Collections.
──────────────────────────────────────────────────────────────────────────────

                         IEnumerable / IEnumerable<T>
                                     ▲
                                     │
                         ICollection / ICollection<T>
                                     ▲
      ┌──────────────────────────────┼───────────────────────────────────────┐
      │                              │                                       │
   IList/IList<T>                ISet<T>                     IDictionary / IDictionary<K,V>
      │                              │                                       │
      │                              │                                       │
┌──────────────┐           ┌────────────────┐                    ┌───────────────────────┐
│   LISTAS     │           │    SETS        │                    │     DICCIONARIOS      │
└──────────────┘           └────────────────┘                    └───────────────────────┘
• List<T>                 • HashSet<T>                         • Dictionary<K,V>
• ArrayList (NG)          • SortedSet<T>                       • SortedDictionary<K,V>
• LinkedList<T>           • IReadOnlySet<T>                    • SortedList<K,V>
• ReadOnlyCollection<T>   • ImmutableHashSet<T> (Imm)          • ConcurrentDictionary<K,V>
• ImmutableList<T> (Imm)  • ImmutableSortedSet<T> (Imm)        • Hashtable (NG)

──────────────────────────────────────────────────────────────────────────────
                         📘 ESTRUCTURAS LINEALES ESPECIALES
──────────────────────────────────────────────────────────────────────────────
FIFO: • Queue<T> • ConcurrentQueue<T> • ImmutableQueue<T> (Imm)
LIFO: • Stack<T> • ConcurrentStack<T> • ImmutableStack<T> (Imm)
Buffers: • BlockingCollection<T> • ConcurrentBag<T>

──────────────────────────────────────────────────────────────────────────────
                         📗 COLECCIONES NO GENÉRICAS (Legacy)
──────────────────────────────────────────────────────────────────────────────
• ArrayList           • Hashtable
• SortedList          • Queue
• Stack               • BitArray
• HybridDictionary    • ListDictionary
• NameValueCollection • StringCollection

──────────────────────────────────────────────────────────────────────────────
                   📙 COLECCIONES INMUTABLES (System.Collections.Immutable)
──────────────────────────────────────────────────────────────────────────────
• ImmutableList<T>          • ImmutableHashSet<T>
• ImmutableArray<T>         • ImmutableSortedSet<T>
• ImmutableQueue<T>         • ImmutableDictionary<K,V>
• ImmutableStack<T>

──────────────────────────────────────────────────────────────────────────────
                   📒 COLECCIONES CONCURRENTES (Thread-Safe)
──────────────────────────────────────────────────────────────────────────────
• ConcurrentBag<T>  
• ConcurrentDictionary<K,V>  
• ConcurrentQueue<T>  
• ConcurrentStack<T>  
• BlockingCollection<T>

──────────────────────────────────────────────────────────────────────────────
```
---

### 5.2. List<T>

#### 5.2.1. Características

**List<T>** es la colección más usada en C#.  Es una lista de tamaño dinámico con acceso por índice.

**Características principales:**
- ✓ Tamaño dinámico (crece automáticamente)
- ✓ Acceso por índice O(1)
- ✓ Inserción/eliminación al final O(1) amortizado
- ✓ Inserción/eliminación en medio O(n)
- ✓ Búsqueda lineal O(n)
- ✓ Mantiene el orden de inserción

#### 5.2.2. Creación e Inicialización

**Formas de crear una `List<T>`:**

```csharp
// 1. Constructor por defecto (lista vacía)
List<int> lista1 = new List<int>();

// 2. Con capacidad inicial
List<int> lista2 = new List<int>(100); // Capacidad para 100 elementos

// 3. Desde otra colección
int[] array = { 1, 2, 3, 4, 5 };
List<int> lista3 = new List<int>(array);

// 4. Inicialización con colección
List<string> lista4 = new List<string> { "uno", "dos", "tres" };

// 5. Sintaxis simplificada (C# 9+)
List<int> lista5 = new() { 1, 2, 3, 4, 5 };

// 6. Crear desde otra lista
List<int> lista6 = new List<int>(lista1);

```

**Ejemplo completo:**

```csharp
// Código ejecutable
        // Lista vacía
        List<string> nombres = new List<string>();
        Console.WriteLine($"Capacidad inicial: {nombres.Capacity}");
        Console.WriteLine($"Cantidad:  {nombres.Count}");
        
        // Lista con capacidad inicial
        List<int> numeros = new List<int>(50);
        Console.WriteLine($"\nCapacidad con 50: {numeros.Capacity}");
        Console.WriteLine($"Cantidad: {numeros.Count}");
        
        // Lista inicializada
        List<double> precios = new List<double> { 19.99, 29.99, 39.99, 49.99 };
        Console.WriteLine($"\nPrecios inicializados:");
        Console.WriteLine($"Capacidad: {precios.Capacity}");
        Console.WriteLine($"Cantidad: {precios. Count}");
        
        foreach (double precio in precios)
        {
            Console.WriteLine($"  ${precio}");
        }
```

#### 5.2.3. Operaciones Básicas

**Agregar elementos:**

```csharp
// Código ejecutable
        List<string> frutas = new List<string>();
        
        // Add:  agregar al final
        frutas. Add("Manzana");
        frutas.Add("Banana");
        frutas.Add("Cereza");
        
        Console.WriteLine("Después de Add:");
        MostrarLista(frutas);
        
        // AddRange: agregar múltiples elementos
        string[] masFrutas = { "Durazno", "Fresa", "Kiwi" };
        frutas.AddRange(masFrutas);
        
        Console.WriteLine("\nDespués de AddRange:");
        MostrarLista(frutas);
        
        // Insert:  insertar en posición específica
        frutas.Insert(0, "Arándano"); // Al inicio
        frutas.Insert(3, "Coco");     // En posición 3
        
        Console.WriteLine("\nDespués de Insert:");
        MostrarLista(frutas);
        
        // InsertRange: insertar múltiples en posición
        List<string> citricos = new List<string> { "Naranja", "Limón" };
        frutas.InsertRange(2, citricos);
        
        Console.WriteLine("\nDespués de InsertRange:");
        MostrarLista(frutas);

// Funciones locales
    void MostrarLista(List<string> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine($"  [{i}] {lista[i]}");
        }
    }
```

**Acceder a elementos:**

```csharp
// Código ejecutable
        List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };
        
        // Acceso por índice
        int primero = numeros[0];
        int ultimo = numeros[numeros.Count - 1];
        
        Console.WriteLine($"Primer elemento: {primero}");
        Console.WriteLine($"Último elemento: {ultimo}");
        
        // Modificar por índice
        numeros[2] = 35;
        Console.WriteLine($"Elemento en índice 2 modificado: {numeros[2]}");
        
        // Recorrer con for
        Console.WriteLine("\nRecorrido con for:");
        for (int i = 0; i < numeros.Count; i++)
        {
            Console.WriteLine($"  [{i}] = {numeros[i]}");
        }
        
        // Recorrer con foreach
        Console.WriteLine("\nRecorrido con foreach:");
        foreach (int numero in numeros)
        {
            Console.WriteLine($"  {numero}");
        }
```

**Eliminar elementos:**

```csharp
// Código ejecutable
        List<string> colores = new List<string> 
        { 
            "Rojo", "Verde", "Azul", "Amarillo", "Verde", "Naranja" 
        };
        
        Console.WriteLine("Lista original:");
        MostrarLista(colores);
        
        // Remove: elimina la primera ocurrencia
        bool eliminado = colores.Remove("Verde");
        Console.WriteLine($"\nRemove('Verde'): {eliminado}");
        MostrarLista(colores);
        
        // RemoveAt: elimina en índice específico
        colores. RemoveAt(0); // Elimina "Rojo"
        Console.WriteLine("\nDespués de RemoveAt(0):");
        MostrarLista(colores);
        
        // RemoveAll: elimina todos los que cumplan condición
        int eliminados = colores.RemoveAll(c => c.Length > 5);
        Console.WriteLine($"\nRemoveAll (longitud > 5): {eliminados} eliminados");
        MostrarLista(colores);
        
        // RemoveRange: elimina rango
        colores.Add("Blanco");
        colores.Add("Negro");
        colores.Add("Gris");
        Console.WriteLine("\nAntes de RemoveRange:");
        MostrarLista(colores);
        
        colores.RemoveRange(1, 2); // Elimina 2 elementos desde índice 1
        Console. WriteLine("\nDespués de RemoveRange(1, 2):");
        MostrarLista(colores);
        
        // Clear: elimina todos
        colores.Clear();
        Console.WriteLine($"\nDespués de Clear: Count = {colores.Count}");

// Funciones locales
    void MostrarLista(List<string> lista)
    {
        foreach (var item in lista)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
```

#### 5.2.4. Búsqueda y Verificación

**Métodos de búsqueda:**

```csharp
// Código ejecutable
        List<int> numeros = new List<int> { 10, 20, 30, 40, 50, 30, 60 };
        
        // Contains: verifica si existe
        bool contiene30 = numeros.Contains(30);
        bool contiene100 = numeros.Contains(100);
        Console.WriteLine($"¿Contiene 30? {contiene30}");
        Console.WriteLine($"¿Contiene 100? {contiene100}");
        
        // IndexOf:  índice de primera ocurrencia
        int indice1 = numeros.IndexOf(30);
        Console.WriteLine($"\nPrimera ocurrencia de 30: índice {indice1}");
        
        // LastIndexOf:  índice de última ocurrencia
        int indice2 = numeros.LastIndexOf(30);
        Console.WriteLine($"Última ocurrencia de 30: índice {indice2}");
        
        // IndexOf con inicio
        int indice3 = numeros.IndexOf(30, 3); // Buscar desde índice 3
        Console.WriteLine($"Ocurrencia de 30 desde índice 3: {indice3}");
        
        // Find: encuentra primer elemento que cumple condición
        int primerMayorQue25 = numeros.Find(n => n > 25);
        Console.WriteLine($"\nPrimer número > 25: {primerMayorQue25}");
        
        // FindLast: encuentra último elemento que cumple condición
        int ultimoMayorQue25 = numeros.FindLast(n => n > 25);
        Console.WriteLine($"Último número > 25: {ultimoMayorQue25}");
        
        // FindAll: encuentra todos los que cumplen condición
        List<int> mayoresQue25 = numeros.FindAll(n => n > 25);
        Console.WriteLine($"\nTodos los > 25: [{string.Join(", ", mayoresQue25)}]");
        
        // FindIndex: índice del primer elemento que cumple
        int indicePrimerPar = numeros.FindIndex(n => n % 2 == 0);
        Console.WriteLine($"\nÍndice del primer par: {indicePrimerPar}");
        
        // Exists: verifica si existe alguno que cumple
        bool hayMayoresQue100 = numeros.Exists(n => n > 100);
        Console.WriteLine($"¿Hay números > 100? {hayMayoresQue100}");
        
        // TrueForAll: verifica si todos cumplen
        bool todosPositivos = numeros.TrueForAll(n => n > 0);
        Console.WriteLine($"¿Todos son positivos? {todosPositivos}");
```

**Ejemplo con objetos personalizados:**

```csharp
public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string Categoria { get; set; }
    public Producto(int id, string nombre, decimal precio, string categoria)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
        Categoria = categoria;
    }
    public override string ToString()
    {
        return $"{Nombre} (${Precio}) - {Categoria}";
    }
}

// Código ejecutable
        List<Producto> productos = new List<Producto>
        {
            new Producto(1, "Laptop", 1200, "Electrónica"),
            new Producto(2, "Mouse", 25, "Electrónica"),
            new Producto(3, "Libro C#", 45, "Libros"),
            new Producto(4, "Teclado", 75, "Electrónica"),
            new Producto(5, "Monitor", 300, "Electrónica")
        };
        
        // Buscar producto por Id
        Producto producto = productos. Find(p => p.Id == 3);
        Console.WriteLine($"Producto con Id 3: {producto}");
        
        // Buscar productos de una categoría
        List<Producto> electronica = productos.FindAll(p => p.Categoria == "Electrónica");
        Console.WriteLine($"\nProductos de Electrónica:");
        foreach (var p in electronica)
        {
            Console.WriteLine($"  {p}");
        }
        
        // Verificar si hay productos caros
        bool hayCaros = productos. Exists(p => p.Precio > 500);
        Console.WriteLine($"\n¿Hay productos > $500? {hayCaros}");
        
        // Verificar si todos están en stock (ejemplo)
        bool todosDisponibles = productos.TrueForAll(p => p.Id > 0);
        Console.WriteLine($"¿Todos tienen Id válido? {todosDisponibles}");
        
        // Encontrar índice del producto más caro
        int indiceMax = 0;
        decimal precioMax = productos[0].Precio;
        for (int i = 1; i < productos.Count; i++)
        {
            if (productos[i].Precio > precioMax)
            {
                precioMax = productos[i]. Precio;
                indiceMax = i;
            }
        }
        Console.WriteLine($"\nProducto más caro: {productos[indiceMax]}");
```

#### 5.2.5. Ordenación

**Métodos de ordenación:**

```csharp
// Código ejecutable
        List<int> numeros = new List<int> { 5, 2, 8, 1, 9, 3, 7 };
        
        Console.WriteLine($"Original: [{string.Join(", ", numeros)}]");
        
        // Sort: ordenar en el lugar (modifica la lista)
        numeros.Sort();
        Console.WriteLine($"Después de Sort(): [{string.Join(", ", numeros)}]");
        
        // Reverse: invertir orden
        numeros.Reverse();
        Console.WriteLine($"Después de Reverse(): [{string.Join(", ", numeros)}]");
        
        // Sort con Comparison<T>
        numeros. Sort((a, b) => a.CompareTo(b)); // Ascendente
        Console.WriteLine($"Sort ascendente: [{string.Join(", ", numeros)}]");
        
        numeros.Sort((a, b) => b.CompareTo(a)); // Descendente
        Console.WriteLine($"Sort descendente: [{string.Join(", ", numeros)}]");
```

**Ordenación de objetos personalizados:**

```csharp
public class Estudiante
{
    public string Nombre { get; set; }
    public double Promedio { get; set; }
    public int Edad { get; set; }
    public Estudiante(string nombre, double promedio, int edad)
    {
        Nombre = nombre;
        Promedio = promedio;
        Edad = edad;
    }
    public override string ToString()
    {
        return $"{Nombre} - Promedio: {Promedio: F2} - {Edad} años";
    }
}

// Código ejecutable
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante("Ana", 8.5, 20),
            new Estudiante("Juan", 9.2, 19),
            new Estudiante("María", 7.8, 21),
            new Estudiante("Pedro", 9.5, 20)
        };
        
        Console.WriteLine("=== Original ===");
        MostrarEstudiantes(estudiantes);
        
        // Ordenar por nombre
        estudiantes.Sort((e1, e2) => e1.Nombre.CompareTo(e2.Nombre));
        Console.WriteLine("\n=== Ordenado por nombre ===");
        MostrarEstudiantes(estudiantes);
        
        // Ordenar por promedio (descendente)
        estudiantes. Sort((e1, e2) => e2.Promedio. CompareTo(e1.Promedio));
        Console.WriteLine("\n=== Ordenado por promedio (desc) ===");
        MostrarEstudiantes(estudiantes);
        
        // Ordenar por edad, luego por promedio
        estudiantes.Sort((e1, e2) =>
        {
            int comparacionEdad = e1.Edad.CompareTo(e2.Edad);
            if (comparacionEdad != 0)
            {
                return comparacionEdad;
            }
            return e2.Promedio.CompareTo(e1.Promedio); // Descendente en promedio
        });
        Console.WriteLine("\n=== Ordenado por edad, luego promedio (desc) ===");
        MostrarEstudiantes(estudiantes);

// Funciones locales
    void MostrarEstudiantes(List<Estudiante> estudiantes)
    {
        foreach (var est in estudiantes)
        {
            Console.WriteLine($"  {est}");
        }
    }
```

#### 5.2.6. Conversiones

**Convertir a array y viceversa:**

```csharp
// Código ejecutable
        // Lista a Array
        List<int> lista = new List<int> { 1, 2, 3, 4, 5 };
        int[] array = lista.ToArray();
        Console.WriteLine($"Array: [{string.Join(", ", array)}]");
        
        // Array a Lista
        int[] otroArray = { 10, 20, 30 };
        List<int> otraLista = new List<int>(otroArray);
        Console.WriteLine($"Lista: [{string.Join(", ", otraLista)}]");
        
        // También con ToList() (requiere using System.Linq)
        // List<int> lista2 = otroArray.ToList();
```

**Copiar listas:**

```csharp
// Código ejecutable
        List<string> original = new List<string> { "A", "B", "C" };
        
        // Copia superficial con constructor
        List<string> copia1 = new List<string>(original);
        
        // Copia con GetRange
        List<string> copia2 = original.GetRange(0, original.Count);
        
        // Copia con ToArray + constructor
        List<string> copia3 = new List<string>(original.ToArray());
        
        // Modificar original
        original[0] = "Z";
        
        Console.WriteLine($"Original: [{string.Join(", ", original)}]");
        Console.WriteLine($"Copia 1:  [{string.Join(", ", copia1)}]");
        Console.WriteLine($"Copia 2:  [{string.Join(", ", copia2)}]");
        Console.WriteLine($"Copia 3:  [{string.Join(", ", copia3)}]");
        
        // Las copias no se afectan (para tipos valor y strings)
```

**Nota sobre copia profunda:**

```csharp
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public override string ToString()
    {
        return $"{Nombre} ({Edad})";
    }
}

// Código ejecutable
        List<Persona> original = new List<Persona>
        {
            new Persona { Nombre = "Ana", Edad = 25 },
            new Persona { Nombre = "Juan", Edad = 30 }
        };
        
        // Copia superficial:   copia las referencias
        List<Persona> copiaSuperficial = new List<Persona>(original);
        
        // Modificar objeto en copia
        copiaSuperficial[0]. Edad = 99;
        
        Console.WriteLine("Original:");
        foreach (var p in original)
        {
            Console.WriteLine($"  {p}");
        }
        
        Console.WriteLine("\nCopia superficial:");
        foreach (var p in copiaSuperficial)
        {
            Console.WriteLine($"  {p}");
        }
        
        // ¡Ambas listas afectadas!  (comparten las mismas instancias)
        
        // Para copia profunda, necesitas clonar cada objeto
        List<Persona> copiaProfunda = new List<Persona>();
        foreach (var persona in original)
        {
            copiaProfunda.Add(new Persona 
            { 
                Nombre = persona.Nombre, 
                Edad = persona.Edad 
            });
        }
        
        copiaProfunda[0]. Edad = 50;
        
        Console.WriteLine("\nCopia profunda:");
        foreach (var p in copiaProfunda)
        {
            Console.WriteLine($"  {p}");
        }
        
        Console.WriteLine("\nOriginal (sin cambios por copia profunda):");
        foreach (var p in original)
        {
            Console.WriteLine($"  {p}");
        }
```

#### 5.2.7. Capacidad y Rendimiento

**Capacity vs.  Count:**

```csharp
// Código ejecutable
        List<int> numeros = new List<int>();
        
        Console.WriteLine("Agregando elementos:");
        for (int i = 1; i <= 10; i++)
        {
            numeros. Add(i);
            Console.WriteLine($"Count: {numeros.Count}, Capacity: {numeros.Capacity}");
        }
        
        // Capacity crece automáticamente (duplicándose)
        // 0 → 4 → 8 → 16 → ... 
```

**TrimExcess:**

```csharp
// Código ejecutable
        List<int> numeros = new List<int>(100); // Capacidad 100
        
        // Agregar solo 10 elementos
        for (int i = 0; i < 10; i++)
        {
            numeros.Add(i);
        }
        
        Console.WriteLine($"Antes de TrimExcess:");
        Console.WriteLine($"  Count: {numeros.Count}");
        Console.WriteLine($"  Capacity: {numeros. Capacity}");
        
        // Reducir capacidad al tamaño real
        numeros. TrimExcess();
        
        Console.WriteLine($"\nDespués de TrimExcess:");
        Console.WriteLine($"  Count: {numeros.Count}");
        Console.WriteLine($"  Capacity: {numeros. Capacity}");
```

**Optimización con capacidad inicial:**

```csharp
using System.Diagnostics;

// Código ejecutable
        const int CANTIDAD = 1000000;
        
        // Sin capacidad inicial
        var sw1 = Stopwatch.StartNew();
        List<int> lista1 = new List<int>();
        for (int i = 0; i < CANTIDAD; i++)
        {
            lista1.Add(i);
        }
        sw1.Stop();
        
        // Con capacidad inicial
        var sw2 = Stopwatch.StartNew();
        List<int> lista2 = new List<int>(CANTIDAD);
        for (int i = 0; i < CANTIDAD; i++)
        {
            lista2.Add(i);
        }
        sw2.Stop();
        
        Console.WriteLine($"Sin capacidad inicial: {sw1.ElapsedMilliseconds}ms");
        Console.WriteLine($"Con capacidad inicial: {sw2.ElapsedMilliseconds}ms");
        Console.WriteLine($"Mejora: {sw1.ElapsedMilliseconds / (double)sw2.ElapsedMilliseconds:F2}x");

// Salida típica:
// Sin capacidad inicial: 45ms
// Con capacidad inicial: 15ms
// Mejora: 3. 00x
```

---

### 5.3. Dictionary<TKey, TValue>

#### 5.3.1. Características

**Dictionary<TKey, TValue>** es una colección de pares clave-valor donde cada clave es única. 

**Características principales:**
- ✓ Búsqueda por clave O(1) promedio
- ✓ Inserción O(1) promedio
- ✓ Eliminación O(1) promedio
- ✓ Claves únicas (no permite duplicados)
- ✓ Valores pueden repetirse
- ✓ No mantiene orden de inserción (usar OrderedDictionary si necesitas orden)

#### 5.3.2. Creación e Inicialización

```csharp
// Código ejecutable
        // 1. Constructor por defecto
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        
        // 2. Con capacidad inicial
        Dictionary<string, int> dict2 = new Dictionary<string, int>(100);
        
        // 3. Inicialización con colección
        Dictionary<string, int> dict3 = new Dictionary<string, int>
        {
            { "uno", 1 },
            { "dos", 2 },
            { "tres", 3 }
        };
        
        // 4. Sintaxis moderna (C# 6+)
        Dictionary<string, int> dict4 = new Dictionary<string, int>
        {
            ["uno"] = 1,
            ["dos"] = 2,
            ["tres"] = 3
        };
        
        // 5. Sintaxis simplificada (C# 9+)
        Dictionary<string, int> dict5 = new()
        {
            { "uno", 1 },
            { "dos", 2 }
        };
        
        // 6. Desde otra colección (ej: array de KeyValuePair)
        KeyValuePair<string, int>[] pares = 
        {
            new KeyValuePair<string, int>("a", 1),
            new KeyValuePair<string, int>("b", 2)
        };
        Dictionary<string, int> dict6 = new Dictionary<string, int>(pares);
```

#### 5.3.3. Operaciones Básicas

**Agregar elementos:**

```csharp
// Código ejecutable
        Dictionary<string, double> precios = new Dictionary<string, double>();
        
        // Add:  agregar clave-valor
        precios.Add("Laptop", 1200.00);
        precios.Add("Mouse", 25.50);
        precios.Add("Teclado", 75.00);
        
        Console.WriteLine("Después de Add:");
        MostrarDiccionario(precios);
        
        // Indexador:  agregar o modificar
        precios["Monitor"] = 300.00; // Agregar (clave no existe)
        precios["Mouse"] = 29.99;     // Modificar (clave existe)
        
        Console.WriteLine("\nDespués de usar indexador:");
        MostrarDiccionario(precios);
        
        // TryAdd (C# 7+):  agregar solo si no existe
        bool agregado1 = precios.TryAdd("Webcam", 80.00);
        bool agregado2 = precios. TryAdd("Mouse", 20.00); // No agrega (ya existe)
        
        Console. WriteLine($"\nTryAdd('Webcam'): {agregado1}");
        Console.WriteLine($"TryAdd('Mouse'): {agregado2}");
        MostrarDiccionario(precios);

// Funciones locales
    void MostrarDiccionario(Dictionary<string, double> dict)
    {
        foreach (var par in dict)
        {
            Console.WriteLine($"  {par.Key}: ${par.Value}");
        }
    }
```

**Acceder a elementos:**

```csharp
// Código ejecutable
        Dictionary<string, string> capitales = new Dictionary<string, string>
        {
            { "España", "Madrid" },
            { "Francia", "París" },
            { "Italia", "Roma" },
            { "Alemania", "Berlín" }
        };
        
        // Acceso por indexador
        string capitalEspaña = capitales["España"];
        Console.WriteLine($"Capital de España: {capitalEspaña}");
        
        // TryGetValue: forma segura (no lanza excepción)
        if (capitales.TryGetValue("Francia", out string capitalFrancia))
        {
            Console.WriteLine($"Capital de Francia: {capitalFrancia}");
        }
        
        if (capitales.TryGetValue("Portugal", out string capitalPortugal))
        {
            Console.WriteLine($"Capital de Portugal: {capitalPortugal}");
        }
        else
        {
            Console.WriteLine("Portugal no está en el diccionario");
        }
        
        // ContainsKey: verificar si existe clave
        bool tieneItalia = capitales.ContainsKey("Italia");
        Console.WriteLine($"\n¿Tiene Italia?  {tieneItalia}");
        
        // ContainsValue: verificar si existe valor
        bool tieneRoma = capitales.ContainsValue("Roma");
        Console.WriteLine($"¿Tiene Roma como valor? {tieneRoma}");
```

**Eliminar elementos:**

```csharp
// Código ejecutable
        Dictionary<int, string> productos = new Dictionary<int, string>
        {
            { 1, "Laptop" },
            { 2, "Mouse" },
            { 3, "Teclado" },
            { 4, "Monitor" },
            { 5, "Webcam" }
        };
        
        Console.WriteLine("Diccionario original:");
        MostrarDiccionario(productos);
        
        // Remove: eliminar por clave
        bool eliminado = productos.Remove(2);
        Console.WriteLine($"\nRemove(2): {eliminado}");
        MostrarDiccionario(productos);
        
        // Remove con out: eliminar y obtener valor
        if (productos.Remove(4, out string valorEliminado))
        {
            Console.WriteLine($"\nEliminado: clave 4, valor '{valorEliminado}'");
        }
        MostrarDiccionario(productos);
        
        // Clear: eliminar todos
        productos.Clear();
        Console.WriteLine($"\nDespués de Clear:  Count = {productos.Count}");

// Funciones locales
    void MostrarDiccionario(Dictionary<int, string> dict)
    {
        foreach (var par in dict)
        {
            Console.WriteLine($"  [{par.Key}] = {par.Value}");
        }
    }
```

#### 5.3.4. Recorrer Diccionarios

**Diferentes formas de iterar:**

```csharp
// Código ejecutable
        Dictionary<string, int> edades = new Dictionary<string, int>
        {
            { "Ana", 25 },
            { "Juan", 30 },
            { "María", 28 },
            { "Pedro", 35 }
        };
        
        // 1. Recorrer pares clave-valor
        Console.WriteLine("=== Recorrido de pares ===");
        foreach (KeyValuePair<string, int> par in edades)
        {
            Console.WriteLine($"{par.Key}: {par.Value} años");
        }
        
        // 2. Usando var (más corto)
        Console.WriteLine("\n=== Recorrido con var ===");
        foreach (var par in edades)
        {
            Console.WriteLine($"{par.Key}: {par.Value} años");
        }
        
        // 3. Deconstrucción (C# 7+)
        Console.WriteLine("\n=== Recorrido con deconstrucción ===");
        foreach (var (nombre, edad) in edades)
        {
            Console.WriteLine($"{nombre}:  {edad} años");
        }
        
        // 4. Recorrer solo claves
        Console.WriteLine("\n=== Solo claves ===");
        foreach (string nombre in edades.Keys)
        {
            Console.WriteLine($"  {nombre}");
        }
        
        // 5. Recorrer solo valores
        Console.WriteLine("\n=== Solo valores ===");
        foreach (int edad in edades.Values)
        {
            Console.WriteLine($"  {edad} años");
        }
        
        // 6. Acceder a clave y valor por separado
        Console.WriteLine("\n=== Acceso manual ===");
        foreach (string nombre in edades.Keys)
        {
            int edad = edades[nombre];
            Console.WriteLine($"{nombre} tiene {edad} años");
        }
```

#### 5.3.5. Propiedades Keys y Values

**Trabajar con colecciones de claves y valores:**

```csharp
// Código ejecutable
        Dictionary<string, double> calificaciones = new Dictionary<string, double>
        {
            { "Matemáticas", 8.5 },
            { "Física", 7.8 },
            { "Química", 9.2 },
            { "Historia", 8.0 }
        };
        
        // Keys: colección de claves
        Dictionary<string, double>. KeyCollection claves = calificaciones.Keys;
        Console.WriteLine($"Cantidad de materias: {claves.Count}");
        Console.WriteLine("Materias:");
        foreach (string materia in claves)
        {
            Console.WriteLine($"  - {materia}");
        }
        
        // Values: colección de valores
        Dictionary<string, double>.ValueCollection valores = calificaciones.Values;
        Console.WriteLine($"\nCalificaciones:");
        foreach (double nota in valores)
        {
            Console.WriteLine($"  - {nota:F1}");
        }
        
        // Calcular promedio
        double suma = 0;
        foreach (double nota in calificaciones.Values)
        {
            suma += nota;
        }
        double promedio = suma / calificaciones.Count;
        Console.WriteLine($"\nPromedio: {promedio:F2}");
        
        // Convertir Keys a array
        string[] materiasArray = new string[calificaciones.Keys.Count];
        calificaciones.Keys.CopyTo(materiasArray, 0);
        Console.WriteLine($"\nMaterias en array: [{string.Join(", ", materiasArray)}]");
        
        // Convertir Values a lista
        List<double> notasLista = new List<double>(calificaciones.Values);
        notasLista.Sort();
        Console.WriteLine($"Notas ordenadas: [{string.Join(", ", notasLista)}]");
```

#### 5.3.6. Ejemplos Prácticos

**Contador de palabras:**

```csharp
// Código ejecutable
        string texto = "el perro y el gato juegan en el parque el perro corre";
        
        // Dividir en palabras
        string[] palabras = texto.Split(' ');
        
        // Contar frecuencia
        Dictionary<string, int> frecuencia = new Dictionary<string, int>();
        
        foreach (string palabra in palabras)
        {
            if (frecuencia.ContainsKey(palabra))
            {
                frecuencia[palabra]++;
            }
            else
            {
                frecuencia[palabra] = 1;
            }
        }
        
        // Alternativa con TryGetValue (más eficiente)
        Dictionary<string, int> frecuencia2 = new Dictionary<string, int>();
        foreach (string palabra in palabras)
        {
            if (frecuencia2.TryGetValue(palabra, out int contador))
            {
                frecuencia2[palabra] = contador + 1;
            }
            else
            {
                frecuencia2[palabra] = 1;
            }
        }
        
        Console.WriteLine("=== Frecuencia de palabras ===");
        foreach (var par in frecuencia)
        {
            Console.WriteLine($"'{par.Key}': {par. Value} veces");
        }
        
        // Palabra más frecuente
        string palabraMasFrecuente = "";
        int maxFrecuencia = 0;
        
        foreach (var par in frecuencia)
        {
            if (par.Value > maxFrecuencia)
            {
                maxFrecuencia = par. Value;
                palabraMasFrecuente = par.Key;
            }
        }
        
        Console.WriteLine($"\nPalabra más frecuente: '{palabraMasFrecuente}' ({maxFrecuencia} veces)");
```

**Caché de configuración:**

```csharp
class ConfiguracionApp
{
    private Dictionary<string, string> configuracion = new Dictionary<string, string>();
    public ConfiguracionApp()
    {
        // Cargar configuración por defecto
        configuracion["Idioma"] = "es";
        configuracion["Tema"] = "Claro";
        configuracion["TamañoFuente"] = "14";
        configuracion["MostrarNotificaciones"] = "true";
    }
    public string ObtenerValor(string clave, string valorPorDefecto = "")
    {
        if (configuracion. TryGetValue(clave, out string valor))
        {
            return valor;
        }
        return valorPorDefecto;
    }
    public void EstablecerValor(string clave, string valor)
    {
        configuracion[clave] = valor;
    }
    public bool ObtenerBooleano(string clave, bool valorPorDefecto = false)
    {
        string valor = ObtenerValor(clave);
        if (bool.TryParse(valor, out bool resultado))
        {
            return resultado;
        }
        return valorPorDefecto;
    }
    public int ObtenerEntero(string clave, int valorPorDefecto = 0)
    {
        string valor = ObtenerValor(clave);
        if (int.TryParse(valor, out int resultado))
        {
            return resultado;
        }
        return valorPorDefecto;
    }
    public void MostrarConfiguracion()
    {
        Console.WriteLine("=== Configuración Actual ===");
        foreach (var par in configuracion)
        {
            Console.WriteLine($"  {par.Key} = {par.Value}");
        }
    }
}

// Código ejecutable
        ConfiguracionApp config = new ConfiguracionApp();
        
        config.MostrarConfiguracion();
        
        // Leer valores
        string idioma = config.ObtenerValor("Idioma");
        int tamañoFuente = config.ObtenerEntero("TamañoFuente");
        bool notificaciones = config.ObtenerBooleano("MostrarNotificaciones");
        
        Console.WriteLine($"\nIdioma: {idioma}");
        Console.WriteLine($"Tamaño de fuente:  {tamañoFuente}");
        Console.WriteLine($"Notificaciones: {notificaciones}");
        
        // Cambiar valores
        config.EstablecerValor("Tema", "Oscuro");
        config.EstablecerValor("TamañoFuente", "16");
        
        Console.WriteLine("\n");
        config.MostrarConfiguracion();
```

**Índice invertido (búsqueda de texto):**

```csharp
// Código ejecutable
        // Documentos
        Dictionary<int, string> documentos = new Dictionary<int, string>
        {
            { 1, "C# es un lenguaje de programación moderno" },
            { 2, "Python es popular para ciencia de datos" },
            { 3, "C# y Python son lenguajes de programación" },
            { 4, "La programación es importante en la era digital" }
        };
        
        // Crear índice invertido (palabra → lista de documentos)
        Dictionary<string, List<int>> indice = CrearIndiceInvertido(documentos);
        
        // Mostrar índice
        Console.WriteLine("=== Índice Invertido ===");
        foreach (var par in indice)
        {
            Console.WriteLine($"{par.Key}: documentos [{string.Join(", ", par. Value)}]");
        }
        
        // Buscar documentos que contienen una palabra
        Console.WriteLine("\n=== Búsqueda ===");
        BuscarPalabra(indice, "programación");
        BuscarPalabra(indice, "C#");
        BuscarPalabra(indice, "Java");

// Funciones locales
    Dictionary<string, List<int>> CrearIndiceInvertido(Dictionary<int, string> documentos)
    {
        Dictionary<string, List<int>> indice = new Dictionary<string, List<int>>();
        
        foreach (var doc in documentos)
        {
            int idDocumento = doc.Key;
            string[] palabras = doc.Value.ToLower().Split(' ');
            
            foreach (string palabra in palabras)
            {
                // Limpiar palabra (quitar puntuación)
                string palabraLimpia = new string(palabra.Where(char.IsLetterOrDigit).ToArray());
                
                if (string.IsNullOrEmpty(palabraLimpia))
                {
                    continue;
                }
                
                // Agregar documento al índice de esta palabra
                if (indice.ContainsKey(palabraLimpia))
                {
                    if (!indice[palabraLimpia].Contains(idDocumento))
                    {
                        indice[palabraLimpia]. Add(idDocumento);
                    }
                }
                else
                {
                    indice[palabraLimpia] = new List<int> { idDocumento };
                }
            }
        }
        
        return indice;
    }

    void BuscarPalabra(Dictionary<string, List<int>> indice, string palabra)
    {
        string palabraBuscar = palabra.ToLower();
        
        if (indice.TryGetValue(palabraBuscar, out List<int> documentos))
        {
            Console.WriteLine($"'{palabra}' encontrada en documentos: [{string.Join(", ", documentos)}]");
        }
        else
        {
            Console. WriteLine($"'{palabra}' no encontrada");
        }
    }
```

#### 5.3.7. Rendimiento y Comparadores

**Comparadores personalizados para claves:**

```csharp
// Comparador case-insensitive

// Código ejecutable
        // Diccionario case-sensitive (por defecto)
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        dict1["Hola"] = 1;
        dict1["hola"] = 2; // Clave diferente
        
        Console.WriteLine("Case-sensitive:");
        foreach (var par in dict1)
        {
            Console.WriteLine($"  {par.Key} = {par.Value}");
        }
        
        // Diccionario case-insensitive
        Dictionary<string, int> dict2 = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        dict2["Hola"] = 1;
        dict2["hola"] = 2; // Actualiza el valor (misma clave)
        
        Console.WriteLine("\nCase-insensitive:");
        foreach (var par in dict2)
        {
            Console.WriteLine($"  {par.Key} = {par.Value}");
        }
        
        // Búsqueda case-insensitive
        bool existe = dict2.ContainsKey("HOLA");
        Console.WriteLine($"\n¿Contiene 'HOLA'? {existe}"); // True
```

**Objetos personalizados como claves:**

Si usamos objetos personalizados como claves en un Dictionary<K, V>, la colección necesita una forma de identificar si un objeto es único. El método `GetHashCode()` debe generar una "huella digital" coherente y que `Equals()` compare correctamente los valores. Sin esto, la colección no podrá recuperar o filtrar la información de forma fiable, tratando objetos con los mismos datos como si fueran diferentes.

```csharp
public class Coordenada :  IEquatable<Coordenada>
{
    public int X { get; set; }
    public int Y { get; set; }
    public Coordenada(int x, int y)
    {
        X = x;
        Y = y;
    }
    // IMPORTANTE: Implementar Equals y GetHashCode
    public bool Equals(Coordenada other)
    {
        if (other == null) return false;
        return X == other.X && Y == other.Y;
    }
    public override bool Equals(object obj)
    {
        return Equals(obj as Coordenada);
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

// Código ejecutable
        Dictionary<Coordenada, string> mapa = new Dictionary<Coordenada, string>();
        
        // Agregar ubicaciones
        mapa[new Coordenada(0, 0)] = "Origen";
        mapa[new Coordenada(10, 5)] = "Punto A";
        mapa[new Coordenada(20, 15)] = "Punto B";
        
        Console.WriteLine("=== Mapa ===");
        foreach (var par in mapa)
        {
            Console.WriteLine($"{par.Key}: {par.Value}");
        }
        
        // Buscar por coordenada
        Coordenada buscar = new Coordenada(10, 5);
        if (mapa.TryGetValue(buscar, out string nombre))
        {
            Console. WriteLine($"\nEn {buscar} está: {nombre}");
        }
        
        // Funciona porque implementamos Equals y GetHashCode correctamente
```


---

### 5.4. HashSet<T>

#### 5.4.1. Características

**HashSet<T>** es una colección que almacena elementos únicos sin orden específico. Si trabajamos con objetos propios, la colección necesita una forma de identificar si un objeto es único. Si trabajamos con tipos personalizados, debemos asegurar que el método `GetHashCode()` genere una "huella digital" coherente y que `Equals()` compare correctamente los valores. Sin esto, la colección no podrá recuperar o filtrar la información de forma fiable, tratando objetos con los mismos datos como si fueran diferentes.

**Características principales:**
- ✓ Elementos únicos (no permite duplicados)
- ✓ Búsqueda O(1) promedio
- ✓ Inserción O(1) promedio
- ✓ Eliminación O(1) promedio
- ✓ No mantiene orden de inserción
- ✓ Operaciones de conjuntos (unión, intersección, diferencia)

#### 5.4.2. Creación y Operaciones Básicas

```csharp
// Código ejecutable
        // Crear HashSet
        HashSet<int> numeros = new HashSet<int>();
        
        // Add:  agregar elemento (retorna true si se agregó, false si ya existía)
        bool agregado1 = numeros.Add(1);
        bool agregado2 = numeros.Add(2);
        bool agregado3 = numeros.Add(1); // No agrega (duplicado)
        
        Console.WriteLine($"Agregar 1: {agregado1}");
        Console.WriteLine($"Agregar 2: {agregado2}");
        Console.WriteLine($"Agregar 1 (duplicado): {agregado3}");
        
        // Agregar múltiples
        numeros.Add(3);
        numeros.Add(4);
        numeros.Add(5);
        
        Console. WriteLine($"\nHashSet:  [{string.Join(", ", numeros)}]");
        Console.WriteLine($"Cantidad: {numeros.Count}");
        
        // Contains: verificar si existe
        bool contiene3 = numeros.Contains(3);
        bool contiene10 = numeros.Contains(10);
        
        Console.WriteLine($"\n¿Contiene 3? {contiene3}");
        Console.WriteLine($"¿Contiene 10? {contiene10}");
        
        // Remove: eliminar elemento
        bool eliminado = numeros.Remove(3);
        Console.WriteLine($"\nRemove(3): {eliminado}");
        Console.WriteLine($"HashSet: [{string.Join(", ", numeros)}]");
        
        // Clear: eliminar todos
        numeros.Clear();
        Console.WriteLine($"\nDespués de Clear: Count = {numeros.Count}");
```

**Inicialización:**

```csharp
// Código ejecutable
        // Con inicializador de colección
        HashSet<string> frutas = new HashSet<string>
        {
            "Manzana", "Banana", "Cereza", "Manzana" // "Manzana" duplicada ignorada
        };
        
        Console.WriteLine($"Frutas: [{string.Join(", ", frutas)}]");
        Console.WriteLine($"Cantidad: {frutas.Count}"); // 3, no 4
        
        // Desde un array (elimina duplicados automáticamente)
        int[] numerosConDuplicados = { 1, 2, 3, 2, 4, 1, 5, 3 };
        HashSet<int> numerosUnicos = new HashSet<int>(numerosConDuplicados);
        
        Console.WriteLine($"\nArray original: [{string.Join(", ", numerosConDuplicados)}]");
        Console.WriteLine($"HashSet (sin duplicados): [{string.Join(", ", numerosUnicos)}]");
```

#### 5.4.3. Operaciones de Conjuntos

**UnionWith:  unión**

```csharp
// Código ejecutable
        HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> conjuntoB = new HashSet<int> { 3, 4, 5, 6 };
        
        Console.WriteLine($"Conjunto A: [{string.Join(", ", conjuntoA)}]");
        Console.WriteLine($"Conjunto B: [{string.Join(", ", conjuntoB)}]");
        
        // UnionWith: A ∪ B (modifica conjuntoA)
        conjuntoA.UnionWith(conjuntoB);
        
        Console.WriteLine($"\nA ∪ B: [{string.Join(", ", conjuntoA)}]");
```

**IntersectWith: intersección**

```csharp
// Código ejecutable
        HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> conjuntoB = new HashSet<int> { 3, 4, 5, 6 };
        
        Console. WriteLine($"Conjunto A: [{string.Join(", ", conjuntoA)}]");
        Console.WriteLine($"Conjunto B:  [{string.Join(", ", conjuntoB)}]");
        
        // IntersectWith:  A ∩ B (modifica conjuntoA)
        conjuntoA.IntersectWith(conjuntoB);
        
        Console.WriteLine($"\nA ∩ B:  [{string.Join(", ", conjuntoA)}]");
```

**ExceptWith: diferencia**

```csharp
// Código ejecutable
        HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> conjuntoB = new HashSet<int> { 3, 4, 5, 6 };
        
        Console.WriteLine($"Conjunto A: [{string.Join(", ", conjuntoA)}]");
        Console.WriteLine($"Conjunto B: [{string.Join(", ", conjuntoB)}]");
        
        // ExceptWith: A - B (elementos en A pero no en B)
        conjuntoA.ExceptWith(conjuntoB);
        
        Console.WriteLine($"\nA - B: [{string.Join(", ", conjuntoA)}]");
```

**SymmetricExceptWith: diferencia simétrica**

```csharp
// Código ejecutable
        HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> conjuntoB = new HashSet<int> { 3, 4, 5, 6 };
        
        Console.WriteLine($"Conjunto A: [{string. Join(", ", conjuntoA)}]");
        Console.WriteLine($"Conjunto B: [{string.Join(", ", conjuntoB)}]");
        
        // SymmetricExceptWith: A Δ B (elementos en A o B, pero no en ambos)
        conjuntoA.SymmetricExceptWith(conjuntoB);
        
        Console.WriteLine($"\nA Δ B: [{string.Join(", ", conjuntoA)}]");
```

**Comparaciones de conjuntos:**

```csharp
// Código ejecutable
        HashSet<int> conjuntoA = new HashSet<int> { 1, 2, 3 };
        HashSet<int> conjuntoB = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> conjuntoC = new HashSet<int> { 4, 5, 6 };
        HashSet<int> conjuntoD = new HashSet<int> { 1, 2, 3 };
        
        // IsSubsetOf: A ⊆ B
        bool esSubconjunto = conjuntoA. IsSubsetOf(conjuntoB);
        Console.WriteLine($"A es subconjunto de B: {esSubconjunto}"); // True
        
        // IsProperSubsetOf: A ⊂ B (subconjunto propio)
        bool esSubconjuntoPropio = conjuntoA.IsProperSubsetOf(conjuntoB);
        Console.WriteLine($"A es subconjunto propio de B: {esSubconjuntoPropio}"); // True
        
        // IsSupersetOf: B ⊇ A
        bool esSuperconjunto = conjuntoB.IsSupersetOf(conjuntoA);
        Console.WriteLine($"B es superconjunto de A: {esSuperconjunto}"); // True
        
        // IsProperSupersetOf: B ⊃ A (superconjunto propio)
        bool esSuperconjuntoPropio = conjuntoB.IsProperSupersetOf(conjuntoA);
        Console.WriteLine($"B es superconjunto propio de A: {esSuperconjuntoPropio}"); // True
        
        // Overlaps: ¿tienen elementos en común?
        bool tienenComunes1 = conjuntoA. Overlaps(conjuntoB);
        bool tienenComunes2 = conjuntoA.Overlaps(conjuntoC);
        Console.WriteLine($"A y B tienen elementos en común: {tienenComunes1}"); // True
        Console.WriteLine($"A y C tienen elementos en común: {tienenComunes2}"); // False
        
        // SetEquals: ¿son iguales? 
        bool sonIguales1 = conjuntoA.SetEquals(conjuntoD);
        bool sonIguales2 = conjuntoA. SetEquals(conjuntoB);
        Console.WriteLine($"A y D son iguales:  {sonIguales1}"); // True
        Console.WriteLine($"A y B son iguales: {sonIguales2}"); // False
```

#### 5.4.4. Ejemplos Prácticos

**Eliminar duplicados:**

```csharp
// Código ejecutable
        List<int> numerosConDuplicados = new List<int> 
        { 
            1, 2, 3, 2, 4, 1, 5, 3, 6, 4, 2 
        };
        
        Console.WriteLine($"Lista original: [{string.Join(", ", numerosConDuplicados)}]");
        Console.WriteLine($"Cantidad: {numerosConDuplicados. Count}");
        
        // Eliminar duplicados con HashSet
        HashSet<int> numerosUnicos = new HashSet<int>(numerosConDuplicados);
        
        Console.WriteLine($"\nSin duplicados: [{string.Join(", ", numerosUnicos)}]");
        Console.WriteLine($"Cantidad: {numerosUnicos.Count}");
        
        // Convertir de vuelta a lista si es necesario
        List<int> listaSinDuplicados = new List<int>(numerosUnicos);
        Console.WriteLine($"\nDe vuelta a lista: [{string. Join(", ", listaSinDuplicados)}]");
```

**Encontrar elementos comunes y diferentes:**

```csharp
// Código ejecutable
        List<string> cursosEstudiante1 = new List<string> 
        { 
            "Matemáticas", "Física", "Química", "Historia" 
        };
        
        List<string> cursosEstudiante2 = new List<string> 
        { 
            "Física", "Biología", "Historia", "Arte" 
        };
        
        HashSet<string> cursos1 = new HashSet<string>(cursosEstudiante1);
        HashSet<string> cursos2 = new HashSet<string>(cursosEstudiante2);
        
        // Cursos en común
        HashSet<string> cursosComunes = new HashSet<string>(cursos1);
        cursosComunes.IntersectWith(cursos2);
        
        Console.WriteLine("Cursos en común:");
        foreach (string curso in cursosComunes)
        {
            Console.WriteLine($"  - {curso}");
        }
        
        // Cursos solo del estudiante 1
        HashSet<string> soloEstudiante1 = new HashSet<string>(cursos1);
        soloEstudiante1.ExceptWith(cursos2);
        
        Console.WriteLine("\nCursos solo del estudiante 1:");
        foreach (string curso in soloEstudiante1)
        {
            Console.WriteLine($"  - {curso}");
        }
        
        // Todos los cursos únicos
        HashSet<string> todosCursos = new HashSet<string>(cursos1);
        todosCursos.UnionWith(cursos2);
        
        Console.WriteLine("\nTodos los cursos:");
        foreach (string curso in todosCursos)
        {
            Console.WriteLine($"  - {curso}");
        }
```

**Verificar visitantes únicos:**

```csharp
// Código ejecutable
        // Simular log de visitas (IP addresses)
        string[] logVisitas = 
        {
            "192.168.1.1",
            "192.168.1.2",
            "192.168.1.1", // Duplicado
            "192.168.1.3",
            "192.168.1.2", // Duplicado
            "192.168.1.4",
            "192.168.1.1", // Duplicado
            "192.168.1.5"
        };
        
        Console.WriteLine($"Total de visitas: {logVisitas.Length}");
        
        // Contar visitantes únicos
        HashSet<string> visitantesUnicos = new HashSet<string>(logVisitas);
        
        Console.WriteLine($"Visitantes únicos: {visitantesUnicos.Count}");
        
        Console.WriteLine("\nIPs únicas:");
        foreach (string ip in visitantesUnicos)
        {
            // Contar visitas de esta IP
            int visitas = 0;
            foreach (string logIp in logVisitas)
            {
                if (logIp == ip)
                {
                    visitas++;
                }
            }
            Console.WriteLine($"  {ip}: {visitas} visitas");
        }
```

---

### 5.5. Queue<T>

#### 5.5.1. Características

**Queue<T>** es una colección FIFO (First In, First Out): el primer elemento en entrar es el primero en salir.

**Características principales:**
- ✓ FIFO (cola)
- ✓ Enqueue O(1) - agregar al final
- ✓ Dequeue O(1) - quitar del inicio
- ✓ Peek O(1) - ver el primero sin quitar
- ✓ No permite acceso por índice

#### 5.5.2. Operaciones Básicas

```csharp
// Código ejecutable
        Queue<string> cola = new Queue<string>();
        
        // Enqueue: agregar al final
        cola.Enqueue("Primero");
        cola.Enqueue("Segundo");
        cola.Enqueue("Tercero");
        cola.Enqueue("Cuarto");
        
        Console.WriteLine($"Elementos en cola: {cola.Count}");
        
        // Peek: ver el primero sin quitar
        string primero = cola. Peek();
        Console.WriteLine($"Primero en la cola (Peek): {primero}");
        Console.WriteLine($"Elementos después de Peek: {cola.Count}");
        
        // Dequeue: quitar y obtener el primero
        string procesado1 = cola.Dequeue();
        Console.WriteLine($"\nDequeue: {procesado1}");
        Console.WriteLine($"Elementos restantes: {cola.Count}");
        
        string procesado2 = cola. Dequeue();
        Console.WriteLine($"Dequeue: {procesado2}");
        Console.WriteLine($"Elementos restantes: {cola.Count}");
        
        // Mostrar elementos restantes
        Console.WriteLine("\nElementos restantes en cola:");
        foreach (string elemento in cola)
        {
            Console.WriteLine($"  - {elemento}");
        }
        
        // Contains: verificar si existe
        bool contieneTercero = cola.Contains("Tercero");
        Console.WriteLine($"\n¿Contiene 'Tercero'? {contieneTercero}");
        
        // Clear: vaciar
        cola.Clear();
        Console.WriteLine($"\nDespués de Clear: {cola.Count} elementos");
```

#### 5.5.3. Ejemplos Prácticos

**Sistema de procesamiento de tareas:**

```csharp
public class Tarea
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public DateTime HoraCreacion { get; set; }
    public Tarea(int id, string descripcion)
    {
        Id = id;
        Descripcion = descripcion;
        HoraCreacion = DateTime.Now;
    }
    public override string ToString()
    {
        return $"[Tarea {Id}] {Descripcion} (creada a las {HoraCreacion: HH:mm: ss})";
    }
}
class SistemaTareas
{
    private Queue<Tarea> colaTareas = new Queue<Tarea>();
    private int siguienteId = 1;
    public void AgregarTarea(string descripcion)
    {
        Tarea tarea = new Tarea(siguienteId++, descripcion);
        colaTareas. Enqueue(tarea);
        Console.WriteLine($"✓ Tarea agregada:  {tarea}");
    }
    public void ProcesarSiguienteTarea()
    {
        if (colaTareas.Count == 0)
        {
            Console.WriteLine("No hay tareas pendientes");
            return;
        }
        Tarea tarea = colaTareas.Dequeue();
        Console.WriteLine($"▶ Procesando:  {tarea}");
        // Simular procesamiento
        System.Threading.Thread.Sleep(500);
        Console.WriteLine($"✓ Tarea completada: {tarea. Id}");
    }
    public void MostrarTareasPendientes()
    {
        Console.WriteLine($"\n=== Tareas Pendientes ({colaTareas.Count}) ===");
        if (colaTareas.Count == 0)
        {
            Console.WriteLine("  (ninguna)");
            return;
        }
        foreach (Tarea tarea in colaTareas)
        {
            Console.WriteLine($"  {tarea}");
        }
    }
}

// Código ejecutable
        SistemaTareas sistema = new SistemaTareas();
        
        // Agregar tareas
        sistema.AgregarTarea("Procesar pedido #1001");
        sistema.AgregarTarea("Enviar email de confirmación");
        sistema.AgregarTarea("Actualizar inventario");
        sistema.AgregarTarea("Generar factura");
        
        sistema.MostrarTareasPendientes();
        
        // Procesar tareas
        Console.WriteLine("\n=== Procesando Tareas ===");
        sistema.ProcesarSiguienteTarea();
        sistema.ProcesarSiguienteTarea();
        
        sistema.MostrarTareasPendientes();
        
        // Agregar más tareas
        Console.WriteLine("\n=== Agregando Más Tareas ===");
        sistema.AgregarTarea("Notificar al cliente");
        
        sistema.MostrarTareasPendientes();
        
        // Procesar todas las restantes
        Console.WriteLine("\n=== Procesando Todas las Restantes ===");
        while (true)
        {
            if (colaTareas.Count == 0) break;
            sistema.ProcesarSiguienteTarea();
        }
```

**Simulación de atención al cliente:**

```csharp
public class Cliente
{
    public string Nombre { get; set; }
    public int NumeroTicket { get; set; }
    public DateTime HoraLlegada { get; set; }
    public Cliente(string nombre, int numeroTicket)
    {
        Nombre = nombre;
        NumeroTicket = numeroTicket;
        HoraLlegada = DateTime.Now;
    }
    public override string ToString()
    {
        return $"Ticket #{NumeroTicket}:  {Nombre}";
    }
}

// Código ejecutable
        Queue<Cliente> colaAtencion = new Queue<Cliente>();
        int siguienteTicket = 1;
        
        // Clientes llegando
        colaAtencion.Enqueue(new Cliente("Ana García", siguienteTicket++));
        colaAtencion.Enqueue(new Cliente("Juan López", siguienteTicket++));
        colaAtencion.Enqueue(new Cliente("María Martínez", siguienteTicket++));
        colaAtencion.Enqueue(new Cliente("Pedro Sánchez", siguienteTicket++));
        
        Console. WriteLine($"=== Clientes en espera:  {colaAtencion.Count} ===");
        foreach (Cliente cliente in colaAtencion)
        {
            Console.WriteLine($"  {cliente}");
        }
        
        // Atender clientes
        Console.WriteLine("\n=== Atendiendo Clientes ===");
        
        while (colaAtencion. Count > 0)
        {
            Cliente siguiente = colaAtencion. Peek();
            Console.WriteLine($"\nSiguiente:  {siguiente}");
            Console.Write("¿Atender? (s/n): ");
            
            // Simular atención automática
            Console.WriteLine("s");
            
            Cliente atendido = colaAtencion.Dequeue();
            TimeSpan tiempoEspera = DateTime. Now - atendido.HoraLlegada;
            Console.WriteLine($"✓ Atendido:  {atendido. Nombre}");
            Console.WriteLine($"  Tiempo de espera: {tiempoEspera.TotalSeconds:F1}s");
            Console.WriteLine($"  Clientes restantes: {colaAtencion.Count}");
            
            System.Threading.Thread.Sleep(100); // Simular tiempo de atención
        }
        
        Console.WriteLine("\n✓ Todos los clientes han sido atendidos");
```

---

### 5.6. Stack<T>

#### 5.6.1. Características

**Stack<T>** es una colección LIFO (Last In, First Out): el último elemento en entrar es el primero en salir.

**Características principales:**
- ✓ LIFO (pila)
- ✓ Push O(1) - agregar al tope
- ✓ Pop O(1) - quitar del tope
- ✓ Peek O(1) - ver el tope sin quitar
- ✓ No permite acceso por índice

#### 5.6.2. Operaciones Básicas

```csharp
// Código ejecutable
        Stack<string> pila = new Stack<string>();
        
        // Push: agregar al tope
        pila.Push("Primero");
        pila.Push("Segundo");
        pila.Push("Tercero");
        pila.Push("Cuarto");
        
        Console.WriteLine($"Elementos en pila: {pila.Count}");
        
        // Peek: ver el tope sin quitar
        string tope = pila.Peek();
        Console.WriteLine($"Tope de la pila (Peek): {tope}");
        Console.WriteLine($"Elementos después de Peek: {pila.Count}");
        
        // Pop: quitar y obtener el tope
        string sacado1 = pila.Pop();
        Console.WriteLine($"\nPop: {sacado1}");
        Console.WriteLine($"Elementos restantes: {pila.Count}");
        
        string sacado2 = pila.Pop();
        Console.WriteLine($"Pop: {sacado2}");
        Console.WriteLine($"Elementos restantes: {pila.Count}");
        
        // Mostrar elementos restantes
        Console.WriteLine("\nElementos restantes en pila:");
        foreach (string elemento in pila)
        {
            Console.WriteLine($"  - {elemento}");
        }
        
        // Contains: verificar si existe
        bool contienePrimero = pila.Contains("Primero");
        Console.WriteLine($"\n¿Contiene 'Primero'? {contienePrimero}");
        
        // Clear: vaciar
        pila.Clear();
        Console.WriteLine($"\nDespués de Clear: {pila.Count} elementos");
```

#### 5.6.3. Ejemplos Prácticos

**Historial de navegación (botones Atrás/Adelante):**

```csharp
class Navegador
{
    private Stack<string> historialAtras = new Stack<string>();
    private Stack<string> historialAdelante = new Stack<string>();
    private string paginaActual = "Inicio";
    public void MostrarEstado()
    {
        Console. WriteLine($"\nPágina actual: {paginaActual}");
        Console.WriteLine($"  Puede ir atrás: {historialAtras.Count} páginas");
        Console.WriteLine($"  Puede ir adelante: {historialAdelante.Count} páginas");
    }
    public void NavegarA(string url)
    {
        historialAtras.Push(paginaActual);
        paginaActual = url;
        historialAdelante.Clear(); // Limpiar historial adelante
        Console.WriteLine($"→ Navegando a: {url}");
    }
    public void Atras()
    {
        if (historialAtras.Count == 0)
        {
            Console.WriteLine("No hay páginas anteriores");
            return;
        }
        historialAdelante.Push(paginaActual);
        paginaActual = historialAtras. Pop();
        Console. WriteLine($"← Atrás a: {paginaActual}");
    }
    public void Adelante()
    {
        if (historialAdelante.Count == 0)
        {
            Console.WriteLine("No hay páginas adelante");
            return;
        }
        historialAtras.Push(paginaActual);
        paginaActual = historialAdelante.Pop();
        Console.WriteLine($"→ Adelante a: {paginaActual}");
    }
}

// Código ejecutable
        Navegador nav = new Navegador();
        
        nav.MostrarEstado();
        
        nav.NavegarA("google.com");
        nav.NavegarA("github.com");
        nav.NavegarA("stackoverflow.com");
        
        nav.MostrarEstado();
        
        nav.Atras();
        nav.Atras();
        
        nav.MostrarEstado();
        
        nav.Adelante();
        
        nav.MostrarEstado();
        
        nav.NavegarA("reddit.com");
        
        nav.MostrarEstado();
        
        nav.Adelante(); // No hay páginas adelante
```

**Verificar paréntesis balanceados:**

```csharp
// Código ejecutable
        string[] expresiones = 
        {
            "(a + b)",
            "((a + b) * c)",
            "(a + b))",
            "((a + b)",
            "{[()]}",
            "{[(])}",
            ""
        };
        
        Console.WriteLine("=== Verificación de Paréntesis Balanceados ===\n");
        
        foreach (string expresion in expresiones)
        {
            bool balanceado = VerificarBalance(expresion);
            string resultado = balanceado ? "✓ Balanceado" :  "✗ No balanceado";
            Console. WriteLine($"{expresion,-20} {resultado}");
        }

// Funciones locales
    bool VerificarBalance(string expresion)
    {
        Stack<char> pila = new Stack<char>();
        
        foreach (char c in expresion)
        {
            // Si es apertura, apilar
            if (c == '(' || c == '[' || c == '{')
            {
                pila.Push(c);
            }
            // Si es cierre, verificar
            else if (c == ')' || c == ']' || c == '}')
            {
                if (pila. Count == 0)
                {
                    return false; // Cierre sin apertura
                }
                
                char apertura = pila.Pop();
                
                // Verificar que coincidan
                if ((c == ')' && apertura != '(') ||
                    (c == ']' && apertura != '[') ||
                    (c == '}' && apertura != '{'))
                {
                    return false; // No coinciden
                }
            }
        }
        
        // Debe quedar vacía (todos los abiertos tienen su cierre)
        return pila.Count == 0;
    }

``
---

### 5.7. SortedSet<T>

#### 5.7.1. Características

**SortedSet<T>** es similar a `HashSet<T>`, pero **mantiene los elementos ordenados**. 

**Características principales:**
- ✓ Elementos únicos (no permite duplicados)
- ✓ Mantiene orden (según `IComparable<T>` o `IComparer<T>`)
- ✓ Búsqueda O(log n)
- ✓ Inserción O(log n)
- ✓ Eliminación O(log n)
- ✓ Operaciones de conjuntos
- ✗ Más lento que `HashSet<T>` pero mantiene orden

#### 5.7.2. Operaciones Básicas
```csharp
class Program
{
    static void Main()
    {
        SortedSet<int> numeros = new SortedSet<int>();
        
        // Agregar elementos (se mantienen ordenados automáticamente)
        numeros.Add(5);
        numeros.Add(2);
        numeros.Add(8);
        numeros.Add(1);
        numeros.Add(9);
        numeros.Add(3);
        
        Console.WriteLine("Elementos (ordenados automáticamente):");
        foreach (int n in numeros)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine();
        
        // Min y Max
        int minimo = numeros.Min;
        int maximo = numeros.Max;
        Console.WriteLine($"\nMínimo: {minimo}");
        Console.WriteLine($"Máximo: {maximo}");
        
        // GetViewBetween:  obtener subconjunto
        SortedSet<int> rango = numeros.GetViewBetween(3, 8);
        Console.WriteLine($"\nRango [3, 8]: [{string.Join(", ", rango)}]");
        
        // Reverse: iterar en orden inverso
        Console.WriteLine("\nOrden inverso:");
        foreach (int n in numeros.Reverse())
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine();
    }
}
```

#### 5.7.3. Con Comparador Personalizado

```csharp
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public override string ToString()
    {
        return $"{Nombre} ({Edad})";
    }
}

// Código ejecutable
        // Ordenar por edad
        var comparadorEdad = Comparer<Persona>.Create((p1, p2) => p1.Edad.CompareTo(p2.Edad));
        SortedSet<Persona> personasPorEdad = new SortedSet<Persona>(comparadorEdad);
        
        personasPorEdad.Add(new Persona { Nombre = "Ana", Edad = 25 });
        personasPorEdad.Add(new Persona { Nombre = "Juan", Edad = 30 });
        personasPorEdad.Add(new Persona { Nombre = "María", Edad = 22 });
        personasPorEdad.Add(new Persona { Nombre = "Pedro", Edad = 28 });
        
        Console.WriteLine("Personas ordenadas por edad:");
        foreach (var persona in personasPorEdad)
        {
            Console.WriteLine($"  {persona}");
        }
```

---

### 5.8. SortedDictionary<TKey, TValue>

#### 5.8.1. Características

**SortedDictionary<TKey, TValue>** es similar a `Dictionary<TKey, TValue>`, pero **mantiene las claves ordenadas**.

**Características principales:**
- ✓ Claves ordenadas
- ✓ Búsqueda O(log n)
- ✓ Inserción O(log n)
- ✓ Eliminación O(log n)
- ✗ Más lento que `Dictionary<TKey, TValue>` pero mantiene orden

#### 5.8.2. Operaciones Básicas

```csharp
// Código ejecutable
        SortedDictionary<string, int> calificaciones = new SortedDictionary<string, int>();
        
        // Agregar (se ordenan por clave automáticamente)
        calificaciones["Matemáticas"] = 85;
        calificaciones["Física"] = 78;
        calificaciones["Química"] = 92;
        calificaciones["Historia"] = 88;
        calificaciones["Biología"] = 90;
        
        Console.WriteLine("Calificaciones (ordenadas alfabéticamente por materia):");
        foreach (var par in calificaciones)
        {
            Console.WriteLine($"  {par.Key}: {par. Value}");
        }
        
        // Keys y Values están ordenados
        Console.WriteLine("\nMaterias (ordenadas):");
        foreach (string materia in calificaciones.Keys)
        {
            Console. WriteLine($"  - {materia}");
        }
```

---

### 5.9. LinkedList<T>

#### 5.9.1. Características

**LinkedList<T>** es una lista doblemente enlazada. 

**Características principales:**
- ✓ Inserción/eliminación en cualquier posición O(1) (si tienes el nodo)
- ✓ No requiere redimensionamiento
- ✗ Acceso por índice O(n)
- ✗ Mayor uso de memoria (por los punteros)

#### 5.9.2. Operaciones Básicas

```csharp
// Código ejecutable
        LinkedList<string> lista = new LinkedList<string>();
        
        // AddLast: agregar al final
        lista.AddLast("Primero");
        lista.AddLast("Tercero");
        lista.AddLast("Cuarto");
        
        // AddFirst: agregar al inicio
        lista.AddFirst("Cero");
        
        Console.WriteLine("Lista:");
        MostrarLista(lista);
        
        // AddAfter / AddBefore: insertar relativo a un nodo
        LinkedListNode<string> nodoPrimero = lista.Find("Primero");
        lista.AddAfter(nodoPrimero, "Segundo");
        
        Console.WriteLine("\nDespués de insertar 'Segundo':");
        MostrarLista(lista);
        
        // Acceder a primer y último nodo
        LinkedListNode<string> primerNodo = lista.First;
        LinkedListNode<string> ultimoNodo = lista.Last;
        
        Console.WriteLine($"\nPrimer nodo: {primerNodo.Value}");
        Console.WriteLine($"Último nodo: {ultimoNodo.Value}");
        
        // Navegar por los nodos
        Console.WriteLine("\nNavegación manual:");
        LinkedListNode<string> nodoActual = lista.First;
        while (nodoActual != null)
        {
            Console.WriteLine($"  {nodoActual.Value}");
            nodoActual = nodoActual.Next;
        }
        
        // Remove: eliminar nodo
        lista.Remove("Tercero");
        
        Console.WriteLine("\nDespués de eliminar 'Tercero':");
        MostrarLista(lista);

// Funciones locales
    void MostrarLista(LinkedList<string> lista)
    {
        foreach (string item in lista)
        {
            Console.Write($"{item} -> ");
        }
        Console. WriteLine("null");
    }
```

---

### 5.10. Colecciones No Genéricas (Legacy)

Las colecciones no genéricas pertenecen al namespace `System.Collections` y fueron introducidas en las primeras versiones de . NET (antes de C# 2.0). **No son type-safe** y requieren casting, lo que puede causar errores en tiempo de ejecución.

#### 5.10.1. ¿Qué son y por qué evitarlas?

**Problemas de las colecciones no genéricas:**

1. **No son type-safe**: Pueden contener cualquier tipo de objeto
2. **Requieren casting**: Conversiones explícitas propensas a errores
3. **Boxing/Unboxing**: Penalización de rendimiento con tipos valor
4. **Errores en tiempo de ejecución**: Los problemas de tipo no se detectan en compilación

```csharp
using System.Collections;

// Código ejecutable
        // Ejemplo del problema
        ArrayList lista = new ArrayList();
        lista.Add(1);        // int (boxing)
        lista.Add("texto");  // string
        lista.Add(3.14);     // double (boxing)
        
        // Esto compila pero falla en ejecución
        foreach (int numero in lista) // ¡EXCEPCIÓN en "texto"!
        {
            Console.WriteLine(numero);
        }
```

#### 5.10.2. ArrayList

**⚠️ OBSOLETA - Usar `List<T>` en su lugar**

```csharp
using System.Collections;

// Código ejecutable
        // ✗ EVITAR: ArrayList (no genérica)
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);        // Boxing:  int → object
        arrayList.Add("texto");  // Cualquier tipo
        arrayList.Add(3.14);     // Boxing: double → object
        
        Console.WriteLine("ArrayList (sin type-safety):");
        foreach (object item in arrayList)
        {
            Console.WriteLine($"  {item} ({item.GetType().Name})");
        }
        
        // Requiere casting (propenso a errores)
        int numero = (int)arrayList[0]; // Unboxing
        // string texto = (string)arrayList[0]; // ¡InvalidCastException!
        
        Console.WriteLine("\n✓ ALTERNATIVA CORRECTA:");
        
        // ✓ USAR: List<T> (genérica)
        List<int> lista = new List<int>();
        lista.Add(1);
        lista.Add(2);
        // lista.Add("texto"); // Error de compilación (type-safe)
        
        int valor = lista[0]; // Sin casting necesario
        Console.WriteLine($"  Valor: {valor}");
```

**Comparación de rendimiento:**

```csharp
using System.Diagnostics;
using System.Collections;

// Código ejecutable
        const int ITERACIONES = 1000000;
        
        // ArrayList (boxing/unboxing)
        var sw1 = Stopwatch.StartNew();
        ArrayList arrayList = new ArrayList();
        for (int i = 0; i < ITERACIONES; i++)
        {
            arrayList. Add(i); // Boxing
        }
        int suma1 = 0;
        foreach (int n in arrayList) // Unboxing
        {
            suma1 += n;
        }
        sw1.Stop();
        
        // List<T> (sin boxing)
        var sw2 = Stopwatch.StartNew();
        List<int> lista = new List<int>();
        for (int i = 0; i < ITERACIONES; i++)
        {
            lista.Add(i); // Sin boxing
        }
        int suma2 = 0;
        foreach (int n in lista) // Sin unboxing
        {
            suma2 += n;
        }
        sw2.Stop();
        
        Console.WriteLine($"ArrayList: {sw1.ElapsedMilliseconds}ms");
        Console.WriteLine($"List<T>:    {sw2.ElapsedMilliseconds}ms");
        Console.WriteLine($"Mejora:     {sw1.ElapsedMilliseconds / (double)sw2.ElapsedMilliseconds:F2}x más rápido");

// Salida típica:
// ArrayList: 180ms
// List<T>:    45ms
// Mejora:    4.00x más rápido
```

#### 5.10.3. Hashtable

**⚠️ OBSOLETA - Usar `Dictionary<TKey, TValue>` en su lugar**

```csharp
using System.Collections;

// Código ejecutable
        // ✗ EVITAR: Hashtable (no genérica)
        Hashtable tabla = new Hashtable();
        tabla["clave1"] = 100;
        tabla["clave2"] = "texto";
        tabla[123] = 3.14; // Claves y valores de cualquier tipo
        
        Console. WriteLine("Hashtable (sin type-safety):");
        foreach (DictionaryEntry entrada in tabla)
        {
            Console.WriteLine($"  {entrada.Key} => {entrada.Value}");
        }
        
        // Requiere casting
        int valor = (int)tabla["clave1"];
        
        Console.WriteLine("\n✓ ALTERNATIVA CORRECTA:");
        
        // ✓ USAR: Dictionary<TKey, TValue> (genérica)
        Dictionary<string, int> diccionario = new Dictionary<string, int>();
        diccionario["clave1"] = 100;
        diccionario["clave2"] = 200;
        // diccionario["clave3"] = "texto"; // Error de compilación
        
        int valorSeguro = diccionario["clave1"]; // Sin casting
        Console.WriteLine($"  Valor: {valorSeguro}");
```

#### 5.10.4. Stack y Queue No Genéricas

**⚠️ OBSOLETAS - Usar `Stack<T>` y `Queue<T>`**

```csharp
using System.Collections;

// Código ejecutable
        // ✗ EVITAR: colecciones no genéricas
        System.Collections.Stack pilaVieja = new System.Collections.Stack();
        pilaVieja. Push(1);
        pilaVieja.Push("texto");
        object valor1 = pilaVieja.Pop(); // Requiere casting
        
        System.Collections.Queue colaVieja = new System.Collections.Queue();
        colaVieja.Enqueue(1);
        colaVieja. Enqueue("texto");
        object valor2 = colaVieja.Dequeue(); // Requiere casting
        
        Console. WriteLine("✓ ALTERNATIVAS CORRECTAS:");
        
        // ✓ USAR:  versiones genéricas
        Stack<int> pilaNueva = new Stack<int>();
        pilaNueva.Push(1);
        // pilaNueva.Push("texto"); // Error de compilación
        int valorPila = pilaNueva.Pop(); // Sin casting
        
        Queue<string> colaNueva = new Queue<string>();
        colaNueva. Enqueue("primero");
        colaNueva.Enqueue("segundo");
        string valorCola = colaNueva. Dequeue(); // Sin casting
        
        Console.WriteLine($"  Pila: {valorPila}");
        Console.WriteLine($"  Cola: {valorCola}");
```

#### 5.10.5. Tabla de Migración

| Colección Legacy (Evitar) | Colección Genérica (Usar)  | Mejora                                   |
| ------------------------- | -------------------------- | ---------------------------------------- |
| `ArrayList`               | `List<T>`                  | Type-safe, sin boxing, mejor rendimiento |
| `Hashtable`               | `Dictionary<TKey, TValue>` | Type-safe, sin boxing, mejor rendimiento |
| `Stack`                   | `Stack<T>`                 | Type-safe, sin boxing                    |
| `Queue`                   | `Queue<T>`                 | Type-safe, sin boxing                    |
| `SortedList`              | `SortedList<TKey, TValue>` | Type-safe, sin boxing                    |

**Regla de oro:  NUNCA uses colecciones no genéricas en código nuevo.  Existen solo por compatibilidad con código legacy.**

---

### 5.11. Colecciones de Solo Lectura (Read-Only)

Las colecciones de solo lectura proporcionan **vistas inmutables** de colecciones subyacentes.  Son útiles para exponer datos sin permitir modificaciones externas.

#### 5.11.1. ¿Qué son las colecciones de solo lectura? 

Las colecciones de solo lectura son **wrappers** o **vistas** sobre colecciones existentes que: 

- ✓ Permiten leer elementos
- ✓ Permiten iterar
- ✗ NO permiten agregar elementos
- ✗ NO permiten eliminar elementos
- ✗ NO permiten modificar elementos

**Importante:** La colección subyacente **sí puede cambiar**, y los cambios se reflejan en la vista de solo lectura.

#### 5.11.2. IReadOnlyList<T> e IReadOnlyCollection<T>

```csharp
// Código ejecutable
        // Lista normal (mutable)
        List<int> listaMutable = new List<int> { 1, 2, 3, 4, 5 };
        
        // Exponer como solo lectura (interfaz)
        IReadOnlyList<int> listaSoloLectura = listaMutable;
        
        Console.WriteLine("Lista de solo lectura:");
        foreach (int numero in listaSoloLectura)
        {
            Console. Write($"{numero} ");
        }
        Console.WriteLine();
        
        // Acceso por índice (permitido)
        int primero = listaSoloLectura[0];
        int ultimo = listaSoloLectura[listaSoloLectura.Count - 1];
        Console.WriteLine($"Primero: {primero}, Último: {ultimo}");
        
        // Modificación (NO permitido - no compila)
        // listaSoloLectura[0] = 10; // Error:  propiedad de solo lectura
        // listaSoloLectura. Add(6);  // Error: método no existe en interfaz
        
        // IMPORTANTE: La lista subyacente SÍ puede cambiar
        Console.WriteLine("\nModificando lista original.. .");
        listaMutable.Add(6);
        listaMutable[0] = 100;
        
        Console.WriteLine("Vista de solo lectura (refleja cambios):");
        foreach (int numero in listaSoloLectura)
        {
            Console.Write($"{numero} ");
        }
        Console.WriteLine();
```

**IReadOnlyCollection<T> vs IReadOnlyList<T>:**

```csharp
// Código ejecutable
        List<string> lista = new List<string> { "uno", "dos", "tres" };
        
        // IReadOnlyCollection<T>:  solo Count y enumeración
        IReadOnlyCollection<string> coleccionLectura = lista;
        Console.WriteLine($"Count: {coleccionLectura.Count}");
        // No tiene indexador
        
        // IReadOnlyList<T>: Count, enumeración y acceso por índice
        IReadOnlyList<string> listaLectura = lista;
        Console.WriteLine($"Count: {listaLectura.Count}");
        Console.WriteLine($"Elemento [1]: {listaLectura[1]}"); // Tiene indexador
```

#### 5.11.3. ReadOnlyCollection<T>

```csharp
using System.Collections. ObjectModel;

// Código ejecutable
        List<string> listaMutable = new List<string> { "uno", "dos", "tres" };
        
        // Crear wrapper de solo lectura
        ReadOnlyCollection<string> soloLectura = new ReadOnlyCollection<string>(listaMutable);
        
        Console.WriteLine("ReadOnlyCollection:");
        foreach (string item in soloLectura)
        {
            Console.WriteLine($"  {item}");
        }
        
        // Acceso por índice (permitido)
        Console.WriteLine($"Elemento [0]: {soloLectura[0]}");
        
        // Modificación (NO permitido)
        // soloLectura[0] = "UNO"; // Error: propiedad de solo lectura
        // soloLectura.Add("cuatro"); // Error: método no existe
        
        // La lista subyacente sí puede cambiar
        Console.WriteLine("\nModificando lista original...");
        listaMutable.Add("cuatro");
        listaMutable[0] = "UNO";
        
        Console.WriteLine("ReadOnlyCollection (refleja cambios):");
        foreach (string item in soloLectura)
        {
            Console.WriteLine($"  {item}");
        }
```

#### 5.11.4. AsReadOnly()

```csharp
// Código ejecutable
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
        
        // Crear vista de solo lectura con AsReadOnly()
        IReadOnlyList<int> numerosReadOnly = numeros.AsReadOnly();
        
        Console.WriteLine("Vista de solo lectura:");
        foreach (int n in numerosReadOnly)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine();
        
        // Modificar original
        numeros.Add(6);
        
        Console.WriteLine("\nDespués de modificar original:");
        foreach (int n in numerosReadOnly)
        {
            Console.Write($"{n} ");
        }
        Console. WriteLine();
```

#### 5.11.5. Casos de Uso

**Exponer colecciones desde clases sin permitir modificación externa:**

```csharp
public class Biblioteca
{
    private List<string> libros = new List<string>();
    // Exponer como solo lectura
    public IReadOnlyList<string> Libros => libros.AsReadOnly();
    public void AgregarLibro(string titulo)
    {
        libros.Add(titulo);
    }
    public bool EliminarLibro(string titulo)
    {
        return libros.Remove(titulo);
    }
}

// Código ejecutable
        Biblioteca biblioteca = new Biblioteca();
        biblioteca.AgregarLibro("El Quijote");
        biblioteca.AgregarLibro("Cien Años de Soledad");
        
        // Obtener colección de solo lectura
        IReadOnlyList<string> libros = biblioteca.Libros;
        
        Console.WriteLine("Libros:");
        foreach (string libro in libros)
        {
            Console.WriteLine($"  - {libro}");
        }
        
        // No se puede modificar desde fuera
        // libros.Add("Otro libro"); // Error: método no existe
        // biblioteca. Libros.Add("Otro"); // Error: método no existe
        
        // Solo se puede modificar a través de métodos públicos
        biblioteca.AgregarLibro("1984");
        
        Console. WriteLine("\nDespués de agregar:");
        foreach (string libro in biblioteca.Libros)
        {
            Console.WriteLine($"  - {libro}");
        }
```

**Resumen de Colecciones de Solo Lectura:**

| Tipo                       | Permite Indexación | Refleja Cambios | Uso                          |
| -------------------------- | ------------------ | --------------- | ---------------------------- |
| `IReadOnlyCollection<T>`   | No                 | Sí              | Vista básica de solo lectura |
| `IReadOnlyList<T>`         | Sí                 | Sí              | Vista con acceso por índice  |
| `IReadOnlyDictionary<K,V>` | Por clave          | Sí              | Vista de diccionario         |
| `ReadOnlyCollection<T>`    | Sí                 | Sí              | Wrapper concreto             |

---

### 5.12. Colecciones Inmutables (System.Collections.Immutable)

Las colecciones inmutables son **completamente inmutables**:  una vez creadas, **nunca cambian**.  Cualquier operación que "modifica" la colección retorna una **nueva instancia**.

#### 5.12.1. ¿Qué son las colecciones inmutables?

**Diferencias clave:**

| Aspecto         | Colección Normal   | Colección Solo Lectura     | Colección Inmutable               |
| --------------- | ------------------ | -------------------------- | --------------------------------- |
| **Modificable** | Sí                 | No (pero la subyacente sí) | No (ni directa ni indirectamente) |
| **Thread-Safe** | No                 | No                         | **Sí** (por naturaleza)           |
| **Operaciones** | Modifican in-place | N/A                        | Retornan nueva instancia          |
| **Rendimiento** | O(1) mayoría       | O(1) lectura               | O(log n) mayoría                  |
| **Memoria**     | Eficiente          | Eficiente                  | Usa structural sharing            |

**Ventajas de inmutabilidad:**

- ✓ **Thread-safe por naturaleza**:  Múltiples hilos pueden leer sin sincronización
- ✓ **Historial de versiones**:  Cada "modificación" crea nueva versión
- ✓ **Sin efectos secundarios**: Funciones puras
- ✓ **Razonamiento más simple**: El estado nunca cambia
- ✗ **Overhead de memoria**: Requiere crear copias (mitigado con structural sharing)
- ✗ **Rendimiento**: O(log n) vs O(1) en muchas operaciones

#### 5.12.2. Instalación

Las colecciones inmutables NO están incluidas por defecto.  Debes instalar el paquete NuGet:

```bash
dotnet add package System.Collections. Immutable
```

O en Visual Studio:  `Tools` → `NuGet Package Manager` → `Manage NuGet Packages` → Buscar `System.Collections.Immutable`

#### 5.12.3. ImmutableList<T>

```csharp
using System.Collections.Immutable;

// Código ejecutable
        // Crear lista inmutable
        ImmutableList<int> lista1 = ImmutableList.Create(1, 2, 3);
        
        Console.WriteLine("Lista original:");
        foreach (int n in lista1)
        {
            Console.Write($"{n} ");
        }
        Console. WriteLine();
        
        // "Agregar" retorna NUEVA lista (no modifica la original)
        ImmutableList<int> lista2 = lista1.Add(4);
        
        Console.WriteLine("\nLista original (SIN CAMBIOS):");
        foreach (int n in lista1)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine();
        
        Console.WriteLine("\nNueva lista (con 4):");
        foreach (int n in lista2)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine();
        
        // Encadenar operaciones (cada una retorna nueva instancia)
        ImmutableList<int> lista3 = lista1
            .Add(4)
            .Add(5)
            .Remove(2)
            .Insert(0, 0);
        
        Console.WriteLine("\nLista con operaciones encadenadas:");
        foreach (int n in lista3)
        {
            Console. Write($"{n} ");
        }
        Console.WriteLine();
        
        // La lista original NUNCA cambia
        Console.WriteLine("\nLista original (TODAVÍA SIN CAMBIOS):");
        foreach (int n in lista1)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine();
```

#### 5.12.4. ImmutableDictionary<TKey, TValue>

```csharp
using System.Collections.Immutable;

// Código ejecutable
        // Crear diccionario inmutable
        ImmutableDictionary<string, int> dict1 = ImmutableDictionary.Create<string, int>();
        
        // "Agregar" retorna nuevo diccionario
        ImmutableDictionary<string, int> dict2 = dict1.Add("uno", 1);
        ImmutableDictionary<string, int> dict3 = dict2.Add("dos", 2);
        ImmutableDictionary<string, int> dict4 = dict3.Add("tres", 3);
        
        Console.WriteLine("dict1 (vacío):");
        Console.WriteLine($"  Count: {dict1.Count}");
        
        Console.WriteLine("\ndict4 (con 3 elementos):");
        foreach (var par in dict4)
        {
            Console.WriteLine($"  {par.Key} => {par.Value}");
        }
        
        // "Eliminar" retorna nuevo diccionario
        ImmutableDictionary<string, int> dict5 = dict4.Remove("dos");
        
        Console.WriteLine("\ndict5 (sin 'dos'):");
        foreach (var par in dict5)
        {
            Console.WriteLine($"  {par.Key} => {par.Value}");
        }
        
        Console.WriteLine("\ndict4 (sin cambios):");
        foreach (var par in dict4)
        {
            Console.WriteLine($"  {par.Key} => {par.Value}");
        }
```

#### 5.12.5. Otras Colecciones Inmutables

```csharp
using System.Collections.Immutable;

// Código ejecutable
        // ImmutableArray<T>: array inmutable (mejor rendimiento que ImmutableList)
        ImmutableArray<int> array = ImmutableArray.Create(1, 2, 3, 4, 5);
        
        // ImmutableHashSet<T>: conjunto inmutable
        ImmutableHashSet<string> set1 = ImmutableHashSet.Create("a", "b", "c");
        ImmutableHashSet<string> set2 = set1.Add("d");
        
        // ImmutableSortedSet<T>: conjunto ordenado inmutable
        ImmutableSortedSet<int> sortedSet = ImmutableSortedSet.Create(5, 1, 3, 2, 4);
        Console.WriteLine($"SortedSet: [{string.Join(", ", sortedSet)}]");
        
        // ImmutableStack<T>: pila inmutable
        ImmutableStack<char> stack1 = ImmutableStack.Create('a', 'b', 'c');
        ImmutableStack<char> stack2 = stack1.Push('d');
        ImmutableStack<char> stack3 = stack2.Pop(out char tope);
        Console.WriteLine($"Tope: {tope}");
        
        // ImmutableQueue<T>: cola inmutable
        ImmutableQueue<int> queue1 = ImmutableQueue.Create(1, 2, 3);
        ImmutableQueue<int> queue2 = queue1.Enqueue(4);
        ImmutableQueue<int> queue3 = queue2.Dequeue(out int primero);
        Console.WriteLine($"Primero: {primero}");
```

#### 5.12.6. Builder Pattern para Rendimiento

Crear muchas instancias inmutables puede ser costoso. Para operaciones en lote, usa **builders**:

```csharp
using System.Collections.Immutable;

// Código ejecutable
        // ✗ INEFICIENTE: crear nueva instancia en cada iteración
        ImmutableList<int> lista = ImmutableList.Create<int>();
        for (int i = 0; i < 1000; i++)
        {
            lista = lista. Add(i); // Crea nueva instancia cada vez
        }
        
        // ✓ EFICIENTE: usar builder
        ImmutableList<int>. Builder builder = ImmutableList.CreateBuilder<int>();
        for (int i = 0; i < 1000; i++)
        {
            builder.Add(i); // Modifica builder (mutable)
        }
        ImmutableList<int> listaFinal = builder.ToImmutable(); // Convierte a inmutable
        
        Console.WriteLine($"Lista con {listaFinal.Count} elementos");
```

#### 5.12.7. Casos de Uso

**Historial de cambios (Undo/Redo):**

```csharp
using System.Collections.Immutable;
class Editor
{
    private ImmutableStack<string> historialAtras = ImmutableStack.Create<string>();
    private ImmutableStack<string> historialAdelante = ImmutableStack. Create<string>();
    private string textoActual = "";
    public void EscribirTexto(string nuevoTexto)
    {
        historialAtras = historialAtras.Push(textoActual);
        textoActual = nuevoTexto;
        historialAdelante = ImmutableStack.Create<string>(); // Limpiar
    }
    public void Deshacer()
    {
        if (historialAtras. IsEmpty)
        {
            Console.WriteLine("No hay nada que deshacer");
            return;
        }
        historialAdelante = historialAdelante.Push(textoActual);
        historialAtras = historialAtras.Pop(out string textoAnterior);
        textoActual = textoAnterior;
    }
    public void Rehacer()
    {
        if (historialAdelante. IsEmpty)
        {
            Console.WriteLine("No hay nada que rehacer");
            return;
        }
        historialAtras = historialAtras.Push(textoActual);
        historialAdelante = historialAdelante.Pop(out string textoSiguiente);
        textoActual = textoSiguiente;
    }
    public void MostrarTexto()
    {
        Console.WriteLine($"Texto actual: '{textoActual}'");
    }
}

// Código ejecutable
        Editor editor = new Editor();
        
        editor.MostrarTexto();
        
        editor.EscribirTexto("Hola");
        editor.MostrarTexto();
        
        editor.EscribirTexto("Hola Mundo");
        editor.MostrarTexto();
        
        editor.EscribirTexto("Hola Mundo!");
        editor.MostrarTexto();
        
        editor. Deshacer();
        editor.MostrarTexto();
        
        editor.Deshacer();
        editor.MostrarTexto();
        
        editor.Rehacer();
        editor.MostrarTexto();
```

**Resumen de Colecciones Inmutables:**

| Colección                  | Equivalente Mutable | Operaciones Principales       |
| -------------------------- | ------------------- | ----------------------------- |
| `ImmutableList<T>`         | `List<T>`           | Add, Remove, Insert, RemoveAt |
| `ImmutableArray<T>`        | `T[]`               | (solo creación)               |
| `ImmutableDictionary<K,V>` | `Dictionary<K,V>`   | Add, Remove, SetItem          |
| `ImmutableHashSet<T>`      | `HashSet<T>`        | Add, Remove, Union, Intersect |
| `ImmutableSortedSet<T>`    | `SortedSet<T>`      | Add, Remove (mantiene orden)  |
| `ImmutableStack<T>`        | `Stack<T>`          | Push, Pop                     |
| `ImmutableQueue<T>`        | `Queue<T>`          | Enqueue, Dequeue              |

---

### 5.13. Colecciones Concurrentes (Thread-Safe)

Las colecciones concurrentes están diseñadas específicamente para **escenarios multi-hilo** donde múltiples hilos acceden y modifican la colección simultáneamente.

#### 5.13.1. ¿Qué son las colecciones concurrentes?

**Problema con colecciones normales en multi-hilo:**

```csharp
using System.Threading. Tasks;

// Código ejecutable
        List<int> lista = new List<int>();
        
        // ✗ PELIGRO: List<T> NO es thread-safe
        Parallel.For(0, 10000, i =>
        {
            lista.Add(i); // ¡Puede causar excepciones o corrupción!
        });
        
        Console.WriteLine($"Elementos agregados: {lista.Count}");
        // Resultado impredecible: puede ser < 10000 o incluso lanzar excepción
```

**Posibles problemas:**
- ✗ **Excepciones**: `ArgumentException`, `IndexOutOfRangeException`
- ✗ **Corrupción de datos**: Estado inconsistente
- ✗ **Race conditions**: Resultados impredecibles
- ✗ **Deadlocks**: Bloqueos mutuos

**Solución: Colecciones Concurrentes**

Las colecciones concurrentes del namespace `System.Collections.Concurrent` están diseñadas para ser **thread-safe sin necesidad de sincronización externa**.

**Características:**
- ✓ Thread-safe por diseño
- ✓ Sin necesidad de locks manuales
- ✓ Operaciones atómicas
- ✓ Optimizadas para escenarios concurrentes
- ✓ Sin bloqueos en la mayoría de lecturas

#### 5.13.2. ConcurrentBag<T>

**Colección desordenada thread-safe**, ideal para escenarios productor-consumidor donde el orden no importa. 

```csharp
using System.Collections.Concurrent;
using System. Threading.Tasks;

// Código ejecutable
        ConcurrentBag<int> bag = new ConcurrentBag<int>();
        
        // ✓ SEGURO: múltiples hilos agregando simultáneamente
        Parallel.For(0, 10000, i =>
        {
            bag.Add(i); // Thread-safe
        });
        
        Console.WriteLine($"Elementos agregados: {bag.Count}"); // Siempre 10000
        
        // Consumir elementos
        int suma = 0;
        while (bag.TryTake(out int numero))
        {
            suma += numero;
        }
        
        Console.WriteLine($"Suma:  {suma}");
        Console.WriteLine($"Elementos restantes: {bag.Count}"); // 0
```

#### 5.13.3. ConcurrentQueue<T>

**Cola FIFO thread-safe**. 

```csharp
using System.Collections.Concurrent;
using System.Threading.Tasks;

// Código ejecutable
        ConcurrentQueue<string> cola = new ConcurrentQueue<string>();
        
        // Productor:  agregar elementos
        Task productor = Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                cola.Enqueue($"Elemento {i}");
                Task.Delay(10).Wait(); // Simular trabajo
            }
        });
        
        // Consumidor:  procesar elementos
        Task consumidor = Task.Run(() =>
        {
            int procesados = 0;
            while (procesados < 100)
            {
                if (cola.TryDequeue(out string elemento))
                {
                    Console.WriteLine($"Procesado: {elemento}");
                    procesados++;
                }
                else
                {
                    Task.Delay(20).Wait(); // Esperar más elementos
                }
            }
        });
        
        Task.WaitAll(productor, consumidor);
        Console.WriteLine($"\nElementos restantes: {cola.Count}");
```

#### 5.13.4. ConcurrentStack<T>

**Pila LIFO thread-safe**.

```csharp
using System.Collections.Concurrent;
using System.Threading.Tasks;

// Código ejecutable
        ConcurrentStack<int> pila = new ConcurrentStack<int>();
        
        // Múltiples hilos agregando
        Parallel.For(0, 100, i =>
        {
            pila.Push(i);
        });
        
        Console.WriteLine($"Elementos en pila: {pila.Count}");
        
        // Múltiples hilos consumiendo
        int procesados = 0;
        Parallel.For(0, 100, i =>
        {
            if (pila.TryPop(out int valor))
            {
                Interlocked.Increment(ref procesados);
            }
        });
        
        Console.WriteLine($"Elementos procesados: {procesados}");
        Console.WriteLine($"Elementos restantes: {pila.Count}");
```

#### 5.13.5. ConcurrentDictionary<TKey, TValue>

**Diccionario thread-safe** con operaciones atómicas especiales.

```csharp
using System.Collections.Concurrent;
using System.Threading.Tasks;

// Código ejecutable
        ConcurrentDictionary<int, string> dict = new ConcurrentDictionary<int, string>();
        
        // Operaciones básicas thread-safe
        dict.TryAdd(1, "uno");
        dict.TryAdd(2, "dos");
        dict.TryAdd(3, "tres");
        
        // TryGetValue:  obtener valor de forma segura
        if (dict.TryGetValue(2, out string valor))
        {
            Console.WriteLine($"Clave 2: {valor}");
        }
        
        // TryUpdate: actualizar solo si el valor actual coincide
        bool actualizado = dict.TryUpdate(2, "DOS", "dos");
        Console.WriteLine($"Actualizado: {actualizado}");
        
        // TryRemove: eliminar y obtener valor
        if (dict.TryRemove(1, out string valorEliminado))
        {
            Console.WriteLine($"Eliminado: {valorEliminado}");
        }
        
        // AddOrUpdate: agregar o actualizar de forma atómica
        string resultado = dict.AddOrUpdate(
            key: 2,
            addValue: "nuevo",
            updateValueFactory: (key, oldValue) => oldValue.ToUpper()
        );
        Console.WriteLine($"Resultado AddOrUpdate: {resultado}");
        
        // GetOrAdd: obtener o agregar si no existe
        string valor2 = dict.GetOrAdd(4, "cuatro");
        Console.WriteLine($"GetOrAdd: {valor2}");
        
        Console.WriteLine("\nDiccionario final:");
        foreach (var par in dict)
        {
            Console.WriteLine($"  {par. Key} => {par.Value}");
        }
```

**Ejemplo práctico: Contador de palabras concurrente**

```csharp
using System.Collections.Concurrent;
using System.Threading.Tasks;

// Código ejecutable
        string[] documentos = 
        {
            "el gato come pescado",
            "el perro come carne",
            "el gato y el perro juegan",
            "el pescado nada en el agua"
        };
        
        ConcurrentDictionary<string, int> frecuencias = new ConcurrentDictionary<string, int>();
        
        // Procesar documentos en paralelo
        Parallel.ForEach(documentos, documento =>
        {
            string[] palabras = documento.Split(' ');
            
            foreach (string palabra in palabras)
            {
                // AddOrUpdate de forma atómica
                frecuencias.AddOrUpdate(
                    key: palabra,
                    addValue: 1,
                    updateValueFactory: (key, oldValue) => oldValue + 1
                );
            }
        });
        
        Console.WriteLine("=== Frecuencia de Palabras ===");
        foreach (var par in frecuencias. OrderByDescending(p => p.Value))
        {
            Console. WriteLine($"{par.Key}: {par.Value}");
        }
```

#### 5.13.6. BlockingCollection<T>

**Colección con bloqueo** para escenarios productor-consumidor clásicos.

```csharp
using System.Collections.Concurrent;
using System.Threading. Tasks;

// Código ejecutable
        BlockingCollection<int> coleccion = new BlockingCollection<int>(boundedCapacity: 10);
        
        // Productor
        Task productor = Task.Run(() =>
        {
            for (int i = 0; i < 20; i++)
            {
                coleccion.Add(i); // Bloquea si está llena
                Console.WriteLine($"Producido: {i}");
                Task.Delay(100).Wait();
            }
            coleccion.CompleteAdding(); // Marcar como completo
        });
        
        // Consumidor
        Task consumidor = Task.Run(() =>
        {
            foreach (int item in coleccion.GetConsumingEnumerable())
            {
                Console.WriteLine($"  Consumido: {item}");
                Task.Delay(200).Wait();
            }
        });
        
        Task.WaitAll(productor, consumidor);
        Console.WriteLine("\n¡Completado!");
```

#### 5.13.7. Cuándo Usar Colecciones Concurrentes

**✓ USAR cuando:**
- Múltiples hilos acceden/modifican la colección simultáneamente
- Patrones productor-consumidor
- Aplicaciones multi-hilo (servidores, procesamiento paralelo)
- Necesitas operaciones atómicas

**✗ NO USAR cuando:**
- Acceso de un solo hilo (overhead innecesario)
- Rendimiento crítico en single-thread (colecciones normales son más rápidas)
- No hay concurrencia real

**Tabla de Decisión:**

| Colección Normal  | Colección Concurrente       | Uso Concurrente                  |
| ----------------- | --------------------------- | -------------------------------- |
| `List<T>`         | `ConcurrentBag<T>`          | Colección desordenada            |
| `Queue<T>`        | `ConcurrentQueue<T>`        | Cola FIFO                        |
| `Stack<T>`        | `ConcurrentStack<T>`        | Pila LIFO                        |
| `Dictionary<K,V>` | `ConcurrentDictionary<K,V>` | Mapeo clave-valor                |
| -                 | `BlockingCollection<T>`     | Productor-consumidor con bloqueo |

---

### 5.14. Jerarquía y Diagramas de Colecciones

#### 5.14.1. Jerarquía de Interfaces de Colecciones

```
                    IEnumerable<T>
                          │
                          ├─────────────────┐
                          │                 │
                    ICollection<T>    IReadOnlyCollection<T>
                          │                 │
        ┌─────────────────┼─────────┐      │
        │                 │         │      │
    IList<T>          ISet<T>   IDictionary<K,V>   IReadOnlyList<T>
        │                 │         │               │
        │                 │         │               │
    List<T>          HashSet<T>  Dictionary<K,V>   (vista)
    LinkedList<T>    SortedSet<T> SortedDictionary<K,V>
```

**Explicación:**
- Las interfaces definen **contratos** de funcionalidad
- Las clases concretas **implementan** estas interfaces
- `IEnumerable<T>` es la base:  permite iteración con `foreach`
- `ICollection<T>` añade:  Count, Add, Remove, Contains
- `IList<T>` añade: acceso por índice `[]`
- `ISet<T>` añade: operaciones de conjuntos
- `IDictionary<K,V>` añade: acceso por clave

#### 5.14.2. Listado Completo de Colecciones Genéricas

1. **Interfaces**: 
   - `IEnumerable<T>`: Iteración básia
   - `ICollection<T>`: Operaciones de colección
   - `IList<T>`: Lista con índice
   - `ISet<T>`: Conjunto sin duplicados
   - `IDictionary<K,V>`: Pares clave-valor

2. **Clases Concretas**:
   - `List<T>`: Lista dinámica
   - `LinkedList<T>`: Lista enlazada
   - `HashSet<T>`: Conjunto hash
   - `SortedSet<T>`: Conjunto ordenado
   - `Dictionary<K,V>`: Diccionario hash
   - `SortedDictionary<K,V>`: Diccionario ordenado
   - `Queue<T>`: Cola FIFO
   - `Stack<T>`: Pila LIFO

#### 5.14.3. Listado con Colecciones Especializadas

**Colecciones adicionales:**

- **`Collection<T>`**: Clase base para colecciones personalizadas
- **`ObservableCollection<T>`**: Notifica cambios (WPF/XAML)
- **`KeyedCollection<K,V>`**: Colección donde los ítems contienen su clave
- **`ReadOnlyCollection<T>`**: Wrapper de solo lectura
- **`SortedList<K,V>`**: Lista ordenada por clave (híbrido)

#### 5.14.4. Diagrama de Colecciones por Namespace

```
System.Collections.Generic
│
├─ List<T>
├─ Dictionary<TKey, TValue>
├─ HashSet<T>
├─ Queue<T>
├─ Stack<T>
├─ LinkedList<T>
├─ SortedSet<T>
└─ SortedDictionary<TKey, TValue>

System.Collections.Concurrent
│
├─ ConcurrentBag<T>
├─ ConcurrentQueue<T>
├─ ConcurrentStack<T>
├─ ConcurrentDictionary<TKey, TValue>
└─ BlockingCollection<T>

System.Collections.Immutable
│
├─ ImmutableList<T>
├─ ImmutableArray<T>
├─ ImmutableDictionary<TKey, TValue>
├─ ImmutableHashSet<T>
├─ ImmutableSortedSet<T>
├─ ImmutableStack<T>
└─ ImmutableQueue<T>

System.Collections.ObjectModel
│
├─ Collection<T>
├─ ReadOnlyCollection<T>
├─ ObservableCollection<T>
└─ KeyedCollection<TKey, TItem>

System.Collections (Legacy - Evitar)
│
├─ ArrayList
├─ Hashtable
├─ Queue
└─ Stack
```

---

### 5.15. Guía de Selección de Colecciones

Para seleccionar el tipo de dato avanzado adecuado, no solo debemos mirar qué hace, sino cómo lo hace. Mientras que una `List<T>` es excelente para acceso directo por índice, es ineficiente para insertar elementos al inicio (ya que debe desplazar toda la información). Por el contrario, un `Dictionary<K, V>` ofrece búsquedas instantáneas pero consume más memoria. Elegir la colección correcta basándose en la complejidad de la operación es clave para el rendimiento del programa.

#### 5.15.1. Flujo de Decisión

1. **Inicio**: Evalúa qué tipo de estructura necesitas
2. **Preguntas clave**:  El diagrama te guía con preguntas sobre:
   - ¿Necesitas pares clave-valor?
   - ¿Elementos únicos?
   - ¿Orden específico (FIFO/LIFO)?
   - ¿Acceso por índice? 
   - ¿Thread-safety?
3. **Resultado**: Te indica la colección óptima


```
──────────────────────────────────────────────────────────────────────────────
          📦 COLECCIONES EN C# — System.Collections.
──────────────────────────────────────────────────────────────────────────────
INICIO
│
├── ¿Necesitas buscar elementos por CLAVE? (map/diccionario)
│     │
│     ├── SÍ →
│     │      │
│     │      ├── ¿Importa el ORDEN de las claves?
│     │      │      │
│     │      │      ├── SÍ →
│     │      │      │      ¿Quieres que estén ORDENADAS automáticamente?
│     │      │      │          │
│     │      │      │          ├── SÍ → SortedDictionary<TKey, TValue>
│     │      │      │          │         (Claves siempre ordenadas por orden natural: árbol)
│     │      │      │          │
│     │      │      │          └── NO → OrderedDictionary
│     │      │      │                    (Mantiene orden de inserción)
│     │      │      │
│     │      │      └── NO → Dictionary<TKey, TValue>
│     │      │              (Clave→valor rápido; sin orden)
│     │      │
│     │      └── (FIN rama diccionarios)
│     │
│     └── NO →
│            │
│            ├── ¿Los elementos pueden REPETIRSE?
│            │      │
│            │      ├── SÍ →
│            │      │      │
│            │      │      ├── ¿Importa el ORDEN?
│            │      │      │      │
│            │      │      │      ├── NO → List<T>
│            │      │      │      │         (Lista general, acceso rápido)
│            │      │      │      │
│            │      │      │      ├── SÍ, orden de inserción →
│            │      │      │      │         List<T>
│            │      │      │      │         (Mantiene el orden natural)
│            │      │      │      │
│            │      │      │      ├── SÍ, orden FIFO →
│            │      │      │      │         Queue<T>
│            │      │      │      │         (Primero entra, primero sale)
│            │      │      │      │
│            │      │      │      └── SÍ, orden LIFO →
│            │      │      │                Stack<T>
│            │      │      │                (Último entra, primero sale)
│            │      │      │
│            │      │      └── (FIN rama duplicables)
│            │      │
│            │      └── NO (no permite duplicados) →
│            │             │
│            │             ├── ¿Necesitas los elementos ORDENADOS?
│            │             │      │
│            │             │      ├── SÍ → SortedSet<T>
│            │             │      │         (Set ordenado automáticamente por orden natural)
│            │             │      │
│            │             │      └── NO → HashSet<T>
│            │             │                (Set rápido sin orden)
│            │             │
│            │             └── (FIN rama no duplicables)
│            │
│            └── (FIN rama sin claves)
│
├── ¿Necesitas un tamaño FIJO y acceso por ÍNDICE?
│     │
│     ├── SÍ → Array (T[])
│     │         (Muy rápido, tamaño fijo)
│     └── NO
│
├── ¿Necesitas inserciones rápidas en extremos?
│     │
│     ├── SÍ → LinkedList<T>
│     │         (Rápido en añadir/quitar nodos al estar enlazados)
│     └── NO
│
├── ¿Ejecución MULTIHILO?
│     │
│     ├── SÍ →
│     │      • ConcurrentQueue<T>  (FIFO concurrente)
│     │      • ConcurrentStack<T>  (LIFO concurrente)
│     │      • ConcurrentBag<T>    (Bolsa no ordenada multi-hilo)
│     │      • BlockingCollection<T> (Controla productores/consumidores)
│     │      • ConcurrentDictionary<K,V> (Diccionario concurrente)
│     │
│     └── NO
│
├── ¿Necesitas que sean INMUTABLES?
│     │
│     ├── SÍ →
│     │      • ImmutableList<T>  (Lista inmutable)
│     │      • ImmutableArray<T> (Array inmutable)
│     │      • ImmutableHashSet<T> (Set inmutable sin orden)
│     │      • ImmutableSortedSet<T> (Set inmutable ordenado natural)
│     │      • ImmutableDictionary<K,V> (Diccionario inmutable) 
│     │      • ImmutableQueue<T> (Cola inmutable)
│     │      • ImmutableStack<T> (Pila inmutable)
│     │
│     └── NO
│
└── FIN

```

#### 5.15.3. Tabla de Decisión Completa

| **Necesidad**                             | **Colección Recomendada**   | **Alternativa**                     |
| ----------------------------------------- | --------------------------- | ----------------------------------- |
| Lista general con acceso por índice       | `List<T>`                   | `ArrayList` (legacy)                |
| Mapeo rápido clave-valor                  | `Dictionary<K,V>`           | `Hashtable` (legacy)                |
| Conjunto sin duplicados                   | `HashSet<T>`                | `SortedSet<T>` (si necesitas orden) |
| Cola FIFO                                 | `Queue<T>`                  | `ConcurrentQueue<T>` (multi-hilo)   |
| Pila LIFO                                 | `Stack<T>`                  | `ConcurrentStack<T>` (multi-hilo)   |
| Lista con inserciones frecuentes en medio | `LinkedList<T>`             | `List<T>` (si inserciones al final) |
| Conjunto ordenado                         | `SortedSet<T>`              | `List<T>` + `Sort()`                |
| Diccionario ordenado por clave            | `SortedDictionary<K,V>`     | `SortedList<K,V>`                   |
| Solo lectura (exponer sin modificación)   | `IReadOnlyList<T>`          | `ReadOnlyCollection<T>`             |
| Completamente inmutable                   | `ImmutableList<T>`          | `ImmutableArray<T>`                 |
| Thread-safe (múltiples hilos)             | `ConcurrentDictionary<K,V>` | `ConcurrentBag<T>`                  |
| Productor-consumidor con bloqueo          | `BlockingCollection<T>`     | `ConcurrentQueue<T>`                |
| Notificar cambios (WPF/MAUI)              | `ObservableCollection<T>`   | -                                   |
| Elementos contienen su clave              | `KeyedCollection<K,V>`      | `Dictionary<K,V>`                   |

#### 5.15.4. Comparación de Complejidad (Big O)
| **Operación**               | List<T> | Dictionary<K,V> | HashSet<T> | LinkedList<T> | SortedSet<T> | Queue<T> | Stack<T> |
| --------------------------- | ------- | --------------- | ---------- | ------------- | ------------ | -------- | -------- |
| **Acceso por índice/clave** | O(1)    | O(1)            | N/A        | O(n)          | N/A          | N/A      | N/A      |
| **Búsqueda**                | O(n)    | O(1)            | O(1)       | O(n)          | O(log n)     | O(n)     | O(n)     |
| **Inserción al final**      | O(1)*   | O(1)            | O(1)       | O(1)          | O(log n)     | O(1)     | O(1)     |
| **Inserción al inicio**     | O(n)    | N/A             | N/A        | O(1)          | O(log n)     | N/A      | N/A      |
| **Inserción en medio**      | O(n)    | O(1)            | O(1)       | O(1)**        | O(log n)     | N/A      | N/A      |
| **Eliminación**             | O(n)    | O(1)            | O(1)       | O(1)**        | O(log n)     | O(1)     | O(1)     |
| **Enumeración**             | O(n)    | O(n)            | O(n)       | O(n)          | O(n)         | O(n)     | O(n)     |
| **Contiene**                | O(n)    | O(1)            | O(1)       | O(n)          | O(log n)     | O(n)     | O(n)     |
| **Ordenado**                | No      | No              | No         | No            | **Sí**       | No       | No       |

\* **O(1) amortizado** - Puede ser O(n) si necesita redimensionar el array interno  
\*\* **Si tienes referencia al nodo** - De lo contrario, O(n) para encontrar el nodo

#### 5.15.5. Casos de Uso Prácticos por Escenario

**Escenario 1: Carrito de Compras**

```csharp
// Opción A: Si cada producto aparece una sola vez con cantidad
Dictionary<int, CarritoItem> carrito = new Dictionary<int, CarritoItem>();
// Clave: ProductoId, Valor: { Producto, Cantidad }

// Opción B: Si pueden haber múltiples instancias del mismo producto
List<Producto> carrito = new List<Producto>();

```

**Escenario 2: Historial de Navegación (Atrás/Adelante)**

```csharp
Stack<string> historialAtras = new Stack<string>();
Stack<string> historialAdelante = new Stack<string>();

```

**Escenario 3: Cola de Impresión**

```csharp
Queue<Documento> colaImpresion = new Queue<Documento>();

```

**Escenario 4: Eliminar Duplicados de una Lista**

```csharp
List<int> numerosConDuplicados = new List<int> { 1, 2, 2, 3, 3, 3, 4 };
HashSet<int> numerosUnicos = new HashSet<int>(numerosConDuplicados);
// O de vuelta a lista:  List<int> resultado = numerosUnicos.ToList();

```

**Escenario 5: Caché de Configuración**

```csharp
Dictionary<string, string> configuracion = new Dictionary<string, string>();

```

**Escenario 6: Rankings Ordenados por Puntuación**

```csharp
SortedDictionary<int, string> ranking = new SortedDictionary<int, string>();
// Clave: puntuación, Valor: nombre del jugador

```

**Escenario 7: Log de Eventos (Solo Agregar al Final)**

```csharp
List<EventoLog> log = new List<EventoLog>();

```

**Escenario 8: Contador de Frecuencias (Palabras, Caracteres, etc.)**

```csharp
Dictionary<string, int> frecuencias = new Dictionary<string, int>();

```

**Escenario 9: Visitantes Únicos (IPs, Usuarios, etc.)**

```csharp
HashSet<string> visitantesUnicos = new HashSet<string>();

```

**Escenario 10: Notificaciones en Tiempo Real (WPF/MAUI)**

```csharp
ObservableCollection<Notificacion> notificaciones = new ObservableCollection<Notificacion>();

```

**Escenario 11: Procesamiento Paralelo de Datos**

```csharp
ConcurrentBag<Resultado> resultados = new ConcurrentBag<Resultado>();

Parallel.ForEach(datos, dato =>
{
    var resultado = Procesar(dato);
    resultados.Add(resultado);
});

```

**Escenario 12: Historial de Cambios (Undo/Redo)**

```csharp
ImmutableStack<Estado> historial = ImmutableStack<Estado>.Empty;

```

---

### 5.16. Resumen de Todas las Colecciones

#### 5.16.1. Tabla Resumen Maestra

| **Colección**                 | **Namespace** | **Ordenada** | **Duplicados** | **Indexada**       | **Thread-Safe** | **Complejidad**      | **Uso Principal**       |
| ----------------------------- | ------------- | ------------ | -------------- | ------------------ | --------------- | -------------------- | ----------------------- |
| **List<T>**                   | Generic       | No           | Sí             | Sí                 | No              | O(1) acceso          | Lista general           |
| **Dictionary<K,V>**           | Generic       | No           | No (claves)    | Por clave          | No              | O(1) búsqueda        | Mapeo clave-valor       |
| **HashSet<T>**                | Generic       | No           | No             | No                 | No              | O(1) búsqueda        | Conjunto único          |
| **Queue<T>**                  | Generic       | FIFO         | Sí             | No                 | No              | O(1) enqueue/dequeue | Cola                    |
| **Stack<T>**                  | Generic       | LIFO         | Sí             | No                 | No              | O(1) push/pop        | Pila                    |
| **LinkedList<T>**             | Generic       | No           | Sí             | No                 | No              | O(1) inserción*      | Inserciones frecuentes  |
| **SortedSet<T>**              | Generic       | Sí           | No             | No                 | No              | O(log n)             | Conjunto ordenado       |
| **SortedDictionary<K,V>**     | Generic       | Sí (claves)  | No (claves)    | Por clave          | No              | O(log n)             | Mapeo ordenado          |
| **SortedList<K,V>**           | Generic       | Sí (claves)  | No (claves)    | Por índice y clave | No              | O(log n) búsqueda    | Híbrido lista/dict      |
| **ConcurrentDictionary<K,V>** | Concurrent    | No           | No (claves)    | Por clave          | **Sí**          | O(1)                 | Mapeo thread-safe       |
| **ConcurrentBag<T>**          | Concurrent    | No           | Sí             | No                 | **Sí**          | O(1)                 | Colección thread-safe   |
| **ConcurrentQueue<T>**        | Concurrent    | FIFO         | Sí             | No                 | **Sí**          | O(1)                 | Cola thread-safe        |
| **ConcurrentStack<T>**        | Concurrent    | LIFO         | Sí             | No                 | **Sí**          | O(1)                 | Pila thread-safe        |
| **BlockingCollection<T>**     | Concurrent    | -            | Sí             | No                 | **Sí**          | O(1)                 | Productor-consumidor    |
| **ImmutableList<T>**          | Immutable     | No           | Sí             | Sí                 | **Sí**          | O(log n)             | Lista inmutable         |
| **ImmutableArray<T>**         | Immutable     | No           | Sí             | Sí                 | **Sí**          | O(1) acceso          | Array inmutable         |
| **ImmutableDictionary<K,V>**  | Immutable     | No           | No (claves)    | Por clave          | **Sí**          | O(log n)             | Mapeo inmutable         |
| **ImmutableHashSet<T>**       | Immutable     | No           | No             | No                 | **Sí**          | O(log n)             | Conjunto inmutable      |
| **ImmutableSortedSet<T>**     | Immutable     | Sí           | No             | No                 | **Sí**          | O(log n)             | Conjunto ord. inmutable |
| **ImmutableStack<T>**         | Immutable     | LIFO         | Sí             | No                 | **Sí**          | O(1)                 | Pila inmutable          |
| **ImmutableQueue<T>**         | Immutable     | FIFO         | Sí             | No                 | **Sí**          | O(1) amort.          | Cola inmutable          |
| **ObservableCollection<T>**   | ObjectModel   | No           | Sí             | Sí                 | No              | O(1) acceso          | Notificaciones WPF      |
| **ReadOnlyCollection<T>**     | ObjectModel   | No           | Sí             | Sí                 | No              | O(1) acceso          | Wrapper solo lectura    |
| **ArrayList**                 | Legacy        | No           | Sí             | Sí                 | No              | O(1) acceso          | **❌ EVITAR**            |
| **Hashtable**                 | Legacy        | No           | No (claves)    | Por clave          | No              | O(1) búsqueda        | **❌ EVITAR**            |

\* Con referencia al nodo

#### 5.16.2. Resumen por Namespace

**System.Collections.Generic (⭐⭐⭐⭐⭐ USAR SIEMPRE)**
- `List<T>` - Lista dinámica general
- `Dictionary<TKey, TValue>` - Mapeo clave-valor rápido
- `HashSet<T>` - Conjunto sin duplicados
- `Queue<T>` - Cola FIFO
- `Stack<T>` - Pila LIFO
- `LinkedList<T>` - Lista enlazada
- `SortedSet<T>` - Conjunto ordenado
- `SortedDictionary<TKey, TValue>` - Diccionario ordenado
- `SortedList<TKey, TValue>` - Híbrido lista/diccionario

**System.Collections.Concurrent (⭐⭐⭐⭐ Usar en multi-hilo)**
- `ConcurrentDictionary<TKey, TValue>` - Diccionario thread-safe
- `ConcurrentBag<T>` - Colección desordenada thread-safe
- `ConcurrentQueue<T>` - Cola thread-safe
- `ConcurrentStack<T>` - Pila thread-safe
- `BlockingCollection<T>` - Productor-consumidor con bloqueo

**System.Collections.Immutable (⭐⭐⭐ Usar para inmutabilidad)**
- `ImmutableList<T>` - Lista inmutable
- `ImmutableArray<T>` - Array inmutable
- `ImmutableDictionary<TKey, TValue>` - Diccionario inmutable
- `ImmutableHashSet<T>` - Conjunto inmutable
- `ImmutableSortedSet<T>` - Conjunto ordenado inmutable
- `ImmutableStack<T>` - Pila inmutable
- `ImmutableQueue<T>` - Cola inmutable

**System.Collections. ObjectModel (⭐⭐ Casos específicos)**
- `Collection<T>` - Clase base para colecciones personalizadas
- `ReadOnlyCollection<T>` - Wrapper de solo lectura
- `ObservableCollection<T>` - Notificaciones de cambios (WPF/MAUI)
- `KeyedCollection<TKey, TItem>` - Colección con claves embebidas

**System.Collections (❌ LEGACY - EVITAR)**
- `ArrayList` - ❌ Usar `List<T>`
- `Hashtable` - ❌ Usar `Dictionary<TKey, TValue>`
- `Queue` - ❌ Usar `Queue<T>`
- `Stack` - ❌ Usar `Stack<T>`
- `SortedList` - ❌ Usar `SortedList<TKey, TValue>`

#### 5.16.3. Recomendaciones Finales

**✓ HACER:**

1. **Siempre usa colecciones genéricas** (`List<T>`, `Dictionary<K,V>`, etc.)
2. **Especifica capacidad inicial** si conoces el tamaño aproximado
   ```csharp
   List<int> lista = new List<int>(1000); // Mejor rendimiento
   
```
3. **Elige la colección según el caso de uso** (no siempre `List<T>`)
4. **Usa colecciones concurrentes** para escenarios multi-hilo
5. **Usa colecciones inmutables** para thread-safety y funciones puras
6. **Expón colecciones como solo lectura** desde tus clases
   ```csharp
   public IReadOnlyList<Item> Items => _items.AsReadOnly();
   
```
7. **Considera el rendimiento** para grandes volúmenes (ver tabla Big O)

**✗ EVITAR:**

1. **NO uses colecciones no genéricas** (`ArrayList`, `Hashtable`, etc.)
2. **NO uses `List<T>` para todo** sin evaluar alternativas
3. **NO expongas colecciones mutables** directamente

```csharp
   // ✗ MAL
   public List<Item> Items { get; set; }
   
   // ✓ BIEN
   public IReadOnlyList<Item> Items => _items;
   
```
4. **NO uses colecciones normales en multi-hilo** sin sincronización
5. **NO ignores la capacidad inicial** en bucles grandes
6. **NO uses `Dictionary` si no necesitas búsqueda por clave**
7. **NO uses `LinkedList` si necesitas acceso por índice frecuente**

#### 5.16.4. Checklist de Selección Rápida

**Antes de elegir una colección, pregúntate:**

- [ ] ¿Necesito acceso por índice?  → `List<T>`
- [ ] ¿Necesito búsqueda rápida por clave? → `Dictionary<K,V>`
- [ ] ¿Necesito elementos únicos? → `HashSet<T>`
- [ ] ¿Necesito orden FIFO? → `Queue<T>`
- [ ] ¿Necesito orden LIFO?  → `Stack<T>`
- [ ] ¿Necesito elementos ordenados? → `SortedSet<T>` o `SortedDictionary<K,V>`
- [ ] ¿Necesito inserciones frecuentes en medio? → `LinkedList<T>`
- [ ] ¿Múltiples hilos?  → `Concurrent*`
- [ ] ¿Inmutabilidad?  → `Immutable*`
- [ ] ¿Solo lectura? → `IReadOnly*` o `ReadOnlyCollection<T>`

---

## 6. Formateadores y Localización

### 6.1. Introducción

La **localización** y el **formateo** permiten que las aplicaciones se adapten a diferentes culturas y regiones, mostrando fechas, números, monedas y textos en el formato apropiado para cada usuario. 

### 6.2. CultureInfo

**`CultureInfo`** representa información sobre una cultura específica (idioma, país, formato de fecha, moneda, etc.).

```csharp
using System.Globalization;

// Código ejecutable
        // Cultura actual del sistema
        CultureInfo culturaActual = CultureInfo. CurrentCulture;
        Console.WriteLine($"Cultura actual: {culturaActual.Name}");
        Console.WriteLine($"Nombre en inglés: {culturaActual. EnglishName}");
        Console.WriteLine($"Nombre nativo: {culturaActual. NativeName}");
        
        // Crear culturas específicas
        CultureInfo culturaEspañola = new CultureInfo("es-ES"); // España
        CultureInfo culturaMexicana = new CultureInfo("es-MX"); // México
        CultureInfo culturaUSA = new CultureInfo("en-US"); // Estados Unidos
        CultureInfo culturaFrancia = new CultureInfo("fr-FR"); // Francia
        
        Console.WriteLine($"\nEspaña: {culturaEspañola.DisplayName}");
        Console.WriteLine($"México: {culturaMexicana. DisplayName}");
        Console.WriteLine($"USA: {culturaUSA.DisplayName}");
        Console.WriteLine($"Francia: {culturaFrancia. DisplayName}");
```

### 6.3. Formateo de Números

```csharp
using System. Globalization;

// Código ejecutable
        double numero = 1234567.89;
        
        CultureInfo es = new CultureInfo("es-ES");
        CultureInfo en = new CultureInfo("en-US");
        CultureInfo fr = new CultureInfo("fr-FR");
        
        Console.WriteLine("=== Formateo de Números ===");
        // N significa que es un Number, y el 2, el número de decimales
        Console.WriteLine($"España:   {numero. ToString("N2", es)}");
        Console.WriteLine($"USA:     {numero.ToString("N2", en)}");
        Console.WriteLine($"Francia:  {numero.ToString("N2", fr)}");
        
        // Moneda
        Console.WriteLine("\n=== Formateo de Moneda ===");
        // C, significa Moneda, y 2 puede ser el úmero de decimales
        Console.WriteLine($"España:  {numero.ToString("C", es)}");
        Console.WriteLine($"USA:     {numero.ToString("C2", en)}");
        Console.WriteLine($"Francia: {numero.ToString("C", fr)}");
        
        // Porcentaje
        double porcentaje = 0.157;
        Console.WriteLine("\n=== Formateo de Porcentaje ===");
        // P significa porcetaje y 2 el número de decimales
        Console.WriteLine($"España:  {porcentaje.ToString("P2", es)}");
        Console.WriteLine($"USA:     {porcentaje.ToString("P2", en)}");
```

### 6.4. Formateo de Fechas

```csharp
using System.Globalization;

// Código ejecutable
        DateTime fecha = new DateTime(2024, 12, 25, 15, 30, 0);
        
        CultureInfo es = new CultureInfo("es-ES");
        CultureInfo en = new CultureInfo("en-US");
        CultureInfo ja = new CultureInfo("ja-JP");
        
        Console. WriteLine("=== Fecha Larga ===");
        // D es fecha larga
        Console.WriteLine($"España: {fecha.ToString("D", es)}");
        Console.WriteLine($"USA:     {fecha.ToString("D", en)}");
        Console.WriteLine($"Japón:  {fecha.ToString("D", ja)}");
        
        Console.WriteLine("\n=== Fecha Corta ===");
        Console.WriteLine($"España: {fecha.ToString("d", es)}");
        Console.WriteLine($"USA:    {fecha.ToString("d", en)}");
        Console.WriteLine($"Japón:  {fecha.ToString("d", ja)}");
        
        Console.WriteLine("\n=== Hora ===");
        Console.WriteLine($"España: {fecha.ToString("T", es)}");
        Console.WriteLine($"USA:    {fecha.ToString("T", en)}");
```

### 6.5. Métodos de Extensión para Formateo

```csharp
using System.Globalization;
public static class ExtensionesFormateo
{
    public static string ToLocalDate(this DateTime fecha)
    {
        return fecha. ToString("d", CultureInfo. CurrentCulture);
    }
    public static string ToLocalMoney(this decimal cantidad)
    {
        return cantidad.ToString("C", CultureInfo.CurrentCulture);
    }
    public static string ToSpanishDate(this DateTime fecha)
    {
        CultureInfo spanish = new CultureInfo("es-ES");
        return fecha.ToString("D", spanish);
    }
    public static string ToEuroMoney(this decimal cantidad)
    {
        CultureInfo spanish = new CultureInfo("es-ES");
        return cantidad.ToString("C", spanish);
    }
}

// Código ejecutable
        DateTime hoy = DateTime.Now;
        decimal precio = 1234.56m;
        
        Console.WriteLine($"Fecha local: {hoy.ToLocalDate()}");
        Console.WriteLine($"Fecha en español: {hoy.ToSpanishDate()}");
        Console.WriteLine($"Precio local: {precio.ToLocalMoney()}");
        Console.WriteLine($"Precio en euros: {precio.ToEuroMoney()}");
```

## 7. Buenas Prácticas y Recomendaciones

### 7.1. Colecciones

- ✓ Usa colecciones genéricas siempre
- ✓ Especifica capacidad inicial si es conocida
- ✓ Elige la colección apropiada (no siempre `List<T>`)
- ✓ Usa `IReadOnly*` para exponer coleccione
- ✓ Usa colecciones concurrentes en multi-hilo
- ✓ Usa colecciones inmutables para thread-safety
- ✗ Evita colecciones no genéricas (legacy)
- ✗ No expongas colecciones mutables directamente

### 7.2. Programación Funcional

- ✓ Usa lambdas para código conciso
- ✓ Prefiere funciones puras cuando sea posible
- ✓ Usa `Func<>` y `Action<>` en lugar de delegates personalizados
- ✓ Aprovecha métodos de extensión
- ✗ Evita lambdas complejas (extraer a métodos)
- ✗ No abuses de closures complejos

### 7.3. Comparación y Ordenación

- ✓ Implementa `IComparable<T>` para orden natural
- ✓ Usa `IComparer<T>` para órdenes alternativos
- ✓ Implementa `IEquatable<T>` para comparación eficiente
- ✓ Sobrescribe `GetHashCode()` al implementar `Equals()`
- ✓ Mantén consistencia entre `CompareTo`, `Equals` y operadores
- ✗ No olvides `GetHashCode()` con `Equals()`

### 7.4. Genéricos

- ✓ Usa genéricos para reutilización type-safe
- ✓ Aplica restricciones (`where`) cuando sea necesario
- ✓ Usa varianza (`out`, `in`) apropiadamente
- ✗ No uses genéricos para todo (simplicidad vs flexibilidad)



## Autor

Codificado con :sparkling_heart: por [José Luis González Sánchez](https://twitter.com/JoseLuisGS_)

[![Twitter](https://img.shields.io/twitter/follow/JoseLuisGS_?style=social)](https://twitter.com/JoseLuisGS_)
[![GitHub](https://img.shields.io/github/followers/joseluisgs?style=social)](https://github.com/joseluisgs)
[![GitHub](https://img.shields.io/github/stars/joseluisgs?style=social)](https://github.com/joseluisgs)

### Contacto

<p>
  Cualquier cosa que necesites házmelo saber por si puedo ayudarte 💬.
</p>
<p>
 <a href="https://joseluisgs.dev" target="_blank">
        <img src="https://joseluisgs.github.io/img/favicon.png" 
    height="30">
    </a>  &nbsp;&nbsp;
    <a href="https://github.com/joseluisgs" target="_blank">
        <img src="https://distreau.com/github.svg" 
    height="30">
    </a> &nbsp;&nbsp;
        <a href="https://twitter.com/JoseLuisGS_" target="_blank">
        <img src="https://i.imgur.com/U4Uiaef.png" 
    height="30">
    </a> &nbsp;&nbsp;
    <a href="https://www.linkedin.com/in/joseluisgonsan" target="_blank">
        <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/LinkedIn_logo_initials.png/768px-LinkedIn_logo_initials.png" 
    height="30">
    </a>  &nbsp;&nbsp;
    <a href="https://g.dev/joseluisgs" target="_blank">
        <img loading="lazy" src="https://googlediscovery.com/wp-content/uploads/google-developers.png" 
    height="30">
    </a>  &nbsp;&nbsp;
<a href="https://www.youtube.com/@joseluisgs" target="_blank">
        <img loading="lazy" src="https://upload.wikimedia.org/wikipedia/commons/e/ef/Youtube_logo.png" 
    height="30">
    </a>  
</p>

## Licencia de uso

Este repositorio y todo su contenido está licenciado bajo licencia **Creative Commons**, si desea saber más, vea
la [LICENSE](https://joseluisgs.dev/docs/license/). Por favor si compartes, usas o modificas este proyecto cita a su
autor, y usa las mismas condiciones para su uso docente, formativo o educativo y no comercial.

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Licencia de Creative Commons" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br /><span xmlns:dct="http://purl.org/dc/terms/" property="dct:title">
JoseLuisGS</span>
by <a xmlns:cc="http://creativecommons.org/ns#" href="https://joseluisgs.dev/" property="cc:attributionName" rel="cc:attributionURL">
José Luis González Sánchez</a> is licensed under
a <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons
Reconocimiento-NoComercial-CompartirIgual 4.0 Internacional License</a>.<br />Creado a partir de la obra
en <a xmlns:dct="http://purl.org/dc/terms/" href="https://github.com/joseluisgs" rel="dct:source">https://github.com/joseluisgs</a>.
