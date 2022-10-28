using System;
public class Lab6A
{
    // Prints two lines of output representing a rocket countdown.
    public static void Main (String[] args)
    {
        Console.WriteLine("Please enter 10 numbers and this program will display the largest.");
        Console.WriteLine();
        int highestNumber = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Please enter number {0}: ", i);
            int currentNumber = Convert.ToInt32(Console.ReadLine());
            highestNumber = currentNumber > highestNumber ? currentNumber : highestNumber;
        }
        Console.WriteLine();
        Console.WriteLine("The largest number was {0}", highestNumber);
    }
} 