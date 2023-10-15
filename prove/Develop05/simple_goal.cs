using System;

class Simple_Goal : Goal  {
    private bool _isComplete;
    public bool isComplete {
        get {return _isComplete;}
        set {_isComplete = value;}
    }
    public override void RecordEvent() {
        _isComplete == true;
    }
}