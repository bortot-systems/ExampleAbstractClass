namespace ExampleAbstractClass
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public void Scratch()
        {
            Console.WriteLine("The cat is scratching.");
        }
    }
}
