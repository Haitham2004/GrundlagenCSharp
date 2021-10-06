using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungKlassenarbeit1
{
    class TemperaturUmrechner
    {
        /* Um diese Methode aufzurufen, gehen Sie folgendemaßen for:
            - Legen Sie ' UebungKlassenarbeit1 als Startprojekt fest. 
            - Rufen Sie 'TemperaturUmrechner.TempUmrechner();' in der Methode 'main' in 'Program' auf
            - Starten Sie den Debugger*/
        public static void TempUmrechner()
        {
            Console.WriteLine("Celsius nach Kelvin C");
            Console.WriteLine("Celsius nach Fahrenheit E");
            Console.WriteLine("Kelvin nach Celsius K");
            Console.WriteLine("Kelvin nach Fahrenheit L");

            string skala = Console.ReadLine().ToUpper();

            if (skala == "C")
            {
                Console.WriteLine("Bitte Temperatur in Celsius ein");
                double Celsius = Convert.ToDouble(Console.ReadLine());
                double ergebnis = Celsius + 273.15;
                Console.WriteLine(ergebnis);
            }

            else if (skala == "E")
            {
                Console.WriteLine("Bitte Temperatur Celsius ein");
                double Celsius = Convert.ToDouble(Console.ReadLine());
                double ergebnis = (Celsius * 9 / 5) + 32;
                Console.WriteLine(ergebnis);

            }

            else if (skala == "K")
            {
                Console.WriteLine("Bitte Temperatur Kelvin ein");
                double Kelvin = Convert.ToDouble(Console.ReadLine());
                double ergebnis = Kelvin - 273.15;
                Console.WriteLine(ergebnis);

            }

            else if (skala == "L")
            {
                Console.WriteLine("Bitte Temperatur Kelvin ein");
                double Kelvin = Convert.ToDouble(Console.ReadLine());
                double ergebnis = 9 / 5 * (Kelvin - 273.15) + 32;
                Console.WriteLine(ergebnis);
            }
            else
                Console.WriteLine("");
        }
    }
}