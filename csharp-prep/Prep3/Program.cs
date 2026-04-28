using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        bool playing = false;

        do //play the game
        {
            // create magic number
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,100);

            // Console.Write("What is the magic number? ");
            // string strNumber = Console.ReadLine();
            // int number = int.Parse(strNumber);

            int num;
            int counter = 0;
            do //guesses
            {
                // ask for user's number
                Console.Write("What is your guess? ");
                string strNum = Console.ReadLine();
                num = int.Parse(strNum);

                // evaluate user's number
                if (num > number)
                {
                    Console.WriteLine("Lower");
                    counter = counter + 1;
                }
                else if (num < number)
                {
                    Console.WriteLine("Higher");
                    counter = counter + 1;
                }
                else
                {
                    Console.WriteLine("You Guessed it!");
                    counter = counter + 1;
                }
            } while (num != number);

            Console.WriteLine($"You took {counter} guesses!");

            // ask to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string askPlaying = Console.ReadLine();

            if (askPlaying == "yes" || askPlaying == "Yes" || askPlaying == "YES")
            {
                playing = true;
            }
            else
            {
                playing = false;
            }
                
        } while (playing == true);
    }
}