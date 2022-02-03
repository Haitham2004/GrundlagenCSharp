using System;

namespace SchleifenAufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 50; i >= 0; i--)//i-- -> i-=1 -> i=i-1
            {
                Console.WriteLine(i);
            }
        }
    }
}