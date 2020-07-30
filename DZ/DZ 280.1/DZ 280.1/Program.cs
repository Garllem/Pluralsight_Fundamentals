using System;

namespace DZ_280._1
{
    //Напишите программу - стат метод вычисление двойного факториала.
    class Program
    {
        static int Factorial(int znachenie)
        {
            return znachenie < 2 ? 1 : znachenie * Factorial(znachenie - 2);

            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Двойной факториал 6!!={0}", Factorial(6));
            Console.WriteLine("Двойной факториал 5!!={0}", Factorial(5));
        }
    }
}
