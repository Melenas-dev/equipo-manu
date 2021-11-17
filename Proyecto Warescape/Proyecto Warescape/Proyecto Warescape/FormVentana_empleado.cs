using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Warescape
{
    public partial class FormVentana_empleado : Form
    {
        public FormVentana_empleado()
        {
            InitializeComponent();
        }
        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new VentanasPrincipal());
            pnl_cerrar.BackColor = Color.DarkGray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormFinanzas());
            pnl_cerrar.BackColor = Color.DarkGray;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ventana_login = new Login();
            ventana_login.Show();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
