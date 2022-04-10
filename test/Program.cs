using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random a = new Random();
            int[] ededler = new int[7];

            for (int i = 0; i < ededler.Length; i++)
            {
                ededler[i] = a.Next(1,1000);
            }
            foreach (var item in ededler)
            {
                Console.WriteLine   (item);
            }


            int index = 0;
            int max = ededler[0];

            for (int i = 1; i < ededler.Length; i++)
            {
                if (max<ededler[i])
                {
                    max = ededler[i];
                    index =i;
                }
            }Console.WriteLine ($"indeks {++index}, max {max}");
        }

   

    }



	
}
