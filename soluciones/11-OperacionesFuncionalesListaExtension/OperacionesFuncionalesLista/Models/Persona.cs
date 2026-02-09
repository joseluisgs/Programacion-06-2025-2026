namespace OperacionesFuncionalesLista.Models;

public record Persona {
    public string Nombre { get; init; } = string.Empty;
    public int Edad { get; init; }
}