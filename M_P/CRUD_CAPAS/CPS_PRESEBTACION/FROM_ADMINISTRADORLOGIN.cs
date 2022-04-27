using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPS_NEGOCIO;

namespace CPS_PRESEBTACION
{
    public partial class FROM_ADMINISTRADORLOGIN : Form
    {
        public FROM_ADMINISTRADORLOGIN()
        {
            InitializeComponent();
        }
        NEGOCIO_ADMINITRADOR_LOGIN objetoNegocio = new NEGOCIO_ADMINITRADOR_LOGIN();
        private string id_login = null;
        private void FROM_ADMINISTRADORLOGIN_Load(object sender, EventArgs e)
        {
            motrar_adminitrador_login();
        }

        private void motrar_adminitrador_login()
        {
            NEGOCIO_ADMINITRADOR_LOGIN objetoNegocio = new NEGOCIO_ADMINITRADOR_LOGIN();
            dataGridView1.DataSource = objetoNegocio.mostrad_adminitrador_login();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                id_login = dataGridView1.CurrentRow.Cells["Numero"].Value.ToString();
                objetoNegocio.eliminar(id_login);
                MessageBox.Show("Cuenta eliminada Correctamente");
                motrar_adminitrador_login();
            }
            else
            {
                MessageBox.Show("Selecione una fila porfavor");
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(this.dataGridView1.Columns[e.ColumnIndex].Name== "Cargo")
            {
                if(Convert.ToString(e.Value)== "administrador")
                {
                    e.CellStyle.ForeColor = Color.DarkOrange;
                }
                if (Convert.ToString(e.Value) == "usuario_principal")
                {
                    e.CellStyle.ForeColor = Color.DarkMagenta;
                }
                if (Convert.ToString(e.Value) == "usuario_secundario")
                {
                    e.CellStyle.ForeColor = Color.DarkGreen;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
