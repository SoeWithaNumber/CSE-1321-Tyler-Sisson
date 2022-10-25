using System;
public class Assignment4A
{
    public static void Main (String[] args)
    {
        Console.WriteLine("[CCSE Study Abroad Survey]");
        int studentCount=1, italy, costaRica, paxBisonica, ghana;
        italy = costaRica = paxBisonica = ghana = 0;
        const String SENTINEL = "quit";
        String answerChoice;
        do{
            Console.WriteLine("Student #{0}: Which country  should we go to for our next study abroad program?", studentCount);
            Console.WriteLine("Italy\nCosta Rica\nPax Bisonica\nGhana\n(Type Quit to end survey)");
            answerChoice = Console.ReadLine();
            switch (answerChoice.ToLower())
            {
                case "italy":
                    italy++;
                    break;
                case "costa rica":
                    costaRica++;
                    break;
                case "pax bisonica":
                    paxBisonica++;
                    break;
                case "ghana":
                    ghana++;
                    break;
                default:
                    Console.WriteLine("Bad input. Check spelling.\n");
                    continue;
            }
            Console.WriteLine("Thank you!\n");
            studentCount++;
        } while(!answerChoice.Equals(SENTINEL));
        Console.WriteLine("[Results]");
        Console.WriteLine("Italy: {0}\nCosta Rica: {1}\nPax Bisonica: {2}\nGhana: {3}", italy, costaRica, paxBisonica, ghana);
    }
} 