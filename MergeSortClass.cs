using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ADA
{
    internal class MergeSortClass
    {
        public static void Ordenar(int[] A)
        {
            MERGESORT(A, 0, A.Length - 1);
            Console.WriteLine(String.Join(", ", A));
        }
        public static void MERGESORT(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                MERGESORT(A, p, q);
                MERGESORT(A, q + 1, r);
                INTERCALA(A, p, q, r);
            }
        }

        public static void INTERCALA(int[] A, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1];
            int[] R = new int[n2];
            Array.Copy(A, p, L, 0, n1);
            Array.Copy(A, q + 1, R, 0, n2);
            int i = 0;
            int j = 0;
            for (int k = p; k <= r; k++)
            {
                if (i < n1 && (j >= n2 || L[i] <= R[j]))
                {
                    A[k] = L[i];
                    i++;
                }
                else
                {
                    A[k] = R[j];
                    j++;
                }
            }
        }
    }
}
