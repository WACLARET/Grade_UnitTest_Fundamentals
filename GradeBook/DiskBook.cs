using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GradeBook
{
    public class DiskBook : InMemoryBook
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override void AddGrade(double grade)
        {
            //Saving data into a file
            //using key word to close the file when data has been written in it
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
            }
     

           
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            using (var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();
                while(line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();

                }
            }
            return result;
        }
    }
}
