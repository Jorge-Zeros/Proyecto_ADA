using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ADA
{
    internal class BubbleSortClass
    {
        public static void Ordenar(int[] A)
        {
            BUBBLESORT(A);
            Console.WriteLine(String.Join(", ", A));
        }
        public static void BUBBLESORT(int[] A)
        {
            int n = A.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (A[j] > A[j + 1])
                    {
                        Swap(ref A[j], ref A[j + 1]);
                    }
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
