using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");
        bool running = true;

        do
        {
            Console.Clear();

            // menu to choose the activity
            Console.WriteLine("Menu Options:" +
            "\n  1. Start breathing activity" +
            "\n  2. Start reflecting activity" +
            "\n  3. start listing activity" +
            "\n  4. Quit");

            // get choice
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            // Console.WriteLine(choice);

            // for each activity
            if (choice == 1) // breathing
            {
                Breathing breathe = new Breathing();
                breathe.BreathActivity();
            }
            else if (choice == 2) // reflecting
            {
                Reflecting reflect = new Reflecting();
                reflect.ReflectActivity();
            }
            else if (choice == 3) // listing
            {
                Listing list = new Listing();
                list.ListingActivity();
            }
            else // quit
            {
                running = false;
            }

        } while (running == true);

        Console.Clear();
    }
}