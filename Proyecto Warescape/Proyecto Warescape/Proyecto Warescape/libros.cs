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
using System.Runtime.InteropServices;

namespace Proyecto_Warescape
{
    public partial class VentanasPrincipal : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=warescapesrl; Uid=root; Pwd=;");
        
        public VentanasPrincipal()
        {
          
            InitializeComponent();
        }

        private void VentanasPrincipal_Load(object sender, EventArgs e)
        {
            MySqlCommand generos = new MySqlCommand("SELECT descripcion from generos;", con);
            con.Open();
            MySqlDataReader registro = generos.ExecuteReader();
            while (registro.Read())
            {
                Cmb_genero.Items.Add(registro["descripcion"].ToString());
            }
            con.Close();
            //muestra en el combobox generos
            actualizar_dgv_libros();
            con.Close();
            dgv_libros.ReadOnly = true;
            //muestra en el datagridview 

            con.Open();
            MySqlCommand editoriales = new MySqlCommand("SELECT nombre from editoriales", con);
            MySqlDataReader leer = editoriales.ExecuteReader();
            while (leer.Read())
            {
                cmb_editorial.Items.Add(leer["nombre"].ToString());
                
            }con.Close();





            
            









        }

      
      

        private void txbautor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar <=64)|| e.KeyChar >= 91 && e.KeyChar <= 96 || (e.KeyChar >=123 && e.KeyChar <=255))
            {
                MessageBox.Show("Este campo solo acepta letras", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;


            }
        }

       

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnRestaurar.Visible = true;


        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnmaximizar.Visible = true;

        }

      

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnmaximizar.Visible = true;

        }

      
        
        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txt_isbn.Text.Equals("") || txt_codigo.Text.Equals("") || txt_nombre.Text.Equals("") || txt_precio.Text.Equals("") || txt_stock.Text.Equals("") || Cmb_genero.Text.Equals("") || cmb_editorial.Text.Equals("")) 
            {
                MessageBox.Show("Ingresar todos los parametros");
            }
            else
            {
                
                MySqlCommand comparar = new MySqlCommand("select isbn from libros where  isbn= " + txt_isbn.Text + ";", con);
                MySqlDataReader reader = comparar.ExecuteReader();
                string a;
                string b="";
                while (reader.Read())
                {
                   a = reader["isbn"].ToString();
                    if (txt_isbn.Text.Equals(a))
                    {
                        b = "iguales";
                    }
                }
                if (b.Equals("iguales"))
                {
                    MessageBox.Show("No puedes tener dos ISBN iguales");
                }
                else
                {
                    con.Close();

                    con.Open();
                    if(!txt_devoluciones.Text.Equals("No obligatorio"))
                    {


                    }
                    else
                    {
                        txt_devoluciones.Text = "0";
                    }
                    string ingreso = "insert into libros values(" + int.Parse(txt_isbn.Text) + "," + int.Parse(txt_codigo.Text) + "," + int.Parse(txt_precio.Text) + "," + int.Parse(txt_stock.Text) + ",'" + txt_nombre.Text + "'," + int.Parse(txt_devoluciones.Text) + ")";
                    MySqlCommand Ingreso = new MySqlCommand(ingreso, con);
                    Ingreso.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    MySqlCommand ingresar_editorial = new MySqlCommand("select * from editoriales where nombre='" + cmb_editorial.Text + "';", con);
                    MySqlDataReader reador = ingresar_editorial.ExecuteReader();
                    string valor2 = "";
                    while (reador.Read())
                    {
                        valor2 = reador["rut"].ToString();
                      
                    }
                    con.Close();
                    con.Open();
                    MySqlCommand vender_consignar = new MySqlCommand("insert into vende_o_consigna values(" + valor2 + "," + int.Parse(txt_isbn.Text) + ");",con);
                    vender_consignar.ExecuteNonQuery();
                    con.Close();
                    con.Open();


                    string almacenar = Cmb_genero.Text;
                    MySqlCommand comando = new MySqlCommand("Select * from generos where descripcion ='" + almacenar + "';", con);
                    MySqlDataReader leertabla = comando.ExecuteReader();
                    string valor = "";
                    while (leertabla.Read())
                    {
                        valor = leertabla["id_genero"].ToString();
                    }
                    con.Close();
                    con.Open();
                    string ingreso2 = "insert into tienen values("+ int.Parse(txt_isbn.Text) +","+ int.Parse(valor) +")";
                    MySqlCommand ingresargenero = new MySqlCommand(ingreso2,con);
                    ingresargenero.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    actualizar_dgv_libros();
                    txt_isbn.Text = "";
                    txt_codigo.Text = "";
                    txt_nombre.Text = "";
                    txt_precio.Text = "";
                    txt_stock.Text = "";
                    Cmb_genero.Text = "";
                }
            
        }
            con.Close();

        }

      

       

      

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();          
            if (txt_isbn.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un ISBN Para borrar un libro");
            }
            else
            {


                string borrar = "DELETE FROM libros WHERE isbn =" + int.Parse(txt_isbn.Text) + ";";
                MySqlCommand comando = new MySqlCommand(borrar, con);
                comando.ExecuteNonQuery();
                actualizar_dgv_libros();
                txt_isbn.Text = "";
            }
            con.Close();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txt_isbn.Text.Equals("") || txt_codigo.Text.Equals("") || txt_nombre.Text.Equals("") || txt_precio.Text.Equals("") || txt_stock.Text.Equals("") || Cmb_genero.Text.Equals(""))
            {
                MessageBox.Show("Ingresar todos los parametros");
            }
            else
            {
                string editar = "UPDATE libros SET isbn=" + int.Parse(txt_isbn.Text) + ",codigo=" + int.Parse(txt_codigo.Text) + ",precio=" + int.Parse(txt_precio.Text) + ",stock=" + int.Parse(txt_stock.Text) + ",nombre='" + txt_nombre.Text + "' Where isbn=" + int.Parse(txt_isbn.Text) + ";";
                MySqlCommand comando = new MySqlCommand(editar, con);
                comando.ExecuteNonQuery();
                actualizar_dgv_libros();
                txt_isbn.Text = "";
                txt_codigo.Text = "";
                txt_nombre.Text = "";
                txt_precio.Text = "";
                txt_stock.Text = "";
                Cmb_genero.Text = "";
            }
            con.Close();
            
        }

       

        private void dgv_libros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                txt_isbn.Text = this.dgv_libros.CurrentRow.Cells[0].Value.ToString();
            }
            
        }
        public void actualizar_dgv_libros()
        {
           
            MySqlCommand mostrar = new MySqlCommand("Select l.*, e.nombre "+" editorial"+", g.descripcion "+"Genero"+"  from editoriales e join vende_o_consigna v on e.rut=v.rut join libros l on l.isbn=v.isbn join tienen t on l.isbn=t.isbn join generos g on g.id_genero=t.id_genero where g.id_genero=t.id_genero and e.rut=v.rut;", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgv_libros.DataSource = tabla;
            
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

      

        private void txt_isbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }

        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form marketing_ir = new marketing();
            marketing_ir.Show();
            this.Hide();
        }

       

        private void Cmb_genero_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            finanzas finanzas = new finanzas();
            finanzas.Show();
        }

        private void dgv_libros_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }

           

            
        }

       
    }
    
}
