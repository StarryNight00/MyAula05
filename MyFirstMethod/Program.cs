using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Main of the program, all of the main components of the program are here.
        /// </summary>
        /// <param name="args"></param>
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

        /// <summary>
        /// For cycle to print in console all numbers between 1 and n.
        /// </summary>
        /// <param name="n"> "n" is a variable type int.
        /// Can be set previously or inserted inside the ( ) </param>
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }

        /// <summary>
        /// For cycle to print in console all numbers between 1 and 10.
        /// Uses the CountToN method with an int 10 within ( ). 
        /// </summary>
        static void CountTo10()
        {
            CountToN(10);

            //for (int i = 1; i <= 10; i++)
                //Console.WriteLine(i);
        }
    }
}
