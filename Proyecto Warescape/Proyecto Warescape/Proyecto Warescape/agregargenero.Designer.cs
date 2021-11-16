
namespace Proyecto_Warescape
{
    partial class agregargenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregargenero));
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_guardar_editorial = new System.Windows.Forms.Button();
            this.dgv_generos = new System.Windows.Forms.DataGridView();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_generos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label1.Location = new System.Drawing.Point(176, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Agregar generos";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(12, 179);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(162, 35);
            this.button7.TabIndex = 26;
            this.button7.Text = "Borrar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 27);
            this.panel1.TabIndex = 30;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.Nombre.Location = new System.Drawing.Point(12, 55);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(75, 24);
            this.Nombre.TabIndex = 28;
            this.Nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(12, 82);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(162, 20);
            this.txt_nombre.TabIndex = 23;
            // 
            // btn_guardar_editorial
            // 
            this.btn_guardar_editorial.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar_editorial.FlatAppearance.BorderSize = 0;
            this.btn_guardar_editorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_guardar_editorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_editorial.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_editorial.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_editorial.Location = new System.Drawing.Point(12, 138);
            this.btn_guardar_editorial.Name = "btn_guardar_editorial";
            this.btn_guardar_editorial.Size = new System.Drawing.Size(163, 35);
            this.btn_guardar_editorial.TabIndex = 25;
            this.btn_guardar_editorial.Text = "Guardar";
            this.btn_guardar_editorial.UseVisualStyleBackColor = false;
            this.btn_guardar_editorial.Click += new System.EventHandler(this.btn_guardar_editorial_Click);
            // 
            // dgv_generos
            // 
            this.dgv_generos.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_generos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_generos.Location = new System.Drawing.Point(180, 55);
            this.dgv_generos.Name = "dgv_generos";
            this.dgv_generos.Size = new System.Drawing.Size(491, 339);
            this.dgv_generos.TabIndex = 27;
            this.dgv_generos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_generos_CellClick);
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
            // agregargenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(692, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_guardar_editorial);
            this.Controls.Add(this.dgv_generos);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregargenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregargenero";
            this.Load += new System.EventHandler(this.agregargenero_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_generos)).EndInit();
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
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_guardar_editorial;
        private System.Windows.Forms.DataGridView dgv_generos;
    }
}