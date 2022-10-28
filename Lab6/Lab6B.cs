using System;
public class Lab6B
{
    // Prints two lines of output representing a rocket countdown.
    public static void Main (String[] args)
    {
       Random rand = new Random();
       Console.Write("Enter a number between 1 and 1000: ");
       int number = Convert.ToInt32(Console.ReadLine());

       int guess = 0;
       int count = 0;
       while(guess != number){
        guess = rand.Next(1, 1001);
        Console.WriteLine("My guess was {0}", guess);
        count++;
       }
       Console.WriteLine();
       Console.WriteLine("I guessed the number was {0} and it only took me {1} guesses", guess, count);
    }
} 