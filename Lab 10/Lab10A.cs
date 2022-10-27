using System;
class Lab10A{
    public static int max(int a, int b){
        return a>b? a : b;
    }

    public static int min(int a, int b){
        return a<b? a : b;
    }
    public static double avg(int a, int b){
        return (double)(a+b)/2.0;
    }
    public static void Main(String[] args){
        Console.Write("Enter a number 1: ");
        int firstNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a number 2: ");
        int secondNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Min is {0}\nMax is {1}\nAverage is {2}", min(firstNum, secondNum), max(firstNum, secondNum), avg(firstNum, secondNum));
    }
}