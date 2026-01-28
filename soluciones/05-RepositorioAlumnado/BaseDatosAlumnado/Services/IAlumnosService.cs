using BaseDatosAlumnado.Common.Lista;
using BaseDatosAlumnado.Enums;
using BaseDatosAlumnado.Models;

namespace BaseDatosAlumnado.Services;

public interface IAlumnosService {
    /// <summary>
    ///     Obtiene el total de alumnos en la base de datos.
    /// </summary>
    /// <returns>Total de alumnos</returns>
    int TotalAlumnos { get; }

    /// <summary>
    ///     Obtiene todos los alumnos ordenados según el criterio especificado.
    /// </summary>
    /// <param name="ordenamiento">Criterio de ordenamiento (Dni o Nota).</param>
    /// <returns>Alumnos ordenados según el criterio.</returns>
    /// <see cref="TipoOrdenamiento" />
    ILista<Alumno> GetAllOrderBy(TipoOrdenamiento ordenamiento = TipoOrdenamiento.Dni);

    /// <summary>
    ///     Obtiene un alumno por su ID.
    /// </summary>
    /// <param name="id">ID del alumno</param>
    /// <returns>Alumno encontrado</returns>
    /// <exception cref="KeyNotFoundException">Si no se encuentra el alumno</exception>
    public Alumno GetById(int id);

    /// <summary>
    ///     Obtiene un alumno por su DNI.
    /// </summary>
    /// <param name="dni">DNI del alumno</param>
    /// <returns>Alumno encontrado</returns>
    /// <exception cref="KeyNotFoundException">Si no se encuentra el alumno</exception
    Alumno GetByDni(string dni);

    /// <summary>
    ///     Crea un nuevo alumno en la base de datos.
    /// </summary>
    /// <param name="alumno">Objeto Alumno a crear.</param>
    /// <returns>Alumno creado</returns>
    /// <exception cref="ArgumentException">Si el alumno ya existe</exception>
    Alumno Save(Alumno alumno);

    /// <summary>
    ///     Actualiza los datos de un alumno existente.
    /// </summary>
    /// <param name="alumno">Objeto Alumno con los datos actualizados.</param>
    /// <returns>Alumno actualizado</returns>
    /// <exception cref="KeyNotFoundException">Si no se encuentra el alumno</exception>
    Alumno Update(Alumno alumno);

    /// <summary>
    ///     Elimina un alumno por su ID.
    /// </summary>
    /// <param name="id">ID del alumno</param>
    /// <returns>Alumno eliminado</returns>
    /// <exception cref="KeyNotFoundException">Si no se encuentra el alumno</exception>
    Alumno Delete(int id);

    /// <summary>
    ///     Genera un informe estadístico del alumnado.
    /// </summary>
    /// <returns>Informe estadístico</returns>
    Informe Informe();
}