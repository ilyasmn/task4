using System;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            int[] ededler = new int[7];

            for (int i = 0; i < ededler.Length; i++)
            {
                ededler[i] = a.Next(1, 1000);
            }
            foreach (var item in ededler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------");
            int temp;
            for (int i = 0; i < ededler.Length; i++)
            {
                for (int j = i+1; j <ededler.Length; j++)
                {
                    if (ededler[i]>ededler[j])
                    {
                        temp = ededler[i];
                        ededler[i] = ededler[j];
                        ededler[j] = temp;
                    }
                }
                
            }
            foreach (var item in ededler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
