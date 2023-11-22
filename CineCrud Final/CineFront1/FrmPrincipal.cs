using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteAM frm = new frmClienteAM(AccionCli.New, 0);
            frm.ShowDialog();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarClientes frm = new frmConsultarClientes();
            frm.ShowDialog();
        }

        private void nuevoComprobanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComprobanteAM frm = new frmComprobanteAM(AccionComp.New, 0);
            frm.ShowDialog();
        }

        private void consultarComprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarComprobantes frm = new frmConsultarComprobantes();
            frm.ShowDialog();
        }
    }
}
