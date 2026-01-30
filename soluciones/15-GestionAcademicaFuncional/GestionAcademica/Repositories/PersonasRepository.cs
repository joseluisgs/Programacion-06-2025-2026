using GestionAcademica.Collections.Lista;
using GestionAcademica.Models;
using GestionAcademica.Repositories.Common;
using Serilog;

namespace GestionAcademica.Repositories;

/// <summary>
///     Repositorio central para la gestión de Personas (Estudiantes y Docentes).
///     Implementa el patrón Singleton e IPersonasRepository utilizando inmutabilidad.
///     Usamos funciones de extension para listas enlazadas definidas en ListaExtensions.cs
/// </summary>
public class PersonasRepository : IPersonasRepository {
    // Implementación del patrón Singleton con Lazy<T> para inicialización perezosa y thread-safe.
    private static readonly Lazy<PersonasRepository> _lazy =
        new(() => new PersonasRepository());

    private readonly ILista<Persona> _listado = new Lista<Persona>();
    private readonly ILogger _logger = Log.ForContext<PersonasRepository>();
    private int _idCounter;

    private PersonasRepository() { }

    /// <summary>
    ///     Obtiene la instancia única del repositorio de forma thread-safe y perezosa.
    /// </summary>
    public static PersonasRepository Instance => _lazy.Value;

    /// <inheritdoc cref="ICrudRepository{TKey,TEntity}.GetAll" />
    public ILista<Persona> GetAll() {
        _logger.Debug("Obteniendo todas las personas");
        return _listado;
    }

    /// <inheritdoc cref="ICrudRepository{TKey,TEntity}.GetById" />
    public Persona? GetById(int id) {
        _logger.Debug($"Obteniendo persona con id {id}");
        return _listado.Find(p => p.Id == id);
    }

    /// <inheritdoc cref="IPersonasRepository.GetByDni" />
    public Persona? GetByDni(string dni) {
        _logger.Debug($"Obteniendo persona con DNI {dni}");
        return _listado.Find(p => p.Dni == dni);
    }

    /// <inheritdoc cref="IPersonasRepository.ExisteDni" />
    public bool ExisteDni(string dni) {
        _logger.Debug($"Verificando existencia de DNI {dni}");
        return GetByDni(dni) != null;
    }

    /// <inheritdoc cref="ICrudRepository{TKey,TEntity}.Create" />
    public Persona? Create(Persona entity) {
        _logger.Debug("Creando nueva persona {entity}", entity);
        // Verificar si el DNI ya existe
        if (ExisteDni(entity.Dni)) return null;

        // Asignar un nuevo Id y las marcas de tiempo
        var nuevaPersona = entity with {
            Id = ++_idCounter,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            IsDeleted = false
        };

        // Agregar la nueva persona al listado y retornar
        _listado.AddLast(nuevaPersona);
        return nuevaPersona;
    }

    /// <inheritdoc cref="ICrudRepository{TKey,TEntity}.Update" />
    public Persona? Update(int id, Persona entity) {
        _logger.Debug("Actualizando persona con id {Id} con datos {Persona}", id, entity);

        // Obtener el índice de la persona a actualizar
        var index = _listado.IndexOf(p => p.Id == id);

        // Si no se encuentra la persona, retornar null
        if (index == -1) return null;

        // Obtener la persona actual para conservar CreatedAt y su Id, luego actualizar
        var actual = _listado.GetAt(index);
        var personaActualizada = entity with {
            Id = id,
            CreatedAt = actual.CreatedAt,
            UpdatedAt = DateTime.UtcNow,
            IsDeleted = false
        };

        // Reemplazar la persona (elimina e inserta donde estaba) en el listado y retornar
        _listado.RemoveAt(index);
        _listado.AddAt(index, personaActualizada);
        return personaActualizada;
    }

    /// <inheritdoc cref="ICrudRepository{TKey,TEntity}.Delete" />
    public Persona? Delete(int id) {
        _logger.Debug($"Eliminando estudiante o docente con id {id}");

        // Si no se encuentra la persona, retornar null
        var index = _listado.IndexOf(p => p.Id == id);

        // Si no se encuentra la persona, retornar null
        if (index == -1) return null;

        // Obtener la persona actual para conservar CreatedAt y su Id, luego marcarla como eliminada
        var personaAEliminar = _listado.GetAt(index);
        _listado.RemoveAt(index); // Eliminar la persona del listado
        return personaAEliminar with {
            IsDeleted = true,
            UpdatedAt = DateTime.UtcNow
        };
    }
}