public class Calming : Activity
{
    private int _itemCounter;
    public Calming() : base()
    {
        _start = "Welcome to the 5-4-3-2-1 Calming Activity";
        _desc = "This activity will help you relax by walking you through the 5-4-3-2-1 sensory technique.";
    }
    public void SenseCycle(int num, string sense)
    {
        Console.Clear();
        if (num > 1)
        {
            Console.WriteLine($"What are {num} things you can {sense}?");
        }
        else
        {
            Console.WriteLine($"What is {num} thing you can {sense}?");
        }
        Console.WriteLine("Press enter when you've found one.");

        _itemCounter = 0;
        for (int i = 0; i < num; i++)
        {
            Console.Write(i+1);
            Console.ReadLine();
            _itemCounter++;
        }
    }
    public void CalmingActivity()
    {
        // write the starting messages
        Console.Clear();
        DisplayStart();

        // get ready

        Console.WriteLine("Get ready... ");
        // spinner for 5 seconds
        Spinner(5);
        Console.Clear();

        // does a function for the duration of time.
        SenseCycle(5, "see");
        SenseCycle(4, "feel");
        SenseCycle(3, "hear");
        SenseCycle(2, "smell");
        SenseCycle(1, "taste");

        // write end messages
        // i have to make the end message here so that the duration works
        Console.Clear();
        _end = $"You have completed another round of the 5-4-3-2-1 Calming Activity";
        DisplayEnd();
    }
}