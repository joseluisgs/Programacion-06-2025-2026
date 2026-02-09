namespace BaseDatosAlumnado.Models;

/// <summary>
///     Representa un informe estadístico sobre los alumnos.
/// </summary>
public record Informe(
    int TotalAlumnos,
    int AlumnosAprobados,
    double PorcentajeAprobados,
    int AlumnosSuspensos,
    double PorcentajeSuspensos,
    double NotaMedia
);