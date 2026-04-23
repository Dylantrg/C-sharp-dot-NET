using System;

public interface IAnimal
{
    void Eat();
}
public class Animals : IAnimal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }

    public virtual void Eat()
    {
        Console.WriteLine("Animal is eating");
    }

}
public class Dog : Animals
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }

    public override void Eat()
    {
        Console.WriteLine("Dog is eating dog food");
    }
}

public class Cat : Animals
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }

    public override void Eat()
    {
        Console.WriteLine("Cat is eating cat food");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Animals dog = new Dog();
        Animals cat = new Cat();
        dog.MakeSound();
        cat.MakeSound();
        dog.Eat();
        cat.Eat();
    }
}
