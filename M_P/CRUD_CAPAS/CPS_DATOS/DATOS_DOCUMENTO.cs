using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CPS_DATOS
{
    public class DATOS_DOCUMENTO
    {
        private DATO_CONEXION conexion = new DATO_CONEXION();
        private SqlDataReader leer;
        SqlCommand comando = new SqlCommand();


        public DataTable datos_mostradp()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "mostrar_documentaciom";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            conexion.cerrarconexion();
            return table;
        }
       
        public DataTable datos_doctorado()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "doctorado";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            conexion.cerrarconexion();
            return table;
        }
        public DataTable datos_salud()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "salud";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            conexion.cerrarconexion();
            return table;
        }
        public DataTable datos_inegieria()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "ingenieria";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            conexion.cerrarconexion();
            return table;
        }
        public DataTable datos_sede()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "sede";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            conexion.cerrarconexion();
            return table;
        }
        public DataTable datos_otros()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "otros";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            conexion.cerrarconexion();
            return table;
        }
        public DataTable datos_cienciaso()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "ciencias";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            conexion.cerrarconexion();
            return table;
        }
        public void insertar_documento(string asunto, string observacion, int doctorado, int ciencia, int salud,int sede, int otros, int inenieria, int isuiqedo)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "insertrar_documento_derecho";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@asunto", asunto);
            comando.Parameters.AddWithValue("@obeservacion", observacion);
            comando.Parameters.AddWithValue("@doctorado", doctorado);
            comando.Parameters.AddWithValue("@ciencia", ciencia);
            comando.Parameters.AddWithValue("@salud ", salud);
            comando.Parameters.AddWithValue("@sede", sede);
            comando.Parameters.AddWithValue("@otros", otros);
            comando.Parameters.AddWithValue("@inieria ", inenieria);
            comando.Parameters.AddWithValue("@solicitante", isuiqedo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void editae_documento_datos(string asunto, string observacion, int doctorado, int ciencia, int salud, int sede, int otros, int inenieria, int isuiqedo ,int id)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "editar_documenderecho";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@asunto", asunto);
            comando.Parameters.AddWithValue("@obeservacion", observacion);
            comando.Parameters.AddWithValue("@doctorado", doctorado);
            comando.Parameters.AddWithValue("@ciencia", ciencia);
            comando.Parameters.AddWithValue("@salud ", salud);
            comando.Parameters.AddWithValue("@sede", sede);
            comando.Parameters.AddWithValue("@otros", otros);
            comando.Parameters.AddWithValue("@inieria ", inenieria);
            comando.Parameters.AddWithValue("@solicitante", isuiqedo);
            comando.Parameters.AddWithValue("@doderecha ", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void eliminar_doatos(int id)
        {
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "elimar_documetderecha";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_docum", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public DataTable mostrar_listado()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.abrirconexion();
            comando.CommandText = "repomotrar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarconexion();
            return tabla;
        }

    }
}
