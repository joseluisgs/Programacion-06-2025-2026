namespace CalculadoraFuncional;

public static class Calculadora {
    public static int Sumar(int a, int b) {
        return a + b;
    }
    public static int Restar(int a, int b) {
        return a - b;
    }

    public static int Multiplicar(int a, int b) {
        return a * b;
    }
    public static int Dividir(int a, int b) {
        if (b == 0) {
            throw new DivideByZeroException("No se puede dividir por cero.");
        }
        return a / b;
    }
    
    // que pasa si quisiera añadir mas operaciones?
}