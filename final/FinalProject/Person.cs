public abstract class Person
{
    private string _name;
    public Person (string name)
    {
        _name = name;
    }
    public abstract void ViewGrades();
    public virtual void AddCourse(Course course)
    {
        //nothing to see here
        //the aprent isnt going to be able to add a couse so the default is nothing
    }
    public string GetName()
    {
        return _name;
    }
}