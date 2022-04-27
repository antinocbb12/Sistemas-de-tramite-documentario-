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
    public partial class FROM_DOCUMENTACION : Form
    {
        public FROM_DOCUMENTACION()
        {
            InitializeComponent();
        }
        NEGOCIO_DOCUMENTO objeto_N = new NEGOCIO_DOCUMENTO();
        private string id_eliminar = null;
        private bool editar = false;
        private void mostrar_documentaciomn()
        {
            NEGOCIO_DOCUMENTO objeto_N = new NEGOCIO_DOCUMENTO();
            dataGridView.DataSource = objeto_N.mostrad_documento();

        }

        private void FROM_DOCUMENTACION_Load(object sender, EventArgs e)
        {
            mostrar_documentaciomn();
            limpiarfrom();
            listar_doctorado();
            listar_salud();
            listar_ciencias();
            listar_ingenieria();
            listar_sede();
            listar_otros();
        }
   
        private void listar_doctorado()
        {
            NEGOCIO_DOCUMENTO objto_N = new NEGOCIO_DOCUMENTO();
            cbmdoctorado.DataSource = objto_N.negocio_doctorado();
            cbmdoctorado.DisplayMember = "Doctorado";
            cbmdoctorado.ValueMember = "id_doctorado";
        }
        private void listar_salud()
        {
            NEGOCIO_DOCUMENTO objto_N = new NEGOCIO_DOCUMENTO();
            cbmsalud.DataSource = objto_N.negocio_salud();
            cbmsalud.DisplayMember = "Facultad_Salud";
            cbmsalud.ValueMember = "id_salud";
        }
        private void listar_ciencias()
        {
            NEGOCIO_DOCUMENTO objto_N = new NEGOCIO_DOCUMENTO();
            cbmciencias.DataSource = objto_N.negocio_ciencias();
            cbmciencias.DisplayMember = "Facultad_Ciencias";
            cbmciencias.ValueMember = "id_ciencias";
        }
        private void listar_ingenieria()
        {
            NEGOCIO_DOCUMENTO objto_N = new NEGOCIO_DOCUMENTO();
            cbmingenieria.DataSource = objto_N.negocio_ingenieria();
            cbmingenieria.DisplayMember = "Facultad_Ingenieria";
            cbmingenieria.ValueMember = "id_ingenieria";
        }
        private void listar_sede()
        {
            NEGOCIO_DOCUMENTO objto_N = new NEGOCIO_DOCUMENTO();
            cbmsede.DataSource = objto_N.negocio_sede();
            cbmsede.DisplayMember = "Filial";
            cbmsede.ValueMember = "id_sede";
        }
        private void listar_otros()
        {
            NEGOCIO_DOCUMENTO objto_N = new NEGOCIO_DOCUMENTO();
            cbmotras.DataSource = objto_N.negocio_otros();
            cbmotras.DisplayMember = "Nombres";
            cbmotras.ValueMember = "id_otros";
        }



        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                objeto_N.insertar_negocio_documetacion(txtobservacion.Text, textasunto.Text,Convert.ToInt32( txtusuario.Text), Convert.ToInt32(cbmdoctorado.SelectedValue), Convert.ToInt32(cbmciencias.SelectedValue), Convert.ToInt32(cbmingenieria.SelectedValue), Convert.ToInt32(cbmotras.SelectedValue), Convert.ToInt32(cbmsalud.SelectedValue), Convert.ToInt32(cbmsede.SelectedValue));

                MessageBox.Show("se registro correctamente");
                mostrar_documentaciomn();
                limpiarfrom();
            }
            if (editar == true)
            {
                objeto_N.editar_documentacion_negocio(txtobservacion.Text, textasunto.Text, Convert.ToInt32(txtusuario.Text), Convert.ToInt32(cbmdoctorado.SelectedValue), Convert.ToInt32(cbmciencias.SelectedValue), Convert.ToInt32(cbmingenieria.SelectedValue), Convert.ToInt32(cbmotras.SelectedValue), Convert.ToInt32(cbmsalud.SelectedValue), Convert.ToInt32(cbmsede.SelectedValue),Convert.ToInt32( id_eliminar));
                MessageBox.Show("se edito correctamente");
                mostrar_documentaciomn();
                limpiarfrom();
                editar = false;

            }
        }
        private void limpiarfrom()
        {
            txtusuario.Clear();
            txtobservacion.Clear();

            //cbntramitante.Clear();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FROM_SOLICITANTE frm = new FROM_SOLICITANTE();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                editar = true;
                txtusuario.Text = dataGridView.CurrentRow.Cells["id_documento_isquierdo"].Value.ToString();
                txtobservacion.Text = dataGridView.CurrentRow.Cells["Observaciones"].Value.ToString();
                textasunto.Text = dataGridView.CurrentRow.Cells["Asunto_Documento"].Value.ToString();
                cbmdoctorado.Text = dataGridView.CurrentRow.Cells["Doctorado"].Value.ToString();
                cbmingenieria.Text = dataGridView.CurrentRow.Cells["Facultad_Ingenieria"].Value.ToString();
                cbmciencias.Text = dataGridView.CurrentRow.Cells["Facultad_Ciencias"].Value.ToString();
                cbmotras.Text = dataGridView.CurrentRow.Cells["Nombres"].Value.ToString();
                cbmsalud.Text = dataGridView.CurrentRow.Cells["Facultad_Salud"].Value.ToString();
                cbmsede.Text = dataGridView.CurrentRow.Cells["Filial"].Value.ToString();
                id_eliminar = dataGridView.CurrentRow.Cells["id_documento_derecho"].Value.ToString();
            }

            else
                MessageBox.Show("selecione una fila por favor");
        }

        private void btnreliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                id_eliminar = dataGridView.CurrentRow.Cells["id_documento_derecho"].Value.ToString();
                objeto_N.eliminar_documentacion_negocio(id_eliminar);
                MessageBox.Show("eliminar correctamente");
                mostrar_documentaciomn();
            }
            else
            {
                MessageBox.Show("selecione una filea porfavor");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirformulario_visualisacion<FROM_VISUALISACION_DOCUMENTACION>();
        }
       private void abrirformulario_visualisacion<MIFORM_visualisacion>() where MIFORM_visualisacion : Form, new()
        {
            Form formulario;
            formulario = panel_dd.Controls.OfType<MIFORM_visualisacion>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MIFORM_visualisacion();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel_dd.Controls.Add(formulario);
                panel_dd.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NEGOCIO_DOCUMENTO estudiante1 = new NEGOCIO_DOCUMENTO();
            //instanciamos la clase dataset
            DataSet almasenar = new DataSet();
            //llenamos de valores el dataset
            estudiante1.buscada_documentacion(textBox1.Text).Fill(almasenar);//FILL ES UN METODO es un objeto dataset
            dataGridView.DataSource = almasenar.Tables[0];
        }
    }
    }

