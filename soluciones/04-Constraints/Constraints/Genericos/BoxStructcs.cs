namespace Constraints.Genericos;

public class BoxStruct<T>(T contenido) where T : struct {
    public T Contenido { get; set; } = contenido;
}