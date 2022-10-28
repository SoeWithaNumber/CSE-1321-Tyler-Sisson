using System;

class Assignment2A
{
    public static void Main(string[] args)
    {
        int people, groups, peopleLeftOut;
        Console.Write("How many people are in your group? ");
        people = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many groups do you want? ");
        groups = Convert.ToInt32(Console.ReadLine());

        peopleLeftOut = people % groups;

        Console.WriteLine("If we divide {0} people evenly in {1} groups evenly, {2} person/people will be left without a group.", people, groups, peopleLeftOut);

    }
}