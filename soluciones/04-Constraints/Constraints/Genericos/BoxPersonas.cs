using Constraints.Models;

namespace Constraints.Genericos;

public class BoxPersonas<T>(T contenido) where T : Persona {
    public T Contenido { get; set; } = contenido;
}