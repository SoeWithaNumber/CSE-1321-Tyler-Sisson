using System;
class Assignment5B{
    public static void Main(String[] args){
        String[][] signs = new String[12][]
        {
            //Jan
            new String[31],
            //Feb
            new String[28],
            //Mar
            new String[31],
            //Apr
            new String[30],
            //May
            new String[31],
            //Jun
            new String[30],
            //Jul
            new String[31],
            //Aug
            new String[31],
            //Sep
            new String[30],
            //Oct
            new String[31],
            //Nov
            new String[30],
            //Dec
            new String[31],
        };
        for (int row = 0; row < signs.Length; row++)
        {
            for (int col = 0; col < signs[row].Length; col++)
            {
                //Aries
                if((row == 2 && col>= 20) || (row == 3 && col <=18)){
                    signs[row][col] = "Aries";
                }
                //Taurus
                else if((row == 3 && col>=19) || (row == 4 && col <=19)){
                    signs[row][col] = "Taurus";
                }
                //Gemini
                else if((row == 4 && col>=20) || (row == 5 && col <=20)){
                    signs[row][col] = "Gemini";
                }
                //Cancer
                else if((row == 5 && col>=21) || (row == 6 && col <=21)){
                    signs[row][col] = "Cancer";
                }
                //Leo
                else if((row == 6 && col>=22) || (row == 7 && col <=21)){
                    signs[row][col] = "Leo";
                }
                //Virgo
                else if((row == 7 && col>=22) || (row == 8 && col <=21)){
                    signs[row][col] = "Virgo";
                }
                //Libra
                else if((row == 8 && col>=22) || (row == 9 && col <=22)){
                    signs[row][col] = "Libra";
                }
                //Scorpio
                else if((row == 9 && col>=23) || (row == 10 && col <=20)){
                    signs[row][col] = "Scorpio";
                }
                //Sagittarius
                else if((row == 10 && col>=21) || (row == 11 && col <=20)){
                    signs[row][col] = "Sagittarius";
                }
                //Capricorn
                else if((row == 11 && col>=21) || (row == 0 && col <=18)){
                    signs[row][col] = "Capricorn";
                }
                //Aquarius
                else if((row == 0 && col>=19) || (row == 1 && col <=17)){
                    signs[row][col] = "Aquarius";
                }
                //Pisces
                else if((row == 1 && col>=18) || (row == 2 && col <=19)){
                    signs[row][col] = "Pisces";
                }
            }
        }
        //I honestly should have just made that a method that took the date range... whatever

        int month,day;

        Console.Write("What month were you born in? ");
        month = Convert.ToInt32(Console.ReadLine());
        if(month < 0 || month > 12){
            Console.WriteLine("That is not a valid month...");
            return;
        }
        Console.Write("And what day? ");
        day = Convert.ToInt32(Console.ReadLine());

        try
        {
            Console.WriteLine("Your sign is {0}!", signs[month-1][day-1]);
        }
        catch (System.Exception)
        {
            
            Console.WriteLine("That is not a valid day...");
        }
        

    }
}