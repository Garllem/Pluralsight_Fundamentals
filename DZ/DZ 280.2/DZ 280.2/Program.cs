using System;

namespace DZ_280._2
{
    class Program
    {
        static int Summ2NatChisel(int znachenie)
        {
            /* int result = 0;
            for (int i = 1; i <= znachenie; i++)
                result += Convert.ToInt32(Math.Pow(i, 2));
            return result;
            */

            if (znachenie <= 1)
                return znachenie;
            else
                return Summ2NatChisel(znachenie - 1) + znachenie * znachenie;
            

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма квадратов натуральных чисел 6={0}", Summ2NatChisel(6));
            Console.WriteLine("Сумма квадратов натуральных чисел 5={0}", Summ2NatChisel(5));
        }
    }
}
