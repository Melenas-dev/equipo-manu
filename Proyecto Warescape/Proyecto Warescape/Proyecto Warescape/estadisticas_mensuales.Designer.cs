
namespace Proyecto_Warescape
{
    partial class estadisticas_mensuales
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
            this.lbl_titulo_promedio = new System.Windows.Forms.Label();
            this.lbl_promedio_total = new System.Windows.Forms.Label();
            this.btn_cargar_datos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_editoriales = new System.Windows.Forms.ComboBox();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.cmb_año = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titulo_promedio
            // 
            this.lbl_titulo_promedio.AutoSize = true;
            this.lbl_titulo_promedio.Location = new System.Drawing.Point(115, 153);
            this.lbl_titulo_promedio.Name = "lbl_titulo_promedio";
            this.lbl_titulo_promedio.Size = new System.Drawing.Size(193, 13);
            this.lbl_titulo_promedio.TabIndex = 1;
            this.lbl_titulo_promedio.Text = "Promedio de ganancia mensual en total";
            // 
            // lbl_promedio_total
            // 
            this.lbl_promedio_total.AutoSize = true;
            this.lbl_promedio_total.Location = new System.Drawing.Point(206, 194);
            this.lbl_promedio_total.Name = "lbl_promedio_total";
            this.lbl_promedio_total.Size = new System.Drawing.Size(13, 13);
            this.lbl_promedio_total.TabIndex = 3;
            this.lbl_promedio_total.Text = "0";
            // 
            // btn_cargar_datos
            // 
            this.btn_cargar_datos.Location = new System.Drawing.Point(152, 235);
            this.btn_cargar_datos.Name = "btn_cargar_datos";
            this.btn_cargar_datos.Size = new System.Drawing.Size(106, 29);
            this.btn_cargar_datos.TabIndex = 4;
            this.btn_cargar_datos.Text = "Cargar datos";
            this.btn_cargar_datos.UseVisualStyleBackColor = true;
            this.btn_cargar_datos.Click += new System.EventHandler(this.btn_cargar_datos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione un mes:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmb_editoriales
            // 
            this.cmb_editoriales.DisplayMember = "nombre";
            this.cmb_editoriales.FormattingEnabled = true;
            this.cmb_editoriales.Location = new System.Drawing.Point(246, 102);
            this.cmb_editoriales.Name = "cmb_editoriales";
            this.cmb_editoriales.Size = new System.Drawing.Size(121, 21);
            this.cmb_editoriales.TabIndex = 8;
            this.cmb_editoriales.ValueMember = "id_ed";
            // 
            // cmb_mes
            // 
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmb_mes.Location = new System.Drawing.Point(246, 60);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(121, 21);
            this.cmb_mes.TabIndex = 9;
            this.cmb_mes.SelectedIndexChanged += new System.EventHandler(this.cmb_mes_SelectedIndexChanged);
            // 
            // cmb_año
            // 
            this.cmb_año.FormattingEnabled = true;
            this.cmb_año.Location = new System.Drawing.Point(246, 18);
            this.cmb_año.Name = "cmb_año";
            this.cmb_año.Size = new System.Drawing.Size(121, 21);
            this.cmb_año.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seleccione un año:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione una editorial (opcional):";
            // 
            // estadisticas_mensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_año);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_mes);
            this.Controls.Add(this.cmb_editoriales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cargar_datos);
            this.Controls.Add(this.lbl_promedio_total);
            this.Controls.Add(this.lbl_titulo_promedio);
            this.Name = "estadisticas_mensuales";
            this.Text = "Estadisticas mensuales";
            this.Load += new System.EventHandler(this.estadisticas_mensuales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo_promedio;
        private System.Windows.Forms.Label lbl_promedio_total;
        private System.Windows.Forms.Button btn_cargar_datos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_editoriales;
        private System.Windows.Forms.ComboBox cmb_mes;
        private System.Windows.Forms.ComboBox cmb_año;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}