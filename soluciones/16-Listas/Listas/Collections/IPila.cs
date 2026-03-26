namespace Listas.Collections;

public interface IPila<T> {
    void Push(T elemento);
    T Pop();
    T Peek();
    bool IsEmpty();
}