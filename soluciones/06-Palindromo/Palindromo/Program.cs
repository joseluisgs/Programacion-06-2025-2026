// See https://aka.ms/new-console-template for more information

using ListaEnlazada.Cola;
using ListaEnlazada.Pila;

Console.WriteLine("Ejemplo de palíndromo con Pilas y Colas");

var palabra01 = "anilina";
var palabra02 = "reconocer";
var palabra03 = "palabra";

Console.WriteLine($"¿La palabra {palabra01} es un palíndromo? {EsPalindromo(palabra01)}");
Console.WriteLine($"¿La palabra {palabra02} es un palíndromo? {EsPalindromo(palabra02)}");
Console.WriteLine($"¿La palabra {palabra03} es un palíndromo? {EsPalindromo(palabra03)}");

bool EsPalindromo(string palabra) {
    var cola = new Cola<char>();
    var pila = new Pila<char>();
    
    
    // Llenar la pila y la cola con los caracteres de la palabra
    foreach (var caracter in palabra) {
        cola.Encolar(caracter);
        pila.Apilar(caracter);
    }
    
    // Comparar los caracteres de la pila y la cola
    while (!cola.EstaVacia() && !pila.EstaVacia()) {
        var caracterCola = cola.Desencolar();
        var caracterPila = pila.Desapilar();
        if (caracterCola != caracterPila) {
            return false;
        }
    }
    return true;
}

