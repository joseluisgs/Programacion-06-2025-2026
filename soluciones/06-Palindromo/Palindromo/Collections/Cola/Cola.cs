using ListaEnlazada.Common;

namespace ListaEnlazada.Cola;

public class Cola<T> : ICola<T> {
    // Implementación de la lista enlazada aquí...
    private Nodo<T>? _cabeza;
    private int _contador;
    
    /*public Cola() {
        Console.WriteLine($"Cola del tipo: {typeof(T).Name}");
    }*/


    public void Encolar(T valor) {
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

    public T Desencolar() {
        // Verificamos si la lista está vacía
        if (_cabeza == null)
            throw new InvalidOperationException("La lista está vacía");
        // Obtenemos el valor de la cabeza
        var valor = _cabeza.Valor;
        // Actualizamos la cabeza al siguiente nodo
        _cabeza = _cabeza.Siguiente;
        // Decrementamos el contador
        _contador--;
        // Devolvemos el valor
        return valor!;
    }

    public T VerFrente() {
        // Verificamos si la lista está vacía
        if (_cabeza == null)
            throw new InvalidOperationException("La lista está vacía");

        // Ahora actual apunta al primer nodo y lo devolvemos
        return _cabeza.Valor;
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