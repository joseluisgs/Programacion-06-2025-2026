namespace BaseDatosAlumnado.Common.Lista;

// Nodo genérico para construir una lista enlazada
public class Nodo<T>(T valor) {
    public T Valor { get; set; } = valor;
    public Nodo<T>? Siguiente { get; set; } = null;

    public override string ToString() {
        return $"Nodo({Valor})";
    }
}