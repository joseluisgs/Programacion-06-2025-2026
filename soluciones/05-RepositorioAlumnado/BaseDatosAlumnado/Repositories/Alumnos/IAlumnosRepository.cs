using BaseDatosAlumnado.Common.Lista;
using BaseDatosAlumnado.Enums;
using BaseDatosAlumnado.Models;
using BaseDatosAlumnado.Repositories.Common;

namespace BaseDatosAlumnado.Repositories.Alumnos;

/// <summary>
///     Repositorio para la gestión de alumnos.
///     Concretiza las operaciones CRUD definidas en ICrudRepository y añade
///     un método específico para obtener los alumnos ordenados por nota descendente.
/// </summary>
public interface IAlumnosRepository : ICrudRepository<int, Alumno> {
    /// <summary>
    ///     Total de alumnos en el repositorio.
    /// </summary>
    public int TotalAlumnos { get; }

    /// <summary>
    ///     Obtiene todos los alumnos ordenados según el criterio especificado.
    /// </summary>
    /// <param name="ordenamiento">Criterio de ordenamiento (Dni o Nota).</param>
    /// <returns>Alumnos ordenados según el criterio.</returns>
    /// <see cref="TipoOrdenamiento" />
    ILista<Alumno> GetAlumnosOrderBy(TipoOrdenamiento ordenamiento = TipoOrdenamiento.Dni);

    /// <summary>
    ///     Obtiene un alumno por su DNI.
    /// </summary>
    /// <param name="dni">DNI del alumno.</param>
    /// <returns>Alumno encontrado o null si no existe.</returns>
    Alumno GetAlumnoPorDni(string dni);
}