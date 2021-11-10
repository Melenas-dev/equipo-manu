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
    }
}
