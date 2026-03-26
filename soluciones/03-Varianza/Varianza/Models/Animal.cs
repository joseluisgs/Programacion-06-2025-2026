namespace Varianza.Models;

public class Animal(string nombre) {
    public string Nombre { get; set; } = nombre;
    
    public void Comer() {
        Console.WriteLine($"{Nombre} está comiendo.");
    }
}