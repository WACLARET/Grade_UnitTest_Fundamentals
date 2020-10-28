using System;
using Xunit;

namespace GradeBook.test
{
    public class BookTests
    {
        //[Fact] //atribute->little piece of data attached to symbol that follows it.
        //public void Test1()
        //{
        //    //Arrange(unittest section)
        //    var x = 10;
        //    var y = 2;
        //    var expected = 12;

        //    //Act(unittest section)
        //    var result = x + y;

        //    //Assert(Assert value computed in Act)
        //    Assert.Equal(expected, result);
        //}

        [Fact] //atribute->little piece of data attached to symbol that follows it.
        public void BookCalculateAverageGrades()
        {
            //Arrange(unittest section)
            var Book = new InMemoryBook("");
            Book.AddGrade(80.9);
            Book.AddGrade(85.9);
            Book.AddGrade(82.9);
            //Act(unittest section)
            var results = Book.GetStatistics();

            //Assert(Assert value computed in Act)
            //Presition number of decimal places want to choose in average(1)
            Assert.Equal(83.2, results.Average, 1);
            Assert.Equal(85.9, results.highGrade, 1);
            Assert.Equal(80.9, results.minGrade, 1);
            Assert.Equal('B', results.letter);
        }
    }
} 
