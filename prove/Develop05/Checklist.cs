public class Checklist : Goal
{
    private int _bonusPoints;
    private int _compCount;
    private int _goalNum;
    private bool _isComplete;

    public Checklist(string name, string description, int points, int bonus, int goalnum, int count = 0, bool comp = false)
    : base (name, description, points)
    {
        _bonusPoints = bonus;
        _compCount = count;
        _goalNum = goalnum;
        _isComplete = comp;
    }
    public override void PrintGoal()
    {
        char comp = _isComplete ? 'X' : ' ';
        Console.WriteLine($"({comp}) {GetName()}: {GetDescription()}. {_compCount}/{_goalNum}");
    }
    public override int RecordGoal()
    {
        _compCount++;
        int num = _compCount == _goalNum ? _bonusPoints : 0;
        _isComplete = _compCount >= _goalNum ? true : false;
        num += GetPoints();
        return num;
    }
    public override string StoreLine()
    {
        string line = $"{GetGoalType()}|{GetName()}|{GetDescription()}|{GetPoints()}|{_goalNum}|{_bonusPoints}|{_compCount}|{_isComplete}";
        return line;
    }
}