public class Vice : Goal
{
    private bool _isComplete;
    public Vice(string name, string description, int points, bool comp = false)
    : base (name, description, points)
    {
        _isComplete = comp;
    }
    public override void PrintGoal()
    {
        char comp;
        comp = _isComplete ? 'X' : ' ';
        Console.WriteLine($"({comp}) {GetName()}: {GetDescription()}");
    }
    public override int RecordGoal()
    {
        int num = _isComplete ? 0 : GetPoints();
        _isComplete = true;
        return -num;
    }
    public override string StoreLine()
    {
        string line = $"{GetGoalType()}|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
        return line;
    }
}