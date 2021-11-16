﻿using System;
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
            dtp_fecha.Value = DateTime.Now.Date;
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
            con.Open();
            MySqlCommand mostrar_operacion = new MySqlCommand("SELECT n_de_operacion from compras_y_consignaciones", con);
            MySqlDataReader leer_operacion = mostrar_operacion.ExecuteReader();
            while (leer_operacion.Read())
            {
                cmb_boleta.Items.Add(leer_operacion["n_de_operacion"].ToString());

            }
            con.Close();

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
            lbl_id_de_libro.Text = "";
            con.Open();
            if (txt_isbn.Text.Equals("") || txt_codigo.Text.Equals("") || txt_nombre.Text.Equals("") || txt_precio.Text.Equals("") || txt_cantidad.Text.Equals("") || Cmb_genero.Text.Equals("") || cmb_editorial.Text.Equals("") || cmb_boleta.Text.Equals("") ||cmb_tipo_de_operacion.Text.Equals("") || txt_valor_del_libro.Text.Equals("") || txt_autor.Text.Equals("")) 
            {
                MessageBox.Show("Ingresar todos los parametros");
            }
            else
            {
                MySqlCommand comparar_boleta = new MySqlCommand("select n_de_operacion from compras_y_consignaciones where n_de_operacion="+int.Parse(cmb_boleta.Text)+";", con);
                MySqlDataReader reader_boleta = comparar_boleta.ExecuteReader();
                string c = "";
                string d="";
                while (reader_boleta.Read())
                {
                    c = reader_boleta["n_de_operacion"].ToString();
                    if (cmb_boleta.Text.Equals(c))
                    {
                        d = "i";
                    }
                }
                con.Close();
                if (d.Equals("i"))
                {

                }
                else
                {
                    con.Open();
                    MySqlCommand ingresar_editorial = new MySqlCommand("select id_ed from editoriales where nombre='" + cmb_editorial.Text + "';", con);
                    MySqlDataReader reador = ingresar_editorial.ExecuteReader();
                    string valor2 = "";
                    while (reador.Read())
                    {
                        valor2 = reador["id_ed"].ToString();
                        
                    }
                    con.Close();
                    con.Open();
                    MySqlCommand ingresar_operacion = new MySqlCommand("insert into compras_y_consignaciones(n_de_operacion, fecha_de_operacion, id_ed) values("+int.Parse(cmb_boleta.Text)+ ",'" + dtp_fecha.Text + "',"+valor2+");", con);
                    ingresar_operacion.ExecuteNonQuery();
                    con.Close();
                }
                con.Open();
                string b = "";
                if (!lbl_id_de_libro.Text.Equals(""))
                {
                    MySqlCommand comparar = new MySqlCommand("select id_libro from libros where id_libro=" + int.Parse(lbl_id_de_libro.Text) + ";", con);
                    MySqlDataReader reader = comparar.ExecuteReader();
                    string a;                   
                    while (reader.Read())
                    {
                        a = reader["id_libro"].ToString();
                        if (lbl_id_de_libro.Text.Equals(a))
                        {
                            b = "iguales";
                        }
                    }
                }
                con.Close();
                if (b.Equals("iguales"))
                {
                    if (cmb_tipo_de_operacion.Text.Equals("Compra"))
                    {
                       
                        con.Open();
                        MySqlCommand ingresar_lcc = new MySqlCommand("insert into lcc(n_de_operacion, id_libro, cantidad_comprada, precio_comprado) value(" + int.Parse(cmb_boleta.Text) + ", " + int.Parse(lbl_id_de_libro.Text) + "," + int.Parse(txt_cantidad.Text) + "," + int.Parse(txt_valor_del_libro.Text) + ");", con);
                        ingresar_lcc.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        MySqlCommand comparar_stock = new MySqlCommand("select stock from libros where  id_libro= " + lbl_id_de_libro.Text + ";", con);
                        MySqlDataReader reader_stock = comparar_stock.ExecuteReader();
                        string f = "";
                        while (reader_stock.Read())
                        {
                             f= reader_stock["stock"].ToString();                          
                        }
                        con.Close();
                        con.Open();
                        int stock_atualizar = int.Parse(f) + int.Parse(txt_cantidad.Text);
                        MySqlCommand ingresar_stock = new MySqlCommand("UPDATE libros SET stock="+stock_atualizar+" where id_libro="+int.Parse(lbl_id_de_libro.Text)+"  ", con);
                        ingresar_stock.ExecuteNonQuery();
                        con.Close();
                    }
                    if (cmb_tipo_de_operacion.Text.Equals("Consignacion"))
                    {
                        
                        con.Open();
                        MySqlCommand ingresar_lcc = new MySqlCommand("insert into lcc(n_de_operacion, id_libro, cantidad_consignada, precio_consignado) value(" + int.Parse(cmb_boleta.Text) + ", " + int.Parse(lbl_id_de_libro.Text) + "," + int.Parse(txt_cantidad.Text) + "," + int.Parse(txt_valor_del_libro.Text) + ");", con);
                        ingresar_lcc.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        MySqlCommand comparar_stock = new MySqlCommand("select stock from libros where  id_libro= " + lbl_id_de_libro.Text + ";", con);
                        MySqlDataReader reader_stock = comparar_stock.ExecuteReader();
                        string f = "";
                        while (reader_stock.Read())
                        {
                            f = reader_stock["stock"].ToString();
                        }
                        con.Close();
                        con.Open();
                        int stock_atualizar = int.Parse(f) + int.Parse(txt_cantidad.Text);
                        MySqlCommand ingresar_stock = new MySqlCommand("UPDATE libros SET stock=" + stock_atualizar + " where id_libro=" + int.Parse(lbl_id_de_libro.Text) + "  ", con);
                        ingresar_stock.ExecuteNonQuery();
                        con.Close();
                    }


                }
                else
                {
                    string id_libro_valor="";
                    con.Close();
                    if (cmb_tipo_de_operacion.Text.Equals("Compra"))
                    {
                        con.Open();
                        string ingreso1 = "insert into libros(isbn, codigo, precio, stock, nombre, autor) values(" + int.Parse(txt_isbn.Text) + "," + int.Parse(txt_codigo.Text) + "," + decimal.Parse(txt_precio.Text) + "," + int.Parse(txt_cantidad.Text) + ",'" + txt_nombre.Text + "','" + txt_autor.Text + "');";
                        MySqlCommand Ingreso = new MySqlCommand(ingreso1, con);
                        Ingreso.ExecuteNonQuery();
                        id_libro_valor = Ingreso.LastInsertedId.ToString();
                        con.Close();
                        con.Open();
                        MySqlCommand ingresar_lcc = new MySqlCommand("insert into lcc(n_de_operacion, id_libro, cantidad_comprada, precio_comprado) value(" + int.Parse(cmb_boleta.Text) + ", " + int.Parse(id_libro_valor) + "," + int.Parse(txt_cantidad.Text) + "," + int.Parse(txt_valor_del_libro.Text) + ")", con);
                        ingresar_lcc.ExecuteNonQuery();
                        con.Close();

                    }
                    if (cmb_tipo_de_operacion.Text.Equals("Consignacion"))
                    {
                        con.Open();
                        string ingreso = "insert into libros(isbn, codigo, precio, stock, nombre, autor) values(" + int.Parse(txt_isbn.Text) + "," + int.Parse(txt_codigo.Text) + "," + decimal.Parse(txt_precio.Text) + "," + int.Parse(txt_cantidad.Text) + ",'" + txt_nombre.Text + "','" + txt_autor.Text + "');";
                        MySqlCommand Ingreso = new MySqlCommand(ingreso, con);
                        Ingreso.ExecuteNonQuery();
                        id_libro_valor = Ingreso.LastInsertedId.ToString();
                        con.Close();     
                        con.Open();
                        MySqlCommand ingresar_lcc = new MySqlCommand("insert into lcc(n_de_operacion, id_libro, cantidad_consignada, precio_consignado) value(" + float.Parse(cmb_boleta.Text) + ", " + int.Parse(id_libro_valor) + "," + int.Parse(txt_cantidad.Text) + "," + int.Parse(txt_valor_del_libro.Text) + ");", con);
                        ingresar_lcc.ExecuteNonQuery();
                        con.Close();
                    }
                    int id_libro;
                    if (lbl_id_de_libro.Text.Equals(""))
                    {
                        id_libro = int.Parse(id_libro_valor);
                    }
                    else
                    {
                        id_libro = int.Parse(lbl_id_de_libro.Text);
                    }
                   
                    for(int i = 0; i < dgv_generos.Rows.Count - 1; i++)
                    {
                        int id_genero = int.Parse(dgv_generos.Rows[i].Cells[1].Value.ToString());
                        

                        con.Open();
                        string ingreso2 = "insert into tienen values(" + id_libro + "," + id_genero + ")";
                        MySqlCommand ingresargenero = new MySqlCommand(ingreso2, con);
                        ingresargenero.ExecuteNonQuery();
                        con.Close();
                    }

                    actualizar_dgv_libros();
                    txt_isbn.Text = "";
                    txt_codigo.Text = "";
                    txt_nombre.Text = "";
                    txt_precio.Text = "";
                    txt_cantidad.Text = "";
                    Cmb_genero.Text = "";
                    txt_valor_del_libro.Text = "";
                    cmb_boleta.Text = "";
                    cmb_tipo_de_operacion.Text = "";
                    cmb_editorial.Text = "";
                    dgv_generos.Rows.Clear();
                }
            
        }
            con.Close();

        }

      

       

      

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();          
            if (lbl_id_de_libro.Text.Equals(""))
            {
                MessageBox.Show("Selecione un libro para borrar");
            }
            else
            {
                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el libro?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    Services.LibrosService.eliminarLibro(con, int.Parse(lbl_id_de_libro.Text));
                    actualizar_dgv_libros();
                    txt_isbn.Text = "";
                    txt_codigo.Text = "";
                    txt_nombre.Text = "";
                    txt_autor.Text = "";
                    txt_precio.Text = "";
                    txt_cantidad.Text = "";
                    Cmb_genero.Text = "";
                    txt_valor_del_libro.Text = "";
                    cmb_boleta.Text = "";
                    cmb_tipo_de_operacion.Text = "";
                    cmb_editorial.Text = "";
                    lbl_id_de_libro.Text = "";
                    dgv_generos.Rows.Clear();
                }
            }
            con.Close();


        }

        private void guardar_edicion(object sender, EventArgs e)
        {
            con.Open();
            if (txt_isbn.Text.Equals("") || txt_codigo.Text.Equals("") || txt_nombre.Text.Equals("") || txt_precio.Text.Equals(""))
            {
                MessageBox.Show("Ingresar todos los parametros");
            }
            else
            {
                if(lbl_id_de_libro.Text.Equals(""))
                {
                    MessageBox.Show("Selecione un libro para editar");
                }
                else { 
                MySqlCommand editar_libro = new MySqlCommand("update libros SET isbn=" + int.Parse(txt_isbn.Text) + ", codigo=" + int.Parse(txt_codigo.Text) + ", precio=" + float.Parse(txt_precio.Text) + ", nombre='" + txt_nombre.Text + "', autor='" + txt_autor.Text + "' Where id_libro=" + int.Parse(lbl_id_de_libro.Text) + ";", con);
                editar_libro.ExecuteNonQuery();

                Services.LibrosService.eliminarGenerosDelLibro(con, int.Parse(lbl_id_de_libro.Text));
                    
                for (int i = 0; i < dgv_generos.Rows.Count - 1; i++)
                {
                    int id_genero = int.Parse(dgv_generos.Rows[i].Cells[1].Value.ToString());
                    int id_libro = int.Parse(lbl_id_de_libro.Text);

                        
                            string ingreso2 = "insert into tienen values(" + id_libro + "," + id_genero + ")";
                            MySqlCommand ingresargenero = new MySqlCommand(ingreso2, con);
                            ingresargenero.ExecuteNonQuery();
                        

                }


                    actualizar_dgv_libros();
                    txt_isbn.Text = "";
                    txt_codigo.Text = "";
                    txt_nombre.Text = "";
                    txt_precio.Text = "";
                    txt_autor.Text = "";
                    txt_cantidad.Text = "";
                    Cmb_genero.Text = "";
                    txt_valor_del_libro.Text = "";
                    cmb_boleta.Text = "";
                    cmb_tipo_de_operacion.Text = "";
                    cmb_editorial.Text = "";
                    lbl_id_de_libro.Text = "";
                    dgv_generos.Rows.Clear();
                }
            }
            con.Close();
            
        }



        private void dgv_libros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                lbl_id_de_libro.Text= this.dgv_libros.CurrentRow.Cells[0].Value.ToString();
                txt_isbn.Text = this.dgv_libros.CurrentRow.Cells[1].Value.ToString();
                txt_codigo.Text = this.dgv_libros.CurrentRow.Cells[2].Value.ToString();
                txt_precio.Text = this.dgv_libros.CurrentRow.Cells[3].Value.ToString();                
                txt_nombre.Text = this.dgv_libros.CurrentRow.Cells[5].Value.ToString();
                txt_autor.Text = this.dgv_libros.CurrentRow.Cells[6].Value.ToString();
                cmb_editorial.Text = this.dgv_libros.CurrentRow.Cells[7].Value.ToString();
                if (dgv_libros.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    int id_libro = int.Parse(dgv_libros.CurrentRow.Cells[0].Value.ToString());
                con.Open();
                string query_generos = "SELECT g.id_genero, descripcion from tienen t JOIN generos g on t.id_genero = g.id_genero where id_libro = " + id_libro + ";";
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
                " WHERE t.id_libro = l.id_libro LIMIT 1 ) 'Primer genero del libro' FROM libros l JOIN lcc as lc on lc.id_libro = l.id_libro JOIN compras_y_consignaciones c on lc.n_de_operacion = c.n_de_operacion JOIN editoriales e on e.id_ed=c.id_ed", con);
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
        public void solo_letras(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

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
            solo_letras(e);
           
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
            WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnmaximizar.Visible = true;
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

        private void cmb_boleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }

        private void cmb_tipo_de_operacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
            solo_letras(e);
        }

        private void txt_valor_del_libro_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_editorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb_editorial.DataSource = null;
            cmb_editorial.Items.Clear();
            Cmb_genero.DataSource = null;
            Cmb_genero.Items.Clear();

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

            }
            con.Close();
            txt_isbn.Text = "";
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_precio.Text = "";
            txt_autor.Text = "";
            txt_cantidad.Text = "";
            Cmb_genero.Text = "";
            cmb_editorial.Text = "";
            txt_valor_del_libro.Text = "";
            cmb_boleta.Text = "";
            cmb_tipo_de_operacion.Text = "";
            lbl_id_de_libro.Text = "";
            dgv_generos.Rows.Clear();

        }

        private void Cmb_genero_SelectedValueChanged(object sender, EventArgs e)
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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_editorial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
    
}
