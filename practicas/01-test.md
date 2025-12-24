### Cuestionario de Programación en C# (Genéricos, Funcional y Colecciones)

- [Cuestionario de Programación en C# (Genéricos, Funcional y Colecciones)](#cuestionario-de-programación-en-c-genéricos-funcional-y-colecciones)
  - [Bloque 1: Introducción y Genéricos Básicos](#bloque-1-introducción-y-genéricos-básicos)
  - [Bloque 2: Programación Funcional](#bloque-2-programación-funcional)
  - [Bloque 3: Operadores y Comparación](#bloque-3-operadores-y-comparación)
  - [Bloque 4: Colecciones Estándar](#bloque-4-colecciones-estándar)
  - [Bloque 5: Colecciones Avanzadas y Especializadas](#bloque-5-colecciones-avanzadas-y-especializadas)
  - [Bloque 6: Formateo, Localización y Buenas Prácticas](#bloque-6-formateo-localización-y-buenas-prácticas)


#### Bloque 1: Introducción y Genéricos Básicos
1. **¿Qué permiten los tipos genéricos en C#?**
   a) Escribir código que solo funciona con tipos enteros.
   b) Escribir código reutilizable y seguro en cuanto a tipos sin duplicación.
   c) Eliminar la necesidad de usar clases.
   d) Forzar al sistema a usar solo tipos `object`.

2. **¿En qué versión de C# se introdujeron los genéricos?**
   a) C# 1.0
   b) C# 2.0
   c) C# 3.0
   d) C# 5.0

3. **¿Cuál es una ventaja fundamental de los genéricos en términos de rendimiento?**
   a) Aumentan el uso de memoria en el stack.
   b) Evitan el proceso de boxing y unboxing de tipos de valor.
   c) Permiten que el código se ejecute sin ser compilado.
   d) Reducen el número de clases en el ensamblado final.

4. **¿Qué es el "boxing"?**
   a) Convertir una clase en una interfaz.
   b) Eliminar un objeto del heap.
   c) Convertir un tipo de valor en un objeto de tipo referencia.
   d) Empaquetar un archivo de código en un NuGet.

5. **¿Cuál es la convención estándar para nombrar un parámetro de tipo único?**
   a) Type
   b) T
   c) TType
   d) U

6. **¿Qué garantiza el "Type-safety" en los genéricos?**
   a) Que los errores de tipo se detecten en tiempo de compilación.
   b) Que no se puedan usar tipos de referencia.
   c) Que todos los tipos sean convertidos a `dynamic`.
   d) Que la memoria sea liberada automáticamente.

7. **¿Cómo se definen múltiples parámetros de tipo en una clase genérica?**
   a) Usando varios bloques `< >`.
   b) Separando los nombres de tipo con puntos.
   c) Separando los parámetros con comas dentro de los corchetes angulares `<T, U>`.
   d) No es posible tener más de un parámetro de tipo.

8. **¿Qué permite la inferencia de tipos en los métodos genéricos?**
   a) Que el compilador deduzca el tipo a partir de los argumentos pasados.
   b) Que el programador no tenga que escribir el nombre del método.
   c) Que los métodos se ejecuten más rápido.
   d) Que el tipo de retorno sea siempre `void`.

9. **¿Puede existir un método genérico dentro de una clase que no es genérica?**
   a) No, solo las clases genéricas pueden tener métodos genéricos.
   b) Sí, los métodos genéricos pueden ser independientes de la clase.
   c) Solo si el método es privado.
   d) Solo si la clase es estática.

10. **¿Cuál es el comportamiento por defecto de los genéricos en C# respecto a la varianza?**
    a) Covarianza
    b) Contravarianza
    c) Invarianza
    d) Bivarianza

11. **¿Qué palabra clave se utiliza para declarar un parámetro de tipo como covariante?**
    a) in
    b) out
    c) ref
    d) const

12. **¿Qué limitación tiene un tipo genérico declarado como `out T` (covariante)?**
    a) Solo puede ser usado como parámetro de entrada.
    b) Solo puede ser producido o devuelto como salida.
    c) No puede ser usado en interfaces.
    d) Debe ser un tipo de valor.

13. **¿Para qué sirve la palabra clave `in` en la contravarianza?**
    a) Para indicar que el tipo solo se devuelve.
    b) Para indicar que el tipo solo se consume o acepta como entrada.
    c) Para permitir el uso de tipos `null`.
    d) Para forzar la herencia múltiple.

14. **¿Cuál es un ejemplo típico de interfaz covariante en .NET?**
    a) `IList<T>`
    b) `IComparer<T>`
    c) `IEnumerable<T>`
    d) `Action<T>`

15. **¿Qué es la invarianza en genéricos?**
    a) Cuando `Contenedor<Perro>` puede usarse como `Contenedor<Animal>`.
    b) Cuando no existe relación entre `Contenedor<Perro>` y `Contenedor<Animal>`.
    c) Cuando `Contenedor<Animal>` puede usarse como `Contenedor<Perro>`.
    d) Cuando el tipo genérico cambia en tiempo de ejecución.

16. **¿Qué hace la restricción `where T : class`?**
    a) Obliga a que T sea un tipo de valor.
    b) Restringe T a tipos de referencia.
    c) Permite que T sea cualquier cosa.
    d) Obliga a que T herede de `System.ValueType`.

17. **¿Qué indica la restricción `where T : new()`?**
    a) Que el tipo debe ser una clase nueva.
    b) Que el tipo debe tener un constructor público sin parámetros.
    c) Que el tipo debe ser estático.
    d) Que el tipo no puede ser instanciado.

18. **¿Cuál es el orden correcto si se combinan múltiples restricciones?**
    a) `new()`, interfaces, clase base.
    b) Clase base, interfaces, `new()`.
    c) Interfaces, `struct`, `new()`.
    d) No importa el orden.

19. **¿Qué restringe la opción `where T : notnull`?**
    a) Tipos que no pueden ser heredados.
    b) Tipos de valor únicamente.
    c) Tipos no anulables (tanto de valor como de referencia).
    d) Tipos que no tienen campos privados.

20. **¿Con qué tipos funciona exclusivamente `Nullable<T>`?**
    a) Tipos de referencia.
    b) Tipos de valor (struct).
    c) Solo con el tipo `int`.
    d) Con interfaces genéricas.

#### Bloque 2: Programación Funcional
21. **¿Qué significa que las funciones sean "ciudadanos de primera clase"?**
    a) Que son más rápidas que las clases.
    b) Que pueden asignarse a variables, pasarse como argumentos y devolverse como resultados.
    c) Que solo pueden definirse en el método `Main`.
    d) Que no pueden ser modificadas después de la compilación.

22. **¿Cuál es un principio clave de la programación funcional que evita modificar valores existentes?**
    a) Encapsulamiento
    b) Inmutabilidad
    c) Herencia
    d) Polimorfismo

23. **¿Qué es una función pura?**
    a) Una función que no tiene parámetros.
    b) Una función que siempre devuelve el mismo resultado para los mismos argumentos y no tiene efectos secundarios.
    c) Una función que solo usa tipos primitivos.
    d) Una función definida dentro de un `record`.

24. **¿Qué característica de C# 9+ simplifica la creación de objetos inmutables?**
    a) Delegates
    b) Lambdas
    c) Records
    d) Extension Methods

25. **¿Qué es la transparencia referencial?**
    a) Poder ver el código fuente de una función.
    b) La capacidad de reemplazar una expresión por su valor sin cambiar el comportamiento del programa.
    c) El uso de variables globales en funciones puras.
    d) La herencia de interfaces en clases abstractas.

26. **¿Qué es un delegate en C#?**
    a) Una clase que gestiona la memoria.
    b) Un tipo que representa referencias a métodos con una firma específica.
    c) Un método que no tiene cuerpo.
    d) Una palabra clave para ciclos infinitos.

27. **¿Qué representa el delegate genérico `Action<T>`?**
    a) Un método que retorna un valor booleano.
    b) Un método que recibe parámetros y no retorna nada (void).
    c) Un método que solo acepta strings.
    d) Un método que debe ser ejecutado en un hilo separado.

28. **¿Cuál es la diferencia principal entre `Action` y `Func`?**
    a) `Action` siempre retorna un valor, `Func` no.
    b) `Action` es para métodos void, `Func` siempre retorna un valor.
    c) `Action` solo acepta un parámetro, `Func` acepta hasta 16.
    d) No hay diferencia, son sinónimos.

29. **¿Qué hace el delegate `Predicate<T>`?**
    a) Compara dos objetos y devuelve un entero.
    b) Recibe un parámetro de tipo T y retorna un `bool`.
    c) Transforma un objeto en otro tipo.
    d) Ejecuta una acción sobre una lista.

30. **¿Cómo se comporta un "Multicast Delegate" que retorna un valor?**
    a) Retorna una lista con todos los valores.
    b) Retorna el valor del primer método ejecutado.
    c) Solo se obtiene el valor del último método ejecutado.
    d) Lanza una excepción si hay más de un método.

31. **¿Qué es una expresión lambda?**
    a) Una forma de declarar variables globales.
    b) Una forma concisa de escribir funciones anónimas.
    c) Un operador para realizar divisiones.
    d) Una clase que no puede ser instanciada.

32. **En una expresión lambda `(x, y) => x + y`, ¿qué representa el símbolo `=>`?**
    a) Mayor o igual que.
    b) Un puntero a memoria.
    c) El operador lambda (lee como "va hacia").
    d) Una asignación de valor.

33. **¿Cuándo son obligatorios los paréntesis en los parámetros de una lambda?**
    a) Siempre son obligatorios.
    b) Cuando no hay parámetros o hay dos o más.
    c) Solo cuando los parámetros son de tipo `int`.
    d) Nunca son obligatorios.

34. **¿Qué es un "closure" en el contexto de las lambdas?**
    a) El cierre del programa al finalizar la ejecución.
    b) La capacidad de una lambda de capturar variables del ámbito externo.
    c) Una función que no tiene parámetros de salida.
    d) El uso de la palabra clave `close` en una interfaz.

35. **¿Qué precaución se debe tener al capturar variables de bucle en una lambda?**
    a) Las lambdas no pueden usarse en bucles.
    b) Pueden causar comportamientos inesperados si la variable cambia antes de la ejecución de la lambda.
    c) Siempre causan un error de compilación.
    d) Consumen toda la memoria RAM disponible.

36. **¿Qué define a una función de orden superior?**
    a) Una función que tiene más de 100 líneas de código.
    b) Una función que recibe otras funciones como parámetros o devuelve funciones.
    c) Una función con prioridad de ejecución en el sistema operativo.
    d) Una función estática dentro de `Program.cs`.

37. **¿Qué operación funcional transforma cada elemento de un array en uno nuevo?**
    a) Filter (Where)
    b) Reduce (Aggregate)
    c) Map (Select)
    d) Count

38. **¿Qué hace la operación `Filter` (o `Where`)?**
    a) Suma todos los elementos.
    b) Crea un nuevo conjunto con los elementos que cumplen una condición.
    c) Ordena el array de forma ascendente.
    d) Elimina el primer elemento del array.

39. **¿Cómo se identifica un método de extensión en C#?**
    a) Por el uso de la palabra clave `extend`.
    b) Por el uso del modificador `this` antes del primer parámetro.
    c) Porque debe estar en una clase privada.
    d) Porque siempre retorna un tipo genérico.

40. **¿Cuál es un requisito para las clases que contienen métodos de extensión?**
    a) Deben ser clases genéricas.
    b) Deben ser clases estáticas.
    c) Deben heredar de `System.Extension`.
    d) Deben tener un constructor público.

#### Bloque 3: Operadores y Comparación
41. **¿Qué operador NO se puede sobrecargar en C#?**
    a) +
    b) ==
    c) =
    d) !

42. **¿Qué modificadores debe tener obligatoriamente la sobrecarga de un operador?**
    a) private static
    b) public static
    c) internal virtual
    d) public abstract

43. **¿Qué requisito existe al sobrecargar el operador `==`?**
    a) Se debe sobrecargar también el operador `!=`.
    b) El método debe ser asíncrono.
    c) Solo puede usarse con tipos `struct`.
    d) Debe retornar un entero.

44. **¿Qué diferencia a un `implicit operator` de un `explicit operator`?**
    a) El implícito es más lento.
    b) El implícito no requiere un cast manual y se usa cuando la conversión es siempre segura.
    c) El explícito siempre es automático.
    d) El explícito solo funciona con strings.

45. **¿Qué interfaz define el "orden natural" de un tipo?**
    a) `IComparer<T>`
    b) `IEquatable<T>`
    c) `IComparable<T>`
    d) `ICloneable`

46. **¿Qué valor debe retornar `CompareTo` si el objeto actual es "menor" que el argumento?**
    a) 0
    b) Un número positivo.
    c) Un número negativo.
    d) 1

47. **¿Para qué sirve la interfaz `IComparer<T>`?**
    a) Para definir el orden natural por defecto.
    b) Para crear comparadores personalizados u órdenes alternativos.
    c) Para comparar si dos objetos son la misma instancia.
    d) Para serializar objetos.

48. **¿Cuál es la regla fundamental al implementar `Equals`?**
    a) Siempre debe retornar `true`.
    b) Se debe sobrescribir también `GetHashCode()`.
    c) No puede usarse con genéricos.
    d) Solo puede comparar números.

49. **¿Qué método de `Array` se usa para buscar un elemento en un array ordenado?**
    a) `Array.FindAll`
    b) `Array.BinarySearch`
    c) `Array.IndexOf`
    d) `Array.Sort`

50. **¿Cuál es la complejidad de la búsqueda binaria?**
    a) O(n)
    b) O(n log n)
    c) O(log n)
    d) O(1)

#### Bloque 4: Colecciones Estándar
51. **¿Cuál es la colección más usada en C# para manejar listas dinámicas?**
    a) `HashSet<T>`
    b) `Queue<T>`
    c) `List<T>`
    d) `ArrayList`

52. **¿Qué sucede con el tamaño de una `List<T>` cuando se agregan elementos?**
    a) Es fijo y lanza una excepción si se supera.
    b) Crece automáticamente de forma dinámica.
    c) Se debe redimensionar manualmente con `ReDim`.
    d) Solo puede crecer hasta 1000 elementos.

53. **¿Cuál es la complejidad del acceso por índice en una `List<T>`?**
    a) O(n)
    b) O(log n)
    c) O(1)
    d) O(n²)

54. **¿Qué propiedad de `List<T>` indica el número real de elementos contenidos?**
    a) `Capacity`
    b) `Length`
    c) `Count`
    d) `Size`

55. **¿Qué diferencia a `Capacity` de `Count` en una lista?**
    a) No hay diferencia.
    b) `Count` es el número de elementos; `Capacity` es el espacio reservado antes de redimensionar.
    c) `Capacity` es siempre menor que `Count`.
    d) `Count` es para arrays; `Capacity` es para listas.

56. **¿Qué estructura de datos utiliza un `Dictionary<TKey, TValue>`?**
    a) Lista enlazada.
    b) Árbol binario.
    c) Pares clave-valor.
    d) Pila LIFO.

57. **¿Cómo debe ser la clave en un `Dictionary`?**
    a) Puede estar duplicada.
    b) Debe ser única.
    c) Siempre debe ser un `int`.
    d) Puede ser `null`.

58. **¿Cuál es la complejidad promedio de búsqueda por clave en un `Dictionary`?**
    a) O(1)
    b) O(n)
    c) O(log n)
    d) O(n log n)

59. **¿Qué colección garantiza que todos sus elementos sean únicos?**
    a) `List<T>`
    b) `HashSet<T>`
    c) `Stack<T>`
    d) `LinkedList<T>`

60. **¿Qué operaciones especiales ofrece `HashSet<T>`?**
    a) Solo agregar y quitar.
    b) Operaciones de conjuntos (Unión, Intersección, Diferencia).
    c) Acceso por índice.
    d) Ordenación automática por burbuja.

61. **¿Qué significa el acrónimo FIFO en una `Queue<T>`?**
    a) Final In, Final Out.
    b) First In, First Out.
    c) Fast In, Fast Out.
    d) First In, Forever Out.

62. **¿Qué método se usa para agregar un elemento al final de una `Queue<T>`?**
    a) `Push`
    b) `Add`
    c) `Enqueue`
    d) `Insert`

63. **¿Qué significa LIFO en un `Stack<T>`?**
    a) Last In, First Out.
    b) Long In, Fast Out.
    c) List In, Folder Out.
    d) Low In, First Out.

64. **¿Qué método elimina y devuelve el elemento superior de un `Stack<T>`?**
    a) `Peek`
    b) `Pop`
    c) `Dequeue`
    d) `RemoveTop`

65. **¿Qué permite hacer el método `Peek` en colas y pilas?**
    a) Eliminar el primer elemento.
    b) Ver el elemento sin quitarlo de la colección.
    c) Limpiar toda la colección.
    d) Buscar un elemento específico.

66. **¿Cuál es la ventaja principal de una `LinkedList<T>` frente a una `List<T>`?**
    a) Acceso por índice más rápido.
    b) Inserción y eliminación en cualquier posición en O(1) (si se tiene el nodo).
    c) Menor uso de memoria.
    d) Es más fácil de usar con `foreach`.

67. **¿Qué desventaja tiene `LinkedList<T>`?**
    a) No permite duplicados.
    b) Acceso por índice es lento (O(n)).
    c) No es genérica.
    d) No permite hilos.

68. **¿Cuál es la diferencia entre `SortedDictionary` y `Dictionary`?**
    a) `SortedDictionary` es más rápido.
    b) `SortedDictionary` mantiene las claves ordenadas.
    c) `SortedDictionary` permite claves duplicadas.
    d) `SortedDictionary` no es una colección genérica.

69. **¿En qué namespace se encuentran las colecciones genéricas estándar?**
    a) `System.Collections`
    b) `System.Collections.Generic`
    c) `System.Linq`
    d) `System.Data`

70. **¿Qué interfaz es la base de todas las colecciones y permite iterar con `foreach`?**
    a) `IList<T>`
    b) `ICollection<T>`
    c) `IEnumerable<T>`
    d) `IDisposable`

#### Bloque 5: Colecciones Avanzadas y Especializadas
71. **¿Por qué se deben evitar las colecciones del namespace `System.Collections` (ArrayList, Hashtable)?**
    a) Porque no son compatibles con C#.
    b) Porque no son seguras en cuanto a tipos (Type-safe) y causan boxing/unboxing.
    c) Porque han sido eliminadas de .NET.
    d) Porque solo funcionan en Windows XP.

72. **¿Qué caracteriza a una colección de "Solo Lectura" (Read-Only)?**
    a) Los datos se borran al leerlos.
    b) Es una vista que no permite modificar la colección original a través de ella.
    c) Los datos están cifrados.
    d) Solo se puede usar con archivos de texto.

73. **¿Qué sucede si la colección subyacente de una `ReadOnlyCollection` cambia?**
    a) La vista de solo lectura lanza una excepción.
    b) Los cambios se reflejan en la vista de solo lectura.
    c) La vista se queda con los datos antiguos para siempre.
    d) El programa se bloquea.

74. **¿Cuál es la diferencia principal de las Colecciones Inmutables (`System.Collections.Immutable`)?**
    a) No se pueden leer.
    b) Cualquier operación de "modificación" devuelve una nueva instancia con el cambio.
    c) Son más rápidas que las listas normales.
    d) Se almacenan solo en el disco duro.

75. **¿Cuál es una ventaja de las colecciones inmutables en entornos multi-hilo?**
    a) Son thread-safe por naturaleza ya que nunca cambian.
    b) Usan bloqueos automáticos (locks).
    c) Son más pequeñas en memoria.
    d) Permiten que varios hilos escriban al mismo tiempo en el mismo objeto.

76. **¿Qué patrón se recomienda para crear colecciones inmutables de forma eficiente en lote?**
    a) Singleton
    b) Factory
    c) Builder Pattern
    d) Observer

77. **¿Para qué sirven las colecciones concurrentes (`System.Collections.Concurrent`)?**
    a) Para juegos con mucha concurrencia de jugadores.
    b) Para ser usadas por múltiples hilos simultáneamente sin necesidad de bloqueos manuales.
    c) Para ejecutar código en la GPU.
    d) Para bases de datos en tiempo real.

78. **¿Qué colección concurrente es ideal para escenarios "productor-consumidor" desordenados?**
    a) `ConcurrentDictionary`
    b) `ConcurrentBag`
    c) `ConcurrentStack`
    d) `List`

79. **¿Qué método especial ofrece `ConcurrentDictionary` para agregar o actualizar de forma atómica?**
    a) `AddOrUpdate`
    b) `InsertOrChange`
    c) `Put`
    d) `ForceAdd`

80. **¿Qué hace `BlockingCollection<T>`?**
    a) Bloquea el acceso a internet.
    b) Proporciona capacidades de bloqueo y límites para patrones productor-consumidor.
    c) Detiene la ejecución del procesador.
    d) Es una lista que no permite elementos nulos.

81. **¿Qué interfaz añade la capacidad de acceso por índice a una colección?**
    a) `IEnumerable<T>`
    b) `ICollection<T>`
    c) `IList<T>`
    d) `ISet<T>`

82. **¿Qué colección usarías para notificar cambios a la interfaz de usuario (WPF/MAUI)?**
    a) `List<T>`
    b) `ObservableCollection<T>`
    c) `ConcurrentQueue<T>`
    d) `ImmutableArray<T>`

83. **¿Cuál es la complejidad de búsqueda en un `SortedSet<T>`?**
    a) O(1)
    b) O(n)
    c) O(log n)
    d) O(1) amortizado

84. **¿Qué colección es un híbrido que permite acceso por índice y por clave de forma ordenada?**
    a) `SortedList<TKey, TValue>`
    b) `Dictionary<TKey, TValue>`
    c) `HashSet<T>`
    d) `LinkedList<T>`

85. **En el algoritmo de selección de colecciones, ¿qué se recomienda si necesitas elementos únicos y ordenados?**
    a) `HashSet<T>`
    b) `SortedSet<T>`
    c) `List<T>` + `Sort()`
    d) `Queue<T>`

86. **¿Qué escenario es ideal para una `Stack<T>`?**
    a) Cola de impresión.
    b) Historial de navegación (atrás/adelante).
    c) Carrito de la compra.
    d) Diccionario de traducción.

87. **¿Qué colección es preferible para eliminar duplicados de una lista de forma eficiente?**
    a) `Dictionary`
    b) `HashSet`
    c) `LinkedList`
    d) `ArrayList`

88. **¿Qué recomendación de rendimiento es importante al crear listas o diccionarios muy grandes?**
    a) No usar genéricos.
    b) Especificar la capacidad inicial si es conocida.
    c) Usar siempre tipos `object`.
    d) Reiniciar el ordenador antes de ejecutar.

89. **¿Por qué `Array.Sort` en C# es considerado "inestable"?**
    a) Porque a veces falla y lanza excepciones.
    b) Porque no garantiza mantener el orden relativo de elementos iguales.
    c) Porque solo funciona con números.
    d) Porque cambia el tamaño del array.

90. **¿Cuál es el algoritmo que usa .NET para `Array.Sort`?**
    a) BubbleSort
    b) IntroSort (QuickSort + HeapSort)
    c) MergeSort
    d) SelectionSort

#### Bloque 6: Formateo, Localización y Buenas Prácticas
91. **¿Qué clase representa la información de una cultura específica (idioma/país)?**
    a) `CultureManager`
    b) `CultureInfo`
    c) `Localizer`
    d) `RegionFormat`

92. **¿Para qué sirve la localización en una aplicación?**
    a) Para encontrar la IP del usuario.
    b) Para adaptar formatos de fechas, números y monedas a diferentes regiones.
    c) Para traducir el código fuente automáticamente.
    d) Para usar GPS.

93. **¿Cuál es una buena práctica respecto a exponer colecciones en una clase?**
    a) Exponer siempre `List<T>` públicamente.
    b) Exponer colecciones como solo lectura (`IReadOnlyList`, etc.).
    c) No usar colecciones en clases.
    d) Hacer que todas las colecciones sean estáticas.

94. **¿Qué se debe evitar al usar lambdas?**
    a) Usar lambdas de una sola línea.
    b) Crear lambdas excesivamente complejas (es mejor extraer a métodos).
    c) Usarlas con delegates predefinidos.
    d) Usarlas en LINQ.

95. **¿Qué se debe hacer siempre al implementar `IEquatable<T>`?**
    a) Implementar también `IComparable`.
    b) Sobrescribir `GetHashCode()` y `Object.Equals()`.
    c) Hacer que la clase sea inmutable.
    d) Usar solo tipos de referencia.

96. **¿Cuándo se deben usar restricciones en parámetros de tipo genérico?**
    a) Nunca, limitan la potencia de los genéricos.
    b) Siempre que necesitemos acceder a miembros específicos del tipo o asegurar ciertas capacidades.
    c) Solo si la clase es interna.
    d) Solo para tipos `string`.

97. **¿Qué paradigma de programación trata las funciones como valores y evita el estado mutable?**
    a) Imperativo
    b) Orientado a Objetos
    c) Funcional
    d) Estructurado

98. **¿Qué operador se usa para la coalescencia nula en tipos anulables?**
    a) `?`
    b) `??`
    c) `?.`
    d) `!!`

99. **¿Qué sucede si intentas añadir una clave duplicada a un `Dictionary` usando el método `Add`?**
    a) Se sobrescribe el valor anterior.
    b) Se lanza una excepción.
    c) No pasa nada, se ignora.
    d) El diccionario se limpia.

100. **¿Cuál es el objetivo final de combinar genéricos, programación funcional y colecciones?**
     a) Hacer el código más difícil de leer.
     b) Escribir código más expresivo, seguro, reutilizable y eficiente (declarativo).
     c) Obligar al uso de punteros.
     d) Evitar el uso de .NET.

