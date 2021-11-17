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
    public partial class agregargenero : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=warescapesrl; Uid=root; Pwd=;");
        public agregargenero()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_editorial_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese datos validos");
            }
            else
            {
                con.Open();
                MySqlCommand comparar = new MySqlCommand("select descripcion from generos where  descripcion= '" + txt_nombre.Text + "';", con);
                MySqlDataReader reader = comparar.ExecuteReader();
                string a;
                string b = "";
                while (reader.Read())
                {
                    a = reader["descripcion"].ToString();
                    if (txt_nombre.Text.Equals(a))
                    {
                        b = "iguales";
                    }

                }
                con.Close();
                if (b.Equals("iguales"))
                {
                    MessageBox.Show("No se puede ingresar dos generos iguales");
                }

                else
                {
                    con.Open();
                    MySqlCommand ingresar = new MySqlCommand("insert into generos(descripcion) values('" + txt_nombre.Text + "');", con);
                    ingresar.ExecuteNonQuery();
                    actualizar_generos();
                    con.Close();
                    
                }
                txt_nombre.Text = "";
            }
        }
        public void actualizar_generos()
        {
            MySqlCommand mostrar = new MySqlCommand("select descripcion 'Descripcion' from generos", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgv_generos.DataSource = tabla;
        }

        private void agregargenero_Load(object sender, EventArgs e)
        {
            actualizar_generos();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!txt_nombre.Text.Equals("")) {
                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el genero?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand borrar = new MySqlCommand("DELETE from generos where descripcion= '" + txt_nombre.Text + "'  ", con);
                    borrar.ExecuteNonQuery();
                    actualizar_generos();
                    con.Close();
                    txt_nombre.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Seleccione un genero");
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void agregargenero_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void dgv_generos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_generos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {

                txt_nombre.Text = this.dgv_generos.CurrentRow.Cells[0].Value.ToString();

            }
        }
    }
}
