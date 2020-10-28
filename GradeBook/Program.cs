using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            //from class in Book.cs
            //initialize book to new book()
            var book = new InMemoryBook("lukes's grade");
            //grade method from Book Class
            //book.AddGrade(80.7);
            //book.AddGrade(90.7);
            //book.AddGrade(80.7);
            //book.AddGrade(70.7);



            EnterGrades(book);



            //convert string into a double



            var stats = book.GetStatistics();
            //string interpolation
            //specifying the amount of numbers after the decimal space N1,N2,N3
            Console.WriteLine($"the average grade is {stats.Average:N1}| the highest grade is {stats.highGrade}|  grade is {stats.letter}| and minimum grade is {stats.minGrade}");


            //array initialization
            //var numbers = new [] {10.1,10.2,10.3,10.4,10.5 };

            //describing a List of double (lists are dynamic compared to arrays)
            //a list can be indexed just like an array
            //List<double> grades = new List<double>() { 9.1,10.1, 10.2, 10.3, 10.4, 10.5 };
            //grades.Add(10.9);



            //           if (args.Length > 0)
            //{
            //       Console.WriteLine($"Hello, {args[0]} world!");
            //}
            //           else
            //{
            //          Console.WriteLine($"Hello");  
            //}

        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Enter Grade or Enter q to quit:");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                //Error Handling
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                //Write this separate catch statements to be able to catch only specifi errors
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                }



            }
        }
    }
}
