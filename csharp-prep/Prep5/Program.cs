using System;
using System.IO.Pipelines;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int year = PromptUserBirthYear();

        int square = SquareNumber(number);
        DisplayResult(name, square, year);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!"); 
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string strNum = Console.ReadLine();
        int num = int.Parse(strNum);
        return num;
    }

    static int PromptUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        string strYear = Console.ReadLine();
        int year = int.Parse(strYear);
        return year;
    }

    static int SquareNumber(int num)
    {
        int result = num * num;
        return result;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        int currentYear = 2026;
        int age = currentYear - birthYear;
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }

}