using GestionAcademica.Models;

namespace GestionAcademica.Factories;

/// <summary>
///     Factoría con datos semilla fijos para registros inmutables de Estudiantes y Docentes.
/// </summary>
public static class PersonasFactory {
    /// <summary>
    ///     Genera la semilla de datos inicial (10 Estudiantes y 5 Docentes).
    /// </summary>
    /// <returns>Enumerable con datos de demostración</returns>
    public static IEnumerable<Persona> Seed() {
        var lista = new List<Persona>();

        lista.Add(new Estudiante {
            Dni = "11111111H", Nombre = "Ana", Apellidos = "López", Calificacion = 8.5, Ciclo = Ciclo.DAM,
            Curso = Curso.Primero
        });
        lista.Add(new Estudiante {
            Dni = "22222222J", Nombre = "Pedro", Apellidos = "Ruiz", Calificacion = 4.2, Ciclo = Ciclo.DAM,
            Curso = Curso.Primero
        });
        lista.Add(new Estudiante {
            Dni = "33333333P", Nombre = "María", Apellidos = "García", Calificacion = 9.0, Ciclo = Ciclo.DAM,
            Curso = Curso.Segundo
        });
        lista.Add(new Estudiante {
            Dni = "44444444A", Nombre = "Juan", Apellidos = "Pérez", Calificacion = 6.5, Ciclo = Ciclo.DAM,
            Curso = Curso.Segundo
        });
        lista.Add(new Estudiante {
            Dni = "55555555K", Nombre = "Elena", Apellidos = "Gómez", Calificacion = 7.8, Ciclo = Ciclo.DAW,
            Curso = Curso.Primero
        });
        lista.Add(new Estudiante {
            Dni = "66666666Q", Nombre = "Luis", Apellidos = "Moreno", Calificacion = 3.5, Ciclo = Ciclo.DAW,
            Curso = Curso.Primero
        });
        lista.Add(new Estudiante {
            Dni = "77777777V", Nombre = "Sonia", Apellidos = "Ruiz", Calificacion = 5.0, Ciclo = Ciclo.DAW,
            Curso = Curso.Segundo
        });
        lista.Add(new Estudiante {
            Dni = "88888888E", Nombre = "Jorge", Apellidos = "Sánchez", Calificacion = 2.0, Ciclo = Ciclo.ASIR,
            Curso = Curso.Primero
        });
        lista.Add(new Estudiante {
            Dni = "99999999X", Nombre = "Laura", Apellidos = "Fernández", Calificacion = 10.0, Ciclo = Ciclo.ASIR,
            Curso = Curso.Segundo
        });
        lista.Add(new Estudiante {
            Dni = "00000000M", Nombre = "Carlos", Apellidos = "Jiménez", Calificacion = 5.5, Ciclo = Ciclo.ASIR,
            Curso = Curso.Segundo
        });

        lista.Add(new Docente {
            Dni = "12345678Z", Nombre = "Jose Luis", Apellidos = "González", Experiencia = 15,
            Especialidad = Modulos.Programacion, Ciclo = Ciclo.DAW
        });
        lista.Add(new Docente {
            Dni = "23456789D", Nombre = "Beatriz", Apellidos = "Sánchez", Experiencia = 10,
            Especialidad = Modulos.BasesDatos, Ciclo = Ciclo.DAW
        });
        lista.Add(new Docente {
            Dni = "34567890V", Nombre = "Carlos", Apellidos = "Pérez", Experiencia = 8, Especialidad = Modulos.Entornos,
            Ciclo = Ciclo.DAM
        });
        lista.Add(new Docente {
            Dni = "45678901H", Nombre = "Marta", Apellidos = "García", Experiencia = 12,
            Especialidad = Modulos.LenguajesMarcas, Ciclo = Ciclo.DAW
        });
        lista.Add(new Docente {
            Dni = "56789012L", Nombre = "Raúl", Apellidos = "Martínez", Experiencia = 5,
            Especialidad = Modulos.Programacion, Ciclo = Ciclo.ASIR
        });

        return lista;
    }
}
