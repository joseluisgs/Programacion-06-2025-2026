namespace Constraints.Models;

public class Gato : IJugador, IAlumno {
    public void Estudiar() {
        Console.WriteLine("El gato está estudiando.");
    }

    public void Jugar() {
        Console.WriteLine("El perro está jugando.");
    }
}