using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n");
        bool quit = false;
        Scripture scrip = new Scripture();
        string book = "Proverbs";
        int chapter = 3;
        int verseStart = 5;
        int verseEnd = 6;
        do
        {
            scrip.DisplayScripture(book, chapter, verseStart, verseEnd);
            string userResponse = Console.ReadLine();
            if (userResponse == "quit")
            {
                quit = true;
            }
            else if (userResponse == "back")
            {
                scrip.RevealWords();
            }
            else
            {
                quit = !scrip.CheckListVisible();
                scrip.HideWords();
            }
        }while (!quit);
    }
}