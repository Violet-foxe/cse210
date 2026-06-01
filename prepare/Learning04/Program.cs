using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Console.WriteLine("Hello Learning04 World!");

        // Assignment class
        Assignment assign1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assign1.GetSummary());

        // MathAssignment Class
        Console.WriteLine();
        MathAssignment assign2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());

        // WritingAssignmentClass
        Console.WriteLine();
        WritingAssignment assign3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World Warr II");
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInformation());

        Console.WriteLine();
    }
}