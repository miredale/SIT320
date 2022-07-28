using System;
namespace ZooParkWithInheritance
{
    class Wolf : Animal
    {
        private String species;
        private String furType;

        public Wolf(String name, String diet, String location, double weight, int age, String colour, String species, String furType)
        : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
            this.furType = furType;
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 10lbs of meat");
        }

        public override void sleep()
        {
            Console.WriteLine("Sleeps, with a feint snore");
        }

        public override void makeNoise()
        {
            Console.WriteLine("AH-WOOOOOOOOOOOOO");
        }

        public override void specialMove()
        {
            Console.WriteLine("Races through an obstacle course");
        }
    }

}