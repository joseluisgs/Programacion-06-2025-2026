// See https://aka.ms/new-console-template for more information

using SobrecargaOperadores.Models;

Console.WriteLine("Hola Sobrecarga de Operadores!");

var p1 = new Persona { Nombre = "Juan", Edad = 30 };
var p2 = new Persona { Nombre = "Juan", Edad = 30 };
var p3 = new Persona { Nombre = "Ana", Edad = 25 };

Console.WriteLine($"p1 == p2: {p1 == p2}"); // True
Console.WriteLine($"p1 == p3: {p1 == p3}"); // False
Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}"); // True
Console.WriteLine($"p1.Equals(p3): {p1.Equals(p3)}"); // False
Console.WriteLine($"p1 != p3: {p1 != p3}"); // True
Console.WriteLine($"!p1.Equals(p3): {!p1.Equals(p3)}"); // False

var v1 = new Vector { X = 2, Y = 3 };
var v2 = new Vector { X = 4, Y = 5 };
Console.WriteLine($"v1 : {v1}"); // (2, 3)
Console.WriteLine($"v2 : {v2}"); // (4, 5)
Console.WriteLine($"v1 == v2: {v1 == v2}"); // False
Console.WriteLine($"v1 != v2: {v1 != v2}"); // True
Console.WriteLine($"v1 + v2: X = {(v1 + v2)}"); // X = (6, 8)}
Console.WriteLine($"v1 - v2: X = {(v1 - v2)}"); // X = (-2, -2)}
Console.WriteLine($"v1 * 3: X = {(v1 * 3)}"); // X = (6, 9)}
Console.WriteLine($"v1 * v2 (producto cruzado): X = {(v1 * v2)}"); // X = (2-,2)

var f1 = new Fraccion { Numerador = 1, Denominador = 2 }; // 1/2
var f2 = new Fraccion { Numerador = 3, Denominador = 4 }; // 3/4

Console.WriteLine($"f1 : {f1}"); // 1/2
Console.WriteLine($"f2 : {f2}"); // 3/4
Console.WriteLine($"f1 == f2: {f1 == f2}"); // False
Console.WriteLine($"f1 != f2: {f1 != f2}"); // True
Console.WriteLine($"f1 + f2: {f1 + f2}"); // 5/4
Console.WriteLine($"f1 - f2: {f1 - f2}"); // -1/4
Console.WriteLine($"f1 * f2: {f1 * f2}"); // 3/8
Console.WriteLine($"f1 / f2: {f1 / f2}"); // 2/3
Console.WriteLine($"++f1: {++f1}"); // 3/2