// See https://aka.ms/new-console-template for more information

using Cache.Cache;
using static System.Console;

const int CAPACITY = 3;

// Instanciamos las tres implementaciones
ICache<string, string> simple = new SimpleCache<string, string>(CAPACITY);
ICache<string, string> fifo = new FifoCache<string, string>(CAPACITY);
ICache<string, string> lru = new LruCache<string, string>(CAPACITY);

WriteLine("=== LABORATORIO DE ESTRATEGIAS DE CACHE ===");
WriteLine($"Capacidad máxima de las caches: {CAPACITY}\n");

// 1. LLENADO INICIAL (A, B, C)
// Entran las raquetas Yonex Ezone y el pedal Timmy
string[] items = { "Yonex_2022", "Yonex_2025", "Timmy_OD" };

WriteLine(">>> Paso 1: Llenando las caches con 3 elementos...");
foreach (var item in items) {
    simple.Add(item, "Data");
    fifo.Add(item, "Data");
    lru.Add(item, "Data");
}

simple.DisplayStatus();
fifo.DisplayStatus();
lru.DisplayStatus();

// 2. EL MOMENTO CRUCIAL: ACCESO A DATOS
// Vamos a simular que usamos mucho la primera raqueta ("Yonex_2022")
WriteLine("\n>>> Paso 2: Usamos (Get) la llave 'Yonex_2022'...");
simple.Get("Yonex_2022");
fifo.Get("Yonex_2022");
lru.Get("Yonex_2022"); // ¡Aquí es donde LRU se diferencia!

lru.DisplayStatus(); // Verás que Yonex_2022 ahora es el "más reciente"

// 3. LA EXPULSIÓN (EVICTION)
// Añadimos un cuarto elemento: el pedal "Angry_Charlie"
WriteLine("\n>>> Paso 3: Añadimos 'Angry_Charlie'. La cache está llena, alguien debe salir...");
simple.Add("Angry_Charlie", "Data");
fifo.Add("Angry_Charlie", "Data");
lru.Add("Angry_Charlie", "Data");

simple.DisplayStatus();
fifo.DisplayStatus();
lru.DisplayStatus();

WriteLine("\n================ CONCLUSIONES PARA EL EXAMEN ================");

// ANÁLISIS FIFO
WriteLine("\n[FIFO] ¿Qué pasó?");
WriteLine("- 'Yonex_2022' fue eliminado porque fue el primero que entró.");
WriteLine("- No importa que lo hayamos usado en el Paso 2; FIFO no tiene memoria de uso.");
WriteLine("> MEJOR CUANDO: Los datos tienen una vida útil corta y el orden de llegada manda.");

// ANÁLISIS LRU
WriteLine("\n[LRU] ¿Qué pasó?");
WriteLine("- 'Yonex_2025' fue eliminado (era el que más tiempo llevaba sin usarse).");
WriteLine("- 'Yonex_2022' SOBREVIVIÓ porque al consultarlo en el Paso 2, saltó al final de la lista.");
WriteLine("> MEJOR CUANDO: Quieres mantener en memoria lo que el usuario usa más a menudo.");

// ANÁLISIS SIMPLE
WriteLine("\n[SIMPLE] ¿Qué pasó?");
WriteLine("- Eliminó lo primero que encontró en el Dictionary (normalmente 'Yonex_2022').");
WriteLine("- Es impredecible y no garantiza justicia.");
WriteLine("> MEJOR CUANDO: La memoria es crítica y no te importa qué dato se pierda.");

// 4. PRUEBA DE ELIMINACIÓN MANUAL
WriteLine("\n>>> Paso 4: Probando el borrado manual de 'Timmy_OD'...");
if (lru.Remove("Timmy_OD"))
    WriteLine("Elemento 'Timmy_OD' eliminado correctamente con O(1).");
lru.DisplayStatus();