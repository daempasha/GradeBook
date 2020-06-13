using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            Statistics stats = book.GetStatistics();

            Console.WriteLine($"Average grade is: {stats.Average:N1} \nHighest grade is: {stats.High} \nMin grade is: {stats.Low}");

        }
    }
}
