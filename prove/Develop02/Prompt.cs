public class Prompt
{
    public List<string> _prompt { get; set; } = new List<string>
    {
        "What made you smile?",
        "How did you help someone?",
        "What makes you excited for tomorrow?",
        "What's soemthing You've been avoiding and why?",
        "When do you feel the most like yourself?",
        "Whats one belief that you have about yourself that might not be true?",
        "What drained your energy recently and what gave you energy?",
        "what can you do tomorrow that will draw you closer to God?",
        "How did you see God's hand in your life today",
        "If you lived everyday like today for all of eternity would you be happy?"
    };
    private static readonly Random rng = new Random();
    public string GetPrompt()
    {
        return _prompt[rng.Next(_prompt.Count)];
    }
    public void Display()
    {
        foreach (string s in _prompt)
        {
            Console.WriteLine(s);
        }
    }
    
    
    
}