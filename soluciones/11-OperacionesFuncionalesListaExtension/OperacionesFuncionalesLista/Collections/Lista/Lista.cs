namespace OperacionesFuncionalesLista.Collections.Lista;

public class Lista<T> : ILista<T> {
    // Implementación de la lista enlazada aqu�...
    private Nodo<T>? _cabeza;
    private int _contador;

    /*
    public Lista() {
        Console.WriteLine($"Lista del tipo: {typeof(T).Name}");
    }
    */


    public void AgregarInicio(T valor) {
        // Creamos un nuevo nodo
        var nuevoNodo = new Nodo<T>(valor);

        // Si la lista est� vac�a, el nuevo nodo ser� la cabeza
        if (_cabeza == null) {
            _cabeza = nuevoNodo;
        }
        // Si no est� vac�a, el nuevo nodo apunta a la cabeza actual y luego se actualiza la cabeza
        else {
            nuevoNodo.Siguiente = _cabeza;
            _cabeza = nuevoNodo;
        }

        // Incrementamos el contador
        _contador++;
    }

    public void AgregarFinal(T valor) {
        // Crear un nuevo nodo
        var nuevoNodo = new Nodo<T>(valor);

        // Si la lista est� vac�a, el nuevo nodo ser� la cabeza
        if (_cabeza == null) {
            _cabeza = nuevoNodo;
        }
        else {
            // Si no est� vac�a, recorremos hasta el final de la lista
            var actual = _cabeza;
            while (actual.Siguiente != null)
                actual = actual.Siguiente;
            // El �ltimo nodo apunta al nuevo nodo
            actual.Siguiente = nuevoNodo;
        }

        // Incrementamos el contador
        _contador++;
    }

    public void AgregarEn(T valor, int indice) {
        // Crear un nuevo nodo
        var nuevoNodo = new Nodo<T>(valor);
        // Validar el �ndice
        if (indice < 0 || indice > _contador)
            throw new ArgumentOutOfRangeException(nameof(indice), "�ndice fuera de rango");
        // Si el �ndice es 0, agregamos al inicio
        if (indice == 0) {
            AgregarInicio(valor);
        }
        else {
            // Si el �ndice es mayor que 0, recorremos hasta el �ndice deseado
            var actual = _cabeza;
            for (var i = 0; i < indice - 1; i++)
                actual = actual?.Siguiente;
            // Creamos un nuevo nodo y lo conectamos con el actual y el siguiente
            nuevoNodo.Siguiente = actual?.Siguiente;
            actual?.Siguiente = nuevoNodo;
            // Incrementamos el contador
            _contador++;
        }
    }

    public void EliminarInicio() {
        // Verificamos si la lista est� vac�a
        if (_cabeza == null)
            throw new InvalidOperationException("La lista est� vac�a");
        // Actualizamos la cabeza para que apunte al siguiente nodo
        _cabeza = _cabeza.Siguiente;
        // Decrementamos el contador
        _contador--;
    }

    public void EliminarFinal() {
        // Verificamos si la lista est� vac�a
        if (_cabeza == null)
            throw new InvalidOperationException("La lista est� vac�a");
        // Si solo hay un nodo, eliminamos la cabeza
        if (_cabeza.Siguiente == null) {
            _cabeza = null;
        }
        else {
            // Recorremos hasta el pen�ltimo nodo
            var actual = _cabeza;

            // con un bucle while
            // while (actual.Siguiente?.Siguiente != null)
            // actual = actual.Siguiente;

            // con un bucle for
            for (var i = 0; i < _contador - 2; i++)
                actual = actual?.Siguiente;

            // Ahora actual apunta al pen�ltimo nodo
            // y el pen�ltimo nodo apunta a null
            actual?.Siguiente = null;
        }

        // Decrementamos el contador
        _contador--;
    }

    public void EliminarEn(int indice) {
        // Validar el �ndice
        if (indice < 0 || indice >= _contador)
            throw new ArgumentOutOfRangeException(nameof(indice), "�ndice fuera de rango");
        // Si el �ndice es 0, eliminamos el inicio
        if (indice == 0) {
            EliminarInicio();
        }
        else {
            // Si el �ndice es mayor que 0, recorremos hasta el �ndice deseado
            var actual = _cabeza;

            // Con un bucle while
            // while (actual.Siguiente?.Siguiente!= null && i < indice - 1)
            // actual = actual.Siguiente;

            // Con un bucle for
            for (var i = 0; i < indice - 1; i++)
                actual = actual?.Siguiente;

            // Ahora actual apunta al nodo antes del que queremos eliminar
            // Saltamos el nodo a eliminar
            actual?.Siguiente = actual.Siguiente?.Siguiente;
            // Decrementamos el contador
            _contador--;
        }
    }

    public T ObtenerPrimero() {
        // Verificamos si la lista est� vac�a
        if (_cabeza == null)
            throw new InvalidOperationException("La lista est� vac�a");

        // Ahora actual apunta al primer nodo y lo devolvemos
        return _cabeza.Valor;
    }

    public T ObtenerUltimo() {
        // Verificamos si la lista est� vac�a
        if (_cabeza == null)
            throw new InvalidOperationException("La lista est� vac�a");
        var actual = _cabeza;
        // Con un bucle while
        // while (actual.Siguiente != null)
        //     actual = actual.Siguiente;
        for (var i = 0; i < _contador - 1; i++)
            actual = actual?.Siguiente;

        // Ahora actual apunta al �ltimo nodo y lo devolvemos
        return actual!.Valor;
    }

    public T Obtener(int indice) {
        // Validar el �ndice
        if (indice < 0 || indice >= _contador)
            throw new ArgumentOutOfRangeException(nameof(indice), "�ndice fuera de rango");
        var actual = _cabeza;
        // Con un bucle while
        // while (actual != null && i < indice)
        //     actual = actual.Siguiente;

        // Con un bucle for
        for (var i = 0; i < indice; i++)
            actual = actual?.Siguiente;

        // Ahora actual apunta al nodo en el �ndice deseado y lo devolvemos
        return actual!.Valor;
    }

    public bool Existe(T valor) {
        var actual = _cabeza;
        // Recorremos la lista buscando el valor
        while (actual != null) {
            if (actual.Valor!.Equals(valor))
                return true;
            actual = actual.Siguiente;
        }

        return false;
    }

    public int Contar() {
        return _contador;
    }

    public bool EstaVacia() {
        return _contador == 0;
    }

    public void Limpiar() {
        _cabeza = null;
        _contador = 0;
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

    // Esto lo veremos m�s adelante, pero es necesario para poder usar foreach
    public IEnumerator<T> GetEnumerator() {
        // Recorremos la lista devolviendo los valores
        var actual = _cabeza;
        while (actual != null) {
            // Yield devuelve un valor y pausa la ejecuci�n, para que el ciclo foreach pueda continuar
            yield return actual.Valor;
            // Avanzamos al siguiente nodo
            actual = actual.Siguiente;
        }
    }
}