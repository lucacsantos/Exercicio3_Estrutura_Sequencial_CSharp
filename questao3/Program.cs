using System;

namespace questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int diferenca;
            Console.WriteLine("diggite quatro numeros inteiros, um embaixo do outro:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}
