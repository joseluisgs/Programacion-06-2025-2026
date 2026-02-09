using System.Globalization;

namespace BaseDatosAlumnado.Config;

public static class Configuracion {
    public static readonly int TamanoInicial = 10;
    public static readonly int IncrementoTamano = 10;
    public static readonly int PorcentajeExpansion = 80;
    public static readonly int PorcentajeReduccion = 50;
    public static readonly double NotaAprobado = 5.00;
    public static readonly CultureInfo Locale = CultureInfo.GetCultureInfo("es-ES");
}