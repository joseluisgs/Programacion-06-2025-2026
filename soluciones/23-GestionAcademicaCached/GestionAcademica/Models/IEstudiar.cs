namespace GestionAcademica.Models;

/// <summary>
///     Define las acciones para una entidad que realiza actividades de estudio.
/// </summary>
public interface IEstudiar {
    /// <summary>
    ///     Realiza la acción de estudiar dentro del contexto académico.
    /// </summary>
    void Estudiar();
}