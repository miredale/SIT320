using System;
namespace ZooParkWithInheritance
{
    class Eagle : Bird
    {
        private bool fly;

        public Eagle(String name, String diet, String location, double weight, int age, String colour, String species, double wingspan, bool fly)
        : base(name, diet, location, weight, age, colour, species, wingspan)
        {
            this.fly = fly;
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 1lbs of fish");
        }

        public override void makeNoise()
        {
            Console.WriteLine("SCREEEEEEEECH");
        }

        public override void specialMove()
        {
            Console.WriteLine("Flies in a figure 8 pattern");
        }
    }
}

