using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Warescape
{
    public partial class Login : Form
    {

        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=warescapesrl; Uid=root; Pwd=;");

        

        string contrasena;
        
        public Login()
        {
            InitializeComponent();
            //crear_conexion();
        }

        private void crear_conexion()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conectado bro");
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (campo_usuario.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre de usuario correcto");
                return;
            }
            
            if (campo_contra.Equals(""))
            {
                MessageBox.Show("Ingrese una contraseña correcta");
                return;
            }

            conexion.Open();
            MySqlCommand comando = new MySqlCommand("Select * from usuario where usuario = '" + campo_usuario.Text + "'", conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            {
                contrasena = reader["contrasena"].ToString();
            }
            conexion.Close();
            conexion.Open();
            MySqlCommand hasheo = new MySqlCommand("Select SHA1 ('" + campo_contra.Text + "') hasheo", conexion);



            MySqlDataReader reader_hasheo = hasheo.ExecuteReader();

            string contra_hasheada = "";

            while (reader_hasheo.Read())
            {
                contra_hasheada = reader_hasheo["hasheo"].ToString();
            }

            
            conexion.Close();

            if (contra_hasheada.Equals(contrasena))
            {

                if (campo_usuario.Text.Equals("Empleado"))
                {
                    this.Hide();
                    Form v1 = new ventana_empleado();
                    v1.Show();
                }
                else
                {
                    this.Hide();
                    ventana v1 = new ventana();
                    v1.Show();
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingreso_Enter(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void campo_contra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            Form restaurar = new FormEmail();
            restaurar.Show();
        }
    }
}
