using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Rong's book");
            book.addGrade(12.0);
            book.addGrade(14.0);
            book.addGrade(16.0);
            book.addGrade(18.0);
            book.addGrade(20.0);
            book.statistic();
        }
    }
}
