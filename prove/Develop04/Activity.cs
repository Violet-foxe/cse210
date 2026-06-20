public class Activity
{
    protected string _start;
    protected string _desc;
    protected string _end;
    protected int _duration; //in seconds
    public Activity()
    {
        _start = "Welcome to Generic Activity";
        _desc = "This activity will do something";
        _end = "You have completed the Activity";
        // _duration = GetDuration();
    }
    public void DisplayStart()
    {
        Console.WriteLine(_start + "\n");
        Console.WriteLine(_desc + "\n");
    }
    public void DisplayEnd()
    {
        Console.WriteLine("Well done! ");
        Spinner(2);
        Console.WriteLine(_end + "\n");
        Spinner(9);
    }
    public int GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        int length = int.Parse(Console.ReadLine());
        return length;
    }
    public void Timer(int number, int interval)
    {
        // counts down from number at a number interval
        // only works for single digit numbers
        for (int i = number; i > 0; i--)
        {
            Console.Write($"{i:D2}");
            Thread.Sleep(interval);
            Console.Write("\b\b  \b\b"); // erase the previous character
        }
    }
    public void Spinner(int seconds)
    {
        int millis = seconds * 1000;
        millis -= 300; // to account for the fade out.

        // write the frame, and wait
        // fade in
        Console.Write(".   "); Thread.Sleep(100); millis -= 100;

        Console.Write("\r"); //clear
        Console.Write(".*  "); Thread.Sleep(100); millis -= 100;

        do
        {
            // do animation
            Console.Write("\r"); // frame 1
            Console.Write(".*+ "); Thread.Sleep(200); millis -= 200;

            Console.Write("\r"); // frame 2
            Console.Write("*+. "); Thread.Sleep(200); millis -= 200;

            Console.Write("\r"); // frame 3
            Console.Write("+.* "); Thread.Sleep(200); millis -= 200;

        } while (millis > 0);
        
        // fade out
        Console.Write("\r"); //clear
        Console.Write(" +. "); Thread.Sleep(100);

        Console.Write("\r"); //clear
        Console.Write("  * "); Thread.Sleep(100);

        Console.Write("\r"); //clear
        Console.Write("   ."); Thread.Sleep(100);

        Console.Write("\r"); //clear
        Console.Write("    ");
        Console.Write("\n");
    }
    public void ForDuration(Action function, int seconds)
    {
        // find the time that the cycle needs to stop
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        DateTime currentTime;

        // if the duration is not reached,
        do
        {
            // do function
            function();
            currentTime = DateTime.Now;
        } while (currentTime < futureTime);
    }
}