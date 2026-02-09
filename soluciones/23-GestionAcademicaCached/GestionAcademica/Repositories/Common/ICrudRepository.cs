using System.Collections.Generic;

namespace GestionAcademica.Repositories.Common;

/// <summary>
///     Contrato genérico para operaciones CRUD de persistencia.
///     Diseñado para devolver IEnumerable, desacoplando el almacenamiento interno.
/// </summary>
/// <typeparam name="TKey">Tipo de la clave primaria.</typeparam>
/// <typeparam name="TEntity">Tipo de la entidad (debe ser una clase).</typeparam>
public interface ICrudRepository<in TKey, TEntity> where TEntity : class {
    /// <summary>
    ///     Recupera todas las entidades del almacén.
    ///     El llamador decide si convierte a lista, ordena, filtra, etc.
    /// </summary>
    /// <returns>Enumerable de solo lectura de todas las entidades.</returns>
    IEnumerable<TEntity> GetAll();

    /// <summary>
    ///     Busca una entidad por su clave única.
    /// </summary>
    /// <param name="id">Clave de búsqueda.</param>
    /// <returns>La entidad encontrada o null.</returns>
    TEntity? GetById(TKey id);

    /// <summary>
    ///     Persiste una nueva entidad en el almacén.
    /// </summary>
    /// <param name="entity">Entidad a crear.</param>
    /// <returns>La entidad creada (usualmente con ID asignado) o null si ya existe.</returns>
    TEntity? Create(TEntity entity);

    /// <summary>
    ///     Actualiza los datos de una entidad existente.
    /// </summary>
    /// <param name="id">Clave de la entidad.</param>
    /// <param name="entity">Nuevos datos de la entidad.</param>
    /// <returns>La entidad actualizada o null si no se encontró.</returns>
    TEntity? Update(TKey id, TEntity entity);

    /// <summary>
    ///     Elimina una entidad del almacén.
    /// </summary>
    /// <param name="id">Clave de la entidad a eliminar.</param>
    /// <returns>La entidad eliminada o null si no existía.</returns>
    TEntity? Delete(TKey id);
}