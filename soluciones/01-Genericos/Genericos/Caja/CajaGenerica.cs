namespace Genericos.Caja;

public class CajaGenerica<T>(T valor) {
    private T _valor = valor;
    public T GetValor() => _valor;
    public void SetValor(T nuevoValor) {
        _valor = nuevoValor;
    }
}