using PlanificadorProcesos.Models;

namespace PlanificadorProcesos.Factories;

/// <summary>
///     Factory para crear instancias de Proceso.
/// </summary>
public static class ProcesoFactory {
    private static int _contador = 0;
    private static readonly Random Random = new();

    /// <summary>
    ///     Crea un nuevo proceso con datos aleatorios.
    /// </summary>
    /// <returns>Nuevo proceso con ID incremental.</returns>
    public static Proceso Create() {
        _contador++;
        return new Proceso(
            id: _contador,
            tiempo: Random.Next(1, 21),     // Tiempo entre 1 y 20
            prioridad: Random.Next(1, 10)  // Prioridad entre 1 y 9
        );
    }

    /// <summary>
    ///     Crea N procesos aleatorios.
    /// </summary>
    /// <param name="cantidad">Número de procesos a crear.</param>
    /// <returns>Lista de procesos.</returns>
    public static List<Proceso> CreateMultiple(int cantidad) {
        var lista = new List<Proceso>();
        for (int i = 0; i < cantidad; i++) {
            lista.Add(Create());
        }
        return lista;
    }

    /// <summary>
    ///     Reinicia el contador de IDs.
    /// </summary>
    public static void ResetContador() {
        _contador = 0;
    }
}
