public class Grade
{
    private float _score;
    private char _letter;
    public float GetScore()
    {
        if(_score >= 90)
        {
            _letter = 'A';
        }
        else if (_score >= 80)
        {
            _letter = 'B';
        }
        else if (_score >= 70)
        {
            _letter = 'C';
        }
        else if (_score >= 60)
        {
            _letter = 'D';
        }
        else
        {
            _letter = 'F';
        }
        
        return _score;
    }
    public char GetLetter()
    {
        return _letter;
    }
    public void SetScore(float score)
    {
        _score = score;
    }
}