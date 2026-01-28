namespace SobrecargaOperadores.Models;

public class Vector {
    public int X { get; init; }
    public int Y { get; init; }
    
    
    public static Vector operator +(Vector v1, Vector v2) {
        return new Vector {
            X = v1.X + v2.X,
            Y = v1.Y + v2.Y
        };
    }

    public static Vector operator -(Vector v1, Vector v2) {
        return new Vector {
            X = v1.X - v2.X,
            Y = v1.Y - v2.Y
        };
    }

    public static Vector operator *(Vector v, int scalar) {
        return new Vector {
            X = v.X * scalar,
            Y = v.Y * scalar
        };
    }
    
    public static Vector operator *(Vector v1, Vector v2) {
        // Producto cruzado
        return new Vector {
            X = v1.Y * v2.X - v1.X * v2.Y,
            Y = v1.X * v2.Y - v1.Y * v2.X
        };
    }
    
    public static bool operator ==(Vector v1, Vector v2) {
        return v1.X == v2.X && v1.Y == v2.Y;
    }
    
    public static bool operator !=(Vector v1, Vector v2) {
        return !(v1 == v2);
    }

    public override string ToString() {
        return $"({X}, {Y})";
    }
}