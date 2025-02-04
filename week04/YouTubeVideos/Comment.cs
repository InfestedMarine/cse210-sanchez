using System;

public class Comment{

    private string commenterName;
    private string text;

    public Comment(string name, string CommentText){

        commenterName = name;
        text = CommentText;
        
    }

    public string GetCommenterName(){

        return commenterName;
    }

    public string GetText(){

        return text;
    }
}