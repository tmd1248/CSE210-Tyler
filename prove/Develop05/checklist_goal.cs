using System;

class Checklist_Goal : Goal  {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public override void RecordEvent() {
        _amountCompleted += 1;
        if(_amountCompleted > _target) {
            _bonus += 1;
        }
    }
}