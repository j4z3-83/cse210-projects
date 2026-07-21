using System;
using System.Runtime.CompilerServices;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        //video one
        Video video1 = new Video();
        video1.SetTitle("Lord of the Rings");
        video1.SetAuthor("Peter Jackson");
        video1.SetLengthInSeconds(33420);
       
        Comment comment1 = new Comment();
        comment1.SetCommenterName("Gandalf The Grey");
        comment1.SetCommentText("Fool of a Took!");
        video1._comments.Add(comment1);

        Comment comment2 = new Comment();
        comment2.SetCommenterName("Samwise Gamgee");
        comment2.SetCommentText("Po-tay-toes! Boil 'em, mash 'em, stick 'em in a stew!");
        video1._comments.Add(comment2);

        Comment comment3 = new Comment();
        comment3.SetCommenterName("Golem");
        comment3.SetCommentText("My precious.");
        video1._comments.Add(comment3);
        
        Video video = new Video();
        video._videos.Add(video1);

        //Video Two
        Video video2 = new Video();
        video2.SetTitle("The Dark Knight");
        video2.SetAuthor("Chris Nolan");
        video2.SetLengthInSeconds(9120);

        Comment comment4 = new Comment();
        comment4.SetCommenterName("Batman");
        comment4.SetCommentText("I'm not wearing hockey pads!");
        video2._comments.Add(comment4);
        
        Comment comment5 = new Comment();
        comment5.SetCommenterName("Joker");
        comment5.SetCommentText("Do you want to know how i got these scars?");
        video2._comments.Add(comment5);
        
        Comment comment6 = new Comment();
        comment6.SetCommenterName("Jim Gordon");
        comment6.SetCommentText("Because he's the hero Gotham deserves, but not the one it needs right now.");
        video2._comments.Add(comment6);

        Comment comment7 = new Comment();
        comment7.SetCommenterName("Alfred Pennyworth");
        comment7.SetCommentText("Some men just want to watch the world burn.");
        video2._comments.Add(comment7);

        video._videos.Add(video2);

        //Video Three
        Video video3 = new Video();
        video3.SetTitle("Hercules");
        video3.SetAuthor("Mickey Mouse");
        video3.SetLengthInSeconds(5580);
     
        Comment comment8 = new Comment();
        comment8.SetCommenterName("Phil");
        comment8.SetCommentText("Two words: I Am Retired.");
        video3._comments.Add(comment8);

        Comment comment9 = new Comment();
        comment9.SetCommenterName("Panic");
        comment9.SetCommentText("Wasn't Hercules The Name Of The Guy We Were Supposed To...");
        video3._comments.Add(comment9);

        Comment comment10 = new Comment();
        comment10.SetCommenterName("Meg");
        comment10.SetCommentText("I'm A Damsel. I'm In Distress. I Can Handle This. Have A Nice Day.");
        video3._comments.Add(comment10);


        video._videos.Add(video3);


        video.GetVideos();

    }
}