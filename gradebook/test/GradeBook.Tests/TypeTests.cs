using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            Book book1 = GetBook("book 1");
            Book book2 = GetBook("book 2");

            Assert.Equal("book 1", book1.Name());
            Assert.Equal("book 2", book2.Name());

        }

        Book GetBook(string name){
            return new Book(name);
        }
    }
}
