public class Scripture
{
    private List<Word> _words = new();
    private Reference _reference;

    // creates scripture from base 1
    public Scripture(List<Word> words, Reference reference)
    {
        Console.WriteLine("Debugging 1");
        _words = words;
        _reference = reference;
    }

    // creates scripture from strings 2
    public Scripture(string sentence, string book, int chapter, string verse)
    {
        // Console.WriteLine("Debugging 2");
        List<Word> words = CreateWordList(sentence);
        _words = words;
        Reference reference = new Reference(book, chapter, verse);
        _reference = reference;
    }

    // converts the sentence into a list of strings 3
    public List<Word> CreateWordList(string sentence)
    {
        // Console.WriteLine("Debugging 3");
        List<string> words = sentence.Split(' ').ToList();

        // makes a new Word list for the sentence
        List<Word> allWords = new();

        foreach (string word in words)
        {
            // makes each stringed word a Word object
            Word theWord = new Word(word);
            // adds the object theWord to the list of Words
            allWords.Add(theWord);
        }
        return allWords;
    }

    // hides some words 4
    public string Hider()
    {
        // Console.WriteLine("Debugging 4");
        
        // visible word counter
        int visible = 0;
        // goes through the whole sentence
        foreach (Word word in _words)
        {
            // looks to see if the word is hidden
            if (!word.IsHidden())
            {
                // adds to the counter
                visible++;
            }
        }

        // returns whichever number is smaller
        int wordsToHide = Math.Min(3, visible);

        Random rnd = new Random();
        // sets the counter to 0 each time it is ran
        int hiddenCount = 0;

        while (hiddenCount < wordsToHide)
        {
            // chooses a random index number using the length of _words
            int index = rnd.Next(_words.Count);

            // looks to see if the word is already hidden 
            if (!_words[index].IsHidden())
            {
                // hides the word at the index
                _words[index].Hide();
                // ups the counter
                hiddenCount++;
            }
        }

        if (visible == 0)
        {
            return "quit";
        }
        else
        {
            return "";
        }
    }

    // writes out the whole sentence 5
    public void Display()
    {
        // Console.WriteLine("Debugging 5");
        // write out the part to remember

        // turn _words into a string that can be displayed
        string verse = "";
        foreach (Word word in _words)
            verse += word.Display();

        Console.WriteLine($"{_reference.Display()} {verse}");
    }
}