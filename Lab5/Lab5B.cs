using System;

class Lab5B
{
    public static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        int intToCheck = Convert.ToInt32(Console.ReadLine());

        if(intToCheck % 2 == 0 && intToCheck % 5 != 0 && intToCheck % 3 != 0){
            Console.WriteLine("This number is divisible by 2");
        }
        else if(intToCheck % 2 != 0 && intToCheck % 5 != 0 && intToCheck % 3 == 0){
            Console.WriteLine("This number is divisible by 3");
        }
        else if(intToCheck % 2 != 0 && intToCheck % 5 == 0 && intToCheck % 3 != 0){
            Console.WriteLine("This number is divisible by 5");
        }
        else{
            Console.WriteLine("This number is undetermined");
        }

    }
}