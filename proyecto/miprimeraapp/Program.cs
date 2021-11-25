using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String resp="";
    do
    {
        
    } while (resp=="si" || resp=="si");

    int Valor1 = 0;
    int Valor2 = 0;
    int Resultado = 0;

    Console.WriteLine("Calculadora T1");
    Console.WriteLine("1.- Para sumar");
    Console.WriteLine("2.- Para restar");
    Console.WriteLine("3.- Para multiplicar");
    Console.WriteLine("4.- Para dividir");
    Console.Write("Eliga Una Opcion:");
    resp=Console.ReadLine();

    String eleccion= Convert.ToString(resp);

    Console.WriteLine("Ingresa dos Valores");
    Console.Write("Primer Valor: ");
    Valor1 = int.Parse(Console.ReadLine());
    Console.Write("Segundo Valor: ");
    Valor2 = int.Parse(Console.ReadLine());
    Console.WriteLine();
    
    switch (eleccion)
    {
        case "1":
        Console.WriteLine("El resultado de la suma es:");
        Resultado = Valor1 + Valor2;
        Console.WriteLine("{0} + {1} = {2}", Valor1, Valor2, Resultado);
        break;

        case "2":
        Console.WriteLine("El resultado de la resta es:");
        Resultado = Valor1 - Valor2;
        Console.WriteLine("{0} - {1} = {2}", Valor1, Valor2, Resultado);
        break;

        case "3":   
        Console.WriteLine("El resultado de la divicion es:");
        Resultado = Valor1 / Valor2;
        Console.WriteLine("{0} / {1} = {2}", Valor1, Valor2, Resultado);
        break;

        case "4":
        Console.WriteLine("El resultado de la multiplicacion es:");
        Resultado = Valor1 * Valor2;
        Console.WriteLine("{0} * {1} = {2}", Valor1, Valor2, Resultado);
        break;
    }
        }
    }
}