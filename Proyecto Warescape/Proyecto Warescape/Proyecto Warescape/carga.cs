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
    public partial class carga : Form
    {
        public carga()
        {
            InitializeComponent();
        }
        int comienzo = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            comienzo += 4;
            progreso.Value = comienzo;
            lblporcentaje.Text = comienzo + "%";
            if (progreso.Value == 100)
            {

                progreso.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
              
                

            }
        }

        private void carga_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
