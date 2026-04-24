using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        // get percentage
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int per = int.Parse(userInput);

        string letter = "";
        // test percentage and grade
        if (per >= 90)
        {
            letter = "A";        
        }
        else if (per >= 80)
        {
            letter = "B";
        }
        else if (per >= 70)
        {
            letter = "C";
        }
        else if (per >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        int lastNum = per % 10;
        // check for sign on the grade
        if (letter == "F")
        {
            sign = "";
        }
        else if ((lastNum >= 7) && (letter != "A"))
        {
            sign = "+";
        }
        else if (lastNum <3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // print the letter grade
        Console.WriteLine($"Your grade is {letter}{sign}.");

        // did you pass the class?
        if (per >= 70)
        {
            Console.WriteLine("You pass the class!");
        }
        else
        {
            Console.WriteLine("You fail the class.");
        }
    }
}