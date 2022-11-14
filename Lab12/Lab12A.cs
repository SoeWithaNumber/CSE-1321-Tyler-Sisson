using System;
class Lab12A{
    public static void Main(String[] args){
        Console.WriteLine("You are about to create a chair");
        Console.Write("How many legs does your chair have: ");
        int legs = Convert.ToInt32(Console.ReadLine());
        Console.Write("Is your chair rolling (true/false): ");
        bool rolling = Convert.ToBoolean(Console.ReadLine());
        Console.Write("What is your chair made of: ");
        String material = Console.ReadLine();

        Chair chair = new Chair(legs, rolling, material);

        Console.Write("Your chair has {0}, ", chair.numOfLegs == 1 ? "1 leg" : chair.numOfLegs + " legs");
        Console.Write("is {0} rolling, ", chair.rolling ? "\b" : "not");
        Console.Write("and is made of {0} \n", chair.material);

        chair.numOfLegs = 4;
        chair.rolling = false;
        chair.material = "wood";

        Console.Write("Your chair has {0}, ", chair.numOfLegs == 1 ? "1 leg" : chair.numOfLegs + " legs");
        Console.Write("is {0} rolling, ", chair.rolling ? "\b" : "not");
        Console.Write("and is made of {0}\n", chair.material);
    }
}

public class Chair
{
    public int numOfLegs;
    public bool rolling;
    public String material;

    public Chair(int numOfLegs, bool rolling, String material)
    {
        this.numOfLegs = numOfLegs;
        this.rolling = rolling;
        this.material = material;
    }
}