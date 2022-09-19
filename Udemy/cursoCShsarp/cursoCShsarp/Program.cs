using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] codigoPeca = { 0 , 0 }, quantidadePeca = { 0 , 0 };
            decimal[] valorPeca = { 0 , 0 };
            decimal total;

            Console.Write("Digite o codigo da primeira peça: ");
            codigoPeca[0] = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade que deseja da primeira peça: ");
            quantidadePeca[0] = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da primeira peça: ");
            valorPeca[0] = decimal.Parse(Console.ReadLine());

            Console.WriteLine($@"ID Item 1:  {codigoPeca[0]} , quantidade do Item 1: {quantidadePeca[0]} , valor do Item 1: {valorPeca[0]}");

            Console.Write("Digite o codigo da segunda peça: ");
            codigoPeca[1] = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade que deseja da segunda peça: ");
            quantidadePeca[1] = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da segunda peça: ");
            valorPeca[1] = decimal.Parse(Console.ReadLine());

            Console.WriteLine($@"ID Item 2: {codigoPeca[1]} , quantidade do Item 2: {quantidadePeca[1]} , valor do Item 2: {valorPeca[1]}");

            total = (valorPeca[0] * quantidadePeca[0]) + (valorPeca[1] + quantidadePeca[1]);

            Console.Write($"O valor a pagar é: R${total}");

        }
    }
}