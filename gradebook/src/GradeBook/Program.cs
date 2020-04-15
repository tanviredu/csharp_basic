using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello tanvir Rahman");
            // adding the argument with the program
            Console.WriteLine("Hello "+args[0]+ "!!!!");
            
            // adding the string interpolation
            // try to use the dotnet interpolation
            // it is very easy
            // like format in python
            Console.WriteLine($"Hello , {args[0]} !!!!" );

        }
    }
}
