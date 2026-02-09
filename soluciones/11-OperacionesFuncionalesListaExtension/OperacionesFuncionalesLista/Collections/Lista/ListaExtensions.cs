namespace OperacionesFuncionalesLista.Collections.Lista;

/// <summary>
///     Operaciones Funcionales sobre la lista enalazada.
///     En base a funciones de Extension para listas enlazadas.
///     La clase debe ser estatica
/// </summary>
public static class ListaExtensions {
    // O pones this, como primer parametro, y se convierte en un metodo de extension
    // y debe ser static la clase y el metodo


    public static ILista<T> Filter<T>(this ILista<T> lista, Predicate<T> predicado) {
        var resultado = new Lista<T>();
        foreach (var elemento in lista)
            if (predicado(elemento))
                resultado.AgregarFinal(elemento);

        return resultado;
    }


    // o podemos usar extension y ya mete el this automaticamente
    // asi se usa como metodo de extension mas facil
    extension<T>(ILista<T> lista) where T : class {
        /// <summary>
        ///     Filtra los elementos de una lista según un predicado dado.
        /// </summary>
        /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
        /// <param name="predicado">Función que define la condición de filtrado.</param>
        /// <returns>Una nueva lista que contiene solo los elementos que cumplen con el predicado.</returns>
        public ILista<T> Where(Predicate<T> predicado) {
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
        /// <param name="predicado">Función que define la condición de búsqueda.</param>
        /// <returns>El primer elemento que cumple con el predicado, o null si no lo encuentra.</returns>
        public T? Find(Predicate<T> predicado) {
            foreach (var elemento in lista)
                if (predicado(elemento))
                    return elemento;

            return null;
        }

        /// <summary>
        ///     Cuenta la cantidad de elementos en una lista que cumplen con un predicado dado.
        /// </summary>
        /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
        /// <param name="predicado">Función que define la condición de búsqueda.</param>
        /// <returns>La cantidad de elementos que cumplen con el predicado.</returns>
        public int Count(Predicate<T> predicado) {
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
        /// <param name="selector">Función que define la transformación de cada elemento.</param>
        /// <returns>Una nueva lista que contiene los resultados de la transformación.</returns>
        public ILista<TK> Select<TK>(Func<T, TK> selector) {
            var resultado = new Lista<TK>();
            foreach (var elemento in lista)
                resultado.AgregarFinal(selector(elemento));
            return resultado;
        }

        /// <summary>
        ///     Suma los valores enteros obtenidos al aplicar una función de selección a cada elemento de la lista.
        /// </summary>
        /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
        /// <param name="selector">Función que define la transformación de cada elemento.</param>
        /// <returns>La suma de los valores obtenidos.</returns>
        public int Sum(Func<T, int> selector) {
            var suma = 0;
            foreach (var elemento in lista)
                suma += selector(elemento);
            return suma;
        }

        /// <summary>
        ///     Reduce los elementos de una lista a un solo valor entero utilizando una función acumuladora
        /// </summary>
        /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
        /// <param name="acumulador">Función que define cómo se acumulan los valores.</param>
        /// <param name="valorInicial">El valor inicial con el que se comienza la acumulación.</param>
        /// <returns>El resultado de la acumulación.</returns>
        public int Aggregate(Func<int, T, int> acumulador, int valorInicial) {
            var resultado = valorInicial;
            foreach (var elemento in lista)
                resultado = acumulador(resultado, elemento);
            return resultado;
        }

        /// <summary>
        ///     Ejecuta una acción para cada elemento de la lista.
        /// </summary>
        /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
        /// <param name="accion">La acción que se ejecuta para cada elemento.</param>
        public void ForEach(Action<T> accion) {
            foreach (var elemento in lista)
                accion(elemento);
        }

        /// <summary>
        ///     Comprueba si al menos un elemento de la lista cumple con un predicado.
        /// </summary>
        /// <param name="predicado"> El predicado a evaluar.</param>
        /// <typeparam name="T"> Tipo de los elementos en la lista.</typeparam>
        /// <returns> True si al menos un elemento cumple con el predicado, false en caso contrario.</returns>
        public bool Any(Predicate<T> predicado) {
            foreach (var elemento in lista)
                if (predicado(elemento))
                    return true;
            return false;
        }

        /// <summary>
        ///     Comprueba si todos los elementos de la lista cumplen con un predicado.
        /// </summary>
        /// <param name="predicado">El predicado a evaluar.</param>
        /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
        /// <returns>True si todos los elementos cumplen con el predicado, false en caso contrario.</returns>
        public bool All(Predicate<T> predicado) {
            foreach (var elemento in lista)
                if (!predicado(elemento))
                    return false;
            return true;
        }
    }
}