using GestionAcademica.Collections.Lista;
using GestionAcademica.Enums;
using GestionAcademica.Exceptions;
using GestionAcademica.Models;
using GestionAcademica.Repositories;
using GestionAcademica.Validators.Common;
using Serilog;

namespace GestionAcademica.Services;

/// <summary>
///     Servicio integral para la gestión de personas (Estudiantes y Docentes).
///     Implementa lógica de negocio mediante un pipeline funcional sobre listas enlazadas.
/// </summary>
public class PersonasService(
    IPersonasRepository repository,
    IValidador<Persona> valEstudiante,
    IValidador<Persona> valDocente) : IPersonasService {
    private readonly ILogger _logger = Log.ForContext<PersonasService>();

    // --- PROPIEDADES Y CONSULTAS BÁSICAS ---

    /// <inheritdoc cref="IPersonasService.TotalPersonas" />
    public int TotalPersonas => repository.GetAll().Size;

    /// <inheritdoc cref="IPersonasService.GetAll" />
    public ILista<Persona> GetAll() {
        _logger.Information("Obteniendo todas las personas.");
        return repository.GetAll();
    }

    // --- MÉTODOS DE FILTRADO Y ORDENAMIENTO ESPECÍFICO ---

    /// <inheritdoc cref="IPersonasService.GetEstudiantesOrderBy" />
    public ILista<Estudiante> GetEstudiantesOrderBy(TipoOrdenamiento ordenamiento = TipoOrdenamiento.Dni) {
        _logger.Information("Obteniendo estudiantes ordenados por {ordenamiento}.", ordenamiento);
        // Obtenemos la lista filtrada por el tipo base y la transformamos (Casting) a Estudiante
        return GetAllOrderBy(ordenamiento, p => p is Estudiante)
            .Select(p => (Estudiante)p);
    }

    /// <inheritdoc cref="IPersonasService.GetDocentesOrderBy" />
    public ILista<Docente> GetDocentesOrderBy(TipoOrdenamiento ordenamiento = TipoOrdenamiento.Dni) {
        _logger.Information("Obteniendo docentes ordenados por {ordenamiento}.", ordenamiento);
        // Reutilizamos la lógica centralizada de ordenamiento y filtramos por Docente
        return GetAllOrderBy(ordenamiento, p => p is Docente)
            .Select(p => (Docente)p);
    }

    // --- GESTIÓN DE INFORMES (PIPELINE FUNCIONAL) ---

    /// <inheritdoc cref="IPersonasService.GenerarInformeEstudiante" />
    public InformeEstudiante GenerarInformeEstudiante(Ciclo? ciclo = null, Curso? curso = null) {
        _logger.Information("Generando informe estadístico de estudiantes con filtro Ciclo: {ciclo}, Curso: {curso}.",
            ciclo, curso);

        // Construimos el pipeline: Ordenar por nota -> Filtrar por Ciclo/Curso
        var estudiantes = GetEstudiantesOrderBy(TipoOrdenamiento.Nota)
            .Where(e => (ciclo == null || e.Ciclo == ciclo) && (curso == null || e.Curso == curso));

        var total = estudiantes.Size;
        if (total == 0) return new InformeEstudiante();

        return new InformeEstudiante {
            PorNota = estudiantes,
            TotalEstudiantes = total,
            // Count y Sum son tus métodos de extensión
            Aprobados = estudiantes.Count(e => e.Calificacion >= 5.0),
            Suspensos = estudiantes.Count(e => e.Calificacion < 5.0),
            NotaMedia = estudiantes.Sum(e => e.Calificacion) / total
        };
    }

    /// <inheritdoc cref="IPersonasService.GenerarInformeDocente" />
    public InformeDocente GenerarInformeDocente(Ciclo? ciclo = null) {
        _logger.Information("Generando informe estadístico de docentes con filtro Ciclo: {ciclo}.", ciclo);

        // Pipeline: Ordenar por experiencia -> Filtrar por ciclo
        var docentes = GetDocentesOrderBy(TipoOrdenamiento.Experiencia)
            .Where(d => ciclo == null || d.Ciclo == ciclo);

        var total = docentes.Size;
        return new InformeDocente {
            PorExperiencia = docentes,
            TotalDocentes = total,
            ExperienciaMedia = total > 0 ? (double)docentes.Sum(d => d.Experiencia) / total : 0
        };
    }

    // --- MOTOR DE ORDENAMIENTO CENTRALIZADO ---

    /// <inheritdoc cref="IPersonasService.GetAllOrderBy" />
    public ILista<Persona> GetAllOrderBy(TipoOrdenamiento orden = TipoOrdenamiento.Dni,
        Predicate<Persona>? filtro = null) {
        _logger.Information("Obteniendo todas las personas ordenadas por {orden} con filtro: {filtro}.", orden,
            filtro != null ? "Sí" : "No");

        var lista = repository.GetAll();

        // 1. Aplicamos el filtro (Where) si existe
        if (filtro != null)
            lista = lista.Where(filtro);

        // 2. Definimos el Comparador (Lambda) según el tipo de ordenamiento
        //    Comparison<T> devuelve: <0 si a<b, 0 si a=b, >0 si a>b
        Comparison<Persona> comparador = orden switch {
            TipoOrdenamiento.Id => (a, b) => a.Id.CompareTo(b.Id),

            TipoOrdenamiento.Dni => (a, b) => string.Compare(a.Dni, b.Dni, StringComparison.Ordinal),

            TipoOrdenamiento.Nombre => (a, b) => string.Compare(a.Nombre, b.Nombre, StringComparison.Ordinal),

            TipoOrdenamiento.Apellidos => (a, b) => string.Compare(a.Apellidos, b.Apellidos, StringComparison.Ordinal),

            TipoOrdenamiento.Ciclo => (a, b) =>
                string.Compare(ObtenerCicloTexto(a), ObtenerCicloTexto(b), StringComparison.Ordinal),

            // Lógica específica para Estudiantes (Nota Descendente)
            // Si no es estudiante, asumimos nota -1 para que quede al final (o al principio según se desee)
            TipoOrdenamiento.Nota => (a, b) => {
                var notaA = a is Estudiante e1 ? e1.Calificacion : -1;
                var notaB = b is Estudiante e2 ? e2.Calificacion : -1;
                // Orden Descendente: b.CompareTo(a)
                return notaB.CompareTo(notaA);
            },

            // Lógica específica para Docentes (Experiencia Descendente)
            TipoOrdenamiento.Experiencia => (a, b) => {
                var expA = a is Docente d1 ? d1.Experiencia : -1;
                var expB = b is Docente d2 ? d2.Experiencia : -1;
                // Orden Descendente
                return expB.CompareTo(expA);
            },

            // Lógica específica para Estudiantes (Curso Ascendente)
            TipoOrdenamiento.Curso => (a, b) => {
                var cursoA = a is Estudiante e1 ? (int)e1.Curso : int.MaxValue;
                var cursoB = b is Estudiante e2 ? (int)e2.Curso : int.MaxValue;
                return cursoA.CompareTo(cursoB);
            },

            _ => (a, b) => a.Id.CompareTo(b.Id)
        };

        // 3. Ejecutamos el ordenamiento usando nuestra extensión personalizada
        return lista.Sort(comparador);
    }

    // --- OPERACIONES CRUD ---

    public Persona Save(Persona persona) {
        _logger.Information("Guardando nueva persona: {persona}", persona);
        // Validación polimórfica según el tipo concreto
        ValidarPersonaConLogicaPolimorfica(persona);
        // Si ya existe, lanzamos una excepción personalizada
        return repository.Create(persona) ?? throw new PersonasException.AlreadyExists(persona.Dni);
    }

    public Persona Update(int id, Persona persona) {
        _logger.Information("Actualizando persona con ID {id}: {persona}", id, persona);
        // Validación polimórfica según el tipo concreto
        ValidarPersonaConLogicaPolimorfica(persona);
        // Si no existe, lanzamos una excepción personalizada
        return repository.Update(id, persona) ?? throw new PersonasException.NotFound(id.ToString());
    }

    public Persona GetById(int id) {
        _logger.Information("Obteniendo persona con ID {id}", id);
        // Si no existe, lanzamos una excepción personalizada
        return repository.GetById(id) ?? throw new PersonasException.NotFound(id.ToString());
    }

    public Persona GetByDni(string dni) {
        _logger.Information("Obteniendo persona con DNI {dni}", dni);
        // Si no existe, lanzamos una excepción personalizada
        return repository.GetByDni(dni) ?? throw new PersonasException.NotFound(dni);
    }

    public Persona Delete(int id) {
        _logger.Information("Eliminando persona con ID {id}", id);
        // Si no existe, lanzamos una excepción personalizada
        return repository.Delete(id) ?? throw new PersonasException.NotFound(id.ToString());
    }

    // --- MÉTODOS PRIVADOS DE APOYO ---

    /// <summary>
    ///     Valida la entidad inyectando el validador correcto según el tipo concreto en tiempo de ejecución.
    /// </summary>
    private void ValidarPersonaConLogicaPolimorfica(Persona persona) {
        // Usamos pattern matching para seleccionar el validador adecuado
        var errores = persona switch {
            Estudiante => valEstudiante.Validar(persona),
            Docente => valDocente.Validar(persona),
            _ => ErrorDeTipo("Tipo de entidad no soportado para validación.")
        };

        // Any() es más eficiente que Count() para verificar existencia
        // o con Size en nuestra lista personalizada
        if (errores.Size > 0) {
            _logger.Warning("Errores de validación encontrados: {errores}", errores);
            throw new PersonasException.Validation(errores);
        }
    }

    /// <summary>
    ///     Helper para unificar el criterio de ciclo entre Estudiantes y Docentes.
    /// </summary>
    private string ObtenerCicloTexto(Persona p) {
        // Usamos pattern matching para seleccionar el ciclo correcto según el tipo concreto en tiempo de ejecución.
        return p switch {
            Estudiante e => e.Ciclo.ToString(),
            Docente d => d.Ciclo.ToString(),
            _ => string.Empty
        };
    }

    private static ILista<string> ErrorDeTipo(string msg) {
        // Creamos una lista de strings y agregamos el mensaje de error.
        var l = new Lista<string>();
        l.AddLast(msg);
        return l;
    }
}