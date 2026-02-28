public class Visualization : Activity
{
    private List<string> _question = new List<string>
    {
        "What is your goal?",
        "What steps can you take today to achieve this goal?",
        "When are you going to take these steps?",
        "What is going to keep you from these steps?",
        "How can you work around this obstical?",
        "Now go out and do it."
    };
    public Visualization (string name, string description, string finish, int duration) 
    : base (name, description, finish, duration)
    {
        //hey how's it going? Enjoying my sloppy code?
    }
    public List<string> GetQuestion()
    {
        return _question;
    }
}