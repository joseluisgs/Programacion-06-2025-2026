using PlanificadorProcesos.Models;

namespace PlanificadorProcesos.Services;

/// <summary>
///     Planificador de prioridad basado en Dictionary + LinkedList.
///     Prioridad: 1 = máxima, 9 = mínima.
/// </summary>
/// <remarks>
///     Usa un Dictionary donde la clave es la prioridad y el valor es una LinkedList.
///     Ventaja sobre Queue: mejor eficiencia en memoria para colas pequeñas.
///     Cada nodo de LinkedList usa: valor + 2 referencias (prev/next).
/// </remarks>
public class PlanificadorPrioridadDictionaryLinkedList : IPlanificadorProcesos {
    private readonly Dictionary<int, LinkedList<Proceso>> _cola = [];

    /// <summary>
    ///     Agrega un proceso a la cola según su prioridad.
    /// </summary>
    /// <param name="proceso">Proceso a agregar.</param>
    public void Encolar(Proceso proceso) {
        if (!_cola.ContainsKey(proceso.Prioridad))
            _cola[proceso.Prioridad] = new LinkedList<Proceso>();
        _cola[proceso.Prioridad].AddLast(proceso);
    }

    /// <summary>
    ///     Extrae el proceso con mayor prioridad (1 = máxima).
    /// </summary>
    /// <returns>El proceso extraído o null si está vacía.</returns>
    public Proceso? Desencolar() {
        if (_cola.Count == 0) return null;
        var prioridadMin = _cola.Keys.Min();
        var nodo = _cola[prioridadMin].First;
        if (nodo != null) {
            var proceso = nodo.Value;
            _cola[prioridadMin].Remove(nodo);
            if (_cola[prioridadMin].Count == 0)
                _cola.Remove(prioridadMin);
            return proceso;
        }
        return null;
    }

    /// <summary>
    ///     Obtiene el proceso con mayor prioridad sin extraerlo.
    /// </summary>
    /// <returns>El proceso o null si está vacía.</returns>
    public Proceso? Primero() {
        if (_cola.Count == 0) return null;
        var prioridadMin = _cola.Keys.Min();
        return _cola[prioridadMin].First?.Value;
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
    public int Contar() => _cola.Values.Sum(q => q.Count);

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
