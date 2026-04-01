using System.IO.Pipelines;
using System.Runtime.CompilerServices;

public class Test : Assignment
{
    private List<Question> _questions;
    private string _answerKey;//I may get rid of this because im going to organize it such that the first option is always the correct one 
    // but when the student goes to take the test (If i even have that as part of the project for now) the stuff gets schuffled
    public Test(string name, float weight, List<Question> qList)
    : base (name, weight)
    {
        _questions = qList;
    }
    public override void DisplayAssignment(Person p)
    {
        Console.WriteLine(GetName());
        foreach (Question q in _questions)
        {
            List<string> s = q.GetOptions();
            if (p is Student)
            {
                ShuffleOptions(s);
            }
            
        }
        
    }
    public void TakeTest()
    {
        float correctCount = 0;
        foreach (Question q in _questions)
        {
            Console.WriteLine(q.GetQuestion());
            List<string> newOptions = ShuffleOptions(q.GetOptions());
            int i = 0;
            foreach (string s in newOptions)
            {
                Console.WriteLine($"{i}. {s}");
            }
            int result = 0;
            do{
            string response = Console.ReadLine();
                if (int.TryParse(response, out result))
                {
                    string userAns = newOptions[result - 1];
                    if (userAns == q.GetAnswer())
                    {
                        correctCount++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number");
                }
            }while(result < 1 || result > 4);

        }
        SetGrade(new Grade(correctCount/_questions.Count));
    }
    public List<string> ShuffleOptions(List<string> list)
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
}