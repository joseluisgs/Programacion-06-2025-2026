// See https://aka.ms/new-console-template for more information

using PatternMatching.Models;
using static System.Console;

WriteLine("Hola Pattern Matching!");

var numero = 8;

var isPar = numero switch {
    _ when numero % 2 is 0 => true,
    _ => false
};

WriteLine($"El número {numero} es par: {isPar}");

var cualidad = numero switch {
    var n when n % 2 is 0 => "Par",
    var n when n % 2 is not 0 => "Impar",
    var n when n < 0 => "Negativo",
    var n when n > 0 => "Positivo",
    var n when IsPrime(n) => "Primo",
    _ => "Desconocido"
};


var persona = new Persona {
    Nombre = "Juan",
    Edad = 25
};

var esAdulto = persona switch {
    { Edad: >= 18 } => true,
    _ => false
};

WriteLine($"La persona {persona.Nombre} es adulta: {esAdulto}");

// if (persona.Edad >= 18) {}
if (persona is { Edad: >= 18 })
    WriteLine($"{persona.Nombre} es mayor de edad.");
else
    WriteLine($"{persona.Nombre} es menor de edad.");

// Si es nulo
if (persona is not null)
    WriteLine("La persona es nula.");
else
    WriteLine("La persona no es nula.");

if (persona is { Nombre: "Juan", Edad: >= 18 })
    WriteLine("La persona es Juan y es mayor de edad.");

if (persona is { } noNulo)
    WriteLine($"La persona no es nula: {noNulo.Nombre}, {noNulo.Edad}");

var calificacion = 7.5;

if (calificacion >= 5 && calificacion <= 10) WriteLine($"La calificación es {calificacion} y es Aprobado.");

if (calificacion is >= 5 and <= 10) WriteLine($"La calificación es {calificacion} y es Aprobado.");

bool IsPrime(int i) {
    // hazla tú que ya deberías saberlo.
    return true; // Ejemplo de implementación de la función isPrime
}
