public class Journal
{
    public List<Entry> _entries {get; set;} = new List<Entry>();
    public string _name;

    
    public void DisplayEntries()
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine($"\n{e._date.ToString("dddd, MMMM dd, yyyy")}\n{e._prompt}\n{e._entry}\n");
        }
        Console.WriteLine();
    }
    public void SaveEntries()
    {
        string filename = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
        foreach (Entry e in _entries)
        {
            outputFile.WriteLine($"{e._date:o}|{e._prompt}|{e._entry}");
        }
        Console.WriteLine();
        }
    }

}