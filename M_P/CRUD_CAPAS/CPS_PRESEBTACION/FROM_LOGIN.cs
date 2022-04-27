using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPS_NEGOCIO;
using System.Data.SqlClient;
using System.Data;

namespace CPS_PRESEBTACION
{
    public partial class FROM_LOGIN : Form
    {
        public FROM_LOGIN()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if(txtusuario.Text =="USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;

            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if(txtusuario.Text=="")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.Silver;
            }
        }

        private void txtpasswor_Enter(object sender, EventArgs e)
        {
            if(txtpasswor.Text=="PASSWOR")
            {
                txtpasswor.Text = "";
                txtpasswor.ForeColor = Color.LightGray;
                txtpasswor.UseSystemPasswordChar = true;
            }
        }

        private void txtpasswor_Leave(object sender, EventArgs e)
        {
            if(txtpasswor.Text=="")
            {
                txtpasswor.Text = "PASSWOR";
                txtpasswor.ForeColor = Color.Silver;
                txtpasswor.UseSystemPasswordChar = false;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_aceder_Click(object sender, EventArgs e)
        {
            NEGOCIO_LOGIN objeto_negocioP = new NEGOCIO_LOGIN();
            SqlDataReader loguear;
            objeto_negocioP.usuario = txtusuario.Text;
            objeto_negocioP.contraseña = txtpasswor.Text;
            loguear = objeto_negocioP.iniciarsecion();
            if (loguear.Read() == true)
            {
                this.Hide();
                Form1 objeto = new Form1();
                Program.cargo = loguear["id_cargo"].ToString();
                Program.nombre = loguear["nombre"].ToString();
                objeto.Show();
            }
            else
                MessageBox.Show("Usuario contraseña invalido");
        }

        private void FROM_LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
         /* METODO PARA ABRIR FORM Y CERRAR
           this.Hide();
        FROM_LOGIN_REGISTRO objeto = new FROM_LOGIN_REGISTRO();
        objeto.Show();*/
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            abrirformulario_registro_login<FROM_LOGIN_REGISTRO>();
        }

        private void abrirformulario_registro_login<MIFORM>() where MIFORM : Form, new()
        {
            Form formulario;
            formulario = panel_login_contenedor.Controls.OfType<MIFORM>().FirstOrDefault();
            if(formulario==null)
            {
                formulario = new MIFORM();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel_login_contenedor.Controls.Add(formulario);
                panel_login_contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* FROM_LOGIN_RECUPERAR frorm = new FROM_LOGIN_RECUPERAR();
            frorm.ShowDialog();
            */
            recuperar_login<FROM_LOGIN_RECUPERAR>();
        }
            private void recuperar_login<MIFORM1>() where MIFORM1 : Form, new()
        {
            Form formulario2;
            formulario2 = panel_login_contenedor.Controls.OfType<MIFORM1>().FirstOrDefault();
            if (formulario2 == null)
            {
                formulario2 = new MIFORM1();
                formulario2.TopLevel = false;
                formulario2.FormBorderStyle = FormBorderStyle.None;
                formulario2.Dock = DockStyle.Fill;
                panel_login_contenedor.Controls.Add(formulario2);
                panel_login_contenedor.Tag = formulario2;
                formulario2.Show();
                formulario2.BringToFront();
            }
        }

    }

    }

