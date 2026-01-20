namespace InheritenceApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dog d1 = new Dog();
			d1.MakeSound(); // Method from Dog class
			// d1.Eat();  // Inherited method from Animal class

			Cat c1 = new Cat();
			c1.MakeSound();

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




		public virtual void MakeSound()
		{
			Console.WriteLine("animal Makes a generic sound");
		}
	}

	// Derived class 
	class Dog : Animal
	{

		public override void MakeSound()
		{
			Console.WriteLine("Barking...");
		}
	}


	class Cat : Animal
	{
		public override void MakeSound()
		{
			Console.WriteLine("Meowing...");
		}
	}
}

