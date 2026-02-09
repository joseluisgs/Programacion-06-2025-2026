// See https://aka.ms/new-console-template for more information

using Listas.Collections;
using Listas.Model;
using static System.Console;

WriteLine("Hola Listas");

var nombres = new List<string> { "Ana", "Luis", "Carlos", "Marta" };
nombres.Add("Sofía");
nombres.Remove("Carlos");
nombres.Insert(1, "Jorge");
nombres.Sort();
foreach (var nombre in nombres)
    WriteLine(nombre);

List<int> numeros = [1, 2, 3, 4, 5]; // { 1, 2, 3, 4, 5 };
numeros.Add(6);
numeros.Remove(3);
numeros.Insert(0, 0);
numeros.Sort();
foreach (var numero in numeros)
    WriteLine(numero);

List<Persona> personas = [
    new() { Nombre = "Ana", Edad = 28 },
    new() { Nombre = "Luis", Edad = 34 },
    new() { Nombre = "Carlos", Edad = 22 }
];

personas.Add(new Persona { Nombre = "Marta", Edad = 30 });
personas.RemoveAt(1);
personas.Insert(1, new Persona { Nombre = "Jorge", Edad = 26 });

foreach (var persona in personas)
    WriteLine($"{persona.Nombre} - {persona.Edad}");

for (var i = 0; i < personas.Count; i++)
    WriteLine($"{personas[i].Nombre} tiene {personas[i].Edad} años.");

WriteLine("Tamaño de la lista de personas: " + personas.Count);
WriteLine("Capacidad de la lista de personas: " + personas.Capacity);

// Puedo usar algo de programacion declarativa/funcional.

personas.ForEach(persona => WriteLine($"{persona.Nombre} tiene {persona.Edad} años."));
WriteLine("Personas mayores de 25 años:");
personas.Where(p => p.Edad > 25).ToList()
    .ForEach(p => WriteLine($"{p.Nombre} es mayor de 25 años."));


WriteLine("Pila de int");
var pila = new Pila<int>();
pila.Push(10);
pila.Push(20);
WriteLine($"Tope de la pila: {pila.Peek()}"); // 20
WriteLine($"Elemento desapilado: {pila.Pop()}"); // 20
WriteLine($"¿La pila está vacía? {pila.IsEmpty()}"); // False

while (!pila.IsEmpty())
    WriteLine($"Elemento desapilado: {pila.Pop()}"); // 10

WriteLine("Cola de strings");
var cola = new Cola<string>();
cola.Enqueue("Primer elemento");
cola.Enqueue("Segundo elemento");
WriteLine($"Frente de la cola: {cola.Peek()}"); // Primer elemento
WriteLine($"Elemento desencolado: {cola.Dequeue()}"); // Primer elemento
WriteLine($"Frente de la cola: {cola.Peek()}"); // Segundo elemento

while (!cola.IsEmpty())
    WriteLine($"Elemento desencolado: {cola.Dequeue()}"); // Segundo elemento

// para buscar personas, busqueda lineal
var encontrado = personas.Find(p => p.Nombre == "Marta");
if (encontrado != null)
    WriteLine($"Encontrado: {encontrado.Nombre}, {encontrado.Edad} años");
else
    WriteLine("Persona no encontrada");

// indexOf
var index = personas.FindIndex(p => p.Nombre == "Ana");
if (index != -1)
    WriteLine($"Ana encontrada en el índice: {index}");
else
    WriteLine("Ana no encontrada");
    
// contains, pero necesito definir igualdad
var ana = new Persona { Nombre = "Ana", Edad = 28 };
if (personas.Contains(ana))
    WriteLine("La lista contiene a Ana");
else
    WriteLine("La lista no contiene a Ana");
    
    // Ordenar por edad
personas.Sort((p1, p2) => p1.Edad.CompareTo(p2.Edad));
WriteLine("Personas ordenadas por edad:");
personas.ForEach(p => WriteLine($"{p.Nombre} - {p.Edad} años"));

// O usar BinarySearch, pero la lista debe estar ordenada
var personaABuscar = new Persona { Nombre = "Jorge", Edad = 26 };
int resultadoBusqueda = personas.BinarySearch(personaABuscar, Comparer<Persona>.Create((p1, p2) => p1.Edad.CompareTo(p2.Edad)));
if (resultadoBusqueda >= 0)
    WriteLine($"Persona encontrada en el índice: {resultadoBusqueda}");
else
    WriteLine("Persona no encontrada con BinarySearch");