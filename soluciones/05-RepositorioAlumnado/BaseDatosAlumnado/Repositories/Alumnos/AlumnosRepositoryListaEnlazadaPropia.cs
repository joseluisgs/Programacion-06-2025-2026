using BaseDatosAlumnado.Common.Lista;
using BaseDatosAlumnado.Enums;
using BaseDatosAlumnado.Factories;
using BaseDatosAlumnado.Models;
using Serilog;

namespace BaseDatosAlumnado.Repositories.Alumnos;

public class AlumnosRepositoryListaEnlazadaPropia : IAlumnosRepository {
    private static AlumnosRepositoryListaEnlazadaPropia? _instance;
    private static int _idCounter;
    private readonly ILista<Alumno> _listado = new Lista<Alumno>();
    private readonly ILogger _log = Log.ForContext<AlumnosRepositoryListaEnlazadaPropia>();

    private AlumnosRepositoryListaEnlazadaPropia() {
        _log.Debug("Creando instancia de AlumnosRepository");
        // inicializamos alumnos de prueba
        InitDemoAlumnos();
    }

    /// <inheritdoc />
    public int TotalAlumnos => _listado.Contar();

    /// <inheritdoc />
    public ILista<Alumno> GetAlumnosOrderBy(TipoOrdenamiento ordenamiento = TipoOrdenamiento.Dni) {
        _log.Debug($"Ordenando alumnos por {ordenamiento}");
        var alumnosArray = new Alumno[_listado.Contar()];
        var n = alumnosArray.Length;
        // Copiamos los alumnos al array
        for (var i = 0; i < _listado.Contar(); i++)
            alumnosArray[i] = _listado.Obtener(i);

        for (var i = 0; i < n - 1; i++) {
            for (var j = 0; j < n - i - 1; j++) {
                var debeIntercambiar = false;
                var alumnoJ = alumnosArray[j];
                var alumnoJ1 = alumnosArray[j + 1];

                if (ordenamiento == TipoOrdenamiento.Dni) {
                    // Ordenar por DNI (Ascendente). CompareTo > 0 significa que alumnoJ es lexicográficamente mayor.
                    // Se usa así porque noe s un número sino una cadena: string
                    if (string.Compare(alumnoJ.Dni, alumnoJ1.Dni, StringComparison.Ordinal) > 0)
                        debeIntercambiar = true;
                }
                else if (ordenamiento == TipoOrdenamiento.Nota) {
                    // Ordenar por Nota (Descendente). Si la nota actual es MENOR que la siguiente, debe intercambiarse.
                    if (alumnoJ.Nota < alumnoJ1.Nota) debeIntercambiar = true;
                }

                if (debeIntercambiar)
                    (alumnosArray[j], alumnosArray[j + 1]) = (alumnosArray[j + 1], alumnosArray[j]);
            }
        }

        // Creamos una nueva lista con los alumnos ordenados
        var sortedList = new Lista<Alumno>();
        foreach (var alumno in alumnosArray)
            sortedList.AgregarFinal(alumno);
        return sortedList;
    }

    public Alumno GetAlumnoPorDni(string dni) {
        _log.Debug($"Buscando alumno por DNI: {dni}");
        foreach (var alumno in _listado)
            if (alumno.Dni.Equals(dni, StringComparison.OrdinalIgnoreCase))
                return alumno;
        throw new KeyNotFoundException($"Alumno con DNI {dni} no encontrado.");
    }


    /// <inheritdoc />
    public ILista<Alumno> GetAll() {
        _log.Debug("Obteniendo todos los alumnos");
        return _listado;
    }

    /// <inheritdoc />
    public Alumno? GetById(int id) {
        _log.Debug($"Obteniendo alumno con id: {id}");
        foreach (var alumno in _listado)
            if (alumno.Id == id)
                return alumno;
        return null;
    }

    /// <inheritdoc />
    public Alumno? Create(Alumno entity) {
        _log.Debug("Creando alumno: {Alumno}", entity);

        // Comprobamos si el alumno ya existe
        if (Exists(entity)) {
            _log.Warning("El alumno ya existe: {Alumno}", entity);
            return null;
        }

        // Asignamos un ID único y las fechas de creación y actualización
        var saved = entity with {
            Id = GetNextId(),
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        // Añadimos el alumno al listado y devolvemos el alumno guardado
        _listado.AgregarFinal(saved);
        return saved;
    }

    /// <inheritdoc />
    public Alumno? Update(int id, Alumno entity) {
        _log.Debug("Actualizando alumno con id: {Id}", id);

        // Comprobamos si el alumno existe y obtenemos su índice
        var index = IndexOf(id);
        if (index == -1) {
            _log.Warning("El alumno con id {Id} no existe", id);
            return null;
        }

        // Actualizamos el alumno y devolvemos el alumno actualizado
        var updated = entity with {
            Id = id,
            UpdatedAt = DateTime.Now
        };

        // Actualizamos el alumno en el listado y devolvemos el alumno actualizado
        _listado.AgregarEn(updated, index);
        return updated;
    }

    /// <inheritdoc />
    public Alumno? Delete(int id) {
        _log.Debug("Eliminando alumno con id: {Id}", id);

        // Comprobamos si el alumno existe y obtenemos su índice
        var index = IndexOf(id);
        if (index == -1) {
            _log.Warning("El alumno con id {Id} no existe", id);
            return null;
        }

        // Obtenemos el alumno a eliminar y marcamos como eliminado
        var alumnoToDelete = _listado.Obtener(index) with {
            IsDeleted = true
        };

        // Eliminamos el alumno del listado y devolvemos el alumno eliminado
        _listado.EliminarEn(index);
        return alumnoToDelete;
    }

    /// <summary>
    ///     Consigue la instancia única del repositorio.
    /// </summary>
    /// <returns>Instancia única de AlumnosRepository.</returns>
    public static AlumnosRepositoryListaEnlazadaPropia GetInstance() {
        return _instance ??= new AlumnosRepositoryListaEnlazadaPropia();
    }

    /// <summary>
    ///     Inicializa el repositorio con datos de alumnos de prueba.
    /// </summary>
    private void InitDemoAlumnos() {
        _log.Debug("Inicializando alumnos de prueba");
        var demoAlumnos = AlumnoFactory.DemoData();
        // Añadimos los alumnos de prueba al repositorio
        foreach (var alumno in demoAlumnos)
            Create(alumno);
    }

    /// <summary>
    ///     Genesigue el siguiente ID único para un nuevo alumno.
    /// </summary>
    private static int GetNextId() {
        return ++_idCounter;
    }

    private bool Exists(Alumno alumno) {
        _log.Debug("Comprobando existencia del alumno: {Alumno}", alumno);
        foreach (var al in _listado)
            if (al.Equals(alumno))
                return true;
        return false;
    }

    private int IndexOf(int id) {
        _log.Debug("Buscando índice del alumno con id: {Id}", id);
        for (var i = 0; i < _listado.Contar(); i++)
            if (_listado.Obtener(i).Id == id)
                return i;
        return -1;
    }
}