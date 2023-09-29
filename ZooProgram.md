#A C Sharp program demonstrating the concepts mentioned in the activity "Create Your Own Virtual Zoo".

This example includes:

An Animal class as a base class with properties (Name and Age) and methods (Speak and Eat).
Three subclasses Lion, Elephant, and Bird, each inheriting from Animal.
Overridden Speak method for each subclass to demonstrate polymorphism.
An Interact method in each animal class to demonstrate interaction and further show polymorphism.
csharp

#CSharp

using System;
namespace VirtualZoo
{
    // Base Animal class
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} the Animal is speaking.");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public virtual void Interact(Animal otherAnimal)
        {
            Console.WriteLine($"{Name} the Animal interacts with {otherAnimal.Name} the Animal.");
        }
    }

    // Lion subclass
    public class Lion : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} the Lion roars!");
        }

        public override void Interact(Animal otherAnimal)
        {
            Console.WriteLine($"{Name} the Lion interacts with {otherAnimal.Name}.");
        }
    }

    // Elephant subclass
    public class Elephant : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} the Elephant trumpets!");
        }

        public override void Interact(Animal otherAnimal)
        {
            Console.WriteLine($"{Name} the Elephant interacts with {otherAnimal.Name}.");
        }
    }

    // Bird subclass
    public class Bird : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} the Bird chirps!");
        }

        public override void Interact(Animal otherAnimal)
        {
            Console.WriteLine($"{Name} the Bird interacts with {otherAnimal.Name}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion { Name = "Leo", Age = 5 };
            Elephant elephant = new Elephant { Name = "Ella", Age = 8 };
            Bird bird = new Bird { Name = "Blue", Age = 2 };

            lion.Speak();  // Output: Leo the Lion roars!
            lion.Eat();  // Output: Leo is eating.
            lion.Interact(elephant);  // Output: Leo the Lion interacts with Ella.

            elephant.Speak();  // Output: Ella the Elephant trumpets!
            elephant.Interact(bird);  // Output: Ella the Elephant interacts with Blue.

            bird.Speak();  // Output: Blue the Bird chirps!
            bird.Interact(lion);  // Output: Blue the Bird interacts with Leo.
        }
    }
}
Explanation:
Animal class:

Contains properties Name and Age.
Contains a virtual Speak method which can be overridden by derived classes.
Contains an Eat method.
Contains a virtual Interact method which can be overridden by derived classes.
Lion, Elephant, and Bird classes:

Inherit from the Animal class.
Override the Speak method to provide their own implementations.
Override the Interact method to provide their own implementations.
Program class contains the Main method which is the entry point of the application:

Creates instances of Lion, Elephant, and Bird.
Calls the Speak, Eat, and Interact methods on these instances to demonstrate the behavior of the different animal types.
This example covers creation of classes, inheritance, and polymorphism, and provides a framework for students to further explore interactions between different object types.
