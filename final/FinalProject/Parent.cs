public class Parent : Person
{
    private Student _linkedChild;
    public Parent (string name, Student kid)
    : base (name)
    {
        _linkedChild = kid;
    }
    public override void ViewGrades()
    {
        throw new NotImplementedException();
    }
}