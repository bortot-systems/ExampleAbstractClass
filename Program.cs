// Program.cs
using ExampleAbstractClass;

class Program
{
    static void Main(string[] args)
    {
        Animal dog = new Dog();
        dog.Sleep();       // Outputs: The animal is sleeping.
        dog.MakeSound();   // Outputs: Woof! Woof!
        dog.Eat();

        Animal cat = new Cat();
        cat.Sleep();       // Outputs: The animal is sleeping.
        cat.MakeSound();   // Outputs: Meow!
        cat.Eat();
    }
}
