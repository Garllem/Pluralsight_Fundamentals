using System;
using System.IO;

namespace GradeBook
{
    public class DiskBook : BaseBook<double>, IBook
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public void AddObjectGrade(object grade)
        {
            var str = grade.ToString();
            var dbl = double.Parse(str);

            if (dbl <= 100 && dbl >= 0)
            {
                AddGrade(dbl);
            }
            else throw new ArgumentException($"Invalid {nameof(grade)} - неправильная оценка");
        }

        public override void AddGrade(double grade)
        {
            // Каждый раз когда вызывается этот метод открывается файл с таким же 
            // именем что и книга и записывает новую строку в файл который содержит значение оценки
            //нужно записать одну оценку в файл
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }

        

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            using(var reader = File.OpenText($"{Name}.txt"))
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