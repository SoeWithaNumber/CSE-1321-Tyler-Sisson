using System;
class Lab9A{
    public static void Main(String[] args){
        Console.WriteLine("Please enter 10 numbers:");
        int[] numbers = new int[10]; 
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Integer {0}: ", i+1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();

        Console.Write("What is the target number: ");
        int target = Convert.ToInt32(Console.ReadLine());
        bool isInSet = false;
        foreach (int number in numbers)
        {
            if(number == target){
                isInSet = true;
                break;
            }
        }

        Console.WriteLine();
        Console.WriteLine(isInSet ? "The target is in the set." : "The target is not in the set.");

    }
}