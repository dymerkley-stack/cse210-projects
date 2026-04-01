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
    
    public Grade ViewOneGrade(Course c)
    {
        float weightSum = 0;
        float sum = 0;
        foreach(Assignment a in c.GetAssignmentAll())
        {
            if (a.GetCompleted())
            {
                sum += a.GetGrade().GetScore();//this adds up the score multiplied by the relative weight os the assignment
                weightSum += a.GetWeight();//this gets the total of all of the weights to divide later 
            }
        }
        weightSum = weightSum > 0 ? weightSum : 1;//just a little handling here to prevent divide by 0
        Grade g = new Grade(sum/weightSum);
        return g;
    }
    public abstract void DisplayCourses();
    
}