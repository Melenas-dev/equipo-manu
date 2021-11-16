
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
            this.vienepor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.fecha_venta = new System.Windows.Forms.DateTimePicker();
            this.cmb_libros = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_publicidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Registrar_ventra = new System.Windows.Forms.Button();
            this.dgv_ventas = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.Button();
            this.lbl_n_de_boleta = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.btn_control_caja = new System.Windows.Forms.Button();
            this.btn_estadisticas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_boleta
            // 
            this.txt_boleta.Location = new System.Drawing.Point(24, 100);
            this.txt_boleta.Name = "txt_boleta";
            this.txt_boleta.Size = new System.Drawing.Size(91, 20);
            this.txt_boleta.TabIndex = 9;
            this.txt_boleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_boleta_KeyPress);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(24, 171);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(91, 20);
            this.txt_precio.TabIndex = 10;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(159, 171);
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
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 73);
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
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 73);
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
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 141);
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
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(136, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad Comprada";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgv_lista
            // 
            this.dgv_lista.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n_de_boleta,
            this.fecha,
            this.precio,
            this.cantidad,
            this.libro,
            this.vienepor});
            this.dgv_lista.Location = new System.Drawing.Point(322, 73);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // vienepor
            // 
            this.vienepor.HeaderText = "Viene Por";
            this.vienepor.Name = "vienepor";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar.Location = new System.Drawing.Point(78, 292);
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
            this.fecha_venta.Location = new System.Drawing.Point(159, 100);
            this.fecha_venta.Name = "fecha_venta";
            this.fecha_venta.Size = new System.Drawing.Size(99, 20);
            this.fecha_venta.TabIndex = 47;
            // 
            // cmb_libros
            // 
            this.cmb_libros.FormattingEnabled = true;
            this.cmb_libros.Location = new System.Drawing.Point(22, 236);
            this.cmb_libros.Name = "cmb_libros";
            this.cmb_libros.Size = new System.Drawing.Size(114, 21);
            this.cmb_libros.TabIndex = 48;
            this.cmb_libros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_libros_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 49;
            this.label5.Text = "libro";
            // 
            // cmb_publicidad
            // 
            this.cmb_publicidad.FormattingEnabled = true;
            this.cmb_publicidad.Location = new System.Drawing.Point(157, 236);
            this.cmb_publicidad.Name = "cmb_publicidad";
            this.cmb_publicidad.Size = new System.Drawing.Size(121, 21);
            this.cmb_publicidad.TabIndex = 50;
            this.cmb_publicidad.SelectedIndexChanged += new System.EventHandler(this.cmb_publicidad_SelectedIndexChanged);
            this.cmb_publicidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_publicidad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(155, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 51;
            this.label6.Text = "Viene por";
            // 
            // Registrar_ventra
            // 
            this.Registrar_ventra.BackColor = System.Drawing.Color.Transparent;
            this.Registrar_ventra.FlatAppearance.BorderSize = 0;
            this.Registrar_ventra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Registrar_ventra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrar_ventra.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar_ventra.ForeColor = System.Drawing.Color.White;
            this.Registrar_ventra.Location = new System.Drawing.Point(577, 292);
            this.Registrar_ventra.Name = "Registrar_ventra";
            this.Registrar_ventra.Size = new System.Drawing.Size(171, 35);
            this.Registrar_ventra.TabIndex = 52;
            this.Registrar_ventra.Text = "Registrar ventra";
            this.Registrar_ventra.UseVisualStyleBackColor = false;
            this.Registrar_ventra.Click += new System.EventHandler(this.Registrar_ventra_Click);
            // 
            // dgv_ventas
            // 
            this.dgv_ventas.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventas.Location = new System.Drawing.Point(12, 391);
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.ReadOnly = true;
            this.dgv_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ventas.Size = new System.Drawing.Size(884, 295);
            this.dgv_ventas.TabIndex = 53;
            this.dgv_ventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ventas_CellClick);
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.Color.Transparent;
            this.Borrar.FlatAppearance.BorderSize = 0;
            this.Borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrar.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar.ForeColor = System.Drawing.Color.White;
            this.Borrar.Location = new System.Drawing.Point(745, 292);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(136, 35);
            this.Borrar.TabIndex = 54;
            this.Borrar.Text = "Borrar venta";
            this.Borrar.UseVisualStyleBackColor = false;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // lbl_n_de_boleta
            // 
            this.lbl_n_de_boleta.AutoSize = true;
            this.lbl_n_de_boleta.Location = new System.Drawing.Point(37, 29);
            this.lbl_n_de_boleta.Name = "lbl_n_de_boleta";
            this.lbl_n_de_boleta.Size = new System.Drawing.Size(0, 13);
            this.lbl_n_de_boleta.TabIndex = 55;
            this.lbl_n_de_boleta.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(944, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximizar.Image")));
            this.btnmaximizar.Location = new System.Drawing.Point(992, 2);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(42, 30);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 57;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(992, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(42, 30);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 58;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1040, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(42, 30);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btn_control_caja
            // 
            this.btn_control_caja.BackColor = System.Drawing.Color.Transparent;
            this.btn_control_caja.FlatAppearance.BorderSize = 0;
            this.btn_control_caja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_control_caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_control_caja.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_control_caja.ForeColor = System.Drawing.Color.White;
            this.btn_control_caja.Location = new System.Drawing.Point(902, 651);
            this.btn_control_caja.Name = "btn_control_caja";
            this.btn_control_caja.Size = new System.Drawing.Size(171, 35);
            this.btn_control_caja.TabIndex = 61;
            this.btn_control_caja.Text = "Control de caja";
            this.btn_control_caja.UseVisualStyleBackColor = false;
            this.btn_control_caja.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_estadisticas
            // 
            this.btn_estadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btn_estadisticas.FlatAppearance.BorderSize = 0;
            this.btn_estadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estadisticas.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estadisticas.ForeColor = System.Drawing.Color.White;
            this.btn_estadisticas.Location = new System.Drawing.Point(22, 17);
            this.btn_estadisticas.Name = "btn_estadisticas";
            this.btn_estadisticas.Size = new System.Drawing.Size(219, 35);
            this.btn_estadisticas.TabIndex = 62;
            this.btn_estadisticas.Text = "Estadisticas mensuales";
            this.btn_estadisticas.UseVisualStyleBackColor = false;
            this.btn_estadisticas.Click += new System.EventHandler(this.btn_estadisticas_Click);
            // 
            // finanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 698);
            this.Controls.Add(this.btn_estadisticas);
            this.Controls.Add(this.btn_control_caja);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnmaximizar);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.lbl_n_de_boleta);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.dgv_ventas);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_ventas;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Label lbl_n_de_boleta;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Button btn_control_caja;
        private System.Windows.Forms.Button btn_estadisticas;
    }
}