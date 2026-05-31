public class Word
{
    private string _word;
    private bool _hidden;

// constructs the word 9, 10, 11
    public Word()
    {
        Console.WriteLine("Debugging 9");
        _word = "nom";
        _hidden = false;
    }
    public Word(string word)
    {
        // Console.WriteLine("Debugging 10");
        _word = word;
        _hidden = false;
    }
    public Word(string word, bool hidden)
    {
        Console.WriteLine("Debugging 11");
        _word = word;
        _hidden = hidden;
    }

// sends a string for a single word plus a space (also sens _s) 12
    public string Display()
    {
        // Console.WriteLine("Debugging 12");
        if (_hidden == true)
        {
            string hiddenWord = new string('_', _word.Length);
            _word = hiddenWord;
            // returns the word that is the length in underscores
            return $"{_word} ";
        }
        else
        {
            // just returns the normal word
            return $"{_word} ";
        }
    }

// returns the boolean value of whether a word is hidden or not. 13
    public bool IsHidden()
    {
        // Console.WriteLine("Debugging 13");
        return _hidden;
    }

// changes a the word to be hidden 14
    public void Hide()
    {
        // Console.WriteLine("Debugging 14");
        _hidden = true;
    }
}