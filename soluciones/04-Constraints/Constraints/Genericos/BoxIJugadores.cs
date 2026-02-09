using Constraints.Models;

namespace Constraints.Genericos;

public class BoxIJugadores<T>(T contenido) where T : IJugador {
    public T Contenido { get; set; } = contenido;
}