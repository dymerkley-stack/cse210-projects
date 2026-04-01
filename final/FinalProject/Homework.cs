public class Homework : Assignment
{
    private List<string> _questions;
    private List<string> _responses;
    public Homework(string name, float weight, List<string> questions)
    : base (name, weight)
    {
        _questions = questions;
    }
    public override void DisplayAssignment(Person p)
    {
        for (int i = 0; i < _questions.Count; i++)
        {
            Console.WriteLine(_questions[i]);

            if (i < _responses.Count)
            {
                Console.WriteLine(_responses[i]);
            }
            else
            {
                Console.WriteLine("No response");
            }
        }
    }
    public void CompleteHomework(List<string> responses)
    {
        _responses = responses;
        CompleteAssignment();
    }
}