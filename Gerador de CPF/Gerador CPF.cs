using System;

namespace Gerador_de_CPF
{
    class GeradorCPF
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a quantidade de CPF a ser gerado:");
            int numGerar = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i < numGerar; i++)
            {
                int n1 = rnd.Next(10);
                int n2 = rnd.Next(10);
                int n3 = rnd.Next(10);
                int n4 = rnd.Next(10);
                int n5 = rnd.Next(10);
                int n6 = rnd.Next(10);
                int n7 = rnd.Next(10);
                int n8 = rnd.Next(10);
                int n9 = rnd.Next(10);
                int somatorio1 = n1 * 10 + n2 * 9 + n3 * 8 + n4 * 7 + n5 * 6 + n6 * 5 + n7 * 4 + n8 * 3 + n9 * 2;
                int digito1 = 11 - (somatorio1 % 11);


                if ((somatorio1 % 11) < 2)
                {
                    digito1 = 0;
                }

                int somatorio2 = n1 * 11 + n2 * 10 + n3 * 9 + n4 * 8 + n5 * 7 + n6 * 6 + n7 * 5 + n8 * 4 + n9 * 3 + digito1 * 2;
                int digito2 = 11 - (somatorio2 % 11);

                if ((somatorio2 % 11) < 2)
                {
                    digito2 = 0;
                }

                string numeroPuro = string.Concat(n1, n2, n3, n4, n5, n6, n7, n8, n9, digito1, digito2);
                Console.WriteLine(numeroPuro);
            };
            Console.ReadLine();
        }
    }
}

