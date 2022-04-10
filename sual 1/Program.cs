using System;

namespace sual_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eded = 0;
            
            for (int i = 1; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    int a = i; int sum = 0;
                    while (a != 0)
                    {
                        sum += a % 10;
                        a /= 10;
                    }

                    if (sum == 6)
                    {
                        eded=i;
                    } 
                } 
            } Console.WriteLine(eded);
        }
    }


}
