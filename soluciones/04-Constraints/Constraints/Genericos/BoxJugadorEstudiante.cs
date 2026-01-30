using Constraints.Models;

namespace Constraints.Genericos;

public class BoxJugadorEstudiante<T>(T contenido) where T : IJugador, IAlumno {
    public T Contenido { get; set; } = contenido;
}