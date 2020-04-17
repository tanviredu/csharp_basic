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
            // book.AddGrade(82.4);
            // book.AddGrade(32.4);
            // book.AddGrade(32.4);
            // book.AddGrade(52.4);
            // book.AddGrade(64.4);
            // book.AddGrade(62.4);

            // now take input from the user

            while(true){
                Console.WriteLine("Enter a Grade or 'q' to quit");
                var input = Console.ReadLine();
                if(input == "q"){
                    break;
                }

                try{
                    // parse the grade from the string
                    var grade = double.Parse(input);
                    // try to add the grade
                    // if any problem then throw the exception
                    // then catch in here
                    book.AddGrade(grade);

                    // although you can catch 
                    // all the exception at once
                }catch(ArgumentException ex){

                        Console.WriteLine(ex.Message);
                }catch(FormatException ex){
                    Console.WriteLine(ex.Message);
                }
                finally{
                    // this will always be executed 
                    // when exception occur
                    Console.WriteLine("****");
                }

            }




            var stat = book.GetStat();
            Console.WriteLine($"The book name is {book.Name}"); // this is where you get the value the getter is getting invoked
            Console.WriteLine($"The lowest Grade is {stat.Low}");
            Console.WriteLine($"The highest Grade is {stat.High}");
            Console.WriteLine($"The avg Grade is {stat.Average:N2}");
            Console.WriteLine($"The letter Grade is {stat.letter}");

            


        

           



        }
    }
}
