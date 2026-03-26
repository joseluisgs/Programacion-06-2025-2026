using System.Numerics;

namespace GestionAcademica.Collections.Lista;

/// <summary>
///     Operaciones Funcionales sobre la lista enlazada.
///     En base a funciones de extensión para listas enlazadas.
/// </summary>
public static class ListaExtensions {
    /// <summary>
    ///     Filtra los elementos de una lista según un predicado dado (Versión estática clásica).
    /// </summary>
    /// <typeparam name="T">Tipo de los elementos en la lista.</typeparam>
    /// <param name="lista">La lista sobre la que se aplica el filtro.</param>
    /// <param name="predicado">Función que define la condición de filtrado.</param>
    /// <returns>Una nueva lista con los elementos que cumplen la condición.</returns>
    public static ILista<T> Filter<T>(this ILista<T> lista, Predicate<T> predicado) {
        var resultado = new Lista<T>();
        foreach (var elemento in lista)
            if (predicado(elemento))
                resultado.AddLast(elemento);

        return resultado;
    }

    extension<T>(ILista<T> lista) where T : class {
        /// <summary>
        ///     Filtra los elementos de una lista según un predicado dado.
        /// </summary>
        /// <param name="predicado">Función que define la condición de filtrado (lambda).</param>
        /// <returns>Una nueva lista que contiene solo los elementos que cumplen con el predicado.</returns>
        public ILista<T> Where(Predicate<T> predicado) {
            var resultado = new Lista<T>();
            foreach (var elemento in lista)
                if (predicado(elemento))
                    resultado.AddLast(elemento);

            return resultado;
        }

        /// <summary>
        ///     Encuentra el primer elemento en una lista que cumple con un predicado dado.
        /// </summary>
        /// <param name="predicado">Condición de búsqueda.</param>
        /// <returns>El primer elemento que cumple la condición, o null si no se encuentra ninguno.</returns>
        public T? Find(Predicate<T> predicado) {
            foreach (var elemento in lista)
                if (predicado(elemento))
                    return elemento;

            return null;
        }

        /// <summary>
        ///     Cuenta la cantidad de elementos en una lista que cumplen con un predicado dado.
        /// </summary>
        /// <param name="predicado">Condición para contabilizar elementos.</param>
        /// <returns>El número de elementos que satisfacen el predicado.</returns>
        public int Count(Predicate<T> predicado) {
            /*var contador = 0;
            foreach (var elemento in lista)
                if (predicado(elemento))
                    contador++;

            return contador;*/
            return lista.Where(predicado).Size;
        }

        /// <summary>
        ///     Mapea los elementos de una lista a un nuevo tipo utilizando una función de selección.
        /// </summary>
        /// <typeparam name="TK">Tipo de la lista resultante.</typeparam>
        /// <param name="selector">Función de transformación aplicada a cada elemento.</param>
        /// <returns>Una nueva lista con los elementos transformados al tipo <typeparamref name="TK" />.</returns>
        public ILista<TK> Select<TK>(Func<T, TK> selector) {
            var resultado = new Lista<TK>();
            foreach (var elemento in lista)
                resultado.AddLast(selector(elemento));
            return resultado;
        }

        /// <summary>
        ///     Suma los valores numéricos obtenidos al aplicar una función de selección a cada elemento de la lista.
        ///     Utiliza <b>Generic Math</b> (Matemáticas Genéricas de .NET) para soportar cualquier tipo numérico
        ///     (int, double, decimal, etc.) de forma nativa.
        /// </summary>
        /// <typeparam name="TResult">Tipo numérico resultante. Debe implementar <see cref="System.Numerics.INumber{TResult}" />.</typeparam>
        /// <param name="selector">
        ///     Expresión lambda que extrae el valor numérico. Evita la necesidad de castings manuales en el
        ///     consumidor.
        /// </param>
        /// <returns>La suma total preservando la precisión del tipo de datos original.</returns>
        public TResult Sum<TResult>(Func<T, TResult> selector) where TResult : INumber<TResult> {
            var suma = TResult.Zero;
            foreach (var elemento in lista)
                suma += selector(elemento);
            return suma;
        }

        /// <summary>
        ///     Reduce los elementos de una lista a un solo valor numérico utilizando una función acumuladora.
        ///     Utiliza <b>Generic Math</b> para operar con cualquier tipo numérico (int, double, etc.) de forma eficiente.
        /// </summary>
        /// <typeparam name="TAccumulate">Tipo numérico del valor acumulado (debe implementar <see cref="INumber{TSelf}" />).</typeparam>
        /// <param name="acumulador">Función que define la lógica de acumulación.</param>
        /// <param name="valorInicial">Semilla o valor base numérico para comenzar la reducción.</param>
        /// <returns>El resultado final del proceso de agregación numérica.</returns>
        public TAccumulate Aggregate<TAccumulate>(Func<TAccumulate, T, TAccumulate> acumulador,
            TAccumulate valorInicial) where TAccumulate : INumber<TAccumulate> {
            var resultado = valorInicial;
            foreach (var elemento in lista)
                resultado = acumulador(resultado, elemento);
            return resultado;
        }

        /// <summary>
        ///     Ejecuta una acción para cada elemento de la lista.
        /// </summary>
        /// <param name="accion">La acción (procedimiento) a ejecutar por cada elemento.</param>
        public void ForEach(Action<T> accion) {
            foreach (var elemento in lista)
                accion(elemento);
        }

        /// <summary>
        ///     Comprueba si al menos un elemento de la lista cumple con un predicado.
        /// </summary>
        /// <param name="predicado">Condición a verificar.</param>
        /// <returns><c>true</c> si algún elemento cumple la condición; de lo contrario, <c>false</c>.</returns>
        public bool Any(Predicate<T> predicado) {
            foreach (var elemento in lista)
                if (predicado(elemento))
                    return true;
            return false;
        }

        /// <summary>
        ///     Comprueba si todos los elementos de la lista cumplen con un predicado.
        /// </summary>
        /// <param name="predicado">Condición que deben cumplir todos los elementos.</param>
        /// <returns><c>true</c> si todos cumplen la condición; de lo contrario, <c>false</c>.</returns>
        public bool All(Predicate<T> predicado) {
            foreach (var elemento in lista)
                if (!predicado(elemento))
                    return false;
            return true;
        }

        /// <summary>
        ///     Devuelve el índice del primer elemento que cumple con el predicado dado.
        /// </summary>
        /// <param name="predicado">Condición de búsqueda.</param>
        /// <returns>El índice basado en cero del primer acierto, o -1 si no se encuentra.</returns>
        public int IndexOf(Predicate<T> predicado) {
            var indice = 0;
            foreach (var elemento in lista) {
                if (predicado(elemento))
                    return indice;
                indice++;
            }

            return -1;
        }

        /// <summary>
        ///     Crea una copia superficial (en cuanto a referencias) pero en una nueva estructura de lista.
        /// </summary>
        /// <returns>Una nueva instancia de lista con los mismos elementos.</returns>
        public ILista<T> Clone() {
            var resultado = new Lista<T>();
            foreach (var elemento in lista)
                resultado.AddLast(elemento);
            return resultado;
        }

        /// <summary>
        ///     Realiza un intercambio físico de dos elementos en la lista según sus índices.
        /// </summary>
        /// <param name="i">Índice del primer elemento.</param>
        /// <param name="j">Índice del segundo elemento.</param>
        /// <exception cref="IndexOutOfRangeException">Si los índices están fuera de rango.</exception>
        private void Swap(int i, int j) {
            if (i < 0 || i >= lista.Size || j < 0 || j >= lista.Size)
                throw new IndexOutOfRangeException(
                    "Los índices proporcionados están fuera de los límites de la lista.");

            if (i == j) return;

            var itemI = lista.GetAt(i);
            var itemJ = lista.GetAt(j);

            lista.RemoveAt(i);
            lista.AddAt(i, itemJ);
            lista.RemoveAt(j);
            lista.AddAt(j, itemI);
        }

        /// <summary>
        ///     Ordena los elementos de forma Ascendente (A-Z, 0-9) basándose en una clave.
        ///     Usa el algoritmo de ordenamiento Bubble Sort.
        /// </summary>
        /// <typeparam name="TK">Tipo de la clave de ordenación (debe ser comparable).</typeparam>
        /// <param name="keySelector">Selector de la propiedad por la que ordenar.</param>
        /// <returns>Una nueva lista clonada y ordenada ascendentemente.</returns>
        public ILista<T> OrderBy<TK>(Func<T, TK> keySelector) where TK : IComparable<TK> {
            var copia = lista.Clone();
            var n = copia.Size;

            for (var i = 0; i < n - 1; i++) {
                for (var j = 0; j < n - i - 1; j++) {
                    var actual = keySelector(copia.GetAt(j));
                    var siguiente = keySelector(copia.GetAt(j + 1));

                    if (actual.CompareTo(siguiente) > 0)
                        copia.Swap(j, j + 1);
                }
            }

            return copia;
        }

        /// <summary>
        ///     Ordena los elementos de forma Descendente (Z-A, 9-0) basándose en una clave.
        ///     Usa el algoritmo de ordenamiento Bubble Sort.
        /// </summary>
        /// <typeparam name="TK">Tipo de la clave de ordenación (debe ser comparable).</typeparam>
        /// <param name="keySelector">Selector de la propiedad por la que ordenar.</param>
        /// <returns>Una nueva lista clonada y ordenada descendentemente.</returns>
        public ILista<T> OrderByDescending<TK>(Func<T, TK> keySelector) where TK : IComparable<TK> {
            var copia = lista.Clone();
            var n = copia.Size;

            for (var i = 0; i < n - 1; i++) {
                for (var j = 0; j < n - i - 1; j++) {
                    var actual = keySelector(copia.GetAt(j));
                    var siguiente = keySelector(copia.GetAt(j + 1));

                    if (actual.CompareTo(siguiente) < 0)
                        copia.Swap(j, j + 1);
                }
            }

            return copia;
        }

        /// <summary>
        ///     Ordena los elementos de la lista utilizando un comparador externo (Lambda).
        ///     Permite una flexibilidad total en el criterio de ordenación sin modificar la lista original.
        /// </summary>
        /// <param name="comparison">
        ///     Delegado o Lambda que define: (a, b) => int (negativo si a < b, 0 si=, positivo si a> b).
        /// </param>
        /// <returns>Una nueva lista ordenada.</returns>
        public ILista<T> Sort(Comparison<T> comparison) {
            var copia = lista.Clone();
            var n = copia.Size;

            // Algoritmo Bubble Sort optimizado
            bool cambiado;
            do {
                cambiado = false;
                for (var i = 0; i < n - 1; i++) {
                    var itemActual = copia.GetAt(i);
                    var itemSiguiente = copia.GetAt(i + 1);

                    // Si el resultado es mayor que 0, significa que itemActual > itemSiguiente -> Intercambiar
                    if (comparison(itemActual, itemSiguiente) > 0) {
                        copia.Swap(i, i + 1);
                        cambiado = true;
                    }
                }

                // Optimización: Cada pasada deja el elemento más grande al final, podemos reducir n
                n--;
            } while (cambiado);

            return copia;
        }

        /// <summary>
        ///     Devuelve un número específico de elementos contiguos desde el principio de la lista.
        /// </summary>
        /// <param name="cantidad">Número de elementos a tomar.</param>
        /// <returns>Una nueva lista con los primeros N elementos.</returns>
        public ILista<T> Take(int cantidad) {
            var resultado = new Lista<T>();
            var total = lista.Size;

            var limite = cantidad > total ? total : cantidad;

            for (var i = 0; i < limite; i++)
                resultado.AddLast(lista.GetAt(i));

            return resultado;
        }
    }
}