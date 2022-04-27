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
    public partial class FROM_SOLICITANTE : Form
    {
        public FROM_SOLICITANTE()
        {
            InitializeComponent();
        }
        NEGOCIO_SOLICITANTE objetoN = new NEGOCIO_SOLICITANTE();
        private string id_eliminar = null;
        private bool editar = false;

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if(editar==false)
            {

            
                    objetoN.insertar_negocio_solicitante(Convert.ToInt32(txtcorrelativa.Text),fecha.Text, txtmesapartes.Text, Convert.ToInt32(cbmtipo.SelectedValue),txtdocumento.Text,txtfolio.Text,txtprocedecia.Text);
            MessageBox.Show("se registro correctamente");
            mostrar_solicitante();
            limpiarfrom();
            }
            if (editar == true)
            {
                objetoN.editar_solitante_negocio(Convert.ToInt32(txtcorrelativa.Text), fecha.Text, txtmesapartes.Text, Convert.ToInt32(cbmtipo.SelectedValue), txtdocumento.Text, txtfolio.Text, txtprocedecia.Text, Convert.ToInt32(id_eliminar));
                MessageBox.Show("se edito correctamente");
                mostrar_solicitante();
                limpiarfrom();
                editar = false;
            }
        }
        private void mostrar_solicitante()
        {
            NEGOCIO_SOLICITANTE objeto_N = new NEGOCIO_SOLICITANTE();
            dataGridView2.DataSource = objeto_N.mostrad_solitante();

        }

        private void FROM_SOLICITANTE_Load(object sender, EventArgs e)
        {
            listar_carreras();
            mostrar_solicitante();
        }
        private void listar_carreras()
        {
            NEGOCIO_SOLICITANTE objto_N = new NEGOCIO_SOLICITANTE();
            cbmtipo.DataSource = objto_N.negocio_carrera();
            cbmtipo.DisplayMember = "tipo_documento";
            cbmtipo.ValueMember = "id_tipodocumento";
        }
        

        private void limpiarfrom()
        {
            txtcorrelativa.Clear();
            txtdocumento.Clear();
            txtmesapartes.Clear();
            txtfolio.Clear();
            txtprocedecia.Clear();
            //cbntramitante.Clear();
        }

        private void btnreliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                id_eliminar = dataGridView2.CurrentRow.Cells["id_documento_isquierdo"].Value.ToString();
                objetoN.eliminar_solicitante_negocio(id_eliminar);
                MessageBox.Show("eliminar correctamente");
                mostrar_solicitante();
            }
            else
            {
                MessageBox.Show("selecione una filea porfavor");
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                editar = true;
                txtcorrelativa.Text = dataGridView2.CurrentRow.Cells["N_Correlativa"].Value.ToString();
                txtdocumento.Text = dataGridView2.CurrentRow.Cells["N_Documento"].Value.ToString();
                fecha.Text = dataGridView2.CurrentRow.Cells["fecha"].Value.ToString();
                txtmesapartes.Text = dataGridView2.CurrentRow.Cells["N_Mesa_Partes"].Value.ToString();
                txtprocedecia.Text = dataGridView2.CurrentRow.Cells["Procedencia_Documento"].Value.ToString();
                cbmtipo.Text = dataGridView2.CurrentRow.Cells["tipo_documento"].Value.ToString();
                id_eliminar = dataGridView2.CurrentRow.Cells["id_documento_isquierdo"].Value.ToString();
            }

            else
                MessageBox.Show("selecione una fila por favor");
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FROM_DOCUMENTACION from = Owner as FROM_DOCUMENTACION;

            from.txtusuario.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        private void abrirformulario_visualisacion<MIFORM_visualisacion>() where MIFORM_visualisacion : Form, new()
        {
            Form formulario;
            formulario = PANEL_DDD.Controls.OfType<MIFORM_visualisacion>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MIFORM_visualisacion();
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

        private void button1_Click(object sender, EventArgs e)
        {
            abrirformulario_visualisacion<FROM_VISUALISACION_SOLICITANTE>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NEGOCIO_SOLICITANTE estudiante1 = new NEGOCIO_SOLICITANTE();
            //instanciamos la clase dataset
            DataSet almasenar = new DataSet();
            //llenamos de valores el dataset
            estudiante1.buscada_solicitante(textBox1.Text).Fill(almasenar);//FILL ES UN METODO es un objeto dataset
            dataGridView2.DataSource = almasenar.Tables[0];
        }
    }
    }

