using System;



namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "";
            Console.WriteLine("Bitte geben sie ihre Text ein");
            name = (Console.ReadLine());




            Console.WriteLine("Bitte geben sie ihre durchläufe der Anzahl");
            int durchlauf = Convert.ToInt32(Console.ReadLine());




            int anzahl_zeichen = 0;



            anzahl_zeichen = ausgabeTextMalX(name, durchlauf);
            Console.Write("\nAnzahlder Buchstaben: {0}", anzahl_zeichen);
        }



        static int ausgabeTextMalX(string text, int n)
        {
            int anz_zeichen_text = text.Length;
            int anz_alle_zeichen = anz_zeichen_text * n;




            for (int i = 0; i < anz_zeichen_text; i++)
            {
                Console.WriteLine(text);
            }
            return anz_alle_zeichen;
        }

    }




}