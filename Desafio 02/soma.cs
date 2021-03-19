using System;

namespace Desafio_02
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número");
            int B = int.Parse(Console.ReadLine());

            int X =  A + B;

            Console.WriteLine("X = " + X);

        }
    }
}
