using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        string input;
        while(quit == false) {
        Console.WriteLine("Hello and welcome to the mindfulness activity selector");
        Console.WriteLine("Please type a number 1-3 to begin an activity");
        Console.WriteLine("1 for breathing, 2 for listing, and 3 for reflecting");
        Console.WriteLine("Or Type 'quit' to quit");
        input = Console.ReadLine();
        switch(input) {
            case '1': 
                breathingactivity.run();
                break;
            case '2': 
                listingactivity.run();
                break;
            case '3':
                reflectionactivity.run();
                break;
            case 'quit': 
                quit = true;
                break;
        }
        }
    }
}