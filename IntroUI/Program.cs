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
                LastName = "Wassmann",
                Age = 30
            };

            CatModel c = new CatModel
            {
                Name = "Biscuit",
                Age = 8,
                Color = "black",
                Breed = "English Short-hair"
            };

            System.Console.WriteLine($"{ p.FirstName } {p.LastName } is my name and I am { p.Age } years old");
            System.Console.WriteLine($"I have a cat named { c.Name }. He\'s an { c.Age } { c.Color} { c.Breed}");
                     
        }
    }
}
    