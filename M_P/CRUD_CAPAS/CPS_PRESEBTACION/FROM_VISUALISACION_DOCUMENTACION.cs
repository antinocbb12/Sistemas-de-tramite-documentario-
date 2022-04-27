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
    public partial class FROM_VISUALISACION_DOCUMENTACION : Form
    {
        NEGOCIO_DOCUMENTO objet_N = new NEGOCIO_DOCUMENTO();
        public FROM_VISUALISACION_DOCUMENTACION()
        {
            InitializeComponent();
        }

        private void FROM_VISUALISACION_DOCUMENTACION_Load(object sender, EventArgs e)
        {
            mostrar_visulacisacion();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void mostrar_visulacisacion()
        {
            dataGridView_visulisacion.DataSource = objet_N.mostrad_documento();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NEGOCIO_DOCUMENTO estudiante1 = new NEGOCIO_DOCUMENTO();
            //instanciamos la clase dataset
            DataSet almasenar = new DataSet();
            //llenamos de valores el dataset
            estudiante1.buscada_documentacion(textBox1.Text).Fill(almasenar);//FILL ES UN METODO es un objeto dataset
            dataGridView_visulisacion.DataSource = almasenar.Tables[0];
        }
    }
}
