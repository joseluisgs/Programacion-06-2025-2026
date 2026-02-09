// See https://aka.ms/new-console-template for more information

using Diccionarios.Models;
using static System.Console;


WriteLine("Hola Diccionarios!");

var paises = new Dictionary<string, string>();

paises.Add("ES", "España");
paises.Add("FR", "Francia");
paises.Add("IT", "Italia");
paises.Add("PT", "Portugal");

foreach (var pais in paises)
    WriteLine($"Clave: {pais.Key}, Valor: {pais.Value}");

// Existe una clave
if (paises.ContainsKey("FR"))
    WriteLine("La clave FR existe en el diccionario");

// Obtener un valor por su clave
var paisItalia = paises["IT"];
WriteLine($"El país con clave IT es: {paisItalia}");

// Eliminar un par clave-valor
paises.Remove("PT");

// TryGetValue
if (paises.TryGetValue("ES", out var paisEspana))
    WriteLine($"El país con clave ES es: {paisEspana}");
else
    WriteLine("La clave ES no existe en el diccionario");

// Cambiar un valor
paises["FR"] = "República Francesa";
WriteLine($"El país con clave FR es ahora: {paises["FR"]}");

// Recorrer solo las claves
WriteLine("Claves en el diccionario:");
foreach (var clave in paises.Keys)
    WriteLine(clave);

// Recorrer solo los valores
WriteLine("Valores en el diccionario:");
foreach (var valor in paises.Values)
    WriteLine(valor);

// Diccionario de Persona
var personas = new Dictionary<string, Persona>();
var p = new Persona { Nombre = "Juan Pérez", Edad = 30, Dni = "12345678A" };
personas.Add(p.Dni, p);
personas.Add("87654321B", new Persona { Nombre = "María Gómez", Edad = 25, Dni = "87654321B" });
foreach (var persona in personas)
    WriteLine($"DNI: {persona.Key}, Nombre: {persona.Value.Nombre}, Edad: {persona.Value.Edad}");

// Buscar una persona por DNI
var dniBuscar = "12345678A";
if (personas.TryGetValue(dniBuscar, out var personaEncontrada))
    WriteLine($"Persona encontrada: Nombre: {personaEncontrada.Nombre}, Edad: {personaEncontrada.Edad}");
else
    WriteLine($"No se encontró ninguna persona con DNI: {dniBuscar}");

// Cambiar la edad de una persona
if (personas.ContainsKey("87654321B")) {
    personas["87654321B"].Edad = 26;
    WriteLine($"La edad de María Gómez ha sido actualizada a: {personas["87654321B"].Edad}");
}

// Recorrer el diccionario de personas
WriteLine("Listado de personas:");
foreach (var persona in personas.Values)
    WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}, DNI: {persona.Dni}");
    
    // Recorrer el diccionario de personas con claves
WriteLine("Listado de personas con DNI:");
foreach (var kvp in personas)
    WriteLine($"DNI: {kvp.Key}, Nombre: {kvp.Value.Nombre}, Edad: {kvp.Value.Edad}");
    
// Eliminar una persona por DNI
if (personas.Remove("12345678A"))
    WriteLine("La persona con DNI 12345678A ha sido eliminada.");
else
    WriteLine("No se encontró ninguna persona con DNI: 12345678A para eliminar.");
    
    // Insertar una nueva persona con un DNI existente (actualiza)
personas["87654321B"] = new Persona { Nombre = "María Gómez", Edad = 27, Dni = "87654321B" };
WriteLine($"La persona con DNI 87654321B ha sido actualizada a edad: {personas["87654321B"].Edad}");

WriteLine("Fin del programa de Diccionarios.");
