using System;
using System.Text.RegularExpressions;
class Lab11B{
    public static void Main(String[] args){
        Console.Write("Enter a password: ");
        String password = Console.ReadLine();
        bool hasUpper = new Regex("[A-Z]").IsMatch(password);
        bool hasDigit = new Regex("[0-9]").IsMatch(password);
        
        bool isLong = password.Length >= 8;
        if(hasDigit && hasUpper && isLong){
            Console.WriteLine("Valid password");
        }
        else{
            Console.WriteLine("Invalid password");
        }
    }
}