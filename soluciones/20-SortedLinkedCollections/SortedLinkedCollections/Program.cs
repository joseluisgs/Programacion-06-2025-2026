// See https://aka.ms/new-console-template for more information

using static System.Console;

WriteLine("Hola Linked y Sorted Collections!");

// Lista enlazada (LinkedList)
var linkedList = new LinkedList<int>();
linkedList.AddLast(10);
linkedList.AddLast(20);
linkedList.AddLast(30);
linkedList.AddFirst(5);

WriteLine("LinkedList contenidos:");
foreach (var item in linkedList) WriteLine(item);


// Lista ordenada (SortedList)
// Que la diferencia de un Dictionary
// es que mantiene los elementos ordenados por la clave
// mientras que un Dictionary no garantiza ningún orden
var sortedList = new SortedList<int, string>();
sortedList.Add(3, "Tres");
sortedList.Add(1, "Uno");
sortedList.Add(2, "Dos");

WriteLine("SortedList contenidos:");
foreach (var kvp in sortedList) WriteLine($"{kvp.Key}: {kvp.Value}");

// SortedDictionary
// La diferencia con SortedList es que SortedDictionary
// es más eficiente para inserciones y eliminaciones frecuentes
var sortedDict = new SortedDictionary<string, int>();
sortedDict.Add("Manzana", 3);
sortedDict.Add("Banana", 2);
sortedDict.Add("Cereza", 5);

// SortedSet
// Es una colección de elementos ordenados y sin duplicados
// La diferencia con HashSet es que SortedSet
// garantiza que los elementos sean ordenados
var sortedSet = new SortedSet<int>();
sortedSet.Add(5);
sortedSet.Add(1);
sortedSet.Add(3);
sortedSet.Add(1); // Duplicado, no se agregará
sortedSet.Add(5); // Agregar elementos