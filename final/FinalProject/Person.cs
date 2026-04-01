public abstract class Person
{
    private string _name;
    public Person (string name)
    {
        _name = name;
    }
    public virtual void ViewGradesAll(){}
    
    public string GetName()
    {
        return _name;
    }
    public virtual List<string> ShuffleOptions(List<string> s)
    {
        return s;
    }
    public Grade ViewOneGrade(Course c)
    {
        int compCount = 0;
        float sum = 0;
        foreach(Assignment a in c.GetAssignmentAll())
        {
            if (a.GetCompleted())
            {
                sum += a.GetGrade().GetScore();
                compCount ++;
            }
        }
        compCount = compCount > 0 ? compCount : 1;
        Grade g = new Grade(sum/compCount);
        return g;
    }
    public abstract void DisplayCourses();
    
}