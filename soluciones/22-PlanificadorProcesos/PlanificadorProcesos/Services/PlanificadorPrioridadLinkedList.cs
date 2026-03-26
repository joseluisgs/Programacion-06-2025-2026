using PlanificadorProcesos.Models;

namespace PlanificadorProcesos.Services;

/// <summary>
///     Planificador de prioridad basado en LinkedList.
///     Prioridad: 1 = máxima, 9 = mínima.
/// </summary>
/// <remarks>
///     Al desencolar, busca el nodo con menor prioridad (1) y lo extrae.
///     Inserción: O(1) al final.
///     Extracción: O(n) al buscar el nodo con prioridad máxima.
/// </remarks>
public class PlanificadorPrioridadLinkedList : IPlanificadorProcesos {
    private readonly LinkedList<Proceso> _cola = new();

    /// <summary>
    ///     Agrega un proceso al final de la cola.
    /// </summary>
    /// <param name="proceso">Proceso a agregar.</param>
    public void Encolar(Proceso proceso) {
        _cola.AddLast(proceso);
    }

    /// <summary>
    ///     Extrae el proceso con mayor prioridad (1 = máxima).
    ///     Recorre la lista buscando el nodo con menor valor de prioridad.
    /// </summary>
    /// <returns>El proceso extraído o null si está vacía.</returns>
    public Proceso? Desencolar() {
        if (_cola.Count == 0) return null;

        var nodoMayorPrioridad = _cola.First;
        var procesoMayor = nodoMayorPrioridad?.Value;

        foreach (var nodo in _cola) {
            if (nodo.Prioridad < procesoMayor!.Prioridad) {
                procesoMayor = nodo;
                nodoMayorPrioridad = _cola.Find(nodo);
            }
        }

        if (nodoMayorPrioridad != null) {
            _cola.Remove(nodoMayorPrioridad);
        }

        return procesoMayor;
    }

    /// <summary>
    ///     Obtiene el proceso con mayor prioridad sin extraerlo.
    /// </summary>
    /// <returns>El proceso o null si está vacía.</returns>
    public Proceso? Primero() {
        if (_cola.Count == 0) return null;

        var procesoMayor = _cola.First?.Value;

        foreach (var nodo in _cola) {
            if (procesoMayor == null || nodo.Prioridad < procesoMayor.Prioridad) {
                procesoMayor = nodo;
            }
        }

        return procesoMayor;
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
