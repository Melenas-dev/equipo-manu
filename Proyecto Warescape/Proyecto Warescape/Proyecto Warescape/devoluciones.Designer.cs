
namespace Proyecto_Warescape
{
    partial class devoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(devoluciones));
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nombre = new System.Windows.Forms.Label();
            this.btn_guardar_editorial = new System.Windows.Forms.Button();
            this.dgv_devoluciones = new System.Windows.Forms.DataGridView();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.cmb_libros = new System.Windows.Forms.ComboBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_id_devoluciones = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label1.Location = new System.Drawing.Point(176, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Libros devueltos";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(8, 352);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(162, 35);
            this.button7.TabIndex = 34;
            this.button7.Text = "Borrar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 27);
            this.panel1.TabIndex = 37;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.Nombre.Location = new System.Drawing.Point(8, 115);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(50, 24);
            this.Nombre.TabIndex = 36;
            this.Nombre.Text = "Libro";
            // 
            // btn_guardar_editorial
            // 
            this.btn_guardar_editorial.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar_editorial.FlatAppearance.BorderSize = 0;
            this.btn_guardar_editorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_guardar_editorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_editorial.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_editorial.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_editorial.Location = new System.Drawing.Point(6, 320);
            this.btn_guardar_editorial.Name = "btn_guardar_editorial";
            this.btn_guardar_editorial.Size = new System.Drawing.Size(163, 35);
            this.btn_guardar_editorial.TabIndex = 33;
            this.btn_guardar_editorial.Text = "Registrar";
            this.btn_guardar_editorial.UseVisualStyleBackColor = false;
            this.btn_guardar_editorial.Click += new System.EventHandler(this.btn_guardar_editorial_Click);
            // 
            // dgv_devoluciones
            // 
            this.dgv_devoluciones.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_devoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_devoluciones.Location = new System.Drawing.Point(180, 57);
            this.dgv_devoluciones.Name = "dgv_devoluciones";
            this.dgv_devoluciones.Size = new System.Drawing.Size(491, 339);
            this.dgv_devoluciones.TabIndex = 35;
            this.dgv_devoluciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_devoluciones_CellClick);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(650, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(40, 27);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 27;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // cmb_libros
            // 
            this.cmb_libros.FormattingEnabled = true;
            this.cmb_libros.Location = new System.Drawing.Point(12, 143);
            this.cmb_libros.Name = "cmb_libros";
            this.cmb_libros.Size = new System.Drawing.Size(158, 21);
            this.cmb_libros.TabIndex = 39;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(12, 209);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(158, 20);
            this.txt_cantidad.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label2.Location = new System.Drawing.Point(8, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 48);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ingresar Libro\r\nPara Devolver\r\n";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CustomFormat = "yyyy-MM-dd";
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha.Location = new System.Drawing.Point(12, 283);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(99, 20);
            this.dtp_fecha.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label4.Location = new System.Drawing.Point(12, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Fecha";
            // 
            // lbl_id_devoluciones
            // 
            this.lbl_id_devoluciones.AutoSize = true;
            this.lbl_id_devoluciones.CausesValidation = false;
            this.lbl_id_devoluciones.Location = new System.Drawing.Point(39, 419);
            this.lbl_id_devoluciones.Name = "lbl_id_devoluciones";
            this.lbl_id_devoluciones.Size = new System.Drawing.Size(0, 13);
            this.lbl_id_devoluciones.TabIndex = 48;
            this.lbl_id_devoluciones.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 49;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(177, 419);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(35, 13);
            this.lbl_nombre.TabIndex = 50;
            this.lbl_nombre.Text = "label6";
            this.lbl_nombre.Visible = false;
            // 
            // devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_id_devoluciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.cmb_libros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.btn_guardar_editorial);
            this.Controls.Add(this.dgv_devoluciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "devoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "devoluciones";
            this.Load += new System.EventHandler(this.devoluciones_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button btn_guardar_editorial;
        private System.Windows.Forms.DataGridView dgv_devoluciones;
        private System.Windows.Forms.ComboBox cmb_libros;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_id_devoluciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_nombre;
    }
}