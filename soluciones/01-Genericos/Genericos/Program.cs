// See https://aka.ms/new-console-template for more information

using Genericos.Caja;

var cajaDeEnteros = new CajaEnteros(34);
var cajaStrings = new CajaStrings("Hola a todos");
var cajaPersona = new CajaPersona(new Persona("Juan", 25));

Console.WriteLine($"Caja de enteros: {cajaDeEnteros.GetValor()}");
Console.WriteLine($"Caja de strings: {cajaStrings.GetValor()}");
Console.WriteLine($"Caja de persona: {cajaPersona.GetValor().Nombre}");

var cajaDeObjetos = new CajaObject("Un string como objeto");
// Si te equivocas la conversion explota en tiempo de ejecucion
//Console.WriteLine($"Caja de objetos: {((int)cajaDeObjetos.GetValor())}");
var otraCajaDeObjetos = new CajaObject(12345);
Console.WriteLine($"Otra caja de objetos:{((int)otraCajaDeObjetos.GetValor())}");

var cajaGenericaDeEnteros = new CajaGenerica<int>(56);
// Nuestro codigo es seguro en tiempo de compilacion
// var cajaGenericaDeEnteros = new CajaGenerica<int>("Genericos en C#" 56); // Error de compilacion
var cajaGenericaDeStrings = new CajaGenerica<string>("Genericos en C#");
var cajaGenericaDePersona = new CajaGenerica<Persona>(new Persona("Ana", 30));

Console.WriteLine($"Caja generica de enteros: {cajaGenericaDeEnteros.GetValor()}");
Console.WriteLine($"Caja generica de strings: {cajaGenericaDeStrings.GetValor().Length}");
Console.WriteLine($"Caja generica de persona: {cajaGenericaDePersona.GetValor().Nombre}");

var cajaGenericaMultiple = new CajaGenericaMultiple<int, string>(99, "C# Genericos");
var cajaGenericaMultipleEnteros = new CajaGenericaMultiple<int, int>(99, 69);
Console.WriteLine($"Caja generica multiple: {cajaGenericaMultiple.GetValor()} - {cajaGenericaMultiple.GetOtroValor()}");
var cajaGenericaMultiplePersona = new CajaGenericaMultiple<Persona, int>(new Persona("Luis", 40), 40);
Console.WriteLine($"Caja generica multiple persona: {cajaGenericaMultiplePersona.GetValor().Nombre} - {cajaGenericaMultiplePersona.GetOtroValor()}");