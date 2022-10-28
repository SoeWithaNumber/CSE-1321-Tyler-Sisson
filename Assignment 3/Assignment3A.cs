using System;

class Assignment3A
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello stranger! Do you have time to hear my tale?");
        Console.WriteLine("1) Yes");
        Console.WriteLine("2) No");
        int option = Convert.ToInt32(Console.ReadLine());
        if(option == 1){
            Console.WriteLine("Thank you! I come from the land of Pax Bisonica. Our country has been taken over by a cruel tyrant!");
            Console.WriteLine("1) That's awful!");
            Console.WriteLine("2) What can I do?");

            option = Convert.ToInt32(Console.ReadLine());


            if(option == 1){
                Console.WriteLine("Alas, it is truly terrible...");
            }

            Console.WriteLine("Please, you must journey to Pax Bisonica and free our country!");
            Console.WriteLine("1) Okay");
            Console.WriteLine("2) No");

            option = Convert.ToInt32(Console.ReadLine());

            if(option == 1){
                Console.WriteLine("Hooray!!");
            }
            else{
                Console.WriteLine("Then all is lost...");
            }
        }
        else{
            Console.WriteLine("Ah, then goodbye...");
        }


    }
}