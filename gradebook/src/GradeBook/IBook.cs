namespace GradeBook
{
    public interface IBook
        {
            void AddObjectGrade(object grade);
            Statistics GetStatistics();
            string Name { get; }
            event GradeAddedDelegate GradeAdded;
        }

}