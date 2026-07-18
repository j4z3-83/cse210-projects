using System.Linq;

public class Word
{
    //member variables
    private string _text;
    private bool _isHidden = false;
    private string _hiddenWord;

    // constructor
    public Word(string text)
    {
        _text = text;
        Hide();
    }

    // functions
    public void Hide()
    {
        string newWord = _text;
        _hiddenWord = new string('_', newWord.Length);
        _isHidden = true;
        IsHidden();
    }

    public void Show()
    {
        
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        
        return _hiddenWord;
    }
}