using System;
using System.Transactions;

public class Video {
    private string title;
    private string author;
    private int length; 
    private List<Comment> comments = new List<Comment>();

    public string Title{
        get {return title;}
        set {title = value;}
    }
    public string Author {
        get {return author;}
        set {author = value;}
    }
    public int Length {
        get {return length;}
        set {length = value;}
    }

    public void add_comment(Comment comment) {
        comments.Add(comment);
    }
    public List<Comment> get_comments() {
        return comments;
    }
}