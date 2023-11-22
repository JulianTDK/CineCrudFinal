using CineBack.Datos;
using CineBack.Dominio;
using CineBack.Servicios;
using CineBack.Servicios.Interfaz;
using CineFront.ClienteSing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront
{
    public partial class frmConsultarComprobantes : Form
    {
        public IServicio serv;

        public frmConsultarComprobantes()
        {
            InitializeComponent();
            serv = new FactoryServiceImp().CrearServicio();
        }

        private async void ConsultarComprobantes_Load(object sender, EventArgs e)
        {
            await CargarClientes();
            dtpDesde.Value = DateTime.Now.AddMonths(-1);
        }

        private async Task CargarClientes()
        {
            List<Parametro> lFiltros = new List<Parametro>();

            lFiltros.Add(new Parametro("@nombre", DBNull.Value));
            lFiltros.Add(new Parametro("@apellido", DBNull.Value));
            lFiltros.Add(new Parametro("dni", DBNull.Value));
            lFiltros.Add(new Parametro("inactivo", DBNull.Value));
            lFiltros.Add(new Parametro("baja", DBNull.Value));

            string url = "https://localhost:7218/api/Cine/CargarClientes";
            string filtrosJson = JsonConvert.SerializeObject(lFiltros);
            var bodyJson = await ClienteSgl.GetInstance().PostAsync(url, filtrosJson);

            List<Cliente> lClientes = JsonConvert.DeserializeObject<List<Cliente>>(bodyJson).OrderBy(oC => oC.Apellido).ToList();

            cboClientes.DataSource = lClientes;
            cboClientes.ValueMember = "Id";
            cboClientes.DisplayMember = "InfoCliente";
            cboClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboClientes.SelectedValue = 59;
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Parametro> lFiltros = new List<Parametro>();

            lFiltros.Add(new Parametro("@fecha_desde", dtpDesde.Value.Date));
            lFiltros.Add(new Parametro("@fecha_hasta", dtpHasta.Value.Date));
            lFiltros.Add(new Parametro("@id_cliente", cboClientes.SelectedValue));
            //lFiltros.Add(new Parametro("@con_final", cboClientes.SelectedIndex == 0 ? 0 : null));

            string url = "https://localhost:7218/api/Cine/CargarComprobantes";
            string filtrosJson = JsonConvert.SerializeObject(lFiltros);
            var bodyJson = await ClienteSgl.GetInstance().PostAsync(url, filtrosJson);

            List<Comprobante> lComprobantes = null;
            lComprobantes = JsonConvert.DeserializeObject<List<Comprobante>>(bodyJson);

            dgvComprobantes.Rows.Clear();

            foreach (Comprobante oC in lComprobantes)
            {
                dgvComprobantes.Rows.Add(new object[] { oC.Id, oC.Fecha, oC.Cliente.InfoCliente, oC.CantEntradas, oC.PrecioTotal });
            }

            foreach (DataGridViewRow row in dgvComprobantes.Rows)
            {
                DataGridViewComboBoxCell cboCell = (DataGridViewComboBoxCell)row.Cells[5];
                cboCell.Value = cboCell.Items[0];
            }

            dgvComprobantes.EditingControlShowing += dgvComprobantes_EditingControlShowing;
        }

        private void dgvComprobantes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox cbo)
            {
                cbo.MouseDown -= cbo_MouseDown;
                cbo.MouseDown += cbo_MouseDown;
            }
        }

        private void cbo_MouseDown(object? sender, MouseEventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;

            if (e.Button == MouseButtons.Left)
            {
                Rectangle dropdownButtonBounds =
                    new Rectangle(cbo.Width - SystemInformation.VerticalScrollBarWidth, 0, SystemInformation.VerticalScrollBarWidth, cbo.Height);

                if (!dropdownButtonBounds.Contains(e.Location))
                {
                    if (cbo.SelectedItem.ToString().Equals("Ver"))
                        MessageBox.Show("Ver");

                    if (cbo.SelectedItem.ToString().Equals("Editar"))
                    {
                        int id = Convert.ToInt32(dgvComprobantes.CurrentRow.Cells["colId"].Value.ToString());
                        frmComprobanteAM frm = new frmComprobanteAM(AccionComp.Act, id);
                        frm.ShowDialog();
                    }
                }
            }
        }
    }
}
