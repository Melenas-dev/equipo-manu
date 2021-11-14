using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Warescape
{
    public partial class finanzas : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=warescapesrl; Uid=root; Pwd=;");


        public finanzas()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panelfinanzas_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
            Form finanzas = new finanzas();
            finanzas.Show();

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanasPrincipal ventanas = new VentanasPrincipal();
            ventanas.Show();

        }

        private void finanzas_Load(object sender, EventArgs e)
        {
            MySqlCommand comando_marketing = new MySqlCommand("SELECT nombre from publicidad", con);
            con.Open();
            MySqlDataReader registro_marketing = comando_marketing.ExecuteReader();
            while (registro_marketing.Read())
            {
                cmb_publicidad.Items.Add(registro_marketing["nombre"].ToString());

            }
            con.Close();


            MySqlCommand comando = new MySqlCommand("SELECT nombre from libros", con);
            con.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cmb_libros.Items.Add(registro["nombre"].ToString());

            }
            con.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            if (txt_boleta.Text.Equals("") || txt_precio.Text.Equals("") || txt_cantidad.Text.Equals("") || cmb_libros.Text.Equals(""))
            {
                MessageBox.Show("Ingresar todos los parametros");
            }
            else
            {
                int n = dgv_lista.Rows.Add();

                dgv_lista.Rows[n].Cells[0].Value = txt_boleta.Text;
                dgv_lista.Rows[n].Cells[1].Value = fecha_venta.Value.ToString("yyyy-MM-dd");
                dgv_lista.Rows[n].Cells[2].Value = txt_precio.Text;
                dgv_lista.Rows[n].Cells[3].Value = txt_cantidad.Text;
                dgv_lista.Rows[n].Cells[4].Value = cmb_libros.SelectedItem.ToString();
                if (!cmb_publicidad.Text.Equals("")) 
                { 
                dgv_lista.Rows[n].Cells[5].Value = cmb_publicidad.SelectedItem.ToString();
                }

            }
            txt_boleta.Text = "";
            txt_precio.Text = "";
            txt_cantidad.Text = "";
            cmb_libros.Text = "";
            cmb_publicidad.Text = "";


        }

        private void Registrar_ventra_Click(object sender, EventArgs e)
        {
            if (dgv_lista.Rows.Count == 0)
            {
                MessageBox.Show("Agrege una venta");
            }
            else
            {

            }
        }

        private void dgv_lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                dgv_lista.Rows.RemoveAt(n);
            }

        }
    }
    }

