namespace Varianza.Box;

// Esta caja es contravariante porque solo consume T
public class ContravarianteBox<T>(T value) : IContravarianza<T> {
    private T _value = value;

    public void Consumir(T item) {
        _value = item;
    }
}