using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        private List<double> grades;

        private string name;

        private static double

                highestGrade,
                lowestGrade,
                average,
                total;

        public Book(String name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void addGrade(double grade)
        {
            grades.Add (grade);
        }

        public void statistic()
        {
            highestGrade = double.MinValue;
            lowestGrade = double.MaxValue;
            total = 0;
            average = 0;
            foreach (var num in grades)
            {
                if (num > highestGrade)
                {
                    highestGrade = num;
                }
                if (num < lowestGrade)
                {
                    lowestGrade = num;
                }
                total += num;
            }
            average = total / grades.Count;
            Console.WriteLine($"The highest grade is {highestGrade:N1}");
            Console.WriteLine($"The lowest grade is {lowestGrade:N1}");
            Console.WriteLine($"The average grade is {average:N1}");
        }
    }
}
