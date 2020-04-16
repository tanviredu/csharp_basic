using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {

            // what are we doing in this 
            // test

            // make the method
            //for working with ctrl+.
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // now we run test that
            // this is not a same object 
            // this is two different object
            // lets assert it
            Assert.Equal("Book 1",book1.Name);
            Assert.Equal("Book 2",book2.Name);



        }


    // can two variable reference same 
    // object lets find out

    [Fact]
    public void TwoVarsCanReferenceSameObject(){
        var book1 = GetBook("Book 1");
        var book2 = book1;


        // find if they point same memory
        Assert.Same(book1,book2);
        // yes two variable can point same object
    }



    // the first parameter is the Book
    // is the return type 
    // so we return a book object
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
