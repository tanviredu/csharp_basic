using System;
using System.Collections.Generic;

namespace GradeBook
{


    class Program
    {
        static void Main(string[] args)
        {
            // create a object 
            // in the book
            var book = new Book("my fav book");
            book.AddGrade(82.4);
            book.AddGrade(32.4);
            book.AddGrade(32.4);
            book.AddGrade(52.4);
            book.AddGrade(64.4);
            book.AddGrade(62.4);
            book.showstat();

        

           



        }
    }
}
