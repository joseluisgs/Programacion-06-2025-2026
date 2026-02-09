namespace GestionAcademica.Validators.Common;

/// <summary>
///     Contrato genérico para la validación de reglas de negocio en entidades.
/// </summary>
/// <typeparam name="T">Tipo de la entidad a validar.</typeparam>
public interface IValidador<in T> {
    /// <summary>
    ///     Evalúa si la instancia proporcionada cumple con los requisitos del sistema.
    /// </summary>
    /// <param name="entidad">Objeto de tipo <typeparamref name="T" /> a validar.</param>
    /// <returns>Enumerable con los errores detectados.</returns>
    IEnumerable<string> Validar(T entidad);
}