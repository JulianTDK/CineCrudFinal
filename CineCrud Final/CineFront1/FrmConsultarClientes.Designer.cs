namespace CineFront
{
    partial class frmConsultarClientes
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
            chkInactivo = new CheckBox();
            chkBaja = new CheckBox();
            btnConsultar = new Button();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvClientes = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colMail = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colFechaBaja = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewComboBoxColumn();
            btnSalir = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // chkInactivo
            // 
            chkInactivo.AutoSize = true;
            chkInactivo.CheckAlign = ContentAlignment.MiddleRight;
            chkInactivo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chkInactivo.Location = new Point(357, 107);
            chkInactivo.Name = "chkInactivo";
            chkInactivo.Size = new Size(76, 23);
            chkInactivo.TabIndex = 3;
            chkInactivo.Text = "Inactivo";
            chkInactivo.UseVisualStyleBackColor = true;
            chkInactivo.Click += chkInactivo_Click;
            // 
            // chkBaja
            // 
            chkBaja.AutoSize = true;
            chkBaja.CheckAlign = ContentAlignment.MiddleRight;
            chkBaja.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chkBaja.Location = new Point(448, 107);
            chkBaja.Name = "chkBaja";
            chkBaja.Size = new Size(74, 23);
            chkBaja.TabIndex = 4;
            chkBaja.Text = "De Baja";
            chkBaja.UseVisualStyleBackColor = true;
            chkBaja.Click += chkBaja_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultar.Location = new Point(538, 106);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(89, 25);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(642, 60);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 25);
            txtDni.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(484, 60);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 25);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(299, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 25);
            txtNombre.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(606, 63);
            label3.Name = "label3";
            label3.Size = new Size(36, 19);
            label3.TabIndex = 2;
            label3.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(424, 63);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(243, 63);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colApellido, colDni, colTelefono, colMail, colTipo, colFechaBaja, colAcciones });
            dgvClientes.Location = new Point(56, 153);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(873, 249);
            dgvClientes.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // colDni
            // 
            colDni.HeaderText = "DNI";
            colDni.Name = "colDni";
            colDni.ReadOnly = true;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Telefono";
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            // 
            // colMail
            // 
            colMail.HeaderText = "Mail";
            colMail.Name = "colMail";
            colMail.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colFechaBaja
            // 
            colFechaBaja.HeaderText = "Fecha Baja";
            colFechaBaja.Name = "colFechaBaja";
            colFechaBaja.ReadOnly = true;
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "Acciones";
            colAcciones.Items.AddRange(new object[] { "Ver", "Editar", "Dar de Baja" });
            colAcciones.Name = "colAcciones";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(448, 424);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 25);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(426, 17);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 6;
            label4.Text = "Consultar clientes";
            // 
            // frmConsultarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(label4);
            Controls.Add(chkInactivo);
            Controls.Add(dgvClientes);
            Controls.Add(chkBaja);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(txtDni);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmConsultarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnConsultar;
        private DataGridView dgvClientes;
        private Button btnSalir;
        private CheckBox chkInactivo;
        private CheckBox chkBaja;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colMail;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colFechaBaja;
        private DataGridViewComboBoxColumn colAcciones;
        private Label label4;
    }
}