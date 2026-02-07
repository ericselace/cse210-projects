using System;
using System.Collections.Generic;
using System.Transactions;
class Video
{
    public string title; 
    public string author;
     public int lengthSeconds; 
     private List<Comment> comments = new List<Comment>();
     public Video(string title, string author, int lengthSeconds)
     {
        title = title; 
        author = author; 
        lengthSeconds = lengthSeconds;

     }
     public void AddComment(Comment  comment)
    {
        comments.Add(comment);
    }
    public int GetCommentCount() 
    { 
        return comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {title}"); 
        Console.WriteLine($"Author: {author}"); 
        Console.WriteLine($"Length: {lengthSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        
        foreach (var comment in comments)
        {
            Console.WriteLine($" - {comment}");
        }
        Console.WriteLine();
    }
}