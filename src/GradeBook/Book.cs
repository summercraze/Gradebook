using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
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

        public Statistic getStatistics()
        {
            var result = new Statistic();

            result.High = double.MinValue;
            result.Low = double.MaxValue;
            total = 0;
            result.Average = 0;
            foreach (var grade in grades)
            {
                 result.Low  = Math.Min( result.Low ,grade);
                 result.High = Math.Max( result.High,grade);
                total += grade;
            }
           result.Average = total / grades.Count;
           return result;
        }
    }
}
