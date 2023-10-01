using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This scripture memorization tool will take a provided input of a scripture and its reference, and will display it to the console.");
        Console.WriteLine("Pressing enter will hide a word at random from the provided scripture");
        Console.WriteLine("Type the word 'quit' to exit the program early, otherwise, pressing enter once the entire scripture is hidden will terminate the program");
        Console.WriteLine("Please enter the reference of the scripture you would like to memorize");
        reference UserReference = new reference;
        UserReference.reference = Console.ReadLine();
        Console.WriteLine("Now enter the associated text of the scripture");
        scripture UserScripture = new scripture;
        UserScripture.scripture = Console.ReadLine();
        int length = UserScripture.scripture.Count();
        int counter;
        while (counter <= length) {
            Console.Clear();
            Console.WriteLine(UserReference.reference);
            Console.WriteLine(UserScripture.scripture);
            Console.WriteLine("Type the word Quit to exit early, or hit enter to repeat this process");
            choice = Console.ReadLine():
            choice.toString();
            if (choice == "quit" or choice == "Quit") {
                counter = length;
            }
            else {
                counter += 1;
                UserScipture.HideRandomWords();
            }
        }
        
    }
}