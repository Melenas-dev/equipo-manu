
namespace Proyecto_Warescape
{
    partial class FormEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmail));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_receptor = new System.Windows.Forms.TextBox();
            this.txt_pass2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pass1 = new System.Windows.Forms.TextBox();
            this.cmb_usuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.pnl_cambiar_pass = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.pnl_cambiar_pass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese un gmail";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_receptor
            // 
            this.txt_receptor.Location = new System.Drawing.Point(27, 84);
            this.txt_receptor.Name = "txt_receptor";
            this.txt_receptor.Size = new System.Drawing.Size(192, 20);
            this.txt_receptor.TabIndex = 4;
            // 
            // txt_pass2
            // 
            this.txt_pass2.Location = new System.Drawing.Point(239, 188);
            this.txt_pass2.Name = "txt_pass2";
            this.txt_pass2.Size = new System.Drawing.Size(124, 20);
            this.txt_pass2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingrese nuevamente la contraseña";
            // 
            // txt_pass1
            // 
            this.txt_pass1.Location = new System.Drawing.Point(239, 117);
            this.txt_pass1.Name = "txt_pass1";
            this.txt_pass1.Size = new System.Drawing.Size(124, 20);
            this.txt_pass1.TabIndex = 3;
            this.txt_pass1.TextChanged += new System.EventHandler(this.txt_pass1_TextChanged);
            // 
            // cmb_usuario
            // 
            this.cmb_usuario.FormattingEnabled = true;
            this.cmb_usuario.Items.AddRange(new object[] {
            "Gerente",
            "Empleado"});
            this.cmb_usuario.Location = new System.Drawing.Point(239, 54);
            this.cmb_usuario.Name = "cmb_usuario";
            this.cmb_usuario.Size = new System.Drawing.Size(124, 21);
            this.cmb_usuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seleccione el usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la nueva contraseña";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F);
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(266, 242);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(126, 35);
            this.btn_Guardar.TabIndex = 17;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(239, 84);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_enviar.TabIndex = 8;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // pnl_cambiar_pass
            // 
            this.pnl_cambiar_pass.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_cambiar_pass.Controls.Add(this.BtnCerrar);
            this.pnl_cambiar_pass.Controls.Add(this.btn_Guardar);
            this.pnl_cambiar_pass.Controls.Add(this.label1);
            this.pnl_cambiar_pass.Controls.Add(this.txt_pass2);
            this.pnl_cambiar_pass.Controls.Add(this.label3);
            this.pnl_cambiar_pass.Controls.Add(this.label4);
            this.pnl_cambiar_pass.Controls.Add(this.cmb_usuario);
            this.pnl_cambiar_pass.Controls.Add(this.txt_pass1);
            this.pnl_cambiar_pass.Location = new System.Drawing.Point(0, -2);
            this.pnl_cambiar_pass.Name = "pnl_cambiar_pass";
            this.pnl_cambiar_pass.Size = new System.Drawing.Size(415, 299);
            this.pnl_cambiar_pass.TabIndex = 9;
            this.pnl_cambiar_pass.Visible = false;
            this.pnl_cambiar_pass.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_cambiar_pass_Paint_1);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(363, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(46, 43);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 27;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FormEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(414, 296);
            this.Controls.Add(this.pnl_cambiar_pass);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_receptor);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmail";
            this.pnl_cambiar_pass.ResumeLayout(false);
            this.pnl_cambiar_pass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_receptor;
        private System.Windows.Forms.TextBox txt_pass2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pass1;
        private System.Windows.Forms.ComboBox cmb_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Panel pnl_cambiar_pass;
        private System.Windows.Forms.PictureBox BtnCerrar;
    }
}