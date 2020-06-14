using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void StringsBehavesLikeValueTypes()
        {
            string name = "Scott";
            name = MakeUppercase(name);

            Assert.Equal("SCOTT", name);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            Book book1 = GetBook("Book 1");
            GetBookSetName(out book1, "New Name");
            
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(out Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            Book book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");
            
            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            Book book = GetBook("Book 1");
            SetName(book, "New Name");
            
            Assert.Equal("New Name", book.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            Book book = GetBook("Book 1");
            Book book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book, book2);
        }
        [Fact]
        public void TwoVariablesCanReferenceSameObject()
        {
            Book book = GetBook("Book 1");
            Book book2 = book;
            
            Assert.Same(book, book2);
        }

        private Book GetBook(string name)
        {
           return new Book(name);
        }
    }
}
