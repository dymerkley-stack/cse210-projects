public class Test : Assignment
{
    private List<Question> _questions;
    private string _answerKey;//I may get rid of this because im going to organize it such that the first option is always the correct one 
    // but when the student goes to take the test (If i even have that as part of the project for now) the stuff gets schuffled
    public Test(string name, float weight, List<Question> qList)
    : base (name, weight)
    {
        _questions = qList;
    }
    public override void DisplayAssignment(Person p)
    {
        Console.WriteLine(GetName());
        foreach (Question q in _questions)
        {
            List<string> s = q.GetOptions();
            p.DisplayAnswers(s);
        }
        
    }
}