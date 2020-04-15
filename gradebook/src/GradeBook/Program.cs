using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            // main is the entry point of the code
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello tanvir Rahman");
            // adding the argument with the program
            // adding  a if statement

            if(args.Length >0){
                
                // adding  a variable
                // now anything you do with a with a floating 
                // point is actually considered as double
                // and you cant use it as a float type
                // until you put a F at the end of it
                // if you dont use the F 
                // you may have to use the 
                // double type 
                // insted of the float
                float x;
                x = 34.1F;
                Console.WriteLine("th value of x is :");
                Console.WriteLine(x);
            
                Console.WriteLine("Hello "+args[0]+ "!!!!");
                // adding the string interpolation
                // try to use the dotnet interpolation
                // it is very easy
                // like format in python
                Console.WriteLine($"Hello , {args[0]} !!!!" );
            }else{
                Console.WriteLine("hello unknown person");
            }


            // adding two number
            // now you can use the iimplicit typing
            var number1  = 100.00;
            var number2 = 2.23;
            var ans = number1+number2;

            Console.WriteLine($"The addtion is {ans}");
            



        }
    }
}
