using System;
using System.Collections.Generic;

namespace GradeBook
{


    public class NamedObject
    {
        // make aconstructr

        public  NamedObject(string name){
            Name = name;
        }
        public string Name{
            get;set;
        }
    }

    // this book clas has a property name
    // we all with the getter and the setter
    // we can do that with the same
    //inheritance

    // sow after the inheritance
    // this method will be avilabe with use
    // now we need to just remove its method Name
    // because we dont need it anymore we get it from the base class
    // Named object
    // do not make instance of the base class
    // not a good idea
    // but remember if your base class also has a constructor
    // you need to feed the data with base() too
    // like the super class in python


    public abstract class Book :NamedObject{
        public Book(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);
        //now when you made a abstract method
        // in a abstract class
        // you must have to implement it
        // with a keyword override


    }
    public class inMemoryBook:Book
    {
        
        // this is the super class
        // you constructing the constructor 
        // of the book class
        // and the base class
        // at the same time
        public inMemoryBook(string name) : base(name){
            grades = new List<double>();
            Name = name;
        }
        


        public  List<double>grades;
        


            // public string Name{
            //     get;set;
            // }
        public override void AddGrade(double grade){

            
            if(grade<=100 && grade >=0){
                grades.Add(grade);





            }else{
                // Console.WriteLine("InValid value");
                throw new ArgumentException($"{nameof(grade)} is invalid");
            }

        }

    

        public void addLetterGrade(char letter){


            // mappign the character with number
            switch(letter){
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;

            }
        }










    
        public stat GetStat(){
            var result = new stat();
            result.Average = 0.0;
            

            result.High = double.MinValue;
            result.Low = double.MaxValue;


            foreach(var grade in grades){
                result.Low = Math.Min(grade,result.Low);
                result.High= Math.Max(grade,result.High);
                result.Average+=grade;


            }

            result.Average = result.Average/grades.Count;

            switch(result.Average){

                case var d when d>=90.0:
                    result.letter = 'A';
                    break;

                case var d when d>=80.0:
                    result.letter = 'B';
                    break;

                case var d when d>=70.0:
                    result.letter = 'C';
                    break;

                default:
                    result.letter = 'F';
                    break;
            }


            return result;
        }

        
    }
}