public class Teacher : Person
{
    private List<TeacherCourse> _courses;
    public Teacher (string name)
    : base (name)
    {
        //you will do nothing because you can do nothing
    }
    public void ViewGradesTeach(int CourseIndex)
    {

        foreach (Student s in _courses[CourseIndex].GetRoster())
        {

            Grade g = ViewOneGrade(s.SearchCourse(_courses[CourseIndex].GetName()));
            //Its very complicated but s.search will return a course
            //The course is searched by taking the course the teacher selected for and using the name as a keword
            //I coundn't just use the same index because the student is going to have a different index
            Console.WriteLine($"Student: {s.GetName()}. Grade: {g.GetScore()}, {g.GetLetter()}");
        }
    }
    public void AddCourse(TeacherCourse course)
    {
        _courses.Add(course);
    }
    public void ViewPendingAssignments(TeacherCourse c)
    {
        foreach(Student s in c.GetRoster())
        {
            Course stud = s.SearchCourse(c.GetName());
            foreach (Assignment a in stud.GetAssignmentAll())
            {
                if (a.GetCompleted() && !a.GetGraded())
                {
                    a.DisplayAssignment(this);
                }
            }
        }
    }
    public void CreateAssignment()
    {
        //to do
    }
    public override void DisplayCourses()
    {
        int i = 1;
        foreach (Course c in _courses)
        {
            Console.WriteLine($"{i}. {c.GetName()}");
        }
    }
    public void GradeAssignment(TeacherCourse t, int studentIndex, int assignmentIndex, float grade)
    {
        //I want to keep this in for posterity
        //t.GetStudent(studentIndex).SearchCourse(t.GetName()).GetAssignment(assignmentIndex).GetGrade().SetScore(grade);
        Student student = t.GetStudent(studentIndex);
        Course course = student.SearchCourse(t.GetName());
        Assignment assignment = course.GetAssignment(assignmentIndex);
        Grade gradeObj = assignment.GetGrade();

        gradeObj.SetScore(grade);
        assignment.SetGraded();
    }
    
}