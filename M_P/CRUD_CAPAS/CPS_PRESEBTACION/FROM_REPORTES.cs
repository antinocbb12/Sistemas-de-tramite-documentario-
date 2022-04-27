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
using System.Data.SqlClient;

namespace CPS_PRESEBTACION
{
    public partial class FROM_REPORTES : Form
    {
        public FROM_REPORTES()
        {
            InitializeComponent();
        }
        NEGOCIO_REPORTE objeto_N = new NEGOCIO_REPORTE();
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-JOV9P95;database=M_P;user=sa;password=123");
        SqlCommand cmd;
        SqlDataReader dr;

        private void dasuchuardatos()
        {
            cmd = new SqlCommand("numero", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter totalsede = new SqlParameter("@numer_sede", 0); totalsede.Direction = ParameterDirection.Output;
            SqlParameter totalsalud = new SqlParameter("@umero_salud", 0); totalsalud.Direction = ParameterDirection.Output;
            SqlParameter totalotro = new SqlParameter("@numero_otro", 0); totalotro.Direction = ParameterDirection.Output;
            SqlParameter totalingenieria = new SqlParameter("@numer_ingenieria", 0); totalingenieria.Direction = ParameterDirection.Output;
            SqlParameter totalciencias = new SqlParameter("@umero_ciencias", 0); totalciencias.Direction = ParameterDirection.Output;
            SqlParameter totaldoctorado = new SqlParameter("@numero_doctorado", 0); totaldoctorado.Direction = ParameterDirection.Output;
            SqlParameter totaltotal = new SqlParameter("@numero_total", 0); totaltotal.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(totalsede);
            cmd.Parameters.Add(totalsalud);
            cmd.Parameters.Add(totalotro);
            cmd.Parameters.Add(totalingenieria);
            cmd.Parameters.Add(totalciencias);
            cmd.Parameters.Add(totaldoctorado);
            cmd.Parameters.Add(totaltotal);


            conexion.Open();
            cmd.ExecuteNonQuery();
            lblsede.Text = cmd.Parameters["@numer_sede"].Value.ToString();
            lblsalud.Text = cmd.Parameters["@umero_salud"].Value.ToString();
            lblotros.Text = cmd.Parameters["@numero_otro"].Value.ToString();
            lblinenieria.Text = cmd.Parameters["@numer_ingenieria"].Value.ToString();
            lblciencia.Text = cmd.Parameters["@umero_ciencias"].Value.ToString();
            lbldoctrado.Text = cmd.Parameters["@numero_doctorado"].Value.ToString();
            totalpersonaaaa.Text = cmd.Parameters["@numero_total"].Value.ToString();


            conexion.Close();
        }
        private void bscarfecha_interno()
        {
            SqlDataAdapter da = new SqlDataAdapter("fecha_todo", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dateTimePicker1_interno.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.todo.DataSource = dt;
        }
    
        private void FROM_REPORTES_Load(object sender, EventArgs e)
        {
            dasuchuardatos();
            bscarfecha_interno();
        }
        public void mostrar_interno()
        {
            todo.DataSource = objeto_N.mostrad_documento_interno();
        }
       

        private void btn_interno_Click(object sender, EventArgs e)
        {
            bscarfecha_interno();

        }

      
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
