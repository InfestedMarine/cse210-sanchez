using System;

class Reference{

    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse){
        
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse){

        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText(){

        if (_endVerse.HasValue)
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        else
            return $"{_book} {_chapter}:{_verse}";
        
    }

    public string GetBook(){

        return _book;
    }

    public int GetChapter(){

        return _chapter;
    }

    public int Getverse(){

        return _verse;
    }

    public int? GetEndVerse(){

        return _endVerse;
    }
}
