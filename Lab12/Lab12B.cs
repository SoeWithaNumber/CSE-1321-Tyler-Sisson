using System;
class Lab12B{
    public static void Main(String[] args){
        Console.WriteLine("You are about to create a dog");
        Console.Write("How old is the dog: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("How much does the dog weigh: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("What is the dog's name: ");
        String name = Console.ReadLine();
        Console.Write("What color is the dog: ");
        String color = Console.ReadLine();
        Console.Write("What breed is the dog: ");
        String breed = Console.ReadLine();

        Dog pet = new Dog(age, weight, name, color, breed);

        Console.WriteLine("{0} is a {1} year old {2} {3} that weighs {4} lbs.", pet.name, pet.age, pet.furColor, pet.breed, pet.weight);

        pet.bark();
        Console.Write("{0} is hungry, how much should he eat: ", pet.name);
        pet.eat(Convert.ToDouble(Console.ReadLine()));
        Console.Write("{0} isn't a very good name. What should they be renamed to: ", pet.name);
        pet.rename(Console.ReadLine());

        Console.WriteLine("{0} is a {1} year old {2} {3} that weighs {4} lbs.", pet.name, pet.age, pet.furColor, pet.breed, pet.weight);

    }
}

public class Dog
{
    public int age;
    public double weight;
    public String name;
    public String furColor;
    public String breed;

    public Dog(int age, double weight, String name, String furColor, String breed){
        this.age = age;
        this.weight = weight;
        this.name = name;
        this.furColor = furColor;
        this.breed = breed;
    }

    public void bark(){
        Console.WriteLine("Woof! Woof!");
    }
    public void rename(String newName){
        this.name = newName;
    }
    public void eat(double food){
        this.weight += food;
    }
}