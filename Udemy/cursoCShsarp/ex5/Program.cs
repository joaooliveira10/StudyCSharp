using System;

namespace Course
{
    class Program
    {
        static string login = null, yn = null;
        static string[] y = { "sim", "Sim", "SIM" };
        static int password = 2002;
        static void Main(string[] args)
        {
            Console.WriteLine("Ola, Seja Bem Vindo! Voce ja possui um usuario? Sim/Nao");
            yn = Console.ReadLine();
            if (yn == y[0])
            {
                Console.WriteLine("Otimo então vamos acessar!");
            }
            else
            {
                Console.WriteLine("Infellizmente voce não pode acessar!");
            }
            Console.WriteLine("Digite seu usuario: ");
            login = Console.ReadLine();
            Pass();
            do
            {
                Validade();
                if (true)
                    Console.WriteLine($"Ola {login}, seja bem vindo!");
            } while (false);


        }
        static void Pass()
        {
            Console.WriteLine("Digite sua senha: ");
            password = int.Parse(Console.ReadLine());
        }
        static void Validade()
        {
            do
            {
                if (password == 2002)
                    Console.WriteLine($"Ola {login}, seja bem vindo!");
                else
                    Console.WriteLine("Senha incorreta!");
                Pass();
            } while (password != 2002);

        }
    }
}