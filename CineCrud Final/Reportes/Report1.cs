using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class Report1 : Form
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cINEDataSet3.sp_cant_comp_x_cli' table. You can move, or remove it, as needed.
            this.sp_cant_comp_x_cliTableAdapter.Fill(this.cINEDataSet3.sp_cant_comp_x_cli);
            // TODO: This line of code loads data into the 'cINEDataSet._sp_peliculas___vistas' table. You can move, or remove it, as needed.
            this.sp_peliculas___vistasTableAdapter.Fill(this.cINEDataSet._sp_peliculas___vistas);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Dispose();
        }
    }
}
