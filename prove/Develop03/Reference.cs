public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }
    public Reference(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
    }
    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerseStart()
    {
        return _verseStart;
    }
    public int GetVerseEnd()
    {
        return _verseEnd;
    }
    public string GetReference()
    {
        string thing;
        if (_verseEnd != 0)
        {
            thing = $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
        else
        {
            thing = $"{_book} {_chapter}:{_verseStart}";
        }
        return thing;
    }
}