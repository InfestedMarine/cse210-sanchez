using System;

class Word {

    private string _text;
    public bool IsHidden;
    
    public Word(string text){

        _text = text;
        IsHidden = false;
    }

    public string GetText(){

        return _text;
    }

    public void SetText(string text){

        _text = text;
    }

    public void Hide(){

        IsHidden = true;
        _text = new string('_', _text.Length);
    }

    public string GetDisplayText(){

        return _text;
    }
}