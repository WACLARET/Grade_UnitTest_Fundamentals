using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{

    //Book is a NamedObject(Inheritance)
    //Interfaces can be inherited more than one Interface
    public class InMemoryBook : Book
    {
        //constructor
        //has no return type 
        //Explicit constructor
        public InMemoryBook(string name) : base(name) //base() refrences the base class accesing the NamedObject Method
        {
           Name = name;
            //executes when use new key word against this class
            grades = new List<double>();
        }

        //Switch statement
        //Method overloading (using the same method name) it looks the method signature not method name  (char Letter)
        public void AddGrade(char Letter) //method 1 (Method overloading)
        {
            switch (Letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(60);
                    break;
                case 'D':
                    AddGrade(50);
                    break;
                case 'E':
                    AddGrade(30);
                    break;
                default:
                    AddGrade(0);
                    break; 
            }
        }


        //void method that does not return a value
        //Polimophysm the ability to overide methods from an inherited class eg BookBase
        //Overide is only done on Abstract and Virtual Methods
        public override void AddGrade(double grade) //method 2 (Method overloading)
        {
            if (grade <= 100 && grade >=0)
            {
                    //add the incoming grade into the list maintained by the field
                    grades.Add(grade);
            }
            else
            {
                //Console.WriteLine("invalid value");
                throw new ArgumentException($"invalid grade");
            }
        }

        //use class identifiers (Statistics) returns to object of type statistics
        public override Statistics GetStatistics()
        {
            //ne object
            var result = new Statistics();
            
            //var result = 0.0;
            //declare max and min garade variable
            //var highGrade = double.MinValue;
            //var minGrade = double.MaxValue;
            //adding items in an array (looping through the array)


            for (var index = 0; index < grades.Count; index++)
            {

                //jumping with break, continue and goto e.g
                //if (grades[index] == 42.1)
                //{
                //    break;
                //}
                result.Add(grades[index]);


                
                
            }




            return result;

            //var index = 0;
            //while (index < grades.Count) 
            //{
            //    result.highGrade = Math.Max(grades[index], result.highGrade);
            //    result.minGrade = Math.Min(grades[index], result.minGrade);
            //    //finding sum
            //    result.Average += grades[index];
            //    index++; //index +=1
            //};

            ////finding average
            //result.Average /= grades.Count;


            //return result;


            //foreach (var grade in grades)
            //{
            //    //if (item > highGrade)
            //    //{
            //    //    highGrade = item;
            //    //}
            //    result.highGrade = Math.Max(grade, result.highGrade);
            //    result.minGrade = Math.Min(grade, result.minGrade);
            //    //finding sum
            //    result.Average += grade;

            //}
            ////finding average
            //result.Average /= grades.Count;


            //return result;



        }
        //field are put out class so that can be accessed anywhere can be accesed out the addgrade method
        // (var) implisit typing cant be used in afield
        //any methods in book class can acces the field

        //List<double> grades = new List<double>();// Initialize grades

        List<double> grades;

        //property(auto property)
        //public string Name
        //{
        //    get; //ability to read the name
        //    set;
        //}

        //Read only Members
        //readonly string category = "Computer";
        //Can only be read only
        public const string CATEGORY = "Computer";
    }
}
