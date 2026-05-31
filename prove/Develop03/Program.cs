using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        // Console.WriteLine("Hello Develop03 World!");

        // make scriptures
        List<Scripture> scriptureList = new();

        string book = "";
        int chapter = 0;
        string verse = "";
        string sentence = "";
        Scripture scripture = new Scripture(sentence, book, chapter, verse);
        // scriptureList.Add(scripture);

        // John 3:16 
        string book1 = "John";
        int chapter1 = 3;
        string verse1 = "16";
        string sentence1 = "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture1 = new Scripture(sentence1, book1, chapter1, verse1);
        scriptureList.Add(scripture1);

        // Proverbs 3:5-6
        string book2 = "Proverbs";
        int chapter2 = 3;
        string verse2 = "5-6";
        string sentence2 = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture2 = new Scripture(sentence2, book2, chapter2, verse2);
        scriptureList.Add(scripture2);

        // 1 Nephi 3:7
        string book3 = "1 Nephi";
        int chapter3 = 3;
        string verse3 = "7";
        string sentence3 = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        Scripture scripture3 = new Scripture(sentence3, book3, chapter3, verse3);
        scriptureList.Add(scripture3);

        // Doctrine and Covenants 4:1
        string book4 = "Doctrine and Covenants";
        int chapter4 = 4;
        string verse4 = "1";
        string sentence4 = "Now behold, a marvelous work is about to come forth among the children of men.";
        Scripture scripture4 = new Scripture(sentence4, book4, chapter4, verse4);
        scriptureList.Add(scripture4);

        // James 1:5
        string book5 = "James";
        int chapter5 = 1;
        string verse5 = "5";
        string sentence5 = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.";
        Scripture scripture5 = new Scripture(sentence5, book5, chapter5, verse5);
        scriptureList.Add(scripture5);

        // Isaiah 1:18
        string book6 = "Isaiah";
        int chapter6 = 1;
        string verse6 = "18";
        string sentence6 = "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool.";
        Scripture scripture6 = new Scripture(sentence6, book6, chapter6, verse6);
        scriptureList.Add(scripture6);

        // Alma 32:21
        string book7 = "Alma";
        int chapter7 = 32;
        string verse7 = "21";
        string sentence7 = "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.";
        Scripture scripture7 = new Scripture(sentence7, book7, chapter7, verse7);
        scriptureList.Add(scripture7);

        // choose random scripture
        // make list of scripture numbers, choose a random one
        Random rnd = new Random();
        int index = rnd.Next(scriptureList.Count);
        Scripture randomScripture = scriptureList[index];

        // display scripture
        string answer = "";
        do
        {
            // clears the console and then displays the scripture
            Console.Clear();
            randomScripture.Display();

            // write out the part for input
            Console.Write("\nPress enter to continue or type 'quit' to finish\n");
            answer = Console.ReadLine();

            // if not quit, then hide stuff
            if (answer != "quit")
            {
                // hides some of the scripture
                // will return "quit" if there is nothing more to hide
                answer = randomScripture.Hider();
            }

        } while (answer != "quit");
        Console.WriteLine();
    }
}