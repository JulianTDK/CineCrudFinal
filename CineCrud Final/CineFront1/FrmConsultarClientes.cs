using CineBack.Datos;
using CineBack.Dominio;
using CineBack.Servicios;
using CineBack.Servicios.Interfaz;
using CineFront.ClienteSing;
using CineFront1;
using Newtonsoft.Json;
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
    public partial class frmConsultarClientes : Form
    {
        public IServicio serv;

        public frmConsultarClientes()
        {
            InitializeComponent();
            serv = new FactoryServiceImp().CrearServicio();
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Parametro> lFiltros = new List<Parametro>();

            object valor = !string.IsNullOrEmpty(txtNombre.Text) ? txtNombre.Text : DBNull.Value;
            lFiltros.Add(new Parametro("@nombre", valor));
            valor = !string.IsNullOrEmpty(txtApellido.Text) ? txtApellido.Text : DBNull.Value;
            lFiltros.Add(new Parametro("@apellido", valor));
            valor = !string.IsNullOrEmpty(txtDni.Text) ? txtDni.Text : DBNull.Value;
            lFiltros.Add(new Parametro("@dni", valor));
            valor = chkInactivo.Checked ? "S" : DBNull.Value;
            lFiltros.Add(new Parametro("@inactivo", valor));
            valor = chkBaja.Checked ? "S" : DBNull.Value;
            lFiltros.Add(new Parametro("@baja", valor));

            string url = "https://localhost:7218/api/Cine/CargarClientes";
            string filtrosJson = JsonConvert.SerializeObject(lFiltros);
            var bodyJson = await ClienteSgl.GetInstance().PostAsync(url, filtrosJson);

            List<Cliente> lClientes = null;
            lClientes = JsonConvert.DeserializeObject<List<Cliente>>(bodyJson);

            dgvClientes.Rows.Clear();

            foreach (Cliente oC in lClientes)
            {
                dgvClientes.Rows.Add(new object[] { oC.Id, oC.Nombre, oC.Apellido, oC.Dni, oC.Telefono, oC.Mail, oC.TipoCliente, oC.FechaBaja });
            }

            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                DataGridViewComboBoxCell cboCell = (DataGridViewComboBoxCell)row.Cells[8];
                cboCell.Value = cboCell.Items[0];
            }

            dgvClientes.EditingControlShowing += dgvClientes_EditingControlShowing;
        }

        private void dgvClientes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox cbo)
            {
                cbo.MouseDown -= cbo_MouseDown;
                cbo.MouseDown += cbo_MouseDown;
            }
        }

        private async void cbo_MouseDown(object sender, MouseEventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;

            if (e.Button == MouseButtons.Left)
            {
                Rectangle dropdownButtonBounds =
                    new Rectangle(cbo.Width - SystemInformation.VerticalScrollBarWidth, 0, SystemInformation.VerticalScrollBarWidth, cbo.Height);

                if (!dropdownButtonBounds.Contains(e.Location))
                {
                    if (cbo.SelectedItem.ToString().Equals("Ver"))
                    {
                        int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["colId"].Value.ToString());
                        frmClienteAM frm = new frmClienteAM(AccionCli.Rid, id);
                        frm.ShowDialog();
                    }

                    if (cbo.SelectedItem.ToString().Equals("Editar"))
                    {
                        int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["colId"].Value.ToString());
                        frmClienteAM frm = new frmClienteAM(AccionCli.Upd, id);
                        frm.ShowDialog();
                        this.btnConsultar_Click(null, null);
                    }

                    if (cbo.SelectedItem.ToString().Equals("Dar de Baja"))
                    {
                        DataGridViewRow row = dgvClientes.CurrentRow;

                        if (row != null)
                        {
                            string id = row.Cells["colId"].Value.ToString();

                            if (MessageBox.Show("¿Seguro que desea dar de baja a el cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                string url = "https://localhost:7218/api/Cine/BajaCliente?id=" + id;
                                var bodyJson = await ClienteSgl.GetInstance().DeleteAsync(url);
                                MessageBox.Show(bodyJson, "Estado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                this.btnConsultar_Click(null, null);
                            }
                        }
                    }
                }
            }
        }

        private void chkInactivo_Click(object sender, EventArgs e)
        {
            chkBaja.Checked = false;
        }

        private void chkBaja_Click(object sender, EventArgs e)
        {
            chkInactivo.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
