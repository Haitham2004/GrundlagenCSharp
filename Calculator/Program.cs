using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklariere zwei Variablen und initialisiere sie mit 0.

            //Gebe einen Titel aus
            Console.WriteLine("Taschen Reschner");

            //Fordere den Benutzer auf die erste Zahl einzugeben.
            Console.WriteLine("Tippen auf ein zahl und Drück Enter bevor die SEK kommt");
            string eingnum1 = "";
            eingnum1 = Console.ReadLine();

            //Fordere den Benutzer auf die weitere Zahl einzugeben.
            Console.WriteLine("wähl eine zahl und dück Enter");
            string eingnum2 = "";
            eingnum2 = Console.ReadLine();

            //Fordere den Benutzer auf ein Option zu wählen(Multiplikation, Division , Addition, Subtraktion).
            Console.WriteLine("Wähl eine Option von der Liste");
            Console.WriteLine("\ta Addieren");
            Console.WriteLine("\tb Subtrahieren");
            Console.WriteLine("\tc Multiplizieren");
            Console.WriteLine("\td Dividieren");
            Console.WriteLine("Wähle eine Option");


            //Warte bis der Benutzer reagiert bevor du die Konsole Schließen.
            Console.WriteLine("Klick eine Taste um den Taschen Rescgner zu beenden...");
            Console.ReadKey();

        }
    }
}
