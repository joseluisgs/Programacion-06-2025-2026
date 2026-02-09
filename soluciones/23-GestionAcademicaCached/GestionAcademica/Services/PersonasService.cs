using GestionAcademica.Cache;
using GestionAcademica.Enums;
using GestionAcademica.Exceptions;
using GestionAcademica.Models;
using GestionAcademica.Repositories;
using GestionAcademica.Validators.Common;
using Serilog;

namespace GestionAcademica.Services;

/// <summary>
///     Servicio integral para la gestión de personas (Estudiantes y Docentes).
///     Implementa lógica de negocio mediante pipelines funcionales con LINQ estándar.
/// </summary>
public class PersonasService(
    IPersonasRepository repository,
    IValidador<Persona> valEstudiante,
    IValidador<Persona> valDocente,
    ICache<int, Persona> cache) : IPersonasService {
    private readonly ILogger _logger = Log.ForContext<PersonasService>();

    /// <inheritdoc cref="IPersonasService.TotalPersonas" />
    public int TotalPersonas => repository.GetAll().Count();

    /// <inheritdoc cref="IPersonasService.GetAll" />
    public IEnumerable<Persona> GetAll() {
        _logger.Information("Obteniendo todas las personas.");
        return repository.GetAll();
    }

    /// <inheritdoc cref="IPersonasService.GetEstudiantesOrderBy" />
    public IEnumerable<Estudiante> GetEstudiantesOrderBy(TipoOrdenamiento ordenamiento = TipoOrdenamiento.Dni) {
        _logger.Information("Obteniendo estudiantes ordenados por {ordenamiento}.", ordenamiento);
        return GetAllOrderBy(ordenamiento, p => p is Estudiante)
            .Cast<Estudiante>();
    }

    /// <inheritdoc cref="IPersonasService.GetDocentesOrderBy" />
    public IEnumerable<Docente> GetDocentesOrderBy(TipoOrdenamiento ordenamiento = TipoOrdenamiento.Dni) {
        _logger.Information("Obteniendo docentes ordenados por {ordenamiento}.", ordenamiento);
        return GetAllOrderBy(ordenamiento, p => p is Docente)
            .Cast<Docente>();
    }

    /// <inheritdoc cref="IPersonasService.GenerarInformeEstudiante" />
    public InformeEstudiante GenerarInformeEstudiante(Ciclo? ciclo = null, Curso? curso = null) {
        _logger.Information("Generando informe estadístico de estudiantes con filtro Ciclo: {ciclo}, Curso: {curso}.",
            ciclo, curso);

        // PIPELINE FUNCIONAL: Encadenamos operaciones en una sola expresión.
        // 1. GetEstudiantesOrderBy → obtenemos estudiantes ordenados por nota
        // 2. Where → filtramos por ciclo/curso (null = sin filtro)
        // 3. ToList() → materializamos el IEnumerable para contar varias veces
        var estudiantes = GetEstudiantesOrderBy(TipoOrdenamiento.Nota)
            .Where(e => (ciclo == null || e.Ciclo == ciclo) && (curso == null || e.Curso == curso))
            .ToList();

        var total = estudiantes.Count;
        if (total == 0) return new InformeEstudiante();

        return new InformeEstudiante {
            PorNota = estudiantes,
            TotalEstudiantes = total,
            // Count con predicado cuenta solo los que cumplen la condición
            Aprobados = estudiantes.Count(e => e.Calificacion >= 5.0),
            Suspensos = estudiantes.Count(e => e.Calificacion < 5.0),
            // Average es la suma dividida por el conteo (igual que en SQL)
            NotaMedia = estudiantes.Average(e => e.Calificacion)
        };
    }

    /// <inheritdoc cref="IPersonasService.GenerarInformeDocente" />
    public InformeDocente GenerarInformeDocente(Ciclo? ciclo = null) {
        _logger.Information("Generando informe estadístico de docentes con filtro Ciclo: {ciclo}.", ciclo);
        
        // PIPELINE FUNCIONAL: Encadenamos operaciones en una sola expresión.
        var docentes = GetDocentesOrderBy(TipoOrdenamiento.Experiencia)
            .Where(d => ciclo == null || d.Ciclo == ciclo)
            .ToList();

        var total = docentes.Count;
        return new InformeDocente {
            PorExperiencia = docentes,
            TotalDocentes = total,
            // Protección contra división por cero si no hay docentes
            ExperienciaMedia = total > 0 ? docentes.Average(d => d.Experiencia) : 0
        };
    }

    /// <inheritdoc cref="IPersonasService.GetAllOrderBy" />
    public IEnumerable<Persona> GetAllOrderBy(TipoOrdenamiento orden = TipoOrdenamiento.Dni,
        Predicate<Persona>? filtro = null) {
        _logger.Information("Obteniendo todas las personas ordenadas por {orden} con filtro: {filtro}.", orden,
            filtro != null ? "Sí" : "No");

        // Si no hay filtro, devolvemos todo. Si lo hay, aplicamos el predicado.
        var lista = filtro == null
            ? repository.GetAll()
            : repository.GetAll().Where(p => filtro(p));

        // MAPA DE ESTRATEGIAS: Un diccionario asocia cada criterio de orden con su función lambda.
        // Ventaja: Para añadir un nuevo criterio, solo añadimos una línea al mapa (Open/Closed Principle).
        // Ejemplo: { TipoOrdenamiento.Edad, () => lista.OrderBy(p => p.Edad) }
        var comparadores = new Dictionary<TipoOrdenamiento, Func<IOrderedEnumerable<Persona>>> {
            { TipoOrdenamiento.Id, () => lista.OrderBy(p => p.Id) },
            { TipoOrdenamiento.Dni, () => lista.OrderBy(p => p.Dni) },
            { TipoOrdenamiento.Nombre, () => lista.OrderBy(p => p.Nombre) },
            { TipoOrdenamiento.Apellidos, () => lista.OrderBy(p => p.Apellidos) },
            { TipoOrdenamiento.Ciclo, () => lista.OrderBy(p => ObtenerCicloTexto(p)) },
            // Para propiedades de tipos derivados (Estudiante/Docente), usamos pattern matching.
            // Si no es del tipo, devolvemos un valor neutro (-1 o int.MaxValue) para que vaya al final.
            { TipoOrdenamiento.Nota, () => lista.OrderByDescending(p => p is Estudiante e ? e.Calificacion : -1) },
            { TipoOrdenamiento.Experiencia, () => lista.OrderByDescending(p => p is Docente d ? d.Experiencia : -1) },
            { TipoOrdenamiento.Curso, () => lista.OrderBy(p => p is Estudiante e ? (int)e.Curso : int.MaxValue) }
        };

        // TryGetValue ejecuta la función solo si encuentra el criterio.
        // Si no existe, usamos Id por defecto (fallback seguro).
        return comparadores.TryGetValue(orden, out var comparador)
            ? comparador()
            : lista.OrderBy(p => p.Id);
    }

    // --- OPERACIONES CRUD ---

    /// <inheritdoc cref="IPersonasService.Save" />
    public Persona Save(Persona persona) {
        _logger.Information("Guardando nueva persona: {persona}", persona);
        // Validamos que la persona sea válida según nuestras reglas de negocio.
        ValidarPersonaConLogicaPolimorfica(persona);
        // Validamos que el DNI no exista ya en la base de datos. Si lo hay, lanzamos excepción.
        var nueva = repository.Create(persona) ?? throw new PersonasException.AlreadyExists(persona.Dni);
        // En producción, Create normalmente NO añade a cache.
        // Lo añadimos aquí para ver el funcionamiento del LRU.
        // cache.Add(nueva.Id, nueva);
        return nueva;
    }

    /// <inheritdoc cref="IPersonasService.Update" />
    public Persona Update(int id, Persona persona) {
        _logger.Information("Actualizando persona con ID {id}: {persona}", id, persona);
        // Validamos que la persona sea válida según nuestras reglas de negocio.
        ValidarPersonaConLogicaPolimorfica(persona);
        // Actualizamos en la base de datos. Si no existe, lanzamos excepción.
        var actualizada = repository.Update(id, persona) ?? throw new PersonasException.NotFound(id.ToString());
        // LRU: Eliminamos de la caché para forzar recarga en el próximo GetById.
        cache.Remove(id);
        return actualizada;
    }

    /// <inheritdoc cref="IPersonasService.GetById" />
    public Persona GetById(int id) {
        _logger.Information("Obteniendo persona con ID {id}", id);
        // LRU: Buscamos en la caché antes de buscar en la base de datos.
        var cached = cache.Get(id);
        if (cached != null)
            // Si está en caché, la devolvemos directamente.
            return cached;
        // Si no está en caché, buscamos en la base de datos. Si no existe, lanzamos excepción.
        var persona = repository.GetById(id) ?? throw new PersonasException.NotFound(id.ToString());
        //LRU: Añadimos al caché para evitar recargar la persona en el próximo GetById.
        cache.Add(id, persona);
        // Devolvemos la persona encontrada.
        return persona;
    }

    /// <inheritdoc cref="IPersonasService.GetByDni" />
    public Persona GetByDni(string dni) {
        _logger.Information("Obteniendo persona con DNI {dni}", dni);
        // Buscamos en la base de datos directamente (no caché por clave DNI).
        var persona = repository.GetByDni(dni) ?? throw new PersonasException.NotFound(dni);
        // LRU: Como ya tenemos el objeto, conocemos su ID. Lo añadimos a cache.
        // cache.Add(persona.Id, persona);
        // Devolvemos la persona encontrada.
        return persona;
    }

    /// <inheritdoc cref="IPersonasService.Delete" />
    public Persona Delete(int id) {
        _logger.Information("Eliminando persona con ID {id}", id);
        // Eliminamos de la base de datos. Si no existe, lanzamos excepción.
        var eliminada = repository.Delete(id) ?? throw new PersonasException.NotFound(id.ToString());
        // LRU: Eliminamos de la caché si existía.
        cache.Remove(id);
        return eliminada;
    }

    // --- MÉTODOS PRIVADOS ---

    /// <summary>
    ///     Selecciona el validador correcto según el tipo concreto de Persona (Estudiante/Docente).
    ///     POLIMORFISMO: El switch expression devuelve el validador adecuado sin if/else.
    ///     Ejemplo: Si es Estudiante, usa ValidadorEstudiante. Si es Docente, usa ValidadorDocente.
    /// </summary>
    private void ValidarPersonaConLogicaPolimorfica(Persona persona) {
        var errores = persona switch {
            Estudiante => valEstudiante.Validar(persona),
            Docente => valDocente.Validar(persona),
            // Caso por defecto (raro que ocurra, pero por seguridad)
            _ => ["Tipo de entidad no soportada para validación."]
        };

        // Any() es más eficiente que Count() > 0 porque no cuenta todos los elementos.
        if (errores.Any()) {
            _logger.Warning("Errores de validación encontrados: {errores}", errores);
            throw new PersonasException.Validation(errores);
        }
    }

    /// <summary>
    ///     Obtiene el ciclo formativo de cualquier Persona (Estudiante o Docente).
    ///     PATTERN MATCHING: El switch extrae la propiedad Ciclo del tipo derivado.
    ///     Ventaja: Una sola función maneja todos los tipos de Persona.
    /// </summary>
    private static string ObtenerCicloTexto(Persona p) {
        return p switch {
            Estudiante e => e.Ciclo.ToString(),
            Docente d => d.Ciclo.ToString(),
            _ => string.Empty
        };
    }
}