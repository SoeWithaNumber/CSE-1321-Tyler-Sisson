using System;

class Assignment1C
{
    public static void Main(string[] args)
    {
        Console.Write("Input starting character: ");
        char startingChar = Convert.ToChar(Console.ReadLine());

        Console.WriteLine(String.Format("Starting at {0}, the next 3 characters are: {1}, {2}, {3}", startingChar, (char)(startingChar + 1), (char)(startingChar + 2), (char)(startingChar + 3)));

    }
}