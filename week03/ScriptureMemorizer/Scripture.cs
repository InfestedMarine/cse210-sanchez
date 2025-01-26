using System;

class Scripture{

    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text){

        _reference = reference;
        _words = new List<Word>();

        foreach (var word in text.Split(' ')){

            _words.Add(new Word(word));
        }
    }

    public void HideRandomWrds(){

        Random random = new Random();
        var visibleWords = _words.FindAll( w => !w.IsHidden);

        if (visibleWords.Count == 0) return;

        var randomWord = visibleWords[random.Next(visibleWords.Count)];
        randomWord.Hide();
    }

    public void DisplayText(){

        Console.Clear();
        Console.WriteLine(_reference.GetDisplayText());
        foreach (var word in _words){
            
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }
}
