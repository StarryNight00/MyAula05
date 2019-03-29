using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número");
            string aux = Console.ReadLine();
            int n = Convert.ToInt32(aux);
            int p = n;

            Fibonacci(p);

            Console.WriteLine(n + " está na posição " + p + " na sequência de Fibonacci.");
        }

        static int Fibonacci(int n)
        {
            n = 1;
            return n;
        }
    }
}
