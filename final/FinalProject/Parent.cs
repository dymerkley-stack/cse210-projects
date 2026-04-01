public class Parent : Person
{
    private Student _linkedChild;
    public Parent (string name, Student kid)
    : base (name)
    {
        _linkedChild = kid;
    }
    public override void ViewGradesAll()
    {
        foreach (Course c in _linkedChild.GetCourses())
        {
            ViewOneGrade(c);
        }
    }
    public override void DisplayCourses()
    {
        int i = 1;
        foreach (Course c in _linkedChild.GetCourses())
        {
            Console.WriteLine($"{i}. {c.GetName()}");
        }
    }
}