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
            actualizar_ventas();
            dgv_lista.ReadOnly = true;
            MySqlCommand comando_marketing = new MySqlCommand("SELECT nombre,id_publicidad from publicidad", con);
            con.Open();
            MySqlDataReader registro_marketing = comando_marketing.ExecuteReader();
            while (registro_marketing.Read())
            {
             string nombre = registro_marketing["nombre"].ToString();
                string id_de_publicidad = registro_marketing["id_publicidad"].ToString();
                cmb_publicidad.Items.Add(nombre + "-" + id_de_publicidad);


            }
            con.Close();


            MySqlCommand comando = new MySqlCommand("SELECT nombre,id_libro from libros", con);
            con.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
              string nombre =registro["nombre"].ToString();
                string id_libro = registro["id_libro"].ToString();
                cmb_libros.Items.Add(nombre + "-" + id_libro);
                



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
            if (dgv_lista.Rows.Count == 1)
            {
                MessageBox.Show("Agrege una venta");
            }
            else
            {
                for(int i=0; i<dgv_lista.Rows.Count - 1; i++)
                {
                    int n_de_boleta = int.Parse(dgv_lista.Rows[i].Cells[0].Value.ToString());
                    string fecha = dgv_lista.Rows[i].Cells[1].Value.ToString();
                    float precio = int.Parse(dgv_lista.Rows[i].Cells[2].Value.ToString());
                    int cantidad_comprada = int.Parse(dgv_lista.Rows[i].Cells[3].Value.ToString());
                    string libro = dgv_lista.Rows[i].Cells[4].Value.ToString();
                    string viene="";
                    string id_publi = "";
                    
                    if (dgv_lista.Rows[i].Cells[5].Value == DBNull.Value)
                    {
                        viene = Convert.ToString(dgv_lista.Rows[i].Cells[5].Value);
                         id_publi = dgv_lista.Rows[i].Cells[5].Value.ToString().Split('-').Last();
                        
                    }
                   
                   
                    string id_libro = dgv_lista.Rows[i].Cells[4].Value.ToString().Split('-').Last();  






                    con.Open();
                    string verificar_boleta = "SELECT n_de_boleta from ventas where n_de_boleta =" + n_de_boleta + ";";
                    MySqlCommand comando = new MySqlCommand(verificar_boleta, con);
                    MySqlDataReader reador = comando.ExecuteReader();
                    string comparar = "";

                    while (reador.Read())
                    {
                        string a = reador["n_de_boleta"].ToString();
                        if (a.Equals(n_de_boleta.ToString()))
                        {
                            comparar = "son iguales";


                        }

                    }
                    con.Close();

                    if(comparar.Equals("son iguales"))
                    {

                        con.Open();

                        string ingresar_generan = "INSERT INTO generan values(" + n_de_boleta + ","+int.Parse(id_libro)+","+cantidad_comprada+","+precio+")";
                        MySqlCommand query_genera = new MySqlCommand(ingresar_generan, con);
                        query_genera.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        if (!viene.Equals(""))
                        {
                            string insertar_publicidad = "INSERT INTO se_registran values(" + int.Parse(id_publi) + "," + n_de_boleta + ");";
                            MySqlCommand query_se_registran = new MySqlCommand(insertar_publicidad, con);
                            query_se_registran.ExecuteNonQuery();
                            

                            
                        }con.Close();
                        con.Open();
                        string extraer_monto = "SELECT monto from ventas where =" + n_de_boleta + "; ";
                        MySqlCommand query_extraer = new MySqlCommand(extraer_monto, con);
                        MySqlDataReader monto = query_extraer.ExecuteReader();
                        con.Close();
                        string b = "";

                        while (monto.Read())
                        {
                             b = monto["monto"].ToString();

                        }
                        con.Open();
                        float cuenta = precio + float.Parse(b);
                        string monto_cambiar = "UPDATE from ventas set monto =" + cuenta + " where n_de_boleta =" + n_de_boleta + ";";

                        MySqlCommand cambiar_monto = new MySqlCommand(monto_cambiar, con);
                        cambiar_monto.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        con.Open();
                        string ingresar_venta = "INSERT INTO ventas values("+n_de_boleta+ ",'" + fecha + "'," + precio+");";
                        MySqlCommand query_ingersar_venta = new MySqlCommand(ingresar_venta, con);
                        query_ingersar_venta.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        string ingresar_generan = "INSERT INTO generan values(" + n_de_boleta + "," + int.Parse(id_libro) + "," + cantidad_comprada + "," + precio + ")";
                        MySqlCommand query_genera = new MySqlCommand(ingresar_generan, con);
                        query_genera.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        if (!viene.Equals(""))
                        {
                            string insertar_publicidad = "INSERT INTO se_registran values(" + int.Parse(id_publi) + "," + n_de_boleta + ");";
                            MySqlCommand query_se_registran = new MySqlCommand(insertar_publicidad, con);
                            query_se_registran.ExecuteNonQuery();

                        }
                        con.Close();

                    }
                

                    con.Close();





                }
                dgv_lista.Rows.Clear();
                actualizar_ventas();





            }








        }

        private void dgv_lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           
            
                int n = e.RowIndex;
                if (n != -1 && n !=0)
                {
                    dgv_lista.Rows.RemoveAt(n);
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
        public void solo_letras(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }

        }

        private void txt_boleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }

        private void dgv_lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void actualizar_ventas()
        {
            string Mostrar_ventas = "select v.n_de_boleta 'N de boleta         ', v.fecha_de_venta 'Fecha', v.monto 'Monto', g.precio 'Precio', g.cantidad_comprada 'Cantidad comprada', l.nombre 'Nombre' from ventas v join generan g on v.n_de_boleta=g.n_de_boleta join libros l on l.id_libro=g.id_libro;";
            MySqlCommand mostrar = new MySqlCommand(Mostrar_ventas, con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgv_ventas.DataSource = tabla;
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            
            if (!lbl_n_de_boleta.Text.Equals("")) 
            {
                    DialogResult resul = MessageBox.Show("Seguro que quiere eliminar la venta?", "Eliminar Registro", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        float n_de_boleta = float.Parse(lbl_n_de_boleta.Text);
                        string borrar_venta = "DELETE From ventas where n_de_boleta="+n_de_boleta+";";
                        con.Open();
                        MySqlCommand borrar = new MySqlCommand(borrar_venta,con);
                        borrar.ExecuteNonQuery();
                        con.Close();
                    }
                }
            else
            {
                MessageBox.Show("Seleccione una venta para borrar");
            }
            actualizar_ventas();
            
        }

        private void dgv_ventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                if (dgv_ventas.CurrentRow.Cells[0].Value.ToString() != "")
                {

                    float a = float.Parse(dgv_ventas.CurrentRow.Cells[0].Value.ToString());
                    lbl_n_de_boleta.Text = (Convert.ToInt32(a)).ToString();
                }

            }
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form caja = new control_de_caja();
            caja.Show();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
    
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnmaximizar.Visible = true;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_estadisticas_Click(object sender, EventArgs e)
        {
            finanzas finanzas = new finanzas();
            finanzas.Hide();

            estadisticas_mensuales estadisticas_Mensuales = new estadisticas_mensuales();
            estadisticas_Mensuales.Show();
        }
    }
    }

