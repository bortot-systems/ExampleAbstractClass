namespace ExampleInterface
{
    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public void Eat()
        {
            Console.WriteLine("The dog is eating.");
        }
    }

}
