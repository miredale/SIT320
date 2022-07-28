using System;
namespace ZooParkWithInheritance
{
    class Penguin : Bird
    {
        private bool fly;

        public Penguin(String name, String diet, String location, double weight, int age, String colour, String species, double wingspan, bool fly)
        : base(name, diet, location, weight, age, colour, species, wingspan)
        {
            this.fly = fly;
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 0.5lbs of fish");
        }

        public override void makeNoise()
        {
            Console.WriteLine("Squawk, squawk, squawk");
        }

        public override void specialMove()
        {
            Console.WriteLine("Bellyslides down an icy slope into an icy bath");
        }
    }

}