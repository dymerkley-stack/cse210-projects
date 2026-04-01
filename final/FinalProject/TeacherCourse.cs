
public class TeacherCourse : Course
{
    private List<Student> _roster;
    public TeacherCourse(string name, Teacher teacher, List<Assignment> assignments = null, List<Student> roster = null)
    : base (name, teacher, assignments)
    {
        _roster = roster;
    }
    public List<Student> GetRoster()
    {
        return _roster;
    }
    public Student GetStudent(int index)
    {
        return _roster[index];
    }
}