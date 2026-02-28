public class Listing : Activity
{
    private List<string> _prompt;
    private int _count = 0;
    public Listing (string name, string description, string finish, int duration) 
    : base (name, description, finish, duration)
    {
        _prompt = new List<string>
        {
            "Who has inspired you recently?",
            "What talents or skills are you proud of?",
            "Who has made a positive difference in your life this week?",
            "When have you felt grateful this month?",
            "Who do you look up to and why?",
            "What challenges have you overcome recently?",
            "Who in your life deserves more appreciation?",
            "What personal achievements are you proud of?",
            "When have you acted with kindness this week?",
            "Who are people you can learn from?"
        };
    }
    public void RunPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompt.Count);
        string randomPrompt = _prompt[index];
        Console.WriteLine(randomPrompt);

        
    }
    public void GetResponses(int count)
    {
        Console.ReadLine();
        count++;
        _count = count;
    }
    public void SetCount(int count)
    {
        _count = count;
    }
    public int GetCount()
    {
        return _count;
    }

}