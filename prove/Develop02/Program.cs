using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal!");
        Console.WriteLine("Please select from the following options by typing 1 - 5");
        bool exitCode = false;
        entry Entry = new entry();
        prompt Prompts = new prompt();
        Random Rand = new Random();
        string entryInfo = "";
        while (exitCode == false) {
            Console.WriteLine("1: make a new entry");
            Console.WriteLine("2: load your journal from a file");
            Console.WriteLine("3: save your journal to a file");
            Console.WriteLine("4: display the currently loaded journal");
            Console.WriteLine("5: Exit the program");
            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);
            switch (choice) {
                case 1:
                    int promptIndex = Rand.Next(Prompts._prompts.Length);
                    string prompt = Prompts._prompts[promptIndex];
                    Console.WriteLine(prompt);
                    Entry._prompt = prompt;
                    DateTime dateHandler = DateTime.Now;
                    Entry._date = dateHandler.ToString();
                    Entry._response = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter the file name you wish to load");
                    string fileLoadName = Console.ReadLine() + ".txt";
                    string[] file = System.IO.File.ReadAllLines(fileLoadName);
                    foreach (string line in file) {
                        entryInfo = entryInfo + line + "\n";
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the file name you wish to save to");
                    string fileSaveName = Console.ReadLine() + ".txt";
                    using (StreamWriter outputFile = new StreamWriter(fileSaveName)) {
                        if(Entry != null) {
                        outputFile.WriteLine(Entry._prompt + ", " + Entry._date + ", " + Entry._response);
                    }}
                    break;
                case 4: 
                    if(Entry != null) {
                    Console.WriteLine(Entry._prompt + " " + Entry._date + " " + Entry._response);
                    }
                    if(entryInfo != null) {
                        Console.WriteLine(entryInfo);
                    }
                    break;
                case 5: 
                    exitCode = true;
                    break;
            }
        }
    }
}
