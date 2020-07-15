using System;

namespace Listing_5._7_Neinicializirovanni_arg
{
    class UsingOutDemo
    {
        //Метод для вычисления значения наиментшего элемента в массива и его индекса
        static int getMin(int[] nums, out int index)
        {
            //Начальное значение для индекса
            index = 0;
            //Перебор элемента массива
            for(int k=1; k<nums.Length; k++)
            {
                //Если значение элемента массива меньше текущего минимального значения
                if(nums[k]<nums[index])
                {
                    index = k;
                }
            }
            //Результат метода
            return nums[index];
        }
        //Главный метод программы
        static void Main(string[] args)
        {
            // Целочисленный массив
            int[] A = { 12, 7, 8, 3, 8, 4, 1, 3, 4, 1, 7, 15 };
            //Отображение содеожимого массива
            foreach (int v in A)
            {
                Console.Write("| {0}", v);
            }
            Console.WriteLine("|");
            //Объявление переменных
            int val, k;
            // Вычисление элемента с наименьшим значением
            val = getMin(A, out k);
            // Отображение результатов
            Console.WriteLine("Наименьшее значение: " + val);
            Console.WriteLine("Индекс элемента: " + k);
            Console.WriteLine("Проверка: A[{0}]={1}", k, A[k]);
        }
    }
}
