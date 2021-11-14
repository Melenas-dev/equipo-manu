
namespace Proyecto_Warescape
{
    partial class finanzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finanzas));
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.txt_boleta = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_lista = new System.Windows.Forms.DataGridView();
            this.n_de_boleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.fecha_venta = new System.Windows.Forms.DateTimePicker();
            this.cmb_libros = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_publicidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vienepor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registrar_ventra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1031, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(42, 30);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // txt_boleta
            // 
            this.txt_boleta.Location = new System.Drawing.Point(22, 109);
            this.txt_boleta.Name = "txt_boleta";
            this.txt_boleta.Size = new System.Drawing.Size(91, 20);
            this.txt_boleta.TabIndex = 9;
            this.txt_boleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_boleta_KeyPress);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(22, 180);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(91, 20);
            this.txt_precio.TabIndex = 10;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(157, 180);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(119, 20);
            this.txt_cantidad.TabIndex = 12;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label1.Location = new System.Drawing.Point(18, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "N° de boleta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label2.Location = new System.Drawing.Point(153, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha de venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label3.Location = new System.Drawing.Point(31, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label4.Location = new System.Drawing.Point(134, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad Comprada";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgv_lista
            // 
            this.dgv_lista.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n_de_boleta,
            this.fecha,
            this.precio,
            this.cantidad,
            this.libro,
            this.vienepor});
            this.dgv_lista.Location = new System.Drawing.Point(320, 82);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.Size = new System.Drawing.Size(643, 173);
            this.dgv_lista.TabIndex = 18;
            this.dgv_lista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lista_CellDoubleClick);
            // 
            // n_de_boleta
            // 
            this.n_de_boleta.HeaderText = "n * de boleta";
            this.n_de_boleta.Name = "n_de_boleta";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "fecha de venta";
            this.fecha.Name = "fecha";
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad comprada";
            this.cantidad.Name = "cantidad";
            // 
            // libro
            // 
            this.libro.HeaderText = "libro";
            this.libro.Name = "libro";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_Agregar.Location = new System.Drawing.Point(20, 302);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(124, 35);
            this.btn_Agregar.TabIndex = 19;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.button5_Click);
            // 
            // fecha_venta
            // 
            this.fecha_venta.CustomFormat = "yyyy-MM-dd";
            this.fecha_venta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_venta.Location = new System.Drawing.Point(157, 109);
            this.fecha_venta.Name = "fecha_venta";
            this.fecha_venta.Size = new System.Drawing.Size(99, 20);
            this.fecha_venta.TabIndex = 47;
            // 
            // cmb_libros
            // 
            this.cmb_libros.FormattingEnabled = true;
            this.cmb_libros.Location = new System.Drawing.Point(20, 245);
            this.cmb_libros.Name = "cmb_libros";
            this.cmb_libros.Size = new System.Drawing.Size(114, 21);
            this.cmb_libros.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label5.Location = new System.Drawing.Point(26, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 49;
            this.label5.Text = "libro";
            // 
            // cmb_publicidad
            // 
            this.cmb_publicidad.FormattingEnabled = true;
            this.cmb_publicidad.Location = new System.Drawing.Point(155, 245);
            this.cmb_publicidad.Name = "cmb_publicidad";
            this.cmb_publicidad.Size = new System.Drawing.Size(121, 21);
            this.cmb_publicidad.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label6.Location = new System.Drawing.Point(153, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 51;
            this.label6.Text = "Viene por";
            // 
            // vienepor
            // 
            this.vienepor.HeaderText = "Viene Por";
            this.vienepor.Name = "vienepor";
            // 
            // Registrar_ventra
            // 
            this.Registrar_ventra.BackColor = System.Drawing.Color.Transparent;
            this.Registrar_ventra.FlatAppearance.BorderSize = 0;
            this.Registrar_ventra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Registrar_ventra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrar_ventra.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar_ventra.ForeColor = System.Drawing.Color.Black;
            this.Registrar_ventra.Location = new System.Drawing.Point(320, 302);
            this.Registrar_ventra.Name = "Registrar_ventra";
            this.Registrar_ventra.Size = new System.Drawing.Size(171, 35);
            this.Registrar_ventra.TabIndex = 52;
            this.Registrar_ventra.Text = "Registrar ventra";
            this.Registrar_ventra.UseVisualStyleBackColor = false;
            this.Registrar_ventra.Click += new System.EventHandler(this.Registrar_ventra_Click);
            // 
            // finanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 698);
            this.Controls.Add(this.Registrar_ventra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_publicidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_libros);
            this.Controls.Add(this.fecha_venta);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dgv_lista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_boleta);
            this.Controls.Add(this.BtnCerrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "finanzas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "finanzas";
            this.Load += new System.EventHandler(this.finanzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.TextBox txt_boleta;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_lista;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DateTimePicker fecha_venta;
        private System.Windows.Forms.ComboBox cmb_libros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_de_boleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn libro;
        private System.Windows.Forms.ComboBox cmb_publicidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn vienepor;
        private System.Windows.Forms.Button Registrar_ventra;
    }
}