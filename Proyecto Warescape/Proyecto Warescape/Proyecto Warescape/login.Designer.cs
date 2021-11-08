
namespace Proyecto_Warescape
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.campo_contra = new System.Windows.Forms.TextBox();
            this.campo_usuario = new System.Windows.Forms.TextBox();
            this.ingreso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_restaurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // campo_contra
            // 
            this.campo_contra.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.campo_contra.Location = new System.Drawing.Point(426, 236);
            this.campo_contra.Name = "campo_contra";
            this.campo_contra.Size = new System.Drawing.Size(126, 31);
            this.campo_contra.TabIndex = 4;
            this.campo_contra.UseSystemPasswordChar = true;
            this.campo_contra.TextChanged += new System.EventHandler(this.campo_contra_TextChanged);
            this.campo_contra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.campo_contra_KeyDown);
            // 
            // campo_usuario
            // 
            this.campo_usuario.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.campo_usuario.Location = new System.Drawing.Point(426, 184);
            this.campo_usuario.Name = "campo_usuario";
            this.campo_usuario.Size = new System.Drawing.Size(126, 31);
            this.campo_usuario.TabIndex = 1;
            this.campo_usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.campo_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.campo_contra_KeyDown);
            // 
            // ingreso
            // 
            this.ingreso.BackColor = System.Drawing.Color.Black;
            this.ingreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingreso.BackgroundImage")));
            this.ingreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ingreso.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ingreso.FlatAppearance.BorderSize = 2;
            this.ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingreso.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingreso.ForeColor = System.Drawing.Color.Black;
            this.ingreso.Location = new System.Drawing.Point(357, 289);
            this.ingreso.Name = "ingreso";
            this.ingreso.Size = new System.Drawing.Size(119, 46);
            this.ingreso.TabIndex = 0;
            this.ingreso.Text = "Ingresar";
            this.ingreso.UseVisualStyleBackColor = false;
            this.ingreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.BackColor = System.Drawing.Color.Transparent;
            this.btn_restaurar.FlatAppearance.BorderSize = 0;
            this.btn_restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restaurar.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restaurar.ForeColor = System.Drawing.Color.Black;
            this.btn_restaurar.Location = new System.Drawing.Point(42, 314);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(196, 35);
            this.btn_restaurar.TabIndex = 17;
            this.btn_restaurar.Text = "Restaurar contraseña";
            this.btn_restaurar.UseVisualStyleBackColor = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(576, 377);
            this.Controls.Add(this.btn_restaurar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.campo_usuario);
            this.Controls.Add(this.ingreso);
            this.Controls.Add(this.campo_contra);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox campo_contra;
        private System.Windows.Forms.TextBox campo_usuario;
        private System.Windows.Forms.Button ingreso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_restaurar;
    }
}

