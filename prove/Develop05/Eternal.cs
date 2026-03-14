public class Eternal : Goal
{
    private int _compCount;
    public Eternal(string name, string description, int points, int count = 0)
    : base (name, description, points)
    {
        _compCount = count;
    }
    public override void PrintGoal()
    {
        Console.WriteLine($"({_compCount}) {GetName()}: {GetDescription()}");
    }
    public override int RecordGoal()
    {
        _compCount++;
        return GetPoints();
    }
    public override string StoreLine()
    {
        string line = $"{GetGoalType()}|{GetName()}|{GetDescription()}|{GetPoints()}|{_compCount}";
        return line;
    }
}