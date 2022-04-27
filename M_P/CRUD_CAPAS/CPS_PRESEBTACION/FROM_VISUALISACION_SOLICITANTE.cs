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
    public partial class FROM_VISUALISACION_SOLICITANTE : Form
    {
        NEGOCIO_SOLICITANTE objet_N = new NEGOCIO_SOLICITANTE();
        public FROM_VISUALISACION_SOLICITANTE()
        {
            InitializeComponent();
        }

       public void mostrar_visulacisacion()
        {
            dataGridView_visulisacion.DataSource = objet_N.mostrad_solitante();
        }

        private void FROM_VISUALISACION_SOLICITANTE_Load(object sender, EventArgs e)
        {
            mostrar_visulacisacion();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NEGOCIO_SOLICITANTE estudiante1 = new NEGOCIO_SOLICITANTE();
            //instanciamos la clase dataset
            DataSet almasenar = new DataSet();
            //llenamos de valores el dataset
            estudiante1.buscada_solicitante(textBox1.Text).Fill(almasenar);//FILL ES UN METODO es un objeto dataset
            dataGridView_visulisacion.DataSource = almasenar.Tables[0];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {










        }
    }
}
