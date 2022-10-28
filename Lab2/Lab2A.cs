using System;

/*
Class: CSE 1321L
Term: 1
Instructor: Meghana Bandaru
Name: Tyler Sisson
Lab: C#
*/
class Lab2A
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a name: ");
        String nameOne = Console.ReadLine();

        Console.Write("Enter a second name: ");
        String nameTwo = Console.ReadLine();

        Console.Write("Enter a verb: ");
        String verb = Console.ReadLine();

        Console.Write("Enter an adverb: ");
        String adverb = Console.ReadLine();

        Console.WriteLine(String.Format("Once upon a time, there was a person named {0} who had a child named {1}. This child would {2} {3} while singing to strangers.", nameOne, nameTwo, verb, adverb));

    }
}