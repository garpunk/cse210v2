using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create Videos
        Video video1 = new Video("Playing Halo in MINECRAFT", "PewDiePie", 300);
        Video video2 = new Video("Epic Speedrun", "Dream", 420);
        Video video3 = new Video("AI Writes a Movie Script", "Corridor Crew", 600);

        // Add comments
        video1.AddComment(new Comment("John", "Halo sucks"));
        video1.AddComment(new Comment("Emily", "This is hilarious!"));
        video1.AddComment(new Comment("Mike", "I love both games!"));

        video2.AddComment(new Comment("Alex", "That was insane!"));
        video2.AddComment(new Comment("Sarah", "I didn't even blink for 7 minutes."));
        video2.AddComment(new Comment("Jake", "World record?"));

        video3.AddComment(new Comment("Anna", "AI is getting too powerful..."));
        video3.AddComment(new Comment("Leo", "I want to see more of this."));
        video3.AddComment(new Comment("Tina", "This was so funny!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (var video in videos)
        {
            video.Display();
        }
    }
}
