using System;

namespace SchleifenAufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)//i-- -> i-=1 -> i=i-1
            {
                Console.WriteLine("Das Quadrat von {0} ist {1}", i, i * i);
            }
        }
    }
}