namespace SobrecargaOperadores.Models;

public class Fraccion {
    public int Numerador { get; init; }
    public int Denominador { get; init; }
    
    public override string ToString() => $"{Numerador}/{Denominador}";

    public override bool Equals(object? obj) {
        if (obj is Fraccion fraccion) {
            return this.Numerador == fraccion.Numerador && this.Denominador == fraccion.Denominador;
        }
        return false;
    }

    private bool Equals(Fraccion other) {
        return Numerador == other.Numerador && Denominador == other.Denominador;
    }

    public override int GetHashCode() {
        return HashCode.Combine(Numerador, Denominador);
    }

    public static bool operator ==(Fraccion f1, Fraccion f2) => f1.Equals(f2);
    public static bool operator !=(Fraccion f1, Fraccion f2) => !f1.Equals(f2);

    public static Fraccion operator +(Fraccion f1, Fraccion f2) {
        return new Fraccion {
            Numerador = f1.Numerador * f2.Denominador + f2.Numerador * f1.Denominador,
            Denominador = f1.Denominador * f2.Denominador
        }.Simplificar();
    }
    
    public static Fraccion operator ++(Fraccion f) {
        return new Fraccion {
            Numerador = f.Numerador + f.Denominador,
            Denominador = f.Denominador
        }.Simplificar();
    }
    
    public static Fraccion operator -(Fraccion f1, Fraccion f2) {
        return new Fraccion {
            Numerador = f1.Numerador * f2.Denominador - f2.Numerador * f1.Denominador,
            Denominador = f1.Denominador * f2.Denominador
        }.Simplificar();
    }
    
    public static Fraccion operator *(Fraccion f1, Fraccion f2) {
        // Multiplicación de fracciones
        return new Fraccion {
            Numerador = f1.Numerador * f2.Numerador,
            Denominador = f1.Denominador * f2.Denominador
        }.Simplificar();
    }
    
    public static Fraccion operator /(Fraccion f1, Fraccion f2) {
        // División de fracciones
        return new Fraccion {
            Numerador = f1.Numerador * f2.Denominador,
            Denominador = f1.Denominador * f2.Numerador
        }.Simplificar();
    }
}

// Métodos de extensión para Fracción
public static class FraccionExtensions {
    public static Fraccion Simplificar(this Fraccion fraccion) {
        var gcd = Mcd(fraccion.Numerador, fraccion.Denominador);
        return new Fraccion {
            Numerador = fraccion.Numerador / gcd,
            Denominador = fraccion.Denominador / gcd
        };
    }

    private static int Mcd(int numerador, int denominador) {
        while (denominador != 0) {
            var temp = denominador;
            denominador = numerador % denominador;
            numerador = temp;
        }
        return Math.Abs(numerador);
    }
}