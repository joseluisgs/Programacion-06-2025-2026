namespace GestionAcademica.Models;

/// <summary>
///     Contiene datos estadísticos consolidados y el listado ordenado del estudiantado.
/// </summary>
public sealed record InformeEstudiante {
    /// <summary>
    ///     Listado de estudiantes ordenados por calificación de forma descendente.
    /// </summary>
    public IEnumerable<Estudiante> PorNota { get; init; } = Enumerable.Empty<Estudiante>();

    /// <summary>
    ///     Número total de estudiantes activos analizados.
    /// </summary>
    public int TotalEstudiantes { get; init; }

    /// <summary>
    ///     Número total de estudiantes con calificación mayor o igual a la de aprobado.
    /// </summary>
    public int Aprobados { get; init; }

    /// <summary>
    ///     Número total de estudiantes con calificación inferior a la de aprobado.
    /// </summary>
    public int Suspensos { get; init; }

    /// <summary>
    ///     Nota media aritmética del estudiantado.
    /// </summary>
    public double NotaMedia { get; init; }

    /// <summary>
    ///     Porcentaje de estudiantes aprobados respecto al total analizado.
    /// </summary>
    public double PorcentajeAprobados => TotalEstudiantes > 0 ? (double)Aprobados / TotalEstudiantes * 100 : 0;
}