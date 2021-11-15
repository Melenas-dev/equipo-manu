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
                cmb_año.Items.Add(reader["year(fecha_de_venta)"]);
            }
            con.Close();
        }

        private void lbl_libros_vendidos_Click(object sender, EventArgs e)
        {

        }

        private void btn_cargar_datos_Click(object sender, EventArgs e)
        {
            if (cmb_mes.Text.Equals("1"))
            {
                con.Open();
                MySqlCommand obtener_precio = new MySqlCommand("select sum(precio), count(precio) from generan g join ventas v where month(fecha_de_venta)='" + cmb_mes.Text + "' and year(fecha_de_venta)=" +
                    "'" + cmb_año.Text + "' ;", con);
                MySqlDataReader obtencion_del_precio = obtener_precio.ExecuteReader();

                float precio = 0;
                float cantidad = 0;
                float promedio = 0;

                while (obtencion_del_precio.Read())
                {
                    precio = float.Parse(obtencion_del_precio["sum(precio)"].ToString());
                    cantidad = float.Parse(obtencion_del_precio["count(precio)"].ToString());
                    promedio = precio / cantidad;
                    MessageBox.Show((promedio).ToString());
                }

                /*
                MySqlCommand obtener_editoriales = new MySqlCommand("select id_ed from editoriales where nombre='" + cmb_editoriales.Text + "';", con);
                MySqlDataReader reader2 = obtener_editoriales.ExecuteReader();
                */
                con.Close();
                lbl_promedio_total.Text = (1).ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_mes_Click(object sender, EventArgs e)
        {

        }

        private void cmb_mes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
