using PlanificadorProcesos.Models;

namespace PlanificadorProcesos.Services;

/// <summary>
///     Planificador FIFO basado en Cola (Queue).
/// </summary>
public class PlanificadorFifoCola : IPlanificadorProcesos {
    private readonly Queue<Proceso> _cola = new();

    /// <summary>
    ///     Agrega un proceso a la cola.
    /// </summary>
    /// <param name="proceso">Proceso a agregar.</param>
    public void Encolar(Proceso proceso) {
        _cola.Enqueue(proceso);
    }

    /// <summary>
    ///     Extrae el primer proceso de la cola.
    /// </summary>
    /// <returns>El proceso extraído o null si está vacía.</returns>
    public Proceso? Desencolar() {
        return _cola.Count > 0 ? _cola.Dequeue() : null;
    }

    /// <summary>
    ///     Obtiene el primer proceso sin extraerlo.
    /// </summary>
    /// <returns>El primer proceso o null si está vacía.</returns>
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
