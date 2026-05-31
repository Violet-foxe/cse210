using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();
        journal._saved = true;

        Console.WriteLine("\nWelcome to the Journal Program!");
        
        bool journalling = true;
        // make loop that repeats until quit
        do
        {
            // make options to choose
            // Write Display load save quit
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display Journal \n3. Load \n4. Save \n5. Quit");
            Console.Write("What # would you like to do? ");
            int answer = int.Parse(Console.ReadLine());

            // evaluate choice
            if (answer == 1)
            {
                // adds a single entry
                journal.AddEntry();
            }

            else if (answer == 2)
            {
                // Display full journal and entries
                journal.DisplayEntries();
            }

            else if (answer == 3)
            {
                // exceeds requirements to have specific senarios of saving and loading. 
                // It is practically an autosave.
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
                // exceeds requirements with load and save senarios, 
                // but the code is in journal.cs
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
// load and save senarios exceeds requirements, 
// more information found throughout the code.
// ctrl + f to find 'exceeds requirements'