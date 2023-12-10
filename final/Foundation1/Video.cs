using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int DurationInSeconds { get; set; }

    private List<Comment> comments;

    public Video(string title, string author, int durationInSeconds)
    {
        Title = title;
        Author = author;
        DurationInSeconds = durationInSeconds;
        comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment newComment = new Comment(commenterName, commentText);
        comments.Add(newComment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Duration: {DurationInSeconds} seconds");
        Console.WriteLine($"Comment Count: {GetCommentCount()}");

        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine($" - {comment.CommenterName}: {comment.CommentText}");
        }

        Console.WriteLine();
    }
}
