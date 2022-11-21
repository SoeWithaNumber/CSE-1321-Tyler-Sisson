using System;
class Assignment7B{
    public static void Main(String[] args){
        Random rnd = new Random();

        FSA[] fsas = new FSA[3];

        for (int i = 0; i < fsas.Length; i++)
        {
            int startingState = rnd.Next(4);
            fsas[i] = new FSA(startingState);
            Console.WriteLine("Machine {0} is starting at state {1}", i, startingState);
        }

        bool finished = false;
        do
        {
            Console.WriteLine("What will you do?");
            Console.WriteLine("-Go to next state");
            Console.WriteLine("-Show current state");
            Console.WriteLine("-End");
            String choice = Console.ReadLine().ToLower();
            int currentFSA;
            Console.WriteLine();
            switch (choice)
            {
                case "go to next state":
                    Console.Write("Which machine will you look at? ");
                    currentFSA = Convert.ToInt32(Console.ReadLine());
                    if (!fsas[currentFSA].isActive()) { Console.WriteLine("Machine is inactive."); break; }
                    else { Console.WriteLine("State of machine {0} is {1}", currentFSA, fsas[currentFSA].goToNextState()); break; }
                    
                    break;
                case "show current state":
                    Console.Write("Which machine will you look at? ");
                    currentFSA = Convert.ToInt32(Console.ReadLine());
                    if(!fsas[currentFSA].isActive()){Console.WriteLine("Machine is inactive."); break;}
                    else{Console.WriteLine("State of machine {0} is {1}",currentFSA, fsas[currentFSA].showCurrentState()); break;}
                    
                    break;
                case "end":
                    Console.Write("Which machine will you look at? ");
                    currentFSA = Convert.ToInt32(Console.ReadLine());
                    if (!fsas[currentFSA].isActive()) { Console.WriteLine("Machine is inactive."); break; }
                    else { fsas[currentFSA].end(); break; }
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
            if(!fsas[0].isActive() && !fsas[1].isActive() && !fsas[2].isActive()){
                finished = true;
            }
        } while (!finished);
        Console.WriteLine("All machines have been turned off.");
    }
}