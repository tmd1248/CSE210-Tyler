using System;

class Goal_Manager {
    private int _points;
    public int points {
        get { return _points;}
        set { _points = value;}
    }
    private List<Goal> _goals = new List<Goal>;
    private string goalhelper;
    private int goalcounter = 1;
    public void start() {
        if(File.Exists("points.txt")) {
            StreamReader sr = new StreamReader("points.txt");
            points = sr.ReadLine();
        }
        if(File.Exists("goals.txt")) {
            StreamReader sr = new StreamReader("goals.txt");
            goalHelper = sr.ReadLine();
            while(goalHelper != null) {
                        switch(goalHelper) {
                            case "simple":
                                Simple_Goal sg = new Simple_Goal;
                                sg.name = sr.ReadLine();
                                sg.description = sr.ReadLine();
                                sg.points = int.Parse(sr.ReadLine());
                                sg.isComplete = bool.Parse(sr.ReadLine());
                                _goals.Add(sg);
                                break;
                            case "eternal":
                                Eternal_Goal eg = new Eternal_Goal;
                                eg.name = sr.ReadLine();
                                eg.description = sr.ReadLine();
                                eg.points = int.Parse(sr.ReadLine());    
                                _goals.Add(eg);                        
                                break;
                            case "checklist":
                                Checklist_Goal cg = new Checklist_Goal;
                                cg.name = sr.ReadLine();
                                cg.description = sr.ReadLine();
                                cg.points = int.Parse(sr.ReadLine());
                                cg.amountCompleted = int.Parse(sr.ReadLine());
                                cg.target = int.Parse(sr.ReadLine());
                                cg.bonus = int.Parse(sr.ReadLine());
                                _goals.Add(cg);
                                break;
                            goalHelper = sr.ReadLine();
                        }
                }
            }
        bool has_chosen = false;
        bool exit_program = false;
        string choice;
        while(exit_program == false) {
            Console.WriteLine("Welcome to the Eternal Quest");
            Console.WriteLine("The point of this program is to help you follow through on goals through gamifying them.");
            Console.WriteLine("Your current point total is " + _points);
            Console.WriteLine("To increase them, select a type of goal, simple, eternal, or checklist");
            Console.WriteLine("To learn more about the goals you have set, type listnames for the names, and listdetails for more detailed information.");
            Console.WriteLine("Or, for other functionality, type create to make a new goal, or save to save your current progress and log out.");
            choice = Console.ReadLine();
            switch(choice) {
                case "simple":
                    Console.WriteLine("Enter the name of the simple goal you wish to complete");
                    choice = Console.ReadLine();
                    foreach(Goal goal in _goals) {
                        if(goal.name == choice) {
                            goal.RecordEvent();
                            _points += goal.points;
                            has_chosen = true;
                            break;
                        }
                    }
                    if(has_chosen == false) {
                        Console.WriteLine("Oops, that's not the name of a goal. You can always add it with the word create");
                    }
                    has_chosen = false;
                    break;
                case "eternal":
                    Console.WriteLine("Enter the name of the eternal goal you wish to complete");
                    choice = Console.ReadLine();
                    foreach(Goal goal in _goals) {
                        if(goal.name == choice) {
                            _points += goal.points;
                            has_chosen = true;
                            break;
                        }
                    }
                    if(has_chosen == false) {
                        Console.WriteLine("Oops, that's not the name of a goal. You can always add it with the word create");
                    }
                    has_chosen = false;
                    break;
                case "checklist": 
                    Console.WriteLine("Enter the name of the checklist goal you wish to complete");
                    choice = Console.ReadLine();
                    foreach(Goal goal in _goals) {
                        if(goal.name == choice) {
                            goal.RecordEvent();
                            _points += goal.points;
                            has_chosen = true;
                            break;
                        }
                    }
                    if(has_chosen == false) {
                        Console.WriteLine("Oops, that's not the name of a goal. You can always add it with the word create");
                    }
                    has_chosen = false;
                    break;
                case "create":
                    CreateGoal();
                    break;
                case "listnames":
                    ListNames();
                    break;

                case "listdetails":
                    ListDetails();
                    break;
                case "save":
                    save();
                    exit_program = true;
                    break;

                 }
            }
        }    
        void ListNames() {
            foreach(Goal goalName in _goals) {
                Console.WriteLIne(goalname.name);
            }
        }
        void ListDetails() {
            foreach (Goal goalInfo in _goals) {
                Console.WriteLine(goalInfo.description);
                if (goalInfo is Simple_Goal) {
                    if(goalInfo.isComplete) {
                        Console.WriteLine("[x]");
                    }
                    else {
                        Console.WriteLine("[ ]");
                    }
                }
            }
        }
        void save() {
            try {
                if (File.Exists("points.txt")) {
                    File.delete("points.txt")
                    }
                StreamWriter sw = new StreamWriter("points.txt", true, Encoding.ASCII);
                sw.Write(_points);
                sw.Close();
                }
            catch(Exception e) {
                Console.WriteLine("Exception: " + e.Message);
            }
            try {
                if (File.Exists("goals.txt")) {
                    File.delete("goals.txt")
                    }
                StreamWriter sw = new StreamWriter("goals.txt", true, Encoding.ASCII);
                foreach(Goal goal in _goals) {
                    if(goal is Simple_Goal) {
                        sw.WriteLine("simple");
                        sw.WriteLine(goal.name);
                        sw.WriteLine(goal.description);
                        sw.WriteLine(goal.points);
                        sw.WriteLine(goal.isComplete);
                    }
                    else if(goal is Eternal_Goal) {
                        sw.WriteLine("eternal");
                        sw.WriteLine(goal.name);
                        sw.WriteLine(goal.description);
                        sw.WriteLine(goal.points);
                    }
                    else {
                        sw.WriteLine("checklist");
                        sw.WriteLine(goal.name);
                        sw.WriteLine(goal.description);
                        sw.WriteLine(goal.points);
                        sw.WriteLine(goal.amountCompleted);
                        sw.WriteLine(goal.target);
                        sw.WriteLine(goal.bonus);
                    }
                }
                sw.Close();
                }
            catch(Exception e) {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
}