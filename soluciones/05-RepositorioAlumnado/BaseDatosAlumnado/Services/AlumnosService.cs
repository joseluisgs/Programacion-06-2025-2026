using BaseDatosAlumnado.Common.Lista;
using BaseDatosAlumnado.Config;
using BaseDatosAlumnado.Enums;
using BaseDatosAlumnado.Models;
using BaseDatosAlumnado.Repositories.Alumnos;
using BaseDatosAlumnado.Validators;
using Serilog;

namespace BaseDatosAlumnado.Services;

/// <summary>
///     Servicio para administrar los alumnos.
/// </summary>
/// <param name="repository">Repositorio del alumnado</param>
/// <param name="validador">Validador de alumno/a</param>
public class AlumnosService(
    IAlumnosRepository repository,
    IAlumnoValidator validador
) : IAlumnosService {
    private readonly ILogger _log = Log.ForContext<AlumnosService>();

    /// <inheritdoc />
    public int TotalAlumnos { get; } = repository.TotalAlumnos;


    /// <inheritdoc />
    public ILista<Alumno> GetAllOrderBy(TipoOrdenamiento ordenamiento = TipoOrdenamiento.Dni) {
        _log.Information("Obteniendo todos los alumnos con ordenamiento: {Ordenamiento}", ordenamiento);
        return repository.GetAlumnosOrderBy(ordenamiento);
    }

    /// <inheritdoc />
    public Alumno GetById(int id) {
        _log.Information("Obteniendo alumno por ID: {Id}", id);
        return repository.GetById(id)
               ?? throw new KeyNotFoundException($"No se encontró al alumno con ID: {id}");
    }

    /// <inheritdoc />
    public Alumno GetByDni(string dni) {
        _log.Information("Obteniendo alumno por DNI: {Dni}", dni);
        return repository.GetAlumnoPorDni(dni)
               ?? throw new KeyNotFoundException($"Alumno con DNI {dni} no encontrado.");
    }


    /// <inheritdoc />
    public Alumno Delete(int id) {
        _log.Information("Eliminando alumno con ID: {Id}", id);
        return repository.Delete(id) ??
               throw new KeyNotFoundException($"Alumno con ID {id} no encontrado para eliminación.");
    }

    /// <summary>
    ///     Actualiza un alumno existente.
    /// </summary>
    /// <param name="alumno">Alumno con los datos actualizados</param>
    /// <returns>Alumno actualizado</returns>
    /// <exception cref="KeyNotFoundException">Si no se encuentra el alumno para actualizar</exception>
    public Alumno Update(Alumno alumno) {
        _log.Information("Actualizando alumno: {Alumno}", alumno);
        // Validar el alumno antes de actualizarlo
        var alumnoValidado = validador.Validate(alumno);

        // Buscar el alumno original en la base de datos
        return repository.Update(alumnoValidado.Id, alumnoValidado)
               ?? throw new KeyNotFoundException(
                   $"Alumno con ID {alumnoValidado.Id} no encontrado para actualización.");
    }


    /// <inheritdoc />
    public Informe Informe() {
        _log.Information("Generando informe");
        var totalNotas = 0.0;
        var aprobados = 0;
        var suspensos = 0;

        var alumnos = repository.GetAll();

        // Se recorre el vector principal directamente
        foreach (var alumno in alumnos) {
            totalNotas += alumno.Nota;
            if (alumno.Nota >= Configuracion.NotaAprobado) // Criterio de aprobado (constante 5.00m)
                aprobados = aprobados + 1;
            else
                suspensos = suspensos + 1;
        }

        // División con decimal para mantener la precisión
        var notaMedia = totalNotas / TotalAlumnos;

        return new Informe(TotalAlumnos, aprobados, aprobados * 100.0 / TotalAlumnos,
            suspensos, suspensos * 100.0 / TotalAlumnos, notaMedia);
    }

    public Alumno Save(Alumno alumno) {
        _log.Information("Guardando nuevo alumno: {Alumno}", alumno);
        // Validar el alumno antes de guardarlo
        var alumnoValidado = validador.Validate(alumno);
        // Guardar el alumno en el repositorio
        return repository.Create(alumnoValidado) ?? throw new ArgumentException(
            $"No se pudo guardar el alumno con DNI {alumnoValidado.Dni}, puede que ya exista.");
    }
}