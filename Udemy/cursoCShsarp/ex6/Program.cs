using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de N: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine($@"Digite os valores de X pela quantidade de valores N escolhido ""{N}"" : ");

            int[] x = new int[N];

            for (int j = 0; j < N; j++)
            {
                Console.Write("Valor: #{0}: ", j + 1);
                int X = int.Parse(Console.ReadLine());
                x[j] = X;
            }
            var a = 0;
            var b = 0;
            for (int i = 0; i < N; i++)
            {
                if (x[i] >= 10 && x[i] <= 20)
                    a++;
                if (x[i] < 10 || x[i] > 20)
                    b++;
            }
            Console.WriteLine($"{a} in");
            Console.WriteLine($"{b} out");
        }
    }
}