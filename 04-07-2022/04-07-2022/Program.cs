using System;

namespace CodeToTest;
 
public class Program
{
    static void Main(string[] args)
    {
        int timeOfDay = 21;
        string greet = Greeting(timeOfDay);
        Console.WriteLine(greet);
    }

    public static string Greeting(int timeOfDay)
    {
        string greeting;

        if(timeOfDay >= 5 && timeOfDay < 12)
        {
            greeting = "Good morning!";
        } 
        else if (timeOfDay >= 12 && timeOfDay <= 18)
        {
            greeting = "Good afternoon!";
        }
        else if((timeOfDay > 18 && timeOfDay <= 24) || (timeOfDay > 0 && timeOfDay < 5))
        {
            greeting = "Good evening!";
        }
        else
        {
            greeting = "Invalid Time";
        }
        return greeting;
    }

    public static string AvailableClassifications(int ageOfViewer)
    {
        string result = "All films are available!";
        if (ageOfViewer >=120 || ageOfViewer < 0)
        {
            throw new ArgumentOutOfRangeException("Invalid age Entry!");
        }
        else if (ageOfViewer < 18 && ageOfViewer >= 15)
        {
            result = "Films U, PG, 12A, 12 and 15 are available!";
        } else if (ageOfViewer < 15 && ageOfViewer >= 12){
            result = "Films U, PG, 12A and 12 are available!";
        } else if (ageOfViewer < 12)
        {
            result = "Films U and PG are available!";
        }
        return result;
    }
}