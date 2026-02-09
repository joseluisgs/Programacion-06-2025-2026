using GestionAcademica.Cache;
using GestionAcademica.Enums;
using GestionAcademica.Exceptions;
using GestionAcademica.Models;

namespace GestionAcademica.Services;

/// <summary>
///     Contrato para el servicio de gestión integral de personas (Estudiantes y Docentes).
///     Define la lógica de negocio, validaciones y orquestación de informes.
///     Todos los métodos de consulta devuelven IEnumerable para máximo desacoplamiento.
/// </summary>
public interface IPersonasService {
    /// <summary>
    ///     Obtiene la cantidad total de personas activas en el sistema.
    /// </summary>
    int TotalPersonas { get; }

    /// <summary>
    ///     Devuelve el listado completo de personas activas.
    /// </summary>
    /// <returns>Enumerable con todas las personas activas.</returns>
    IEnumerable<Persona> GetAll();

    /// <summary>
    ///     Devuelve el listado completo aplicando ordenamiento y filtros opcionales.
    /// </summary>
    /// <param name="orden">Criterio de ordenamiento para el listado.</param>
    /// <param name="filtro">Predicado opcional para filtrar los resultados.</param>
    /// <returns>Enumerable con las personas que cumplen los criterios.</returns>
    IEnumerable<Persona> GetAllOrderBy(TipoOrdenamiento orden = TipoOrdenamiento.Dni, Predicate<Persona>? filtro = null);

    /// <summary>
    ///     Devuelve el listado completo de estudiantes aplicando ordenamiento opcional.
    /// </summary>
    /// <param name="ordenamiento">Criterio de ordenamiento para el listado.</param>
    /// <returns>Enumerable con los estudiantes ordenados según el criterio.</returns>
    IEnumerable<Estudiante> GetEstudiantesOrderBy(TipoOrdenamiento ordenamiento = TipoOrdenamiento.Dni);

    /// <summary>
    ///     Devuelve el listado completo de docentes aplicando ordenamiento opcional.
    /// </summary>
    /// <param name="ordenamiento">Criterio de ordenamiento para el listado.</param>
    /// <returns>Enumerable con los docentes ordenados según el criterio.</returns>
    IEnumerable<Docente> GetDocentesOrderBy(TipoOrdenamiento ordenamiento = TipoOrdenamiento.Dni);

    /// <summary>
    ///     Localiza una persona activa por su identificador único.
    /// </summary>
    /// <param name="id">Identificador numérico de la persona.</param>
    /// <returns>La instancia de <see cref="Persona" /> encontrada.</returns>
    /// <exception cref="PersonasException.NotFound">Se lanza si el identificador no existe.</exception>
    Persona GetById(int id);

    /// <summary>
    ///     Localiza una persona activa mediante su Documento Nacional de Identidad.
    /// </summary>
    /// <param name="dni">DNI de la persona a buscar.</param>
    /// <returns>La instancia de <see cref="Persona" /> asociada al DNI.</returns>
    /// <exception cref="PersonasException.NotFound">Se lanza si el DNI no corresponde a ninguna persona activa.</exception>
    Persona GetByDni(string dni);

    /// <summary>
    ///     Realiza el registro de una nueva persona (Estudiante o Docente) tras aplicar validaciones.
    /// </summary>
    /// <param name="persona">Instancia de la persona a persistir.</param>
    /// <returns>La persona registrada con su ID y fechas de auditoría asignadas.</returns>
    /// <exception cref="PersonasException.Validation">Se lanza si la validación de campos falla.</exception>
    /// <exception cref="PersonasException.AlreadyExists">Se lanza si el DNI ya está en uso.</exception>
    Persona Save(Persona persona);

    /// <summary>
    ///     Sincroniza y actualiza los datos de una persona existente en el sistema.
    /// </summary>
    /// <param name="id">ID de la persona a actualizar.</param>
    /// <param name="persona">Instancia de la persona con los datos actualizados.</param>
    /// <returns>La persona actualizada con la nueva fecha de modificación.</returns>
    /// <exception cref="PersonasException.NotFound">Se lanza si no se encuentra el registro original.</exception>
    /// <exception cref="PersonasException.Validation">Se lanza si los nuevos datos no son válidos.</exception>
    Persona Update(int id, Persona persona);

    /// <summary>
    ///     Ejecuta el borrado físico de una persona identificada por su ID.
    /// </summary>
    /// <param name="id">ID de la persona a eliminar.</param>
    /// <returns>La instancia de la persona que ha sido marcada como eliminada.</returns>
    /// <exception cref="PersonasException.NotFound">Se lanza si el ID especificado no existe.</exception>
    Persona Delete(int id);

    /// <summary>
    ///     Procesa el listado de personas para generar métricas estadísticas sobre los estudiantes.
    /// </summary>
    /// <param name="ciclo">Filtro opcional por ciclo formativo.</param>
    /// <param name="curso">Filtro opcional por curso académico.</param>
    /// <returns>Un objeto <see cref="InformeEstudiante" /> con los totales y medias calculadas.</returns>
    InformeEstudiante GenerarInformeEstudiante(Ciclo? ciclo = null, Curso? curso = null);

    /// <summary>
    ///     Procesa el listado de personas para generar un informe detallado sobre los docentes.
    /// </summary>
    /// <param name="ciclo">Filtro opcional por ciclo formativo.</param>
    /// <returns>Un objeto <see cref="InformeDocente" /> con listados ordenados por experiencia y medias.</returns>
    InformeDocente GenerarInformeDocente(Ciclo? ciclo = null);
}