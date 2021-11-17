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
using Proyecto_Warescape.Services;

namespace Proyecto_Warescape
{
    public partial class estadisticas_mensuales : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=warescapesrl; Uid=root; Pwd=;");

        public estadisticas_mensuales()
        {
            InitializeComponent();
        }

        private void estadisticas_mensuales_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand obtener_año = new MySqlCommand("select year(fecha_de_venta) from ventas group by year(fecha_de_venta);", con);
            MySqlDataReader reader = obtener_año.ExecuteReader();
            while (reader.Read())
            {
                cmb_año.Items.Add(reader["year(fecha_de_venta)"].ToString()); 
            }
            con.Close();

            con.Open();
            MySqlCommand obtener_editoriales = new MySqlCommand("select * from editoriales;", con);
            MySqlDataReader reader2 = obtener_editoriales.ExecuteReader();
            while (reader2.Read())
            {
                EditorialesClase ed = new EditorialesClase();
                ed.nombre = reader2["nombre"].ToString();
                ed.id_ed = int.Parse(reader2["id_ed"].ToString());

                cmb_editoriales.Items.Add(ed);
            }
            con.Close();
            
        }

        private void lbl_libros_vendidos_Click(object sender, EventArgs e)
        {

        }

        private void btn_cargar_datos_Click(object sender, EventArgs e)
        {
            if (!cmb_mes.Text.Equals("") || !cmb_año.Text.Equals(""))
            {
                // LA TERNERA ANASHE
                String editorial_seleccionada = cmb_editoriales.SelectedItem == null ? "-1" : (cmb_editoriales.SelectedItem as EditorialesClase).id_ed.ToString();             
                if (cmb_editoriales.Text.Equals(""))
                {
                    lbl_titulo_promedio.Text = "Promedio de ganancia mensual en total";
                }
                else
                {
                    lbl_titulo_promedio.Text = "Promedio de ganancias por editorial";
                }
                con.Open();
                MySqlCommand obtener_precio = new MySqlCommand("SELECT IFNULL(SUM(g.precio), 0) as precio, IFNULL(sum(cantidad_vendida), 0)'Cantidad' FROM generan g JOIN ventas v ON g.n_de_boleta = v.n_de_boleta" +
                    " JOIN libros l on l.id_libro=g.id_libro join lcc as lc on lc.id_libro = l.id_libro JOIN compras_y_consignaciones c on lc.n_de_operacion = c.n_de_operacion JOIN editoriales e on e.id_ed=c.id_ed where month(fecha_de_venta)='" + cmb_mes.Text + "' and year(fecha_de_venta)=" +
                    "'" + cmb_año.Text + "' and (c.id_ed=" + editorial_seleccionada + " or " + editorial_seleccionada + " = -1);", con);
                MySqlDataReader obtencion_del_precio = obtener_precio.ExecuteReader();

                float precio = 0;
                float cantidad = 0;
                float promedio = 0;

                while (obtencion_del_precio.Read())
                {
                    precio = float.Parse(obtencion_del_precio["precio"].ToString());          
                    cantidad = float.Parse(obtencion_del_precio["Cantidad"].ToString());
                    promedio = precio / cantidad;
                    if (double.IsNaN(promedio))
                    {
                        lbl_promedio_total.Text = "0";
                    }
                    else
                    {
                        lbl_promedio_total.Text = promedio.ToString();
                    }
                }

                /*
                MySqlCommand obtener_editoriales = new MySqlCommand("select id_ed from editoriales where nombre='" + editorial_seleccionada + "';", con);
                MySqlDataReader reader2 = obtener_editoriales.ExecuteReader();
                */
                con.Close();
            }
            else
            {
                MessageBox.Show("Mes y año deben estar ingresados para continuar", "Error");
            }
        }


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_año_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_mes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_editoriales_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
