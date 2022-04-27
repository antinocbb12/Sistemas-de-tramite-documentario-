using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CPS_DATOS
{
    public class DATOS_ADMINITRADOR_LOGIN
    {
        private DATO_CONEXION conexion = new DATO_CONEXION();
        SqlDataReader lee;

        SqlCommand comando = new SqlCommand();
        public DataTable mostrar_login_adminitrador()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "mostrad_adminitrador_login";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            conexion.cerrarconexion();
            return tabla;
        }

        public void eliminar (int id)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "elimar_adminitrador_login";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_login", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}

