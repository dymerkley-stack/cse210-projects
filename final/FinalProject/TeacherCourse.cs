
public class TeacherCourse : Course
{
    private List<Assignment> _assignments;
    private List<Student> _roster;
    public TeacherCourse(string name, Teacher teacher, List<Assignment> assignments = null, List<Student> roster = null)
    : base (name, teacher)
    {
        _assignments = assignments;
        _roster = roster;
    }
    public Assignment GetAssignment(int index)
    {
        return _assignments[index];
    }
    public List<Assignment> GetAssignmentAll()
    {
        return _assignments;
    }
    public List<Student> GetRoster()
    {
        return _roster;
    }
    public void AddAssignment(Assignment a)
    {
        _assignments.Add(a);
    }
}