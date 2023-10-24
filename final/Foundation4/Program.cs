using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();
        Running running = new Running {
            Date = DateOnly.Parse("October 1, 2024"), 
            Distance = 50, 
            Time = 30
        };
        exercises.Add(running);
        Swimming swimming = new Swimming {
            Date = DateOnly.Parse("May 22, 2023"), Laps = 120, Time = 30
        };
        exercises.Add(swimming);
        Stationary_bike stationary_Bike = new Stationary_bike {
            Date = DateOnly.Parse("January 2, 2020"), Speed = 14, Time = 10
        };
        exercises.Add(stationary_Bike);
        foreach (Exercise exercise in exercises) {
            Console.WriteLine(exercise.getSummary());
        }
    }
}