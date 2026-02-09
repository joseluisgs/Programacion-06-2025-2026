// See https://aka.ms/new-console-template for more information

using Constraints.Genericos;
using Constraints.Models;

Console.WriteLine("Hola Mundo desde Constraints!");

var cajaJugador = new Box<Jugador>(new Jugador("Carlos", 10));
cajaJugador.Contenido.Jugar();

// No se puede hacer esto porque Perro no hereda de Persona
// var cajaPerro = new BoxPersonas<Perro>(new Perro());
//var cajaInt = new BoxPersonas<int>(5);

// Si se puede hacer esto porque Jugador hereda de Persona
var cajaJugador2 = new BoxPersonas<Jugador>(new Jugador("Ana", 7));
var cajaEntrenador = new BoxPersonas<Entrenador>(new Entrenador("Luis", 8));

// No puedo hacer esto porque Persona no implementa IJugador
// var cajaPersona = new BoxIJugadores<Persona>(new Persona("Miguel"));
var cajaJugador3 = new BoxIJugadores<Jugador>(new Jugador("Sofia", 9));
var cajaPerro2 = new BoxIJugadores<Perro>(new Perro());


// No puedo hacer esto, porque Jugador no implementa IAlumno
// var cajaX3 = new BoxJugadorEstudiante<Jugador>(new Jugador("Pedro", 11));

var cajaX4 = new BoxJugadorEstudiante<Alumno>(new Alumno("Marta", 12));
cajaX4.Contenido.Estudiar();
cajaX4.Contenido.Jugar();
var cajaX5 = new BoxJugadorEstudiante<Gato>(new Gato());
cajaX5.Contenido.Estudiar();
cajaX5.Contenido.Jugar();

// Y asi con todos
// Falla porque Perro no es por valor
//var cajaX6 = new BoxStruct<Alumno>(new Alumno("Laura", 13));
var cajaX7 = new BoxStruct<int>(25);
var cajaX8 = new BoxStruct<Coordenada>(new Coordenada(10, 20));

// No puedo hacer esto, porque no hay constructor vacio
//var cajaX9 = new BoxNew<Jugador>(new Jugador("Andres", 14));
var cajaX10 = new BoxNew<Coordenada>(new Coordenada(30, 40));
var cajaX11 = new BoxNew<Perro>(new Perro());
var cajaX12 = new BoxNew<Dios>(new Dios());