namespace Listas.Collections;

public class Cola<T> : ICola<T> {
    private readonly List<T> _items = new();

    public void Enqueue(T item) {
        _items.Add(item);
    }

    public T Dequeue() {
        if (_items.Count == 0) throw new InvalidOperationException("La cola está vacía.");
        var item = _items[0];
        _items.RemoveAt(0);
        return item;
    }

    public T Peek() {
        return _items.Count == 0 ? throw new InvalidOperationException("La cola está vacía.") : _items[0];
    }

    public bool IsEmpty() {
        return _items.Count == 0;
    }
}