﻿using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Anel's Grade Book");
            // book.AddGrade(89.1);
            // book.AddGrade(90.5);
            // book.AddGrade(77.5);

            var done = false;

            while (true)
            {
                Console.WriteLine("Please enter a grade or 'q' to quit:");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally 
                {
                    System.Console.WriteLine("**");
                }
            }

            {
                var stats = book.GetStatistics();

                System.Console.WriteLine($"For the book named {book.Name}");
                System.Console.WriteLine($"The lowest grade is {stats.Low}");
                System.Console.WriteLine($"The highest grade is {stats.High}");
                System.Console.WriteLine($"The average grade is {stats.Average}");
                System.Console.WriteLine($"The letter grade is {stats.Letter}");
            }



        }
    }
}
