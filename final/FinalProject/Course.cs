public abstract class Course
{
    private string _name;
    private Teacher _teacher;
    public Course (string name, Teacher teacher)
    {
        _name = name;
        _teacher = teacher;
    }
    
}