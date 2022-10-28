using System;

class Assignment3C
{
    public static void Main(string[] args)
    {
            Console.Write("What mobile device do you have?");
            String device = Console.ReadLine();

            if(!device.ToLower().Equals("apple") || !device.ToLower().Equals("android") ){
                Console.WriteLine("I’m sorry, our app does not support your device.");
                return;
            }
            Console.Write("What version do you have?");

            int version = Convert.ToInt32(Console.ReadLine());

            if((device.ToLower().Equals("apple")&&version >=12)|| (device.ToLower().Equals("android")&&version >=11)

    }
}