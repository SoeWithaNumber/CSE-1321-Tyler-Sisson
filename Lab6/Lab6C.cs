using System;
public class Lab6B
{
    // Prints two lines of output representing a rocket countdown.
    public static void Main (String[] args)
    {
        float balance = 1000;
        Console.WriteLine("Welcome!");
        Console.WriteLine("You have ${0} in your account.", balance);
        Console.WriteLine("");
        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("0 - Make a deposit");
            Console.WriteLine("1 - Make a withdrawal");
            Console.WriteLine("2 - Display account value");
            Console.WriteLine("");
            Console.Write("Please make a selection: ");

            String choice = Console.ReadLine();
            
            if(choice.Equals("0")){
                Console.Write("How much would you like to deposit? : ");
                balance += float.Parse(Console.ReadLine());
                Console.WriteLine("Your current balance is ${0}", balance);
                Console.Write("Would you like to return to the main menu (Y/N)? : ");
                char yesNo = Convert.ToChar(Console.ReadLine().ToLower());
                if(yesNo == 'n'){
                    break;
                }

            }
            else if(choice.Equals("1")){
                Console.Write("How much would you like to withdraw? : ");
                balance -= float.Parse(Console.ReadLine());
                Console.WriteLine("Your current balance is ${0}", balance);
                Console.Write("Would you like to return to the main menu (Y/N)? : ");
                char yesNo = Convert.ToChar(Console.ReadLine().ToLower());
                if(yesNo == 'n'){
                    break;
                }
            }
            else if(choice.Equals("2")){
                Console.WriteLine("Your current balance is ${0}", balance);
                Console.Write("Would you like to return to the main menu (Y/N)? : ");
                char yesNo = Convert.ToChar(Console.ReadLine().ToLower());
                if(yesNo == 'n'){
                    break;
                }
            }
            else{
                Console.WriteLine("Invalid entry, please try again.");
                Console.Write("Would you like to return to the main menu (Y/N)? : ");
                char yesNo = Convert.ToChar(Console.ReadLine().ToLower());
                if(yesNo == 'n'){
                    break;
                }
            }

        } while (true);
        Console.WriteLine("");
        Console.WriteLine("Thank you for banking with us!");
    }
} 