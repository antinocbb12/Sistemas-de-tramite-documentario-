using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CPS_DATOS;

namespace CPS_NEGOCIO
{
    public class NEGOCIO_ADMINITRADOR_LOGIN
    {
        private DATOS_ADMINITRADOR_LOGIN objetoDATOS = new DATOS_ADMINITRADOR_LOGIN();
        public DataTable mostrad_adminitrador_login()
        {
            DataTable table = new DataTable();
            table = objetoDATOS.mostrar_login_adminitrador();
            return table;
        }
        public void eliminar(string id)
        {
            objetoDATOS.eliminar(Convert.ToInt32(id));
        }
        
    }
}
