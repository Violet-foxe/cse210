public class Breathing : Activity
{
    public Breathing() : base()
    {
        _start = "Welcome to Breathing Activity";
        _desc = "This activity will help you relax by walking you through breathing in and out slowly." +
        "\nClear your mind and focus on your breathing.";
    }
    public void BreathCycle()
    {
        // one cycle of breathing

        // breath in
        Console.Write("Breath in...");
        // count down from 4, second between counts
        Timer(4, 1000);
        // breath out
        Console.Write("\nNow breathe out...");
        // count down from 6
        Timer(6, 1000);
        Console.WriteLine("\n");
    }
    public void BreathActivity()
    {
        // write the starting messages
        Console.Clear();
        DisplayStart();
        // get the duration of the activity 
        // (i have to do it here, so it is in the right order)
        _duration = GetDuration();

        // get ready
        Console.Clear();


        Console.WriteLine("Get ready... ");
        // spinner for 5 seconds
        Spinner(5);

        // does a function for the duration of time.
        ForDuration(BreathCycle, _duration);

        // write end messages
        // i have to make the end message here so that the duration works
        _end = $"You have completed another {_duration} seconds of the Breathing Activity";
        DisplayEnd();
    }
}