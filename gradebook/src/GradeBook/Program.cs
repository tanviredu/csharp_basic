using System;
using System.Collections.Generic;

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
            

            // now we can declare an array
            // with ths command
            // you must enter the array size in this number
            var numbers = new double[3];
            // populating the array
            // with the number
            numbers[0] = 12.7;
            numbers[1] = 100.0;
            numbers[2] = 500.3;


            // instedof adding number like this 
            // you can directly add the array
            // with this method


            // and the array command is the 
            // var name = new [];
            // thats it
            var myarray = new double[3] {100.0,22.0,2.0};

            // now if you dont want to provide the explicit number
            // of length you can leave it blank

            var myarray2 = new double[] {11,223.33,44,2.223,23.23,2323.23};
            Console.WriteLine(myarray2.Length);

            // now adding the number
            var result = numbers[0];
            result = result+numbers[1];
            result = result+numbers[2];
            Console.WriteLine(result);


            Console.WriteLine(myarray.Length);

            // you dont even need to use the 
            // double or anything 
            var another_number = new [] {100,200,300,400};
            Console.WriteLine(another_number.Length);
            Console.WriteLine(another_number.GetType());

            var num = new[] {133,11.4,334.343,23.2323};
            Console.WriteLine(num.Length);
            Console.WriteLine(num.GetType());

            // insted of manually add the number 
            // we can use  aforeach loop 
            // to do  that work
            result = 0.0;
            foreach(var number in numbers ){
                // this you can add it
                result+=number;

            }            

            Console.WriteLine(result);

            // this array is hard to
            // for the calculation
            // you may add list
            // like data structure
            // for that


            // this is how you use the generic data structure
            // this is how you use most of the type
            // the syntax is
            // var name = new List<type>;
            // thats it
            var grades = new List<double>() {122,33.3434,3434.34,3434,343,6563.34};
            // you can initializa this array easily
            /// with this help
            // and you can manually add this
            // to  the array

            // and you can add number with the loop too
            var result2 = 0.0;
            
            // then print the number
            // print the number

            foreach(var grade in grades){
                // now we are going to print 
                // this from the list
                //Console.WriteLine(grade);
                //add the whole value
                // with the array
                result2+=grade;

            }

            Console.WriteLine(result2);
            
            // now we will find the 
            // the average 
            // of the result
            // the list object 
            //has a property name count

            var result3 = result2/grades.Count;

            Console.WriteLine($"the avg is {result3}");





            //grades.Add(56.1);
            // you can index the list just like the array
            // array is dynamic
            // you can even apply yhe binary search 
            // in the List if the list is sorted




        }
    }
}
