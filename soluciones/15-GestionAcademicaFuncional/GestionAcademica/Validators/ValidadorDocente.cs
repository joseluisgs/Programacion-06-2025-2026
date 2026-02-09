using GestionAcademica.Collections.Lista;
using GestionAcademica.Models;
using GestionAcademica.Validators.Common;

namespace GestionAcademica.Validators;

/// <summary>
///     Validador especializado para la entidad Docente.
///     Acumula todos los errores de integridad detectados en la entidad.
/// </summary>
public class ValidadorDocente : IValidador<Persona> {
    public ILista<string> Validar(Persona persona) {
        var errores = new Lista<string>();

        if (persona is not Docente docente) {
            errores.AddLast("La entidad proporcionada no es un Docente.");
            return errores;
        }

        if (string.IsNullOrWhiteSpace(docente.Nombre) || docente.Nombre.Length < 2)
            errores.AddLast("El nombre del docente es obligatorio (mín. 2 car.).");

        if (string.IsNullOrWhiteSpace(docente.Apellidos) || docente.Apellidos.Length < 2)
            errores.AddLast("Los apellidos del docente son obligatorios (mín. 2 car.).");

        if (docente.Experiencia < 0)
            errores.AddLast("Los años de experiencia no pueden ser negativos.");

        if (string.IsNullOrWhiteSpace(docente.Especialidad))
            errores.AddLast("La especialidad o módulo docente debe estar definida.");

        if (!Enum.IsDefined(typeof(Ciclo), docente.Ciclo))
            errores.AddLast("El ciclo asignado no es un ciclo oficial válido.");

        return errores;
    }
}