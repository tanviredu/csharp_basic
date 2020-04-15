using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        
        // change the constructor
        // and add a parameter
        public Book(string name){
            // this is the constructor
            // function
            // now i create a List in thee
            // this object is autometically generated here
            // now in this valriable
            // all the grades will be added
            // now can we directly access this 
            // or we need a method to access this
            // to do this when you declare a list
            // you need to add the public access modifier 
            // this class the generic list class
            // but this is not a good idea
            // do not let people access the data structure
            // that you are using from different class
            //use public method
            // and only let user remove or add data with this method

            grades = new List<double>();
            this.name = name;
        }
        

        // here you define the list
        // and inside the constructor
        // unlike other scripting
        //language you can write things 
        //later because this is a compiled language 

        private  List<double>grades;
        private string name; // define a variable for the name of the book

        // when you use the private
        // other class cant use it
        // only this class can use this
        // add CTRL+. to add the namespace            
    
        // now any method you add can access the 
        // grades

        
        
        // this class is under the 
        // Gradebook
        // thats why we need the name 
        // namespace gradebook
        // we can put different class
        // in the same file
        // but in csharp we dont do that
        //we create separate class
        // in separate file
        //class has properties and method
        // the propertise are also called state
        // and the method is also called the behaviour
        public void AddGrade(double grade){

            // in ghere you need to store the grade
            // add the state/propertise/field
            // if you want that the properties 
            // will be used througout the program
            // you can not use it under a method
            // and you cant use implecit typing
            // now add the graders in the list

            grades.Add(grade);

        }

        public void showstat(){
            // all the minimum value 
            // maximum value
            // and the avg value will be here
            var result = 0.0;
            var highgrade = double.MinValue; // a very low value
            var lowgrade = double.MaxValue;  // a very high value

            // calculayte this with a loop

            foreach(var number in grades){
                // you can use the grades because
                // its in the class
                lowgrade = Math.Min(number,lowgrade);
                highgrade = Math.Max(number,highgrade);
                result+=number;


            }

            // now find the avg
            result = result/grades.Count;

            // now console log this

            Console.WriteLine($"The lowest Grade is {lowgrade}");
            Console.WriteLine($"The highest Grade is {highgrade}");
            Console.WriteLine($"The avg Grade is {result:N2}");

        }

        
    }
}