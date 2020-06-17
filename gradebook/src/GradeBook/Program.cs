using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new DiskBook("Alina's Grade Book");
            //var book = new InMemoryBook("kek");

            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"Максимальное значение {stats.High }");
            Console.WriteLine($"Минимальное значение {stats.Low}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Введите оценку или 'q' для отмены");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                try
                {
                    book.AddObjectGrade(input);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }

            }
        }

        static  void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }

    }
}
