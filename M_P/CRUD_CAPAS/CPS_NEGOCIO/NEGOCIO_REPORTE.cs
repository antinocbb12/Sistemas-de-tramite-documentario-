using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPS_DATOS;
using System.Data;
namespace CPS_NEGOCIO
{
  public  class NEGOCIO_REPORTE
    {
        private DATOS_REPORTES objeto_dato = new DATOS_REPORTES();

   
        public DataTable mostrad_documento_interno()
        {
            DataTable table = new DataTable();
            table = objeto_dato.mostrar_documento_interno();
            return table;
        }
    }
}
