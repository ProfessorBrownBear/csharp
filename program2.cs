using System;

public class Dog
{
    private string name = string.Empty;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void Speak()    { Console.WriteLine("I am a Dog, I say Woof!");   }
}

public class Cat
{
    public string catName = string.Empty;
    public void Speak() { Console.WriteLine("I am a Cat, I say Meow!"); }
}

// Adding a Program class with a Main method
class Program
{
    // Shift supervisor: Starts the program and makes everybody work:

    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Name = "Buddy";
        myDog.Speak(); 

        Cat fifi = new Cat();
        fifi.catName = "FIFI";
        fifi.Speak();
    }
}
