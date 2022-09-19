using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.Write("Digite o valor do raio ");
            double raio = double.Parse(Console.ReadLine());
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine($"Area {area.ToString("F4")}");
        }
    }
}