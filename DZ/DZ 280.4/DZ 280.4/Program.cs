using System;

namespace DZ_280._4
{
    class Program
    {
        static int [] Metod(char [] a)
        {
            int [] B = new int [a.Length];
            for (int k=0;k<a.Length;k++)
            {
                uint code = (uint)a[k];
                int code2 = Convert.ToInt32(code);
                B[k] = code2;
            }
            return B;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Поехали");
            char[] A = { 'A', 'B', 'C', 'D', 'F', 'G' };
            int [] B = Metod(A);

            
            for (int k = 1; k <= B.Length; k++)
            {
                Console.Write(B[k - 1]+"|");
            }

        }
    }
}
