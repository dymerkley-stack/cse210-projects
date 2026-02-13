public class Word
{
    public Word(string w)
    {
        _word = w;
    }
    private string _word;
    private bool _hidden = true;
    public void SetWord(string word)
    {
        _word = word;
    }
    public string GetWord()
    {
        return _word;
    }
    public void SetHidden(bool value)
    {
        _hidden = value;
    }
    public bool GetHidden()
    {
        return _hidden;
    }

}