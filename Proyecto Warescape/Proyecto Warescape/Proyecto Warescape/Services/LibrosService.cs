using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_Warescape.Services
{
    class LibrosService
    {
        public static void eliminarGenerosDelLibro(MySqlConnection con, int id_libro)
        {
            string borrar_generos = "DELETE FROM tienen WHERE id_libro =" + id_libro + ";";
            MySqlCommand borrador_generos = new MySqlCommand(borrar_generos, con);
            borrador_generos.ExecuteNonQuery();
        }

        public static void eliminarLibro(MySqlConnection con, int id_libro)
        {
            string borrar = "DELETE FROM libros WHERE id_libro =" + id_libro + ";";
            MySqlCommand comando = new MySqlCommand(borrar, con);
            comando.ExecuteNonQuery();
            eliminarGenerosDelLibro(con, id_libro);
        }

        public static void agregar_lcc_consignacion(MySqlConnection con, int boleta, int id_Libro, int cantidad, int valor_del_libro)
        {
            con.Open();
            MySqlCommand ingresar_lcc = new MySqlCommand("insert into lcc(n_de_operacion, id_libro, cantidad_consignada, precio_consignado) value(" + boleta + ", " + id_Libro + "," + cantidad + "," + valor_del_libro + ");", con);
            ingresar_lcc.ExecuteNonQuery();
            con.Close();
        }

        public static void agregar_lcc_compra(MySqlConnection con, int boleta, int id_Libro, int cantidad, int valor_del_libro)
        {
            con.Open();
            MySqlCommand ingresar_lcc = new MySqlCommand("insert into lcc(n_de_operacion, id_libro, cantidad_comprada, precio_comprado) value(" + boleta + ", " + id_Libro + "," + cantidad + "," + valor_del_libro + ");", con);
            ingresar_lcc.ExecuteNonQuery();
            con.Close();
        }

        public static void actualizar_stock_agregar(MySqlConnection con,int id_libro, int cantidad)
        {
            con.Open();
            MySqlCommand comparar_stock = new MySqlCommand("select stock from libros where  id_libro= " + id_libro + ";", con);
            MySqlDataReader reader_stock = comparar_stock.ExecuteReader();
            string f = "";
            while (reader_stock.Read())
            {
                f = reader_stock["stock"].ToString();
            }
            con.Close();
            con.Open();
            int stock_atualizar = int.Parse(f) + cantidad;
            MySqlCommand ingresar_stock = new MySqlCommand("UPDATE libros SET stock=" + stock_atualizar + " where id_libro=" + id_libro + "  ", con);
            ingresar_stock.ExecuteNonQuery();
            con.Close();
        }

        public static void actualizar_stock_quitar(MySqlConnection con, int id_libro, int cantidad)
        {
            con.Open();
            MySqlCommand comparar_stock = new MySqlCommand("select stock from libros where  id_libro= " + id_libro + ";", con);
            MySqlDataReader reader_stock = comparar_stock.ExecuteReader();
            string f = "";
            while (reader_stock.Read())
            {
                f = reader_stock["stock"].ToString();
            }
            con.Close();
            con.Open();
            int stock_atualizar = int.Parse(f) - cantidad;
            MySqlCommand ingresar_stock = new MySqlCommand("UPDATE libros SET stock=" + stock_atualizar + " where id_libro=" + id_libro + "  ", con);
            ingresar_stock.ExecuteNonQuery();
            con.Close();
        }

        public static string[] Obtener_fechas_ventas(MySqlConnection con)
        {
            con.Open();
            MySqlCommand obtener_año = new MySqlCommand("select year(fecha_de_venta) from ventas group by year(fecha_de_venta);", con);
            MySqlDataReader reader = obtener_año.ExecuteReader();

            string[] coleccion_fechas = { };

            while (reader.Read())
            {
                coleccion_fechas.Append(reader["year(fecha_de_venta)"]).ToString();
            }
            con.Close();
            return coleccion_fechas;
        }
    }
}
