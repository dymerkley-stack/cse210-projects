using Microsoft.VisualBasic;

public class Scripture
{
    private string _scripture = "Trust in the LORD with all your heart and lean not on your own understanding;"
    + " in all your ways acknowledge him, and he will make your paths straight.";
    private List<Word> _ScriptureWords = new List<Word>();
    public Scripture()
    {
        string[] splitOmatic = _scripture.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string w in splitOmatic)
        {
            _ScriptureWords.Add(new Word(w));
        }
    }
    public void HideWords()
    {
        Random rand = new Random();
        for (int i = 0; i<3; i++)
        {
            bool check = CheckListVisible();
            while(check)
            {
                int pick = rand.Next(0, _ScriptureWords.Count);
                if (_ScriptureWords[pick].GetHidden())
                {
                    _ScriptureWords[pick].SetHidden(false);
                    check = false;
                }
            }
        }
    }
    public bool CheckListVisible()
    {
        for (int i = 0; i < _ScriptureWords.Count; i++)
        {
            if (_ScriptureWords[i].GetHidden())
            {
                return true;
            }
        }
        return false;
    }
    public void DisplayScripture(string book, int chapter, int verseStart, int verseEnd = 0)
    {
        Reference r = new Reference(book, chapter, verseStart, verseEnd);
        Console.SetCursorPosition(0, Console.CursorTop - 2);
        string refe = r.GetReference();
        Console.WriteLine(refe);
        foreach(Word w in _ScriptureWords)
        {
            string wordstring = w.GetWord();
            bool vis = w.GetHidden();
            if (vis)
            {
                string newWord = w.GetWord();
                Console.Write($"{newWord} ");
            }
            else
            {
                string newWord = string.Concat(w.GetWord().Select(c => char.IsLetter(c) ? '_' : c));
                Console.Write($"{newWord}     ");
            }
        }
    }
    public void RevealWords()
    {
        Random rand = new Random();
        for (int i = 0; i<3; i++)
        {
            bool check = CheckListHidden();
            while(check)
            {
                int pick = rand.Next(0, _ScriptureWords.Count);
                if (!_ScriptureWords[pick].GetHidden())
                {
                    _ScriptureWords[pick].SetHidden(true);
                    check = false;
                }
            }
        }
    }
    private bool CheckListHidden()
    {
        for (int i = 0; i < _ScriptureWords.Count; i++)
        {
            if (!_ScriptureWords[i].GetHidden())
            {
                return true;
            }
        }
        return false;
    }
}//i am converting the word to a series of dashes