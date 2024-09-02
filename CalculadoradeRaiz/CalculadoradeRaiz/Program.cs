using System;

namespace CalculadoradeRaiz
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("---------------------");
            Console.WriteLine("Calculadora de Raízes");
            Console.WriteLine("---------------------");

            int num = 0;
            Console.Write("Número = ");
            int.TryParse(Console.ReadLine(), out num);

            double rq = Math.Sqrt(num);
            double rc = Math.Cbrt(num);


            Console.WriteLine($"A raíz quadrada de {num} é {rq:F2}");
            Console.WriteLine($"A raíz cúbica de {num} é {rc:F2}");
            Console.ReadKey();
        }
    }
}