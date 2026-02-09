using BaseDatosAlumnado.Common.Lista;

namespace BaseDatosAlumnado.Repositories.Common;

/// <summary>
///     Repositorio genérico para las entidades de la base de datos.
/// </summary>
/// <typeparam name="TKey"></typeparam>
/// <typeparam name="TEntity"></typeparam>
public interface ICrudRepository<TKey, TEntity> where TEntity : class {
    /// <summary>
    ///     Obtiene todos los elementos de la entidad.
    /// </summary>
    ILista<TEntity> GetAll();

    /// <summary>
    ///     Obtiene un elemento por su ID.
    /// </summary>
    /// <param name="id">ID del elemento a obtener.</param>
    /// <returns>Elemento con el ID especificado. Nulo si no existe</returns>
    TEntity? GetById(TKey id);

    /// <summary>
    ///     Crea un nuevo elemento en la entidad.
    /// </summary>
    /// <param name="entity">Entidad a crear.</param>
    /// <returns>Entidad creada con su ID asignado. Nulo si no se pudo crear</returns>
    TEntity? Create(TEntity entity);

    /// <summary>
    ///     Actualiza un elemento existente en la entidad.
    /// </summary>
    /// <param name="id">ID del elemento a actualizar.</param>
    /// <param name="entity">Entidad a actualizar.</param>
    /// <returns>Entidad actualizada. Nulo si no existe</returns>
    TEntity? Update(TKey id, TEntity entity);

    /// <summary>
    ///     Elimina un elemento por su ID.
    /// </summary>
    /// <param name="id">ID del elemento a eliminar.</param>
    /// <returns>Entidad eliminada. Nulo si no existe</returns>
    TEntity? Delete(TKey id);
}