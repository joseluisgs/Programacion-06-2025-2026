using System.Text.RegularExpressions;
using BaseDatosAlumnado.Models;
using Serilog;

namespace BaseDatosAlumnado.Validators;

/// <summary>
///     Validador para objetos Alumno.
/// </summary>
public class AlumnoValidator : IAlumnoValidator {
    // Constantes para los rangos
    private const int MinNombreLength = 3;
    private const int MaxNombreLength = 100;
    private const int MinNota = 0;
    private const int MaxNota = 10;
    public static readonly string RegexNombre = @"^[A-Za-zñÑáéíóúÁÉÍÓÚ\s]{3,}$";
    private static readonly string RegexDniFormato = @"^(\d{8})([A-Z])$";

    private readonly ILogger _log = Log.ForContext<AlumnoValidator>();

    /// <summary>
    ///     Valida un objeto Alumno. Si falla alguna validación, lanza la excepción apropiada.
    /// </summary>
    /// <param name="alumno">El objeto Alumno a validar.</param>
    /// <returns>El mismo objeto Alumno si todas las validaciones pasan.</returns>
    public Alumno Validate(Alumno alumno) {
        _log.Debug("Iniciando validación para el alumno: {Alumno}", alumno);

        // --- 1. Validación del DNI ---
        if (string.IsNullOrWhiteSpace(alumno.Dni)) {
            _log.Warning("Validación fallida: DNI vacío o nulo.");
            throw new ArgumentException("El DNI no puede estar vacío.", nameof(alumno.Dni));
        }

        if (!ValidarDniCompleto(alumno.Dni)) {
            _log.Warning("Validación fallida: El DNI '{Dni}' no es válido o su formato es incorrecto.", alumno.Dni);
            throw new ArgumentException("El DNI no es válido o su formato es incorrecto.", nameof(alumno.Dni));
        }

        // --- 2. Validación del Nombre Completo (Existencia) ---
        if (string.IsNullOrWhiteSpace(alumno.NombreCompleto)) {
            _log.Warning("Validación fallida: Nombre completo vacío o nulo.");
            throw new ArgumentException("El nombre completo no puede estar vacío.", nameof(alumno.NombreCompleto));
        }

        // --- 3. Validación del Nombre Completo (Longitud) ---
        var currentNombreLength = alumno.NombreCompleto.Length;

        if (currentNombreLength < MinNombreLength || currentNombreLength > MaxNombreLength) {
            _log.Warning(
                "Validación fallida: Longitud de nombre '{Nombre}' fuera de rango ({Min}-{Max}). Actual: {Current}",
                alumno.NombreCompleto, MinNombreLength, MaxNombreLength, currentNombreLength);

            // Uso de ArgumentOutOfRangeException con paramName y mensaje descriptivo
            throw new ArgumentOutOfRangeException(
                nameof(alumno.NombreCompleto),
                $"El nombre completo debe tener entre {MinNombreLength} y {MaxNombreLength} caracteres. Tiene {currentNombreLength}."
            );
        }

        // Lo validamos con el regex finalmente
        if (!ValidadNombre(alumno.NombreCompleto)) {
            _log.Warning("Validación fallida: Nombre completo '{Nombre}' contiene caracteres inválidos.",
                alumno.NombreCompleto);
            throw new ArgumentException("El nombre completo contiene caracteres inválidos.",
                nameof(alumno.NombreCompleto));
        }

        // --- 4. Validación de la Nota ---
        if (alumno.Nota < MinNota || alumno.Nota > MaxNota) {
            _log.Warning("Validación fallida: Nota fuera de rango. Valor actual: {ActualNota}", alumno.Nota);

            // Uso de ArgumentOutOfRangeException con paramName, actualValue y mensaje completo
            throw new ArgumentOutOfRangeException(
                nameof(alumno.Nota),
                alumno.Nota,
                $"La nota debe estar entre {MinNota} y {MaxNota} (ambos inclusive). Valor proporcionado: {alumno.Nota}."
            );
        }

        _log.Debug("Validación del alumno completada con éxito.");
        return alumno;
    }

    /// <summary>
    ///     Valida la lógica completa del DNI, incluyendo formato y letra.
    /// </summary>
    /// <param name="dni">El DNI a validar.</param>
    /// <returns>True si el DNI es válido, False si no lo es.</returns>
    private bool ValidarDniCompleto(string dni) {
        _log.Debug("Iniciando validación de la lógica de letra del DNI: {Dni}", dni);

        const string LetrasDni = "TRWAGMYFPDXBNJZSQVHLCKE";
        // La expresión regular valida formato: 8 dígitos + 1 letra mayúscula

        // 1. Validar el formato base (debe tener 8 dígitos y una letra mayúscula)
        var match = Regex.Match(dni, RegexDniFormato);
        if (!match.Success) {
            _log.Warning("Validación DNI fallida por formato (no 8 dígitos + 1 letra A-Z): '{Dni}'", dni);
            return false;
        }

        // 2. Extraer número y letra
        // Group[1] contiene los 8 dígitos, Group[2] contiene la letra
        var dniNumero = int.Parse(match.Groups[1].Value);
        var dniLetra = match.Groups[2].Value[0];

        // 3. Cálculo del módulo y de la letra esperada
        var indiceLetra = dniNumero % 23;
        var letraEsperada = LetrasDni[indiceLetra];

        // 4. Comparamos
        var resultado = letraEsperada == dniLetra;

        if (!resultado)
            _log.Warning(
                "Validación DNI fallida por letra. DNI: '{Dni}'. Esperada: '{Esperada}'. Recibida: '{Recibida}'.",
                dni, letraEsperada, dniLetra);

        return resultado;
    }

    /// <summary>
    ///     Valida el nombre completo usando una expresión regular.
    /// </summary>
    /// <param name="nombre">El nombre a validar.</param>
    /// <returns>True si el nombre es válido, False si no lo es.</returns>
    private bool ValidadNombre(string nombre) {
        return Regex.IsMatch(nombre, RegexNombre);
    }
}