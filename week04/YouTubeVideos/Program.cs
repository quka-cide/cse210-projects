using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Exploring C#", "John Doe", 300);
        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 450);
        Video video3 = new Video("C# Design Patterns", "Emily Johnson", 600);

        video1.AddComments("Alice", "Great explanation!");
        video1.AddComments("Bob", "Very helpful, thanks!");
        video1.AddComments("Charlie", "Can you cover LINQ next?");

        video2.AddComments("David", "Loved the deep dive!");
        video2.AddComments("Anna", "Very helpful! Thank you.");
        video2.AddComments("Eve", "Can you explain async/await in detail?");

        video3.AddComments("Frank", "Really useful content.");
        video3.AddComments("Grace", "Best video on this topic!");
        video3.AddComments("Hannah", "Waiting for more!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}