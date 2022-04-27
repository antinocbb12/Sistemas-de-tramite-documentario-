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
    public partial class FROM_EXPEDIENTE : Form
    {
        public FROM_EXPEDIENTE()
        {
            InitializeComponent();
        }
        NEGOCIO_SOLICITANTE objeto_N = new NEGOCIO_SOLICITANTE();

        /*
        private void txtnombre_Enter(object sender, EventArgs e)
        {
            if (txtnombre.Text == "Nombres")
            {
                txtnombre.Text = "";
                txtnombre.ForeColor = Color.Black;

            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                txtnombre.Text = "Nombres";
                txtnombre.ForeColor = Color.Black;
            }
        }

        private void txtapellido_Enter(object sender, EventArgs e)
        {
            if (txtapellido.Text == "Apellidos")
            {
                txtapellido.Text = "";
                txtapellido.ForeColor = Color.Black;

            }
        }

        private void txtapellido_Leave(object sender, EventArgs e)
        {
            if (txtapellido.Text == "")
            {
                txtapellido.Text = "Apellidos";
                txtapellido.ForeColor = Color.Black;
            }
        }

    */
        private void abrirformulario_ducmento<MIFORM_ducmento>() where MIFORM_ducmento : Form, new()
        {
            Form formulario;
            formulario = PANEL_DDD.Controls.OfType<MIFORM_ducmento>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MIFORM_ducmento();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PANEL_DDD.Controls.Add(formulario);
                PANEL_DDD.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

     

     

      

        private void btnsolicitud_Click_1(object sender, EventArgs e)
        {
            abrirformulario_ducmento<FROM_SOLICITANTE>();

        }

        private void btndocumento_Click_1(object sender, EventArgs e)
        {
            abrirformulario_ducmento<FROM_DOCUMENTACION>();

        }
    }
}
