namespace Cache.Cache;

/// <summary>
///     Implementación básica de una cache que utiliza únicamente un <see cref="Dictionary{TKey, TValue}" />.
///     Si se alcanza la capacidad máxima, elimina un elemento de forma arbitraria.
///     Características:
///     - Capacidad fija.
///     - No utiliza estructuras adicionales para seguimiento de uso.
///     - Eliminación arbitraria de elementos cuando se alcanza la capacidad.
///     - Operaciones de adición, obtención y eliminación en tiempo promedio O(1).
///     - No es adecuada para escenarios donde el patrón de acceso es importante.
///     - Ideal para casos simples donde la simplicidad y el bajo consumo de memoria son prioritarios.
/// </summary>
public class SimpleCache<TKey, TValue>(int capacity) : ICache<TKey, TValue>
    where TKey : notnull {
    private readonly Dictionary<TKey, TValue> _data = new();

    /// <inheritdoc cref="ICache{TKey,TValue}.Add" />
    public void Add(TKey key, TValue value) {
        // Si el elemento no existe y no hay espacio, liberamos un hueco
        if (!_data.ContainsKey(key) && _data.Count >= capacity) {
            // Al no tener estructuras adicionales, eliminamos la primera llave 
            // que nos devuelva el enumerador del diccionario.
            var keyToRemove = _data.Keys.First();
            _data.Remove(keyToRemove);
        }

        _data[key] = value;
    }

    /// <inheritdoc cref="ICache{TKey,TValue}.Get" />
    public TValue? Get(TKey key) {
        // Usamos GetValueOrDefault para devolver el valor o null/default de forma segura
        return _data.GetValueOrDefault(key);
    }

    /// <inheritdoc cref="ICache{TKey,TValue}.Remove" />
    public bool Remove(TKey key) {
        return _data.Remove(key);
    }

    /// <inheritdoc cref="ICache{TKey,TValue}.DisplayStatus" />
    public void DisplayStatus() {
        Console.WriteLine($"[SimpleCache] Capacidad: {_data.Count}/{capacity}");
        Console.WriteLine($"Items: {string.Join(", ", _data.Keys)}");
    }
}