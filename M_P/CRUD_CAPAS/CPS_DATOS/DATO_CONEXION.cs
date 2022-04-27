using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CPS_DATOS
{
    public class DATO_CONEXION
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-RKVOCO8;database=M_P;user=sa;password=123");
        public SqlConnection abrirconexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection cerrarconexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
