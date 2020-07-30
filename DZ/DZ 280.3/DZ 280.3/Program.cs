using System;

namespace DZ_280._3
{
    class Program
    {
        static int [] Metod(int [] a, int b)
        {
            int[] c = new int[b];
            
            for(int k=0;k<b;k++)
            {
                c[k]= a[k];
            }
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Работаем!");
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            
            A = Metod(A, 5);

            for(int k=1;k<= A.Length;k++)
            {
                Console.Write(A[k-1]);
            }
            

            Console.ReadKey();
        }
    }
}
