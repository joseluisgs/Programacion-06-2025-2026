namespace Genericos.Caja;

// Con object se puede guardar cualquier tipo de dato
// Pero no es seguro, el casting puede fallar en tiempo de ejecución
public class CajaObject(object valor) {
    private object _valor = valor;
    public object GetValor() => _valor;
    public void SetValor(object nuevoValor) {
        _valor = nuevoValor;
    }
}