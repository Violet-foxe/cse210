using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        // Console.WriteLine("Hello Develop03 World!");

        // GET SCRIPTURE
        // search library file
        string filename = "library.csv";
        string[] lines = File.ReadAllLines(filename);

        Random random = new Random();
        // finds a random index
        int randomIndex = random.Next(lines.Length);
        // using that index, choose a random line
        string randomLine = lines[randomIndex];

        // uses | as a separator
        string[] parts = randomLine.Split('|');

        // parse the line
        string book = parts[0];
        int chapter = int.Parse(parts[1]);
        string verse = parts[2];
        string sentence = parts[3];
        Scripture randomScripture = new Scripture(sentence, book, chapter, verse);

        // DISPLAY SCRIPTURE
        string answer = "";
        do
        {
            // clears the console and then displays the scripture
            Console.Clear();
            randomScripture.Display();

            // write out the part for input
            Console.Write("\nPress enter to continue or type 'quit' to finish\n");
            answer = Console.ReadLine();

            // adds a new verse to practice to the library
            if (answer == "add")
            {
                // appends it to the end
                using (StreamWriter outputFile = new StreamWriter(filename, append: true))
                {
                    // each part needed
                    Console.Write("Book: ");
                    string addBook = Console.ReadLine();
                    Console.Write("Chapter #: ");
                    string addChapter = Console.ReadLine();
                    Console.Write("Verse #(s): ");
                    string addVerse = Console.ReadLine();
                    Console.Write("Content: ");
                    string addSentence = Console.ReadLine();

                    // send the info to the file
                    outputFile.WriteLine($"{addBook}|{addChapter}|{addVerse}|{addSentence}");
                }
            }

            // if not quit, then hide stuff
            else if (answer != "quit")
            {
                // hides some of the scripture
                // will return "quit" if there is nothing more to hide
                answer = randomScripture.Hider();
            }

        } while (answer != "quit");
        Console.WriteLine();
    }
}

// Stretch:
// i made a list of scriptures that can be chosen at random from a seperate library file
// the program only hides words that haven't already been hidden
// made a hidden add scripture option that lets you input any scripture you want by typing "add"
    // yes, you can pull from your entries for future memorization. 
    // Rin, Nak, and Kir are my additions.