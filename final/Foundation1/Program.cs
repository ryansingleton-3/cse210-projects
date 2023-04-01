using System;

class Program
{
    static void Main(string[] args)
    {
        VideoList videoList = new VideoList();
        Video video1 = new Video("Dwyane Wade is the best baller of all time", "Ryan Singleton", 350);
        videoList._videos.Add(video1);
        Comment comment1 = new Comment("You got that right!", "Dwyane Wade");
        Comment comment2 = new Comment("Couldn't agree more!", "ESPN");
        Comment comment3 = new Comment("LeBron is better", "LebronFan4475");
        Comment comment4 = new Comment("This is awesome", "RandomPerson123");
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        video1._comments.Add(comment4);
        



        Video video2 = new Video("My cat fell asleep on me", "RandomUser555", 25);
        videoList._videos.Add(video2);
        Comment comment5 = new Comment("aww, that happens to me all of the time too!", "CatLover345");
        Comment comment6 = new Comment("Cats are the worst", "DogPerson123");
        Comment comment7 = new Comment("Dogs are way better", "CoolPerson123");
        Comment comment8 = new Comment("What is the cat's name?", "InterestedGuy123");
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        video2._comments.Add(comment7);
        video2._comments.Add(comment8);



        Video video3 = new Video("General Conference April 2023 Sunday Morning Session", "The Church of Jesus Christ of Latter-Day Saints", 7200);
        videoList._videos.Add(video3);
        Comment comment9 = new Comment("I love general conference", "DevotedMember123");
        Comment comment10 = new Comment("I loved President Nelson's talk the most!", "AnotherDevotedMember");
        Comment comment11 = new Comment("I loved the talk about repentance", "HumbleGuy123");
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);
        video3._comments.Add(comment11);



        videoList.ShowVideoList();

        
    }
}