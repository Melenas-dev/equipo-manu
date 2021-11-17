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
    public partial class editoriales : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=warescapesrl; Uid=Admin; Pwd=warescape;");
        public editoriales()
        {
            InitializeComponent();
        }

        private void Editoriales_Load(object sender, EventArgs e)
        {
            con.Open();
            actualizar_editoriales();
            con.Close();
        }

        private void btn_guardar_editorial_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text.Equals("") || txt_rut.Text.Equals(""))
            {
                MessageBox.Show("Ingrese datos validos");
            }
            else
            {
                long rut = long.Parse(txt_rut.Text.Replace(" ", string.Empty));


                con.Open();
                MySqlCommand comparar = new MySqlCommand("select rut from editoriales where  rut= " + rut + ";", con); 
                MySqlDataReader reader = comparar.ExecuteReader();
                string a;
                string b = "";
                while (reader.Read())
                {
                    a = reader["rut"].ToString();
                    if (txt_rut.Text.Equals(a))
                    {
                        b = "iguales";
                    }
                    
                }
                con.Close();
                if (b.Equals("iguales"))
                {
                    MessageBox.Show("No se puede ingresar dos Rut iguales");
                }
                
                else
                {
                    con.Open();
                    MySqlCommand ingresar = new MySqlCommand("insert into editoriales(nombre,rut) values('" + txt_nombre.Text.Trim() + "'," + rut + ");", con);
                    ingresar.ExecuteNonQuery();
                    actualizar_editoriales();
                    con.Close();
                }
                txt_nombre.Text = "";
                txt_rut.Text = "";
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void actualizar_editoriales()
        {
            MySqlCommand mostrar = new MySqlCommand("select nombre'Nombre', rut'RUT' from editoriales", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgv_editoriales.DataSource = tabla;
        }

        private void dgv_editoriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {

                txt_nombre.Text = this.dgv_editoriales.CurrentRow.Cells[0].Value.ToString().Trim();
                txt_rut.Text = this.dgv_editoriales.CurrentRow.Cells[1].Value.ToString();
            }
    }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!txt_rut.Text.Equals("")) {
                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar la editorial?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand borrar = new MySqlCommand("DELETE from editoriales where rut=" + long.Parse(txt_rut.Text) + "", con);
                    borrar.ExecuteNonQuery();
                    actualizar_editoriales();
                    con.Close();
                    txt_nombre.Text = "";
                    txt_rut.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Seleccione una editorial");
            }
        }

        private void txt_rut_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Editoriales_MouseDown(object sender, MouseEventArgs e)
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
    }
}
