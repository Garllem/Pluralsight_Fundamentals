using System;

namespace Listing_5._9_proizvolnoe_kolichestvo_args
{
    class ParamsDemo
    {
        //Метод для вычисления суммы чисел
        static int sum(params int[] a)
        {
            //Локальная переменная (значение суммы)
            int res = 0;
            //Перебор аргументов метода
            for(int k=0;k<a.Length;k++)
            {
                //Прибавление слагаемого к сумме
                res += a[k];
            }
            //Результат метода
            return res;
        }
        //Метод для извлечения символов из текста
        static string getText(string t, params int[] a)
        {
            // Начальное значение формируемой текстовой строки
            string res = "";
            //Перебор аргументов метода
            for(int k=0; k<a.Length;k++)
            {
                //Добавление символа в тексте
                res += t[a[k]];
            }
            //Результат метода
            return res;
        }
        // метод отображает значение аргументов
        static void show(int[] a, params char[] b)
        {
            //Количество элементов в числовом массиве
            Console.Write("Чисел " + a.Length + ": ");
            //Значения элементов в числовом массиве
            for(int k=0;k<a.Length-1;k++)
            {
                Console.Write(a[k] + " ");
            }
            Console.WriteLine("и "+a[a.Length-1]);
            //Количество символьных аргументов
            Console.Write("Символов " + b.Length + ": ");
            //Значение символьных аргументов
            for(int k=0; k<b.Length-1;k++)
            {
                Console.Write(b[k] + " ");
            }
            Console.WriteLine("и " + b[b.Length - 1]);
        }
        //Главный метод программы
        static void Main(string[] args)
        {
            //Примеры вызова методов
            //Вычисление суммы чисел:
            Console.WriteLine("Сумма чисел: "+sum(1,6,9,2,4));
            Console.WriteLine("Сумма чисел: " + sum(5,1,2));
            //Формируется текст
            Console.WriteLine(getText("Раз два три", 0, 10, 8, 1));
            Console.WriteLine(getText("Бревно", 3, 5, 1, 5, 4));
            //Отображаются аргументы
            show(new int[] { 1, 3, 5 }, 'A', 'B', 'C', 'D','E');
            show(new int[] { 1, 3, 5, 7, 9 }, 'A', 'B', 'C', 'D');

        }
    }
}
