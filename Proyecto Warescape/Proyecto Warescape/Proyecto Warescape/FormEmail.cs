using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace Proyecto_Warescape
{
    public partial class FormEmail : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=warescapesrl; Uid=root; Pwd=;");
        public FormEmail()
        {
            InitializeComponent();
            pnl_cambiar_pass.Hide();
            txt_pass1.PasswordChar = '*';
            txt_pass2.PasswordChar = '*';
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            do
            {
                Email enviarmail = new Email();
                int num = enviarmail.Enviar(txt_receptor.Text);
                int resultado = 0;
                if (num != 0)
                {
                    try
                    {
                        resultado = int.Parse(Interaction.InputBox("Ingrese el digito", "Verificacion"));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Caracteres no permitidos, ingrese NUMEROS.");
                        result = MessageBox.Show("Debido al error, ¿Desea volver a enviar el correo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                    if(num == resultado)
                    {
                        MessageBox.Show("Los numeros coinciden");
                        result = DialogResult.No;
                        pnl_cambiar_pass.Show();
                    }
                }
                else
                {
                    result = MessageBox.Show("Debido al error, ¿Desea volver a enviar el correo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            } while (result == DialogResult.Yes);
            MessageBox.Show("Proceso terminado.");

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cambiar_Click(object sender, EventArgs e)
        {
            if(txt_pass1.Text != txt_pass2.Text)
            {
                MessageBox.Show("Ambas contraseñas deben ser iguales.", "Ingrese nuevamente");
            }
            else
            {
                string usuario = cmb_usuario.Text;
                con.Open();
                MySqlCommand eliminarusuario = new MySqlCommand("delete from usuario where usuario='"+usuario+"'", con);
                eliminarusuario.ExecuteNonQuery();
                con.Close();
                con.Open();
                MySqlCommand crearusuario = new MySqlCommand("insert into usuario values ('" + usuario + "', SHA1('" + txt_pass1.Text + "'))", con);
                crearusuario.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Se ha cambiado la contraseña correctamente", "Accion realizada con exito");
                Form login = new Login();
                this.Hide();
            }
        }
    }
}
