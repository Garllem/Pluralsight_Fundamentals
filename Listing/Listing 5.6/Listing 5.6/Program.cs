using System;

namespace Listing_5._6
{
    class RefArgsDemo
    {
        // Первый метод Аргумент - целое число
        static void alpha(ref int n)
        {
            //Проверка значения аргумента
            Console.WriteLine("В методе alpha(). На выходе: " + n);
            //Попытка изменить значение аргумента
            n++;
            //Проверка значения аргумента
            Console.WriteLine("В методе alpha(). На выходе: " + n);
        }
        // Второй метод. Аргумент -ссылка на массив
        static void bravo(ref int[] n)
        {
            //Проверка сожержимого массива
            Console.WriteLine("В методе bravo(). На выходе: " + ArrayToText(n));
            //Перебор элементов маccива
            for (int k = 0; k < n.Length; k++)
            {
                // Попытка изменить значение массива
                n[k]++;
            }
            //Проверка содержимого массива
            Console.WriteLine("В методе bravo(). На выходе: " + ArrayToText(n));
        }
        // Третий метод. Аргумент ссылка на массив
        static void charlie(ref int[] n)
        {
            //Проверка сожержимого массива
            Console.WriteLine("В методе charlie(). На выходе: " + ArrayToText(n));
            //Создаётся новый массив
            int[] m = new int[n.Length];
            //Перебор элементов маccива
            for (int k = 0; k < n.Length; k++)
            {
                //Значение элемента массива
                m[k] = n[k] + 1;
            }
            //Попытка присвоить новое значение аргументу
            n = m;

            //Проверка содержимого массива
            Console.WriteLine("В методе charlie(). На выходе: " + ArrayToText(n));
        }
        // Метод для преобразования массива в текст
        static string ArrayToText(int[] n)
        {
            //Текстовая переменная
            string res = "[" + n[0];
            //Перебор элементов массива (кроме начального)
            for (int k = 1; k < n.Length; k++)
            {
                // Дописывание текста в текстовую переменную
                res += "," + n[k];
            }
            // Дописывание текста в текстовую переменную
            res += "]";
            // Результат метода - тектовая строка
            return res;
        }
        //Главный метод программы
        static void Main(string[] args)
        {
            // Переменная для передачи аргументом методу
            int A = 100;
            //Проверка значения переменной
            Console.WriteLine("До вызова метода alpha():А=" + A);
            //Вызов метода
            alpha(ref A);
            //Проверка значения переменной
            Console.WriteLine("После вызова метода alpha():А=" + A);

            // Массив для передачи аргументом методу
            int[] B = { 1, 3, 5 };
            //Проверка содержимого массива
            Console.WriteLine("До вызова метода bravo(): B=" + ArrayToText(B));
            //Вызов метода
            bravo(ref B);
            //Проверка содержимого массива
            Console.WriteLine("После вызова метода bravo(): B=" + ArrayToText(B));

            // Массив для передачи аргументом методу
            int[] C = { 2, 4, 6 };
            // Проверка содержимого массива
            Console.WriteLine("До вызова метода charlie(): C=" + ArrayToText(C));
            //Вызов метода
            charlie(ref C);
            //Проверка содержимого массива
            Console.WriteLine("После вызова метода charlie(): C=" + ArrayToText(C));
        }
    }
}
