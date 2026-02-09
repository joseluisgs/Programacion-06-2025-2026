namespace Varianza.Models;

public class Gato(string nombre, int edad) : Animal(nombre) {
    public int Edad { get; set; } = edad;
    
    public void Maullar() {
        Console.WriteLine($"{Nombre} está maullando.");
    }
}