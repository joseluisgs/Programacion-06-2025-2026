namespace Constraints.Genericos;

public class Box<T>(T contenido) {
    public T Contenido { get; set; } = contenido;
}