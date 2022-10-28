using System;

class Lab4A
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the score of your exam: ");
        float gradeScore = float.Parse(Console.ReadLine());

        String gradeLetter;
        if(gradeScore<=64){
            gradeLetter = "F";
        }
        else if(gradeScore<=67){
            gradeLetter = "D-";
        }
        else if(gradeScore<=70){
            gradeLetter = "D";
        }
        else if(gradeScore<=73){
            gradeLetter = "D+";
        }
        else if(gradeScore<=76){
            gradeLetter = "C-";
        }
        else if(gradeScore<=79){
            gradeLetter = "C";
        }
        else if(gradeScore<=82){
            gradeLetter = "C+";
        }
        else if(gradeScore<=85){
            gradeLetter = "B-";
        }
        else if(gradeScore<=88){
            gradeLetter = "B";
        }
        else if(gradeScore<=89){
            gradeLetter = "B+";
        }
        else if(gradeScore<=94){
            gradeLetter = "A-";
        }
        else if(gradeScore<=97){
            gradeLetter = "A";
        }
        else{
            gradeLetter = "A+";
        }

        Console.WriteLine("Letter grade is: {0}", gradeLetter);
    }
}