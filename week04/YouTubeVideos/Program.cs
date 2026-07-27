using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold all videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to make a paper kite", "Paper kite", 1300);
        video1.AddComment(new Comment("John", "This was super helpful!"));
        video1.AddComment(new Comment("Matthew", "I finally understand how to make a paper kite neatly."));
        video1.AddComment(new Comment("tega", " Please can you do one more explanation in another video?"));
        videos.Add(video1);

        Video video2 = new Video("The Earth and it's Mystery", "Wanderlust TV", 1540);
        video2.AddComment(new Comment("Johan", " There are so many interesting things on earth!"));
        video2.AddComment(new Comment("Anna", "The footage was  really amazing."));
        video2.AddComment(new Comment("mary", "Earth is underrated."));
        video2.AddComment(new Comment("Love ", " I Love this video!"));
        videos.Add(video2);

        Video video3 = new Video("How to pizza", "Kitchen Basics", 950);
        video3.AddComment(new Comment("Mama", "My first pizza turned out great!"));
        video3.AddComment(new Comment("Jubith", "What kind of flour did you use for this video?"));
        video3.AddComment(new Comment("precious", "Thanks, Awesome."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}