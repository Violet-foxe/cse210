public class Reflecting : Activity
{
    private List<string> _promptList;
    private List<string> _reflectList;
    public Reflecting() : base()
    {
        _start = "Welcome to the Reflecting Activity";
        _desc = "This activity will help you reflect on times in your life " +
        "when you have shown strength and resilience. " +
        "This will help you recognize the power you have " +
        "and how you can use it in other aspects of your life.";
        _reflectList = CreateReflectList();
        _promptList = CreatePromptList();
    }
    public List<string> CreatePromptList()
    {
        List<string> theList = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        return theList;
    }
    public List<string> CreateReflectList()
    {
        List<string> theList = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
        return theList;
    }
    public string GetListItem(List<string> list)
    {
        int randomIndex = Random.Shared.Next(list.Count);
        string listItem = list[randomIndex];
        return listItem;
    }
    public void AskQuestion()
    {
        string reflection = GetListItem(_reflectList);
        Console.WriteLine($"> {reflection}");
        Spinner(10);
    }
    public void ReflectActivity()
    {
        // write the starting messages
        Console.Clear();
        DisplayStart();
        _duration = GetDuration(); // and get duration
        // (i have to do it here, so it is in the right order)

        Console.Clear();
        // do activity
        Console.WriteLine("Get ready... ");
        Spinner(5);
        string thePrompt = GetListItem(_promptList);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" ---{thePrompt}--- \n");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Timer(15, 1000);

        Console.Clear();
        ForDuration(AskQuestion, _duration);

        // end
        // i have to make the end message here so that writing the duration works
        _end = $"You have completed another {_duration} seconds of the Reflecting Activity";
        DisplayEnd();
    }
}