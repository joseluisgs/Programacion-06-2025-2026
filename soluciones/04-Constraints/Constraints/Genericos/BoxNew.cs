namespace Constraints.Genericos;

public class BoxNew<T>(T contenido) where T : new() {
    public T Contenido { get; set; } = contenido;
}