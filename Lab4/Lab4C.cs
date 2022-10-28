using System;

class Lab4C
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome!");
        Console.Write("Please enter a number: ");
        double inputNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What would you like to do with this number: ");
        Console.WriteLine("0- Get the additive inverse of this number");
        Console.WriteLine("1- Get the reciprocal of this number");
        Console.WriteLine("2- Square the number");
        Console.WriteLine("3- Cube the number");
        Console.WriteLine("4- Exit the program");
        
        int selectionNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        switch (selectionNumber)
        {
            case 0: Console.WriteLine("The additive inverse of {0} is {1}", inputNumber, inputNumber*-1);
            break;

            case 1: Console.WriteLine("The reciprocal of {0} is {1}", inputNumber, 1/inputNumber);
            break;

            case 2: Console.WriteLine("The square of {0} is {1}", inputNumber, inputNumber*inputNumber);
            break;

            case 3: Console.WriteLine("The cube of {0} is {1}", inputNumber, inputNumber*inputNumber*inputNumber);
            break;

            case 4: Console.WriteLine("Thank you, goodbye!");
            break;

            default: Console.WriteLine("Invalid input, please try again!");
            break;
            
        }
    }
}