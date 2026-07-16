using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.FileIO;

public class ScriptureLibrary
{
    private string filename = "scriptures.csv";
    List<string> books = new List<string>();
    List<int> chapters = new List<int>();
    List<int> verses = new List<int>();
    List<int> endVerses = new List<int>();
    List<string> texts = new List<string>();
    private string book;
    private int chapter;
    private int verse;
    private int endVerse;
    private string text;
    Random rand = new Random();
    public ScriptureLibrary()
    {
        
    }
    
    public (string book, int chapter, int verse, int endVerse, string text) GetScriptureReference()
    {
        var scriptures = new List<string[]>();

        using (TextFieldParser parser = new TextFieldParser(filename))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            parser.HasFieldsEnclosedInQuotes = true;

            if(!parser.EndOfData)
            {
                parser.ReadLine();
            }

            while(!parser.EndOfData)
            {
                string[] lines = parser.ReadFields();
                scriptures.Add(lines);
                books.Add(lines[0]);
                chapters.Add(int.Parse(lines[1]));
                verses.Add(int.Parse(lines[2]));
                if(lines[3] == "")
                {
                    endVerses.Add(0);
                }
                else
                {
                    endVerses.Add(int.Parse(lines[3]));
                }
                texts.Add(lines[4]);                
            }
            int referenceIndex = rand.Next(0, books.Count);
            book = books[referenceIndex];
            chapter = chapters[referenceIndex];
            verse = verses[referenceIndex];
            endVerse = endVerses[referenceIndex];
            text = texts[referenceIndex];
        }
        return (book, chapter, verse, endVerse, text);
    }
}