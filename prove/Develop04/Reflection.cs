using System.Diagnostics;
using System.Threading;

public class Reflection : Activity
{
    private int _questionTime;
    private List<string> _reflectPrompt = new List<string>
    {
        "Think of a time when you forgave someone.",
        "Think of a time when you overcame a fear.",
        "Think of a time when you learned from a mistake.",
        "Think of a time when you showed courage.",
        "Think of a time when you stepped outside your comfort zone.",
        "Think of a time when you kept going even though you wanted to quit.",
        "Think of a time when you made a positive difference.",
        "Think of a time when you were honest even when it was hard.",
        "Think of a time when you took responsibility for your actions.",
        "Think of a time when you supported a friend during a tough moment."
    };
    private List<string> _reflectQuestion = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "What challenges did you face along the way?",
        "How did you overcome those challenges?",
        "Who, if anyone, supported you during this experience?",
        "What would you do differently if you could do it again?",
        "What strengths did you discover or use?",
        "How has this experience changed you?"
    };

    public Reflection(string name, string description, string finish, int duration, int qtime) 
    : base (name, description, finish, duration)
    {
        _questionTime = qtime;

    }
    public void RunPrompt()
    {
        Random random = new Random();

        int index = random.Next(_reflectPrompt.Count);
        string randomPrompt = _reflectPrompt[index];

        Console.WriteLine(randomPrompt);
    }
    public void RunQuestion()
    {
        Random random = new Random();
        Stopwatch stopwatch = Stopwatch.StartNew();
        TimeSpan duration = TimeSpan.FromSeconds(GetDuration());

        while (stopwatch.Elapsed < duration)
        {
            int index = random.Next(_reflectQuestion.Count);
            string randomQuestion = _reflectQuestion[index];
            Console.WriteLine($"\r{randomQuestion}");
            for (int i = _questionTime/2; i > 0; i--)
            {
                DoTheWave();
            }
        }

    }
}