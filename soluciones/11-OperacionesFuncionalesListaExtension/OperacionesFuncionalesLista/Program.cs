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

var mayoresEdad = lista.Filter(p => p.Edad >= 18);
Console.WriteLine("\nPersonas mayores de edad:");
foreach (var persona in mayoresEdad) Console.WriteLine($"- {persona.Nombre}, {persona.Edad} años");

var empizanPorC = lista.Where(p => p.Nombre.StartsWith("C", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("\nPersonas cuyos nombres empiezan por 'C':");
foreach (var persona in empizanPorC) Console.WriteLine($"- {persona.Nombre}, {persona.Edad} años");

var empiezaPorA = lista.Find(p => p.Nombre.StartsWith("A", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("\nPrimera persona cuyo nombre empieza por 'A':");
Console.WriteLine(empiezaPorA?.ToString() ?? "Ninguna persona encontrada");

var empiezaPorK = lista.Find(p => p.Nombre.StartsWith("K", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("\nPrimera persona cuyo nombre empieza por 'K':");
Console.WriteLine(empiezaPorK?.ToString() ?? "Ninguna persona encontrada");

var primeraMayorDe18 = lista.Find(p => p.Edad > 18);
Console.WriteLine("\nPrimera persona mayor de 18 años:");
Console.WriteLine(primeraMayorDe18?.ToString() ?? "Ninguna persona encontrada");

var cuantosMayoresDe18 = lista.Count(p => p.Edad > 18);
Console.WriteLine($"\nCantidad de personas mayores de 18 años: {cuantosMayoresDe18}");

var cuantosTienenLaEdadPar = lista.Count(p => p.Edad % 2 == 0);
Console.WriteLine($"\nCantidad de personas con edad par: {cuantosTienenLaEdadPar}");

var cuantosLongitudNombreMayorA5YEmpiezanPorC = lista.Count(p =>
    p.Nombre.Length > 5 && p.Nombre.StartsWith("C", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine(
    $"\nCantidad de personas con longitud de nombre mayor a 5 y que empiezan por 'C': {cuantosLongitudNombreMayorA5YEmpiezanPorC}");

var listaNombres = lista.Select(p => p.Nombre);
Console.WriteLine("\nLista de nombres extraídos de la lista de personas:");
foreach (var nombre in listaNombres)
    Console.WriteLine($"- {nombre}");

var listaEdades = lista.Select(p => p.Edad);
Console.WriteLine("\nLista de edades extraídas de la lista de personas:");
foreach (var edad in listaEdades)
    Console.WriteLine($"- {edad}");

var listaLongitudesNombres = lista.Select(p => p.Nombre.Length);
Console.WriteLine("\nLista de longitudes de nombres extraídas de la lista de personas:");
foreach (var longitud in listaLongitudesNombres)
    Console.WriteLine($"- {longitud}");

var sumaEdades = lista.Sum(p => p.Edad);
Console.WriteLine($"\nSuma de todas las edades: {sumaEdades}");

var sumaLongitudesNombres = lista.Sum(p => p.Nombre.Length);
Console.WriteLine($"\nSuma de todas las longitudes de nombres: {sumaLongitudesNombres}");

var acumuladorEdades = lista.Aggregate((acum, p) => acum + p.Edad, 0);
Console.WriteLine($"\nReducción de edades (suma) usando Reduce: {acumuladorEdades}");

var algunNombreConC =
    lista.Any(p => p.Nombre.Contains("c", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine($"\n¿Algún nombre contiene la letra 'c'? {algunNombreConC}");

var todasMayoresDe10 = lista.All(p => p.Edad > 10);
Console.WriteLine($"\n¿Todas las personas son mayores de 10 años? {todasMayoresDe10}");

Console.WriteLine("\nTodas las personas en la lista (usando ForEach):");
lista.ForEach(p => Console.WriteLine($"- {p.Nombre}, {p.Edad} años"));


// Gracias a las funciones de extensión podemos concatenar múltiples operaciones funcionales
var sumaEdadesNombresConC = lista
    .Where(p => p.Nombre.Contains("c", StringComparison.CurrentCultureIgnoreCase))
    .Sum(p => p.Edad);

Console.WriteLine($"\nSuma de edades de personas cuyos nombres contienen la letra 'c': {sumaEdadesNombresConC}");

Console.WriteLine(
    "\nNombres de personas mayores de 18 años, con edad par, nombres que contienen 'c' y longitud de nombre mayor a 5:");
lista.Where(p => p.Edad > 18)
    .Where(p => p.Nombre.Contains("c", StringComparison.CurrentCultureIgnoreCase))
    .Where(p => p.Edad % 2 == 0)
    .Where(p => p.Nombre.Length > 5)
    .Select(p => p.Nombre)
    .ForEach(nombre => Console.WriteLine($"- {nombre}"));

// De todos los nombres con 'c', obtener la suma de las longitudes de los nombres de personas mayores de 18 años
var sumaLongitudesNombresMayoresDe18ConC = lista
    .Where(p => p.Nombre.Contains("c", StringComparison.CurrentCultureIgnoreCase))
    .Where(p => p.Edad > 18)
    .Sum(p => p.Nombre.Length);

Console.WriteLine(
    $"\nSuma de longitudes de nombres de personas cuyos nombres contienen la letra 'c' y son mayores de 18 años: {sumaLongitudesNombresMayoresDe18ConC}");

// De todos los que son mayores de edad, encuentra aquel cuyo nombre acaba en 'a'
var mayorDeEdadNombreTerminaEnA = lista
    .Where(p => p.Edad > 18)
    .Find(p => p.Nombre.EndsWith("a", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("\nPrimera persona mayor de edad cuyo nombre termina en 'a':");
Console.WriteLine(mayorDeEdadNombreTerminaEnA?.ToString() ?? "Ninguna persona encontrada");