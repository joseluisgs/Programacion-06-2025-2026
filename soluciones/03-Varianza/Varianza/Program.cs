// See https://aka.ms/new-console-template for more information

using Varianza.Box;
using Varianza.Models;

Console.WriteLine("Hola Varianza!");

Box<Animal> animalBox = new Box<Animal>(new Animal("Buddy"));
Box<Perro> perroBox = new Box<Perro>(new Perro("Max", 5));

// No confundir con esto
Box<Animal> boxConAnimal = new Box<Animal>(new Perro("Rocky", 3));
var animalEnBox = boxConAnimal.GetValue();

// Tampoco puedo hacer esto, porque el tipo genérico es diferente
// Box<Animal> boxConPerro = perroBox;
// Que pasaría si yo ahora...
// boxConPerro.SetValue(new Gato("Mittens", 2));
//var perroEnBox = boxConPerro.GetValue(); // Error en tiempo de ejecución


// Pero, puedo hacer esto?
// No, porque Box<Animal> no es un subtipo de Box<Perro>
// Que pasaría si llamo a un metodo de perro en el Box de Animal?
// Box<Perro> boxConAnimal = animalBox;
//var perroEnBox = boxConAnimal.GetValue();


// Puedo hacer esto?
// No, porque Box<Animal> no es un supertipo de Box<Perro>
// Box<Animal> boxConPerro = new Box<Perro>(new Perro("Rocky", 3));

// No, porque Box<Perro> no es un subtipo de Box<Animal>
// Box<Perro> boxConAnimal = new Box<Animal>(new Perro("Rocky"));


// Esto sí es posible gracias a la covarianza
// Me asegura que solo voy a producir T, no consumirlo
ICovarianteBox<Perro> covarianteBox = new CovarianteBox<Perro>(new Perro("Fido", 4));
ICovarianteBox<Animal> covarianteBoxAnimal = covarianteBox; //
var animalDesdeCovariante = covarianteBoxAnimal.GetValue();
Console.WriteLine($"El nombre del animal desde la caja covariante es: {animalDesdeCovariante.Nombre}");

// Pero no puedo hacer esto, porque la caja covariante no puede consumir T
IContravarianza<Animal> contravarianteBox = new ContravarianteBox<Animal>(new Animal("Luna"));
IContravarianza<Perro> contravarianteBoxPerro = contravarianteBox; //
contravarianteBoxPerro.Consumir(new Perro("Rex", 6));
Console.WriteLine("Se consumió un perro en la caja contravariante.");


