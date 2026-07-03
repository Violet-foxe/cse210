public class GoalList
{
	private List<Goal> _goalList = new();
	private bool _saved;
	private bool _loaded;
	private int _totalPoints;

	public GoalList()
	{
		_saved = false;
		_loaded = false;
		_totalPoints = 0;
	}
	public void SaveGoals(string filename)
	{
		FileInfo fileInfo = new FileInfo(filename);
		// if loaded or starting with nothing in the file
		if (_loaded || fileInfo.Length == 0)
		{
			using (StreamWriter outputFile = new StreamWriter(filename))
			{
				// first line is the points
				outputFile.WriteLine(_totalPoints);

				// rest of the lines are the goals
				foreach (Goal goal in _goalList)
				{
					string saveString = goal.GetSaveString();
					outputFile.WriteLine(saveString);
				}
			}
		}

		// if not loaded (adds onto the end)
		else if (!_loaded)
		{
			using (StreamWriter outputFile = new StreamWriter(filename, append: true))
			{
				// lines are the goals added to the end
				foreach (Goal goal in _goalList)
				{
					string saveString = goal.GetSaveString();
					outputFile.WriteLine(saveString);
				}
			}
		}

		// saved is now true
		_saved = true;
	}
	public void LoadGoals(string filename)
	{
		// if not saved, then save
		if (!_saved)
		{
			SaveGoals(filename);
		}

		// blank the goal list to make sure it doesn't dublicate goals from a previous load
		_goalList.Clear();

		// just get the whole list
		string[] lines = System.IO.File.ReadAllLines(filename);
		// get the first line
		_totalPoints = int.Parse(lines[0]);

		foreach (string line in lines.Skip(1))
		{
			string[] parts = line.Split(">");

			string goal = parts[0];
			string info = parts[1];

			if (goal == "SGoal")
			{
				string[] sParts = info.Split("|");
				string title = sParts[0];
				string description = sParts[1];
				int points = int.Parse(sParts[2]);
				bool completed = bool.Parse(sParts[3]);

				Goal simple = new SimpleGoal(title, points, completed, description);
				_goalList.Add(simple);

			}
			else if (goal == "EGoal" || goal == "Goal")
			{
				string[] eParts = info.Split("|");
				string title = eParts[0];
				string description = eParts[1];
				int points = int.Parse(eParts[2]);
				int streak = int.Parse(eParts[3]);

				Goal eternal = new EternalGoal(title, points, streak, description);
				_goalList.Add(eternal);
			}
			else if (goal == "CGoal")
			{
				string[] cParts = info.Split("|");
				string title = cParts[0];
				string description = cParts[1];
				int points = int.Parse(cParts[2]);
				int bonusPoints = int.Parse(cParts[3]);
				int target = int.Parse(cParts[4]);
				int streak = int.Parse(cParts[5]);

				Goal checklist = new ChecklistGoal(title, points, target, bonusPoints, streak, description);
				_goalList.Add(checklist);
			}
			else if (goal == "NGoal")
			{
				string[] nParts = info.Split("|");
				string title = nParts[0];
				string description = nParts[1];
				int points = int.Parse(nParts[2]);
				int streak = int.Parse(nParts[3]);
				Goal negative = new NegativeGoal(title, points, streak, description);
					_goalList.Add(negative);
			}
			else if (goal == "Goal")
			{
				string[] eParts = info.Split("|");
				string title = eParts[0];
				string description = eParts[1];
				int points = int.Parse(eParts[2]);

				Goal theGoal = new Goal(title, points, description);
				_goalList.Add(theGoal);
			}
			else{ Console.WriteLine("Error in goal type"); }
		}

		// it is now loaded
		_loaded = true;
	}
	public void AddGoal()
	{
		bool choosing = true;
		Console.Clear();
		// menu to choose a new goal/badhabit
		Console.WriteLine("The types of Goals are:");
		Console.WriteLine("  1. Simple Goal\n  2. Eternal Goal\n  " +
		"3. Checklist Goal\n  4. Bad Habit");

		// get user input
		do
		{
			Console.Write("Which type of Goal would you like to create? ");
			int choice = int.Parse(Console.ReadLine());

			// evaluate choice
			if (choice == 1) //simple goal
			{
				// Console.WriteLine("you totally created a simple goal");

				// get info for goal
				Console.Write("What is the name of your goal? ");
				string title = Console.ReadLine();
				Console.Write("What is a short description of it? ");
				string description = Console.ReadLine();
				Console.Write("How many points should be given when completed? ");
				int points = int.Parse(Console.ReadLine());

				// make the goal
				Goal simple = new SimpleGoal(title, points, description);
				// add it to the goalList
				_goalList.Add(simple);

				choosing = false;
				// Console.WriteLine($"{title}, {description}, {points}");
			}
			else if (choice == 2) // eternal goal
			{
				// Console.WriteLine("you totally created an eternal goal");

				Console.Write("What is the name of your goal? ");
				string title = Console.ReadLine();
				Console.Write("What is a short description of it? ");
				string description = Console.ReadLine();
				Console.Write("How many points should be given when completed? ");
				int points = int.Parse(Console.ReadLine());

				Goal eternal = new EternalGoal(title, points, description);
				_goalList.Add(eternal);

				choosing = false;
			}
			else if (choice == 3) //checklist goal
			{
				// Console.WriteLine("you totally created a checklist goal");

				Console.Write("What is the name of your goal? ");
				string title = Console.ReadLine();
				Console.Write("What is a short description of it? ");
				string description = Console.ReadLine();
				Console.Write("How many points should be given each time it is accomplished? ");
				int points = int.Parse(Console.ReadLine());
				Console.Write("How many times should the goal be accomplished?? ");
				int target = int.Parse(Console.ReadLine());
				Console.Write("How many points should be given upon completing it entirely? ");
				int bonusPoints = int.Parse(Console.ReadLine());

				Goal checklist = new ChecklistGoal(title, points, target, bonusPoints, description);
				_goalList.Add(checklist);

				choosing = false;
			}
			else if (choice == 4) // bad habit
			{
				// Console.WriteLine("you totally created a bad habit");

				Console.Write("What is the name of your bad habit? ");
				string title = Console.ReadLine();
				Console.Write("What is a short description of it? ");
				string description = Console.ReadLine();
				Console.Write("How many points should be taken away when done? ");
				int points = int.Parse(Console.ReadLine());

				Goal negative = new NegativeGoal(title, points, description);
				_goalList.Add(negative);

				choosing = false;
			}
		} while (choosing == true);
	}
	public void RecordEvent()
	{
		// get goal to record
		Console.WriteLine("The goals are:");
		DisplayShortList();
		Console.Write("Which goal did you accomplish? ");
		int record = int.Parse(Console.ReadLine());

		Goal chosenGoal = _goalList[record-1];
		// get points for it and add to the total points
		_totalPoints += chosenGoal.Record();
	}
	public void DisplayList()
	{
		Console.WriteLine();
		int num = 1;
		// for each goal in display goal, run the display function
		foreach (Goal goal in _goalList)
		{
			Console.WriteLine($"{num}. {goal.Display()}");
			num++;
		}
		Console.WriteLine();
	}
	public void DisplayShortList()
	{
		int num = 1;
		// for each goal in display goal, run the display function
		foreach (Goal goal in _goalList)
		{
			Console.WriteLine($"{num}. {goal.DisplayTitle()}");
			num++;
		}
	}
	public int GetTotalPoints()
	{
		return _totalPoints;
	}
}