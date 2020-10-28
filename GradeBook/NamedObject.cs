using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name
        {
            get; //ability to read the name
            set;
        }
    }


    //Iterface in Polymophysm application
    public interface IBook //Name of interface should begin with UPPER CASE (I)
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        //Statistics GetStatistics();a

        string Name { get;  } //Property of type string//Can be read
        //event DradeAddeddelegate GradeAdded;
    }



    //Abstract class Implements POlymophysm
    public abstract class Book : NamedObject, IBook //Everything inherits automaticaly form (base) sytem.object class // Everything is a reference type
    {
        protected Book(string name) : base(name)
        {
        }

        //public virtual event  DradeAddeddelegate GradeAdded;

        //Abstract Method
        //This shows everything that is a (BookBase) to have an AddGrade member but there is no implementation
        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();
        
    }
}
