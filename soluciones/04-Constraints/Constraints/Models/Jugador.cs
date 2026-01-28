namespace Constraints.Models;

public class Jugador(string nombre, int numero) : Persona(nombre), IJugador {
    public int Numero { get; set; } = numero;

    public void Jugar() {
        Console.WriteLine($"{Nombre} está jugando con el número {Numero}.");
    }
}