using System;
namespace ZooParkWithInheritance
{
    class Bird : Animal
    {
        private String species;
        private double wingspan;

        public Bird(String name, String diet, String location, double weight, int age, String colour, String species, double wingspan)
        : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
            this.wingspan = wingspan;
        }

        public override void eat()
        {
            Console.WriteLine("I can eat xlbs of fish");
        }

        public override void sleep()
        {
            Console.WriteLine("The bird sleeps in silence, with its head down");
        }
    }
}