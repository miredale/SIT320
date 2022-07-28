using System;
namespace ZooParkWithInheritance
{
   class Feline : Animal
    {
        private String species;

        public Feline(String name, String diet, String location, double weight, int age, String colour, String species)
        : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
        }
        public override void sleep()
        {
            Console.WriteLine("The cat purrs while sleeping");
        }

         public override void specialMove()
        {
            Console.WriteLine("Stands on back legs and raises front paws");
        }
    }
}


