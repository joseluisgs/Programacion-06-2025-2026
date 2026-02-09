namespace ListaEnlazada.Pila;

public interface IPila<T> {
    void Apilar(T valor);
    T Desapilar();
    T VerTope();
    bool EstaVacia();
    int Contar();
    void Mostrar();
}