
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estadisticas_mensuales));
            this.lbl_titulo_promedio = new System.Windows.Forms.Label();
            this.lbl_promedio_total = new System.Windows.Forms.Label();
            this.btn_cargar_datos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_editoriales = new System.Windows.Forms.ComboBox();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.cmb_año = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo_promedio
            // 
            this.lbl_titulo_promedio.AutoSize = true;
            this.lbl_titulo_promedio.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_promedio.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo_promedio.Location = new System.Drawing.Point(45, 192);
            this.lbl_titulo_promedio.Name = "lbl_titulo_promedio";
            this.lbl_titulo_promedio.Size = new System.Drawing.Size(327, 21);
            this.lbl_titulo_promedio.TabIndex = 1;
            this.lbl_titulo_promedio.Text = "Promedio de ganancia mensual en total:";
            // 
            // lbl_promedio_total
            // 
            this.lbl_promedio_total.AutoSize = true;
            this.lbl_promedio_total.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_promedio_total.ForeColor = System.Drawing.Color.White;
            this.lbl_promedio_total.Location = new System.Drawing.Point(202, 222);
            this.lbl_promedio_total.Name = "lbl_promedio_total";
            this.lbl_promedio_total.Size = new System.Drawing.Size(19, 21);
            this.lbl_promedio_total.TabIndex = 3;
            this.lbl_promedio_total.Text = "0";
            // 
            // btn_cargar_datos
            // 
            this.btn_cargar_datos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cargar_datos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cargar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargar_datos.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar_datos.ForeColor = System.Drawing.Color.White;
            this.btn_cargar_datos.Location = new System.Drawing.Point(156, 256);
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
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione un mes:";
            // 
            // cmb_editoriales
            // 
            this.cmb_editoriales.DisplayMember = "nombre";
            this.cmb_editoriales.FormattingEnabled = true;
            this.cmb_editoriales.Location = new System.Drawing.Point(299, 152);
            this.cmb_editoriales.Name = "cmb_editoriales";
            this.cmb_editoriales.Size = new System.Drawing.Size(121, 21);
            this.cmb_editoriales.TabIndex = 3;
            this.cmb_editoriales.ValueMember = "id_ed";
            this.cmb_editoriales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_editoriales_KeyPress);
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
            this.cmb_mes.Location = new System.Drawing.Point(299, 120);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(121, 21);
            this.cmb_mes.TabIndex = 2;
            this.cmb_mes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_mes_KeyPress);
            // 
            // cmb_año
            // 
            this.cmb_año.FormattingEnabled = true;
            this.cmb_año.Location = new System.Drawing.Point(299, 86);
            this.cmb_año.Name = "cmb_año";
            this.cmb_año.Size = new System.Drawing.Size(121, 21);
            this.cmb_año.TabIndex = 1;
            this.cmb_año.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_año_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seleccione un año:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione una editorial (opcional):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 34);
            this.label2.TabIndex = 16;
            this.label2.Text = "Estadísticas Mensuales";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(387, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(42, 27);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 17;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // estadisticas_mensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(432, 297);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_año);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_mes);
            this.Controls.Add(this.cmb_editoriales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cargar_datos);
            this.Controls.Add(this.lbl_promedio_total);
            this.Controls.Add(this.lbl_titulo_promedio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "estadisticas_mensuales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas mensuales";
            this.Load += new System.EventHandler(this.estadisticas_mensuales_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.estadisticas_mensuales_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BtnCerrar;
    }
}