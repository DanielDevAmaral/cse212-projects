using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        string random = "asdjlkfj";
        HashSet<char> newrandom = new HashSet<char>();


        foreach (var x in random)
        {
            newrandom.Add(x);
            
        }

        Console.WriteLine(newrandom.ToString());


        

    }
}