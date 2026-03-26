using PlanificadorProcesos.Models;

namespace PlanificadorProcesos.Services;

/// <summary>
///     Planificador de prioridad basado en Dictionary + Queue.
///     Prioridad: 1 = máxima, 9 = mínima.
/// </summary>
/// <remarks>
///     Usa un Dictionary donde la clave es la prioridad y el valor es una Queue de procesos.
///     Al desencolar, busca la clave mínima (Prioridad 1) yExtrae de su cola.
///     Si la cola se queda vacía, elimina la clave.
/// </remarks>
public class PlanificadorPrioridadDictionaryCola : IPlanificadorProcesos {
    private readonly Dictionary<int, Queue<Proceso>> _cola = [];

    /// <summary>
    ///     Agrega un proceso a la cola según su prioridad.
    /// </summary>
    /// <param name="proceso">Proceso a agregar.</param>
    public void Encolar(Proceso proceso) {
        if (!_cola.ContainsKey(proceso.Prioridad)) _cola[proceso.Prioridad] = new Queue<Proceso>();
        _cola[proceso.Prioridad].Enqueue(proceso);
    }

    /// <summary>
    ///     Extrae el proceso con mayor prioridad (1 = máxima).
    ///     Busca la clave mínima (1) y extrae de su cola.
    /// </summary>
    /// <returns>El proceso extraído o null si está vacía.</returns>
    public Proceso? Desencolar() {
        if (_cola.Count == 0) return null;
        var prioridadMin = _cola.Keys.Min();
        var proceso = _cola[prioridadMin].Dequeue();
        if (_cola[prioridadMin].Count == 0)
            _cola.Remove(prioridadMin);
        return proceso;
    }

    /// <summary>
    ///     Obtiene el proceso con mayor prioridad sin extraerlo.
    /// </summary>
    /// <returns>El proceso o null si está vacía.</returns>
    public Proceso? Primero() {
        if (_cola.Count == 0) return null;
        var prioridadMin = _cola.Keys.Min();
        return _cola[prioridadMin].Peek();
    }

    /// <summary>
    ///     Verifica si la cola está vacía.
    /// </summary>
    /// <returns>True si está vacía, false en caso contrario.</returns>
    public bool EstaVacia() {
        return _cola.Count == 0;
    }

    /// <summary>
    ///     Obtiene el número de procesos en la cola.
    /// </summary>
    /// <returns>Número de procesos.</returns>
    public int Contar() {
        return _cola.Values.Sum(q => q.Count);
    }

    /// <summary>
    ///     Representación en cadena de la cola.
    /// </summary>
    /// <returns>Representación textual de la cola.</returns>
    public override string ToString() {
        var resultado = new List<string>();
        foreach (var prioridad in _cola.Keys.OrderBy(k => k))
            resultado.Add($"Prioridad {prioridad}: [{string.Join(", ", _cola[prioridad])}]");
        return "[" + string.Join(", ", resultado) + "]";
    }
}
