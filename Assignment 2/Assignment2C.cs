using System;

class Assignment2C
{
    public static void Main(string[] args)
    {
        const float usdToBps = 0.85f;
        const float bpsToBsd = 0.2f;

        float usd, bps, bsd;
        Console.WriteLine("[Bisonica Currency Exchange]");
        Console.Write("How many US Dollars do you have? ");
        usd = float.Parse(Console.ReadLine());

        bps = usd*usdToBps;
        bsd = bps*bpsToBsd;

        Console.WriteLine("{0,0:0.##} US Dollar(s) is {1,0:0.##} British Pound(s), which is worth {2,0:0.##} Bison Dollar(s)",usd, bps, bsd );
    }
}