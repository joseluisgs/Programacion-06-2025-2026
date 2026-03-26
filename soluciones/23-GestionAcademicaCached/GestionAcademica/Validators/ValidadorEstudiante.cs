using GestionAcademica.Models;
using GestionAcademica.Validators.Common;

namespace GestionAcademica.Validators;

/// <summary>
///     Validador especializado para la entidad Estudiante.
///     Acumula todos los errores de integridad detectados en la entidad.
/// </summary>
public class ValidadorEstudiante : IValidador<Persona> {
    public IEnumerable<string> Validar(Persona persona) {
        var errores = new List<string>();

        if (persona is not Estudiante estudiante) {
            errores.Add("La entidad proporcionada no es un Estudiante.");
            return errores;
        }

        if (string.IsNullOrWhiteSpace(estudiante.Nombre) || estudiante.Nombre.Length < 2)
            errores.Add("El nombre es obligatorio (mín. 2 car.).");

        if (string.IsNullOrWhiteSpace(estudiante.Apellidos) || estudiante.Apellidos.Length < 2)
            errores.Add("Los apellidos son obligatorios (mín. 2 car.).");

        if (estudiante.Calificacion is < 0 or > 10)
            errores.Add("La calificación debe estar entre 0.0 y 10.0.");

        if (!Enum.IsDefined(typeof(Ciclo), estudiante.Ciclo))
            errores.Add("El ciclo formativo no es válido.");

        if (!Enum.IsDefined(typeof(Curso), estudiante.Curso))
            errores.Add("El curso académico no es válido (Primero o Segundo).");

        return errores;
    }
}