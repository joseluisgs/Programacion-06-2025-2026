namespace PlanificadorProcesos.Services;

/// <summary>
///     Interfaz para estructuras de datos de planificación de procesos.
/// </summary>
/// <typeparam name="TKey">Tipo de la clave de ordenación.</typeparam>
/// <typeparam name="T">Tipo del proceso.</typeparam>
public interface IPlanificador<TKey, T> where T : class {
    /// <summary>
    ///     Agrega un proceso a la cola.
    /// </summary>
    /// <param name="proceso">Proceso a agregar.</param>
    void Encolar(T proceso);

    /// <summary>
    ///     Extrae el siguiente proceso de la cola.
    /// </summary>
    /// <returns>El proceso extraído o null si está vacía.</returns>
    T? Desencolar();

    /// <summary>
    ///     Obtiene el primer proceso sin extraerlo.
    /// </summary>
    /// <returns>El primer proceso o null si está vacía.</returns>
    T? Primero();

    /// <summary>
    ///     Verifica si la cola está vacía.
    /// </summary>
    bool EstaVacia();

    /// <summary>
    ///     Obtiene el número de procesos en la cola.
    /// </summary>
    int Contar();

    /// <summary>
    ///     Representación en cadena de la cola.
    /// </summary>
    string ToString();
}