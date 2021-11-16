using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace Proyecto_Warescape
{
    public partial class graficas : Form

    {

        MySqlConnection con = new MySqlConnection("Server=localhost; Database=warescapesrl; Uid=root; Pwd=;");


        public graficas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void graficas_Load(object sender, EventArgs e)
        {

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            chartpublicidades.Series["Publicitado"].Points.Clear();
            // select id_publicidad,count(id_publicidad) from se_registran group by id_publicidad;

            con.Open();

            string conveniencia = "select nombre,count(s.id_publicidad)'cantidad' from se_registran s join publicidad p on s.id_publicidad = p.id_publicidad group by s.id_publicidad;";
            MySqlCommand publi = new MySqlCommand(conveniencia, con);
            MySqlDataReader reader = publi.ExecuteReader();

            while (reader.Read())
            {
                chartpublicidades.Series["Publicitado"].Points.AddXY(reader.GetString("nombre"), reader.GetInt32("cantidad"));
            }

            con.Close();
                






        }

        private void chartpublicidades_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }
    }
}
