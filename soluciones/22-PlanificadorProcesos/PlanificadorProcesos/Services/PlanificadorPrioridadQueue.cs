using PlanificadorProcesos.Models;

namespace PlanificadorProcesos.Services;

/// <summary>
///     Planificador de prioridad basado en PriorityQueue de .NET.
///     Prioridad: 1 = máxima, 9 = mínima.
/// </summary>
/// <remarks>
///     Usa PriorityQueue donde la prioridad es el valor de Prioridad del proceso.
///     Como PriorityQueue extrae el menor primero, al pasar la prioridad directamente,
///     el proceso con Prioridad 1 sale primero (es el "menor").
/// </remarks>
public class PlanificadorPrioridadQueue : IPlanificadorProcesos {
    private readonly PriorityQueue<Proceso, int> _cola = new();

    /// <summary>
    ///     Agrega un proceso a la cola.
    /// </summary>
    /// <param name="proceso">Proceso a agregar.</param>
    public void Encolar(Proceso proceso) {
        _cola.Enqueue(proceso, proceso.Prioridad);
    }

    /// <summary>
    ///     Extrae el proceso con mayor prioridad (1 = máxima).
    ///     Como PriorityQueue usa min-heap, el menor valor sale primero.
    /// </summary>
    /// <returns>El proceso extraído o null si está vacía.</returns>
    public Proceso? Desencolar() {
        return _cola.Count > 0 ? _cola.Dequeue() : null;
    }

    /// <summary>
    ///     Obtiene el proceso con mayor prioridad sin extraerlo.
    /// </summary>
    /// <returns>El proceso o null si está vacía.</returns>
    public Proceso? Primero() {
        return _cola.Count > 0 ? _cola.Peek() : null;
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
