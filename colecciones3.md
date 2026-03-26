```
──────────────────────────────────────────────────────────────────────────────
          📦 COLECCIONES EN C# — System.Collections.
──────────────────────────────────────────────────────────────────────────────
INICIO
│
├── ¿Necesitas buscar elementos por CLAVE? (map/diccionario)
│     │
│     ├── SÍ →
│     │      │
│     │      ├── ¿Importa el ORDEN de las claves?
│     │      │      │
│     │      │      ├── SÍ →
│     │      │      │      ¿Quieres que estén ORDENADAS automáticamente?
│     │      │      │          │
│     │      │      │          ├── SÍ → SortedDictionary<TKey, TValue>
│     │      │      │          │         (Claves siempre ordenadas por orden natural: árbol)
│     │      │      │          │
│     │      │      │          └── NO → OrderedDictionary
│     │      │      │                    (Mantiene orden de inserción)
│     │      │      │
│     │      │      └── NO → Dictionary<TKey, TValue>
│     │      │              (Clave→valor rápido; sin orden)
│     │      │
│     │      └── (FIN rama diccionarios)
│     │
│     └── NO →
│            │
│            ├── ¿Los elementos pueden REPETIRSE?
│            │      │
│            │      ├── SÍ →
│            │      │      │
│            │      │      ├── ¿Importa el ORDEN?
│            │      │      │      │
│            │      │      │      ├── NO → List<T>
│            │      │      │      │         (Lista general, acceso rápido)
│            │      │      │      │
│            │      │      │      ├── SÍ, orden de inserción →
│            │      │      │      │         List<T>
│            │      │      │      │         (Mantiene el orden natural)
│            │      │      │      │
│            │      │      │      ├── SÍ, orden FIFO →
│            │      │      │      │         Queue<T>
│            │      │      │      │         (Primero entra, primero sale)
│            │      │      │      │
│            │      │      │      └── SÍ, orden LIFO →
│            │      │      │                Stack<T>
│            │      │      │                (Último entra, primero sale)
│            │      │      │
│            │      │      └── (FIN rama duplicables)
│            │      │
│            │      └── NO (no permite duplicados) →
│            │             │
│            │             ├── ¿Necesitas los elementos ORDENADOS?
│            │             │      │
│            │             │      ├── SÍ → SortedSet<T>
│            │             │      │         (Set ordenado automáticamente por orden natural)
│            │             │      │
│            │             │      └── NO → HashSet<T>
│            │             │                (Set rápido sin orden)
│            │             │
│            │             └── (FIN rama no duplicables)
│            │
│            └── (FIN rama sin claves)
│
├── ¿Necesitas un tamaño FIJO y acceso por ÍNDICE?
│     │
│     ├── SÍ → Array (T[])
│     │         (Muy rápido, tamaño fijo)
│     └── NO
│
├── ¿Necesitas inserciones rápidas en extremos?
│     │
│     ├── SÍ → LinkedList<T>
│     │         (Rápido en añadir/quitar nodos al estar enlazados)
│     └── NO
│
├── ¿Ejecución MULTIHILO?
│     │
│     ├── SÍ →
│     │      • ConcurrentQueue<T>  (FIFO concurrente)
│     │      • ConcurrentStack<T>  (LIFO concurrente)
│     │      • ConcurrentBag<T>    (Bolsa no ordenada multi-hilo)
│     │      • BlockingCollection<T> (Controla productores/consumidores)
│     │      • ConcurrentDictionary<K,V> (Diccionario concurrente)
│     │
│     └── NO
│
├── ¿Necesitas que sean INMUTABLES?
│     │
│     ├── SÍ →
│     │      • ImmutableList<T>  (Lista inmutable
│     │      • ImmutableArray<T> (Array inmutable
│     │      • ImmutableHashSet<T> (Set inmutable sin orden)
│     │      • ImmutableSortedSet<T> (Set inmutable ordenado natural)
│     │      • ImmutableDictionary<K,V> (Diccionario inmutable) 
│     │      • ImmutableQueue<T> (Cola inmutable)
│     │      • ImmutableStack<T> (Pila inmutable)
│     │
│     └── NO
│
└── FIN

```
