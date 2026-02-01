public class Entry
{
    public string _prompt;
    public string _entry;
    public DateTime _date;
    public Entry (string userinput, string prompt, DateTime? date = null)
    {
        _date = date ?? DateTime.Now;
        _prompt = prompt;
        _entry = userinput;
    }
}