using System;
class Assignment4C{
    public static void Main(String[] args){
        Console.WriteLine("[Backspace Animation]");
        Console.WriteLine("Please enter your sentence:");
        String sentence = Console.ReadLine();
        Console.WriteLine("How many letters do you want to backspace?");
        int backspace = Convert.ToInt32(Console.ReadLine());
        Console.Write(sentence);
        for (int i = 0; i < backspace; i++)
        {
            Console.Write("\b \b");
            System.Threading.Thread.Sleep(500);
        }
    }
}