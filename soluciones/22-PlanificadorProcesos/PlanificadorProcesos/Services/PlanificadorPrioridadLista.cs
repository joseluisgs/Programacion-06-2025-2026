using PlanificadorProcesos.Models;

namespace PlanificadorProcesos.Services;

/// <summary>
///     Planificador de prioridad basado en Lista.
///     Prioridad: 1 = máxima, 9 = mínima.
/// </summary>
/// <remarks>
///     Al desencolar, ordena la lista ascendentemente por prioridad yExtrae el primero.
///     El proceso con Prioridad 1 (menor valor) sale primero.
/// </remarks>
public class PlanificadorPrioridadLista : IPlanificadorProcesos {
    private readonly List<Proceso> _cola = [];

    /// <summary>
    ///     Agrega un proceso a la cola.
    /// </summary>
    /// <param name="proceso">Proceso a agregar.</param>
    public void Encolar(Proceso proceso) {
        _cola.Add(proceso);
    }

    /// <summary>
    ///     Extrae el proceso con mayor prioridad (1 = máxima).
    ///     Ordena ascendentemente y extrae el primero.
    /// </summary>
    /// <returns>El proceso extraído o null si está vacía.</returns>
    public Proceso? Desencolar() {
        if (_cola.Count == 0) return null;
        var proceso = _cola.OrderBy(p => p.Prioridad).First();
        _cola.Remove(proceso);
        return proceso;
    }

    /// <summary>
    ///     Obtiene el proceso con mayor prioridad sin extraerlo.
    /// </summary>
    /// <returns>El proceso o null si está vacía.</returns>
    public Proceso? Primero() {
        return _cola.Count > 0 ? _cola.OrderBy(p => p.Prioridad).First() : null;
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
