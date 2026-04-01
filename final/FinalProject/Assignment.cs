public abstract class Assignment
{
    private string _name;
    private Grade _grade;
    private float _weight;
    private bool _isComplete = false;
    private bool _isGraded = false;
    public Assignment(string name, float weight)
    {
        _name = name;
        _weight = weight;
    }
    public string GetName()
    {
        return _name;
    }
    public Grade GetGrade()
    {
        return _grade;
    }
    public float GetWeight()
    {
        return _weight;
    }
    public bool GetCompleted()
    {
        return _isComplete;
    }
    public void SetGrade(Grade grade)
    {
        _grade = grade;
    }
    public void CompleteAssignment()
    {
        _isComplete = true;
    }
    public bool GetGraded()
    {
        return _isGraded;
    }
    public void SetGraded()
    {
        _isGraded = true;
    }

    //i decided to get rid of the edit assignment as it would make more sense to just submit it one time and not eb constantly editing it
    public abstract void DisplayAssignment(Person p);
    
}