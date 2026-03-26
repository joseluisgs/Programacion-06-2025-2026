using GestionAcademica.Exceptions.Common;

namespace GestionAcademica.Exceptions;

/// <summary>
///     Contenedor de excepciones específicas para el dominio de Personas.
/// </summary>
public abstract class PersonasException(string message) : DomainException(message) {
    /// <summary>Se lanza cuando no existe el registro solicitado.</summary>
    public sealed class NotFound(string id)
        : PersonasException($"No se ha encontrado ninguna persona con el identificador: {id}");

    /// <summary>Se lanza cuando fallan las reglas de validación de negocio.</summary>
    public sealed class Validation(IEnumerable<string> errors)
        : PersonasException("Se han detectado errores de validación en la entidad.") {
        public IEnumerable<string> Errores { get; init; } = errors;
    }

    /// <summary>Se lanza ante conflictos de duplicidad (DNI).</summary>
    public sealed class AlreadyExists(string dni)
        : PersonasException($"Conflicto de integridad: El DNI {dni} ya está registrado en el sistema.");
}