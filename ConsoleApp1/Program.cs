using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            B b = new B("demo");
        }
        internal class A
        {
            public A(string name)
            {
                Console.WriteLine($"new ins {name}");
            }
        }

        internal class B : A
        {
            public B(string n)
            : base(n)
            {

            }
    
        

        }
    }
    
}
