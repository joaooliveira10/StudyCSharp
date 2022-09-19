using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca, quantidadePeca;
            decimal valorPeca, total;

            Console.Write("Digite o codigo da primeira peça: ");
            codigoPeca = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantiaade que deseja da primeira peça: ");
            quantidadePeca = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da primeira peça: ");
            valorPeca = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o codigo da segunda peça: ");
            codigoPeca = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantiaade que deseja da primeira peça: ");
            quantidadePeca = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da primeira peça: ");
            valorPeca = decimal.Parse(Console.ReadLine());

            decimal total = valorPeca.1 * quantidadePeca.1 + valorPeca.2 + quantidadePeca.2;

            Console.Write($"O valor a pagar é: R${total}");

        }
    }
}