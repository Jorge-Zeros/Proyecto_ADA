namespace Proyecto_ADA
{
    partial class AlgoritmosOrdenacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.chartGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipos
            // 
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Items.AddRange(new object[] {
            "Grupo1",
            "Grupo2",
            "Grupo3"});
            this.cmbTipos.Location = new System.Drawing.Point(16, 94);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(121, 24);
            this.cmbTipos.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 157);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(131, 56);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Ejecutar Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(149, 12);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.RowTemplate.Height = 24;
            this.dgvResultado.Size = new System.Drawing.Size(833, 275);
            this.dgvResultado.TabIndex = 2;
            // 
            // chartGrafica
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGrafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGrafica.Legends.Add(legend1);
            this.chartGrafica.Location = new System.Drawing.Point(16, 293);
            this.chartGrafica.Name = "chartGrafica";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGrafica.Series.Add(series1);
            this.chartGrafica.Size = new System.Drawing.Size(1211, 266);
            this.chartGrafica.TabIndex = 3;
            this.chartGrafica.Text = "chart1";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1079, 132);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 45);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AlgoritmosOrdenacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 571);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.chartGrafica);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.cmbTipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AlgoritmosOrdenacion";
            this.Text = "Algoritmos de Ordenación";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrafica;
        private System.Windows.Forms.Button btnSalir;
    }
}

