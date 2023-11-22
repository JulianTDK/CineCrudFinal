namespace CineFront
{
    partial class frmConsultarComprobantes
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
            cboClientes = new ComboBox();
            btnConsultar = new Button();
            label1 = new Label();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            dgvComprobantes = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colFecAlta = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colCantEntradas = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewComboBoxColumn();
            btnSalir = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvComprobantes).BeginInit();
            SuspendLayout();
            // 
            // cboClientes
            // 
            cboClientes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(231, 106);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(353, 25);
            cboClientes.TabIndex = 2;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultar.Location = new Point(593, 106);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(220, 25);
            btnConsultar.TabIndex = 15;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(171, 109);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 12;
            label1.Text = "Cliente:";
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(593, 57);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(220, 25);
            dtpHasta.TabIndex = 9;
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(269, 57);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(220, 25);
            dtpDesde.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(498, 60);
            label5.Name = "label5";
            label5.Size = new Size(86, 19);
            label5.TabIndex = 7;
            label5.Text = "Fecha Hasta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(171, 60);
            label4.Name = "label4";
            label4.Size = new Size(89, 19);
            label4.TabIndex = 6;
            label4.Text = "Fecha Desde:";
            // 
            // dgvComprobantes
            // 
            dgvComprobantes.AllowUserToAddRows = false;
            dgvComprobantes.AllowUserToDeleteRows = false;
            dgvComprobantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComprobantes.Columns.AddRange(new DataGridViewColumn[] { colId, colFecAlta, colCliente, colCantEntradas, colPrecio, colAcciones });
            dgvComprobantes.Location = new Point(171, 156);
            dgvComprobantes.Name = "dgvComprobantes";
            dgvComprobantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComprobantes.Size = new Size(643, 250);
            dgvComprobantes.TabIndex = 10;
            // 
            // colId
            // 
            colId.HeaderText = "Id (Sacar)";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colFecAlta
            // 
            colFecAlta.HeaderText = "Fecha de Alta";
            colFecAlta.Name = "colFecAlta";
            colFecAlta.ReadOnly = true;
            // 
            // colCliente
            // 
            colCliente.HeaderText = "Cliente";
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            // 
            // colCantEntradas
            // 
            colCantEntradas.HeaderText = "Cant. de Entradas";
            colCantEntradas.Name = "colCantEntradas";
            colCantEntradas.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio Total";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "Acciones";
            colAcciones.Items.AddRange(new object[] { "Ver", "Editar" });
            colAcciones.Name = "colAcciones";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(455, 426);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(407, 17);
            label2.Name = "label2";
            label2.Size = new Size(181, 21);
            label2.TabIndex = 16;
            label2.Text = "Consultar comprobantes";
            // 
            // frmConsultarComprobantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(label2);
            Controls.Add(cboClientes);
            Controls.Add(btnConsultar);
            Controls.Add(dgvComprobantes);
            Controls.Add(label1);
            Controls.Add(dtpHasta);
            Controls.Add(btnSalir);
            Controls.Add(dtpDesde);
            Controls.Add(label4);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmConsultarComprobantes";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ConsultarComprobantes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComprobantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Label label5;
        private Label label4;
        private DataGridView dgvComprobantes;
        private Label label1;
        private Button btnConsultar;
        private Button btnSalir;
        private ComboBox cboClientes;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colFecAlta;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colCantEntradas;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewComboBoxColumn colAcciones;
        private Label label2;
    }
}