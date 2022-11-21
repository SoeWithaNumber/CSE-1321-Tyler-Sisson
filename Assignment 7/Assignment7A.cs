using System;
class Assignment7A{
    public static void Main(String[] args){
        Console.Write("What state do you want to start at? ");
        int startingState = Convert.ToInt32(Console.ReadLine());

        FSA fsa = new FSA(startingState);

        bool finished = false;
        do{
            Console.WriteLine("What will you do?");
            Console.WriteLine("-Go to next state");
            Console.WriteLine("-End");
            String choice = Console.ReadLine().ToLower(); 
            Console.WriteLine();
            switch(choice){
                case "go to next state": 
                    Console.WriteLine("You are now at state {0}", fsa.goToNextState());
                    break;
                case "end":
                    finished = fsa.end();
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }while(!finished);

    }
}