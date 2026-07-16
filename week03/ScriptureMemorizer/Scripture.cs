using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public class Scripture
{
    //member variables
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string text;
    private List<int> numbersList = new List<int>();
    private List<string>  singleWords = new List<string>();
    private int indexNumber;
    private bool isHidden = false;
    private int wordsLeft;
    private int hiddenCount;
    private int currentHidden = 0;
    public Scripture(Reference reference, string newText)
    {
        _reference = reference;
        text = newText;
        singleWords = text.Split(' ').ToList();
        int listLength = singleWords.Count;
        wordsLeft = singleWords.Count;
        numbersList = Enumerable.Range(1, listLength).ToList();
        Random.Shared.Shuffle(CollectionsMarshal.AsSpan(numbersList));   
    }

    //functions
    public void HideRandomWords(int numberToHide)
    {
        hiddenCount = numberToHide;
        if(numberToHide >= wordsLeft)
        {
            numberToHide = wordsLeft;
        }
        wordsLeft -= numberToHide;        
        for (int i = 0; i < numberToHide; i++)
        {
            indexNumber = numbersList[0];
            Word word = new Word(singleWords[indexNumber-1]);            
            string hiddenWord = word.GetDisplayText();
            singleWords.RemoveAt(indexNumber-1);
            singleWords.Insert(indexNumber-1, hiddenWord);
            text = string.Join(" ", singleWords);
            isHidden=word.IsHidden();
            numbersList.RemoveAt(0);
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompletelyHidden()
    {
        int totalHidden = singleWords.Count;
        bool hidden = false;
        if(currentHidden >= totalHidden)
        {
            hidden = true;            
        }
        else if(isHidden)
        {
            currentHidden += hiddenCount;             
        }
        return hidden;
    }
}