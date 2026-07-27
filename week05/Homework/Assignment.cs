public class Assignment
{
   protected string _studentName;
   protected string _topic;

   public Assignment(string newName, string newTopic)
    {
        _studentName = newName;
        _topic = newTopic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}