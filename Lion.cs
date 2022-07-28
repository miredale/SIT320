using System;
namespace ZooParkWithInheritance
{
    class Lion : Feline
    {
        private String colourStripes;

        public Lion(String name, String diet, String location, double weight, int age, String colour, String species, String colourStripes)
        : base(name, diet, location, weight, age, colour, species)
        {
            this.colourStripes = colourStripes;
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 30lbs of meat");
        }

        public override void makeNoise()
        {
            Console.WriteLine("RRRAAAAAAAWWWWWWWRRRRRRRRRRRRR");
        }
    }
}