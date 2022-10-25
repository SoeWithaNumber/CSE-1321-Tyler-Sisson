using System;

class Assignment4B
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome!");
        int selectionNumber;
        double inputNumber;
        Console.Write("Please input a number: ");
        inputNumber = Convert.ToDouble(Console.ReadLine());
        do{
            Console.WriteLine("What would you like to do to this number: ");
            Console.WriteLine("-1- Select a new number: ");
            Console.WriteLine("0- Get the additive inverse of this number");
            Console.WriteLine("1- Get the reciprocal of this number");
            Console.WriteLine("2- Square the number");
            Console.WriteLine("3- Cube the number");
            Console.WriteLine("4- Exit the program");
            
            selectionNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if(selectionNumber < -1||selectionNumber>4){
                selectionNumber = retryNumber(selectionNumber);
            }
            switch (selectionNumber)
            {
                case 0: Console.WriteLine("The additive inverse of {0} is {1}", inputNumber, inputNumber*-1);
                break;

                case 1: Console.WriteLine("The reciprocal of {0} is {1}", inputNumber, 1/inputNumber);
                break;

                case 2: Console.WriteLine("The square of {0} is {1}", inputNumber, inputNumber*inputNumber);
                break;

                case 3: Console.WriteLine("The cube of {0} is {1}", inputNumber, inputNumber*inputNumber*inputNumber);
                break;

                case 4: Console.WriteLine("Thank you, goodbye!");
                break;

                case -1:
                    Console.Write("Please input a number: ");
                    inputNumber = Convert.ToDouble(Console.ReadLine());
                break;

                //default: retryNumber(inputNumber);
                //break;
                
            }
        } while(selectionNumber != 4);
    }
    static int retryNumber(int currentNumber){
        int newNumber = currentNumber;
        while(newNumber <-1 || newNumber > 4){
            Console.Write("Please pick a number between -1 and 4: ");
            newNumber = Convert.ToInt32(Console.ReadLine());
        }
        return newNumber;
    }
}