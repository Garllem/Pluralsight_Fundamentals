using System;

namespace Listing_5._4
{
    class ArrayFromMethDemo
    {
        // Метод для создания массива с числами фибоначи
        static int[] fibs(int n)
        {
            // Создаём массив
            int[] nums = new int[n];
            // Первый элемент массива
            nums[0] = 1;
            // Если массив из одного элемента
            if (nums.Length == 1) return nums;
            // Второй элемент массива
            nums[1] = 1;
            // Заполнение элементов массива
            for(int k=2; k<nums.Length; k++)
            {
                // Значение элемента массива равно сумме значений
                // двух предыдущих элементов
                nums[k] = nums[k - 1] + nums[k - 2];
            }
            //Результат метода - ссылка на массив
            return nums;
        }
        // Метод для создания массива со случайными символами
        static char[] rands(int n)
        {
            //Объект для генерирования случайных чисел
            Random rnd = new Random();
            //Создание массива
            char[] symbs = new char[n];
            // Заполнение массива
            for(int k=0; k<symbs.Length; k++)
            {
                // Значенте элемента - случайный символ
                symbs[k] = (char)('A' + rnd.Next(26));
            }
            // Результат метода ссылка на массив
            return symbs;
        }
        // Метод для создания массива с нечетными числами
        static int[,] odds(int m, int n)
        {
            //Создание двумерного массива
            int[,] nums = new int[m, n];
            //Локальная переменная
            int val = 1;
            // Перебор строк массива
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                // Перебор элементов в строке
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    // Значение элемента
                    nums[i, j] = val;
                    // Значение для следующего элемента
                    val += 2;
                }
            }
            // Результат метода - ссылка на массив
            return nums;
        }
        // Главный метод программы
        static void Main(string[] args)
        {
            // Переменная для целочисленного массива
            int[] A;
            // Переменная для символьного массива
            char[] B;
            // Переменная для двумерного массива
            int[,] C;
            // Создаётся массив с числами Фибоначи
            A = fibs(10);
            Console.WriteLine("Числа Фибоначи:");
            // Отображение содержимого массива
            foreach(int s in A)
            {
                Console.Write("| {0}", s);
            }
            Console.WriteLine("|");
            //Создаётся массив со случайными символами
            B = rands(8);
            Console.WriteLine("Случайные символы:");
            // Отображение содержимого массива
            foreach(char s in B)
            {
                Console.Write("| {0}", s);
            }
            Console.WriteLine("|");
            // Создается двумерный массив с нечетными числами:
            C = odds(4, 6);
            Console.WriteLine("Двумерный массив:");
            // Отображение содержимого двумерного массива:
            for(int i=0; i<C.GetLength(0); i++)
            {
                for(int j=0; j<C.GetLength(1); j++)
                {
                    Console.Write("{0,4}", C[i, j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
