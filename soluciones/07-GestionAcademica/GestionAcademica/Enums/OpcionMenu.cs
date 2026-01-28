namespace GestionAcademica.Enums;

/// <summary>
///     Opciones del menú principal organizadas jerárquicamente.
/// </summary>
public enum OpcionMenu {
    Salir = 0,

    // Bloque General (Prioridad 1)
    ListarTodas = 1,
    BuscarDni = 2,
    BuscarId = 3,

    // Bloque Estudiantes
    ListarEstudiantes = 4,
    AnadirEstudiante = 5,
    ActualizarEstudiante = 6,
    EliminarEstudiante = 7,
    InformeEstudiantes = 8,

    // Bloque Docentes
    ListarDocentes = 9,
    AnadirDocente = 10,
    ActualizarDocente = 11,
    EliminarDocente = 12,
    InformeDocentes = 13
}