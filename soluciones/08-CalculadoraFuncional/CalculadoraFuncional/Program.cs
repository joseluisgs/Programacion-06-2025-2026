// See https://aka.ms/new-console-template for more information

using CalculadoraFuncional;

var res = Calculadora.Sumar(2, 3);
Console.WriteLine($"El resultado de la suma es: {res}");
res = Calculadora.Restar(5, 2);

// Funcional, la función es ciudadano de primera clase :)
// Funcional, puedo pasarle una función que ya exista
res = CalculadoraFunc.Operacion(2, 3, Sumar);

// Pudo almacenar las funciones en variables
Func<int, int, int> restita = Restar;
var multipli = Multiplicar;
Console.WriteLine($"El resultado de la resta es: {res}");
res = CalculadoraFunc.Operacion(5, 2, restita);
Console.WriteLine($"El resultado de la multiplicacion es: {res}");
res = CalculadoraFunc.Operacion(4, 3, multipli);
Console.WriteLine($"El resultado de la multiplicacion es: {res}");

// O puedo usar funciones anónimas (lambda)
res = CalculadoraFunc.Operacion(3, 4, (a, b) => a * b);
res = CalculadoraFunc.Operacion(10, 2, (a, b) => a / b);

// Gracias a las lambdas podemos definir funciones sobre la marcha
// Que cumplan el contrato de la firma Func<int, int, int>
res = CalculadoraFunc.Operacion(10, 3, (a, b) => (int)Math.Pow(a, b));
Console.WriteLine($"El resultado de la operacion es: {res}");
res = CalculadoraFunc.Operacion(10, 2, (a, b) => a % b);
Console.WriteLine($"El resultado de la operacion es: {res}");

// O programar cosas mas complejas, en el fondo es solo una función sobre la marcha
res = CalculadoraFunc.Operacion(20, 8, (a, b) => {
    if(a<b) 
        return b - a;
    return a * b;
});
Console.WriteLine($"El resultado de la operacion es: {res}");


Dictionary<string, Func<int, int, int>> calculadora =
    new Dictionary<string, Func<int, int, int>>
    {
        { "suma", Sumar },
        { "resta", Restar },
        { "multiplicacion", Multiplicar },
        { "division", (a, b) => a / b },
        {"modulo", (a, b) => a % b }
    };

int a = 20, b = 5;
foreach (var operacion in calculadora)
{
    int resultado = operacion.Value(a, b);
    Console.WriteLine($"{operacion.Key}: {a} y {b} = {resultado}");
}


// Funcion normal
int Sumar(int a, int b) => a + b;
int Restar(int a, int b) => a - b;
int Multiplicar(int a, int b) => a * b;