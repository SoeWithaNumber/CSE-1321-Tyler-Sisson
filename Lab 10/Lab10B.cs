using System;
class Lab10B{
    public static bool isValid(double width, double height){
        return (2*width)+(2*height) > 30 ? true : false;
    }
    public static double area(double width, double height){
        return width * height;
    }
    public static double perimeter(double width, double height){
        return (2*width)+(2*height);
    }
    public static void Main(String[] args){
        bool ended = false;
        do{
            Console.Write("\nEnter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            if(isValid(width, height)){
            
                Console.WriteLine("This is a valid rectangle");
                Console.WriteLine("The area is: {0}\nThe perimeter is: {1}", area(width, height), perimeter(width, height));
            }
            else{Console.WriteLine("Invalid rectangle");}
            Console.Write("Do you want to enter another width and height? (Y/N) : ");
            char answerChoice = Console.ReadLine().ToLower()[0];
            ended = answerChoice == 'n' ? true : false;
        } while(!ended);
    }
}