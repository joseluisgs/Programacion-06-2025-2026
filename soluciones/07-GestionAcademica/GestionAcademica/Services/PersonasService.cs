using GestionAcademica.Common.Lista;
using GestionAcademica.Enums;
using GestionAcademica.Exceptions;
using GestionAcademica.Models;
using GestionAcademica.Repositories;
using GestionAcademica.Validators.Common;

namespace GestionAcademica.Services;

/// <summary>
///     Servicio integral para la gestión de personas (Estudiantes y Docentes).
/// </summary>
public class PersonasService(
    IPersonasRepository repository,
    IValidador<Persona> valEstudiante,
    IValidador<Persona> valDocente) : IPersonasService {
    /// <inheritdoc cref="IPersonasService.TotalPersonas" />
    public int TotalPersonas => repository.GetAll().Contar();

    /// <inheritdoc cref="IPersonasService.Save" />
    public Persona Save(Persona persona) {
        var errores = persona switch {
            Estudiante => valEstudiante.Validar(persona),
            Docente => valDocente.Validar(persona),
            _ => throw new PersonasException.Validation(ErrorDeTipo("Tipo de persona no admitido."))
        };

        if (errores.Contar() > 0) throw new PersonasException.Validation(errores);

        return repository.Create(persona) ?? throw new PersonasException.AlreadyExists(persona.Dni);
    }

    /// <inheritdoc cref="IPersonasService.Update" />
    public Persona Update(Persona persona) {
        var errores = persona switch {
            Estudiante => valEstudiante.Validar(persona),
            Docente => valDocente.Validar(persona),
            _ => throw new PersonasException.Validation(ErrorDeTipo("Tipo no reconocido."))
        };

        if (errores.Contar() > 0) throw new PersonasException.Validation(errores);

        return repository.Update(persona.Id, persona) ?? throw new PersonasException.NotFound(persona.Id.ToString());
    }

    /// <inheritdoc cref="IPersonasService.GetById" />
    public Persona GetById(int id) {
        return repository.GetById(id) ?? throw new PersonasException.NotFound(id.ToString());
    }

    /// <inheritdoc cref="IPersonasService.GetByDni" />
    public Persona GetByDni(string dni) {
        return repository.GetByDni(dni) ?? throw new PersonasException.NotFound(dni);
    }

    /// <inheritdoc cref="IPersonasService.Delete" />
    public Persona Delete(int id) {
        return repository.Delete(id) ?? throw new PersonasException.NotFound(id.ToString());
    }

    /// <inheritdoc cref="IPersonasService.GetEstudiantesOrderBy" />
    public ILista<Estudiante> GetEstudiantesOrderBy(TipoOrdenamiento ordenamiento = TipoOrdenamiento.Dni) {
        var lista = GetAllOrderBy(ordenamiento);
        var filtrados = new Lista<Estudiante>();
        foreach (var p in lista)
            if (p is Estudiante e)
                filtrados.AgregarFinal(e);
        return filtrados;
    }

    /// <inheritdoc cref="IPersonasService.GetDocentesOrderBy" />
    public ILista<Docente> GetDocentesOrderBy(TipoOrdenamiento ordenamiento = TipoOrdenamiento.Dni) {
        var lista = GetAllOrderBy(ordenamiento);
        var filtrados = new Lista<Docente>();
        foreach (var p in lista)
            if (p is Docente d)
                filtrados.AgregarFinal(d);
        return filtrados;
    }

    /// <inheritdoc cref="IPersonasService.GetAllOrderBy" />
    public ILista<Persona> GetAllOrderBy(TipoOrdenamiento ordenamiento = TipoOrdenamiento.Dni) {
        var lista = FiltrarSegunOrdenamiento(ordenamiento);
        var n = lista.Contar();
        for (var i = 0; i < n - 1; i++) {
            for (var j = 0; j < n - i - 1; j++)
                if (DebeIntercambiar(lista.Obtener(j), lista.Obtener(j + 1), ordenamiento))
                    Intercambiar(lista, j, j + 1);
        }

        return lista;
    }

    /// <inheritdoc cref="IPersonasService.GenerarInformeEstudiante" />
    public InformeEstudiante GenerarInformeEstudiante(Ciclo? ciclo = null, Curso? curso = null) {
        var porNota = new Lista<Estudiante>();
        var total = 0;
        var aprobados = 0;
        var suspensos = 0;
        var suma = 0.0;

        foreach (var p in repository.GetAll())
            if (p is Estudiante e && (ciclo == null || e.Ciclo == ciclo) && (curso == null || e.Curso == curso)) {
                porNota.AgregarFinal(e);
                total++;
                suma += e.Calificacion;
                if (e.Calificacion >= 5.0) aprobados++;
                else suspensos++;
            }

        if (total > 0) OrdenarEstudiantesPorNota(porNota);
        return new InformeEstudiante {
            PorNota = porNota,
            TotalEstudiantes = total,
            Aprobados = aprobados,
            Suspensos = suspensos,
            NotaMedia = total > 0 ? suma / total : 0
        };
    }

    /// <inheritdoc cref="IPersonasService.GenerarInformeDocente" />
    public InformeDocente GenerarInformeDocente(Ciclo? ciclo = null) {
        var porExperiencia = new Lista<Docente>();
        var total = 0;
        var suma = 0.0;

        foreach (var p in repository.GetAll())
            if (p is Docente d && (ciclo == null || d.Ciclo == ciclo)) {
                porExperiencia.AgregarFinal(d);
                total++;
                suma += d.Experiencia;
            }

        if (total > 0) OrdenarDocentesPorExperiencia(porExperiencia);
        return new InformeDocente {
            PorExperiencia = porExperiencia,
            TotalDocentes = total,
            ExperienciaMedia = total > 0 ? suma / total : 0
        };
    }

    /// <summary>
    ///     Filtra la colección completa de personas según la compatibilidad del criterio de ordenación.
    ///     COMENTARIO DOCENTE: Esta fase es necesaria para evitar comparaciones imposibles (ej. Nota en un Docente).
    /// </summary>
    /// <param name="orden">Criterio que determina si se filtran tipos específicos.</param>
    /// <returns>Una sublista con las entidades compatibles para el ordenamiento.</returns>
    private ILista<Persona> FiltrarSegunOrdenamiento(TipoOrdenamiento orden) {
        var filtrada = new Lista<Persona>();
        foreach (var p in repository.GetAll()) {
            var incluir = orden switch {
                TipoOrdenamiento.Nota or TipoOrdenamiento.Curso => p is Estudiante,
                TipoOrdenamiento.Experiencia or TipoOrdenamiento.Modulo => p is Docente,
                _ => true
            };
            if (incluir) filtrada.AgregarFinal(p);
        }

        return filtrada;
    }

    /// <summary>
    ///     Evalúa si dos entidades de tipo Persona deben intercambiar su posición según el criterio.
    ///     COMENTARIO DOCENTE: Implementa lógica polimórfica mediante patrones de casting seguro (as).
    /// </summary>
    /// <param name="p1">Primera persona a comparar.</param>
    /// <param name="p2">Segunda persona a comparar.</param>
    /// <param name="orden">Atributo por el que se realiza la comparación.</param>
    /// <returns>True si el orden es incorrecto y requiere intercambio físico.</returns>
    private bool DebeIntercambiar(Persona p1, Persona p2, TipoOrdenamiento orden) {
        return orden switch {
            TipoOrdenamiento.Id => p1.Id > p2.Id, // ASC
            TipoOrdenamiento.Dni => string.Compare(p1.Dni, p2.Dni, StringComparison.OrdinalIgnoreCase) > 0, // ASC
            TipoOrdenamiento.Apellidos =>
                string.Compare(p1.Apellidos, p2.Apellidos, StringComparison.OrdinalIgnoreCase) > 0, // ASC
            TipoOrdenamiento.Nombre => string.Compare(p1.Nombre, p2.Nombre, StringComparison.OrdinalIgnoreCase) >
                                       0, // ASC
            TipoOrdenamiento.Nota => (p1 as Estudiante)?.Calificacion < (p2 as Estudiante)?.Calificacion, // DESC
            TipoOrdenamiento.Experiencia => (p1 as Docente)?.Experiencia < (p2 as Docente)?.Experiencia, // DESC
            TipoOrdenamiento.Curso => (p1 as Estudiante)?.Curso > (p2 as Estudiante)?.Curso, // ASC
            TipoOrdenamiento.Ciclo => string.Compare(ObtenerCicloTexto(p1), ObtenerCicloTexto(p2),
                StringComparison.OrdinalIgnoreCase) > 0, // ASC
            TipoOrdenamiento.Modulo => string.Compare((p1 as Docente)?.Especialidad, (p2 as Docente)?.Especialidad,
                StringComparison.OrdinalIgnoreCase) > 0, // ASC
            _ => false
        };
    }

    /// <summary>
    ///     Extrae la representación en texto del ciclo formativo de forma transversal.
    /// </summary>
    /// <param name="p">Persona de la que extraer el ciclo.</param>
    /// <returns>Cadena con el nombre del ciclo o string vacío si no aplica.</returns>
    private string ObtenerCicloTexto(Persona p) {
        return p switch { Estudiante e => e.Ciclo.ToString(), Docente d => d.Ciclo.ToString(), _ => string.Empty };
    }

    /// <summary>
    ///     Realiza el intercambio físico de dos nodos en la lista personalizada.
    ///     COMENTARIO DOCENTE: Debido a que ILista no tiene setter por índice, usamos el ciclo Eliminar/Agregar.
    /// </summary>
    /// <param name="lista">Lista sobre la que operar.</param>
    /// <param name="i">Índice del primer elemento.</param>
    /// <param name="j">Índice del segundo elemento.</param>
    private void Intercambiar(ILista<Persona> lista, int i, int j) {
        var v1 = lista.Obtener(i);
        var v2 = lista.Obtener(j);
        lista.EliminarEn(i);
        lista.AgregarEn(v2, i);
        lista.EliminarEn(j);
        lista.AgregarEn(v1, j);
    }

    /// <summary>
    ///     Algoritmo de burbuja optimizado para el ranking de estudiantes por nota descendente.
    /// </summary>
    /// <param name="lista">Lista de estudiantes a ordenar.</param>
    private void OrdenarEstudiantesPorNota(ILista<Estudiante> lista) {
        var n = lista.Contar();
        for (var i = 0; i < n - 1; i++)
            for (var j = 0; j < n - i - 1; j++)
                if (lista.Obtener(j).Calificacion < lista.Obtener(j + 1).Calificacion) {
                    var e1 = lista.Obtener(j);
                    var e2 = lista.Obtener(j + 1);
                    lista.EliminarEn(j);
                    lista.AgregarEn(e2, j);
                    lista.EliminarEn(j + 1);
                    lista.AgregarEn(e1, j + 1);
                }
    }

    /// <summary>
    ///     Algoritmo de burbuja optimizado para el ranking de docentes por veteranía descendente.
    /// </summary>
    /// <param name="lista">Lista de docentes a ordenar.</param>
    private void OrdenarDocentesPorExperiencia(ILista<Docente> lista) {
        var n = lista.Contar();
        for (var i = 0; i < n - 1; i++)
            for (var j = 0; j < n - i - 1; j++)
                if (lista.Obtener(j).Experiencia < lista.Obtener(j + 1).Experiencia) {
                    var d1 = lista.Obtener(j);
                    var d2 = lista.Obtener(j + 1);
                    lista.EliminarEn(j);
                    lista.AgregarEn(d2, j);
                    lista.EliminarEn(j + 1);
                    lista.AgregarEn(d1, j + 1);
                }
    }

    /// <summary>
    ///     Genera una lista de errores con un único mensaje de fallo de tipo.
    /// </summary>
    /// <param name="msg">Mensaje descriptivo del error.</param>
    /// <returns>Colección con el error de integridad.</returns>
    private static ILista<string> ErrorDeTipo(string msg) {
        var l = new Lista<string>();
        l.AgregarFinal(msg);
        return l;
    }
}