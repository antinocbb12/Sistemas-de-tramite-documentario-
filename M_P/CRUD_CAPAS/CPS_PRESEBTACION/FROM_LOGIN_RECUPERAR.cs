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
    public partial class FROM_LOGIN_RECUPERAR : Form
    {
        public FROM_LOGIN_RECUPERAR()
        {
            InitializeComponent();
        }
        NEGOCIO_LOGIN objeto = new NEGOCIO_LOGIN();
        private void btnrecupear_Click(object sender, EventArgs e)
        {
            txtmensaje.Text = objeto.recpass(txtusuario.Text);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
