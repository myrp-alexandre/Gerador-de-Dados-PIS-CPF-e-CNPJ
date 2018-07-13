using System;

namespace Gerador_de_CNPJ
{
    class GeradorCNPJ
    {
        static void Main(string[] args)
        {

            int Mod(int dividendo, int divisor)
            {
                return (dividendo - (dividendo / divisor) * divisor);
            }

            Console.WriteLine("Digite a quantidade de CNPJ a ser gerado:");
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
                int n9 = 0;
                int n11 = 0;
                int n10 = 0;
                int n12 = 1;
                int d1 = n12 * 2 + n11 * 3 + n10 * 4 + n9 * 5 + n8 * 6 + n7 * 7 + n6 * 8 + n5 * 9 + n4 * 2 + n3 * 3 + n2 * 4 + n1 * 5;
                d1 = 11 - (Mod(d1, 11));

                if (d1 >= 10) d1 = 0;
                int d2 = d1 * 2 + n12 * 3 + n11 * 4 + n10 * 5 + n9 * 6 + n8 * 7 + n7 * 8 + n6 * 9 + n5 * 2 + n4 * 3 + n3 * 4 + n2 * 5 + n1 * 6;
                d2 = 11 - (Mod(d2, 11));
                if (d2 >= 10) d2 = 0;


                string cnpj = string.Concat(n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, d1, d2);
                Console.WriteLine(cnpj);
            };
            Console.ReadLine();
        }
    }
}
