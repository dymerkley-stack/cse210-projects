public abstract class Course
{
    private string _name;
    private Teacher _teacher;
    private List<Assignment> _assignments;
    public Course (string name, Teacher teacher, List<Assignment> assignments = null)
    {
        _name = name;
        _teacher = teacher;
        _assignments = assignments;
    }
    public Assignment GetAssignment(int index)
    {
        return _assignments[index];
    }
    public List<Assignment> GetAssignmentAll()
    {
        return _assignments;
    }
    public void AddAssignment(Assignment a)
    {
        _assignments.Add(a);
    }
    public string GetName()
    {
        return _name;
    } 
    
}