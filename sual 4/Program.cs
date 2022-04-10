using System;

namespace sual_4
{
    internal class Program
    {
        static void Main(string[] args)



           
            //11-e bolunub  11-ci eded hansidir?
        {
            
            for (int i = 1; i < 1000; i++)
            {

                int a = i;
                int f=a;
                int g;
                int h = a;
                int sum= 0;
                int b;
                int z;
                int sum2 = 0;
                bool state = false;
                bool state2 = false;
               int count = 0;



                while (a > 0)
                {
                    b = a % 10;
                    sum += b;
                   a /=10;

                    if (sum>11)
                    {
                        state = true;                      
                    }
                    while (h > 0)
                    {
                        z = h % 11;
                        h = h - 11;

                        if (z == 0)
                        {
                            state2 = true;
                            break;
                        }

                    }

                    if (state == true && state2==true )
                    {
                        count = 0;
                        while (f > 0)
                        {
                            f = f + 11;
                            count++;
                            if (count++ == 11)
                            {
                                Console.WriteLine(i);
                               
                            }




                        }
                    }
                }
               
            }
          













        }

        }
}
