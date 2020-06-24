using System;

namespace Listing_5._3
{
    class ArrayToMethDemo
    {
        //Метод для заполнения массива случайными числами
        static void fillRand(int[] nums)
        {
            //Объект генерирования случайных чисел
            Random rnd = new Random();
            //Заполнение массива случайными числами
            for (int k=0; k<nums.Length; k++)
            {
                nums[k] = rnd.Next(1, 100);
            }
        }
        //Метод отображения одномерного
        //целочисленного массива
        static void showArray(int[] nums)
        {
            //Перебор элементов массива 
            for (int k = 0; k < nums.Length; k++)
            {
                //Отображение значения элемента
                Console.Write("| {0}", nums[k]);
            }
            Console.WriteLine("|");
        }
        //Метод для отображения двумерного
        //целочисленного массива
        static void showArray(int[,] nums)
        {
            //Перебор строк в массиве 
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                //Перебор элементов в строке
                for(int j=0;j<nums.GetLength(1);j++)
                {
                    //Отображение значения элемента массива
                    Console.Write("{0,3}", nums[i, j]);
                }
                //Переход к новой строке
                Console.WriteLine();
            }
            
        }
        //Метод для вычисления наименьшего элемента в массиве
        static int findMin(int [] nums)
        {
            //Локальная переменная
            int s = nums[0];
            //Поиск наименьшего значения
            for(int k=1; k<nums.Length;k++)
            {
                //Если проверяемый элемент имеет значение,
                //меньше текущего значения переменной s
                if (nums[k] < s) s = nums[k];
            }
            //результат метода
            return s;
        }
        //Главный метод программы
        static void Main(string[] args)
        {
            //Одномерные массивы
            int[] A = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int[] B = new int[5];
            //Двумерный массив
            int[,] C = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            // Массив В заполняется случайными числами
            fillRand(B);
            Console.WriteLine("Одномерный массив А:");
            //Отображается массив А:
            showArray(A);
            Console.WriteLine("Одномерный массив В:");
            // Отображается массив B:
            showArray(B);
            // Поиск наименьшего элемента
            int m = findMin(B);
            Console.WriteLine("наименьшее значение: {0}", m);
            Console.WriteLine("Двумерный массив С:");
            // Отображение массива С:
            showArray(C);
        }
    }
}
