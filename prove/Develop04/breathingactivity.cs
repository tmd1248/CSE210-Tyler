using System;

class breathingactivity : activity {
    public ReflectingActivity () {
        _description = "This activity will assist with relaxation through measured breaths, helping you to clear your mind and focus upon this one exercise";
         _name = "Breathing Activity";
    }
    public void run() {
        DisplayStartingMessage();
        Console.writeLine("Enter the number of whole seconds you would like to run this activity for. This activity works in periods of 4 seconds.");
        _duration = Console.ReadLine();
        while(_duration > 0) {
            Console.WriteLine("Breathe In...");
            DisplayTimer(2);
            Console.WriteLine("Breathe Out...");
            DisplayTimer(2);
            _duration -= 2;
        }
        DisplayEndingMessage();
    }
}