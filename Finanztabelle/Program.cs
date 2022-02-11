using System;



namespace Finanztabelle
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine(" ");



            double k = 0, z = 0, Kn = 0, B = 0, KZ = 0, Z=0;
            short j = 0;



            Console.WriteLine("Geben Sie Ihre Kapital");
            k = Convert.ToDouble(Console.ReadLine());
            Kn = k;
            Console.WriteLine("Geben Sie Ihre Jahre");
            j = Convert.ToInt16(Console.ReadLine());



            Console.WriteLine("Geben Sie Ihre Zinsen");
            z = Convert.ToDouble(Console.ReadLine());



            string jahre = "Jahre";
            Console.WriteLine($"{"Jahre",4} {"Guthaben",10} {"Zinsen",8} {"K.zinsen",10} {"Bilanz",8} ");



            for (int i = 1; i <= 45; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();



            for (int jahr = 1; jahr <= j; jahr++)
            {
                Z = Kn * (z / 100);
                B = Kn + Z;
                KZ = KZ + Z;

                Console.WriteLine($"{jahr,4} {Kn,10:F2} {Z,8:F2} {KZ,10:F2} {B,8:F2} ");
                Kn = Kn + Z;
            }
            for (int i = 1; i <= 45; i++)
            {
                Console.Write("-");
            }
            

            Console.ReadKey();



        }



    }
}