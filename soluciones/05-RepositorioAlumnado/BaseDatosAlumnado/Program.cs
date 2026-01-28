using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using BaseDatosAlumnado.Common.Lista;
using BaseDatosAlumnado.Config;
using BaseDatosAlumnado.Enums;
using BaseDatosAlumnado.Models;
using BaseDatosAlumnado.Repositories.Alumnos;
using BaseDatosAlumnado.Services;
using BaseDatosAlumnado.Validators;
using Serilog;


// ====================================================================
// GESTIÓN DE ALUMNOS - CONSTANTES DEL SISTEMA
// ====================================================================

// Configurar el logger estático: Nivel mínimo Debug y salida a la consola con template.
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug() // Permitir mensajes Debug y superiores
    .WriteTo.Console(
        outputTemplate: "{Timestamp:HH:mm:ss.fff zzz} [{Level:u3}] [{SourceContext}] {Message:lj}{NewLine}{Exception}")
    .CreateLogger(); // Utilizamos Serilog para el logging

// --------------------------------------------------------------------
// BLOQUE PRINCIPAL (Top-Level Statements)
// --------------------------------------------------------------------

Console.Title = "Bases de Datos Alumnado con Arrays Estáticos en C#";
Console.OutputEncoding = Encoding.UTF8;
Console.Clear();

// Usa Daw's Template: Creación de estructuras y métodos.'
Main();

Log.CloseAndFlush(); // Asegura que todos los logs pendientes se escriban.
Console.WriteLine("\n⌨️ Presiona una tecla para salir...");
Console.ReadKey();
return;

// DAW's Template
void Main() {
    // Instanciamos el servicio de Alumnos "inyectando"
    // con el repositorio y validador adecuados.
    IAlumnosService service = new AlumnosService(
        AlumnosRepositoryListaEnlazadaPropia.GetInstance(),
        new AlumnoValidator()
    );
    // Usamos el tipo del enum, que internamente es un int.
    OpcionMenu opcion; // Valor inicial inválido para forzar la entrada al bucle do-while.


    const string RegexOpcionMenu = "^[0-8]$";

    Console.WriteLine("Sistema de Gestión de Alumnos DAW");
    Console.WriteLine("==================================");

    do {
        MostrarMenu();

        // Validación de la opción de menú con Regex
        string opcionStr;
        do {
            Console.Write("Seleccione una opción: ");
            opcionStr = Console.ReadLine()?.Trim() ?? "";
            if (!ValidarEntrada(RegexOpcionMenu, opcionStr))
                Console.WriteLine("⚠️ Opción no válida. Intente de nuevo.");
        } while (!ValidarEntrada(RegexOpcionMenu, opcionStr));

        // Conversión a entero y luego al tipo enum OpcionMenu
        opcion = (OpcionMenu)int.Parse(opcionStr);

        // El bucle principal delega la lógica a los métodos locales
        switch (opcion) {
            case OpcionMenu.ListarTodos:
                // Llamada a la función que faltaba
                ListarAlumnos(service);
                break;
            case OpcionMenu.InfoId:
                MostrarInfoAlumnoPorId(service);
                break;
            case OpcionMenu.InfoDni:
                MostrarInfoAlumnoPorDni(service);
                break;
            case OpcionMenu.Anadir:
                AnadirNuevoAlumno(service);
                break;
            case OpcionMenu.Actualizar:
                ActualizarDatosAlumno(service);
                break;
            case OpcionMenu.Eliminar:
                EliminarAlumnoPorDni(service);
                break;
            case OpcionMenu.ListarNotas:
                // Llamada a la función que faltaba, con ordenamiento por Nota
                ListarAlumnos(service, TipoOrdenamiento.Nota);
                break;
            case OpcionMenu.Estadisticas:
                MostrarEstadisticas(service);
                break;
            case OpcionMenu.Salir:
                Console.WriteLine("👋 Saliendo del programa. ¡Hasta pronto!");
                break;
            default:
                // Este caso ya no debería ocurrir si la validación es correcta.
                Console.WriteLine("⚠️ Opción no reconocida. Intente de nuevo.");
                break;
        }
    } while (opcion != OpcionMenu.Salir);
}

void MostrarMenu() {
    //  Usamos casting explícito a int para obtener el valor del enum.
    Console.WriteLine("\n--- MENÚ DE OPERACIONES ---");
    Console.WriteLine($"{(int)OpcionMenu.ListarTodos}. Listar todos los alumnos (Ordenado por DNI)");
    Console.WriteLine($"{(int)OpcionMenu.InfoId}. Información de alumno por ID");
    Console.WriteLine($"{(int)OpcionMenu.InfoDni}. Información de alumno por DNI");
    Console.WriteLine($"{(int)OpcionMenu.Anadir}. Añadir alumno");
    Console.WriteLine($"{(int)OpcionMenu.Actualizar}. Actualizar alumno");
    Console.WriteLine($"{(int)OpcionMenu.Eliminar}. Eliminar alumno");
    Console.WriteLine($"{(int)OpcionMenu.ListarNotas}. Listado ordenado por notas (Descendente)");
    Console.WriteLine($"{(int)OpcionMenu.Estadisticas}. Mostrar Estadísticas");
    Console.WriteLine($"{(int)OpcionMenu.Salir}. Salir");
    Console.WriteLine("---------------------------");
}

void ListarAlumnos(IAlumnosService service, TipoOrdenamiento ordenamiento = TipoOrdenamiento.Dni) {
    Console.WriteLine("\n--- LISTADO DE ALUMNOS ---");

    if (service.TotalAlumnos == 0) {
        Console.WriteLine("⚠️ INFO: No hay alumnos registrados.");
        return;
    }

    var listado = service.GetAllOrderBy(ordenamiento);
    ImprimirListado(listado);
}

void ImprimirListado(ILista<Alumno> alumnos) {
    // Hemos añadido una columna para el ID
    Console.WriteLine("---------------------------------------------------------");
    Console.WriteLine($"{"ID",-4} {"DNI",-10} {"Nombre",-25} {"Nota",-5}");
    Console.WriteLine("---------------------------------------------------------");

    for (var i = 0; i < alumnos.Contar(); i++) {
        var alumno = alumnos.Obtener(i);
        // Usamos alineación fija para simular el formato de tabla, incluyendo el ID
        Console.WriteLine(
            $"{alumno.Id,-4} {alumno.Dni,-10} {alumno.NombreCompleto,-25} {alumno.Nota.ToString("F2", Configuracion.Locale),-5}");
    }

    Console.WriteLine("---------------------------------------------------------");
}

void MostrarInfoAlumnoPorId(IAlumnosService service) {
    const string RegexId = @"^\d+$";

    Console.WriteLine("\n--- INFORMACIÓN DE ALUMNO POR ID ---");
    var idStr = LeerCadenaValidada("Introduzca el ID del alumno a buscar: ", RegexId, "Formato de ID no válido.");

    // Conversión a entero
    var id = int.Parse(idStr);

    try {
        var alumno = service.GetById(id);
        ImprimirInfoAlumno(alumno);
    }
    catch (KeyNotFoundException ex) {
        Log.Error(ex, "Error al obtener alumno por ID.");
        Console.WriteLine($"❌ ERROR: {ex.Message}");
    }
}

void MostrarInfoAlumnoPorDni(IAlumnosService service) {
    Console.WriteLine("\n--- INFORMACIÓN DE ALUMNO POR DNI ---");

    // 1. Lectura y Validación de DNI (debe existir)
    var dni = LeerDniValidado();

    try {
        var alumno = service.GetByDni(dni);
        ImprimirInfoAlumno(alumno);
    }
    catch (KeyNotFoundException ex) {
        // Si no quieres mostrar el stack trace al usuario, solo el mensaje, quita el ex, del Logger
        Log.Error(ex, "Error al obtener alumno por DNI.");
        Console.WriteLine($"❌ ERROR: {ex.Message}");
    }
}


string LeerDniValidado() {
    string dni;
    bool dniValido;

    do {
        Console.Write("DNI: ");
        dni = Console.ReadLine()?.Trim() ?? "";

        // Uso de ToUpper() sin argumento de cultura.
        dni = dni.ToUpper();

        if (!ValidarDniCompleto(dni)) {
            // El error original provenía de aquí, al fallar ValidarDniCompleto.
            Console.WriteLine(
                "❌ ERROR: DNI inválido. Asegúrese del formato (8 dígitos + 1 letra) y la letra de control correcta.");
            dniValido = false;
        }
        else {
            dniValido = true;
        }
    } while (!dniValido);

    return dni;
}


void AnadirNuevoAlumno(IAlumnosService service) {
    Console.WriteLine("\n--- AÑADIR NUEVO ALUMNO ---");
    Console.WriteLine("Introduzca los datos del nuevo alumno:");

    // 1. Lectura y Validación de DNI (debe ser nuevo)
    var dni = LeerDniValidado();

    // 2. Lectura y Validación de Nombre
    var nombre = LeerCadenaValidada(
        "Nombre Completo: ",
        AlumnoValidator.RegexNombre,
        "Nombre inválido. Mínimo 3 caracteres, solo letras y espacios."
    );

    // 3. Lectura y Validación de Nota
    var nota = LeerNotaValida();

    // 4. Crear la nueva struct Alumno
    var nuevoAlumno = new Alumno {
        Dni = dni,
        NombreCompleto = nombre,
        Nota = nota
    };

    try {
        service.Save(nuevoAlumno);
        Console.WriteLine($"✅ INFO: Alumno (ID: {nuevoAlumno.Id}) añadido exitosamente.");
    }
    catch (Exception ex) {
        Log.Error(ex, "Error al añadir nuevo alumno.");
        Console.WriteLine($"❌ ERROR: No se pudo añadir el alumno. {ex.Message}");
    }
}


void ActualizarDatosAlumno(IAlumnosService service) {
    Console.WriteLine("\n--- ACTUALIZAR ALUMNO ---");
    Console.WriteLine("Introduzca el DNI del alumno cuyos datos desea actualizar:");

    // 1. Lectura y Validación de DNI (debe existir)
    var dni = LeerDniValidado();

    Alumno? alumnoAntiguo;

    try {
        alumnoAntiguo = service.GetByDni(dni);
    }
    catch (KeyNotFoundException ex) {
        Log.Error(ex, "Error al actualizar nuevo alumno.");
        Console.WriteLine($"❌ ERROR: No se pudo actualizar el alumno. {ex.Message}");
        return; // Si el DNI no existe, salimos del método
    }

    Console.WriteLine("\n--- DATOS ACTUALES (ANTIGUOS) ---");
    ImprimirInfoAlumno(alumnoAntiguo);

    // 3. Recoger nuevos datos con validación
    Console.WriteLine($"\n✏️ Introduzca los nuevos datos para {alumnoAntiguo.NombreCompleto}:");

    // Desea cambiar el nombre? si no se mantiene el antiguo
    var cambiar = PedirConfirmacion("¿Desea cambiar el nombre?");
    var nombreActualizado = cambiar
        ? LeerCadenaValidada(
            "Nuevo Nombre Completo: ",
            AlumnoValidator.RegexNombre,
            "Nombre inválido. Mínimo 3 caracteres, solo letras y espacios."
        )
        : alumnoAntiguo.NombreCompleto;

    // Desea cambiar la nota?, si no se mantiene la antigua
    cambiar = PedirConfirmacion("¿Desea cambiar la nota?");
    var notaActualizada = cambiar ? LeerNotaValida() : alumnoAntiguo.Nota;

    // 4. Crear el registro PROPUESTO con los datos nuevos (para mostrar la vista previa)
    var alumnoNuevo = new Alumno {
        Id = alumnoAntiguo.Id, // Mantenemos el mismo ID
        Dni = alumnoAntiguo.Dni, // Mantenemos el mismo DNI
        NombreCompleto = nombreActualizado,
        Nota = notaActualizada
    };

    // 5. Mostrar los datos propuestos
    Console.WriteLine("\n--- DATOS PROPUESTOS (NUEVOS) ---");
    ImprimirInfoAlumno(alumnoNuevo);

    // 6. Pedir confirmación antes de aplicar
    if (PedirConfirmacion($"Actualizar el alumno {alumnoAntiguo.NombreCompleto} (ID: {alumnoAntiguo.Id})"))
        // 7. Si confirma, aplicar la modificación
        try {
            service.Update(alumnoNuevo);
            Console.WriteLine($"\n✅ INFO: Datos del alumno con DNI {dni} actualizados con éxito.");
        }
        catch (Exception ex) {
            Log.Error(ex, "Error al actualizar datos del alumno.");
            Console.WriteLine($"❌ ERROR: No se pudo actualizar el alumno. {ex.Message}");
        }
    else
        Console.WriteLine(
            $"\n🚫 CANCELADO: Actualización de datos para {dni} cancelada. Los datos antiguos se mantienen.");
}

void EliminarAlumnoPorDni(IAlumnosService service) {
    Console.WriteLine("\n--- ELIMINAR ALUMNO ---");

    Console.WriteLine("Introduzca el DNI del alumno a eliminar:");
    // Validamos que el DNI exista (false: debe existir)
    var dni = LeerDniValidado();

    try {
        var alumno = service.GetByDni(dni);
        // 1. Mostrar datos a eliminar
        Console.WriteLine("\n--- ALUMNO A ELIMINAR PERMANENTEMENTE ---");
        ImprimirInfoAlumno(alumno);
        if (PedirConfirmacion(
                $"¿Está seguro de que desea eliminar permanentemente al alumno con DNI {dni}? Esta acción no se puede deshacer.")) {
            // 3. Si confirma, eliminar y reducir
            service.Delete(alumno.Id);
            Console.WriteLine($"\n✅ INFO: Alumno con DNI {dni} eliminado con éxito.");
        }
        else {
            // 4. Si cancela, no hacer nada
            Console.WriteLine($"\n🚫 CANCELADO: Eliminación del alumno con DNI {dni} cancelada.");
        }
    }
    catch (KeyNotFoundException ex) {
        Log.Error(ex, "Error al obtener alumno por DNI para eliminación.");
        Console.WriteLine($"❌ ERROR: {ex.Message}");
    }
}

void MostrarEstadisticas(IAlumnosService service) {
    Console.WriteLine("\n--- ESTADÍSTICAS DEL ALUMNADO ---");
    if (service.TotalAlumnos == 0) {
        Console.WriteLine("⚠️ INFO: No hay alumnos para calcular estadísticas.");
        return;
    }

    var informe = service.Informe();

    Console.WriteLine($"📊 Alumnos totales: {informe.TotalAlumnos}");
    Console.WriteLine(
        $"🎖️ Aprobados (Nota >= {Configuracion.NotaAprobado.ToString("F2", Configuracion.Locale)}): {informe.AlumnosAprobados}");
    Console.WriteLine($"Porcentaje Aprobados: {informe.PorcentajeAprobados.ToString("F2", Configuracion.Locale)}%");
    Console.WriteLine(
        $"🔴 Suspensos (Nota < {Configuracion.NotaAprobado.ToString("F2", Configuracion.Locale)}): {informe.AlumnosSuspensos}");
    Console.WriteLine($"Porcentaje Suspensos: {informe.PorcentajeSuspensos.ToString("F2", Configuracion.Locale)}%");
    Console.WriteLine($"⭐ Nota Media: {informe.NotaMedia.ToString("F2", Configuracion.Locale)}");
}


bool ValidarEntrada(string patron, string entrada) {
    return Regex.IsMatch(entrada, patron);
}

bool ValidarDniCompleto(string dni) {
    var letrasDni = "TRWAGMYFPDXBNJZSQVHLCKE";
    // La expresión regular ahora solo valida formato: 8 dígitos + 1 letra mayúscula (más robusto)
    var regexDniFormato = @"^(\d{8})([A-Z])$";

    // 1. Validar el formato base
    if (!Regex.IsMatch(dni, regexDniFormato)) {
        Log.Warning("Validación DNI fallida por formato (no 8 dígitos + 1 letra A-Z): '{Dni}'", dni);
        return false;
    }

    // 2. Extraer número y letra (ahora que sabemos que el formato es 8+1)
    var match = Regex.Match(dni, regexDniFormato);
    // Group[1] contiene los 8 dígitos, Group[2] contiene la letra
    var dniNumero = int.Parse(match.Groups[1].Value);
    var dniLetra = match.Groups[2].Value[0]; // Ya está en mayúscula por LeerDniValido

    // 3. Cálculo del módulo y de la letra esperada
    var indiceLetra = dniNumero % 23;
    var letraEsperada = letrasDni[indiceLetra];

    // 4. Comparamos
    var resultado = letraEsperada == dniLetra;

    if (!resultado)
        Log.Warning("Validación DNI fallida por letra. DNI: '{Dni}'. Esperada: '{Esperada}'.", dni, letraEsperada);

    return resultado;
}

void ImprimirInfoAlumno(Alumno alumno) {
    Console.WriteLine("-----------------------------------");
    Console.WriteLine($"👤 ID: {alumno.Id}");
    Console.WriteLine($"💳 DNI: {alumno.Dni}");
    Console.WriteLine($"📝 Nombre: {alumno.NombreCompleto}");
    Console.WriteLine($"💯 Nota: {alumno.Nota.ToString("F2", Configuracion.Locale)}");
    Console.WriteLine("-----------------------------------");
}

bool PedirConfirmacion(string mensaje) {
    Console.WriteLine("\n-----------------------------------");
    Console.WriteLine($"⚠️ {mensaje} Se requiere confirmación.");
    Console.Write("Presione 'S' para confirmar, o cualquier otra tecla para cancelar: ");

    // Leemos solo una tecla sin mostrarla inmediatamente
    var key = Console.ReadKey(true).KeyChar;
    // Mostramos la tecla que se presionó (S, s, N, etc.)
    Console.WriteLine(key);

    // Uso de ToUpper() sin argumento de cultura.
    if (char.ToUpper(key) == 'S') {
        Console.WriteLine("✅ Operación CONFIRMADA.");
        return true;
    }

    Console.WriteLine("🚫 Operación CANCELADA por el usuario.");
    return false;
}

string LeerCadenaValidada(string prompt, string regexPattern, string errorMsg) {
    string input;
    var valido = false;
    do {
        Console.Write(prompt);
        input = (Console.ReadLine() ?? "").Trim();
        if (ValidarEntrada(regexPattern, input))
            valido = true;
        else
            Console.WriteLine($"❌ ERROR: {errorMsg}");
    } while (!valido);

    return input;
}

double LeerNotaValida() {
    // Patrón que acepta coma o punto como separador decimal.
    var regexNotaLocale = @"^(?:0([,.]\d{1,2})?|[1-9]([,.]\d{1,2})?|10([,.]0{1,2})?)$";

    var notaStr = LeerCadenaValidada(
        "Nota (0.00 - 10.00, use coma o punto): ",
        regexNotaLocale,
        "La nota debe estar entre 0.00 y 10.00 y tener hasta dos decimales."
    );

    //Estandarizamos: si tiene coma, la convertimos a punto.
    notaStr = notaStr.Replace(',', '.');

    double.TryParse(notaStr, NumberStyles.Float, CultureInfo.InvariantCulture, out var nota);
    return nota;
}