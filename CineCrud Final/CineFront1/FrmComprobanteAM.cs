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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront
{
    public enum AccionComp
    {
        New,
        Act,
        Rid
    }

    public partial class frmComprobanteAM : Form
    {
        private AccionComp modo;
        private IServicio serv;
        Comprobante oC = new Comprobante();
        List<Butaca> lButacas = new List<Butaca>();
        List<int> lButacasCopia = new List<int>();
        int btcsSeleccionadas = 0;
        int maxBtcs = 0;

        public frmComprobanteAM(AccionComp modo, int id)
        {
            InitializeComponent();
            this.modo = modo;
            serv = new FactoryServiceImp().CrearServicio();
            oC.Id = id;
            dtpFecha.Enabled = false;
            txtDescuento.Enabled = false;
            dgvDetalles.Enabled = false;
            txtSubTotal.Enabled = false;
            txtTotal.Enabled = false;

            if (modo.Equals(AccionComp.New))
            {
                this.Text = "Nuevo Comprobante";
            }

            if (modo.Equals(AccionComp.Act))
            {
                this.Text = "Actualizar Comprobante";
                cboClientes.Enabled = false;
                cboFormasPago.Enabled = false;
            }

            if (modo.Equals(AccionComp.Rid))
            {
                this.Text = "Ver Comprobante";
                cboClientes.Enabled = false;
                cboFormasPago.Enabled = false;
                btnAgregar.Enabled = false;
                btnCancelar.Enabled = false;
                flpButacas.Enabled = false;
            }
        }

        private async void frmComprobanteAM_Load(object sender, EventArgs e)
        {
            await CargarClientes();
            await CargarFunciones();
            await CargarFormasPago();

            if (modo.Equals(AccionComp.Act) || modo.Equals(AccionComp.Rid))
            {
                await this.CargarComprobante(oC.Id);
                int bandFuncion = 0;
                await CargarButacas();
                btcsSeleccionadas = flpButacas.Controls.OfType<Button>().Count(Button => Button.BackColor == SystemColors.Control);
                maxBtcs = (maxBtcs == 0) ? lButacasCopia.Count : maxBtcs;
                CalcularTotales();

                foreach (DetalleComprobante oDC in oC.DetsComprobante)
                {
                    if (oDC.Butaca.Funcion.Id != bandFuncion)
                    {
                        dgvDetalles.Rows.Add(new object[] { oDC.Butaca.Funcion.InfoFuncion, btcsSeleccionadas, btcsSeleccionadas * oDC.PrecioEntrada });
                        bandFuncion = oDC.Butaca.Funcion.Id;
                    }
                }
            }
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

        private async Task CargarFunciones()
        {
            string url = "https://localhost:7218/api/Cine/Funciones";
            var bodyJson = await ClienteSgl.GetInstance().GetAsync(url);
            List<Funcion> lFunciones = JsonConvert.DeserializeObject<List<Funcion>>(bodyJson);

            cboFunciones.DataSource = lFunciones;
            cboFunciones.ValueMember = "Id";
            cboFunciones.DisplayMember = "InfoFuncion";
            cboFunciones.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private async Task CargarFormasPago()
        {
            string url = "https://localhost:7218/api/Cine/FormasPago";
            var bodyJson = await ClienteSgl.GetInstance().GetAsync(url);
            List<FormaPago> lFormasPago = JsonConvert.DeserializeObject<List<FormaPago>>(bodyJson);

            cboFormasPago.DataSource = lFormasPago;
            cboFormasPago.ValueMember = "Id";
            cboFormasPago.DisplayMember = "Nombre";
            cboFormasPago.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboFormasPago.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private async Task CargarComprobante(int id)
        {
            List<Parametro> lFiltros = new List<Parametro>();
            lFiltros.Add(new Parametro("@id_comprobante", id));

            string url = "https://localhost:7218/api/Cine/CargarComprobante";
            string filtrosJson = JsonConvert.SerializeObject(lFiltros);
            var bodyJson = await ClienteSgl.GetInstance().PostAsync(url, filtrosJson);

            oC = JsonConvert.DeserializeObject<Comprobante>(bodyJson);

            dtpFecha.Value = oC.Fecha;
            cboClientes.SelectedValue = oC.Cliente.Id;
            cboFormasPago.SelectedValue = oC.FormaPago.Id;

            foreach (DetalleComprobante oDC in oC.DetsComprobante)
            {
                cboFunciones.SelectedValue = oDC.Butaca.Funcion.Id;
            }
        }

        private async Task CargarButacas()
        {
            Funcion oF = (Funcion)cboFunciones.SelectedItem;
            await CargarButacasBd(oF.Id);
            flpButacas.Controls.Clear();
            CargarButacasFlp();
        }

        private async Task CargarButacasBd(int id)
        {
            List<Parametro> lFiltros = new List<Parametro>();
            lFiltros.Add(new Parametro("@id_funcion", id));

            string url = "https://localhost:7218/api/Cine/CargarButacas";
            string filtrosJson = JsonConvert.SerializeObject(lFiltros);
            var bodyJson = await ClienteSgl.GetInstance().PostAsync(url, filtrosJson);

            lButacas = JsonConvert.DeserializeObject<List<Butaca>>(bodyJson);
        }

        private void CargarButacasFlp()
        {
            foreach (Butaca oBtc in lButacas)
            {
                Button oBtn = new Button();
                oBtn.Width = 30;
                oBtn.Height = 30;
                oBtn.BackColor = Color.Black;
                oBtn.Text = oBtc.Nro.ToString();
                oBtn.Click += Button_Click;
                oBtn.Tag = oBtc;

                switch (oBtc.Estado.Nombre)
                {
                    case "Libre":
                        oBtn.ForeColor = Color.Green;
                        break;
                    case "Ocupada":
                        oBtn.ForeColor = Color.Red;
                        break;
                    case "Reservada":
                        oBtn.ForeColor = Color.Yellow;
                        break;
                    default:
                        oBtn.ForeColor = Color.Black;
                        break;
                }

                if (modo.Equals(AccionComp.Act) || modo.Equals(AccionComp.Rid))
                {
                    lButacasCopia = oC.DetsComprobante.Select(DetalleComprobante => DetalleComprobante.Butaca.Id).ToList();
                }

                if (lButacasCopia.Contains(oBtc.Id))
                {
                    oBtn.BackColor = SystemColors.Control;

                    if (modo.Equals(AccionComp.Act) || modo.Equals(AccionComp.Rid))
                    {
                        if (oBtn.ForeColor == Color.Red)
                            oBtn.ForeColor = Color.Green;
                    }
                }

                flpButacas.Controls.Add(oBtn);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button oBtn = (Button)sender;
            Butaca oBtc = (Butaca)oBtn.Tag;
            DetalleComprobante oDC = null;
            DetalleComprobante oDC1 = oC.DetsComprobante.FirstOrDefault(DetalleComprobante => DetalleComprobante.Butaca.Id == oBtc.Id);

            if (oBtn.ForeColor == Color.Green)
            {
                if (dgvDetalles.Rows.Count == 0)
                {
                    if (oBtn.BackColor != SystemColors.Control)
                    {
                        If(oBtc, oBtn, oDC, oDC1);
                    }

                    else
                    {
                        Else(oBtn, oBtc, oDC, oDC1);
                    }
                }

                else
                {
                    if (oBtn.BackColor != SystemColors.Control)
                    {
                        bool todasDiferentes = true;

                        foreach (DataGridViewRow row in dgvDetalles.Rows)
                        {
                            if (row.Cells["colFuncion"].Value.ToString().Equals(cboFunciones.Text))
                            {
                                todasDiferentes = false;
                                break;
                            }
                        }

                        if (todasDiferentes)
                        {
                            If(oBtc, oBtn, oDC, oDC1);
                        }
                    }

                    else
                    {
                        Else(oBtn, oBtc, oDC, oDC1);
                    }
                }
            }

            else
                MessageBox.Show("¡Esa butaca esta ocupada o reservada daltonico/a!");
        }

        private void If(Butaca oBtc, Button oBtn, DetalleComprobante oDC, DetalleComprobante oDC1)
        {
            oBtc.Estado.Nombre = "Ocupada";
            oBtc.Funcion = (Funcion)cboFunciones.SelectedItem;

            if (oDC1 != null)
            {
                oDC = oDC1;
            }

            else
            {
                oDC = new DetalleComprobante(oBtc.Funcion.Sala.TipoSala.PrecioEntrada(), oBtc);

                if (modo.Equals(AccionComp.New))
                {
                    oC.AgregarDetalle(oDC);
                    oBtn.BackColor = SystemColors.Control;
                }

                if (modo.Equals(AccionComp.Act))
                {
                    if (oC.DetsComprobante.Count < maxBtcs)
                    {
                        oC.AgregarDetalle(oDC);
                        oBtn.BackColor = SystemColors.Control;
                    }

                    else
                    {
                        MessageBox.Show("¡Atención Cinéfilo!\n\nHas superado la cantidad de entradas permitidas. Por favor, revisa tu seleccion y ajusta la cantidad de entradas para continuar con tu compra.\n\n¡Gracias por elegirnos y disfruta de la película", "Control");
                        return;
                    }
                }
            }

            lButacasCopia.Add(oBtc.Id);
        }

        private void Else(Button oBtn, Butaca oBtc, DetalleComprobante oDC, DetalleComprobante oDC1)
        {
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["colFuncion"].Value.ToString().Equals(cboFunciones.Text))
                {
                    dgvDetalles.Rows.Remove(row);
                }
            }

            oBtn.BackColor = Color.Black;
            oBtc.Estado.Nombre = "Libre";
            oBtc.Funcion = (Funcion)cboFunciones.SelectedItem;

            if (oDC1 != null)
            {
                oDC = oDC1;
                oC.QuitarDetalle(oDC);
            }

            else
            {
                oDC = new DetalleComprobante(oBtc.Funcion.Sala.TipoSala.PrecioEntrada(), oBtc);
                oC.QuitarDetalle(oDC);
            }

            lButacasCopia.Remove(oBtc.Id);
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDescuento();
        }

        private void CargarDescuento()
        {
            Cliente oC = (Cliente)cboClientes.SelectedItem;

            switch (oC.TipoCliente)
            {
                case "Plata":
                    txtDescuento.Text = 10.ToString() + "%";
                    break;
                case "Oro":
                    txtDescuento.Text = 20.ToString() + "%";
                    break;
                case "Diamante":
                    txtDescuento.Text = 40.ToString() + "%";
                    break;
                default:
                    txtDescuento.Text = 0.ToString() + "%";
                    break;
            }
        }

        private async void cboFunciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            await CargarButacas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["colFuncion"].Value.ToString().Equals(cboFunciones.Text))
                {
                    MessageBox.Show("Esta funcion ya esta agregada", "Control");
                    return;
                }
            }

            btcsSeleccionadas = flpButacas.Controls.OfType<Button>().Count(Button => Button.BackColor == SystemColors.Control);

            if (btcsSeleccionadas == 0)
            {
                MessageBox.Show("¡Ups! Parece que olvido ingresar una entrada (^_^)");
                return;
            }


            Funcion oF = (Funcion)cboFunciones.SelectedItem;
            dgvDetalles.Rows.Add(new object[] { oF.InfoFuncion, btcsSeleccionadas, btcsSeleccionadas * oF.Sala.TipoSala.PrecioEntrada() });
            CalcularTotales();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 3)
            {


                if (dgvDetalles.CurrentRow.Cells["colFuncion"].Value.ToString().Equals(cboFunciones.Text))
                {
                    foreach (Button oBtn in flpButacas.Controls.OfType<Button>().Where(Button => Button.BackColor == SystemColors.Control))
                    {
                        oBtn.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("La funcion seleccionada es incorrecta", "Control");
                    return;
                }

                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
                CalcularTotales();
            }
        }

        private void CalcularTotales()
        {
            Double Subtotal = oC.DetsComprobante.Sum(DetalleComprobante => DetalleComprobante.PrecioEntrada);
            txtSubTotal.Text = Subtotal.ToString();
            txtTotal.Text = (txtDescuento.Text == "40%") ? (Subtotal * 0.6).ToString() : (txtDescuento.Text == "20%") ? (Subtotal * 0.8).ToString() : (txtDescuento.Text == "10%") ? (Subtotal * 0.9).ToString() : Subtotal.ToString();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Y la funcion?", "Control");
                return;
            }

            if (modo.Equals(AccionComp.New))
            {
                await SaveComprobante();
            }

            if (modo.Equals(AccionComp.Act))
            {
                await ActualizarComprobante();
                this.Dispose();
            }

            await ActualizarButaca();

            await CargarButacas();

            oC.DetsComprobante.Clear();
            dgvDetalles.Rows.Clear();
            lButacasCopia.Clear();
        }

        private async Task SaveComprobante()
        {
            oC.Cliente = (Cliente)cboClientes.SelectedItem;
            oC.FormaPago = (FormaPago)cboFormasPago.SelectedItem;

            string url = "https://localhost:7218/api/Cine/Comprobante";
            string comprobanteJson = JsonConvert.SerializeObject(oC);
            var bodyJson = await ClienteSgl.GetInstance().PostAsync(url, comprobanteJson);

            MessageBox.Show(bodyJson);
        }

        private async Task ActualizarComprobante()
        {
            string url = "https://localhost:7218/api/Cine/ActualizarComprobante";
            string comprobanteJson = JsonConvert.SerializeObject(oC);
            var bodyJson = await ClienteSgl.GetInstance().PutAsync(url, comprobanteJson);

            MessageBox.Show(bodyJson);
        }

        private async Task ActualizarButaca()
        {
            oC.Cliente = (Cliente)cboClientes.SelectedItem;
            oC.FormaPago = (FormaPago)cboFormasPago.SelectedItem;

            string url = "https://localhost:7218/api/Cine/Butaca";
            string comprobanteJson = JsonConvert.SerializeObject(oC);
            var bodyJson = await ClienteSgl.GetInstance().PutAsync(url, comprobanteJson);

            MessageBox.Show(bodyJson);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea cancelar? Al hacerlo, perderá todos los datos ingresados hasta el momento.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
