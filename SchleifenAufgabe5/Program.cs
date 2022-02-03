using System;

namespace SchleifenAufgabe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie eine Zahl ein: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = -x; i <= x; i = i + 2) 
            {
                Console.Write("{0,5}", i);
            }
        }
    }
}
