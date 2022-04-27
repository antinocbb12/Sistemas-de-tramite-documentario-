using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPS_DATOS;
using System.Data.SqlClient;
using System.Data;

namespace CPS_NEGOCIO
{
   public class NEGOCIO_LOGIN
    {
        private DATOS_LOGIN objeto_datosN = new DATOS_LOGIN();
        private string _usuario;
        private string _password;

        public string usuario
        {
            set { _usuario = value; }
            get { return _usuario; }
        }
        public string contraseña
        {
            set { _password = value; }
            get { return _password; }
        }
        public SqlDataReader iniciarsecion()
        {
            SqlDataReader loguear;
            loguear = objeto_datosN.iniciarsecion(usuario,contraseña);
            return loguear;
        }
        public DataTable negocio_cargo()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_datosN.datos_cargo();
            return tabla;
        }

        public string recpass(string usuario)
        {
            string mensaje;
            mensaje = objeto_datosN.recuperarcntraseña(usuario);
            return mensaje;
                }

        public void insertar_logeo_negocio(string usuario, string passowr, string nombre, string apellido, int cargo, string email,string codigo)
        {
            objeto_datosN.insetar_resgtor_login(usuario, passowr, nombre, apellido, Convert.ToInt32(cargo), email,codigo);
        }
    }
}
