using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPS_PRESEBTACION
{
    public partial class FROM_ESCANER : Form
    {
        ESCANER img = new ESCANER();
        public FROM_ESCANER()
        {
            InitializeComponent();
        }

        private void escanrrr_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                picescaner.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void FROM_ESCANER_Load(object sender, EventArgs e)
        {
            img.abrirconxion();
            img.caragarfoto(cbmfoto);
        }

        private void cbmfoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            img.verimgen(picescaner, cbmfoto.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(img.inseratimagen(txtdocumento.Text, picescaner));
            cbmfoto.Items.Clear();
            img.caragarfoto(cbmfoto);
        }
    }
}
