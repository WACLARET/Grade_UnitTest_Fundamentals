using System;
using Xunit;

namespace GradeBook.test
{
    public class TypeTests
    {
        //VALUE TYPE
        [Fact]
        public  void Test1()
        {
            var x = GetInt();
            setInt(ref x);
            Assert.Equal(42, x);
            
        }

        private void setInt(ref int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }









        //REFERENCE TYPE
        //String behaves like value type but its a reference type
        [Fact]
        public void StringBehavesLikeValaeType()
        {
            //stings are immutable cant be changed
            string name = "Anto";
            name = MakeUpperCase(name);

            Assert.Equal("ANTO", name);

        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact] //atribute->little piece of data attached to symbol that follows it.
        public void CSharpCanPassedByRef()
        {
            var book1 = GetBook("Book1");
            //ivoking a method and passing a string on the book name
            GetBooksetName(ref book1, "New Name");
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBooksetName(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);

        }

        [Fact] //atribute->little piece of data attached to symbol that follows it.
        public void CSharpIsPassedByValue()
        {
            var book1 = GetBook("Book1");
            //ivoking a method and passing a string on the book name
            GetBooksetName(book1, "New Name");
            Assert.Equal("Book1", book1.Name);
        }

        private void GetBooksetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
            
        }

        [Fact] //atribute->little piece of data attached to symbol that follows it.
        public void CanSetNameFromRefrence()
        {
            var book1 = GetBook("Book1");
            //ivoking a method and passing a string on the book name
            setName(book1, "New Name");
            Assert.Equal("New Name", book1.Name);
        }

        private void setName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        [Fact] //atribute->little piece of data attached to symbol that follows it.
        public void GEtBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");

            //Assert.Equal("Book1", book1.Name);
            //Assert.Equal("Book2", book2.Name);

            //Assert (same) shows book1 and book2 dont points to the same reference
            Assert.NotSame(book1, book2);
            Assert.False(object.ReferenceEquals(book1, book2));

        }


        [Fact] //atribute->little piece of data attached to symbol that follows it.
        public void TwoVArriablesCanReferenceSAmeObject()
        {
            var book1 = GetBook("Book1");
            var book2 = book1;

            //Assert.Equal("Book1", book1.Name);
            //Assert.Equal("Book1", book2.Name);

            //Assert (same) shows book1 and book2 points to the same reference
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));

        }

        //We return a book
        //Void means method doesnt return anything
        private InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
