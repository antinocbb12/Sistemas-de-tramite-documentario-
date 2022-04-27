using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace CPS_DATOS
{
   public class DATOS_SOLICITANTE
    {
        private DATO_CONEXION conexion = new DATO_CONEXION();
        private SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable datos_carrera()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "tipo_domun";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            conexion.cerrarconexion();
            return table;
        }
      

        public void insertar_solicitante (int correlativa ,string fecha,string mesa_partes,int tipo_documento , string documento, string folio, string procedencia)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "insertrar_documento_isiquierdo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@correlativa", correlativa);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@mesa_partes", mesa_partes);
            comando.Parameters.AddWithValue("@tipodocumento", tipo_documento);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@folio", folio);
            comando.Parameters.AddWithValue("@procedencia", procedencia);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public DataTable mostrar_solicitante()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "mostrar_documento_isquierdo";   
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarconexion();
            return tabla;
        }

        public void editae_solitante_datos (int correlativa, string fecha, string mesa_partes, int tipo_documento, string documento, string folio, string procedencia ,int id )
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "editar_documentacioisqueir";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@correlativa", correlativa);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@mesa_partes", mesa_partes);
            comando.Parameters.AddWithValue("@tipodocumento", tipo_documento);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@folio", folio);
            comando.Parameters.AddWithValue("@procedencia", procedencia);
            comando.Parameters.AddWithValue("@id_solitante ", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void eliminar_doatos(int id)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "elimar_documetacionistquierda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_docum", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
