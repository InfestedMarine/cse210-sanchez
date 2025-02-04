using System;
using System.Reflection;

public class Video{

    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;


    public Video(string videoTilte, string videoAuthor, int videoLength){

        title = videoTilte;
        author = videoAuthor;
        lengthInSeconds = videoLength;
        comments = new List<Comment>();

    }

    public string GetTitle(){

        return title;
    }

    public string GetAuthor(){

        return author;
    }

    public int GetLengthInSeconds(){

        return lengthInSeconds;
    }

    public void Addcomment(Comment comment){

        comments.Add(comment);
    }

    public int GetCommentCount(){

        return comments.Count;
    }

    public List<Comment> GetComments(){

        return new List<Comment>(comments);
    }

}