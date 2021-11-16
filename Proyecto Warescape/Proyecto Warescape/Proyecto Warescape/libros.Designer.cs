﻿
namespace Proyecto_Warescape
{
    partial class VentanasPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanasPrincipal));
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_generos = new System.Windows.Forms.DataGridView();
            this.nombre_genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_editorial = new System.Windows.Forms.ComboBox();
            this.Cmb_genero = new System.Windows.Forms.ComboBox();
            this.dgv_libros = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_valor_del_libro = new System.Windows.Forms.TextBox();
            this.cmb_tipo_de_operacion = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_boleta = new System.Windows.Forms.ComboBox();
            this.lbl_id_de_libro = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_ingresar_consignacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_generos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(652, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Géneros del libro";
            // 
            // dgv_generos
            // 
            this.dgv_generos.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_generos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_generos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_genero,
            this.id_genero});
            this.dgv_generos.Location = new System.Drawing.Point(656, 129);
            this.dgv_generos.Name = "dgv_generos";
            this.dgv_generos.ReadOnly = true;
            this.dgv_generos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_generos.Size = new System.Drawing.Size(243, 98);
            this.dgv_generos.TabIndex = 23;
            this.dgv_generos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_generos_CellContentClick);
            // 
            // nombre_genero
            // 
            this.nombre_genero.HeaderText = "Nombre";
            this.nombre_genero.Name = "nombre_genero";
            this.nombre_genero.ReadOnly = true;
            // 
            // id_genero
            // 
            this.id_genero.HeaderText = "ID del género";
            this.id_genero.Name = "id_genero";
            this.id_genero.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(328, 156);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(77, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Editorial";
            this.label7.UseMnemonic = false;
            // 
            // cmb_editorial
            // 
            this.cmb_editorial.FormattingEnabled = true;
            this.cmb_editorial.Location = new System.Drawing.Point(330, 186);
            this.cmb_editorial.Name = "cmb_editorial";
            this.cmb_editorial.Size = new System.Drawing.Size(137, 21);
            this.cmb_editorial.TabIndex = 19;
            this.cmb_editorial.SelectedIndexChanged += new System.EventHandler(this.cmb_editorial_SelectedIndexChanged);
            this.cmb_editorial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_editorial_KeyPress);
            // 
            // Cmb_genero
            // 
            this.Cmb_genero.DisplayMember = "descripcion";
            this.Cmb_genero.FormattingEnabled = true;
            this.Cmb_genero.Location = new System.Drawing.Point(491, 186);
            this.Cmb_genero.Name = "Cmb_genero";
            this.Cmb_genero.Size = new System.Drawing.Size(137, 21);
            this.Cmb_genero.TabIndex = 18;
            this.Cmb_genero.Tag = "";
            this.Cmb_genero.ValueMember = "id_genero";
            this.Cmb_genero.SelectedIndexChanged += new System.EventHandler(this.Cmb_genero_SelectedIndexChanged);
            this.Cmb_genero.SelectedValueChanged += new System.EventHandler(this.Cmb_genero_SelectedValueChanged);
            this.Cmb_genero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_genero_KeyPress);
            // 
            // dgv_libros
            // 
            this.dgv_libros.AllowUserToAddRows = false;
            this.dgv_libros.AllowUserToDeleteRows = false;
            this.dgv_libros.AllowUserToOrderColumns = true;
            this.dgv_libros.AllowUserToResizeColumns = false;
            this.dgv_libros.AllowUserToResizeRows = false;
            this.dgv_libros.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_libros.Location = new System.Drawing.Point(30, 359);
            this.dgv_libros.Name = "dgv_libros";
            this.dgv_libros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_libros.Size = new System.Drawing.Size(897, 327);
            this.dgv_libros.TabIndex = 17;
            this.dgv_libros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_libros_CellClick);
            this.dgv_libros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_libros_CellContentClick);
            this.dgv_libros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_libros_KeyPress);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(624, 318);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 35);
            this.button7.TabIndex = 16;
            this.button7.Text = "Borrar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(461, 318);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 35);
            this.button6.TabIndex = 15;
            this.button6.Text = "Guardar edición";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.guardar_edicion);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(35, 311);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 35);
            this.button5.TabIndex = 14;
            this.button5.Text = "Ingresar libro";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ingresar_libro);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(16, 186);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(134, 20);
            this.txt_nombre.TabIndex = 11;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(493, 287);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(135, 20);
            this.txt_cantidad.TabIndex = 10;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stock_KeyPress);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(491, 129);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(137, 20);
            this.txt_precio.TabIndex = 9;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(330, 129);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(137, 20);
            this.txt_codigo.TabIndex = 8;
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(165, 131);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(137, 20);
            this.txt_isbn.TabIndex = 7;
            this.txt_isbn.TextChanged += new System.EventHandler(this.txt_isbn_TextChanged);
            this.txt_isbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_isbn_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(487, 156);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Genero";
            this.label6.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(489, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(487, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(326, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(164, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Autor";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(168, 184);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(137, 20);
            this.txt_autor.TabIndex = 30;
            this.txt_autor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(933, 653);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 35);
            this.button2.TabIndex = 33;
            this.button2.Text = "Generos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(933, 612);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 35);
            this.button3.TabIndex = 34;
            this.button3.Text = "Editoriales";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_valor_del_libro
            // 
            this.txt_valor_del_libro.Location = new System.Drawing.Point(332, 287);
            this.txt_valor_del_libro.Name = "txt_valor_del_libro";
            this.txt_valor_del_libro.Size = new System.Drawing.Size(135, 20);
            this.txt_valor_del_libro.TabIndex = 36;
            this.txt_valor_del_libro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_del_libro_KeyPress);
            // 
            // cmb_tipo_de_operacion
            // 
            this.cmb_tipo_de_operacion.FormattingEnabled = true;
            this.cmb_tipo_de_operacion.Items.AddRange(new object[] {
            "Compra",
            "Consignacion"});
            this.cmb_tipo_de_operacion.Location = new System.Drawing.Point(168, 284);
            this.cmb_tipo_de_operacion.Name = "cmb_tipo_de_operacion";
            this.cmb_tipo_de_operacion.Size = new System.Drawing.Size(137, 21);
            this.cmb_tipo_de_operacion.TabIndex = 37;
            this.cmb_tipo_de_operacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_tipo_de_operacion_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(164, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 24);
            this.label11.TabIndex = 39;
            this.label11.Text = "Tipo de operacion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(328, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 24);
            this.label12.TabIndex = 40;
            this.label12.Text = "Valor del libro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 24);
            this.label10.TabIndex = 41;
            this.label10.Text = "Nª de operacion";
            // 
            // cmb_boleta
            // 
            this.cmb_boleta.FormattingEnabled = true;
            this.cmb_boleta.Location = new System.Drawing.Point(16, 284);
            this.cmb_boleta.Name = "cmb_boleta";
            this.cmb_boleta.Size = new System.Drawing.Size(134, 21);
            this.cmb_boleta.TabIndex = 42;
            this.cmb_boleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_boleta_KeyPress);
            // 
            // lbl_id_de_libro
            // 
            this.lbl_id_de_libro.AutoSize = true;
            this.lbl_id_de_libro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_de_libro.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.lbl_id_de_libro.Location = new System.Drawing.Point(21, 130);
            this.lbl_id_de_libro.Name = "lbl_id_de_libro";
            this.lbl_id_de_libro.Size = new System.Drawing.Size(0, 24);
            this.lbl_id_de_libro.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 24);
            this.label14.TabIndex = 44;
            this.label14.Text = "ID";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CustomFormat = "yyyy-MM-dd";
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha.Location = new System.Drawing.Point(656, 284);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(99, 20);
            this.dtp_fecha.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(652, 251);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(59, 24);
            this.label13.TabIndex = 46;
            this.label13.Text = "Fecha";
            this.label13.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(933, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 35);
            this.button1.TabIndex = 47;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium", 28F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(27, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(263, 44);
            this.label15.TabIndex = 48;
            this.label15.Text = "Ingresar Libros";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(933, 571);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 35);
            this.button4.TabIndex = 50;
            this.button4.Text = "Devoluciones";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(945, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1041, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(42, 30);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 26;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximizar.Image")));
            this.btnmaximizar.Location = new System.Drawing.Point(993, 2);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(42, 30);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 27;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(993, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(42, 30);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 28;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Franklin Gothic Medium", 17F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(30, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(242, 29);
            this.label17.TabIndex = 52;
            this.label17.Text = "Consignacion o compra";
            // 
            // btn_ingresar_consignacion
            // 
            this.btn_ingresar_consignacion.BackColor = System.Drawing.Color.Transparent;
            this.btn_ingresar_consignacion.FlatAppearance.BorderSize = 0;
            this.btn_ingresar_consignacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_ingresar_consignacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar_consignacion.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar_consignacion.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar_consignacion.Location = new System.Drawing.Point(168, 311);
            this.btn_ingresar_consignacion.Name = "btn_ingresar_consignacion";
            this.btn_ingresar_consignacion.Size = new System.Drawing.Size(287, 35);
            this.btn_ingresar_consignacion.TabIndex = 53;
            this.btn_ingresar_consignacion.Text = "Ingresar consignacion o compra";
            this.btn_ingresar_consignacion.UseVisualStyleBackColor = false;
            this.btn_ingresar_consignacion.Click += new System.EventHandler(this.btn_ingresar_consignacion_Click);
            // 
            // VentanasPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 698);
            this.Controls.Add(this.btn_ingresar_consignacion);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_id_de_libro);
            this.Controls.Add(this.cmb_boleta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_tipo_de_operacion);
            this.Controls.Add(this.txt_valor_del_libro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.btnmaximizar);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_generos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.cmb_editorial);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.Cmb_genero);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.dgv_libros);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanasPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventanas";
            this.Load += new System.EventHandler(this.VentanasPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_generos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_libros;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox Cmb_genero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_editorial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_generos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_genero;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_valor_del_libro;
        private System.Windows.Forms.ComboBox cmb_tipo_de_operacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_boleta;
        private System.Windows.Forms.Label lbl_id_de_libro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_ingresar_consignacion;
    }
}