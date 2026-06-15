public class Listing : Activity
{
    private List<string> _promptList;
    private int _itemCounter;
    public Listing() : base()
    {
        _start = "Welcome to the Listing Activity";
        _desc = "This activity will help you reflect on the good things in your life " +
        "by having you list as many things as you can in a certain area.";
        _promptList = CreatePromptList();
    }
    public List<string> CreatePromptList()
    {
        List<string> theList = [
           " Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        ];
        return theList;
    }
    public string GetListItem(List<string> list)
    {
        int randomIndex = Random.Shared.Next(list.Count);
        string listItem = list[randomIndex];
        return listItem;
    }
    public void TypeList()
    {
        Console.Write("> ");
        Console.ReadLine();
        _itemCounter +=1;
    }
    public void ListingActivity()
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
        string prompt = GetListItem(_promptList);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" ---{prompt}--- ");
        Console.Write("You may begin in: ");
        Timer(9, 1000);

        ForDuration(TypeList, _duration);

        Console.WriteLine($"\nYou listed {_itemCounter} items!");

        // end
        // i have to make the end message here so that writing the duration works
        _end = $"You have completed another {_duration} seconds of the Reflecting Activity";
        DisplayEnd();
    }
}