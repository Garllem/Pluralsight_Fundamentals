using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {      
        [Fact]
        public void InMemoryBook_CalculatesAnAvverageGrade()
        {
            //arrange переменные
            var book = new InMemoryBook("");
            book.AddObjectGrade("A");
            book.AddObjectGrade("B");
            book.AddObjectGrade("C");
            
            //act вычисления
            var result = book.GetStatistics();           

            //assert утверждение
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);       
            Assert.Equal('B', result.Letter);   
        }

        [Fact]
        public void DiskBook_CalculatesAnAvverageGrade()
        {
            //arrange переменные
            var book = new DiskBook("");
            book.AddObjectGrade(80);
            book.AddObjectGrade(20.1);
            book.AddObjectGrade(22);

            //act вычисления
            var result = book.GetStatistics();

            //assert утверждение
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }
    }
}
