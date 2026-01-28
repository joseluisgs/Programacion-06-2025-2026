- [6. Formateadores y Localización](#6-formateadores-y-localización)
  - [6.1. Introducción](#61-introducción)
  - [6.2. CultureInfo](#62-cultureinfo)
  - [6.3. Formateo de Números](#63-formateo-de-números)
  - [6.4. Formateo de Fechas](#64-formateo-de-fechas)
  - [6.5. Métodos de Extensión para Formateo](#65-métodos-de-extensión-para-formateo)

# 6. Formateadores y Localización

La **localización** y el **formateo** permiten que las aplicaciones se adapten a diferentes culturas y regiones.

## 6.1. Introducción

Diferentes países tienen diferentes convenciones:
- **España**: 1.234,56 € (punto como separador de miles, coma para decimales)
- **USA**: $1,234.56 (coma como separador de miles, punto para decimales)
- **Fechas**: dd/mm/aaaa vs mm/dd/aaaa

## 6.2. CultureInfo

`CultureInfo` representa información sobre una cultura específica.

```csharp
using System.Globalization;

// Cultura actual del sistema
CultureInfo actual = CultureInfo.CurrentCulture;
Console.WriteLine(actual.Name); // "es-ES", "en-US", etc.

// Culturas específicas
CultureInfo españa = new CultureInfo("es-ES");
CultureInfo usa = new CultureInfo("en-US");
CultureInfo méxico = new CultureInfo("es-MX");
CultureInfo japón = new CultureInfo("ja-JP");

Console.WriteLine($"España: {españa.DisplayName}");
Console.WriteLine($"USA: {usa.DisplayName}");
```

## 6.3. Formateo de Números

```csharp
double numero = 1234567.89;
CultureInfo es = new CultureInfo("es-ES");
CultureInfo en = new CultureInfo("en-US");

// Formato numérico (N)
Console.WriteLine($"España: {numero.ToString("N2", es)}");   // 1.234.567,89
Console.WriteLine($"USA: {numero.ToString("N2", en)}");     // 1,234,567.89

// Formato moneda (C)
Console.WriteLine($"España: {numero.ToString("C", es)}");   // 1.234.567,89 €
Console.WriteLine($"USA: {numero.ToString("C", en)}");     // $1,234,567.89

// Formato porcentaje (P)
double porcentaje = 0.1575;
Console.WriteLine($"España: {porcentaje.ToString("P2", es)}");  // 15,75 %
Console.WriteLine($"USA: {porcentaje.ToString("P2", en)}");    // 15.75 %
```

### 📝 Nota del Profesor: Cadenas de Formato

| Formato | Descripción | Ejemplo |
|---------|-------------|---------|
| `C` o `C2` | Moneda | 1.234,56 € |
| `N` o `N2` | Número | 1.234.567,89 |
| `P` o `P2` | Porcentaje | 15,75 % |
| `D` o `D5` | Entero con ceros | 00123 |
| `E` o `E2` | Científico | 1,23E+06 |
| `F` o `F2` | Fixed-point | 1234567,89 |

## 6.4. Formateo de Fechas

```csharp
using System.Globalization;

DateTime fecha = new DateTime(2024, 12, 25, 15, 30, 0);
CultureInfo es = new CultureInfo("es-ES");
CultureInfo en = new CultureInfo("en-US");
CultureInfo jp = new CultureInfo("ja-JP");

// Fecha larga (D)
Console.WriteLine($"España: {fecha.ToString("D", es)}");   // miércoles, 25 de diciembre de 2024
Console.WriteLine($"USA: {fecha.ToString("D", en)}");     // Wednesday, December 25, 2024
Console.WriteLine($"Japón: {fecha.ToString("D", jp)}");   // 2024年12月25日

// Fecha corta (d)
Console.WriteLine($"España: {fecha.ToString("d", es)}");   // 25/12/2024
Console.WriteLine($"USA: {fecha.ToString("d", en)}");     // 12/25/2024

// Hora (T o t)
Console.WriteLine($"España: {fecha.ToString("T", es)}");   // 15:30:00
Console.WriteLine($"USA: {fecha.ToString("T", en)}");     // 3:30:00 PM

// Custom
Console.WriteLine(fecha.ToString("dd/MM/yyyy HH:mm")); // 25/12/2024 15:30
```

### 🧠 Analogía: El Formato de Fecha como Idioma

Igual que cada idioma tiene palabras diferentes, cada cultura tiene su propia "gramática" para fechas y números.

## 6.5. Métodos de Extensión para Formateo

```csharp
using System.Globalization;

public static class ExtensionesFormateo
{
    public static string ToLocalDate(this DateTime fecha)
    {
        return fecha.ToString("d", CultureInfo.CurrentCulture);
    }
    
    public static string ToLocalMoney(this decimal cantidad)
    {
        return cantidad.ToString("C", CultureInfo.CurrentCulture);
    }
    
    public static string ToSpanishDate(this DateTime fecha)
    {
        return fecha.ToString("D", new CultureInfo("es-ES"));
    }
    
    public static string ToEuroMoney(this decimal cantidad)
    {
        return cantidad.ToString("C", new CultureInfo("es-ES"));
    }
}

// Uso
DateTime hoy = DateTime.Now;
decimal precio = 1234.56m;

Console.WriteLine(hoy.ToLocalDate());
Console.WriteLine(precio.ToLocalMoney());
```

### 💡 Tip del Examinador: CultureInfo.InvariantCulture

Usa `CultureInfo.InvariantCulture` cuando el formato NO debe variar según la cultura (datos técnicos, archivos de configuración):

```csharp
// Para datos que siempre deben tener el mismo formato
string json = $"\"date\": \"{fecha.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}\"";
```
