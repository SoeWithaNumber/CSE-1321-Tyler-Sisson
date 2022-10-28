using System;
class Assignment5A{
    public static void Main(String[] args){
        Console.WriteLine("[Top 5 Friend's List]");
        String[] friends = new String[5]{"", "", "", "", ""};
        int choice, index;
        int currentFriend = 0;
        bool done = false;
        while(!done){
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Enter a friend's name");
            Console.WriteLine("2) Replace a friend's name");
            Console.WriteLine("3) Display your friends list");
            Console.WriteLine("4) Quit");
            Console.Write("Your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 4:
                    done = true;
                    break;
                case 1:
                    Console.Write("Enter a name: ");
                    String name = Console.ReadLine();
                    if(currentFriend > 4){
                        Console.WriteLine("Sorry! Your friends list is full!");
                        break;
                    }
                    friends[currentFriend++] = name;
                    break;
                case 2:
                    Console.Write("Enter a name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter an index: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    if(index < 0 || index > 4){
                        Console.WriteLine("Invalid index!");
                        break;
                    }
                    Console.WriteLine("{0} has replaced {1} on your friends list!", name, friends[index]);
                    friends[index] = name;
                    break;
                case 3:
                    for (int i = 0; i < friends.Length; i++)
                    {
                        Console.WriteLine("{0}) {1}", i+1, friends[i]);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }

        }
    }
}