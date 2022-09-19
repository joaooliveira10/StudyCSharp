using System;

namespace Course
{
    class Program
    {
        static double a, b, c, delta;
        static void Main(string[] args)
        {
            Console.WriteLine(@"Vamos fazer uma equacao do segundo grau! (ax^2 + bx + c = 0) 
");
            do
            {
                Console.WriteLine(@"Digite um valor para a: 
");
                a = double.Parse(Console.ReadLine());
                if (a == 0)
                    Console.WriteLine(@"ERRO o valor de a nao pode ser 0
");
            }
            while (a == 0);
            Console.WriteLine(@"Digite um valor para b: 
");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Digite um valor para c: 
");
            c = double.Parse(Console.ReadLine());
            double delta = Math.Pow(b, 2) - (4 * a * c);
            Console.WriteLine($@"O valor da equacao de delta é: {delta}
");
            if (delta < 0)
            {
                Console.WriteLine(@"ERRO o valor de DELTA nao pode ser NEGATIVO
");
                Console.WriteLine(@"Impossivel calcular
");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($@"O valor de x' é = {x1.ToString("F4")}
");
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($@"O valor de x'' é = {x2.ToString("F4")}
");
            }
        }
    }
}