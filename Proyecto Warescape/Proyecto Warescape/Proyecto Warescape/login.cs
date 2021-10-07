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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
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
            MySqlCommand comando = new MySqlCommand("Select * from usuarios where usuarios = '" + campo_usuario.Text + "'", conexion);

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

                this.Hide();
                ventana v1 = new ventana();
                v1.Show();
                
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void campo_contra_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
