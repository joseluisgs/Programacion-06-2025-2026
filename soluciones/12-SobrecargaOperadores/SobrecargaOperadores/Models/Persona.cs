namespace SobrecargaOperadores.Models;

public class Persona {
    public string Nombre { get; init; } = string.Empty;
    public int Edad { get; init; }

    public override bool Equals(object? obj) {
        if (obj is Persona p) {
            return this.Edad == p.Edad && this.Nombre == p.Nombre;
        }
        return false;
    }

    private bool Equals(Persona other) {
        return Nombre == other.Nombre && Edad == other.Edad;
    }

    public override int GetHashCode() {
        return HashCode.Combine(Nombre, Edad);
    }


    public static bool operator ==(Persona p1, Persona p2) {
        return p1.Equals(p2);
    }

    public static bool operator !=(Persona p1, Persona p2) {
        return !p1.Equals(p2);
    }
}