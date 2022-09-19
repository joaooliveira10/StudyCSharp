namespace Course
{
    class Program
    {
        static int[] itemID = { 1, 2, 3, 4, 5 };
        static int quantidade;
        static string[] itemNome = { "Cachorro Quente", "X-Salada", "X-Bacon", "Torrada Simples", "Refrigerante" };
        static decimal[] itemValor = { 4.00m, 4.50m, 5.00m, 2.00m, 1.50m };
        static decimal soma = 0;
        static string ce;

        static void Main(string[] args)
        {
            ConsoleKeyInfo escape;

            Menu();

            Selecao();

            decimal a = Selecao();

            Console.WriteLine("Deseja mais alguma coisa? SIM digite 's' se NAO digite 'n': ");
            ce = Console.ReadLine();

            if (ce == "s")
            {
                Menu();
                Selecao();
                Console.WriteLine($"O valor total é de R${Selecao() + a} ");
            }
            else
            {
                Console.WriteLine($"O valor total é de R${Selecao()}");
            }



            static void Menu()
            {
                Console.WriteLine($@"Menu 

    Codigo          Especificao          Preco   
    {itemID[0]}             {itemNome[0]}        R${itemValor[0]}
    {itemID[1]}             {itemNome[1]}               R${itemValor[1]}
    {itemID[2]}             {itemNome[2]}                R${itemValor[2]}
    {itemID[3]}             {itemNome[3]}        R${itemValor[3]}
    {itemID[4]}             {itemNome[4]}           R${itemValor[4]}");

                Console.WriteLine("Digite o codigo do item que deseja: ");
                itemID[0] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite qual a quantidade que deseja: ");
                quantidade = int.Parse(Console.ReadLine());
            }

            static decimal Selecao()
            {
                if (itemID[0] == 1)
                    soma = itemValor[0] * quantidade;

                else if (itemID[0] == 2)
                    soma = itemValor[1] * quantidade;

                else if (itemID[0] == 3)
                    soma = itemValor[2] * quantidade;

                else if (itemID[0] == 4)
                    soma = itemValor[3] * quantidade;

                else if (itemID[0] == 5)
                    soma = itemValor[4] * quantidade;

                return soma;
            }

            escape = Console.ReadKey();
            while (escape.Key == ConsoleKey.Escape) ;
        }
    }
}