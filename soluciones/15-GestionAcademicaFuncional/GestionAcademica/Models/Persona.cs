namespace GestionAcademica.Models;

/// <summary>
///     Clase base abstracta e inmutable para cualquier persona registrada en el sistema.
///     Implementa una identidad estricta basada unívocamente en el DNI.
/// </summary>
public abstract record Persona {
    public int Id { get; init; }
    public string Dni { get; init; } = string.Empty;
    public string Nombre { get; init; } = string.Empty;
    public string Apellidos { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; init; }
    public bool IsDeleted { get; init; }

    /// <summary>
    ///     Retorna el nombre completo formateado para visualización.
    /// </summary>
    public string NombreCompleto => $"{Nombre} {Apellidos}";

    /// <summary>
    ///     Determina si dos personas son idénticas comparando sus DNIs de forma insensible a mayúsculas.
    /// </summary>
    /// <param name="other">Instancia de persona a comparar.</param>
    /// <returns>True si los DNIs coinciden.</returns>
    public virtual bool Equals(Persona? other) {
        return other is not null && string.Equals(Dni, other.Dni, StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    ///     Calcula el código hash basado exclusivamente en el DNI para mantener coherencia con la igualdad.
    /// </summary>
    /// <returns>Código hash entero.</returns>
    public override int GetHashCode() {
        return HashCode.Combine(Dni.ToLowerInvariant());
    }
}
