using System; 

class listingactivity : activity {
    private List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
    private int _count;
    public ListingActivity () {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
         _name = "Listing Activity";
    }
    public void run() {
        DisplayStartingMessage();
        Console.WriteLine("Enter the number of seconds you would like to think about the question for.");
        _duration = Console.ReadLine();
        Console.WriteLine(GetRandomPrompt());
        DisplayTimer(_duration);
        List<string> userList = GetListFromUser();
        foreach(string useritem in userList) {
            Console.WriteLine(useritem);
        }
}
    public string GetRandomPrompt() {
        Random rand = new Random();
        return rand.next(_prompts.count());
    }
    public List<string> GetListFromUser() {
        bool tracker = false;
        List<string> tempList = new List<string>;
        while(tracker == false) {
            Console.WriteLine("Enter a response or type \"quit\" to quit");
            string response = Console.ReadLine();
            if (response == 'quit') {
                tracker = true;
            }
            else {
                tempList.add(response);
            }
        return tempList;


        }
    }
}