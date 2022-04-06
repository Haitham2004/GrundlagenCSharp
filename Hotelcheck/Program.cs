using System;

namespace Hotelcheck
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] zimmernummer = { 23, 32, 45, 3 };
            string[] vorname = { "Paul, Ringo, John, George" };
            string[] nachname = { "McCartney, Starr, Lennon, Harrison" };
            short[] übernachtungen = { 4, 3, 1, 12 };
            double[] rechnungsbetrag = { 329.84, 247.38, 82.46, 989.52 };
            bool kundencheck = false;
            int i = 0;
            //string eingabe_string;
            //short eingabe_short = 0;
            //bool Falsch = false;
            bool flag = false;
            do
            {
                Console.WriteLine("Bitte geben Sie die Zimmernummer oder Nachname");
                string eingabe_string = Console.ReadLine();
                short eingabe_short;



                flag = short.TryParse(eingabe_string, out eingabe_short);



                if (flag == true)
                {
                    var daten = GetData(eingabe_short, zimmernummer, vorname, nachname, übernachtungen, rechnungsbetrag);



                    if (daten.Item1 == true)
                    {

                    }
                    else
                    {
                        Console.WriteLine("kein Item gefunden");
                    }



                }
                else
                {
                    var daten = GetData(eingabe_string, zimmernummer, vorname, nachname, übernachtungen, rechnungsbetrag);
                    if (daten.Item1 == true)
                    {



                    }
                    else
                    {
                        Console.WriteLine("kein Item gefunden");



                    }



                }



            } while (flag == true);





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
