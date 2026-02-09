namespace Listas.Collections;

public interface ICola<T> {
    void Enqueue(T item);
    T Dequeue();
    T Peek();
    bool IsEmpty();
}