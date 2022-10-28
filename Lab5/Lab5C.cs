using System;

class Lab5C
{
    public static void Main(string[] args)
    {
        Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if(x > 0 && y > 0){
            Console.WriteLine("This point is in the first quadrant.");
        }
        else if(x < 0 && y > 0){
            Console.WriteLine("This point is in the second quadrant.");
        }
        else if(x < 0 && y < 0){
            Console.WriteLine("This point is in the third quadrant.");
        }
        else if(x > 0 && y < 0){
            Console.WriteLine("This point is in the fourth quadrant.");
        }
        else if(x == 0 && y != 0){
            Console.WriteLine("This point is on the y axis.");
        }
        else if(x != 0 && y == 0){
            Console.WriteLine("This point is on the x axis.");
        }
        else{
            Console.WriteLine("This point is the origin.");
        }
    }
}