using System;

public class word {
    private string _word;
    public string word {
        get {return _word;}
        set {word = value;}
    }
    public void Hide() {
        string hider;
        int counter = 0;
        while (counter <= _word.Length) {
            hider += "_";
            counter += 1;
        }
        _word = hider;
    }
}