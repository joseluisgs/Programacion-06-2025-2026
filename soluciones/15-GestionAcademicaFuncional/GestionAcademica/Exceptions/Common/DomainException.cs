namespace GestionAcademica.Exceptions.Common;

/// <summary>
///     Clase base abstracta para todas las excepciones del dominio académico.
///     Se ubica en Common porque define el contrato raíz para cualquier error de negocio.
/// </summary>
public abstract class DomainException(string message) : Exception(message);