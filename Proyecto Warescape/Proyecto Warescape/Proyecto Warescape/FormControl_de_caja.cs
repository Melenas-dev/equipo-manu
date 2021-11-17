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
    public partial class FormControl_de_caja : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=warescapesrl; Uid=Admin; Pwd=warescape;");
        public FormControl_de_caja()
        {
            InitializeComponent();
        }
  
        private void button7_Click(object sender, EventArgs e)
        {
            if (cmb_año.Text.Equals("") || cmb_mes.Text.Equals(""))
            {
                MessageBox.Show("ingrese mes y año para motrar la caja");
            }
            else
            {
                DataTable tabla = new DataTable();
                string comand = "select v.n_de_boleta 'N de boleta         ', v.fecha_de_venta 'Fecha', v.monto 'Monto', g.precio 'Precio', g.cantidad_vendida 'Cantidad comprada', l.nombre 'Nombre' from ventas v join generan g on v.n_de_boleta=g.n_de_boleta join libros l on l.id_libro=g.id_libro where year(fecha_de_venta)=" + cmb_año.Text + " and month(fecha_de_venta)=" + cmb_mes.SelectedItem.ToString() + "; ";
                con.Open();
                MySqlDataAdapter comando_ventas = new MySqlDataAdapter(comand, con);
                comando_ventas.Fill(tabla);
                dgv_ventas.DataSource = tabla;
                con.Close();
                con.Open();
                string monto = "select sum(monto) from ventas where year(fecha_de_venta)=" + cmb_año.Text + " and month(fecha_de_venta)=" + cmb_mes.SelectedItem.ToString() + "; ";
                MySqlCommand mos_monto = new MySqlCommand(monto, con);
                MySqlDataReader leer_monto = mos_monto.ExecuteReader();
                while (leer_monto.Read())
                {
                    lbl_monto.Text = leer_monto["sum(monto)"].ToString();
                }

                con.Close();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tb_año_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void control_de_caja_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand obtener_año = new MySqlCommand("select year(fecha_de_venta) from ventas group by year(fecha_de_venta);", con);
            MySqlDataReader reader = obtener_año.ExecuteReader();
            while (reader.Read())
            {
                cmb_año.Items.Add(reader["year(fecha_de_venta)"]);
            }
            con.Close();
        }

        private void btnmaximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
  

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void control_de_caja_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void cmb_año_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_mes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
