using PlanificadorProcesos.Models;

namespace PlanificadorProcesos.Services;

/// <summary>
///     Planificador FIFO basado en LinkedList.
/// </summary>
/// <remarks>
///     LinkedList permite inserción y extracción eficiente en ambas direcciones.
///     O(1) para agregar al final y extraer del inicio.
/// </remarks>
public class PlanificadorFifoLinkedList : IPlanificadorProcesos {
    private readonly LinkedList<Proceso> _cola = [];

    /// <summary>
    ///     Agrega un proceso al final de la cola.
    /// </summary>
    /// <param name="proceso">Proceso a agregar.</param>
    public void Encolar(Proceso proceso) {
        _cola.AddLast(proceso);
    }

    /// <summary>
    ///     Extrae el primer proceso de la cola.
    /// </summary>
    /// <returns>El proceso extraído o null si está vacía.</returns>
    public Proceso? Desencolar() {
        if (_cola.Count == 0) return null;
        var proceso = _cola.First!.Value;
        _cola.RemoveFirst();
        return proceso;
    }

    /// <summary>
    ///     Obtiene el primer proceso sin extraerlo.
    /// </summary>
    /// <returns>El proceso o null si está vacía.</returns>
    public Proceso? Primero() {
        return _cola.First?.Value;
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
        return _cola.Count;
    }

    /// <summary>
    ///     Representación en cadena de la cola.
    /// </summary>
    /// <returns>Representación textual de la cola.</returns>
    public override string ToString() {
        return "[" + string.Join(", ", _cola) + "]";
    }
}
