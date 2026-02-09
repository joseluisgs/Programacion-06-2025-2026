namespace ListaEnlazada.Cola;

public interface ICola<T> {
    void Encolar(T valor);
    T Desencolar();
    T VerFrente();
    bool EstaVacia();
    int Contar();
    void Mostrar();
}