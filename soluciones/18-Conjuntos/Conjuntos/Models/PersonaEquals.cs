namespace Conjuntos.Models;

public class PersonaEquals {
    public string Nombre { get; set; } = string.Empty;
    public int Edad { get; set; }

    public override bool Equals(object? obj) {
        if (obj is PersonaEquals otraPersona) return Nombre == otraPersona.Nombre && Edad == otraPersona.Edad;
        return false;
    }

    public override int GetHashCode() {
        return HashCode.Combine(Nombre, Edad);
    }
}