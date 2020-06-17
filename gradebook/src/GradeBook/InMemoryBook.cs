using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class InMemoryBook : BaseBook<string>, IBook
    {
        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddObjectGrade(object grade)
        {
            AddGrade(grade.ToString());
        }

        public override void AddGrade(string letter)
        {
            switch(letter)
            {
                case "A":
                    AddGrade(90);
                    break;

                case "B":
                    AddGrade(80);
                    break;

                case "C":
                    AddGrade(70);
                    break;

                default:
                    throw new ArgumentException($"Некорректная оценка {letter}");
            }
        }

        private void AddGrade(double grade) 
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)} - неправильная оценка");
            }    
        }

        public override event GradeAddedDelegate GradeAdded;

       
        public override Statistics GetStatistics() 
        {
            var result = new Statistics();
            
            
            for(var index = 0; index < grades.Count; index++) 
            {
                result.Add(grades[index]);
            } 
            
            return result;
        }

        

        private List<double> grades;

         public const string CATEGORY = "Science";
    }

}