using CineBack.Datos;
using CineBack.Dominio;
using CineBack.Servicios;
using CineBack.Servicios.Interfaz;
using CineFront.ClienteSing;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

namespace CineFront
{
    public enum AccionCli
    {
        New,
        Upd,
        Rid
    }

    public partial class frmClienteAM : Form
    {
        private AccionCli modo;
        private IServicio serv;
        Cliente oCliente = new Cliente();

        public frmClienteAM(AccionCli modo, int id)
        {
            InitializeComponent();
            serv = new FactoryServiceImp().CrearServicio();
            this.modo = modo;
            oCliente.Id = id;

            if (modo.Equals(AccionCli.New))
            {
                this.Text = "Nuevo Cliente";
                dtpFecNac.Value = DateTime.Now.AddYears(-15);
                rbtHombre.Checked = true;
                chkBaja.Enabled = false;
            }

            if (modo.Equals(AccionCli.Upd))
            {
                this.Text = "Actualizar Cliente";
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtDni.Enabled = false;
                dtpFecNac.Enabled = false;
                rbtHombre.Enabled = false;
                rbtMujer.Enabled = false;
            }

            if (modo.Equals(AccionCli.Rid))
            {
                this.Text = "Ver Cliente";
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtDni.Enabled = false;
                dtpFecNac.Enabled = false;
                txtTelefono.Enabled = false;
                txtMail.Enabled = false;
                txtCalle.Enabled = false;
                txtNro.Enabled = false;
                cboBarrios.Enabled = false;
                cboTiposClientes.Enabled = false;
                rbtHombre.Enabled = false;
                rbtMujer.Enabled = false;
                chkBaja.Enabled = false;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarBarrrios();
            await CargarTiposClientes();

            if (modo.Equals(AccionCli.Upd) || modo.Equals(AccionCli.Rid))
            {
                await this.CargarCliente(oCliente.Id);
            }

            if (modo.Equals(AccionCli.Upd))
            {
                chkBaja.Enabled = oCliente.FechaBaja != null;
            }
        }

        private async Task CargarBarrrios()
        {
            string url = "https://localhost:7218/api/Cine/Barrios";
            var bodyJson = await ClienteSgl.GetInstance().GetAsync(url);

            List<Barrio> lBarrios = JsonConvert.DeserializeObject<List<Barrio>>(bodyJson);

            cboBarrios.DataSource = lBarrios;
            cboBarrios.ValueMember = "IdBarrio";
            cboBarrios.DisplayMember = "Nombre";
            cboBarrios.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task CargarTiposClientes()
        {
            string url = "https://localhost:7218/api/Cine/TiposClientes";
            var bodyJson = await ClienteSgl.GetInstance().GetAsync(url);

            List<TipoCliente> lTiposClientes = JsonConvert.DeserializeObject<List<TipoCliente>>(bodyJson);

            cboTiposClientes.DataSource = lTiposClientes;
            cboTiposClientes.ValueMember = "IdTipoCliente";
            cboTiposClientes.DisplayMember = "NombreTipoCliente";
            cboTiposClientes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task CargarCliente(int? id)
        {
            List<Parametro> lFiltros = new List<Parametro>();
            lFiltros.Add(new Parametro("@id_cliente", id));

            string url = "https://localhost:7218/api/Cine/CargarCliente";
            string filtrosJson = JsonConvert.SerializeObject(lFiltros);
            var bodyJson = await ClienteSgl.GetInstance().PostAsync(url, filtrosJson);

            oCliente = JsonConvert.DeserializeObject<Cliente>(bodyJson);

            txtNombre.Text = oCliente.Nombre;
            txtApellido.Text = oCliente.Apellido;
            txtDni.Text = oCliente.Dni.ToString();
            dtpFecNac.Value = oCliente.FechaNac;
            txtTelefono.Text = oCliente.Telefono;
            txtMail.Text = oCliente.Mail;
            txtCalle.Text = oCliente.Calle;
            txtNro.Text = oCliente.Nro.ToString();
            cboBarrios.SelectedValue = oCliente.IdBarrio;
            cboTiposClientes.SelectedValue = oCliente.IdTipoCliente;
            rbtHombre.Checked = oCliente.IdGeneroCliente == 1;
            rbtMujer.Checked = oCliente.IdGeneroCliente == 2;
            chkBaja.Checked = oCliente.FechaBaja != null;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtNombre.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ingresa un nombre valido capo.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (txtApellido.Text.Trim() == "" || txtApellido.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ingresa un apellido valido capo.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (txtDni.Text.Trim() == "" || !int.TryParse(txtDni.Text, out _))
            {
                MessageBox.Show("Ingresa un DNI valido capo.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (dtpFecNac.Value > DateTime.Now.AddYears(-15))
            {
                MessageBox.Show("Fecha de nacimiento inválida. Por favor, verifica e ingresa una fecha válida para continuar.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (txtMail.Text.Trim() == "" && txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico o número de teléfono validos.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (txtCalle.Text.Trim() == "" || txtCalle.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingresa una calle valida.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (txtNro.Text.Trim() == "" || !int.TryParse(txtNro.Text, out _))
            {
                MessageBox.Show("Por favor, ingresa un nro. de calle valido.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (modo.Equals(AccionCli.New))
            {
                await SaveCliente();
            }

            if (modo.Equals(AccionCli.Upd))
            {
                await ModificarCliente();
                this.Dispose();
            }

            if (modo.Equals(AccionCli.Rid))
            {
                this.Dispose();
            }

            ResetearCampos();
        }

        private async Task SaveCliente()
        {
            LoadCliente();

            string url = "https://localhost:7218/api/Cine/Clientes";
            string clienteJson = JsonConvert.SerializeObject(oCliente);
            var bodyJson = await ClienteSgl.GetInstance().PostAsync(url, clienteJson);

            MessageBox.Show(bodyJson, "Estado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private async Task ModificarCliente()
        {
            LoadCliente();

            string url = "https://localhost:7218/api/Cine/ActualizarCliente";
            string clienteJson = JsonConvert.SerializeObject(oCliente);
            var bodyJson = await ClienteSgl.GetInstance().PutAsync(url, clienteJson);

            MessageBox.Show(bodyJson, "Estado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void LoadCliente()
        {
            oCliente.Nombre = txtNombre.Text;
            oCliente.Apellido = txtApellido.Text;
            oCliente.Dni = Convert.ToInt32(txtDni.Text);
            oCliente.FechaNac = dtpFecNac.Value;
            oCliente.Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? DBNull.Value.ToString() : txtTelefono.Text;
            oCliente.Mail = string.IsNullOrWhiteSpace(txtMail.Text) ? DBNull.Value.ToString() : txtMail.Text;
            oCliente.Calle = txtCalle.Text;
            oCliente.Nro = Convert.ToInt32(txtNro.Text);
            oCliente.IdBarrio = Convert.ToInt32(cboBarrios.SelectedValue);
            oCliente.IdTipoCliente = Convert.ToInt32(cboTiposClientes.SelectedValue);
            oCliente.IdGeneroCliente = rbtHombre.Checked ? 1 : (rbtMujer.Checked ? 2 : 3);
            oCliente.FechaBaja = !chkBaja.Checked ? (DateTime?)null : oCliente.FechaBaja;
        }

        private void ResetearCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            dtpFecNac.Value = DateTime.Now.AddYears(-15);
            txtTelefono.Text = "";
            txtMail.Text = "";
            txtCalle.Text = "";
            txtNro.Text = "";
            cboBarrios.SelectedIndex = 0;
            cboTiposClientes.SelectedIndex = 0;
            rbtHombre.Checked = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (modo.Equals(AccionCli.New) || modo.Equals(AccionCli.Upd))
            {
                if (MessageBox.Show("¿Está seguro de que desea cancelar el registro? Al hacerlo, perderá todos los datos ingresados hasta el momento.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }

            else
                this.Dispose();
        }
    }
}