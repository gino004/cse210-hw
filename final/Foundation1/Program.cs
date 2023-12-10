using System;

class Program
{
    static void Main(string[] args)
    {
         Video video1 = new Video("Introduction to C#", "CodeMaster", 300);
        video1.AddComment("User1", "Great tutorial!");
        video1.AddComment("User2", "Very helpful.");

        Video video2 = new Video("Object-Oriented Programming Basics", "CodeSensei", 400);
        video2.AddComment("User3", "This clarified a lot for me.");

        Video video3 = new Video("ASP.NET Web Development", "WebWizard", 600);
        video3.AddComment("User4", "Looking forward to more content!");

        // Agregar videos a una lista
        List<Video> videoList = new List<Video> { video1, video2, video3 };

        // Mostrar información de cada video
        foreach (var video in videoList)
        {
            video.DisplayVideoInfo();
        }
    }
}