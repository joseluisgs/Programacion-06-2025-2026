using PlanificadorProcesos.Models;

namespace PlanificadorProcesos.Services;

/// <summary>
///     Planificador de prioridad basado en SortedSet.
///     Prioridad: 1 = máxima, 9 = mínima.
/// </summary>
/// <remarks>
///     Usa SortedSet con un comparador que ordena por prioridad.
///     Min() devuelve el proceso con Prioridad 1 (menor valor = máxima prioridad).
///     Si hay empate en prioridad, ordena por ID.
/// </remarks>
public class PlanificadorPrioridadSortedSet : IPlanificadorProcesos {
    private readonly SortedSet<Proceso> _cola = new(new ComparadorProceso());

    /// <summary>
    ///     Agrega un proceso a la cola.
    /// </summary>
    /// <param name="proceso">Proceso a agregar.</param>
    public void Encolar(Proceso proceso) {
        _cola.Add(proceso);
    }

    /// <summary>
    ///     Extrae el proceso con mayor prioridad (1 = máxima).
    ///     Min() devuelve el elemento con menor valor según el comparador.
    /// </summary>
    /// <returns>El proceso extraído o null si está vacía.</returns>
    public Proceso? Desencolar() {
        if (_cola.Count == 0) return null;
        var proceso = _cola.Min;
        if (proceso != null) _cola.Remove(proceso);
        return proceso;
    }

    /// <summary>
    ///     Obtiene el proceso con mayor prioridad sin extraerlo.
    /// </summary>
    /// <returns>El proceso o null si está vacía.</returns>
    public Proceso? Primero() {
        return _cola.Count > 0 ? _cola.Min : null;
    }

    /// <summary>
    ///     Verifica si la cola está vacía.
    /// </summary>
    /// <returns>True si está vacía, false en caso contrario.</returns>
    public bool EstaVacia() => _cola.Count == 0;

    /// <summary>
    ///     Obtiene el número de procesos en la cola.
    /// </summary>
    /// <returns>Número de procesos.</returns>
    public int Contar() => _cola.Count;

    /// <summary>
    ///     Representación en cadena de la cola.
    /// </summary>
    /// <returns>Representación textual de la cola.</returns>
    public override string ToString() {
        return "[" + string.Join(", ", _cola) + "]";
    }
}

/// <summary>
///     Comparador para SortedSet que ordena por prioridad y luego por ID.
/// </summary>
public class ComparadorProceso : IComparer<Proceso> {
    /// <summary>
    ///     Compara dos procesos por prioridad y luego por ID.
    ///     Prioridad menor (1) se considera "menor" y sale primero.
    /// </summary>
    public int Compare(Proceso? x, Proceso? y) {
        if (x == null || y == null) return 0;
        if (x.Prioridad != y.Prioridad)
            return x.Prioridad.CompareTo(y.Prioridad);
        return x.Id.CompareTo(y.Id);
    }
}
