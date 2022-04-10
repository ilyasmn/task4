using System;

namespace sual_5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int a = 456654;
            int sum = 0;
            int b = a;
            
            int qaliq;
            int ters=0;
        
            while (a > 0)
            {
                qaliq = a % 10;
                sum = sum + qaliq;

                ters = ters * 10 + qaliq;
                a = a / 10;
            }
                Console.WriteLine(ters);
            if (ters==b)
            {
                int z = int.Parse(1 + b.ToString() + 1);
                Console.WriteLine($"        {z} daxil edilmis eded polindromdur");

            }
            else
            {
                Console.WriteLine("yuxarida gosterilmis eded polindrom deyil");
            }

            




            




            }
    }
}
