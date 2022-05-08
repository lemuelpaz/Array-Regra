using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Tarefa2 ou Tarefa3: ");

            switch (Console.ReadLine().ToLower()) { 
            case "tarefa2":
                Tarefa2();
                break;
            case "tarefa3":
                Tarefa3();
                break;     

            default:
                Console.WriteLine("Opção inválida!!");
                break;
            }
        }


        static void Tarefa2()
        {
            primeiro:
            int[] primeiroarray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] segundoarray = { 4, 6, 93, 7, 55, 32, 3 };

            var resultado = primeiroarray.Except(segundoarray);

            foreach (var num in resultado)
            {
                Console.WriteLine("\nResultado: " + num);
            }
        }


        static void Tarefa3()
        {
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            Func<int, bool> numImpar = num => num % 2 != 0;

            var resultado = numeros.Where(numImpar);

            foreach (var num in resultado)
            {
                Console.WriteLine("\nResultado: " + num);
            }
        }

    }
}
