using System;

class Program
{
    static void Main(string[] args)
    {  
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What do you think the number is? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("The number is higher than yours");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("The number is lower than yours");
            }
            else
            {
                Console.WriteLine("That's the number");
            }

        }                    
    }
}