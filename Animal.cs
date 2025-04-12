namespace ExampleAbstractClass
{
    public abstract class Animal
    {
        // This method has a full implementation
        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }

        // This method is abstract, so it must be implemented by subclasses
        public abstract void MakeSound();
        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }
    }
}
