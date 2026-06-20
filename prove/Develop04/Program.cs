using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");
        bool running = true;
        int choice;
        do
        {
            Console.Clear();

            // menu to choose the activity
            Console.WriteLine("Menu Options:" +
            "\n  1. Start breathing activity" +
            "\n  2. Start reflecting activity" +
            "\n  3. Start listing activity" +
            "\n  4. Start 5-4-3-2-1 calming activity" +
            "\n  5. Quit");

            // get choice
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
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
            else if (choice == 4) // listing
            {
                Calming calm = new Calming();
                calm.CalmingActivity();
            }
            else // quit
            {
                running = false;
            }

        } while (running == true);

        Console.Clear();
    }
}
// i've exceeded requirements by adding a new activity about the 54321 technique