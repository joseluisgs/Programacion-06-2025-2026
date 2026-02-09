namespace GestionAcademica.Collections.Lista;

/// <summary>
///     Contrato para una estructura de datos de Lista Enlazada Genérica.
///     ¿Qué es una lista enlazada?
///     Una lista enlazada es una colección de elementos donde cada elemento (nodo) contiene un valor y una referencia al
///     siguiente nodo en la secuencia.
///     Esta estructura permite una inserción y eliminación eficiente de elementos en cualquier posición de la lista.
///     V1-> V2-> V3-> null
///     Hereda de <see cref="IEnumerable{T}" /> para permitir la iteración y el uso de LINQ.
/// </summary>
/// <typeparam name="T">Tipo de los elementos almacenados en la lista.</typeparam>
public interface ILista<T> : IEnumerable<T> {
    /// <summary>
    ///     Obtiene el número de elementos actualmente almacenados en la lista.
    /// </summary>
    /// <returns>El conteo de elementos en la lista.</returns>
    int Size { get; }

    /// <summary>
    ///     Inserta un nuevo elemento al principio de la lista.
    /// </summary>
    /// <param name="item">El elemento a añadir.</param>
    void AddFirst(T item);

    /// <summary>
    ///     Añade un nuevo elemento al final de la lista.
    /// </summary>
    /// <param name="item">El elemento a añadir.</param>
    void AddLast(T item);

    /// <summary>
    ///     Inserta un elemento en una posición específica de la lista.
    /// </summary>
    /// <param name="index">Posición (basada en cero) donde se insertará el elemento.</param>
    /// <param name="item">El elemento a insertar.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Se lanza si el índice es menor que cero o mayor que el tamaño de la
    ///     lista.
    /// </exception>
    void AddAt(int index, T item);

    /// <summary>
    ///     Elimina el primer elemento de la lista.
    /// </summary>
    /// <exception cref="InvalidOperationException">Se lanza si la lista está vacía.</exception>
    void RemoveFirst();

    /// <summary>
    ///     Elimina el último elemento de la lista.
    /// </summary>
    /// <exception cref="InvalidOperationException">Se lanza si la lista está vacía.</exception>
    void RemoveLast();

    /// <summary>
    ///     Elimina el elemento situado en una posición específica.
    /// </summary>
    /// <param name="index">Índice del elemento a eliminar.</param>
    /// <exception cref="ArgumentOutOfRangeException">Se lanza si el índice está fuera de los límites de la lista.</exception>
    void RemoveAt(int index);

    /// <summary>
    ///     Obtiene el primer elemento de la lista sin eliminarlo.
    /// </summary>
    /// <returns>El valor del primer elemento.</returns>
    /// <exception cref="InvalidOperationException">Se lanza si la lista está vacía.</exception>
    T GetFirst();

    /// <summary>
    ///     Obtiene el último elemento de la lista sin eliminarlo.
    /// </summary>
    /// <returns>El valor del último elemento.</returns>
    /// <exception cref="InvalidOperationException">Se lanza si la lista está vacía.</exception>
    T GetLast();

    /// <summary>
    ///     Recupera el elemento situado en el índice especificado.
    /// </summary>
    /// <param name="index">Posición del elemento a recuperar.</param>
    /// <returns>El valor del elemento en dicha posición.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Se lanza si el índice está fuera de los límites.</exception>
    T GetAt(int index);

    /// <summary>
    ///     Determina si un elemento específico existe dentro de la lista.
    /// </summary>
    /// <param name="item">El elemento a buscar.</param>
    /// <returns><c>true</c> si el elemento se encuentra en la lista; de lo contrario, <c>false</c>.</returns>
    bool Contains(T item);

    /// <summary>
    ///     Indica si la lista carece de elementos.
    /// </summary>
    /// <returns><c>true</c> si la lista está vacía; de lo contrario, <c>false</c>.</returns>
    bool IsEmpty();

    /// <summary>
    ///     Elimina todos los elementos de la lista, dejándola vacía.
    /// </summary>
    void Clear();

    /// <summary>
    ///     Muestra el contenido de la lista por la consola de forma visual.
    /// </summary>
    void Display();

    /// <summary>
    ///     Busca un elemento y devuelve su posición en la lista.
    /// </summary>
    /// <param name="item">El elemento a localizar.</param>
    /// <returns>El índice del elemento si se encuentra; de lo contrario, -1.</returns>
    int IndexOf(T item);
}