using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace CPS_DATOS
{
   public class DATOS_LOGIN
    {
        private DATO_CONEXION conexion =new DATO_CONEXION();
        private SqlDataReader leer; //para leer datos 
        private string email, nombres, contraseña;
            private string mensaje;
        SqlCommand comando = new SqlCommand();

        public string recuperarcntraseña(string usuario)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "recuperar_usuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                email = leer["email"].ToString();
                nombres = leer["nombre"].ToString() + " , " + leer["apellido"].ToString(); ;
                contraseña = leer["passwordd"].ToString();
                enviar_email();
                mensaje = "Estimado" + nombres + " ,se ha enviado contraseñ asu correo:" + email + "verificar en su vandeja de entrada";
                leer.Close();
            }
            else
            {
                mensaje = "no existen datos................";
            }
            return mensaje;
        }
        public void enviar_email()
        {
            //correo
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("andisistemas12@gmail.com");
            correo.To.Add(email);
            correo.Subject = ("recuperar contraseña system");
            correo.Body = "hola, " + nombres + "usted solicito recuperar contraseña su contrseña es: " + contraseña;
            correo.Priority = MailPriority.Normal;

            //smpt servidor de correo
            SmtpClient servemail = new SmtpClient();
            servemail.Credentials = new NetworkCredential("andisistemas12@gmail.com", "cuellar12");
            servemail.Host = "smtp.gmail.com";
            servemail.Port = 587;
            servemail.EnableSsl = true;
            try
            {
                servemail.Send(correo);
            }
            catch (Exception ex)
            {

            }
            correo.Dispose();
        }

        public SqlDataReader iniciarsecion(string user,string passwor)
        {
            SqlCommand comando = new SqlCommand("admin", conexion.abrirconexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", user);
            comando.Parameters.AddWithValue("@passowor", passwor);
            leer = comando.ExecuteReader();
            return leer;
        }

        public DataTable datos_cargo()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "cargo";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            conexion.cerrarconexion();
            return table;
        }
        public void insetar_resgtor_login (string usuario,string passowr,string nombre,string apellido , int cargo , string email,string codigo )
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "insetlogin";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@passowr", passowr);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@cargo", cargo);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@codigo", codigo);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

    }
}
