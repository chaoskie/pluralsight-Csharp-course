using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        // [Before]
        // public void makeBook()
        // {
        //     List<double> grades = new List<double>() {12.4, 2.1, 11.78};
        //     Book book = new Book("book",grades);
        // }

        [Fact]
        public void TestGrades()
        {
            Book book = new Book("book");
            book.AddGrade(12.4); 
            book.AddGrade(2.1);
            book.AddGrade(11.78);
            Assert.Equal(8.76, book.ComputeAverageGrade(), 2);
            Assert.Equal(2.1, book.LowestGrade(), 1);
            Assert.Equal(12.4, book.HighestGrade(),1);
        }
    }
}
