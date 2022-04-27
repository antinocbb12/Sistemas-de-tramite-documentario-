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
    public class NEGOCIO_DOCUMENTO
    {
        private DATOS_DOCUMENTO objeto_dato = new DATOS_DOCUMENTO();
        private DATO_CONEXION objeto_conex = new DATO_CONEXION();
        SqlDataReader lee;
        SqlCommand comando = new SqlCommand();

        public DataTable mostrad_documento()
        {
            DataTable table = new DataTable();
            table = objeto_dato.datos_mostradp();
            return table;
        }
        public DataTable mostrad_listado()
        {
            DataTable table = new DataTable();
            table = objeto_dato.mostrar_listado();
            return table;
        }
       
        public DataTable negocio_doctorado()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_dato.datos_doctorado();
            return tabla;
        }
        public DataTable negocio_salud()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_dato.datos_salud();
            return tabla;
        }
        public DataTable negocio_ciencias()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_dato.datos_cienciaso();
            return tabla;
        }
        public DataTable negocio_ingenieria()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_dato.datos_inegieria();
            return tabla;
        }
        public DataTable negocio_sede()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_dato.datos_sede();
            return tabla;
        }
        public DataTable negocio_otros()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_dato.datos_otros();
            return tabla;
        }
        public SqlDataAdapter buscada_documentacion(string filtro)
        {
            comando.Connection = objeto_conex.abrirconexion();
            SqlCommand da = new SqlCommand("select dq.id_documento_isquierdo,Asunto_Documento,Observaciones,Doctorado,Facultad_Ciencias,Facultad_Ingenieria , Facultad_Salud, Nombres, Filial, id_documento_derecho from documento_derecho dr inner join documento_isquierdo dq on dq.id_documento_isquierdo = dr.id_documento_isquierdo inner join P_doctorado pd on pd.id_doctorado = dr.id_doctorado inner join P_ciencias ci on ci.id_ciencias = dr.id_ciencias inner  join P_salud ps on ps.id_salud = dr.id_salud inner join P_ingenieria pim on pim.id_ingenieria = dr.id_ingenieria inner join P_otros po on po.id_otros = dr.id_otros inner join P_sede ped on ped.id_sede = dr.id_sede  where dq.id_documento_isquierdo like '" + filtro + "%'", objeto_conex.abrirconexion());
            /* comando.CommandType = CommandType.StoredProcedure;
             comando.Parameters.AddWithValue("@filtro", filtro);*/
            SqlDataAdapter ejecutar = new SqlDataAdapter(da);
            comando.Parameters.Clear();
            return ejecutar;

        }
        public SqlDataAdapter buscada_listado(string filtro)
        {
            comando.Connection = objeto_conex.abrirconexion();
            SqlCommand da = new SqlCommand("select N_Correlativa,fecha,N_Mesa_Partes,tipo_documento,N_Documento,Folio,Procedencia_Documento, Asunto_Documento, Observaciones, Doctorado, Facultad_Ciencias, Facultad_Ingenieria, Facultad_Salud, Nombres, Filial from documento_derecho dr inner join documento_isquierdo dq on dq.id_documento_isquierdo = dr.id_documento_isquierdo inner join P_doctorado pd on pd.id_doctorado = dr.id_doctorado inner join P_ciencias ci on ci.id_ciencias = dr.id_ciencias inner join P_salud ps on ps.id_salud = dr.id_salud  inner  join P_ingenieria pim on pim.id_ingenieria = dr.id_ingenieria  inner join P_otros po on po.id_otros = dr.id_otros inner join P_sede ped on ped.id_sede = dr.id_sede inner join tipo_docume qq on qq.id_tipodocumento = dq.id_tipodocumento  where N_Documento like '" + filtro + "%'", objeto_conex.abrirconexion());
            /* comando.CommandType = CommandType.StoredProcedure;
             comando.Parameters.AddWithValue("@filtro", filtro);*/
            SqlDataAdapter ejecutar = new SqlDataAdapter(da);
            comando.Parameters.Clear();
            return ejecutar;

        }
        public void insertar_negocio_documetacion(string asunto, string observacion, int doctorado, int ciencia, int salud, int sede, int otros, int inenieria, int isuiqedo)
        {
            objeto_dato.insertar_documento( asunto,observacion, Convert.ToInt32(doctorado), Convert.ToInt32(ciencia), Convert.ToInt32(salud), Convert.ToInt32(sede), Convert.ToInt32(otros), Convert.ToInt32(inenieria), Convert.ToInt32(isuiqedo));
        }
        public void editar_documentacion_negocio(string asunto, string observacion, int doctorado, int ciencia, int salud, int sede, int otros, int inenieria, int isuiqedo, int id)
        {
            objeto_dato.editae_documento_datos(asunto, observacion, Convert.ToInt32(doctorado), Convert.ToInt32(ciencia), Convert.ToInt32(salud), Convert.ToInt32(sede), Convert.ToInt32(otros), Convert.ToInt32(inenieria), Convert.ToInt32(isuiqedo), Convert.ToInt32(id));
        }
        public void eliminar_documentacion_negocio(string id)
        {
            objeto_dato.eliminar_doatos(Convert.ToInt32(id));
        }

    }
}
