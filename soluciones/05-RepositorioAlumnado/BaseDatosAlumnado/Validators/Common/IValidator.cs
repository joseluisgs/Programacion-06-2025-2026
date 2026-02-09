namespace BaseDatosAlumnado.Validators.Common;

public interface IValidator<T> {
    T Validate(T item);
}