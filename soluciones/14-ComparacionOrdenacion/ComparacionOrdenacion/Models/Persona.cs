namespace ComparacionOrdenacion.Models;

public class Persona : IComparable<Persona>, IEquatable<Persona>
{
    public string Nombre { get; init; } = string.Empty;
    public string Apellido { get; init; } = string.Empty;
    public int Edad { get; init; }
    
    // Definimos como se comparan dos objetos Persona
    // -1 si this < other
    // 0 si this == other
    // 1 si this > other
    public int CompareTo(Persona? other)
    {
        if (other == null) return 1;
        var comparacion = this.Apellido.CompareTo(other.Apellido);
        if (comparacion != 0) return comparacion;
        return this.Nombre.CompareTo(other.Nombre);
    }
    
    // Sobrecarga de operadores relacionales
    public static bool operator <(Persona left, Persona right) => left.CompareTo(right) < 0;
    public static bool operator >(Persona left, Persona right) => left.CompareTo(right) > 0;
    public static bool operator <=(Persona left, Persona right) => left.CompareTo(right) <= 0;
    public static bool operator >=(Persona left, Persona right) => left.CompareTo(right) >= 0;
    
    public bool Equals(Persona? other) {
        if (other == null) return false;
        return this.Nombre == other.Nombre && this.Apellido == other.Apellido && this.Edad == other.Edad;
    }
    public override int GetHashCode() => (Nombre, Apellido, Edad).GetHashCode();
    
    public static bool operator ==(Persona? left, Persona? right) {
        if (left is null && right is null) return true;
        if (left is null || right is null) return false;
        return left.Equals(right);
    }

    public static bool operator !=(Persona left, Persona right) {
        return !(left == right);
    }
}