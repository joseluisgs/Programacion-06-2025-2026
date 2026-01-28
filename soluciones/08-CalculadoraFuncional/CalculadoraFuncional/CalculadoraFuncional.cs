namespace CalculadoraFuncional;

public static class CalculadoraFunc {
    
    // Con delegados predefinidos
    public static int Operacion(int a, int b, Func<int, int, int> operacion) {
        return operacion(a, b);
    }
}