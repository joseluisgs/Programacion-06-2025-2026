// See https://aka.ms/new-console-template for more information

using FuncionesExtension.Extension;

Console.WriteLine("Hola Funciones de Extension!");

int numero = 7;
Console.WriteLine($"{numero} es par? {numero.EsPar()}");
Console.WriteLine($"{numero} es primo? {numero.EsPrimo()}");
Console.WriteLine($"El factorial de {numero} es {numero.Factorial()}");

string texto = "anilina";
Console.WriteLine($"\"{texto}\" es palíndromo? {texto.EsPalindromo()}");
Console.WriteLine($"\"{texto}\" tiene {texto.ContarVocales()} vocales.");
Console.WriteLine($"\"{texto}\" invertido es \"{texto.Invertir()}\".");