using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = 2.5;
            Console.WriteLine(--x); // out 1.5
            //x = 2.5;
            Console.WriteLine(x--); //1.5
            Console.WriteLine(x); //0.5        

           

        }
    }
}
