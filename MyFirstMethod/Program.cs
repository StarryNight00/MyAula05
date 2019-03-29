using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //1a vez
            string aux1 = Console.ReadLine();
            int nCount1 = Convert.ToInt32(aux1);
            CountToN(nCount1);

            string aux2 = Console.ReadLine();
            int nCount2 = Convert.ToInt32(aux2);
            CountToN(nCount2);

            CountTo10();
        }

        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }
        static void CountTo10()
        {
            CountToN(10);

            //for (int i = 1; i <= 10; i++)
                //Console.WriteLine(i);
        }
    }
}
