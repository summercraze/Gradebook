using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTest
    {
        [Fact]
        public void Test1()
        {
           //arrange
           var book = new Book("");
           book.addGrade(12.1);
           book.addGrade(34.5);
           book.addGrade(29.8);
           //act
           var result = book.getStatistics();
           //assert
           Assert.Equal(25.5, result.Average,1);
           Assert.Equal(34.5, result.High,1);
           Assert.Equal(12.1, result.Low,1);
        }
    }
}
