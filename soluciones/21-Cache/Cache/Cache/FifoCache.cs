namespace Cache.Cache;

/// <summary>
///     Implementación de cache que sigue el algoritmo FIFO (First-In, First-Out)
///     utilizando una <see cref="LinkedList{TKey}" /> para mayor eficiencia en eliminaciones manuales.
///     Características:
///     - Capacidad fija definida en el constructor.
///     - Utiliza un <see cref="Dictionary{TKey, TValue}" /> para búsquedas rápidas.
///     - Utiliza una <see cref="LinkedList{TKey}" /> para mantener el orden de entrada.
///     - A diferencia de una Queue, permite eliminar elementos intermedios eficientemente.
///     - El primer elemento en entrar es siempre el primero en ser desalojado (FIFO).
/// </summary>
public class FifoCache<TKey, TValue>(int capacity) : ICache<TKey, TValue>
    where TKey : notnull {
    private readonly Dictionary<TKey, TValue> _data = new();
    private readonly LinkedList<TKey> _order = new();

    /// <inheritdoc cref="ICache{TKey,TValue}.Add" />
    public void Add(TKey key, TValue value) {
        // Si la llave ya existe, solo actualizamos el valor y no tocamos el orden (es FIFO)
        if (_data.ContainsKey(key)) {
            _data[key] = value;
            return;
        }

        // Si estamos al límite, el "sacrificado" es el primero de la lista
        if (_data.Count >= capacity) {
            var oldestKey = _order.First!.Value;
            _order.RemoveFirst();
            _data.Remove(oldestKey);
        }

        // Añadimos el nuevo dato al diccionario y al final de la lista
        _data.Add(key, value);
        _order.AddLast(key);
    }

    /// <inheritdoc cref="ICache{TKey,TValue}.Get" />
    public TValue? Get(TKey key) {
        // En FIFO, el acceso (Get) NO cambia el orden de prioridad
        return _data.GetValueOrDefault(key);
    }

    /// <inheritdoc cref="ICache{TKey,TValue}.Remove" />
    public bool Remove(TKey key) {
        // Gracias a LinkedList, si el elemento existe, lo borramos de ambos sitios
        // sin necesidad de reconstruir ninguna estructura.
        if (_data.Remove(key)) {
            _order.Remove(key);
            return true;
        }

        return false;
    }

    /// <inheritdoc cref="ICache{TKey,TValue}.DisplayStatus" />
    public void DisplayStatus() {
        Console.WriteLine($"[FifoCache-Linked] Capacidad: {_data.Count}/{capacity}");
        Console.WriteLine($"Cola (Entrada -> Reciente): {string.Join(" -> ", _order)}");
    }
}