
namespace Proyecto_Warescape
{
    partial class editoriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editoriales));
            this.txt_rut = new System.Windows.Forms.TextBox();
            this.dgv_editoriales = new System.Windows.Forms.DataGridView();
            this.btn_guardar_editorial = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_editoriales)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_rut
            // 
            this.txt_rut.Location = new System.Drawing.Point(13, 141);
            this.txt_rut.Name = "txt_rut";
            this.txt_rut.Size = new System.Drawing.Size(162, 20);
            this.txt_rut.TabIndex = 2;
            this.txt_rut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rut_KeyPress);
            // 
            // dgv_editoriales
            // 
            this.dgv_editoriales.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgv_editoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_editoriales.Location = new System.Drawing.Point(180, 54);
            this.dgv_editoriales.Name = "dgv_editoriales";
            this.dgv_editoriales.Size = new System.Drawing.Size(491, 339);
            this.dgv_editoriales.TabIndex = 5;
            this.dgv_editoriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_editoriales_CellClick);
            // 
            // btn_guardar_editorial
            // 
            this.btn_guardar_editorial.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar_editorial.FlatAppearance.BorderSize = 0;
            this.btn_guardar_editorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_guardar_editorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_editorial.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_editorial.ForeColor = System.Drawing.Color.Black;
            this.btn_guardar_editorial.Location = new System.Drawing.Point(12, 198);
            this.btn_guardar_editorial.Name = "btn_guardar_editorial";
            this.btn_guardar_editorial.Size = new System.Drawing.Size(163, 35);
            this.btn_guardar_editorial.TabIndex = 3;
            this.btn_guardar_editorial.Text = "Guardar";
            this.btn_guardar_editorial.UseVisualStyleBackColor = false;
            this.btn_guardar_editorial.Click += new System.EventHandler(this.btn_guardar_editorial_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(12, 81);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(162, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.Nombre.Location = new System.Drawing.Point(12, 54);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(75, 24);
            this.Nombre.TabIndex = 19;
            this.Nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Rut";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 27);
            this.panel1.TabIndex = 21;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(653, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(40, 27);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 27;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(12, 248);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(162, 35);
            this.button7.TabIndex = 4;
            this.button7.Text = "Borrar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label1.Location = new System.Drawing.Point(176, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Editoriales";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // editoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(692, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_guardar_editorial);
            this.Controls.Add(this.dgv_editoriales);
            this.Controls.Add(this.txt_rut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editoriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editoriales";
            this.Load += new System.EventHandler(this.Editoriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_editoriales)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_rut;
        private System.Windows.Forms.DataGridView dgv_editoriales;
        private System.Windows.Forms.Button btn_guardar_editorial;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
    }
}