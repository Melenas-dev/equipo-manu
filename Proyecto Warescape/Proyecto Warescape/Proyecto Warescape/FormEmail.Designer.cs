
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_receptor = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.pnl_cambiar_pass = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_usuario = new System.Windows.Forms.ComboBox();
            this.txt_pass1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pass2 = new System.Windows.Forms.TextBox();
            this.btn_cambiar = new System.Windows.Forms.Button();
            this.pnl_cambiar_pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receptor";
            // 
            // txt_receptor
            // 
            this.txt_receptor.Location = new System.Drawing.Point(34, 189);
            this.txt_receptor.Name = "txt_receptor";
            this.txt_receptor.Size = new System.Drawing.Size(138, 20);
            this.txt_receptor.TabIndex = 4;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(242, 133);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(138, 23);
            this.btn_enviar.TabIndex = 6;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // pnl_cambiar_pass
            // 
            this.pnl_cambiar_pass.Controls.Add(this.btn_cambiar);
            this.pnl_cambiar_pass.Controls.Add(this.txt_pass2);
            this.pnl_cambiar_pass.Controls.Add(this.label4);
            this.pnl_cambiar_pass.Controls.Add(this.txt_pass1);
            this.pnl_cambiar_pass.Controls.Add(this.cmb_usuario);
            this.pnl_cambiar_pass.Controls.Add(this.label3);
            this.pnl_cambiar_pass.Controls.Add(this.label1);
            this.pnl_cambiar_pass.Location = new System.Drawing.Point(1, 1);
            this.pnl_cambiar_pass.Name = "pnl_cambiar_pass";
            this.pnl_cambiar_pass.Size = new System.Drawing.Size(413, 289);
            this.pnl_cambiar_pass.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la nueva contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seleccione el usuario";
            // 
            // cmb_usuario
            // 
            this.cmb_usuario.FormattingEnabled = true;
            this.cmb_usuario.Items.AddRange(new object[] {
            "Gerente",
            "Empleado"});
            this.cmb_usuario.Location = new System.Drawing.Point(23, 124);
            this.cmb_usuario.Name = "cmb_usuario";
            this.cmb_usuario.Size = new System.Drawing.Size(121, 21);
            this.cmb_usuario.TabIndex = 2;
            // 
            // txt_pass1
            // 
            this.txt_pass1.Location = new System.Drawing.Point(236, 93);
            this.txt_pass1.Name = "txt_pass1";
            this.txt_pass1.Size = new System.Drawing.Size(121, 20);
            this.txt_pass1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingrese nuevamente la contraseña";
            // 
            // txt_pass2
            // 
            this.txt_pass2.Location = new System.Drawing.Point(236, 159);
            this.txt_pass2.Name = "txt_pass2";
            this.txt_pass2.Size = new System.Drawing.Size(121, 20);
            this.txt_pass2.TabIndex = 5;
            // 
            // btn_cambiar
            // 
            this.btn_cambiar.Location = new System.Drawing.Point(261, 215);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(75, 23);
            this.btn_cambiar.TabIndex = 6;
            this.btn_cambiar.Text = "Cambiar";
            this.btn_cambiar.UseVisualStyleBackColor = true;
            this.btn_cambiar.Click += new System.EventHandler(this.btn_cambiar_Click);
            // 
            // FormEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 288);
            this.Controls.Add(this.pnl_cambiar_pass);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_receptor);
            this.Controls.Add(this.label2);
            this.Name = "FormEmail";
            this.Text = "FormEmail";
            this.pnl_cambiar_pass.ResumeLayout(false);
            this.pnl_cambiar_pass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_receptor;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Panel pnl_cambiar_pass;
        private System.Windows.Forms.Button btn_cambiar;
        private System.Windows.Forms.TextBox txt_pass2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pass1;
        private System.Windows.Forms.ComboBox cmb_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}