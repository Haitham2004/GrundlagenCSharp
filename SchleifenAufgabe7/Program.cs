using System;

namespace SchleifenAufgabe7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie einen Wert für 'n' ein!");

            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Die Summe lautet {0}", sum);


        }

    }
}
