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
    public partial class FROM_REPORTEGENERAL : Form
    {
        public FROM_REPORTEGENERAL()
        {
            InitializeComponent();
        }
        NEGOCIO_DOCUMENTO obje_N = new NEGOCIO_DOCUMENTO();

        private void FROM_REPORTEGENERAL_Load(object sender, EventArgs e)
        {
            mostrar_listadp();
        }
        public void mostrar_listadp()
        {
            dataGridView1.DataSource = obje_N.mostrad_listado();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NEGOCIO_DOCUMENTO estudiante1 = new NEGOCIO_DOCUMENTO();
            //instanciamos la clase dataset
            DataSet almasenar = new DataSet();
            //llenamos de valores el dataset
            estudiante1.buscada_listado(textBox1.Text).Fill(almasenar);//FILL ES UN METODO es un objeto dataset
            dataGridView1.DataSource = almasenar.Tables[0];
        }
    }

    
}
