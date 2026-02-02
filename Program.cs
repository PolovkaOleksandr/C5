using System;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            
             try
             {
                 Console.WriteLine("enter a number");
                 int a = Convert.ToInt32(Console.ReadLine());

             }
             catch (FormatException)
             {
                Console.WriteLine($"An error occurred: Invalid input. Please enter a valid integer.");
             }
        }
    }
}
