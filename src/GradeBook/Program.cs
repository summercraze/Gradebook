using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;
using System.Globalization;
using System;
using System.Collections.Generic;
namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            // var numbers = new [] {35.7, 67.8, 12.3};
            book.addGrade(12.0);
            double sum = 0;
            // for(int i = 0; i < numbers.Length; i++)
            // {
            //    sum += numbers[i];
            // }
          
           List<double> grades = new List<double>(){35.7, 67.8, 12.3};
           grades.Add(56.1);
           foreach(var number in grades)
           {
            sum +=number;
           }
           double average = sum/grades.Count;
             Console.WriteLine("The sum of array is : " + sum);
               Console.WriteLine($"The average of array is {average:N2}");
            // double x = 35.7; 
            // double y = 67.8;
            // double z = x + y;
            // Console.WriteLine("The sum of " + x + " and " + y + " is " + z);

           
        }
    }
}
