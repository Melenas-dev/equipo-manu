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
            MySqlCommand generos = new MySqlCommand("SELECT * from generos;", con);
            con.Open();
            MySqlDataReader registro = generos.ExecuteReader();
            while (registro.Read())
            {
                Generos gen = new Generos();
                gen.descripcion = registro["descripcion"].ToString();
                gen.id_genero = int.Parse(registro["id_genero"].ToString()); 

                Cmb_genero.Items.Add(gen);
            }
            con.Close();
            //muestra en el combobox generos
            //actualizar_dgv_libros();
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
            


        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            

        }

      

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            

        }

      
        
        private void ingresar_libro(object sender, EventArgs e)
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
                    string ingreso = "insert into libros values(" + int.Parse(txt_isbn.Text) + "," + int.Parse(txt_codigo.Text) + "," + int.Parse(txt_precio.Text) + "," + int.Parse(txt_stock.Text) + ",'" + txt_nombre.Text + "')";
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

                    
                   
                    for(int i = 0; i < dgv_generos.Rows.Count - 1; i++)
                    {
                        int id_genero = int.Parse(dgv_generos.Rows[i].Cells[1].Value.ToString());
                        int isbn = int.Parse(txt_isbn.Text);

                        con.Open();
                        string ingreso2 = "insert into tienen values(" + isbn + "," + id_genero + ")";
                        MySqlCommand ingresargenero = new MySqlCommand(ingreso2, con);
                        ingresargenero.ExecuteNonQuery();
                        con.Close();
                    }

                    actualizar_dgv_libros();
                    txt_isbn.Text = "";
                    txt_codigo.Text = "";
                    txt_nombre.Text = "";
                    txt_precio.Text = "";
                    txt_stock.Text = "";
                    Cmb_genero.Text = "";
                    dgv_generos.Rows.Clear();
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
                Services.LibrosService.eliminarLibro(con, int.Parse(txt_isbn.Text));
                actualizar_dgv_libros();
                txt_isbn.Text = "";

                dgv_generos.Rows.Clear();
            }
            con.Close();


        }

        private void guardar_edicion(object sender, EventArgs e)
        {
            con.Open();
            if (txt_isbn.Text.Equals("") || txt_codigo.Text.Equals("") || txt_nombre.Text.Equals("") || txt_precio.Text.Equals("") || txt_stock.Text.Equals(""))
            {
                MessageBox.Show("Ingresar todos los parametros");
            }
            else
            {
                string editar = "UPDATE libros SET isbn=" + int.Parse(txt_isbn.Text) + ",codigo=" + int.Parse(txt_codigo.Text) + ",precio=" + int.Parse(txt_precio.Text) + ",stock=" + int.Parse(txt_stock.Text) + ",nombre='" + txt_nombre.Text + "' Where isbn=" + int.Parse(txt_isbn.Text) + ";";
                MySqlCommand comando = new MySqlCommand(editar, con);
                comando.ExecuteNonQuery();

                Services.LibrosService.eliminarGenerosDelLibro(con, int.Parse(txt_isbn.Text));

                for (int i = 0; i < dgv_generos.Rows.Count - 1; i++)
                {
                    int id_genero = int.Parse(dgv_generos.Rows[i].Cells[1].Value.ToString());
                    int isbn = int.Parse(txt_isbn.Text);

                    string ingreso2 = "insert into tienen values(" + isbn + "," + id_genero + ")";
                    MySqlCommand ingresargenero = new MySqlCommand(ingreso2, con);
                    ingresargenero.ExecuteNonQuery();
                }

                actualizar_dgv_libros();
                txt_isbn.Text = "";
                txt_codigo.Text = "";
                txt_nombre.Text = "";
                txt_precio.Text = "";
                txt_stock.Text = "";
                Cmb_genero.Text = "";
                cmb_editorial.Text = "";
                dgv_generos.Rows.Clear();
            }
            con.Close();
            
        }



        private void dgv_libros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                
                txt_isbn.Text = this.dgv_libros.CurrentRow.Cells[0].Value.ToString();
                txt_codigo.Text = this.dgv_libros.CurrentRow.Cells[1].Value.ToString();
                txt_precio.Text = this.dgv_libros.CurrentRow.Cells[2].Value.ToString();
                txt_stock.Text = this.dgv_libros.CurrentRow.Cells[3].Value.ToString();
                txt_nombre.Text = this.dgv_libros.CurrentRow.Cells[4].Value.ToString();
                cmb_editorial.Text = this.dgv_libros.CurrentRow.Cells[6].Value.ToString();
                if (dgv_libros.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    int isbn = int.Parse(dgv_libros.CurrentRow.Cells[0].Value.ToString());
                con.Open();
                string query_generos = "SELECT g.id_genero, descripcion from tienen t JOIN generos g on t.id_genero = g.id_genero where isbn = " + isbn + ";";
                MySqlCommand cmmnd_generos = new MySqlCommand(query_generos, con);

                dgv_generos.Rows.Clear();

                MySqlDataReader generos_del_libro = cmmnd_generos.ExecuteReader();
                while (generos_del_libro.Read())
                {
                    Generos gen = new Generos();
                    gen.descripcion = generos_del_libro["descripcion"].ToString();
                    gen.id_genero = int.Parse(generos_del_libro["id_genero"].ToString());

                    dgv_generos.Rows.Add(gen.descripcion, gen.id_genero);
                }
                con.Close();
                }else
                {
                    MessageBox.Show("Ingrese una fila valida");
                }

            }
            
        }
        public void actualizar_dgv_libros()
        {
            MySqlCommand mostrar = new MySqlCommand("SELECT l.*, e.nombre Editorial, ( SELECT g.descripcion FROM tienen t JOIN generos g ON g.id_genero = t.id_genero " +
                " WHERE t.isbn = l.isbn LIMIT 1 ) 'Primer genero del libro' FROM libros l JOIN vende_o_consigna v on v.isbn = l.isbn JOIN editoriales e on e.rut = v.rut", con);
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

        private void txt_isbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_libros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Cmb_genero.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un genero");
                return;
            }

            for (int i = 0; i < dgv_generos.Rows.Count - 1; i++)
            {
                int id_genero = int.Parse(dgv_generos.Rows[i].Cells[1].Value.ToString());

                if (id_genero == (Cmb_genero.SelectedItem as Generos).id_genero)
                {
                    MessageBox.Show("El genero ya esta ingresado");
                    return;
                }
            }

            dgv_generos.Rows.Add(Cmb_genero.Text, ((Cmb_genero.SelectedItem as Generos).id_genero).ToString());
        }

        private void dgv_generos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cmb_genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_devoluciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_devoluciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form editoriales = new editoriales();
            editoriales.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form generos = new agregargenero();
            generos.Show();
        }
    }
    
}
