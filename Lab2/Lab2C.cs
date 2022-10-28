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
        Console.Write("Please enter width: ");
        float width = float.Parse(Console.ReadLine());

        Console.Write("Please enter height: ");
        float height = float.Parse(Console.ReadLine());

        Console.WriteLine("The area is: " + width*height);
        Console.WriteLine("The perimeter is: " + (width * 2 + height * 2));
    }
}