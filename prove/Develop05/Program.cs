using System;

class Program
{
	static void Main(string[] args)
	{
		// Console.WriteLine("Hello Develop05 World!");

		// Make a new goalList
		GoalList fullList = new();
		Console.Clear();

		bool playing = true;
		do
		{
			// Welcome + show menu
			Console.WriteLine($"You have {fullList.GetTotalPoints()} points.\n");// display score
			Console.WriteLine("Menu Options:");
			Console.WriteLine("  1. Create New Goal\n" +// create new goals, 
			"  2. List Goals\n" +// display goals
			"  3. Save Goals\n" +// save
			"  4. Load Goals\n" +//load
			"  5. Record Event\n" +// record event
			"  6. Quit");//quit
			Console.Write("Select a choice from the menu: ");
			int choice = int.Parse(Console.ReadLine());

			// evaluate input
			if (choice == 1) // create goal
			{
				// Console.WriteLine("you totally created a new goal");
				// create a new goal, and add to the list
				fullList.AddGoal();
				Console.Clear();
			}
			else if (choice == 2) // listed goals
			{
				// Console.WriteLine("you totally listed the goals");
				// list and display all the goals
				fullList.DisplayList();
			}
			else if (choice == 3) // save goals
			{
				// Console.WriteLine("you totally saved the goals");
				// save the goals to a file
				Console.Write("What is the file name for the goal file? ");
				string filename = Console.ReadLine();

				fullList.SaveGoals(filename);
				Console.Clear();
			}
			else if (choice == 4) // load goals
			{
				// Console.WriteLine("you totally loaded goals");
				// load other goals from a file
				Console.Write("What is the file name for the goal file? ");
				string filename = Console.ReadLine();

				fullList.LoadGoals(filename);
				Console.Clear();
			}
			else if (choice == 5) // record event
			{
				// Console.WriteLine("you totally recorded an event");
				// record an event to update a goal
				
				Console.Clear();
				fullList.RecordEvent();
				Console.Clear();
			}
			else // quit
			{
				playing = false;
			}
		} while (playing == true);
	}
}

// added negative goal (bad habit), which grants negative points