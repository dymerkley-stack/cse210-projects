public class Paper : Assignment
{
    private List<string> _paper;
    private string _description;
    public Paper(string name, float weight, string description)
    : base (name, weight)
    {
        _description = description;
    }
    public override void DisplayAssignment(Person p)
    {
        Console.WriteLine($"Name: {p.GetName()}");
        Console.WriteLine($"Assignment: {GetName()}");
        Console.WriteLine($"Description: {_description}");
        foreach(string s in _paper)
        {
            Console.WriteLine(s);
        }
    }
    public List<string> GetStudentPaper()
    {
        return _paper;
    }
    public void CompletePaper(List<string> assignNew)
    {
        _paper = assignNew;
        CompleteAssignment();
    }
}