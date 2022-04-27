using System;

namespace Hotelcheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Haitham Mansour und Jowan
            short[] zimmernummer = { 23, 32, 45, 3 };
            string[] vorname = { "Paul", "Ringo", "John", "George" };
            string[] nachname = { "McCartney", "Starr", "Lennon", "Harrison" };
            short[] übernachtungen = { 4, 3, 1, 12 };
            double[] rechnungsbetrag = { 329.84, 247.38, 82.46, 989.52 };
            bool kundencheck = false;
            int i = 0;
            bool flag = false;
            do
            {
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                 "                              >>> Hotel-Check In <<<\n" +
                                 "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("Herzlich Willkommen");
                Console.WriteLine("Bitte geben Sie die Zimmernummer oder Nachname");
                Console.WriteLine("Exit tippen für out-Check");
                string eingabe_string = Console.ReadLine();
                short eingabe_short;
                
                if(eingabe_string=="Exit"|| eingabe_string == "exit")
                {
                    Console.WriteLine("------------------------------------------------------------------------------------\n" +
                "                              >>> Hotel-Check out <<<\n" +
                "------------------------------------------------------------------------------------\n\n");
                    Console.ReadKey();
                    Environment.Exit(0);
                }



                flag = short.TryParse(eingabe_string, out eingabe_short);
                



                if (flag == true)
                {
                    var daten = GetData(eingabe_short, zimmernummer, vorname, nachname, übernachtungen, rechnungsbetrag);


                    if(daten.Item1 == true)
                    {
                        short zimmernummer_gast  = daten.Item2;
                        string vorname_gast = daten.Item3;
                        string nachname_gast = daten.Item4;
                        short übernachtungen_gast = daten.Item5;
                        double rechnungsbetrag_gast = daten.Item6;

                        Console.WriteLine($"Zimmernummer:\t{zimmernummer_gast}\nVorname:\t{vorname_gast}\nNachname:\t{nachname_gast}\nÜbernachtungen:\t{übernachtungen_gast}\nRechnungsbetrag:\t{rechnungsbetrag_gast}\n");
                    }
                    else
                    {
                        Console.WriteLine("kein Daten gefunden");
                    }



                }
                else
                {

                    
                    var daten = GetData(eingabe_string, zimmernummer, vorname, nachname, übernachtungen, rechnungsbetrag);
                    if (daten.Item1 == true)
                    {

                        short zimmernummer_gast = daten.Item2;
                        string vorname_gast = daten.Item3;
                        string nachname_gast = daten.Item4;
                        short übernachtungen_gast = daten.Item5;
                        double rechnungsbetrag_gast = daten.Item6;

                        Console.WriteLine($"Zimmernummer:\t{zimmernummer_gast}\nVorname:\t{vorname_gast}\nNachname:\t{nachname_gast}\nÜbernachtungen:\t{übernachtungen_gast}\nRechnungsbetrag:\t{rechnungsbetrag_gast}\n");
                    }
                    else
                    {
                        Console.WriteLine("kein Daten gefunden");



                    }



                }

                Console.ReadKey();
                Console.Clear();

            } while (true);





        }
        static (bool, short, string, string, short, double) GetData(short diff, short[] zn, string[] vn, string[] nn, short[] ün, double[] rb)
        {
            bool flag = false;
            int index = 0;
            for (int i = 0; i < zn.Length; i++)
            {
                if (diff == zn[i])
                {
                    index = i;
                    flag = true;



                }
            }



            return (flag, zn[index], vn[index], nn[index], ün[index], rb[index]);
        }
        static (bool, short, string, string, short, double) GetData(string diff, short[] zn, string[] vn, string[] nn, short[] ün, double[] rb)
        {
            bool flag = false;
            int index = 0;
            for (int i = 0; i < nn.Length; i++)
            {
                if (diff == nn[i])
                {
                    index = i;
                    flag = true;



                }
            }



            return (flag, zn[index], vn[index], nn[index], ün[index], rb[index]);
        }

    }
}