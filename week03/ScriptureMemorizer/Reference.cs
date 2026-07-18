using System.Reflection;

public class Reference
{
    //member variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;

    //constructor
    public Reference(string book, int chapter, int verse)
    {
        
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;        
    }

    //functions
    public string GetDisplayText()
    {
        string newReference;
        if(_endVerse == 0)
        {
            newReference = $"{_book} {_chapter}: {_verse}";
        }
        else
        {
            newReference = $"{_book} {_chapter}: {_verse}-{_endVerse}";     
        }
        return newReference;    
    }
}