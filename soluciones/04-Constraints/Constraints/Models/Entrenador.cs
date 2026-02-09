namespace Constraints.Models;

public class Entrenador(string nombre, int experiencia) : Persona(nombre) {
    public int Experiencia { get; set; } = experiencia;
}