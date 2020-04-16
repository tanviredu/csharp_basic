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







    // now make a test to change the propertise
    // of the book

    [Fact]
    public void CanSetNameFromReference(){
            // get the book first
            var book1 = GetBook("Book 1");
            // make a method to set the same
            // dont write the direct code
            // always make a method for it
            SetName(book1,"New Book Name");
    }

        private void SetName(Book book, string name)
        {
            book.Name = name;
            // yes you can change the 
            // the propertise with refrence
        }



        // there is another way to do it

        [Fact]
        public void CsharpCanPassByRef(){
            var book1 = GetBook("Book1");
            // we are going to send the reference
            // of the book
            GetBookSetName(ref book1,"this is the new name");

            Assert.Equal("this is the new name",book1.Name);
        }

        // this book will catch 
        // the reference 
        // and then set the name
        // this ref Book book will tell 
        // that catch a reference have to catch

        
        private void GetBookSetName(ref Book book,string name)
        {
            // now we can set the name
            // directly

            book = new Book(name);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }



        // make another tests so that
        // you will find when you work with string
        // it behave like value types
        // that means when you make a string 
        // UPPER case it will return you a copy
        // in a new memory not the same
        // string

        [Fact]
        public void StringBehaveLikeValueTypes(){
            string name = "Tanvir";
            
            // first typethe method
            // and then CTRL+. 
            // to make this function
            var uppername = MakeThisUpper(name);

            // if you assert with the 
            // name and the uppername
            // you will get an error
        }

        private string MakeThisUpper(string name)
        {
            // this will return a new string
            // just like the python prgramming 
            return name.ToUpper();
        }
    }
}
