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
            Assert.NotSame(book1,book2);
        }

        [Fact]
        public void SameReferenceObjectsTest()
        {
            Book book1 = GetBook("book 1");
            Book book2 = book1;

            Assert.Equal("book 1", book1.Name());
            Assert.Equal("book 1", book2.Name());
            Assert.Same(book1,book2);
            Assert.True(Object.ReferenceEquals(book1,book2));
        }

        Book GetBook(string name){
            return new Book(name);
        }
    }
}
