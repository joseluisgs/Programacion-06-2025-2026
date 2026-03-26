namespace Listas.Collections;

public class Pila<T> : IPila<T> {
    private readonly List<T> _elementos = new();

    public void Push(T elemento) {
        _elementos.Add(elemento);
    }

    public T Pop() {
        if (_elementos.Count == 0)
            throw new InvalidOperationException("La pila está vacía.");

        var elemento = _elementos[_elementos.Count - 1];
        _elementos.RemoveAt(_elementos.Count - 1);
        return elemento;
    }

    public T Peek() {
        if (_elementos.Count == 0)
            throw new InvalidOperationException("La pila está vacía.");

        return _elementos[_elementos.Count - 1];
    }

    public bool IsEmpty() {
        return _elementos.Count == 0;
    }
}