public class Teacher : Person
{
    private List<Course> _courses;
    public Teacher (string name)
    : base (name)
    {
        //you will do nothing because you can do nothing
    }
    public override void ViewGrades()
    {
        //add in where it goes through the courses and prints off all of the kids and their grades
        //it might be cool to add in where the teacher can look at the individual kids and show all of their assignments
    }
    public override void AddCourse(Course course)
    {
        _courses.Add(course);
    }
    public void ViewPendingAssignments()
    {
        //to do
    }
    public void CreateAssignment()
    {
        //to do
    }
}