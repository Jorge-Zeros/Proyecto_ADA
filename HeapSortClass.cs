using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ADA
{
    internal class HeapSortClass
    {
        public HeapSortClass()
        {
            
        }

        public static void Ordenar(int[] A)
        {
            int n = A.Length - 1;
            HEAPSORT(A, n);
            Console.WriteLine(String.Join(", ", A));
        }   
        public static void HEAPSORT(int[] A, int n)
        {
            BuildMaxHeap(A, n);
            int m = n;
            for (int i = n; i >= 2; i--) // decreciendo
            {
                Swap(ref A[1], ref A[i]);
                m = m - 1;
                MAX_HEAPIFY(A, m, 1);
            }
        }

        public static void BuildMaxHeap(int[] A, int n)
        {
            for (int i = n / 2; i >= 1; i--)
            {
                MAX_HEAPIFY(A, n, i);
            }
        }

        public static void MAX_HEAPIFY(int[] A, int n, int i)
        {
            int iz = 2 * i;
            int de = 2 * i + 1;
            int mayor;

            if (iz <= n && A[iz] > A[i])
            {
                mayor = iz;
            }
            else
            {
                mayor = i;
            }

            if (de <= n && A[de] > A[mayor])
            {
                mayor = de;
            }

            if (mayor != i)
            {
                Swap(ref A[i], ref A[mayor]);
                MAX_HEAPIFY(A, n, mayor);
            }
        }

        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
