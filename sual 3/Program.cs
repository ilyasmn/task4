using System;

namespace sual_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100000; i++)
            {


                int a = i;
               
                int sum2 = 0;
                int b = a;
                int f = a;
                int d;
                int e;
                int g;
                int n;
                int c = a % 10;
                bool state1 = false;
                bool state2 = false;
                while (a > 0)
                {
                    e = a % 10;
                    a = a / 10;

                    if (e == 5 )
                    {
                        state1 = true;
                        break;

                    }


                    while (f > 0)
                    {
                        g = f % 10;
                        f = f / 10;

                        if (g !=c)
                        {
                            state2 = true;
                            break;

                        }
                    }
                    if (state1 == false && state2 == false)
                    {
                        while (b > 0)
                        {
                            n = b % 10;
                            sum2 = sum2 + n;
                            b = b / 10;
                        }
                        if (sum2 > 5)
                        {
                            Console.WriteLine(i);

                            break;


                        }
                    }
                }

            }
        }
    }

}









