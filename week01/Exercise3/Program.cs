using System;
using System.Runtime.Serialization;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        
         Console.Write("What is the magic number? ");
         int magicNumber = int.Parse(Console.ReadLine());

         

         Console.Write("what is your guess?  ");
         int guess = int.Parse(Console.ReadLine());


        if (guess < magicNumber)
        {
          Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }

        else
        {
            Console.WriteLine("Awesome, you got it correctly!.");
        }
    }    


        
}   