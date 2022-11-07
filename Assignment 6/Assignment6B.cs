using System;
class Assignment6B{
    static String WhatsMyType(int input){
        return String.Format("'{0}' is an integer!", input);
    }
    static String WhatsMyType(String input){
        return String.Format("'{0}' is a string!", input);
    }
    static String WhatsMyType(float input){
        return String.Format("'{0}' is a float!", input);
    }
    static String WhatsMyType(char input){
        return String.Format("'{0}' is a char!", input);
    }
    static String WhatsMyType(bool input){
        return String.Format("'{0}' is a bool!", input);
    }
    public static void Main(String[] args){
        Console.Write("Enter an int: ");
        int integer = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a string: ");
        String str = Console.ReadLine();
        Console.Write("Enter a float: ");
        float flt = float.Parse(Console.ReadLine());
        Console.Write("Enter a char: ");
        char character = Console.ReadLine()[0];
        Console.Write("Enter a boolean: ");
        bool boolean = bool.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("What datatype do you want to check? ");
        String type = Console.ReadLine().ToLower();
        switch (type)
        {
            case "int":
                Console.WriteLine(WhatsMyType(integer));
                break;
            case "string":
                Console.WriteLine(WhatsMyType(str));
                break;
            case "float":
                Console.WriteLine(WhatsMyType(flt));
                break;
            case "char":
                Console.WriteLine(WhatsMyType(character));
                break;
            case "boolean":
                Console.WriteLine(WhatsMyType(boolean));
                break;
        }

    }
}