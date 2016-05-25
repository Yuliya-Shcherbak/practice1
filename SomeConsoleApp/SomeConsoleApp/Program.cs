using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SomeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SomeClass.SayHello());
            Console.WriteLine("New number is: {0}", SomeClass.PrintSomeNumber());
            Console.ReadKey();
        }
    }

    class SomeClass
    {
        public static int PrintSomeNumber()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 1000);
            return num;
        }

        public static string SayHello()
        {
            return "Hello World!";
        }
    }
}
