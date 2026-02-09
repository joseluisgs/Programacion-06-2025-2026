using GestionAcademica.Models;
using GestionAcademica.Repositories.Common;
using Serilog;

namespace GestionAcademica.Repositories;

/// <summary>
///     Repositorio central para la gestión de Personas (Estudiantes y Docentes).
///     Implementa el patrón Singleton usando Dictionary para búsquedas O(1).
///     La ordenación se delega al Servicio mediante IEnumerable.
/// </summary>
public class PersonasRepository : IPersonasRepository {
    private static readonly Lazy<PersonasRepository> Lazy = new(() => new PersonasRepository());

    // DICCIONARIO SECUNDARIO: Indexa DNI -> ID.
    // ¿Por qué dos diccionarios?
    // - DNI es único pero NO es la clave primaria (el ID lo asigna el sistema).
    // - Si solo tuviéramos _porId, buscar por DNI requeriría iterar O(n).
    // - Con _dniIndex, поиск por DNI también es O(1).
    // Esta técnica se llama "índice secundario" y se usa en bases de datos reales.
    private readonly Dictionary<string, int> _dniIndex = new();

    private readonly ILogger _logger = Log.ForContext<PersonasRepository>();

    // ============================================================
    // ESTRUCTURAS DE DATOS INTERNAS
    // ============================================================

    // DICCIONARIO PRINCIPAL: Almacena las personas indexadas por su ID.
    // Permite búsquedas O(1) por ID (la clave primaria).
    private readonly Dictionary<int, Persona> _porId = new();

    private int _idCounter;

    private PersonasRepository() { }

    public static PersonasRepository Instance => Lazy.Value;

    /// <inheritdoc cref="IPersonasRepository.GetAll" />
    public IEnumerable<Persona> GetAll() {
        _logger.Debug("Obteniendo todas las personas");
        return _porId.Values;
    }

    /// <inheritdoc cref="ICrudRepository{TKey,TEntity}.GetById" />
    public Persona? GetById(int id) {
        _logger.Debug($"Obteniendo persona con id {id}");
        return _porId.GetValueOrDefault(id);
    }

    /// <inheritdoc cref="IPersonasRepository.GetByDni" />
    public Persona? GetByDni(string dni) {
        _logger.Debug($"Obteniendo persona con DNI {dni}");
        return _dniIndex.TryGetValue(dni, out var id) && _porId.TryGetValue(id, out var persona)
            ? persona
            : null;
    }

    /// <inheritdoc cref="IPersonasRepository.ExisteDni" />
    public bool ExisteDni(string dni) {
        return _dniIndex.ContainsKey(dni);
    }

    /// <inheritdoc cref="ICrudRepository{int, Persona}.Create" />
    public Persona? Create(Persona entity) {
        _logger.Debug("Creando nueva persona {entity}", entity);
        if (ExisteDni(entity.Dni)) return null;

        var nuevaPersona = entity with {
            Id = ++_idCounter,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            IsDeleted = false
        };

        _porId[nuevaPersona.Id] = nuevaPersona;
        _dniIndex[nuevaPersona.Dni] = nuevaPersona.Id;
        return nuevaPersona;
    }

    /// <inheritdoc cref="ICrudRepository{int, Persona}.Update" />
    public Persona? Update(int id, Persona entity) {
        _logger.Debug("Actualizando persona con id {Id} con datos {Persona}", id, entity);

        if (!_porId.TryGetValue(id, out var actual)) return null;

        var personaActualizada = entity with {
            Id = id,
            CreatedAt = actual.CreatedAt,
            UpdatedAt = DateTime.UtcNow,
            IsDeleted = false
        };

        _porId[id] = personaActualizada;

        if (actual.Dni != personaActualizada.Dni) {
            _dniIndex.Remove(actual.Dni);
            _dniIndex[personaActualizada.Dni] = id;
        }

        return personaActualizada;
    }

    /// <inheritdoc cref="ICrudRepository{int, Persona}.Delete" />
    public Persona? Delete(int id) {
        _logger.Debug($"Eliminando persona con id {id}");

        if (!_porId.Remove(id, out var persona)) return null;

        _dniIndex.Remove(persona.Dni);

        return persona with {
            IsDeleted = true,
            UpdatedAt = DateTime.UtcNow
        };
    }
}