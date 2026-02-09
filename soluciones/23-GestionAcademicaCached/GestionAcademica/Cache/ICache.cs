namespace GestionAcademica.Cache;

/// <summary>
///     Cache
/// </summary>
/// <typeparam name="TKey">Clave</typeparam>
/// <typeparam name="TValue">Valor</typeparam>
public interface ICache<in TKey, TValue> where TKey : notnull {
    /// <summary>
    ///     Agregar un elemento al cache
    /// </summary>
    /// <param name="key">Clave</param>
    /// <param name="value">Valor</param>
    void Add(TKey key, TValue value);

    /// <summary>
    ///     Obtener un elemento del cache
    /// </summary>
    /// <param name="key">Clave</param>
    /// <returns>Valor o Nulo</returns>
    TValue? Get(TKey key);

    /// <summary>
    ///     Eliminar un elemento del cache
    /// </summary>
    /// <param name="key">Clave</param>
    /// <returns>Si el elemento fue eliminado</returns>
    bool Remove(TKey key);

    /// <summary>
    ///     Mostrar el estado del cache
    /// </summary>
    void DisplayStatus();
}