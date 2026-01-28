using GestionAcademica.Common.Lista;
using GestionAcademica.Models;
using GestionAcademica.Repositories.Common;

namespace GestionAcademica.Repositories;

/// <summary>
///     Repositorio central para la gestión de Personas (Estudiantes y Docentes).
///     Implementa el patrón Singleton e IPersonasRepository utilizando inmutabilidad.
/// </summary>
public class PersonasRepository : IPersonasRepository {
    // Implementación del patrón Singleton con Lazy<T> para inicialización perezosa y thread-safe.
    private static readonly Lazy<PersonasRepository> _lazy =
        new(() => new PersonasRepository());

    private readonly ILista<Persona> _listado = new Lista<Persona>();
    private int _idCounter;

    private PersonasRepository() { }

    /// <summary>
    ///     Obtiene la instancia única del repositorio de forma thread-safe y perezosa.
    /// </summary>
    public static PersonasRepository Instance => _lazy.Value;

    /// <inheritdoc cref="ICrudRepository{TKey,TEntity}.GetAll" />
    public ILista<Persona> GetAll() {
        return _listado;
    }

    /// <inheritdoc cref="ICrudRepository{TKey,TEntity}.GetById" />
    public Persona? GetById(int id) {
        foreach (var p in _listado)
            if (p.Id == id)
                return p;
        return null;
    }

    /// <inheritdoc cref="IPersonasRepository.GetByDni" />
    public Persona? GetByDni(string dni) {
        foreach (var p in _listado)
            if (p.Dni.Equals(dni, StringComparison.OrdinalIgnoreCase))
                return p;
        return null;
    }

    /// <inheritdoc cref="IPersonasRepository.ExisteDni" />
    public bool ExisteDni(string dni) {
        return GetByDni(dni) != null;
    }

    /// <inheritdoc cref="ICrudRepository{TKey,TEntity}.Create" />
    public Persona? Create(Persona entity) {
        if (ExisteDni(entity.Dni)) return null;

        var nuevaPersona = entity with {
            Id = ++_idCounter,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            IsDeleted = false
        };

        _listado.AgregarFinal(nuevaPersona);
        return nuevaPersona;
    }

    /// <inheritdoc cref="ICrudRepository{TKey,TEntity}.Update" />
    public Persona? Update(int id, Persona entity) {
        for (var i = 0; i < _listado.Contar(); i++) {
            var actual = _listado.Obtener(i);
            if (actual.Id == id) {
                var actualizada = entity with {
                    Id = id,
                    CreatedAt = actual.CreatedAt,
                    UpdatedAt = DateTime.UtcNow,
                    IsDeleted = false
                };

                _listado.EliminarEn(i);
                _listado.AgregarEn(actualizada, i);
                return actualizada;
            }
        }

        return null;
    }

    /// <inheritdoc cref="ICrudRepository{TKey,TEntity}.Delete" />
    public Persona? Delete(int id) {
        for (var i = 0; i < _listado.Contar(); i++) {
            var actual = _listado.Obtener(i);
            if (actual.Id == id) {
                _listado.EliminarEn(i);
                return actual with { IsDeleted = true, UpdatedAt = DateTime.UtcNow };
            }
        }

        return null;
    }
}