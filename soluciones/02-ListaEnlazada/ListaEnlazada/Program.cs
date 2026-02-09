// See https://aka.ms/new-console-template for more information

using ListaEnlazada.Cola;
using ListaEnlazada.Lista;
using ListaEnlazada.Pila;
using static System.Console;

WriteLine("Hola Lista Enlazada!");

var lista = new Lista<int>();
lista.AgregarFinal(10);
lista.AgregarFinal(20);
lista.AgregarInicio(5);
lista.AgregarEn(15, 2); // Agregar 15 en el índice 2
lista.Mostrar(); // Debería mostrar: 5 -> 10 -> 15 -> 20
WriteLine($"Primero: {lista.ObtenerPrimero()}"); // Debería mostrar: 5
WriteLine($"Último: {lista.ObtenerUltimo()}"); // Debería mostrar: 20
WriteLine($"Elemento en índice 2: {lista.Obtener(2)}"); // Debería mostrar: 15
WriteLine($"Existe 15: {lista.Existe(15)}"); // Debería mostrar: True
WriteLine($"Contar: {lista.Contar()}"); // Debería mostrar: 4
// Recorremos e imprimimos los elementos para verificar
// El problema de esto es que la recorremos dos veces, una para contar y otra para obtener
WriteLine("Recorrido con for:");
for (var i = 0; i < lista.Contar(); i++) {
    var elemento = lista.Obtener(i);
    WriteLine(elemento);
}

// Usando foreach gracias al IEnumerable implementado, podemos recorrer la lista sin preocuparnos por los índices
WriteLine("Recorrido con foreach:");
foreach (var elemento in lista)
    WriteLine(elemento);

lista.EliminarEn(2); // Eliminar el elemento en el índice 2
lista.Mostrar(); // Debería mostrar: 5 -> 10 -> 20
lista.EliminarInicio();
lista.Mostrar(); // Debería mostrar: 10 -> 20
lista.EliminarFinal();
lista.Mostrar(); // Debería mostrar: 10
WriteLine($"¿Está vacía?: {lista.EstaVacia()}"); // Debería mostrar: False
lista.Limpiar();
WriteLine($"¿Está vacía después de limpiar?: {lista.EstaVacia()}"); // Debería mostrar: True

WriteLine();
WriteLine("Hola Cola!");
var cola = new Cola<string>();
cola.Encolar("Primero");
cola.Encolar("Segundo");
cola.Encolar("Tercero");
cola.Mostrar(); // Debería mostrar: Primero -> Segundo -> Tercero
WriteLine($"Frente de la cola: {cola.VerFrente()}"); // Debería mostrar: Primero
WriteLine($"Desencolando: {cola.Desencolar()}"); // Debería mostrar: Primero
cola.Mostrar(); // Debería mostrar: Segundo -> Tercero
WriteLine($"Contar en la cola: {cola.Contar()}"); // Debería mostrar: 2
WriteLine($"¿Está vacía la cola?: {cola.EstaVacia()}"); // Debería mostrar: False
while (!cola.EstaVacia())
    WriteLine($"Desencolando: {cola.Desencolar()}");
WriteLine($"¿Está vacía la cola después de desencolar todo?: {cola.EstaVacia()}"); // Debería mostrar: True

WriteLine();
WriteLine("Hola Pila!");
var pila = new Pila<double>();
pila.Apilar(1.1);
pila.Apilar(2.2);
pila.Apilar(3.3);
pila.Mostrar(); // Debería mostrar: 1.1 -> 2.2 -> 3.3
WriteLine($"Tope de la pila: {pila.VerTope()}"); // Debería mostrar: 3.3
WriteLine($"Desapilando: {pila.Desapilar()}"); // Debería mostrar: 3.3
pila.Mostrar(); // Debería mostrar: 1.1 -> 2.2
WriteLine($"Contar en la pila: {pila.Contar()}"); // Debería mostrar: 2
WriteLine($"¿Está vacía la pila?: {pila.EstaVacia()}"); // Debería mostrar: False
while (!pila.EstaVacia())
    WriteLine($"Desapilando: {pila.Desapilar()}");
WriteLine($"¿Está vacía la pila después de desapilar todo?: {pila.EstaVacia()}"); // Debería mostrar: True