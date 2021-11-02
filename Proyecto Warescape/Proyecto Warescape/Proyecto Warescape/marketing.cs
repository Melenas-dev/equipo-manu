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
            if (txt_rut.Text.Equals("") || txt_id.Text.Equals("") || txt_alcance.Text.Equals("") || txt_nombre.Text.Equals(""))
            {
                MessageBox.Show("Ingresar todos los parametros");
            }

            else
            {
                string ingreso_publicidad = "insert into publicidades values(" + int.Parse(txt_rut.Text) + "," + int.Parse(txt_id.Text) + "," + int.Parse(txt_alcance.Text) + ",'" + txt_nombre.Text + "');";
                MySqlCommand Ingreso = new MySqlCommand(ingreso_publicidad, con);
                Ingreso.ExecuteNonQuery();
                con.Close();
                mostrar_publicidades();


            }




        }
        public void mostrar_publicidades()
        {

            MySqlCommand mostrar = new MySqlCommand("Select id,rut,nombre,alcance_de_personas from publicidades;", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgv_publicidades.DataSource = tabla;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            con.Open();
            if (txt_rut.Text.Equals("") || txt_id.Text.Equals("") || txt_alcance.Text.Equals("") || txt_nombre.Text.Equals(""))
            {
                MessageBox.Show("Ingresar todos los parametros");
            }
            else
            {

                string editar = "UPDATE publicidades set rut=" + int.Parse(txt_rut.Text) + ",id="  + int.Parse(txt_id.Text) + ",alcance_de_personas=" + int.Parse(txt_alcance.Text) + ",nombre='" + txt_nombre.Text + "' where id ="+int.Parse(txt_id.Text)+";";
                MySqlCommand comando = new MySqlCommand(editar, con);
                comando.ExecuteNonQuery();
                mostrar_publicidades();
                txt_id.Text = "";
                txt_rut.Text = "";
                txt_nombre.Text = "";
                txt_alcance.Text = "";
                
            }con.Close();

        }

        private void dgv_publicidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                txt_id.Text = this.dgv_publicidades.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txt_id.Text.Equals("") )
            {
                MessageBox.Show("Ingresar el id");
            }
            else
            {
                string borrar = "DELETE FROM publicidades WHERE id =" + int.Parse(txt_id.Text) + ";";
                MySqlCommand comando = new MySqlCommand(borrar, con);
                comando.ExecuteNonQuery();
                mostrar_publicidades();
                txt_id.Text = "";
            }
            
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
    }
}

