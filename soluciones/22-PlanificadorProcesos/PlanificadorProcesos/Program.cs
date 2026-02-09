using System.Diagnostics;
using System.Text;
using PlanificadorProcesos.Factories;
using PlanificadorProcesos.Models;
using PlanificadorProcesos.Services;

// =============================================================================
// EXPERIMENTO: Comparación de Planificadores de Procesos
// =============================================================================
// Este experimento compara diferentes implementaciones de planificadores:
// - Sin prioridad (FIFO): Lista, LinkedList, Dictionary, Cola
// - Con prioridad: Lista, LinkedList, Dictionary+Cola, Dictionary+LinkedList, SortedSet, PriorityQueue
//
// Prioridad: 1 = máxima, 9 = mínima
// Quantum: 2 unidades de tiempo por proceso
// =============================================================================

Console.WriteLine("=== PLANIFICADOR DE PROCESOS - EXPERIMENTO COMPARATIVO ===");
Console.WriteLine();

// Generamos 30 procesos aleatorios usando el Factory
var procesos = ProcesoFactory.CreateMultiple(30);

Console.WriteLine($"Procesos generados: {procesos.Count}");
Console.WriteLine();

var resultados = new List<PlanificadorResultado>();

// -----------------------------------------------------------------------------
// PLANIFICADORES SIN PRIORIDAD (FIFO)
// -----------------------------------------------------------------------------
// Estos planificadores ignoran la prioridad y procesan en orden de llegada.
// Útiles cuando todos los procesos tienen la misma importancia.
// -----------------------------------------------------------------------------

// PlanificadorFifoLista
// - Inserción: O(1) al final
// - Extracción: O(n) al eliminar el primero (shift de elementos)
var lista = new PlanificadorFifoLista();
procesos.ForEach(p => lista.Encolar(p.Copy()));
Console.WriteLine("--- PlanificadorFifoLista ---");
Console.WriteLine($"Procesos: {lista}");
resultados.Add(EjecutarPlanificador(lista, "PlanificadorFifoLista"));


// PlanificadorFifoLinkedList
// - Inserción: O(1) con AddLast
// - Extracción: O(1) con RemoveFirst
// - Eficiente para FIFO sin shift de memoria
var linkedList = new PlanificadorFifoLinkedList();
procesos.ForEach(p => linkedList.Encolar(p.Copy()));
Console.WriteLine();
Console.WriteLine("--- PlanificadorFifoLinkedList ---");
Console.WriteLine($"Procesos: {linkedList}");
resultados.Add(EjecutarPlanificador(linkedList, "PlanificadorFifoLinkedList"));


// PlanificadorFifoDictionary
// - Inserción: O(1) con clave ID
// - Extracción: O(n) al buscar el primer elemento
// - No garantiza orden de inserción
var dictionary = new PlanificadorFifoDictionary();
procesos.ForEach(p => dictionary.Encolar(p.Copy()));
Console.WriteLine();
Console.WriteLine("--- PlanificadorFifoDictionary ---");
Console.WriteLine($"Procesos: {dictionary}");
resultados.Add(EjecutarPlanificador(dictionary, "PlanificadorFifoDictionary"));


// PlanificadorFifoCola
// - Inserción: O(1) con Enqueue
// - Extracción: O(1) con Dequeue
// - Implementación optimizada para operaciones FIFO (RECOMENDADO)
var cola = new PlanificadorFifoCola();
procesos.ForEach(p => cola.Encolar(p.Copy()));
Console.WriteLine();
Console.WriteLine("--- PlanificadorFifoCola ---");
Console.WriteLine($"Procesos: {cola}");
resultados.Add(EjecutarPlanificador(cola, "PlanificadorFifoCola"));

// -----------------------------------------------------------------------------
// PLANIFICADORES CON PRIORIDAD (1 = máxima, 9 = mínima)
// -----------------------------------------------------------------------------
// Estos planificadores siempre ejecutan primero los procesos con prioridad mayor.
// Importantes para sistemas donde hay tareas más urgentes que otras.
// -----------------------------------------------------------------------------

// PlanificadorPrioridadLista
// - Inserción: O(1) al final
// - Extracción: O(n log n) por OrderBy cada vez
// - Simple pero ineficiente para grandes volúmenes
var listaPrioridad = new PlanificadorPrioridadLista();
procesos.ForEach(p => listaPrioridad.Encolar(p.Copy()));
Console.WriteLine();
Console.WriteLine("--- PlanificadorPrioridadLista ---");
Console.WriteLine($"Procesos: {listaPrioridad}");
resultados.Add(EjecutarPlanificador(listaPrioridad, "PlanificadorPrioridadLista"));


// PlanificadorPrioridadLinkedList
// - Inserción: O(1) al final
// - Extracción: O(n) al buscar el nodo con mayor prioridad
// - Menos eficiente que otras opciones pero ilustra el concepto
var linkedListPrioridad = new PlanificadorPrioridadLinkedList();
procesos.ForEach(p => linkedListPrioridad.Encolar(p.Copy()));
Console.WriteLine();
Console.WriteLine("--- PlanificadorPrioridadLinkedList ---");
Console.WriteLine($"Procesos: {linkedListPrioridad}");
resultados.Add(EjecutarPlanificador(linkedListPrioridad, "PlanificadorPrioridadLinkedList"));


// PlanificadorPrioridadDictionaryCola
// - Inserción: O(1) acceso al Dictionary + O(1) Enqueue
// - Extracción: O(k) búsqueda de clave mínima + O(1) Dequeue
// - Muy eficiente para pocas prioridades (1-9)
var dictPrioridad = new PlanificadorPrioridadDictionaryCola();
procesos.ForEach(p => dictPrioridad.Encolar(p.Copy()));
Console.WriteLine();
Console.WriteLine("--- PlanificadorPrioridadDictionaryCola ---");
Console.WriteLine($"Procesos: {dictPrioridad}");
resultados.Add(EjecutarPlanificador(dictPrioridad, "PlanificadorPrioridadDictionaryCola"));


// PlanificadorPrioridadDictionaryLinkedList
// - Inserción: O(1) acceso al Dictionary + O(1) AddLast
// - Extracción: O(k) búsqueda + O(1) RemoveFirst
// - Ventaja sobre Queue: mejor eficiencia en memoria
var dictPrioridadLinkedList = new PlanificadorPrioridadDictionaryLinkedList();
procesos.ForEach(p => dictPrioridadLinkedList.Encolar(p.Copy()));
Console.WriteLine();
Console.WriteLine("--- PlanificadorPrioridadDictionaryLinkedList ---");
Console.WriteLine($"Procesos: {dictPrioridadLinkedList}");
resultados.Add(EjecutarPlanificador(dictPrioridadLinkedList, "PlanificadorPrioridadDictionaryLinkedList"));


// PlanificadorPrioridadSortedSet
// - Inserción: O(log n)
// - Extracción: O(log n) con Min()
// - Mantiene orden automáticamente con IComparer
// - Elegante y eficiente para prioridades comparables
var sortedSet = new PlanificadorPrioridadSortedSet();
procesos.ForEach(p => sortedSet.Encolar(p.Copy()));
Console.WriteLine();
Console.WriteLine("--- PlanificadorPrioridadSortedSet ---");
Console.WriteLine($"Procesos: {sortedSet}");
resultados.Add(EjecutarPlanificador(sortedSet, "PlanificadorPrioridadSortedSet"));


// PlanificadorPrioridadQueue (PriorityQueue de .NET)
// - Inserción: O(log n)
// - Extracción: O(log n)
// - Estructura nativa de .NET optimizada para este propósito
// - Ideal cuando el rango de prioridades es conocido y acotado (RECOMENDADO)
var priorityQueue = new PlanificadorPrioridadQueue();
procesos.ForEach(p => priorityQueue.Encolar(p.Copy()));
Console.WriteLine();
Console.WriteLine("--- PlanificadorPrioridadQueue (NET) ---");
Console.WriteLine($"Procesos: {priorityQueue}");
resultados.Add(EjecutarPlanificador(priorityQueue, "PlanificadorPrioridadQueue"));


ImprimirTablaComparativa(resultados);

// =============================================================================
// CONCLUSIÓN
// =============================================================================
Console.WriteLine();
Console.WriteLine("=================================================================");
Console.WriteLine("CONCLUSIÓN");
Console.WriteLine("=================================================================");
Console.WriteLine();
Console.WriteLine("MEJOR PARA CADA ESCENARIO:");
Console.WriteLine();
Console.WriteLine("1. SIN PRIORIDAD (FIFO):");
Console.WriteLine("   - PlanificadorFifoCola (RECOMENDADO):");
Console.WriteLine("     • O(1) para todas las operaciones");
Console.WriteLine("     • Implementación nativa optimizada");
Console.WriteLine("     • Simplicidad y rendimiento combinados");
Console.WriteLine();
Console.WriteLine("   - PlanificadorFifoLinkedList:");
Console.WriteLine("     • O(1) inserción y extracción");
Console.WriteLine("     • Sin shift de memoria como Lista");
Console.WriteLine("     • Alternativa válida a Cola");
Console.WriteLine();
Console.WriteLine("   - PlanificadorFifoLista:");
Console.WriteLine("     • Útil si necesitas acceso aleatorio frecuente");
Console.WriteLine("     • Ineficiente para FIFO (shift O(n))");
Console.WriteLine();
Console.WriteLine("   - PlanificadorFifoDictionary:");
Console.WriteLine("     • Solo si necesitas búsqueda por ID");
Console.WriteLine("     • No garantiza orden de inserción");
Console.WriteLine();
Console.WriteLine("2. CON PRIORIDAD:");
Console.WriteLine("   - PlanificadorPrioridadQueue (RECOMENDADO):");
Console.WriteLine("     • O(log n) operaciones");
Console.WriteLine("     • Estructura nativa de .NET");
Console.WriteLine("     • Menor overhead que soluciones personalizadas");
Console.WriteLine();
Console.WriteLine("   - PlanificadorPrioridadDictionaryCola:");
Console.WriteLine("     • O(1) extracción cuando hay pocas prioridades (1-9)");
Console.WriteLine("     • Ideal cuando el rango de prioridades es acotado");
Console.WriteLine("     • Organiza claramente por niveles de prioridad");
Console.WriteLine();
Console.WriteLine("   - PlanificadorPrioridadDictionaryLinkedList:");
Console.WriteLine("     • Similar a DictionaryCola");
Console.WriteLine("     • Mejor eficiencia en memoria (LinkedList vs Queue)");
Console.WriteLine("     • Útil cuando hay muchas colas pequeñas");
Console.WriteLine();
Console.WriteLine("   - PlanificadorPrioridadSortedSet:");
Console.WriteLine("     • O(log n) elegante con comparador");
Console.WriteLine("     • Mantiene orden automáticamente");
Console.WriteLine("     • Útil para prioridades complejas");
Console.WriteLine();
Console.WriteLine("   - PlanificadorPrioridadLinkedList:");
Console.WriteLine("     • O(1) inserción, O(n) extracción");
Console.WriteLine("     • Ilustra el concepto pero ineficiente");
Console.WriteLine("     • Útil para aprender el algoritmo");
Console.WriteLine();
Console.WriteLine("   - PlanificadorPrioridadLista:");
Console.WriteLine("     • O(n log n) por OrderBy en cada extracción");
Console.WriteLine("     • Solo para volúmenes pequeños");
Console.WriteLine("     • La opción menos eficiente");
Console.WriteLine();
Console.WriteLine("VEREDICTO FINAL:");
Console.WriteLine("• Para FIFO: PlanificadorFifoCola o PlanificadorFifoLinkedList");
Console.WriteLine("• Para Prioridad: PlanificadorPrioridadQueue o PlanificadorPrioridadDictionaryCola");
Console.WriteLine("• Evitar: PlanificadorPrioridadLista en producción");

// =============================================================================
// MÉTODO AUXILIAR: Ejecuta el planificador y muestra estadísticas
// =============================================================================
PlanificadorResultado EjecutarPlanificador(IPlanificadorProcesos planificador, string nombre) {
    Console.WriteLine($"Tamaño inicial: {planificador.Contar()}");

    var quantum = 2;
    var ejecuciones = 0;
    var sw = Stopwatch.StartNew();

    while (!planificador.EstaVacia()) {
        var proceso = planificador.Desencolar();
        if (proceso != null) {
            Console.WriteLine($"Ejecutando: {proceso}");
            proceso.Tiempo -= quantum;
            ejecuciones++;

            if (proceso.IsActive) {
                Console.WriteLine($"  → Tiempo restante: {proceso.Tiempo}");
                planificador.Encolar(proceso);
            }
            else {
                Console.WriteLine("  → TERMINADO");
            }
        }
    }

    sw.Stop();
    Console.WriteLine($"Ejecuciones: {ejecuciones}");
    Console.WriteLine($"Tiempo ejecución: {sw.ElapsedMilliseconds}ms");

    return new PlanificadorResultado {
        Nombre = nombre,
        Ejecuciones = ejecuciones,
        TiempoMs = sw.ElapsedMilliseconds
    };
}



// =============================================================================
// MÉTODO AUXILIAR: Imprime tabla comparativa de tiempos
// =============================================================================
void ImprimirTablaComparativa(List<PlanificadorResultado> listaResultados) {
    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════");
    Console.WriteLine("                          TABLA COMPARATIVA DE TIEMPOS                         ");
    Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════");
    Console.WriteLine();
    Console.WriteLine($"{"Planificador",-45} {"Ejecuciones",15} {"Tiempo(ms)",15}");
    Console.WriteLine(new string('─', 75));

    foreach (var r in listaResultados) {
        Console.WriteLine($"{r.Nombre,-45} {r.Ejecuciones,15} {r.TiempoMs,15}");
    }

    Console.WriteLine(new string('─', 75));
    var tiempoMin = listaResultados.Min(r => r.TiempoMs);
    var tiempoMax = listaResultados.Max(r => r.TiempoMs);
    var promedio = listaResultados.Average(r => r.TiempoMs);
    Console.WriteLine($"{"MÍNIMO:",45} {tiempoMin,15}ms");
    Console.WriteLine($"{"MÁXIMO:",45} {tiempoMax,15}ms");
    Console.WriteLine($"{"PROMEDIO:",45} {promedio,15:F2}ms");
    Console.WriteLine($"{"DIFERENCIA (MAX-MIN):",45} {tiempoMax - tiempoMin,15}ms");
    Console.WriteLine();
    Console.WriteLine("Nota: Los tiempos de ejecución de procesos son idénticos para todos los");
    Console.WriteLine("      planificadores. Las diferencias en tiempo se deben a la eficiencia");
    Console.WriteLine("      algorítmica de cada estructura de datos.");
    Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════");
}

record PlanificadorResultado {
    public string Nombre { get; init; } = "";
    public int Ejecuciones { get; init; }
    public long TiempoMs { get; init; }
}

// =============================================================================
// EXPLICACIÓN DE LAS ESTRUCTURAS INTERNAS DE C#
// =============================================================================
// NOTA: En Dictionary<int, Queue<Proceso>> se podría usar LinkedList<T> en lugar
// de Queue<T> para mejor eficiencia en memoria:
//   - Queue: array circular con capacidad extra (espacios vacíos posibles)
//   - LinkedList: solo usa memoria para nodos existentes (valor + 2 refs)
//   - Para colas pequeñas (3-5 elementos), LinkedList usa menos memoria
// =============================================================================

// -----------------------------------------------------------------------------
// Queue<T> DE .NET
// -----------------------------------------------------------------------------
// Queue<T> está implementado como un Array Circular (Circular Buffer).
//
// En lugar de usar LinkedList (que tiene overhead de nodos), usa un array interno
// con dos índices:
//   - head: índice del primer elemento
//   - tail: índice donde se insertará el siguiente elemento
//
// Cuando el array se llena, dobla su capacidad y copia los elementos al inicio.
// Esto amortiza el costo de las inserciones.
//
// ¿Qué pasa si borramos muchos elementos?
// - El array NO se reduce automáticamente (por diseño).
// - head avanza, pero tail se queda al final del array.
// - Queda espacio "vacío" al inicio del array que no se reutiliza.
//
// Ejemplo: Cola con 100 elementos, capacity 128. Desencolamos 90.
// - Quedan 10 elementos útiles al final del array.
// - Los primeros 90 espacios están "vacíos" pero el array sigue siendo de 128.
//
// Solución: Queue<T>.TrimExcess() - redimensiona el array al tamaño real.
// Complejidad: O(n) para copiar los elementos restantes al inicio.
//
// Complejidad:
//   - Enqueue: O(1) amortizado
//   - Dequeue: O(1)
//   - Peek: O(1)
//
// Analogía: Es como una fila en un supermercado donde el cajero no hace que todos
// se deshilachen cuando alguien se va, simplemente atiende al siguiente.

// -----------------------------------------------------------------------------
// PriorityQueue<T, TPriority> DE .NET 6+
// -----------------------------------------------------------------------------
// PriorityQueue<T, TPriority> está implementado como un Min-Heap.
//
// Un Heap es un árbol binario completo donde cada nodo padre es menor (o mayor)
// que sus hijos. Se implementa como un array donde:
//
//   Para un nodo en índice i:
//     - Hijo izquierdo: 2*i + 1
//     - Hijo derecho: 2*i + 2
//     - Padre: (i-1)/2
//
// Enqueue:
//   1. Se añade el elemento al final del array
//   2. Se "sift up" (tamizar hacia arriba) intercambiando con el padre si es necesario
//   Esto asegura que la propiedad del heap se mantenga.
//
// Dequeue:
//   1. El elemento con mayor prioridad está en la raíz (índice 0)
//   2. Se intercambia con el último elemento
//   3. Se elimina el último
//   4. Se "sift down" (tamizar hacia abajo) intercambiando con el hijo mayor si es necesario
//
// Complejidad:
//   - Enqueue: O(log n)
//   - Dequeue: O(log n)
//   - Peek: O(1)
//
// Ventaja sobre SortedList:
//   SortedList requiere O(n log n) para insertar porque debe mantener todo ordenado.
//   Heap solo necesita O(log n) por inserción.
//
// Analogía: Es como una pirámide de personas donde la más importante está arriba,
// y cuando alguien nuevo entra, se abre paso hacia arriba si es más importante.
//
// ¿Qué pasa si hay muchos cambios de prioridad?
// - Cada cambio de prioridad requiere un "sift up" o "sift down" completo.
// - En el peor caso, el elemento puede ir desde una hoja hasta la raíz (o viceversa).
// - Esto significa recorrer todo el árbol: O(log n) intercambios.
//
// Costo acumulado:
//   - 1 cambio de prioridad: O(log n)
//   - n cambios de prioridad: O(n log n)
//
// Ejemplo: 1000 cambios de prioridad en una cola de 1000 elementos:
//   - Peor caso: 1000 * log2(1000) ≈ 1000 * 10 = 10.000 operaciones.
//
// Comparación:
//   - PriorityQueue con prioridad cambiante: O(n log n) total
//   - Dictionary<int, Queue<T>> o Dictionary<int, LinkedList<T>>: O(1) por cambio
//
// Conclusión:
//   Si las prioridades cambian frecuentemente, PriorityQueue puede ser costoso.
//   En ese caso, Dictionary<int, Queue<T>> o Dictionary<int, LinkedList<T>> son más eficientes (O(1) por cambio).
//
// Memoria: LinkedList<T> vs Queue<T>
//   - Queue<T>: array con capacidad extra (espacios vacíos posibles)
//   - LinkedList<T>: solo nodos existentes (valor + 2 referencias)
//   - Para colas pequeñas, LinkedList usa menos memoria
//
// =============================================================================
// EXPLICACIÓN DE LA TABLA COMPARATIVA DE TIEMPOS
// =============================================================================
//
// ¿POR QUÉ LAS EJECUCIONES SON IDÉNTICAS?
//   Todos los planificadores procesan los mismos 30 procesos generados por el
//   factory, con los mismos tiempos iniciales. El quantum es idéntico (2).
//   Por tanto, cada proceso recibe exactamente el mismo número de ejecuciones
//   y termina en el mismo momento, independientemente del planificador usado.
//
// ¿POR QUÉ LOS TIEMPOS DE EJECUCIÓN SON DIFERENTES?
//   Las diferencias se deben a la EFICIENCIA ALGORÍTMICA de cada estructura:
//
//   - O(1) operaciones: Cola, LinkedList, Dictionary → Más rápidos
//   - O(log n) operaciones: SortedSet, PriorityQueue → Intermedios
//   - O(n) operaciones: Lista, Dictionary con búsqueda secuencial → Más lentos
//
//   El "ganador" no es necesariamente el más rápido en ms (0ms vs 11ms),
//   sino aquel que mejor equilibra:
//     • Complejidad algorítmica
//     • Uso de memoria
//     • Simplicidad de código
//     • Mantenibilidad
//
// OBSERVACIONES DE LOS RESULTADOS:
//   • PlanificadorFifoCola y PlanificadorFifoLinkedList: O(1) para todas las
//     operaciones. Ideales para FIFO puro.
//   • PlanificadorPrioridadDictionaryCola: O(1) extracción con rango fijo de
//     prioridades (1-9). Muy eficiente en la práctica.
//   • PlanificadorPrioridadSortedSet: O(log n) elegante pero con overhead.
//   • PlanificadorFifoDictionary: O(n) al buscar el primer elemento lo hace
//     ineficiente para este caso de uso.
//
// CONCLUSIÓN PRÁCTICA:
//   Para sistemas reales, elegir según el caso:
//     - FIFO puro → Queue<T> (O(1), nativo, optimizado)
//     - Prioridades fijas (1-9) → Dictionary<int, Queue<T>> (O(1) real)
//     - Prioridades dinámicas → PriorityQueue<T> (O(log n), nativo)
//     - Evitar Lista<OrderBy> en producción (O(n log n) acumulado)
// =============================================================================
