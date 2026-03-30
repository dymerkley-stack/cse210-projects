public class Student : Person
{
    
    public Student(string name)
    : base(name)
    {
        //You probably dont do anything either.
    }
    public override void AddCourse(Course course)
    {
        throw new NotImplementedException();
    }
    public override void ViewGrades()
    {
        throw new NotImplementedException();
    }
}