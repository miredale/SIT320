using System;

namespace ZooParkWithInheritance
{

    class ZooPark
    {
        static void Main(string[] args)
        {
            //Animal williamWolf = new Animal("William the Wolf", "Meat", "Dog Village", 50.6, 9, "grey");
            //Animal tonyTiger = new Animal("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White");
            //Animal edgarEagle = new Animal("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black");

            Tiger tonyTiger = new Tiger("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White", "Siberian", "White");
            tonyTiger.eat();
            tonyTiger.sleep();
            tonyTiger.makeNoise();
            tonyTiger.specialMove();
            Console.WriteLine();

            Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black", "Harpy", 98.5, true);
            edgarEagle.eat();
            edgarEagle.sleep();
            edgarEagle.makeNoise();
            edgarEagle.specialMove();
            Console.WriteLine();

            Penguin petaPenguin = new Penguin("Peta the Penguin", "Fish", "Bird Mania", 15, 10, "Black and White", "Chinstrap", 20.0, false);
            petaPenguin.eat();
            petaPenguin.sleep();
            petaPenguin.makeNoise();
            petaPenguin.specialMove();
            Console.WriteLine();

            
            Wolf williamWolf = new Wolf("William the Wolf", "Meat", "Dog Village", 50.6, 9, "grey", "grey", "shaggy");
            williamWolf.eat();
            williamWolf.sleep();
            williamWolf.makeNoise();
            williamWolf.specialMove();
            Console.WriteLine();

            Lion larryLion = new Lion("Larry the Lion", "Meat", "Cat Land", 110, 6, "Orange and brown", "Congo", "None");
            larryLion.eat();
            larryLion.sleep();
            larryLion.makeNoise();
            larryLion.specialMove();
            Console.WriteLine();

            Animal baseAnimal = new Animal("Animal Name", "Animal Diet", "Animal Location", 0.0, 0, "Animal Colour");
            baseAnimal.eat();
            baseAnimal.sleep();
            baseAnimal.makeNoise();
            baseAnimal.specialMove();
            
            Console.ReadLine();
        }
    }
}
