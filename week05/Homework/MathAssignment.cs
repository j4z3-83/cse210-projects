using System.Security.Cryptography.X509Certificates;

public class MathAssignment : Assignment
{
    string _textbookSection;
    string _problems;

    public MathAssignment(string newName, string newTopic, string newSection, string newProblems) : base (newName, newTopic)
    {
        _textbookSection = newSection;
        _problems = newProblems;
    }

     public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }


}