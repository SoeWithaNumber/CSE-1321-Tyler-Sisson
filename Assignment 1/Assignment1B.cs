using System;

class Assignment1B
{
    public static void Main(string[] args)
    {
        float inputHWGrade, inputLabGrade, inputMidterm, inputFinal;

        Console.Write("Enter your homework Grade: ");
        inputHWGrade = float.Parse(Console.ReadLine());

        Console.Write("Enter your lab Grade: ");
        inputLabGrade = float.Parse(Console.ReadLine());

        Console.Write("Enter your midterm exam Grade: ");
        inputMidterm = float.Parse(Console.ReadLine());

        Console.Write("Enter your final exam Grade: ");
        inputFinal = float.Parse(Console.ReadLine());

        float weightedHW, weightedLab, weightedMidterm, weightedFinal;

        weightedHW = inputHWGrade*0.4f;
        weightedLab = inputLabGrade*0.1f;
        weightedMidterm = inputMidterm*0.2f;
        weightedFinal = inputFinal*0.3f;

        Console.WriteLine();
        Console.WriteLine("Your weighted homework grade is: " + weightedHW);
        Console.WriteLine("Your weighted lab grade is: " + weightedLab);
        Console.WriteLine("Your weighted homework grade is: " + weightedMidterm);
        Console.WriteLine("Your weighted homework grade is: " + weightedFinal);

        float totalGrade = weightedHW + weightedLab + weightedMidterm + weightedFinal;
        Console.WriteLine(String.Format("Final grade: {0,0:F3}", totalGrade));
    }
}