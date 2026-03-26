namespace Cache.Cache;

/// <summary>
///     Implementación de cache basada en el algoritmo LRU (Least Recently Used).
///     Cuando la capacidad se agota, elimina el elemento que lleva más tiempo sin ser utilizado.
///     Características:
///     - Capacidad fija definida mediante el constructor.
///     - Utiliza un <see cref="Dictionary{TKey, TValue}" /> para acceso instantáneo O(1).
///     - Utiliza una <see cref="LinkedList{TKey}" /> para gestionar el historial de uso.
///     - Cada acceso (Get) o actualización (Add) mueve el elemento al final de la lista.
///     - El elemento situado al inicio de la lista (First) es siempre el candidato al desalojo.
/// </summary>
public class LruCache<TKey, TValue>(int capacity) : ICache<TKey, TValue>
    where TKey : notnull {
    private readonly Dictionary<TKey, TValue> _data = new();
    private readonly LinkedList<TKey> _usageOrder = new();

    /// <inheritdoc cref="ICache{TKey,TValue}.Add" />
    public void Add(TKey key, TValue value) {
        if (_data.ContainsKey(key)) {
            // Si la llave ya existe, actualizamos su valor
            _data[key] = value;
            // IMPORTANTE: Al actualizarlo, también se considera un "uso reciente"
            RefreshUsage(key);
            return;
        }

        if (_data.Count >= capacity) {
            // La cache está llena. Extraemos el elemento que menos se ha usado
            // (el que quedó atrapado al principio de la lista).
            var oldestKey = _usageOrder.First!.Value;
            _usageOrder.RemoveFirst();
            _data.Remove(oldestKey);
        }

        // Añadimos el nuevo par clave-valor
        _data.Add(key, value);
        // Lo insertamos al final como el elemento más nuevo
        _usageOrder.AddLast(key);
    }

    /// <inheritdoc cref="ICache{TKey,TValue}.Get" />
    public TValue? Get(TKey key) {
        if (!_data.TryGetValue(key, out var value)) return default;

        // ¡DIFERENCIA CON FIFO!: Al consultar un dato, este "rejuvenece".
        // Lo movemos al final de la lista para que no sea el siguiente en morir.
        RefreshUsage(key);

        return value;
    }

    /// <inheritdoc cref="ICache{TKey,TValue}.Remove" />
    public bool Remove(TKey key) {
        // Borramos de ambas estructuras para mantener la sincronización
        if (_data.Remove(key)) {
            _usageOrder.Remove(key);
            return true;
        }

        return false;
    }

    /// <inheritdoc cref="ICache{TKey,TValue}.DisplayStatus" />
    public void DisplayStatus() {
        Console.WriteLine($"[LruCache] Capacidad: {_data.Count}/{capacity}");
        // La lista muestra el orden de supervivencia:
        // El primero (First) es el próximo en ser borrado, el último (Last) es el más seguro.
        Console.WriteLine($"Uso (Menos reciente -> Más reciente): {string.Join(" -> ", _usageOrder)}");
    }

    /// <summary>
    ///     Mueve una clave existente a la última posición de la lista de uso.
    ///     Este método es el corazón del algoritmo LRU.
    /// </summary>
    /// <param name="key">La clave del elemento que acaba de ser utilizado.</param>
    private void RefreshUsage(TKey key) {
        _usageOrder.Remove(key);
        _usageOrder.AddLast(key);
    }
}