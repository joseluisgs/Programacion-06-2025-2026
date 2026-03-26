namespace PlanificadorProcesos.Models;

/// <summary>
///     Representa un proceso en el sistema de planificación.
/// </summary>
/// <remarks>
///     Un proceso tiene un identificador único, tiempo de ejecución restante,
///     prioridad y timestamps de creación y última modificación.
///     La prioridad va de 1 (mayor) a 9 (menor).
/// </remarks>
public class Proceso(int id, int tiempo, int prioridad) {
    /// <summary>
    ///     Identificador único del proceso.
    /// </summary>
    public int Id { get; } = id;

    /// <summary>
    ///     Tiempo de ejecución restante del proceso.
    /// </summary>
    public int Tiempo {
        get => field;
        set {
            field = Math.Max(0, value);
            UpdatedAt = DateTime.UtcNow;
        }
    } = tiempo;

    /// <summary>
    ///     Prioridad del proceso (1 = mayor, 9 = menor).
    /// </summary>
    public int Prioridad {
        get => field;
        set {
            field = value < 1 ? 1 : value > 9 ? 9 : value;
            UpdatedAt = DateTime.UtcNow;
        }
    } = prioridad;

    /// <summary>
    ///     Timestamp de creación del proceso.
    /// </summary>
    public DateTime CreatedAt { get; } = DateTime.UtcNow;

    /// <summary>
    ///     Timestamp de última modificación.
    /// </summary>
    public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;

    /// <summary>
    ///     Indica si el proceso está activo.
    /// </summary>
    public bool IsActive => Tiempo > 0;

    /// <summary>
    ///     Crea una copia del proceso.
    /// </summary>
    public Proceso Copy() {
        return new Proceso(Id, Tiempo, Prioridad);
    }

    public override string ToString() {
        return
            $"Proceso(id={Id}, tiempo={Tiempo}, prioridad={Prioridad}, createdAt={CreatedAt:O}, updatedAt={UpdatedAt:O})";
    }
}