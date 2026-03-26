// See https://aka.ms/new-console-template for more information

using static System.Console;

WriteLine("Hola Colas y Pilas!");

// Ejemplo de Pila (LIFO - Last In First Out)
var pila = new Stack<int>();
pila.Push(1);
pila.Push(2);
pila.Push(3);

WriteLine("Pila:");
while (pila.Count > 0)
    WriteLine(pila.Pop());

// Ejemplo de Cola (FIFO - First In First Out)
var cola = new Queue<int>();
cola.Enqueue(1);
cola.Enqueue(2);
cola.Enqueue(3);
WriteLine("Cola:");
while (cola.Count > 0)
    WriteLine(cola.Dequeue());

var testStrings = new[] {
    "A man, a plan, a canal: Panama",
    "racecar",
    "hello",
    "No 'x' in Nixon",
    "Not a palindrome"
};

WriteLine("\nPalindrome test:");
foreach (var str in testStrings)
    WriteLine($"\"{str}\" es palindromo? {IsPalindrome(str)}");


bool IsPalindrome(string str) {
    var pila = new Stack<char>();
    var cola = new Queue<char>();

    foreach (var ch in str)
        if (char.IsLetterOrDigit(ch)) {
            var lowerCh = char.ToLower(ch);
            pila.Push(lowerCh);
            cola.Enqueue(lowerCh);
        }

    while (pila.Count > 0 && cola.Count > 0)
        if (pila.Pop() != cola.Dequeue())
            return false;

    return true;
}

// Cola de prioridad es FIFO pero con prioridad
var priorityQueue = new PriorityQueue<string, int>();
priorityQueue.Enqueue("1.- Tarea de prioridad media", 2);
priorityQueue.Enqueue("Tarea de prioridad baja", 3);
priorityQueue.Enqueue("3.- Tarea de prioridad muy alta", 1);
priorityQueue.Enqueue("4.- Tarea de prioridad baja", 3);
priorityQueue.Enqueue("5.- Tarea de prioridad media", 2);

WriteLine("\nCola de Prioridad:");
while (priorityQueue.Count > 0) {
    var tarea = priorityQueue.Dequeue();
    WriteLine(tarea);
}