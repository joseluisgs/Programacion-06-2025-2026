using ComparacionOrdenacion.Models;

namespace ComparacionOrdenacion.Comparadores;

public class CaseInsensitiveComparer : IEqualityComparer<Persona> {

    public bool Equals(Persona? x, Persona? y) {
        if (x is null && y is null) return true;
        if (x is null || y is null) return false;
        return string.Equals(x.Apellido, y.Apellido, StringComparison.OrdinalIgnoreCase);
    }
    public int GetHashCode(Persona obj) {
        return obj.Apellido.ToLowerInvariant().GetHashCode();
    }
}