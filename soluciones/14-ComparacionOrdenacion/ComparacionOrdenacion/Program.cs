// See https://aka.ms/new-console-template for more information

using ComparacionOrdenacion.Comparadores;
using ComparacionOrdenacion.Models;

Console.WriteLine("Hola Comparadores y Ordenacion!");

var p1 = new Persona { Nombre = "Juan", Apellido = "Perez", Edad = 30 };
var p2 = new Persona { Nombre = "Ana", Apellido = "Gomez", Edad = 18 };
var p3 = new Persona { Nombre = "Pedro", Apellido = "Gomez", Edad = 18 };

switch (p1.CompareTo(p2)) {
    case < 0:
        Console.WriteLine($"{p1.Nombre} {p1.Apellido} va antes que {p2.Nombre} {p2.Apellido}");
        break;
    case > 0:
        Console.WriteLine($"{p1.Nombre} {p1.Apellido} va despues que {p2.Nombre} {p2.Apellido}");
        break;
    default:
        Console.WriteLine($"{p1.Nombre} {p1.Apellido} es igual que {p2.Nombre} {p2.Apellido}");
        break;
}

if (p1 < p2) {
    Console.WriteLine($"{p1.Nombre} {p1.Apellido} va antes que {p2.Nombre} {p2.Apellido}");
} else if (p1 > p2) {
    Console.WriteLine($"{p1.Nombre} {p1.Apellido} va despues que {p2.Nombre} {p2.Apellido}");
} else {
    Console.WriteLine($"{p1.Nombre} {p1.Apellido} es igual que {p2.Nombre} {p2.Apellido}");
}

var personas = new Persona[] { p1, p2, p3 };
Array.Sort(personas);

Console.WriteLine("\nOrdenando por Apellido y Nombre:");
foreach (var persona in personas) {
    Console.WriteLine($"{persona.Nombre} {persona.Apellido}");
}

Array.Sort(personas, new ComparadorPorEdad());

Console.WriteLine("\nOrdenando por Edad:");
foreach (var persona in personas) {
    Console.WriteLine($"{persona.Nombre} {persona.Apellido} - {persona.Edad} años");
}

Array.Sort(personas, (p1, p2) => p2.Edad - p1.Edad);

Console.WriteLine("\nOrdenando por Edad (ascendente):");
foreach (var persona in personas) {
    Console.WriteLine($"{persona.Nombre} {persona.Apellido} - {persona.Edad} años");
}

Array.Sort(personas, (p1, p2) => p1.Nombre.CompareTo(p2.Nombre));

Console.WriteLine("\nOrdenando por Nombre:");
foreach (var persona in personas) {
    Console.WriteLine($"{persona.Nombre} {persona.Apellido}");
}


// Comparaciones con IEqualityComparer<Persona>
var comparadorCaseInsensitive = new CaseInsensitiveComparer();
Console.WriteLine($"\n¿{p2.Apellido} es igual a {p3.Apellido} (case insensitive)? {comparadorCaseInsensitive.Equals(p2, p3)}");

// Con una lambda sobre la marcha para la igualdad por edad
var comparadorPorEdad = Comparer<Persona>.Create((x, y) => x.Edad.CompareTo(y.Edad));
Console.WriteLine($"\n¿{p2.Nombre} tiene la misma edad que {p3.Nombre}? {comparadorPorEdad.Compare(p2, p3) == 0}");


// Ordenar, siempre con Sort, pero hay que usar el comparador.
Array.Sort(personas, comparadorPorEdad); // o su lambda
Array.Sort(personas, (x, y) => x.Edad.CompareTo(y.Edad)); // o su lambda

Console.WriteLine("\nOrdenando por Edad (ascendente) con el comparador personalizado:");
foreach (var persona in personas) {
    Console.WriteLine($"{persona.Nombre} {persona.Apellido} - {persona.Edad} años");
}

// Buscar con BinarySearch
var indice = Array.BinarySearch(personas, new Persona { Nombre = "Ana", Apellido = "Gomez", Edad = 18 }, comparadorPorEdad);
if (indice >= 0) {
    Console.WriteLine($"\nPersona encontrada en el índice {indice}: {personas[indice].Nombre} {personas[indice].Apellido}");
}

