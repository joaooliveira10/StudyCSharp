using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca, quantidadePeca;
            decimal valorPeca, total;

            Console.Write("Digite o codigo da primeira pe�a: ");
            codigoPeca = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantiaade que deseja da primeira pe�a: ");
            quantidadePeca = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da primeira pe�a: ");
            valorPeca = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o codigo da segunda pe�a: ");
            codigoPeca = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantiaade que deseja da primeira pe�a: ");
            quantidadePeca = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da primeira pe�a: ");
            valorPeca = decimal.Parse(Console.ReadLine());

            decimal total = valorPeca.1 * quantidadePeca.1 + valorPeca.2 + quantidadePeca.2;

            Console.Write($"O valor a pagar �: R${total}");

        }
    }
}