using System;
using System.Runtime.InteropServices;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        bool quit = true;
        Prompt prompt = new Prompt();
        Journal journal = new Journal();

        while (quit){
            Console.WriteLine("Welcome to the diary of a wimpy kid.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Add prompt");
            Console.WriteLine("4. Display Prompts");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Quit");
            int userinput = int.Parse(Console.ReadLine());
            if (userinput == 1)
            {
                string currentPrompt = prompt.GetPrompt();
                Console.WriteLine(currentPrompt);
                string userResponse = Console.ReadLine();
                Entry userentry = new Entry(userResponse, currentPrompt);
                journal._entries.Add(userentry);
            }
            else if (userinput == 2)
            {
                journal.DisplayEntries();
            }
            else if (userinput == 3)
            {
                string userPrompt = Console.ReadLine();
                prompt._prompt.Add(userPrompt);
            }
            else if (userinput == 4)
            {
                prompt.Display();
            }
            else if (userinput == 5) 
            {   
                journal.SaveEntries();   
            }
            else if (userinput == 6)
            {
                List<Entry> items = new List<Entry>();

                string filename = "myFile.txt";
                string[] lines = File.ReadAllLines(filename);
                
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt1 = parts[1];
                    string entry1 = parts[2];
                
                    journal._entries.Add(new Entry(entry1, prompt1, date));
                }
            }
            else if (userinput == 7)
            {
                quit = false;
            }
            else
            {
                while (userinput < 1 || userinput > 6)
                {
                    Console.WriteLine("Invalid Response please try again.");
                    userinput = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}