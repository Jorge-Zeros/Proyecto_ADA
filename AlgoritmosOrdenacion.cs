using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ADA
{
    public partial class AlgoritmosOrdenacion : Form
    {
        private int[] ArregloTamanio = { 10, 100, 1000, 10000, 100000 };

        public AlgoritmosOrdenacion()
        {
            InitializeComponent();
        }

        private int[] GenerarArreglo(int tamanio)
        {
            Random random = new Random();
            int[] array = new int[tamanio];
            for (int i = 0; i < tamanio; i++)
            {
                array[i] = random.Next(0, 1000);
            }
            return array;
        }

        private void AgregarSeries(string name, SeriesChartType chartType, System.Drawing.Color color)
        {
            Series series = new Series(name)
            {
                ChartType = chartType,
                Color = color,
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8
            };
            chartGrafica.Series.Add(series);
        }

        // Modulo para ejecutar el Grupo1 De algoritmos de Ordenamiento
        private void EjecutarGrupo1()
        {
            // Tomamos los tiempos
            int i = 0;
            double[] TiempoBubble = new double[5];
            double[] TiempoSelection = new double[5];
            double[] TiempoInsertion = new double[5];
            foreach (int Tamanio in ArregloTamanio)
            {
                // Creamos un arreglo Ramdom
                int[] Arreglo = GenerarArreglo(Tamanio);
                // Tiempo de Bubble
                var Cronometro = System.Diagnostics.Stopwatch.StartNew();
                cOrdenamiento.BubbleSort(Arreglo);
                Cronometro.Stop();
                TiempoBubble[i] = double.Parse(Cronometro.ElapsedMilliseconds.ToString());
                // Tiempo de Selection
                Cronometro.Start();
                cOrdenamiento.SelectionSort(Arreglo);
                Cronometro.Stop();
                TiempoSelection[i] = double.Parse(Cronometro.ElapsedMilliseconds.ToString());
                //Tiempo de Insertion
                Cronometro.Start();
                cOrdenamiento.InsertionSort(Arreglo);
                Cronometro.Stop();
                TiempoInsertion[i] = double.Parse(Cronometro.ElapsedMilliseconds.ToString());
                // Actualizar contador
                i++;
            }

            // Limpiamos las filas y columnas
            dgvResultado.Columns.Clear();
            dgvResultado.Rows.Clear();

            // Agregamos las columnas
            dgvResultado.Columns.Add("Tamanio", "Tamaño");
            dgvResultado.Columns.Add("Bubble", "BubbleSort");
            dgvResultado.Columns.Add("Selection", "SelectionSort");
            dgvResultado.Columns.Add("Insertion", "InsertionSort");

            // Agregar las Filas
            for (int j = 0; j < 5; j++)
            {
                dgvResultado.Rows.Add(ArregloTamanio[j], TiempoBubble[j], TiempoSelection[j], TiempoInsertion[j]);
            }

            // Limpiar las series
            chartGrafica.Series.Clear();

            // Agregar las series
            AgregarSeries("Bubble", SeriesChartType.Line, Color.Blue);
            AgregarSeries("Selection", SeriesChartType.Line, Color.Red);
            AgregarSeries("Insertion", SeriesChartType.Line, Color.Green);

            // Agregar los valores de la serie
            for (int k = 0; k < 5; k++)
            {
                chartGrafica.Series["Bubble"].Points.AddXY(ArregloTamanio[k], TiempoBubble[k]);
                chartGrafica.Series["Selection"].Points.AddXY(ArregloTamanio[k], TiempoSelection[k]);
                chartGrafica.Series["Insertion"].Points.AddXY(ArregloTamanio[k], TiempoInsertion[k]);
            }
        }

        // Modulo para ejecutar el Grupo2 De algoritmos de Ordenamiento
        private void EjecutarGrupo2()
        {
            // Tomamos los tiempos
            int i = 0;
            double[] TiempoMerge = new double[5];
            double[] TiempoQuick = new double[5];
            double[] TiempoQuickRandomized = new double[5];
            double[] TiempoHeap = new double[5];
            foreach (int Tamanio in ArregloTamanio)
            {
                // Creamos un arreglo Ramdom
                int[] Arreglo = GenerarArreglo(Tamanio);
                // Tiempo de Merge
                var Cronometro = System.Diagnostics.Stopwatch.StartNew();
                cOrdenamiento.MergeSort(Arreglo);
                Cronometro.Stop();
                TiempoMerge[i] = double.Parse(Cronometro.ElapsedMilliseconds.ToString());
                // Tiempo de Quick
                Cronometro.Start();
                cOrdenamiento.QuickSort(Arreglo);
                Cronometro.Stop();
                TiempoQuick[i] = double.Parse(Cronometro.ElapsedMilliseconds.ToString());
                //Tiempo de Quick Randomized
                Cronometro.Start();
                cOrdenamiento.InsertionSort(Arreglo);
                Cronometro.Stop();
                TiempoQuickRandomized[i] = double.Parse(Cronometro.ElapsedMilliseconds.ToString());
                //Tiempo de Quick Heap
                Cronometro.Start();
                cOrdenamiento.HeapSort(Arreglo);
                Cronometro.Stop();
                TiempoHeap[i] = double.Parse(Cronometro.ElapsedMilliseconds.ToString());
                // Actualizar contador
                i++;
            }

            // Limpiamos las filas y columnas
            dgvResultado.Columns.Clear();
            dgvResultado.Rows.Clear();

            // Agregamos las columnas
            dgvResultado.Columns.Add("Tamanio", "Tamaño");
            dgvResultado.Columns.Add("Merge", "MergeSort");
            dgvResultado.Columns.Add("Quick", "QuickSort");
            dgvResultado.Columns.Add("QuickRandomized", "QuickRandomizedSort");
            dgvResultado.Columns.Add("Heap", "HeapSort");

            // Agregar las Filas
            for (int j = 0; j < 5; j++)
            {
                dgvResultado.Rows.Add(ArregloTamanio[j], TiempoMerge[j], TiempoQuick[j], TiempoQuickRandomized[j], TiempoHeap[j]);
            }

            // Limpiar las series
            chartGrafica.Series.Clear();

            // Agregar las series
            AgregarSeries("Merge", SeriesChartType.Line, Color.Blue);
            AgregarSeries("Quick", SeriesChartType.Line, Color.Red);
            AgregarSeries("QuickRandomized", SeriesChartType.Line, Color.Green);
            AgregarSeries("Heap", SeriesChartType.Line, Color.Brown);

            // Agregar los valores de la serie
            for (int k = 0; k < 5; k++)
            {
                chartGrafica.Series["Merge"].Points.AddXY(ArregloTamanio[k], TiempoMerge[k]);
                chartGrafica.Series["Quick"].Points.AddXY(ArregloTamanio[k], TiempoQuick[k]);
                chartGrafica.Series["QuickRandomized"].Points.AddXY(ArregloTamanio[k], TiempoQuickRandomized[k]);
                chartGrafica.Series["Heap"].Points.AddXY(ArregloTamanio[k], TiempoHeap[k]);
            }
        }

        // Modulo para ejecutar el Grupo3 De algoritmos de Ordenamiento
        private void EjecutarGrupo3()
        {
            // Tomamos los tiempos
            int i = 0;
            double[] TiempoCount = new double[5];
            double[] TiempoRadix = new double[5];
            foreach (int Tamanio in ArregloTamanio)
            {
                // Creamos un arreglo Ramdom
                int[] Arreglo = GenerarArreglo(Tamanio);
                // Tiempo de Count
                var Cronometro = System.Diagnostics.Stopwatch.StartNew();
                cOrdenamiento.CountSort(Arreglo);
                Cronometro.Stop();
                TiempoCount[i] = double.Parse(Cronometro.ElapsedMilliseconds.ToString());
                // Tiempo de Radix
                Cronometro.Start();
                cOrdenamiento.RadixSort(Arreglo);
                Cronometro.Stop();
                TiempoRadix[i] = double.Parse(Cronometro.ElapsedMilliseconds.ToString());
                // Actualizar contador
                i++;
            }

            // Limpiamos las filas y columnas
            dgvResultado.Columns.Clear();
            dgvResultado.Rows.Clear();

            // Agregamos las columnas
            dgvResultado.Columns.Add("Tamanio", "Tamaño");
            dgvResultado.Columns.Add("Count", "CountSort");
            dgvResultado.Columns.Add("Radix", "RadixSort");

            // Agregar las Filas
            for (int j = 0; j < 5; j++)
            {
                dgvResultado.Rows.Add(ArregloTamanio[j], TiempoCount[j], TiempoRadix[j]);
            }

            // Limpiar las series
            chartGrafica.Series.Clear();

            // Agregar las series
            AgregarSeries("Count", SeriesChartType.Line, Color.Blue);
            AgregarSeries("Radix", SeriesChartType.Line, Color.Red);

            // Agregar los valores de la serie
            for (int k = 0; k < 5; k++)
            {
                chartGrafica.Series["Count"].Points.AddXY(ArregloTamanio[k], TiempoCount[k]);
                chartGrafica.Series["Radix"].Points.AddXY(ArregloTamanio[k], TiempoRadix[k]);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (cmbTipos.Text == "Grupo1")
            {
                EjecutarGrupo1();
            }
            else if (cmbTipos.Text == "Grupo2")
            {
                EjecutarGrupo2();
            }
            else if (cmbTipos.Text == "Grupo3")
            {
                EjecutarGrupo3();
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
