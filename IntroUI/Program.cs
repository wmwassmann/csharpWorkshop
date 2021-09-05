using System;
using IntroLibrary;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel p = new PersonModel
            {
                FirstName = "William",
                LastName = "Wassmann"
            };

            System.Console.WriteLine($"{ p.FirstName } {p.LastName } is my name");
            System.Console.WriteLine(p.FirstName);

            Console.WriteLine("Hello World!");
            Console.WriteLine("This is a test");
            Console.WriteLine("This is the end");
        }
    }
}
    