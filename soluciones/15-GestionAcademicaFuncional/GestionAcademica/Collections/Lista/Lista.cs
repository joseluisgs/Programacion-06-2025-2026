using System.Collections;

namespace GestionAcademica.Collections.Lista;

/// <summary>
///     Implementación de una lista enlazada genérica.
/// </summary>
/// <typeparam name="T">Tipo de los elementos almacenados en la lista.</typeparam>
public class Lista<T> : ILista<T> {
    private Nodo<T>? _cabeza;

    /// <inheritdoc cref="ILista{T}.AddFirst" />
    public void AddFirst(T item) {
        var nuevoNodo = new Nodo<T>(item);
        if (_cabeza == null) {
            _cabeza = nuevoNodo;
        }
        else {
            nuevoNodo.Next = _cabeza;
            _cabeza = nuevoNodo;
        }

        Size++;
    }

    /// <inheritdoc cref="ILista{T}.AddLast" />
    public void AddLast(T item) {
        var nuevoNodo = new Nodo<T>(item);
        if (_cabeza == null) {
            _cabeza = nuevoNodo;
        }
        else {
            var actual = _cabeza;
            while (actual.Next != null)
                actual = actual.Next;
            actual.Next = nuevoNodo;
        }

        Size++;
    }

    /// <inheritdoc cref="ILista{T}.AddAt" />
    public void AddAt(int index, T item) {
        if (index < 0 || index > Size)
            throw new ArgumentOutOfRangeException(nameof(index), "Índice fuera de rango");

        if (index == 0) {
            AddFirst(item);
        }
        else {
            var nuevoNodo = new Nodo<T>(item);
            var actual = _cabeza;
            for (var i = 0; i < index - 1; i++)
                actual = actual?.Next;

            nuevoNodo.Next = actual?.Next;
            actual!.Next = nuevoNodo;
            Size++;
        }
    }

    /// <inheritdoc cref="ILista{T}.RemoveFirst" />
    public void RemoveFirst() {
        if (_cabeza == null)
            throw new InvalidOperationException("La lista está vacía");
        _cabeza = _cabeza.Next;
        Size--;
    }

    /// <inheritdoc cref="ILista{T}.RemoveLast" />
    public void RemoveLast() {
        if (_cabeza == null)
            throw new InvalidOperationException("La lista está vacía");

        if (_cabeza.Next == null) {
            _cabeza = null;
        }
        else {
            var actual = _cabeza;
            for (var i = 0; i < Size - 2; i++)
                actual = actual?.Next;
            actual!.Next = null;
        }

        Size--;
    }

    /// <inheritdoc cref="ILista{T}.RemoveAt" />
    public void RemoveAt(int index) {
        if (index < 0 || index >= Size)
            throw new ArgumentOutOfRangeException(nameof(index), "Índice fuera de rango");

        if (index == 0) {
            RemoveFirst();
        }
        else {
            var actual = _cabeza;
            for (var i = 0; i < index - 1; i++)
                actual = actual?.Next;

            actual!.Next = actual.Next?.Next;
            Size--;
        }
    }

    /// <inheritdoc cref="ILista{T}.GetFirst" />
    public T GetFirst() {
        if (_cabeza == null)
            throw new InvalidOperationException("La lista está vacía");
        return _cabeza.Value;
    }

    /// <inheritdoc cref="ILista{T}.GetLast" />
    public T GetLast() {
        if (_cabeza == null)
            throw new InvalidOperationException("La lista está vacía");
        var actual = _cabeza;
        for (var i = 0; i < Size - 1; i++)
            actual = actual?.Next;
        return actual!.Value;
    }

    /// <inheritdoc cref="ILista{T}.GetAt" />
    public T GetAt(int index) {
        if (index < 0 || index >= Size)
            throw new ArgumentOutOfRangeException(nameof(index), "Índice fuera de rango");
        var actual = _cabeza;
        for (var i = 0; i < index; i++)
            actual = actual?.Next;
        return actual!.Value;
    }

    /// <inheritdoc cref="ILista{T}.Contains" />
    public bool Contains(T item) {
        var actual = _cabeza;
        while (actual != null) {
            if (actual.Value!.Equals(item))
                return true;
            actual = actual.Next;
        }

        return false;
    }

    /// <inheritdoc cref="ILista{T}.IsEmpty" />
    public bool IsEmpty() {
        return Size == 0;
    }

    /// <inheritdoc cref="ILista{T}.Clear" />
    public void Clear() {
        _cabeza = null;
        Size = 0;
    }

    /// <inheritdoc cref="ILista{T}.Display" />
    public void Display() {
        var actual = _cabeza;
        while (actual != null) {
            Console.Write(actual.Value);
            if (actual.Next != null)
                Console.Write(" -> ");
            actual = actual.Next;
        }

        Console.WriteLine();
    }

    /// <inheritdoc cref="IEnumerator{T}" />
    public IEnumerator<T> GetEnumerator() {
        var actual = _cabeza;
        while (actual != null) {
            yield return actual.Value;
            actual = actual.Next;
        }
    }

    /// <inheritdoc cref="IEnumerable{T}" />
    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }

    /// <inheritdoc cref="ILista{T}.IndexOf" />
    public int IndexOf(T item) {
        var actual = _cabeza;
        var indice = 0;
        while (actual != null) {
            if (actual.Value!.Equals(item))
                return indice;
            actual = actual.Next;
            indice++;
        }

        return -1;
    }

    /// <inheritdoc cref="ILista{T}.Size" />
    public int Size { get; private set; }
}