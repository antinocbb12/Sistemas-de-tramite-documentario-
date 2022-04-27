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
    public class NEGOCIO_SOLICITANTE
    {
        private DATOS_SOLICITANTE objeto_dato = new DATOS_SOLICITANTE();
        private DATO_CONEXION objeto_conex = new DATO_CONEXION();
        SqlDataReader lee;
        SqlCommand comando = new SqlCommand();
        public void insertar_negocio_solicitante(int correlativa, string fecha, string mesa_partes, int tipo_documento, string documento, string folio, string procedencia)
        {
            objeto_dato.insertar_solicitante(Convert.ToInt32(correlativa), fecha, mesa_partes, Convert.ToInt32(tipo_documento), documento, folio, procedencia);
        }

        public DataTable negocio_carrera()
        {
            DataTable tabla = new DataTable();
            tabla = objeto_dato.datos_carrera();
            return tabla;
        }
   
        public DataTable mostrad_solitante()
        {
            DataTable table = new DataTable();
            table = objeto_dato.mostrar_solicitante();
            return table;
        }
        public void editar_solitante_negocio(int correlativa, string fecha, string mesa_partes, int tipo_documento, string documento, string folio, string procedencia, int id)
        {
            objeto_dato.editae_solitante_datos(Convert.ToInt32(correlativa), fecha, mesa_partes, Convert.ToInt32(tipo_documento), documento, folio, procedencia, Convert.ToInt32(id));
        }
        public void eliminar_solicitante_negocio(string id)
        {
            objeto_dato.eliminar_doatos(Convert.ToInt32(id));
        }
        public SqlDataAdapter buscada_solicitante(string filtro)
        {
            comando.Connection = objeto_conex.abrirconexion();
            SqlCommand da = new SqlCommand(" select id_documento_isquierdo,N_Correlativa,fecha,N_Mesa_Partes,tipo_documento,N_Documento,Folio,Procedencia_Documento from documento_isquierdo di inner join  tipo_docume td on di.id_tipodocumento = td.id_tipodocumento  where N_Documento like '" + filtro + "%'", objeto_conex.abrirconexion());
            /* comando.CommandType = CommandType.StoredProcedure;
             comando.Parameters.AddWithValue("@filtro", filtro);*/
            SqlDataAdapter ejecutar = new SqlDataAdapter(da);
            comando.Parameters.Clear();
            return ejecutar;

        }
    }
}
