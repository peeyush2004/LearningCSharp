namespace InheritenceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.Bark(); // Method from Dog class
            d1.Eat();  // Inherited method from Animal class

            Console.ReadKey();
        }
    }

    // Base class
    class Animal
    {

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }


    }

    // Derived class 
    class Dog : Animal
    {

        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }


}
