using System;

namespace Datenfelder
{
    class Program
    {
        static void Main(string[] args)
        {
            int Note = 0, Klausuren = 20;

            double Notenschnitt = 0;
            string name = "Schüler";
            string[] namen = new string[Klausuren];

            int[] noten = new int[Klausuren];
            int anzahl = 0;

            for (int Schueler = 0; Schueler < Klausuren; Schueler++)
            {
                anzahl++;
                Console.WriteLine("{0} Note:",anzahl);
                Note = Convert.ToInt32(Console.ReadLine());

                noten[Schueler] = Note;
                Notenschnitt = Notenschnitt + Note;
                Console.Clear();

            }
            for (int AusgabeNote = 0; AusgabeNote < Klausuren; AusgabeNote++)
            {
                Console.WriteLine(namen[AusgabeNote] + "\tNote:" + noten[AusgabeNote]);

            }

            Console.WriteLine("Ihre Durchschnitt Beträgt:{0:F2}", Notenschnitt / Klausuren);
        }
    }
    }
