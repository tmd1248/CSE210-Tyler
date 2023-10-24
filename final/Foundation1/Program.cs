using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        for(int x = 0; x < 3; x++) {
            Video video = new Video
            {
                Author = "testAuthor" + x.ToString(),
                Title = "testVideo" + x.ToString(),
                Length = 55 + x
            };
            for (int y = 0; y < 3; y++) {
                Comment comment = new Comment
                {
                    Author = "testVideo " + x + " CommentAuthor" + y.ToString(),
                    Text = "I am typing the number " + y.ToString()
                };
                video.add_comment(comment);
            }
            videos.Add(video);
        }
        foreach(Video video in videos) {
            Console.WriteLine("Author " + video.Author);
            Console.WriteLine("Title " + video.Title);
            Console.WriteLine("Length " + video.Length);
            List<Comment> comments = new List<Comment>();
            comments = video.get_comments();
            foreach (Comment comment in comments) {
                Console.WriteLine("Comment author " + comment.Author);
                Console.WriteLine("Comment Text " + comment.Text);
            }
        }
    }
}