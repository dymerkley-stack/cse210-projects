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
        throw new NotImplementedException();
    }
}