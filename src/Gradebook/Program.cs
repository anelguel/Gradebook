using System;
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

            Console.WriteLine("Please enter a grade");

            var input = Console.ReadLine();
            var grade = double.Parse(input);

            if (grade <= 0 || grade >= 100)
            {
                book.AddGrade(grade);
            }
            else if (grade == 'q')
            {
                var stats = book.GetStatistics();

                System.Console.WriteLine($"The lowest grade is {stats.Low}");
                System.Console.WriteLine($"The highest grade is {stats.High}");
                System.Console.WriteLine($"The average grade is {stats.Average}");
                System.Console.WriteLine($"The letter grade is {stats.Letter}");
            }

            

        }
    }
}
