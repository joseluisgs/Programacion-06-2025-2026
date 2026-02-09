namespace BaseDatosAlumnado.Models;

/// <summary>
///     Representa un alumno en la base de datos.
///     Contiene propiedades como el identificador, DNI, nombre completo y la nota del alumno.
///     Al ser un record, es inmutable y proporciona funcionalidades integradas como igualdad por valor y
///     desestructuración.
/// </summary>
public record Alumno {
    public int Id { get; init; } = 0;
    public required string Dni { get; init; }
    public required string NombreCompleto { get; init; }
    public double Nota { get; init; }

    // metadatos para auditoría
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    public bool IsDeleted { get; init; } = false;


    // Has code y Equals se generan automáticamente para records
    // Pero no queremos que se basen en el ID, o Los metadatos de auditoría
    // solo en Dni y NombreCompleto

    public virtual bool Equals(Alumno? other) {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Dni == other.Dni && NombreCompleto.Equals(other.NombreCompleto, StringComparison.OrdinalIgnoreCase);
    }

    public override int GetHashCode() {
        return HashCode.Combine(Dni, NombreCompleto);
    }
}