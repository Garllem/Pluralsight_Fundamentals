using System;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public abstract class BaseBook<T> : NamedObject
    {
        protected BaseBook(string name) : base(name)
        {
        }        

        public abstract event GradeAddedDelegate GradeAdded;
        public abstract void AddGrade(T grade);
        public abstract Statistics GetStatistics();
    }
}