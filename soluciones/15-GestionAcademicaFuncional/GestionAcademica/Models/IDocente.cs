namespace GestionAcademica.Models;

/// <summary>
///     Define las capacidades de un docente para impartir formación.
/// </summary>
public interface IDocente {
    /// <summary>
    ///     Ejecuta la acción de impartir una sesión lectiva.
    /// </summary>
    void ImpartirClase();
}