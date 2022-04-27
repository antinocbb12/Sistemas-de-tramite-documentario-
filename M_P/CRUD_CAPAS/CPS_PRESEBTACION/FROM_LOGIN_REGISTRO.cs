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
    public partial class FROM_LOGIN_REGISTRO : Form
    {
        public FROM_LOGIN_REGISTRO()
        {
            InitializeComponent();
        }
        NEGOCIO_LOGIN objetP = new NEGOCIO_LOGIN();
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "NOMBRES")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "NOMBRES";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void txtapellido_Enter(object sender, EventArgs e)
        {
            if (txtapellido.Text == "APELLIDOS")
            {
                txtapellido.Text = "";
                txtapellido.ForeColor = Color.Black;

            }
        }

        private void txtapellido_Leave(object sender, EventArgs e)
        {
            if (txtapellido.Text == "")
            {
                txtapellido.Text = "APELLIDOS";
                txtapellido.ForeColor = Color.Black;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "EMAIL")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;

            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "EMAIL";
                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;

            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {

            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.Black;
            }
        }

        private void txtpasswor_Enter(object sender, EventArgs e)
        {
            if (txtpasswor.Text == "PASSWOR")
            {
                txtpasswor.Text = "";
                txtpasswor.ForeColor = Color.Black;
                txtpasswor.UseSystemPasswordChar = true;
            }
        }

        private void txtpasswor_Leave(object sender, EventArgs e)
        {

            if (txtpasswor.Text == "")
            {
                txtpasswor.Text = "PASSWOR";
                txtpasswor.ForeColor = Color.Black;
                txtpasswor.UseSystemPasswordChar = false;
            }
        }

        private void listarcargo()
        {
            NEGOCIO_LOGIN objetoNp = new NEGOCIO_LOGIN();
            cbmcargo.DataSource = objetoNp.negocio_cargo();
            cbmcargo.DisplayMember = "cargo";
            cbmcargo.ValueMember = "id_cargo";
        }
        private void registro_login()
        {
            NEGOCIO_LOGIN bojenego = new NEGOCIO_LOGIN();
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
            if (txtcodigo.Text == "acq")
            {
                objetP.insertar_logeo_negocio(txtusuario.Text, txtpasswor.Text, textBox1.Text, txtapellido.Text, Convert.ToInt32(cbmcargo.SelectedValue), txtemail.Text,txtcodigo.Text);
                
                MessageBox.Show("se registro correctamente");
                    registro_login();

                }
                else
                MessageBox.Show("no se registro correctamente");
           }
            catch (Exception ex)
            {
                MessageBox.Show("no se puede registrar los datos por" + ex);
            }
            
        }

        private void FROM_LOGIN_REGISTRO_Load(object sender, EventArgs e)
        {
            listarcargo();
            registro_login();

        }

        private void txtcodigo_Enter(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "CODIGO")
            {
                txtcodigo.Text = "";
                txtcodigo.ForeColor = Color.Black;

            }
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                txtcodigo.Text = "CODIGO";
                txtcodigo.ForeColor = Color.Black;
            }
        }
    }
}
