using ListaEnlazada.Common;

namespace ListaEnlazada.Pila;

public class Pila<T> : IPila<T> {
    // Implementación de la lista enlazada aquí...
    private Nodo<T>? _cabeza;
    private int _contador;
    
    public Pila() {
        Console.WriteLine($"Pila del tipo: {typeof(T).Name}");
    }


    public void Apilar(T valor) {
        // Crear un nuevo nodo
        var nuevoNodo = new Nodo<T>(valor);

        // Si la lista está vacía, el nuevo nodo será la cabeza
        if (_cabeza == null) {
            _cabeza = nuevoNodo;
        }
        else {
            // Si no está vacía, recorremos hasta el final de la lista
            var actual = _cabeza;
            while (actual.Siguiente != null)
                actual = actual.Siguiente;
            // El último nodo apunta al nuevo nodo
            actual.Siguiente = nuevoNodo;
        }

        // Incrementamos el contador
        _contador++;
    }

    public T Desapilar() {
        // Verificamos si la lista está vacía
        if (_cabeza == null)
            throw new InvalidOperationException("La lista está vacía");

        // Si solo hay un nodo, lo eliminamos y devolvemos su valor
        if (_cabeza.Siguiente == null) {
            var valor = _cabeza.Valor;
            _cabeza = null;
            _contador--;
            return valor!;
        }
        else {
            // Si hay más de un nodo, recorremos hasta el penúltimo nodo
            var actual = _cabeza;
            // Con un bucle While
            /*while (actual.Siguiente!.Siguiente != null)
            actual = actual.Siguiente;*/
            // Con un bucle For
            for (var i = 0; i < _contador - 2; i++)
                actual = actual.Siguiente!;
            // Guardamos el valor del último nodo
            var valor = actual.Siguiente!.Valor;
            // Eliminamos el último nodo
            actual.Siguiente = null;
            // Decrementamos el contador
            _contador--;
            return valor!;
        }
    }

    public T VerTope() {
        // Verificamos si la lista está vacía
        if (_cabeza == null)
            throw new InvalidOperationException("La lista está vacía");
        var actual = _cabeza;
        // Con un bucle while
        // while (actual.Siguiente != null)
        //     actual = actual.Siguiente;
        for (var i = 0; i < _contador - 1; i++)
            actual = actual?.Siguiente;

        // Ahora actual apunta al último nodo y lo devolvemos
        return actual!.Valor;
    }

    public int Contar() {
        return _contador;
    }

    public bool EstaVacia() {
        return _contador == 0;
    }

    public void Mostrar() {
        var actual = _cabeza;
        // Recorremos la lista mostrando los valores
        while (actual != null) {
            Console.Write(actual.Valor);
            if (actual.Siguiente != null)
                Console.Write(" -> ");
            actual = actual.Siguiente;
        }

        Console.WriteLine();
    }
}