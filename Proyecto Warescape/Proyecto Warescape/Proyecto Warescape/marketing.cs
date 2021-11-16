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
    public partial class marketing : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=warescapesrl; Uid=root; Pwd=;");
        public marketing()
        {
            InitializeComponent();
        }

        private void marketing_Load(object sender, EventArgs e)
        {
            mostrar_publicidades();


        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)

        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();

            txt_monto.Text = txt_monto.Text.Replace(" ", string.Empty);
            txt_rut.Text = txt_rut.Text.Replace(" ", string.Empty);

            if (txt_rut.Text.Equals("") || txt_monto.Text.Equals("") || txt_nombre.Text.Equals(""))
            {
                MessageBox.Show("Ingresar todos los parametros");
                con.Close();
                return;
            }
            if (txt_nombre.Text.Trim().Equals(" "))
            {
                MessageBox.Show("verificar espacios");
                con.Close();
                return;
            }
            else
            {
                string ingreso_publicidad = "insert into publicidad(rut, monto, nombre) values(" + int.Parse(txt_rut.Text) + ", " + int.Parse(txt_monto.Text.Trim()) + ",'" + txt_nombre.Text.Trim() + "');";
                MySqlCommand Ingreso = new MySqlCommand(ingreso_publicidad, con);
                Ingreso.ExecuteNonQuery();
                con.Close();
                mostrar_publicidades();


            }




        }
        public void mostrar_publicidades()
        {

            MySqlCommand mostrar = new MySqlCommand("Select id_publicidad ID,rut RUT,nombre Nombre,monto Monto from publicidad;", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgv_publicidades.DataSource = tabla;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            con.Open();

            txt_monto.Text = txt_monto.Text.Replace(" ", string.Empty);
            txt_rut.Text = txt_rut.Text.Replace(" ", string.Empty);
            

            if (txt_rut.Text.Equals("") || lbl_id_publicidad.Text.Equals("") || txt_monto.Text.Equals("") || txt_nombre.Text.Equals(""))
            {
                MessageBox.Show("Ingresar todos los parametros");
                
            }
            if (txt_nombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Verificar espacios");
            }
            else
            {

                string editar = "UPDATE publicidad set rut=" + int.Parse(txt_rut.Text) + ", monto=" + float.Parse(txt_monto.Text) + ",nombre='" + txt_nombre.Text.Trim() + "' where id_publicidad =" + int.Parse(lbl_id_publicidad.Text) + ";";
                MySqlCommand comando = new MySqlCommand(editar, con);
                comando.ExecuteNonQuery();
                mostrar_publicidades();
                lbl_id_publicidad.Text = "";
                txt_rut.Text = "";
                txt_nombre.Text = "";
                txt_monto.Text = "";

            }
            con.Close();

        }

        private void dgv_publicidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                lbl_id_publicidad.Text = this.dgv_publicidades.CurrentRow.Cells[0].Value.ToString();
                txt_monto.Text = this.dgv_publicidades.CurrentRow.Cells[3].Value.ToString();
                txt_rut.Text = this.dgv_publicidades.CurrentRow.Cells[1].Value.ToString();
                txt_nombre.Text = this.dgv_publicidades.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            if (lbl_id_publicidad.Text.Equals(""))
            {
                MessageBox.Show("seleccione un marketing");
            }
            else
            {
                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar la marketing?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    string borrar = "DELETE FROM publicidad WHERE id_publicidad =" + int.Parse(lbl_id_publicidad.Text) + ";";
                    MySqlCommand comando = new MySqlCommand(borrar, con);
                    comando.ExecuteNonQuery();
                    mostrar_publicidades();
                    lbl_id_publicidad.Text = "";
                    txt_rut.Text = "";
                    txt_nombre.Text = "";
                    txt_monto.Text = "";
                }

            }
            con.Close();

        }
        public void solo_numeros(KeyPressEventArgs e)
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

        private void txt_rut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }

        private void txt_alcance_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_monto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnmaximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        public void solo_letras(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }

        }
    }
}

