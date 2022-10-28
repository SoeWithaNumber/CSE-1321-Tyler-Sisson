using System;

class Assignment1A
{
    public static void Main(string[] args)
    {
        int width, height;
        int resolution;

        Console.Write("Enter width in pixels: ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Height in pixels: ");
        height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter resolution in PPI: ");
        resolution = Convert.ToInt32(Console.ReadLine());

        float outputHeight;
        float outputWidth;
        outputHeight = (float) height/resolution;
        outputWidth = (float) width/resolution;

        Console.WriteLine(String.Format("At {0} PPI, the image is {1,0:F3}\" x {2,0:F3}\"", resolution, outputWidth, outputHeight));

    }
}