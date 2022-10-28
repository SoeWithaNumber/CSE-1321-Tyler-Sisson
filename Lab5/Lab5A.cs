using System;

class Lab5A
{
    public static void Main(string[] args)
    {
        Console.Write("Do you have a driving permit? ");
        char yesNo = Convert.ToChar(Console.ReadLine().ToLower());

        if(yesNo == 'y'){
            Console.Write("Do you have a commercial driving license? ");
            yesNo = Convert.ToChar(Console.ReadLine().ToLower());
            if(yesNo == 'y'){
                Console.WriteLine("Congratulations! You can purchase a vehicle, let's start talking options!");
            }
            else{
                Console.WriteLine("Commercial driving license is a prerequisite to purchase a vehicle!");
            }
        }
        else{
            Console.WriteLine("Driving permit is a prerequisite to purchase a vehicle!");
        }
    }
}