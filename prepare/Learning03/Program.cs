using System;

class Program
{
    public static double FindSmallest(List<double> list )
    {
        double smallest = list[0];
        for (int i = 0; i < list.Count(); i++)
        {
            if (smallest > list[i])
            {
                smallest = list[i];
            }
        }
        return smallest;
    }
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
        List<double> sprintTimes = new List<double> {9.58, 9.69, 9.72, 9.74, 9.78};
        Console.WriteLine("100 Meter Dash Fastest Time Lookup");

        double shortest = FindSmallest(sprintTimes);
        Console.WriteLine($"{shortest} seconds");
    }
}