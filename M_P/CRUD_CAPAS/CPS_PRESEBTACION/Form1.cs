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

namespace CPS_PRESEBTACION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.PANEL_PRINCIP.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(64, 64, 64));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //capturar posiones y tamaño antes de maximisar para restaur
        int lx, ly;
        int sw, sh;

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);

            btn_maximisar.Visible = true;
            btnrestaurar.Visible = false;
        }

        private void btn_maximisar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            btn_maximisar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void panel_superior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnminisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void panel_contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FROM_LOGIN objeto = new FROM_LOGIN();
            objeto.Show(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarusuarios();
        }
        private void mostrarusuarios()
        {
            if(Program.cargo == "2")
            {
                lblcargo.Text = "administrador";
            }
            if (Program.cargo == "3")
            {
                lblcargo.Text = "usuario_1Nº";
            }
            if (Program.cargo == "4")
            {
                lblcargo.Text = "usuario_2Nº";
            }
            lblnombre.Text = Program.nombre;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            panel_reportes.Visible = true;
        }

        private void btnreporte_expedinte_Click(object sender, EventArgs e)
        {
            panel_reportes.Visible = false;
            abrirformulario_adminitrador_login<FROM_REPORTES>();

        }

        private void btnreporte_escaner_Click(object sender, EventArgs e)
        {
            panel_reportes.Visible = false;
            abrirformulario_adminitrador_login<FROM_REPORTEGENERAL>();

        }

        private void btnreporte_login_Click(object sender, EventArgs e)
        {
            panel_reportes.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirformulario_adminitrador_login<FROM_EXPEDIENTE>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirformulario_adminitrador_login <FROM_ADMINISTRADORLOGIN>();
        }
        private void abrirformulario_adminitrador_login<MIFORM_administrador>() where MIFORM_administrador : Form, new()
        {
            Form formulario;
            formulario = panel_contenedor.Controls.OfType<MIFORM_administrador>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MIFORM_administrador();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel_contenedor.Controls.Add(formulario);
                panel_contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirformulario_adminitrador_login<FROM_ESCANER>();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       
    }
}
