namespace GestionAcademica.Collections.Lista;

/// <summary>
///     Nodo de una lista enlazada genérica.
///     Un nodo contiene un valor y una referencia al siguiente nodo.
/// </summary>
/// <param name="value">Valor almacenando</param>
/// <typeparam name="T">Siguiente elemento</typeparam>
public class Nodo<T>(T value) {
    public T Value { get; set; } = value;
    public Nodo<T>? Next { get; set; } = null;

    public override string ToString() {
        return $"Nodo({Value})";
    }
}