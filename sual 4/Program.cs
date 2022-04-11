using System;

namespace sual_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0; int qaliq = 0; 
            for (int i = 1; i < 1000; i++)
            {                                   
                if (i % 11 == 0)
                { int a = i; int sum = 0;
                    while (a > 0)
                    {  qaliq = a % 10;
                         sum = sum + qaliq;
                           a = a / 10;
                    }
                    if (sum > 11)
                    { count++;
                        if (count == 11)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }
    }
}

   
    








          













  