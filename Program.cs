using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite alguma temperatura em graus celsius, e veja ela se transformar em fahrenheit...");
            string celsius = Console.ReadLine();

            Double C = Convert.ToDouble(celsius);
            Double F = C * 1.8 + 32;

            Console.WriteLine("A temperatura em Fahrenheit é" + " " + F);
            

        }
    }
}
