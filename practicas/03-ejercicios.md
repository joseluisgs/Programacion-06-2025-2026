# Relación de Ejercicios: Colecciones, Genéricos y Programación Funcional

- [Relación de Ejercicios: Colecciones, Genéricos y Programación Funcional](#relación-de-ejercicios-colecciones-genéricos-y-programación-funcional)
  - [I. Estructuras Lineales y TDA Clásicos](#i-estructuras-lineales-y-tda-clásicos)
  - [II. Colecciones de Búsqueda y Gestión de Datos](#ii-colecciones-de-búsqueda-y-gestión-de-datos)
  - [III. Sistemas Complejos y Robustos](#iii-sistemas-complejos-y-robustos)
  - [IV. Programación Funcional y Extensiones](#iv-programación-funcional-y-extensiones)
  - [V. Estructuras Personalizadas y Gestión de Repositorios](#v-estructuras-personalizadas-y-gestión-de-repositorios)


## I. Estructuras Lineales y TDA Clásicos

1.  **La Serpiente (Listas Enlazadas):** Implementa el TDA del cuerpo de una serpiente utilizando obligatoriamente **listas enlazadas**.
    *   1.1. Generaliza el sistema para gestionar un **nido de serpientes** con capacidad máxima de 20 ejemplares.
2.  **Juego de las Siete y Media (Pilas):** Simula el juego entre un humano y la máquina utilizando una **pila** (`Stack<T>`) para gestionar el mazo de 40 cartas.
3.  **El Solitario (Pilas):** Implementa el juego con baraja francesa usando una pila principal y dos montones.
    *   3.1. La base de los montones debe ser un rey y las cartas superiores de diferente color.
    *   3.2. Implementa la regeneración del mazo respetando el orden de salida original y permitiendo solo tres barajeos.
4.  **Verificador de Palíndromos:** Determina si una cadena es palíndroma utilizando simultáneamente una **pila** y una **cola** para comparar el orden inverso y directo de los caracteres.
5.  **Simulación Round-Robin (Colas):** Implementa un algoritmo de planificación de procesos donde cada uno tiene una identidad y un *quantum* al azar.
    *   5.1. **Gestión FIFO:** Los procesos entran y salen de la CPU mediante una cola genérica.
    *   5.2. **Prioridad:** Modifica el sistema para que los procesos (prioridad 0 a 3) se inserten en la cola según su importancia.
    *   5.3. **Registro de salida:** Añade una pila donde el procesador apile los procesos conforme van finalizando con éxito.
6.  **Historial de Navegación:** Implementa la lógica de los botones "Atrás" y "Adelante" de un navegador web mediante el uso de dos estructuras de tipo **pila**.
7.  **Balanceo de Paréntesis:** Crea un analizador que utilice una `Stack<char>` para verificar si los paréntesis, llaves y corchetes de una expresión están correctamente equilibrados.
8.  **Gestión de Cola de Impresión:** Simula un servidor de impresión donde los documentos se procesan por orden de llegada y permite consultar el siguiente trabajo sin eliminarlo mediante `Peek()`.

## II. Colecciones de Búsqueda y Gestión de Datos

9.  **Gestión de Biblioteca Multiformato:** Diseña una estructura para manejar libros, DVDs y revistas.
    *   9.1. Implementa la gestión (añadir, buscar, eliminar, listar) utilizando **listas genéricas**.
    *   9.2. Implementa la misma gestión utilizando **mapas/diccionarios** para optimizar las búsquedas por clave.
10. **Analizador de Frecuencias (Diccionarios):** Desarrolla un contador de palabras que reciba un texto y utilice un `Dictionary<string, int>` para almacenar la frecuencia de cada palabra.
11. **Eliminación de Duplicados (Sets):** Crea un programa que reciba una lista masiva de datos (ej. IDs de usuario) y utilice un `HashSet<T>` para extraer rápidamente los elementos únicos.
12. **Operaciones de Conjuntos:** Dados dos grupos de datos (ej. habilidades de dos clases de personajes), utiliza `HashSet<T>` para realizar operaciones de **unión, intersección y diferencia**.
13. **Ranking de Puntuaciones:** Utiliza un `SortedSet<T>` para mantener una lista de las 10 mejores puntuaciones de un juego, asegurando que se mantengan ordenadas automáticamente tras cada inserción.
14. **Caché de Configuración:** Implementa un sistema de almacenamiento de configuración mediante un diccionario, asegurando que si una clave ya existe se actualice su valor y si no, se añada.

## III. Sistemas Complejos y Robustos

15. **Cine SpiderDAM (Sistema Integral):** Diseña un sistema de gestión de butacas (normales, VIP, ofertas) mediante una sala única (**Singleton**) parametrizada.
    *   15.1. **Configuración y Validación:** Implementa un objeto de configuración que valide nombres de administrador y correos electrónicos mediante **expresiones regulares**.
    *   15.2. **Gestión de Reservas:** Almacena las reservas en un repositorio siempre ordenado por filas y columnas.
    *   15.3. **Tickets y Ventas:** Genera tickets con identificador único y momento de compra, almacenándolos en un repositorio ordenado de más nuevo a más antiguo.
    *   15.4. **Informe Estadístico:** Desarrolla funciones que calculen porcentajes de ocupación y recaudación total basándose en los estados de las butacas.
16. **Repositorio Genérico de Datos:** Crea una clase genérica `Repositorio<T>` con restricciones (`where T : class, IEquatable<T>`) que permita gestionar cualquier entidad con métodos de búsqueda y filtrado.

## IV. Programación Funcional y Extensiones

17. **Calculadora Declarativa:** Diseña una calculadora que sustituya la lógica de control (`if/switch`) por un `Dictionary<string, Func<double, double, double>>` para ejecutar operaciones basadas en lambdas.
18. **Biblioteca de Operaciones Funcionales (Extension Methods):** Implementa sobre arrays o listas genéricas las siguientes funciones:
    *   18.1. **`Filter`:** Devuelve una colección con los elementos que cumplen un `Predicate<T>`.
    *   18.2. **`Map`:** Transforma una colección de tipo `T` a tipo `R` mediante un `Func<T, R>`.
    *   18.3. **`CountIf`:** Cuenta elementos que satisfacen una condición específica.
19. **Búsqueda Funcional Segura:** Crea un método de extensión `FindFirstOrNull` que devuelva el primer elemento que cumpla un predicado o el valor por defecto si la colección es vacía, manejando tipos genéricos anulables.
20. **Pipeline de Procesamiento:** Implementa una cadena de llamadas (encadenamiento) que filtre una lista de objetos (ej. Libros), los transforme a un string con su nombre y los imprima por consola mediante un método `ForEach`.
21. **Factory de Validadores:** Crea una función de orden superior que devuelva `Predicate<string>` personalizados para validar longitudes de texto o formatos específicos.
22. **Validador de Usuarios Genérico:** Crea un sistema que reciba un objeto usuario y una lista de `Predicate<T>` (ej. validar email, validar edad mínima) y devuelva si el objeto es válido tras aplicar todas las funciones.
23. **Comparador Dinámico de Objetos:** Implementa una clase que herede de `IComparer<T>` y permita inyectar un `Comparison<T>` mediante lambda para cambiar el criterio de ordenación en tiempo de ejecución.
24. **Sistema de Logs con Localización:** Crea un método de extensión para colecciones que formatee mensajes de registro incluyendo fecha y hora adaptadas a una `CultureInfo` específica.
25. **Analizador de Texto Alfabético:** Utiliza un `SortedDictionary<string, int>` para listar todas las palabras únicas de un archivo y su frecuencia, garantizando que el listado final esté siempre ordenado alfabéticamente.

## V. Estructuras Personalizadas y Gestión de Repositorios

26. **Simulación de Pila (Stack) mediante `List<T>`:** Implementa una clase genérica `MiPila<T>` que no utilice la colección `Stack<T>` de .NET, sino que gestione internamente una `List<T>`.
    *   **26.1.** Implementa los métodos `Push` (añadir al final) y `Pop` (eliminar y devolver el último elemento) asegurando la lógica LIFO (Last In, First Out).
    *   **26.2.** Controla las excepciones mediante robustez si se intenta hacer un `Pop` en una lista vacía.

27. **Simulación de Cola (Queue) mediante `List<T>`:** Crea una clase genérica `MiCola<T>` utilizando una `List<T>` como estructura base.
    *   **27.1.** Implementa `Enqueue` (añadir al final) y `Dequeue` (eliminar el primer elemento, índice 0) para cumplir la lógica FIFO (First In, First Out).
    *   **27.2.** Analiza y justifica el impacto en el rendimiento (complejidad Big O) de eliminar el primer elemento en una lista frente a una cola real.

28. **Servicio de Estudiantes Multirepositorio:** Implementa un servicio para gestionar objetos `Estudiante` (DNI, Nombre, Nota) utilizando tres enfoques de repositorio distintos y comparando su comportamiento:
    *   **28.1. Repositorio con `List<T>`:** Permite la búsqueda por DNI mediante un predicado y asegura manualmente que no existan duplicados antes de insertar. La salida debe ordenarse por DNI usando `Sort()` antes de mostrarse.
    *   **28.2. Repositorio con `Dictionary<string, Estudiante>`:** Utiliza el DNI como clave para garantizar la unicidad y obtener acceso O(1). Para la salida ordenada, utiliza un `SortedDictionary` o vuelca los datos a una lista para ordenarlos.
    *   **28.3. Repositorio con `HashSet<T>` o `SortedSet<T>`:** Implementa `IEquatable<Estudiante>` e `IComparable<Estudiante>` en la clase Estudiante para que la colección gestione automáticamente la ausencia de duplicados y el orden natural.

29. **Caché de Datos FIFO (Longitud 5):** Diseña un sistema de caché genérico que limite su almacenamiento a un máximo de 5 elementos.
    *   **29.1.** Utiliza una `Queue<T>` para implementar una política de reemplazo FIFO: cuando la caché esté llena y entre un nuevo elemento, el más antiguo debe ser expulsado automáticamente.

30. **Caché de Datos LRU (Least Recently Used):** Implementa una caché de longitud 5 que utilice la política del "elemento menos recientemente utilizado".
    *   **30.1.** Utiliza una combinación de `Dictionary<TKey, LinkedListNode<TValue>>` para acceso rápido y una `LinkedList<T>` para mantener el orden de uso.
    *   **30.2.** Cada vez que se acceda o inserte un elemento, este debe moverse al principio de la lista. Si se supera la capacidad de 5, se debe eliminar el nodo al final de la lista (el menos usado).

