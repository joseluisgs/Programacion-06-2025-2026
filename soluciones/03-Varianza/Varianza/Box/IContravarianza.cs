namespace Varianza.Box;

// Definimos una interfaz contravariante
// El genérico , solo puede "entrar" (consumir) T
public interface IContravarianza<in T> {
    void Consumir(T item);  // Solo ENTRADA
}