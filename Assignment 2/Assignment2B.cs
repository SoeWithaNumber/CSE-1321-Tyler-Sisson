using System;

class Assignment2B
{
    public static void Main(string[] args)
    {
        int startXpos, endXpos, framesPassed;
        Console.WriteLine("[Lerping!]");

        Console.Write("Enter the X coordinate for Keyframe #1: ");
        startXpos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the X coordinate for Keyframe #2: ");
        endXpos = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many frames have passed? ");
        framesPassed = Convert.ToInt32(Console.ReadLine());

        float thirtyFps, sixtyFps;
        int distance = endXpos - startXpos;
        

        thirtyFps = startXpos + (distance * (framesPassed/30f));
        sixtyFps = startXpos + (distance * (framesPassed/60f));

        Console.WriteLine("The character has to move {0} places in a second.", distance);
        Console.WriteLine("At 30 FPS, their current X position would be {0}.", thirtyFps);
        Console.WriteLine("At 60 FPS, their current X position would be {0}.", sixtyFps);



    }
}