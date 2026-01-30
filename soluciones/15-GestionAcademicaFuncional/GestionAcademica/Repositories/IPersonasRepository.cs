using GestionAcademica.Models;
using GestionAcademica.Repositories.Common;

namespace GestionAcademica.Repositories;

/// <summary>
///     Contrato especializado para la gestión de personas (Estudiantes y Docentes).
///     Define las operaciones de búsqueda, persistencia y validación de identidad.
/// </summary>
public interface IPersonasRepository : ICrudRepository<int, Persona> {
    /// <summary>
    ///     Realiza una búsqueda por el Documento Nacional de Identidad.
    /// </summary>
    /// <param name="dni">DNI a localizar.</param>
    /// <returns>La persona asociada al DNI o null.</returns>
    Persona? GetByDni(string dni);

    /// <summary>
    ///     Verifica si un DNI ya se encuentra registrado y activo en el sistema.
    /// </summary>
    /// <param name="dni">DNI a comprobar.</param>
    /// <returns>True si el DNI está en uso; de lo contrario, false.</returns>
    bool ExisteDni(string dni);
}