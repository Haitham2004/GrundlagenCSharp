using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklariere zwei Variablen und initialisiere sie mit 0.
            int num1 = 0;
            int num2 = 0;

            //Gebe einen Titel aus
            Console.WriteLine("Taschen Reschner");

            //Fordere den Benutzer auf die erste Zahl einzugeben.
            Console.WriteLine("Tippen Sie eine Zahl ein und drücken Sie Enter");
            double eingnum1 = Convert.ToDouble(Console.ReadLine());

            //Fordere den Benutzer auf die weitere Zahl einzugeben.
            Console.WriteLine("wähl eine zahl und dück Enter");
            double eingnum2 = Convert.ToDouble(Console.ReadLine());

            //Fordere den Benutzer auf ein Option zu wählen(Multiplikation, Division , Addition, Subtraktion).
            Console.WriteLine("Wähl eine Option von der Liste");
            Console.WriteLine("\ta - Addieren");
            Console.WriteLine("\ts - Subtrahieren");
            Console.WriteLine("\tm - Multiplizieren");
            Console.WriteLine("\td - Dividieren");
            Console.WriteLine("Wähle eine Option");

            string auswahl = Console.ReadLine().ToLower();
            double ergbnis;

            if (auswahl == "a")
            {
                ergbnis = eingnum1 + eingnum2;
            }

            else if (auswahl == "s")
            {
                ergbnis = eingnum1 - eingnum2;
            }

            else if (auswahl == "m")
            {
                ergbnis = eingnum1 * eingnum2;
            }

            else if (auswahl == "d")
            {
                ergbnis = eingnum1 / eingnum2;
            }

            else
                Console.WriteLine("Auswahl nicht Korrekt");

            ergbnis = double.NaN;
            Console.WriteLine("Das Ergbnis ist:(0,10)",ergbnis);

            //Warte bis der Benutzer reagiert bevor du die Konsole Schließen.
            Console.WriteLine("Klick eine Taste um den Taschen Reschner zu beenden...");
            Console.ReadKey();

        }
    }
}
