using System;

class Lab4B
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the day: ");
        String day = Console.ReadLine().ToLower();

        if(day.Equals("monday") || day.Equals("wednesday")){
            Console.WriteLine("I have class today!");
        }
        else if(day.Equals("friday")){
            Console.WriteLine("It's Friday!");
        }
        else{
            Console.WriteLine("I should use this time to do my homework.");
        }
    }
}