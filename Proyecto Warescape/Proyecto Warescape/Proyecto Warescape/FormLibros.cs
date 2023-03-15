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
using Google.Protobuf.WellKnownTypes;

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
            //muestra en el combobox generos. Si retorna 200 es ok
            cargarGenerosLibros(con);

            actualizar_dgv_libros(con);
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



            actualizar_cmb_buscar();
                        
        }

       

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingresar_libro(object sender, EventArgs e)
        {
            List<string> colCamposVacios = validacionCamposIngresarLibros();

            if (colCamposVacios.Count > 0) 
            {
                MessageBox.Show("Falta ingresar " + string.Join(", ", colCamposVacios.Select(campo => campo)));
            }
            else
            {
                con.Open();
                MySqlCommand comparar_boleta = new MySqlCommand("select n_de_operacion from compras_y_consignaciones where n_de_operacion="+long.Parse(cmb_boleta.Text)+";", con);
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
                    MySqlCommand ingresar_operacion = new MySqlCommand("insert into compras_y_consignaciones(n_de_operacion, fecha_de_operacion, id_ed) values("+long.Parse(cmb_boleta.Text)+ ",'" + dtp_fecha.Text + "',"+valor2+");", con);
                    ingresar_operacion.ExecuteNonQuery();
                    con.Close();
                }
                con.Open();
                
                if (!lbl_id_de_libro.Text.Equals(""))
                {
                    MessageBox.Show("Tienes un libros seleccionado si quieres ingresar un libro dale al boton 'Actualizar' para que se deseleccione, en el caso de querer ingresar una consignacion o compra ingrese en el boton 'Ingresar consignacion o compra' ");
                }
                else
                {
                    string id_libro_valor="";
                    con.Close();
                    if (txt_isbn.Text.Trim().Equals("") || txt_codigo.Text.Trim().Equals("") || txt_precio.Text.Trim().Equals("") || txt_cantidad.Text.Trim().Equals("") || txt_nombre.Text.Trim().Equals("") || txt_autor.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("parametro no permitido");

                    }
                    else
                    {

                        if (cmb_tipo_de_operacion.Text.Equals("Compra"))
                    {
                        con.Open();
                        string ingreso1 = "insert into libros(isbn, codigo, precio, stock, nombre, autor) values(" + long.Parse(txt_isbn.Text.Trim()) + "," + long.Parse(txt_codigo.Text.Trim()) + "," + decimal.Parse(txt_precio.Text.Trim()) + "," + int.Parse(txt_cantidad.Text.Trim()) + ",'" + txt_nombre.Text.Trim() + "','" + txt_autor.Text.Trim() + "');";
                        MySqlCommand Ingreso = new MySqlCommand(ingreso1, con);
                        Ingreso.ExecuteNonQuery();
                        id_libro_valor = Ingreso.LastInsertedId.ToString();
                        con.Close();
                        Services.LibrosService.agregar_lcc_compra(con, int.Parse(cmb_boleta.Text), int.Parse(id_libro_valor), int.Parse(txt_cantidad.Text), int.Parse(txt_valor_del_libro.Text));

                        }
                    if (cmb_tipo_de_operacion.Text.Equals("Consignacion"))
                    {
                        con.Open();
                        string ingreso = "insert into libros(isbn, codigo, precio, stock, nombre, autor) values(" + long.Parse(txt_isbn.Text) + "," + long.Parse(txt_codigo.Text) + "," + decimal.Parse(txt_precio.Text) + "," + int.Parse(txt_cantidad.Text) + ",'" + txt_nombre.Text + "','" + txt_autor.Text + "');";
                        MySqlCommand Ingreso = new MySqlCommand(ingreso, con);
                        Ingreso.ExecuteNonQuery();
                        id_libro_valor = Ingreso.LastInsertedId.ToString();
                        con.Close();
                            Services.LibrosService.agregar_lcc_consignacion(con, int.Parse(cmb_boleta.Text), int.Parse(id_libro_valor), int.Parse(txt_cantidad.Text), int.Parse(txt_valor_del_libro.Text));
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
                    }

                    actualizar_dgv_libros(con);
                    cmb_buscar_libro.Items.Clear();
                    actualizar_cmb_buscar();
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
                    dgv_generos.Rows.Clear();
                }
            
        }
            con.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
                      
            if (lbl_id_de_libro.Text.Equals(""))
            {
                MessageBox.Show("Selecione un libro para borrar");
            }
            else
            {
                con.Open();
                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el libro?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    Services.LibrosService.eliminarLibro(con, int.Parse(lbl_id_de_libro.Text));
                    actualizar_cmb_buscar();
                    actualizar_dgv_libros(con);
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
                con.Close();
            }
            con.Close();


        }

        private void guardar_edicion(object sender, EventArgs e)
        {
            con.Open();

            txt_precio.Text = txt_precio.Text.Replace(" ", string.Empty);
            txt_isbn.Text = txt_isbn.Text.Replace(" ", string.Empty);
            txt_codigo.Text = txt_codigo.Text.Replace(" ", string.Empty);
            txt_cantidad.Text = txt_cantidad.Text.Replace(" ", string.Empty);
            txt_valor_del_libro.Text = txt_valor_del_libro.Text.Replace(" ", string.Empty);

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
                MySqlCommand editar_libro = new MySqlCommand("update libros SET isbn=" + long.Parse(txt_isbn.Text) + ", codigo=" + long.Parse(txt_codigo.Text) + ", precio=" + float.Parse(txt_precio.Text) + ", nombre='" + txt_nombre.Text + "', autor='" + txt_autor.Text + "' Where id_libro=" + int.Parse(lbl_id_de_libro.Text) + ";", con);
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

                    actualizar_cmb_buscar();
                    actualizar_dgv_libros(con);
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
        public void actualizar_dgv_libros(MySqlConnection con)
        {
            try
            {
                con.Open();
                MySqlCommand mostrar = new MySqlCommand("SELECT l.id_libro'ID Libro', l.isbn'ISBN', l.codigo'Codigo', l.precio'Precio', l.stock'Stock', l.nombre'Nombre', l.autor'Autor', e.nombre Editorial, ( SELECT g.descripcion FROM tienen t JOIN generos g ON g.id_genero = t.id_genero " +
                    " WHERE t.id_libro = l.id_libro LIMIT 1 ) 'Primer genero del libro' FROM libros l JOIN lcc as lc on lc.id_libro = l.id_libro JOIN compras_y_consignaciones c on lc.n_de_operacion = c.n_de_operacion JOIN editoriales e on e.id_ed=c.id_ed", con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = mostrar;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgv_libros.DataSource = tabla;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizar_dgv_libros = " + ex.Message);
                throw;
            }
        }

        public void actualizar_cmb_buscar()
        {
            con.Close();
            con.Open();
            MySqlCommand Libros = new MySqlCommand("SELECT id_libro,nombre from libros;", con);
            MySqlDataReader leer_libros = Libros.ExecuteReader();
            AutoCompleteStringCollection text = new AutoCompleteStringCollection();
            while (leer_libros.Read())
            {

                string id_libro = leer_libros["id_libro"].ToString();
                string nombre = leer_libros["nombre"].ToString();

                cmb_buscar_libro.Items.Add(nombre + "-" + id_libro);
                text.Add(nombre + "-" + id_libro);

            }
            con.Close();
            
            cmb_buscar_libro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_buscar_libro.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cmb_buscar_libro.AutoCompleteCustomSource = text;
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
            Form marketing_ir = new FormMarketing();
            marketing_ir.Show();
            this.Hide();
        }

       

        private void Cmb_genero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            solo_numeros(e);
            solo_letras(e);
           
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFinanzas finanzas = new FormFinanzas();
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_devoluciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form editoriales = new FormEditoriales();
            editoriales.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form generos = new FormAgregar_genero();
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
            actualizar_dgv_libros(con);
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
                int id_genero = int.Parse(dgv_generos.Rows[i].Cells[1].Value.ToString().Trim());

                if (id_genero == (Cmb_genero.SelectedItem as Generos).id_genero)
                {
                    MessageBox.Show("El genero ya esta ingresado");
                    return;
                }
            }

            dgv_generos.Rows.Add(Cmb_genero.Text, ((Cmb_genero.SelectedItem as Generos).id_genero).ToString());
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cmb_editorial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form devoluciones1 = new FormDevoluciones();
            devoluciones1.Show();
        }

        private void btn_ingresar_consignacion_Click(object sender, EventArgs e)
        {

            txt_precio.Text = txt_precio.Text.Replace(" ", string.Empty);
            txt_isbn.Text = txt_isbn.Text.Replace(" ", string.Empty);
            txt_codigo.Text = txt_codigo.Text.Replace(" ", string.Empty);
            txt_cantidad.Text = txt_cantidad.Text.Replace(" ", string.Empty);
            txt_valor_del_libro.Text = txt_valor_del_libro.Text.Replace(" ", string.Empty);
            if (lbl_id_de_libro.Text.Equals("")) 
            {
                MessageBox.Show("Seleccione un libro antes de realizar una consignacion");
                
            }
            else {
                if (txt_isbn.Text.Equals("") || txt_codigo.Text.Equals("") || txt_nombre.Text.Equals("") || txt_precio.Text.Equals("") || cmb_editorial.Text.Equals("") || cmb_boleta.Text.Equals("") || cmb_tipo_de_operacion.Text.Equals("") || txt_valor_del_libro.Text.Equals("") || txt_autor.Text.Equals(""))
                {
                    MessageBox.Show("Ingresar todos los parametros");
                }
                else
                {

                    con.Open();
                    MySqlCommand comparar_boleta = new MySqlCommand("select n_de_operacion from compras_y_consignaciones where n_de_operacion=" + long.Parse(cmb_boleta.Text) + ";", con);
                    MySqlDataReader reader_boleta = comparar_boleta.ExecuteReader();
                    string c = "";
                    string d = "";
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
                        MySqlCommand ingresar_operacion = new MySqlCommand("insert into compras_y_consignaciones(n_de_operacion, fecha_de_operacion, id_ed) values(" + long.Parse(cmb_boleta.Text) + ",'" + dtp_fecha.Text + "'," + valor2 + ");", con);
                        ingresar_operacion.ExecuteNonQuery();
                        con.Close();


                    }
                    if (cmb_tipo_de_operacion.Text.Equals("Compra"))
                    {
                        Services.LibrosService.agregar_lcc_compra(con, int.Parse(cmb_boleta.Text), int.Parse(lbl_id_de_libro.Text), int.Parse(txt_cantidad.Text), int.Parse(txt_valor_del_libro.Text));
                        Services.LibrosService.actualizar_stock_agregar(con, int.Parse(lbl_id_de_libro.Text), int.Parse(txt_cantidad.Text));

                    }
                    if (cmb_tipo_de_operacion.Text.Equals("Consignacion"))
                    {
                        Services.LibrosService.agregar_lcc_consignacion(con, int.Parse(cmb_boleta.Text), int.Parse(lbl_id_de_libro.Text), int.Parse(txt_cantidad.Text), int.Parse(txt_valor_del_libro.Text));
                        Services.LibrosService.actualizar_stock_agregar(con, int.Parse(lbl_id_de_libro.Text), int.Parse(txt_cantidad.Text));

                    }
                    actualizar_dgv_libros(con);
                    txt_isbn.Text = "";
                    lbl_id_de_libro.Text = "";
                    txt_codigo.Text = "";
                    txt_nombre.Text = "";
                    txt_precio.Text = "";
                    txt_cantidad.Text = "";
                    txt_autor.Text = "";
                    Cmb_genero.Text = "";
                    txt_valor_del_libro.Text = "";
                    cmb_boleta.Text = "";
                    cmb_tipo_de_operacion.Text = "";
                    cmb_editorial.Text = "";
                    dgv_generos.Rows.Clear();
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (!cmb_buscar_libro.Text.Trim().Equals(""))
            {
                con.Open();
                int id_libro = int.Parse(cmb_buscar_libro.Text.Split('-').Last().Trim());
                string buscar_libro = "SELECT l.*, e.nombre Editorial, ( SELECT g.descripcion FROM tienen t JOIN generos g ON g.id_genero = t.id_genero " +
                    " WHERE t.id_libro = l.id_libro LIMIT 1 ) 'Primer genero del libro' FROM libros l JOIN lcc as lc on lc.id_libro = l.id_libro JOIN compras_y_consignaciones c on lc.n_de_operacion = c.n_de_operacion JOIN editoriales e on e.id_ed=c.id_ed where l.id_libro=" + id_libro + ";";
                MySqlDataAdapter mostrar_libro = new MySqlDataAdapter(buscar_libro,con);
                DataTable tabla = new DataTable();
                mostrar_libro.Fill(tabla);
                dgv_libros.DataSource = tabla;
                con.Close();
            }
            else
            {
                MessageBox.Show("Ingrese un libro para buscar");
            }
        }

        private void dtp_fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public int cargarGenerosLibros(MySqlConnection con) 
        {
            dtp_fecha.Value = DateTime.Now.Date;
            int status = 500;

            try
            {
                con.Open();
                MySqlCommand queryGeneros = new MySqlCommand("SELECT * from generos;", con);
                MySqlDataReader generos = queryGeneros.ExecuteReader();
                while (generos.Read())
                {
                    Generos gen = new Generos();
                    gen.descripcion = generos["descripcion"].ToString();
                    gen.id_genero = int.Parse(generos["id_genero"].ToString());

                    Cmb_genero.Items.Add(gen);
                }
                con.Close();
                status = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw;
            }
            return status;
        }

        public List<string> validacionCamposIngresarLibros()
        {
            try
            {
                string[] colCamposValue = { txt_isbn.Text.Trim(), 
                        txt_codigo.Text.Trim(), 
                        txt_nombre.Text.Trim(), 
                        txt_precio.Text.Trim(), 
                        txt_cantidad.Text.Trim(), 
                        Cmb_genero.Text.Trim(), 
                        cmb_editorial.Text.Trim(), 
                        cmb_boleta.Text.Trim(), 
                        cmb_tipo_de_operacion.Text.Trim(), 
                        txt_valor_del_libro.Text.Trim(), 
                        txt_autor.Text.Trim() };

                string[] colCamposKey = { "ISBN", 
                            "Código", 
                            "Nombre", 
                            "Precio", 
                            "Cantidad", 
                            "Genero", 
                            "Editorial", 
                            "Boleta", 
                            "Tio de Operación", 
                            "Valor del Libro", 
                            "Autor" };

                List<string> camposVacios = new List<string>();

                for (int i = 0; i < colCamposValue.Length; i++)
                {
                    if (colCamposValue[i].Equals(""))
                    {
                        Console.Write(colCamposKey[i]);
                        camposVacios.Add(colCamposKey[i]);
                    }
                }

                return camposVacios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validacionCamposIngresarLibros = " + ex.Message);
                throw;
            }
        }
    }
    
}
