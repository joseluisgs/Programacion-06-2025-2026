namespace Varianza.Box;

// Esta caja es invariante porque tanto produce como consume T
public class Box<T> {
    private T _value;
    
    public Box(T value) {
        _value = value;
    }
    
    // Producimos T
    public T GetValue() {
        return _value;
    }
    
    // Consumimos T
    public void SetValue(T value) {
        _value = value;
    }
    
}