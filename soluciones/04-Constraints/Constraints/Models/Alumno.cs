namespace Constraints.Models;

public class Alumno(string nombre, double calificacion) : Persona(nombre), IJugador, IAlumno {
    public double Calificacion { get; set; } = calificacion;

    public void Estudiar() {
        Console.WriteLine($"{Nombre} está estudiando.");
    }

    public void Jugar() {
        Console.WriteLine($"{Nombre} está jugando y su calificación es {Calificacion}.");
    }
}