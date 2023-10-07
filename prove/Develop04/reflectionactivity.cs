using System;

class reflectionactivity : activity {
    private List<string> _prompts = ["Think of a time when you stood up for someone else in a personal or professional setting", "Think of a time when you did something really difficult.","Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
    private List<string> _questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?"]
        public ReflectingActivity () {
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
         _name = "Reflecting Activity";

    }
    public void run() {
        DisplayStartingMessage();
        Console.WriteLine("Enter the number of questions you would like to run this activity for. Each question will remain onscreen for 9 seconds.");
        _duration = Console.ReadLine();
        DisplayPrompt();
        while(_duration > 0) {
            DisplayQuestion();
            DisplaySpinner(9);
            _duration -= 1;
        }
        DisplayEndingMessage();
    }
    public string GetRandomPrompt() {
        Random rand = new Random();
        return rand.next(_prompts.count());
    }
    public string GetRandomQuestion() {
        Random rand = new Random();
        return rand.next(_questions.count());
    }
    public void DisplayPrompt() {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestion() {
        Console.WriteLine(GetRandomQuestion());
    }
}