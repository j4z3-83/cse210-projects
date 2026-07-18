using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public class Scripture
{
    //member variables
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _text;
    private List<int> _numbersList = new List<int>();
    private List<string>  _singleWords = new List<string>();
    private int _indexNumber;
    private bool _isHidden = false;
    private int _wordsLeft;
    private int _hiddenCount;
    private int _currentHidden = 0;

    //constructor
    public Scripture(Reference reference, string newText)
    {
        _reference = reference;
        _text = newText;
        _singleWords = _text.Split(' ').ToList();
        int listLength = _singleWords.Count;
        _wordsLeft = _singleWords.Count;
        _numbersList = Enumerable.Range(1, listLength).ToList();
        Random.Shared.Shuffle(CollectionsMarshal.AsSpan(_numbersList));   
    }

    //functions
    public void HideRandomWords(int numberToHide)
    {
        _hiddenCount = numberToHide;
        if(numberToHide >= _wordsLeft)
        {
            numberToHide = _wordsLeft;
        }
        _wordsLeft -= numberToHide;        
        for (int i = 0; i < numberToHide; i++)
        {
            _indexNumber = _numbersList[0];
            Word word = new Word(_singleWords[_indexNumber-1]);            
            string hiddenWord = word.GetDisplayText();
            _singleWords.RemoveAt(_indexNumber-1);
            _singleWords.Insert(_indexNumber-1, hiddenWord);
            _text = string.Join(" ", _singleWords);
            _isHidden=word.IsHidden();
            _numbersList.RemoveAt(0);
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {_text}";
    }

    public bool IsCompletelyHidden()
    {
        int totalHidden = _singleWords.Count;
        bool hidden = false;
        if(_currentHidden >= totalHidden)
        {
            hidden = true;            
        }
        else if(_isHidden)
        {
            _currentHidden += _hiddenCount;             
        }
        return hidden;
    }
}