public class StudentCourse : Course
{
    public List<Assignment> _assignments;
    

    public StudentCourse (string name, Teacher teacher, List<Assignment> assignments = null)
    : base (name, teacher)
    {
        
    }
}