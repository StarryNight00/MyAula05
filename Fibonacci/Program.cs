using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número");
            string aux = Console.ReadLine();
            int inp = Convert.ToInt32(aux);

            int pos = Fibonacci(inp);

            Console.WriteLine("A posição indicada tem contido o número " + pos + " na sequência de Fibonacci.");
        }

        static int Fibonacci(int n)
        {
            int res; //resultado do pedido

            if (n <= 2)
            {
                res = 1;
            }
            else
            {
                res = Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            return res;
        }
    }
}
