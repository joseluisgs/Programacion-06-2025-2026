namespace OperacionesFuncionalesLista.Collections.Lista;

public interface ILista<T> {
    void AgregarInicio(T valor);
    void AgregarFinal(T valor);
    void AgregarEn(T valor, int indice);
    void EliminarInicio();
    void EliminarFinal();
    void EliminarEn(int indice);
    T ObtenerPrimero();
    T ObtenerUltimo();
    T Obtener(int indice);
    bool Existe(T valor);
    int Contar();
    bool EstaVacia();
    void Limpiar();
    void Mostrar();
    IEnumerator<T> GetEnumerator();
}