using System;

class Assignment3B
{
    public static void Main(string[] args)
    {
        Console.Write("What belt grade are you? ");
        int grade = Convert.ToInt32(Console.ReadLine());


        switch (grade)
        {
            case 10:
                Console.WriteLine("You have a white belt,\nwith 0 stripes!");
                break;
            case 9:
                console.WriteLine("You have a white belt,\nwith 1 stripe!");
                break;
            case 8:
                console.WriteLine("You have a yellow belt,\nwith 1 stripe!");
                break;
            case 7:
                console.WriteLine("You have a yellow belt,\nwith 2 stripes!");
                break;
            case 6:
                console.WriteLine("You have a blue belt,\nwith 1 stripe!");
                break;
            case 5:
                console.WriteLine("You have a blue belt,\nwith 2 stripes!");
                break;
            case 4:
                console.WriteLine("You have a green belt,\nwith 1 stripe!");
                break;
            case 3:
                console.WriteLine("You have a green belt,\nwith 2 stripes!");
                break;
            case 2:
                console.WriteLine("You have a brown belt,\nwith 1 stripe!");
                break;
            case 1:
                console.WriteLine("You have a brown belt,\nwith 2 stripes!");
                break;
            case 0:
                console.WriteLine("You have a black belt,\nwith 0 stripes!");
                break;

            default:
                console.WriteLine("You have no belt...");
                break;
        }

    }
}