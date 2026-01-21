using System;

namespace Coding.Exercise
{
    // Base class
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // Derived class Cat
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    public class Exercise
    {
        public void DemonstrateOverriding()
        {
            Animal animal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }
}
