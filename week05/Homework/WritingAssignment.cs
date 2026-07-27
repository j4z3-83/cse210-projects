public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string newName, string newTopic, string newTitle) : base (newName, newTopic)
    {
        _title = newTitle;        
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}