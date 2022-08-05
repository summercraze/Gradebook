using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Rong's book");
            book.addGrade(12.6);
            book.addGrade(14.7);
            book.addGrade(16.8);
            book.addGrade(18.4);
            book.addGrade(20.0);
            var statistic = book.getStatistics();
            Console.WriteLine($"Lowest : {statistic.Low}");
             Console.WriteLine($"Highest : {statistic.High}");
              Console.WriteLine($"Average : {statistic.Average}");
        }
    }
}
