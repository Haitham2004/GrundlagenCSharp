using System;

namespace SchleifenAufgabe10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello... geben Sie eine Größe für den Baum ein");

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                #region Zeile

                for (int q = 1; q <= n - i; q++)
                    Console.Write(" ");

                for (int q = 1; q <= 1 + ((i - 1) * 2); q++)
                    Console.Write("*");
                Console.WriteLine();

                #endregion
            }
        }
    }
}
