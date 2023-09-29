take this C# code and refactor it to use a super class called pet containing call commonalities of dog and cat


Below is an example of how you can refactor the Dog class to include a superclass Pet, and I also include a new Cat class to demonstrate how 
  it can share commonalities with Dog by inheriting from Pet.

csharp
Copy code
using System;

// Superclass Pet
public class Pet
{
    // Field
    private string name = string.Empty;

    // Property
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Common method for all pets
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

// Dog class inheriting from Pet
public class Dog : Pet
{
    // Method specific to Dog
    public void Bark()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

// Cat class inheriting from Pet
public class Cat : Pet
{
    // Method specific to Cat
    public void Meow()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Name = "Buddy";
        myDog.Bark(); // Output: Buddy says: Woof!
        myDog.Eat();  // Output: Buddy is eating.

        Cat myCat = new Cat();
        myCat.Name = "Whiskers";
        myCat.Meow(); // Output: Whiskers says: Meow!
        myCat.Eat();  // Output: Whiskers is eating.
    }
}
In the above code:

The Pet class is a superclass that contains a Name property and an Eat method, which are common to all pets.
The Dog and Cat classes inherit from the Pet class.
Dog has a Bark method that is specific to dogs.
Cat has a Meow method that is specific to cats.
In the Main method, instances of Dog and Cat are created, their Name properties are set, and their specific and inherited methods are called.
This demonstrates how you can use inheritance to share common properties and methods among different classes by using a superclass.
