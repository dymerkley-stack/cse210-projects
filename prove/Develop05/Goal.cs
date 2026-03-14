public abstract class Goal
{
    private string _goalType;
    private string _name;
    private string _description;
    private int _points;
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _goalType = GetType().Name;
    }
    public int GetPoints()
    {
        return _points;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetGoalType()
    {
        return _goalType;
    }
    public abstract int RecordGoal();
    public abstract void PrintGoal();
    public abstract string StoreLine();

}