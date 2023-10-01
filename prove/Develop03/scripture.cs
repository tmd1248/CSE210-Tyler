using System;

public class scripture {
    private string[] scriptureHolder;
    private int counter = 0;
    private string scriptureReturn;
    
    List<word> _scripture = new List<word>();
    List<int> hiddenWords = new List<int>();
    public string scripture {
        get {
            while (counter <= _scripture.Count()) {
                scriptureReturn += _scripture[counter].word + " ";
                counter += 1;
            }
            return scriptureReturn;
            } 
        set {scriptureHolder = value.Split(' ');
            foreach (var wordToBeAdded in scriptureHolder) {
                Word word = new Word();
                word.word = wordToBeAdded;
                _scripture.add(word);
        }
        }
    }
    
    public void HideRandomWords() {
        Random rand = new Random();
        bool tracker = false;
        while (tracker == false) {
            int selection = rand.next(_scripture.Count);
            if (hiddenWords.Contains(selection) == false) {
                _scripture[selection].Hide();
                hiddenWords.add(selection);
                tracker = true;
            }
        }
    }

}