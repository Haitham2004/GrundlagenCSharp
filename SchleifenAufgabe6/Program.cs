using System;

namespace SchleifenAufgabe6
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingabe;
            do
            {
                Console.WriteLine("Geben Sie eine Zahl ein");
                eingabe = Convert.ToInt32(Console.ReadLine());

            } while (eingabe != 0);
        }
    }
    }

