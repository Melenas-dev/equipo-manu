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
        public static void eliminarGenerosDelLibro(MySqlConnection con, int isbn)
        {
            string borrar_generos = "DELETE FROM tienen WHERE isbn =" + isbn + ";";
            MySqlCommand borrador_generos = new MySqlCommand(borrar_generos, con);
            borrador_generos.ExecuteNonQuery();
        }

        public static void eliminarLibro(MySqlConnection con, int isbn)
        {
            string borrar = "DELETE FROM libros WHERE isbn =" + isbn + ";";
            MySqlCommand comando = new MySqlCommand(borrar, con);
            comando.ExecuteNonQuery();
            eliminarGenerosDelLibro(con, isbn);
        }
    }
}
