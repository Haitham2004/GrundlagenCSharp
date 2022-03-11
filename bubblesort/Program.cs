using System;

namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            int n = 4;
            int[] Daten ={45, 10, 15, 4};

            foreach(int element in Daten)
            {
                Console.Write(" "+element);
            }
            Console.WriteLine();

            do
            {
                flag = true;
                for (int index = 0; index < n - 1; index++)
                {


                    if (Daten[index] > Daten[index + 1])
                    {
                        int buffer = Daten[index + 1];
                        //{45, 10, 15, 4}
                        Daten[index + 1] = Daten[index];
                        //{45, 45, 15, 4}
                        Daten[index] = buffer;
                    }
                }
            } while(flag);

            
            
            //

            foreach (int element in Daten)
            {
                Console.Write(" " + element);
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
