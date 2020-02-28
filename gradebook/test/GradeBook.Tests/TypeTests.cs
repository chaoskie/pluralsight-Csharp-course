using Xunit;
using System;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void BookNameTests(){
            Book book1 = GetBook("book1");
            Book book2 = GetBook("book2");
            setBookName(book1, "book2");

            Assert.Equal("book2", book1.Name);
            Assert.Equal(book1.Name,book2.Name);
            Assert.NotSame(book1,book2);
        }

        [Fact]
        public void StringActsLikeValueTypes(){
            string name = "scott";
            makeUpperCase(name);
            Assert.NotEqual("SCOTT",name);            
        }

        private void makeUpperCase(string name){
            name.ToUpper();
        }

        [Fact]
        public void BookReferenceTestPassByValue(){
            var book1 = GetBook("book1");
            setBookNameReferenceTestByValue(book1, "new name");
            Assert.Equal("book1",book1.Name);
            Assert.NotEqual("new name",book1.Name);
        }
        private void setBookNameReferenceTestByValue(Book book, string name){
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
        public void BookReferenceTestPassByReference(){
            var book1 = GetBook("book1");
            setBookNameReferenceTestByReference(ref book1, "new name");
            Assert.NotEqual("book1",book1.Name);
            Assert.Equal("new name",book1.Name);
        }
        private void setBookNameReferenceTestByReference(ref Book book, string name){
            book = new Book(name);
        }        

        private void setBookName(Book book, string name){
            book.Name = name;
        }

        [Fact]
        public void NotSameBooksTest()
        {
            Book book1 = GetBook("book 1");
            Book book2 = GetBook("book 2");

            Assert.Equal("book 1", book1.Name);
            Assert.Equal("book 2", book2.Name);
            Assert.NotSame(book1,book2);
        }

        [Fact]
        public void SameReferenceObjectsTest()
        {
            Book book1 = GetBook("book 1");
            Book book2 = book1;

            Assert.Equal("book 1", book1.Name);
            Assert.Equal("book 1", book2.Name);
            Assert.Same(book1,book2);
            Assert.True(Object.ReferenceEquals(book1,book2));
        }

        [Fact]
        public void NotSameReferenceObjectsTest()
        {
            Book book1 = GetBook("book 1");
            Book book2 = GetBook("book 1");

            Assert.Equal("book 1", book1.Name);
            Assert.Equal("book 1", book2.Name);
            Assert.Equal(book1.Name, book2.Name);
            Assert.NotSame(book1,book2);
            Assert.False(Object.ReferenceEquals(book1,book2));
        }

        Book GetBook(string name){
            return new Book(name);
        }
    }
}
