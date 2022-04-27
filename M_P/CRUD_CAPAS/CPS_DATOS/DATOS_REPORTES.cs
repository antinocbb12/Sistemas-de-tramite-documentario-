using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CPS_DATOS
{
   public class DATOS_REPORTES
    {
        private DATO_CONEXION conexion = new DATO_CONEXION();
        private SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

    
        public DataTable mostrar_documento_interno()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "documento_todo";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarconexion();
            return tabla;
        }
    }
}
