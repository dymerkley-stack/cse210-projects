public class Question
{
    private string _question;
    private string _answer;
    private List<string> _options;
    public Question(string question, List<string> answers)
    {
        _question = question;
        int i = 0;
        foreach (string a in answers)
        {
            if (i == 0)
            {
                _answer = a;
            }
            _options.Add(a);
        }
    }
    public string GetQuestion()
    {
        return _question;
    }
    public string GetAnswer()
    {
        return _answer;
    }
    public List<string> GetOptions()
    {
        return _options;
    }
    public List<string> GetRandOptions()
    {
        
        throw new NotImplementedException();
    }
}