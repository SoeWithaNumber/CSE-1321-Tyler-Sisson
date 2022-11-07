using System;
class Lab11A{
    public static void Main(String[] args){
        while(true){
            Console.WriteLine("Menu");
            Console.WriteLine("0) Hello World");
            Console.WriteLine("1) Goodbye Moon");
            Console.WriteLine("2) Walking on Sunshine");
            Console.Write("What would you like to do: ");
            int response = Convert.ToInt32(Console.ReadLine());
           
            switch (response)
            {
                case 0:
                    Console.WriteLine("Hello!");
                    break;
                case 1:
                    Console.WriteLine("Ok, bye.");
                    break;
                case 2:
                    Console.WriteLine("WHOA!");
                    break;
            }
            Console.Write("Type YES to rerun. ");
            String rerun = Console.ReadLine();
            if(rerun != "YES"){
                break;
            }
        }
    }
}
