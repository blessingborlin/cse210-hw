using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string first = Console.ReadLine();

        Console.Write("what is your topic? ");
        string last= Console.ReadLine();

        Console.WriteLine($" {first} - {last}");
        
    }
}