using BaseDatosAlumnado.Models;
using Serilog;

namespace BaseDatosAlumnado.Factories;

/// <summary>
///     Clase que genera datos de prueba para Alumnos.
/// </summary>
public static class AlumnoFactory {
    private static readonly ILogger _log = Log.ForContext(typeof(AlumnoFactory));

    /// <summary>
    ///     Genera un conjunto de datos de prueba para Alumnos.
    /// </summary>
    /// <returns>Un vector de Alumnos con datos de prueba.</returns>
    public static Alumno[] DemoData() {
        _log.Information("Inicializando datos de prueba para Alumnos...");
        var lista = new Alumno[3];

        var a1 = new Alumno
            { Dni = "48612345M", NombreCompleto = "Juan Pérez", Nota = 8.50 };
        var a2 = new Alumno
            { Dni = "87654321X", NombreCompleto = "Ana García", Nota = 4.25 };
        var a3 = new Alumno
            { Dni = "11111111H", NombreCompleto = "Carlos Ruiz", Nota = 10.00 };


        // Asignación a las primeras posiciones del vector
        lista[0] = a1; // ID 1
        lista[1] = a2; // ID 2
        lista[2] = a3; // ID 3

        return lista;
    }
}