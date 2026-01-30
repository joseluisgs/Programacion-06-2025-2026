namespace Genericos.Caja;

public class CajaGenericaMultiple<T, TP>(T valor, TP otroValor) {
    private T _valor = valor;
    private TP _otroValor = otroValor;
    public T GetValor() => _valor;
    public TP GetOtroValor() => _otroValor;
    public void SetValor(T nuevoValor) {
        _valor = nuevoValor;
    }
    public void SetOtroValor(TP nuevoOtroValor) {
        _otroValor = nuevoOtroValor;
    }
}