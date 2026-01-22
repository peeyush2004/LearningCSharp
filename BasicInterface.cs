namespace InterfaceApp
{

    public interface IAnimal
    {
        void MakeSound();
        void Eat(string food);
    }

    public class Dog : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Dog is eating {food}");
        }

        public void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.MakeSound();
            d1.Eat("bone");

            Console.ReadKey();
        }
    }
}
