using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Proyecto_Warescape
{
    class Email
    {
        public int Enviar(string receptor)
        {
            string emisor = "warescapesrl2@gmail.com";
            string password = "libreria33";
            
            Random r = new Random();
            // va a devolver un numero minimo y un maximo.
            int num = r.Next(100000, 1000000);
            //

            MailMessage msg = new MailMessage();

            if (receptor.Equals(""))
            {
                MessageBox.Show("Debe ingresar un correo valido", "Error");
                num = 0;
                return num;
            }
            else
            {
                msg.To.Add(receptor);
                msg.Subject = "Correo de verificacion // Warescape";
                msg.SubjectEncoding = Encoding.UTF8;
                msg.Body = "El codigo de verificacion es " + num + " por favor ingreselo";
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.From = new MailAddress(emisor);
                // Aca se le da permiso a C# para uso de terceros.
                SmtpClient client = new SmtpClient();
                // 

                // Se "inicializan" las credenciales del correo para que C# pueda entrar a el msimo sion dificultades.
                client.Credentials = new NetworkCredential(emisor, password);
                //
                client.Port = 587;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";

                try
                {
                    client.Send(msg);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se envio el correo correctamente, por favor verifique.");
                    num = 0;
                }
                return num;
            }
        }
    }
}
