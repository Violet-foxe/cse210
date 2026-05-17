// using System.IO;
public class Journal
{
    // +_entries: List<Entry>
    public List<Entry> _entries = new();
    public bool _loaded;
    public bool _saved;

    // Behaviors
    // +AddEntry: void
    // DisplayEntries: void
    public void AddEntry()
    {
        // Write: make entry
        Entry entry = new Entry();

        // find date
        DateTime CurrentTime = DateTime.Now;
        entry._date = CurrentTime.ToShortDateString();
        Console.WriteLine($"\n{entry._date}");

        // get prompt
        entry._prompt = GetPrompt();
        Console.WriteLine(entry._prompt);

        // get response from user
        Console.Write("> ");
        entry._response = Console.ReadLine();

        // send to journal
        _entries.Add(entry);
        _saved = false;

        // Display?
        string entryString = entry.Display();
        // Console.WriteLine(entryString);
    }
    public void DisplayEntries()
    {
        // use loop to go through each entry and printing them
        foreach (Entry entry in _entries)
        {
            string stringEntry = entry.Display();
            Console.WriteLine(stringEntry);
        }
    }
    public void Save()
    {
        // using System;
        // get file name
        Console.Write("Save to filename: ");
        string filename = Console.ReadLine();

        if (_loaded == true)
        {
            // send to a csv, doesn't add to the end
            using(StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    // get all the entry information
                    outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
                }
            }
            
        }
        else // this is if the program hasn't been loaded in this session
        {
            // send to a csv
            using(StreamWriter outputFile = new StreamWriter(filename, append: true))
            {
                foreach (Entry entry in _entries)
                {
                    // get all the entry information
                    outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
                }
            }
        }
        _saved = true;
    }
    public void Load()
    {
        // find the file
        Console.Write("Load from filename: ");
        string filename = Console.ReadLine();

        _entries.Clear();
        
        // get the info from file
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
             // seperator: |
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            _entries.Add(entry);
        }
        _loaded = true;
    }

    public string GetPrompt()
    {
        // make list
        List<string> promptList = new();

        // add prompts to the list
        promptList.Add("If you could transport to the past at one time today, when would you go?");
        promptList.Add("What is the best thing you saw today?");
        promptList.Add("What were your biggest challenge today?");
        promptList.Add("What were your biggest win today?");
        promptList.Add("What is something that made you happy today?");
        promptList.Add("What is one thing you wish to forget today?");
        promptList.Add("If you had to forget everything else, what is one thing you'd choose to remember from today?");
        promptList.Add("Who were you with today?");
        promptList.Add("Who was your favorite person you talked to?");
        promptList.Add("What was your favorite thing to do today?");
        promptList.Add("What are you grateful for?");
        promptList.Add("How much of your to-do list did you get done?");
        promptList.Add("Is there anything you wish you could improve about today?");
        promptList.Add("AHHHHHHHHHHHHH");
        promptList.Add("How long have you procrastinated? (then get the thing done! >:[ )");
        promptList.Add("... *ominous noises*");

        // choose random prompt
        Random rnd = new Random();
        int index = rnd.Next(promptList.Count);
        string prompt = promptList[index];

        return prompt;
    }
}