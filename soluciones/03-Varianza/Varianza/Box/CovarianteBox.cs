namespace Varianza.Box;

// Esta caja es covariante porque solo produce T
public class CovarianteBox<T>(T value) : ICovarianteBox<T> {
    private T _value = value;

    public T GetValue() {
        return _value;
    }
}