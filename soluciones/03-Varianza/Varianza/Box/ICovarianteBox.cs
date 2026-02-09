namespace Varianza.Box;

// Definimos una interfaz covariante
// El genérico , solo puede "salir" (producir) T
public interface ICovarianteBox<out T> {
    // Solo producimos T
    T GetValue();
}