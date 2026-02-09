using ComparacionOrdenacion.Models;

namespace ComparacionOrdenacion.Comparadores;

// Comparador por edad
public class ComparadorPorEdad : IComparer<Persona>
{
    public int Compare(Persona x, Persona y)
    {
        return x.Edad.CompareTo(y.Edad);
    }
}

// Comparador por nombre
public class ComparadorPorNombre : IComparer<Persona>
{
    public int Compare(Persona x, Persona y)
    {
        return x.Nombre.CompareTo(y.Nombre);
    }
}
