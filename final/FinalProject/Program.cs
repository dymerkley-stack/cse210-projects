using System;

class Program
{
    static void Main(string[] args)
    {



        List<Assignment> courseWork = new List<Assignment>
        {
            
        };
        
        
        Teacher t1 = new Teacher ("Mr. Johnson");
        
        Person s1 = new Student ("Jared");
        Person s2 = new Student ("John");
        Person s3 = new Student ("Jason");
        Person s4 = new Student ("Mike");
        Person s5 = new Student ("Noah");

        Course math1 = new TeacherCourse("Math", t1);
    }
}