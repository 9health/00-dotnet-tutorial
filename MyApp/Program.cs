
// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);

            int s;

            s = 0;

            for ( int i = 1; i <= 10; i++ ) {
              s = s + i;
            }

            Console.WriteLine("Sum from 1 to 10 is " + s);
        }
    }
}

