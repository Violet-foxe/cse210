public class Reference
{
    private string _book;
    private int _chapter;
    private string _verse;

    // constructors to make a reference 6, 7
    public Reference()
    {
        Console.WriteLine("Debugging 6");
        _book = "No Book";
        _chapter = 0;
        _verse = "";
    }
    public Reference(string book, int chapter, string verse)
    {
        // Console.WriteLine("Debugging 7");
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

// displays the reference 8
    public string Display()
    {
        // Console.WriteLine("Debugging 8");
        return $"{_book} {_chapter}:{_verse}";
    }
}