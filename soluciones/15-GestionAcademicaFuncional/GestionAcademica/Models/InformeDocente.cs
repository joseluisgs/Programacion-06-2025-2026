using GestionAcademica.Collections.Lista;

namespace GestionAcademica.Models;

/// <summary>
///     Contiene datos estadísticos consolidados y el listado ordenado del profesorado.
/// </summary>
public sealed record InformeDocente {
    /// <summary>
    ///     Listado de docentes ordenados por experiencia académica.
    /// </summary>
    public ILista<Docente> PorExperiencia { get; init; } = new Lista<Docente>();

    /// <summary>
    ///     Número total de docentes activos analizados.
    /// </summary>
    public int TotalDocentes { get; init; }

    /// <summary>
    ///     Media aritmética de los años de experiencia del profesorado.
    /// </summary>
    public double ExperienciaMedia { get; init; }
}