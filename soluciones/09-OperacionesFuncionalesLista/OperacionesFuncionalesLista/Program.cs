// See https://aka.ms/new-console-template for more information

using OperacionesFuncionalesLista.Collections.Lista;
using OperacionesFuncionalesLista.Models;

Console.WriteLine("Hola Operaciones con Listas Enlazadas!");

var lista = new Lista<Persona>();
lista.AgregarFinal(new Persona { Nombre = "Ana", Edad = 15 });
lista.AgregarFinal(new Persona { Nombre = "Luis", Edad = 20 });
lista.AgregarFinal(new Persona { Nombre = "Carlos", Edad = 17 });
lista.AgregarFinal(new Persona { Nombre = "Carolina", Edad = 22 });

Console.WriteLine("Lista Original:");
foreach (var persona in lista) Console.WriteLine($"- {persona.Nombre}, {persona.Edad} años");

var mayoresEdad = ListaOp.Where(lista, p => p.Edad >= 18);
Console.WriteLine("\nPersonas mayores de edad:");
foreach (var persona in mayoresEdad) Console.WriteLine($"- {persona.Nombre}, {persona.Edad} años");

var empizanPorC = ListaOp.Where(lista, p => p.Nombre.StartsWith("C", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("\nPersonas cuyos nombres empiezan por 'C':");
foreach (var persona in empizanPorC) Console.WriteLine($"- {persona.Nombre}, {persona.Edad} años");

var empiezaPorA = ListaOp.Find(lista, p => p.Nombre.StartsWith("A", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("\nPrimera persona cuyo nombre empieza por 'A':");
Console.WriteLine(empiezaPorA?.ToString() ?? "Ninguna persona encontrada");

var empiezaPorK = ListaOp.Find(lista, p => p.Nombre.StartsWith("K", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("\nPrimera persona cuyo nombre empieza por 'K':");
Console.WriteLine(empiezaPorK?.ToString() ?? "Ninguna persona encontrada");

var primeraMayorDe18 = ListaOp.Find(lista, p => p.Edad > 18);
Console.WriteLine("\nPrimera persona mayor de 18 años:");
Console.WriteLine(primeraMayorDe18?.ToString() ?? "Ninguna persona encontrada");

var cuantosMayoresDe18 = ListaOp.Count(lista, p => p.Edad > 18);
Console.WriteLine($"\nCantidad de personas mayores de 18 años: {cuantosMayoresDe18}");

var cuantosTienenLaEdadPar = ListaOp.Count(lista, p => p.Edad % 2 == 0);
Console.WriteLine($"\nCantidad de personas con edad par: {cuantosTienenLaEdadPar}");

var cuantosLongitudNombreMayorA5YEmpiezanPorC = ListaOp.Count(lista,
    p => p.Nombre.Length > 5 && p.Nombre.StartsWith("C", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine(
    $"\nCantidad de personas con longitud de nombre mayor a 5 y que empiezan por 'C': {cuantosLongitudNombreMayorA5YEmpiezanPorC}");

var listaNombres = ListaOp.Select(lista, p => p.Nombre);
Console.WriteLine("\nLista de nombres extraídos de la lista de personas:");
foreach (var nombre in listaNombres)
    Console.WriteLine($"- {nombre}");

var listaEdades = ListaOp.Select(lista, p => p.Edad);
Console.WriteLine("\nLista de edades extraídas de la lista de personas:");
foreach (var edad in listaEdades)
    Console.WriteLine($"- {edad}");

var listaLongitudesNombres = ListaOp.Select(lista, p => p.Nombre.Length);
Console.WriteLine("\nLista de longitudes de nombres extraídas de la lista de personas:");
foreach (var longitud in listaLongitudesNombres)
    Console.WriteLine($"- {longitud}");

var sumaEdades = ListaOp.Sum(lista, p => p.Edad);
Console.WriteLine($"\nSuma de todas las edades: {sumaEdades}");

var sumaLongitudesNombres = ListaOp.Sum(lista, p => p.Nombre.Length);
Console.WriteLine($"\nSuma de todas las longitudes de nombres: {sumaLongitudesNombres}");

var acumuladorEdades = ListaOp.Aggregate(lista, (acum, p) => acum + p.Edad, 0);
Console.WriteLine($"\nReducción de edades (suma) usando Reduce: {acumuladorEdades}");

var algunNombreConC = ListaOp.Any(lista, p => p.Nombre.Contains("c", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine($"\n¿Algún nombre contiene la letra 'c'? {algunNombreConC}");

var todasMayoresDe10 = ListaOp.All(lista, p => p.Edad > 10);
Console.WriteLine($"\n¿Todas las personas son mayores de 10 años? {todasMayoresDe10}");

Console.WriteLine("\nTodas las personas en la lista (usando ForEach):");
ListaOp.ForEach(lista, p => Console.WriteLine($"- {p.Nombre}, {p.Edad} años"));