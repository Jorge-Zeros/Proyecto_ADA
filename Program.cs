using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ADA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AlgoritmosOrdenaciónControl());
            int[] A = new int[] { 0, 4, 10, 3, 5, 1 };
            BubbleSortClass.Ordenar(A);
            MergeSortClass.Ordenar(A);
            HeapSortClass.Ordenar(A);
        }
    }
}
