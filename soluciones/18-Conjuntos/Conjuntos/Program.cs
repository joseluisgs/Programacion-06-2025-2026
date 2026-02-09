// See https://aka.ms/new-console-template for more information

using Conjuntos.Models;
using static System.Console;

WriteLine("Hola Conjuntos!");

var conjuntoA = new HashSet<int> { 5, 3, 2, 1, 7, 7, 3 };
var conjuntoB = new HashSet<int> { 4, 5, 6, 7, 8 };

WriteLine("Conjunto A: " + string.Join(", ", conjuntoA));
WriteLine("Conjunto B: " + string.Join(", ", conjuntoB));

// Agregar elementos
conjuntoA.Add(10);
conjuntoB.Add(9);
conjuntoB.Add(9);
conjuntoB.Add(9);
conjuntoB.Add(9);

WriteLine("Conjunto A después de agregar 10: " + string.Join(", ", conjuntoA));
WriteLine("Conjunto B después de agregar 9 varias veces: " + string.Join(", ", conjuntoB));

// Eliminar elementos
conjuntoA.Remove(2);

// Union
var union = new HashSet<int>(conjuntoA);
union.UnionWith(conjuntoB);
WriteLine("Unión de A y B: " + string.Join(", ", union));

// Intersección
var interseccion = new HashSet<int>(conjuntoA);
interseccion.IntersectWith(conjuntoB);
WriteLine("Intersección de A y B: " + string.Join(", ", interseccion));

// Diferencia
var diferencia = new HashSet<int>(conjuntoA);
diferencia.ExceptWith(conjuntoB);
WriteLine("Diferencia de A y B (A - B): " + string.Join(", ", diferencia));

// Truco de eliminar duplicados en una lista
var listaConDuplicados = new List<int> { 1, 2, 3, 2, 4, 5, 1, 6, 3 };
WriteLine("Lista con duplicados: " + string.Join(", ", listaConDuplicados));
var conjuntoSinDuplicados = new HashSet<int>(listaConDuplicados);
WriteLine("Conjunto sin duplicados: " + string.Join(", ", conjuntoSinDuplicados));
var listaSinDuplicados = conjuntoSinDuplicados.ToList();
WriteLine("Lista sin duplicados: " + string.Join(", ", listaSinDuplicados));


// Que pasa con Persona:
WriteLine("\nQue pasa con Persona:");
var persona1 = new Persona { Nombre = "Juan", Edad = 30 };
var persona2 = new Persona { Nombre = "Juan", Edad = 30 };
var conjuntoPersonas = new HashSet<Persona>();
conjuntoPersonas.Add(persona1);
conjuntoPersonas.Add(persona2);

// Por defecto, HashSet usa la igualdad de referencia, si no se sobrescriben Equals y GetHashCode en la clase Persona,
foreach (var persona in conjuntoPersonas)
    WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");

// Que pasa con Persona:
WriteLine("\nQue pasa con Persona con Equals y GetHashCode:");
var persona3 = new PersonaEquals { Nombre = "Juan", Edad = 30 };
var persona4 = new PersonaEquals { Nombre = "Juan", Edad = 30 };
var conjuntoPersonasEquals = new HashSet<PersonaEquals>();
conjuntoPersonasEquals.Add(persona3);
conjuntoPersonasEquals.Add(persona4);

// Por defecto, HashSet usa la igualdad de referencia, si no se sobrescriben Equals y GetHashCode en la clase Persona,
foreach (var persona in conjuntoPersonasEquals)
    WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");