using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculateAverageGrade()
        {

            // arrange the logic
            // now initially you cant find the 
            // Book object in this project
            // because this is from another project
            // tell the compiler
            // dotnet add reference <path_to_the_project>
            // dotnet add reference ../../src/GradeBook/GradeBook.csproj
            var book = new inMemoryBook("");
            // add Geade to the book
            book.AddGrade(89.10);
            book.AddGrade(79.10);
            book.AddGrade(69.10);
            book.AddGrade(79.10);
            book.AddGrade(49.10);

            // but your function has no return statement
            // your book must have  a return statement
            // and your method does not return any object
            // so we can use it easily
            var result = book.GetStat();
            // last parameter 
            // is the precision
            Assert.Equal(73.1,result.Average,1);
            Assert.Equal('C',result.letter);

            // this is how unit test improve your code


        }
    }
}
