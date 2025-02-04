using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("HELLO WELCOME TO MY MINECRAFT LET'S PLAY EPISODE 1", "OniPlays", 1200);
        video1.Addcomment(new Comment("Steve", "Nice you spotted that creepy"));
        video1.Addcomment(new Comment("Creeper", "Hisssss in dismay"));

        Video video2 = new Video("BLOXXING IN SWORD FIGHT IN THE HEIGHTS", "BloxxerMan420", 900);
        video2.Addcomment(new Comment("xXSlayerXx","YOO JOIN MY ROBLOX CLAN!!"));
        video2.Addcomment(new Comment("Gerald", "Hohho! the way you stole the ice dagger from him amazing!"));

        List<Video> videos = new List<Video> {video1, video2};

        foreach (Video video in videos){

            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments()){
                
                Console.WriteLine($"-{comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }


    }
}