namespace FuncionesExtension.Extension;

public static class IntExtensions {
    // El bloque extension define el 'receptor' (numero) sin usar 'this'
    extension(int numero) {
        public bool EsPar() => numero % 2 == 0;

        public bool EsPrimo() {
            // No seas cutre y usa un algoritmo eficiente
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;
            for (int i = 3; i * i <= numero; i += 2) {
                if (numero % i == 0) return false;
            }
            return true;
        }
        public long Factorial() {
            if (numero < 0) throw new ArgumentException("El número debe ser no negativo.");
            long resultado = 1;
            for (int i = 2; i <= numero; i++) {
                resultado *= i;
            }
            return resultado;
        }
    }
}
