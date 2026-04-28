using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        // make list
        List<int> numberList = new List<int>();

        // ask user for numbers (in loop)
        int num;
        do
        {
            Console.Write("Enter number: ");
            string strNum = Console.ReadLine();
            num = int.Parse(strNum);

            // add to the list
            if (num != 0)
            {
                numberList.Add(num);
            }
        } while (num != 0);

        // math for average
        int total = 0;
        int counter = 0;
        int largest = -999999999;
        int smallest = 999999999;
        foreach (int number in numberList)
        {
            // for finding average
            total = total + number;
            counter = counter + 1;

            // find largest number
            if (number > largest)
            {
                largest = number;
            }
            // find smallest number
            else if (number < smallest && number > 0)
            {
                smallest = number;
            }
        }
        float average = ((float)total / counter);

        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
    }
}