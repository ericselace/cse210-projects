using System;

class Program
{
    static void Main()
    {
       Video video1 = new Video("Learning C#", "Alice", 600);
       Video video2 = new Video("Physics Explained", "Bob", 1200); 
       Video video3 = new Video("Cooking Pasta", "Charlie", 900); 

       video1.AddComment(new Comment("John", "Great explanation!")); 
       video1.AddComment(new Comment("Sarah", "Very helpful, thanks.")); 
       video1.AddComment(new Comment("Mike", "Can you cover LINQ next?"));

       video2.AddComment(new Comment("Anna", "Relativity is mind-blowing.")); 
       video2.AddComment(new Comment("Tom", "Clear and concise.")); 
       video2.AddComment(new Comment("Lucy", "Loved the derivation!"));

       video3.AddComment(new Comment("Emma", "Yummy recipe!")); 
       video3.AddComment(new Comment("David", "Tried it, came out perfect.")); 
       video3.AddComment(new Comment("Sophia", "Can you do lasagna next?"));


       List<Video> videos = new List<Video> { video1, video2, video3 };

       foreach (Video video in videos) 
       { 
        video.DisplayInfo(); 
       }

    }
}