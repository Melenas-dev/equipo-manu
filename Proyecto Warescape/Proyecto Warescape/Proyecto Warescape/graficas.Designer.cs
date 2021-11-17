
namespace Proyecto_Warescape
{
    partial class graficas
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
            this.chartpublicidades = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnconveniencia = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartpublicidades)).BeginInit();
            this.SuspendLayout();
            // 
            // chartpublicidades
            // 
            this.chartpublicidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartpublicidades.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.chartpublicidades.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartpublicidades.Legends.Add(legend1);
            this.chartpublicidades.Location = new System.Drawing.Point(68, 12);
            this.chartpublicidades.Name = "chartpublicidades";
            this.chartpublicidades.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Publicitado";
            this.chartpublicidades.Series.Add(series1);
            this.chartpublicidades.Size = new System.Drawing.Size(630, 635);
            this.chartpublicidades.TabIndex = 0;
            this.chartpublicidades.Text = "chart1";
            // 
            // btnconveniencia
            // 
            this.btnconveniencia.BackColor = System.Drawing.Color.Transparent;
            this.btnconveniencia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnconveniencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnconveniencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconveniencia.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconveniencia.ForeColor = System.Drawing.Color.White;
            this.btnconveniencia.Location = new System.Drawing.Point(725, 90);
            this.btnconveniencia.Name = "btnconveniencia";
            this.btnconveniencia.Size = new System.Drawing.Size(296, 35);
            this.btnconveniencia.TabIndex = 35;
            this.btnconveniencia.Text = "Conveniencia de Markering";
            this.btnconveniencia.UseVisualStyleBackColor = false;
            this.btnconveniencia.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(796, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 43);
            this.label7.TabIndex = 64;
            this.label7.Text = "Gráficas";
            // 
            // graficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1069, 659);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnconveniencia);
            this.Controls.Add(this.chartpublicidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "graficas";
            this.Text = "Graficas";
            ((System.ComponentModel.ISupportInitialize)(this.chartpublicidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartpublicidades;
        private System.Windows.Forms.Button btnconveniencia;
        private System.Windows.Forms.Label label7;
    }
}