using System;

namespace sual_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123456789;
            int odd = 0, even = 0;
            while (a != 0)
            {
                int rem = a % 10;
                if (rem % 2 == 1)
                  odd++;
                else
                    even++;
                a /= 10;
            }
            Console.WriteLine(odd);
    




        }
    }
}


