using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();

        Console.WriteLine("\nWelcome to the Journal Program!");
        
        bool journalling = true;
        // make loop that repeats until quit
        do
        {
        // make options to choose
            // Write Display load save quit
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display Journal \n3. Load \n4. Save \n5. Quit");
            Console.Write("What would you like to do? (use #) ");
            int answer = int.Parse(Console.ReadLine());

            // evaluate choice
            if (answer == 1)
            {
                journal.AddEntry();
            }

            else if (answer == 2)
            {
                // Display journal
                journal.DisplayEntries();
            }

            else if (answer == 3)
            {
                if (journal._saved == true)
                {
                    // Load journal without saving it because it's already saved
                    journal.Load();
                }
                else
                {
                    // Save and Load journal because it hasn't been saved
                    Console.WriteLine("Automatically saving...");
                    journal.Save();
                    journal.Load();
                }
                // Console.WriteLine("Journal is totally loaded");
            }

            else if (answer == 4)
            {
                // Save journal
                journal.Save();
                // Console.WriteLine("Journal is totally saved");
            }

            else
            {
                // quit
                journalling = false;
            }

        } while (journalling == true);
    }
}