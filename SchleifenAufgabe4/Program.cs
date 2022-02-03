using System;

namespace SchleifenAufgabe4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 10; i =i-10)//i-- -> i-=1 -> i=i-1
            {
                Console.Write( i );
            }
        }
    }

}