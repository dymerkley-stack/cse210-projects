using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment me = new Assignment("Dylan", "Programing with Functions");
        Console.WriteLine(me.GetSummary());
        
        MathAssignment math = new MathAssignment("Dylan", "Math", "Section 10.5", "1,3,5,7,9");
        Console.WriteLine();
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment sux = new WritingAssignment("Dylan", "Market Trends", "AI Copilot Integration");
        Console.WriteLine();
        Console.WriteLine(sux.GetSummary());
        Console.WriteLine(sux.GetWritingInformation());
    }
}