namespace OperacionesFuncionalesLista.Collections.Lista;

/// <summary>
///     Operaciones Funcionales sobre la lista enalazada.
/// </summary>
public static class ListaOp {
    /// <summary>
    ///     Filtra los elementos de una lista según un predicado dado.
    /// </summary>
    /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
    /// <param name="lista">La lista a filtrar.</param>
    /// <param name="predicado">Función que define la condición de filtrado.</param>
    /// <returns>Una nueva lista que contiene solo los elementos que cumplen con el predicado.</returns>
    public static ILista<T> Where<T>(ILista<T> lista, Predicate<T> predicado) {
        var resultado = new Lista<T>();
        foreach (var elemento in lista)
            if (predicado(elemento))
                resultado.AgregarFinal(elemento);

        return resultado;
    }

    /// <summary>
    ///     Encuentra el primer elemento en una lista que cumple con un predicado dado.
    /// </summary>
    /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
    /// <param name="lista">La lista en la que buscar.</param>
    /// <param name="predicado">Función que define la condición de búsqueda.</param>
    /// <returns>El primer elemento que cumple con el predicado, o null si no lo encuentra.</returns>
    public static T? Find<T>(ILista<T> lista, Predicate<T> predicado) where T : class {
        foreach (var elemento in lista)
            if (predicado(elemento))
                return elemento;

        return null;
    }

    /// <summary>
    ///     Cuenta la cantidad de elementos en una lista que cumplen con un predicado dado.
    /// </summary>
    /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
    /// <param name="lista">La lista en la que buscar.</param>
    /// <param name="predicado">Función que define la condición de búsqueda.</param>
    /// <returns>La cantidad de elementos que cumplen con el predicado.</returns>
    public static int Count<T>(ILista<T> lista, Predicate<T> predicado) {
        var contador = 0;
        foreach (var elemento in lista)
            if (predicado(elemento))
                contador++;

        return contador;
    }

    /// <summary>
    ///     Mapea los elementos de una lista a un nuevo tipo utilizando una función de selección.
    /// </summary>
    /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
    /// <typeparam name="TK">Tipo de los elementos en la lista resultante.</typeparam>
    /// <param name="lista">La lista a mapear.</param>
    /// <param name="selector">Función que define la transformación de cada elemento.</param>
    /// <returns>Una nueva lista que contiene los resultados de la transformación.</returns>
    public static ILista<TK> Select<T, TK>(ILista<T> lista, Func<T, TK> selector) {
        var resultado = new Lista<TK>();
        foreach (var elemento in lista)
            resultado.AgregarFinal(selector(elemento));
        return resultado;
    }

    /// <summary>
    ///     Suma los valores enteros obtenidos al aplicar una función de selección a cada elemento de la lista.
    /// </summary>
    /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
    /// <param name="lista">La lista de valores.</param>
    /// <param name="selector">Función que define la transformación de cada elemento.</param>
    /// <returns>La suma de los valores obtenidos.</returns>
    public static int Sum<T>(ILista<T> lista, Func<T, int> selector) {
        var suma = 0;
        foreach (var elemento in lista)
            suma += selector(elemento);
        return suma;
    }

    /// <summary>
    ///     Reduce los elementos de una lista a un solo valor entero utilizando una función acumuladora
    /// </summary>
    /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
    /// <param name="lista">La lista de valores.</param>
    /// <param name="acumulador">Función que define cómo se acumulan los valores.</param>
    /// <param name="valorInicial">El valor inicial con el que se comienza la acumulación.</param>
    /// <returns>El resultado de la acumulación.</returns>
    public static int Aggregate<T>(ILista<T> lista, Func<int, T, int> acumulador, int valorInicial) {
        var resultado = valorInicial;
        foreach (var elemento in lista)
            resultado = acumulador(resultado, elemento);
        return resultado;
    }

    /// <summary>
    ///     Ejecuta una acción para cada elemento de la lista.
    /// </summary>
    /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
    /// <param name="lista">La lista de elementos.</param>
    /// <param name="accion">La acción que se ejecuta para cada elemento.</param>
    public static void ForEach<T>(ILista<T> lista, Action<T> accion) {
        foreach (var elemento in lista)
            accion(elemento);
    }

    /// <summary>
    ///     Comprueba si al menos un elemento de la lista cumple con un predicado.
    /// </summary>
    /// <param name="lista"> La lista de elementos.</param>
    /// <param name="predicado"> El predicado a evaluar.</param>
    /// <typeparam name="T"> Tipo de los elementos en la lista.</typeparam>
    /// <returns> True si al menos un elemento cumple con el predicado, false en caso contrario.</returns>
    public static bool Any<T>(ILista<T> lista, Predicate<T> predicado) {
        foreach (var elemento in lista)
            if (predicado(elemento))
                return true;
        return false;
    }

    /// <summary>
    ///     Comprueba si todos los elementos de la lista cumplen con un predicado.
    /// </summary>
    /// <param name="lista">La lista de elementos.</param>
    /// <param name="predicado">El predicado a evaluar.</param>
    /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
    /// <returns>True si todos los elementos cumplen con el predicado, false en caso contrario.</returns>
    public static bool All<T>(ILista<T> lista, Predicate<T> predicado) {
        foreach (var elemento in lista)
            if (!predicado(elemento))
                return false;
        return true;
    }
}