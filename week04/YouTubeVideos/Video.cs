using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

public class Video
{
    //member variables
    public List <Video> _videos = new List<Video>();
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    public List <Comment> _comments = new List<Comment>();

    //functions
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public void SetLengthInSeconds(int seconds)
    {
        _lengthInSeconds = seconds;
    }
    public void GetVideos()
    {
        foreach (Video video in _videos)
        {
            Console.WriteLine("");
            Console.WriteLine("Video");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Video title: {video._title}");
            Console.WriteLine($"Video author: {video._author}");
            Console.WriteLine($"Video length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {video._comments.Count}");
            Console.WriteLine("");
            Console.WriteLine("Comments");
            Console.WriteLine(new string('-', 50));
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

        }
    }
}