using System;

class activity {

    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage() {
        Console.writeLine(_description);
    }
    
    public void DisplayEndingMessage() {
        Console.WriteLine("Thank you for using this program. I hope it has been helpful to you");
    }

    public void DisplaySpinner(int seconds) {
        List<string> spinnerList = new List<string>();
        spinnerList.Add("|");
        spinnerList.Add("\\");
        spinnerList.Add("—");
        spinnerList.Add("/");
        spinnerList.Add("|");
        spinnerList.Add("\\");
        spinnerList.Add("—");
        spinnerList.Add("/");
        spinnerList.Add("|");
        foreach (string s in spinnerList) {
            Console.Write(s);
            Thread.Sleep(seconds / 9 * 1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayTimer(int seconds) {
        while(seconds > 0) {
            Console.Write(seconds);
            Thread.Sleep(1000);
            seconds -= 1;
            Console.Write("\b \b");
        }
        Console.WriteLine("All Done!");
    }
}