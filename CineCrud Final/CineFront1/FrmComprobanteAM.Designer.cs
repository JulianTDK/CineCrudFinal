namespace CineFront
{
    partial class frmComprobanteAM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpFecha = new DateTimePicker();
            cboFormasPago = new ComboBox();
            lblPago = new Label();
            lblPelicula = new Label();
            cboFunciones = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTotal = new TextBox();
            txtSubTotal = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtDescuento = new TextBox();
            label1 = new Label();
            cboClientes = new ComboBox();
            label2 = new Label();
            btnAgregar = new Button();
            flpButacas = new FlowLayoutPanel();
            dgvDetalles = new DataGridView();
            colAccion = new DataGridViewButtonColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCantEntradas = new DataGridViewTextBoxColumn();
            colFuncion = new DataGridViewTextBoxColumn();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(329, 76);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(256, 25);
            dtpFecha.TabIndex = 0;
            // 
            // cboFormasPago
            // 
            cboFormasPago.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboFormasPago.FormattingEnabled = true;
            cboFormasPago.Location = new Point(12, 176);
            cboFormasPago.Name = "cboFormasPago";
            cboFormasPago.Size = new Size(279, 25);
            cboFormasPago.TabIndex = 2;
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPago.Location = new Point(12, 154);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(105, 19);
            lblPago.TabIndex = 5;
            lblPago.Text = "Forma de Pago:";
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPelicula.Location = new Point(12, 54);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(60, 19);
            lblPelicula.TabIndex = 6;
            lblPelicula.Text = "Funcion:";
            // 
            // cboFunciones
            // 
            cboFunciones.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboFunciones.FormattingEnabled = true;
            cboFunciones.Location = new Point(12, 76);
            cboFunciones.Name = "cboFunciones";
            cboFunciones.Size = new Size(279, 25);
            cboFunciones.TabIndex = 9;
            cboFunciones.SelectedIndexChanged += cboFunciones_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(329, 104);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 19;
            label4.Text = "Descuento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 390);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 20;
            label5.Text = "SubTotal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(31, 419);
            label6.Name = "label6";
            label6.Size = new Size(41, 19);
            label6.TabIndex = 21;
            label6.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(82, 416);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 25);
            txtTotal.TabIndex = 22;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubTotal.Location = new Point(82, 387);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(100, 25);
            txtSubTotal.TabIndex = 23;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(399, 433);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 25);
            btnAceptar.TabIndex = 26;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(480, 433);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 25);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDescuento
            // 
            txtDescuento.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescuento.Location = new Point(329, 126);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(256, 25);
            txtDescuento.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 104);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 33;
            label1.Text = "Cliente:";
            // 
            // cboClientes
            // 
            cboClientes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(12, 126);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(279, 25);
            cboClientes.TabIndex = 34;
            cboClientes.SelectedIndexChanged += cboClientes_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(329, 54);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 38;
            label2.Text = "Fecha:";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(331, 176);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(254, 25);
            btnAgregar.TabIndex = 36;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // flpButacas
            // 
            flpButacas.Location = new Point(608, 54);
            flpButacas.Name = "flpButacas";
            flpButacas.Size = new Size(364, 360);
            flpButacas.TabIndex = 37;
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { colFuncion, colCantEntradas, colPrecio, colAccion });
            dgvDetalles.Location = new Point(12, 219);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowTemplate.Height = 25;
            dgvDetalles.Size = new Size(573, 162);
            dgvDetalles.TabIndex = 3;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick;
            // 
            // colAccion
            // 
            colAccion.HeaderText = "Accion";
            colAccion.Name = "colAccion";
            colAccion.ReadOnly = true;
            colAccion.Text = "Quitar";
            colAccion.UseColumnTextForButtonValue = true;
            colAccion.Visible = false;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 125;
            // 
            // colCantEntradas
            // 
            colCantEntradas.HeaderText = "Cant.  de Entradas";
            colCantEntradas.Name = "colCantEntradas";
            colCantEntradas.ReadOnly = true;
            colCantEntradas.Width = 125;
            // 
            // colFuncion
            // 
            colFuncion.HeaderText = "Funcion";
            colFuncion.Name = "colFuncion";
            colFuncion.ReadOnly = true;
            colFuncion.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(425, 17);
            label3.Name = "label3";
            label3.Size = new Size(135, 19);
            label3.TabIndex = 39;
            label3.Text = "Nuevo comprobante";
            // 
            // frmComprobanteAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(label3);
            Controls.Add(dtpFecha);
            Controls.Add(dgvDetalles);
            Controls.Add(txtDescuento);
            Controls.Add(flpButacas);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(cboFunciones);
            Controls.Add(txtSubTotal);
            Controls.Add(cboClientes);
            Controls.Add(lblPelicula);
            Controls.Add(txtTotal);
            Controls.Add(cboFormasPago);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblPago);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmComprobanteAM";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmComprobanteAM_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private ComboBox cboFormasPago;
        private Label lblPago;
        private Label lblPelicula;
        private ComboBox cboFunciones;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTotal;
        private TextBox txtSubTotal;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtDescuento;
        private Label label1;
        private ComboBox cboClientes;
        private Button btnAgregar;
        private FlowLayoutPanel flpButacas;
        private Label label2;
        private DataGridView dgvDetalles;
        private DataGridViewTextBoxColumn colFuncion;
        private DataGridViewTextBoxColumn colCantEntradas;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewButtonColumn colAccion;
        private Label label3;
    }
}