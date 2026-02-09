namespace Varianza.Models;

public class Perro(string nombre, int edad) : Animal(nombre) {
    public int Edad { get; set; } = edad;
    
    public void Ladrar() {
        Console.WriteLine($"{Nombre} está ladrando.");
    }
}