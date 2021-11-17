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
    public partial class devoluciones : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=warescapesrl; Uid=root; Pwd=;");
        public devoluciones()
        {
            InitializeComponent();
        }

        private void devoluciones_Load(object sender, EventArgs e)
        {
            con.Close();

            MySqlCommand comando = new MySqlCommand("SELECT nombre,id_libro from libros", con);
            con.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                string nombre = registro["nombre"].ToString();
                string id_libro = registro["id_libro"].ToString();
                cmb_libros.Items.Add(nombre + "-" + id_libro);




            }
            con.Close();

            actualizar_devoluciones();

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_guardar_editorial_Click(object sender, EventArgs e)
        {
            if(cmb_libros.Text.Equals("") || txt_cantidad.Text.Equals(""))
            {
                MessageBox.Show("Ingrese valores correctos");
            }
            else
            {
                string id_libro = cmb_libros.Text.Split('-').Last().Trim();
                int cantidad = int.Parse(txt_cantidad.Text.Replace(" ", string.Empty));
                if (cantidad == 0) 
                {

                    MessageBox.Show("No puedes ingresar una devolucion con cantidad 0");

                }
                else 
                {

                    con.Open();
                    string comando2 = "SELECT l.stock, e.id_ed FROM libros l JOIN lcc as lc on lc.id_libro = l.id_libro JOIN compras_y_consignaciones c on lc.n_de_operacion = c.n_de_operacion JOIN editoriales e on e.id_ed=c.id_ed where l.id_libro=" + id_libro + ";";
                    MySqlCommand buscar_stock = new MySqlCommand(comando2,con);
                    MySqlDataReader leer_buscar_stock = buscar_stock.ExecuteReader();
                    int stock = 0;
                    int id_ed = 0;
                    while (leer_buscar_stock.Read())
                    {
                        stock = int.Parse(leer_buscar_stock["stock"].ToString());
                        id_ed = int.Parse(leer_buscar_stock["id_ed"].ToString());
                    }
                    con.Close();
                    if (stock <= 0) 
                    {
                        MessageBox.Show("No tienes stock de ese libro");
                    }
                    else
                    {
                        if (int.Parse(txt_cantidad.Text)>stock)
                        {
                            MessageBox.Show("No tienes tantos libros para devolver");
                        }
                        else
                        {
                            con.Open();
                            string ingresar_devolucion = "insert into devoluciones(id_libro,id_ed,fecha,cantidad) values("+id_libro+","+id_ed+ ",'"+dtp_fecha.Text+"',"+cantidad+");";
                            MySqlCommand comando_ingresar_devolucion = new MySqlCommand(ingresar_devolucion,con);
                            comando_ingresar_devolucion.ExecuteNonQuery();
                            con.Close();
                            int quitar = stock - int.Parse(txt_cantidad.Text);
                            con.Open();
                            string cambar_stock = "update libros set stock=" + quitar + " where id_libro=" + id_libro + ";";
                            MySqlCommand cambio_stock = new MySqlCommand(cambar_stock,con);
                            cambio_stock.ExecuteNonQuery();
                            con.Close();





                        }
                    }
                }
            }
            actualizar_devoluciones(); 
        }
        public void actualizar_devoluciones()
        {
            con.Open();
            string devoluciones = "select l.nombre'Libro', e.nombre'Editorial', d.fecha'Fecha', d.cantidad'Cantidad', d.id_devoluciones'Nª de devolucion', d.id_libro   from libros l join devoluciones d on l.id_libro=d.id_libro join editoriales e on e.id_ed=d.id_ed;";
            MySqlCommand mostrar = new MySqlCommand(devoluciones, con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = mostrar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgv_devoluciones.DataSource = tabla;
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lbl_id_devoluciones.Text.Equals(""))
            {
                MessageBox.Show("Seleccione una devolucion para borrar");
            }
            else {

                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar la devolucion "+lbl_nombre.Text+"?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    string eliminar_devolucion = "delete from devoluciones where id_devoluciones=" + int.Parse(lbl_id_devoluciones.Text) + ";";
                    con.Open();
                    MySqlCommand querry_eliminar = new MySqlCommand(eliminar_devolucion,con);
                    querry_eliminar.ExecuteNonQuery();
                    con.Close();
                    Services.LibrosService.actualizar_stock_agregar(con, int.Parse(lbl_id_libro.Text), int.Parse(lbl_cantidad.Text));
                    actualizar_devoluciones();
                    lbl_cantidad.Text = "";
                    lbl_id_devoluciones.Text = "";
                    lbl_id_libro.Text = "";
                    lbl_nombre.Text = "";
                }
            }
        }

        private void dgv_devoluciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1) 
            {
                lbl_id_devoluciones.Text = dgv_devoluciones.Rows[n].Cells[4].Value.ToString(); 
                lbl_nombre.Text = dgv_devoluciones.Rows[n].Cells[0].Value.ToString();
                lbl_cantidad.Text= dgv_devoluciones.Rows[n].Cells[3].Value.ToString();
                lbl_id_libro.Text = dgv_devoluciones.Rows[n].Cells[5].Value.ToString();

            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void devoluciones_MouseDown(object sender, MouseEventArgs e)
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

        private void dtp_fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
