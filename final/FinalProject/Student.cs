using System.Collections.Generic;
public class Student : Person
{
    private List<Course> _courses;
    public Student(string name)
    : base(name)
    {
        //You probably dont do anything either.
    }
    public void AddCourse(Course course)
    {
        throw new NotImplementedException();
    }
    public override void ViewGradesAll()
    {
        foreach (Course c in _courses)
        {
            ViewOneGrade(c);
        }
    }
    public override List<string> ShuffleOptions(List<string> list)
    {
        
        Random rand = new Random();
        
            for (int i = list.Count - 1; i > 0; i--)
            {
                int rnd = rand.Next(0, i + 1); // inclusive upper bound
                string temp = list[i];
                list[i] = list[rnd];
                list[rnd] = temp;
            }
        return list;
    }
    public List<Course> GetCourses()
    {
        return _courses;
    }
    public Course SearchCourse(string name)
    {
        for (int i = 0; i < _courses.Count; i++)
        {
            if (name == _courses[i].GetName())
            {
                return _courses[i];
            }
        }
        return _courses[0];
    }
    public Assignment SearchAssignment(Course c, string name)
    {
        List<Assignment> assignList = c.GetAssignmentAll();
        for (int i = 0; i < assignList.Count; i++)
        {
            if (name == assignList[i].GetName())
            {
                return assignList[i];
            }
        }
        return assignList[0];
    }
    public override void DisplayCourses()
    {
        int i = 1;
        foreach (Course c in _courses)
        {
            Console.WriteLine($"{i}. {c.GetName()}");
        }
    }
    public void SubmitPaper(Course c, Paper a)
    {
        Assignment systemAssign = SearchAssignment(c, a.GetName());
        if (systemAssign is Paper pap)
        {
            List<string> newPaper = a.GetStudentPaper();
            pap.UpdatePaper(newPaper);
        }
    }
    //I am adding a way to submit the different types of assignments into the class database
}