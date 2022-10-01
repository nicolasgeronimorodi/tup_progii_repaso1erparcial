using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        private void darDeAltaRecetaToolStripMenuItem_Click(object sender, EventArgs e)

        {
            Form FrmAltaReceta = new FrmAltaReceta();
            FrmAltaReceta.Show();
        }

        private void consultarRecetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmConsultarRecetas = new FrmConsultarRecetas();
            FrmConsultarRecetas.Show();
        }
    }
}
