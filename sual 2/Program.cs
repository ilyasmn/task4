using System;

namespace sual_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
              

            for (int i = 1; i < 1000; i++)
            {
                
                
                    int a = i; int sum1 = 0; int b; int sum2 = 0; int eded;
                    while (a > 0)
                    {
                       
                        b = a % 10;
                        sum1 = (sum1 * 10) + b;
                        sum2 = sum2 + b;
                        a = a / 10;
                    }


                    if (sum2 > 10 && i == sum1 && i/100!=3 && i%10!=3 && i%100/10!=3)
                    {
                        eded = i;
                        Console.WriteLine(eded);
                    }
                  
                }

            }
            
        }
            
        }
    

