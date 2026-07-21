public class Comment
{
    //member variable
    private string _commenterName;
    private string _commentText;

    //functions
    public string GetCommenterName()
    {
        return _commenterName;
    }

    public void SetCommenterName(string Name)
    {
        _commenterName = Name;
    }

    public string GetCommentText()
    {
        return _commentText;
    }

    public void SetCommentText(string text)
    {
        _commentText = text;
    }
}