namespace CineFront
{
    partial class frmClienteAM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkBaja = new CheckBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            cboTiposClientes = new ComboBox();
            rbtMujer = new RadioButton();
            rbtHombre = new RadioButton();
            cboBarrios = new ComboBox();
            txtNro = new TextBox();
            txtCalle = new TextBox();
            dtpFecNac = new DateTimePicker();
            txtTelefono = new TextBox();
            txtDni = new TextBox();
            txtMail = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblTipo = new Label();
            lblGenero = new Label();
            lblBarrio = new Label();
            lblNro = new Label();
            lblCalle = new Label();
            lblFecNac = new Label();
            lblTelefono = new Label();
            lblMail = new Label();
            lblDni = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // chkBaja
            // 
            chkBaja.AutoSize = true;
            chkBaja.CheckAlign = ContentAlignment.MiddleRight;
            chkBaja.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chkBaja.Location = new Point(496, 372);
            chkBaja.Name = "chkBaja";
            chkBaja.Size = new Size(124, 23);
            chkBaja.TabIndex = 12;
            chkBaja.Text = "Estado de Baja: ";
            chkBaja.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(495, 418);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 25);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(389, 418);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 25);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cboTiposClientes
            // 
            cboTiposClientes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboTiposClientes.FormattingEnabled = true;
            cboTiposClientes.Location = new Point(496, 331);
            cboTiposClientes.Name = "cboTiposClientes";
            cboTiposClientes.Size = new Size(215, 25);
            cboTiposClientes.TabIndex = 9;
            // 
            // rbtMujer
            // 
            rbtMujer.AutoSize = true;
            rbtMujer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbtMujer.Location = new Point(422, 372);
            rbtMujer.Name = "rbtMujer";
            rbtMujer.Size = new Size(63, 23);
            rbtMujer.TabIndex = 11;
            rbtMujer.TabStop = true;
            rbtMujer.Text = "Mujer";
            rbtMujer.UseVisualStyleBackColor = true;
            // 
            // rbtHombre
            // 
            rbtHombre.AutoSize = true;
            rbtHombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbtHombre.Location = new Point(339, 372);
            rbtHombre.Name = "rbtHombre";
            rbtHombre.Size = new Size(77, 23);
            rbtHombre.TabIndex = 10;
            rbtHombre.TabStop = true;
            rbtHombre.Text = "Hombre";
            rbtHombre.UseVisualStyleBackColor = true;
            // 
            // cboBarrios
            // 
            cboBarrios.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboBarrios.FormattingEnabled = true;
            cboBarrios.Location = new Point(275, 332);
            cboBarrios.Name = "cboBarrios";
            cboBarrios.Size = new Size(215, 25);
            cboBarrios.TabIndex = 8;
            // 
            // txtNro
            // 
            txtNro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNro.Location = new Point(496, 269);
            txtNro.Name = "txtNro";
            txtNro.Size = new Size(215, 25);
            txtNro.TabIndex = 7;
            // 
            // txtCalle
            // 
            txtCalle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalle.Location = new Point(275, 269);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(215, 25);
            txtCalle.TabIndex = 6;
            // 
            // dtpFecNac
            // 
            dtpFecNac.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecNac.Format = DateTimePickerFormat.Short;
            dtpFecNac.Location = new Point(496, 145);
            dtpFecNac.Name = "dtpFecNac";
            dtpFecNac.Size = new Size(215, 25);
            dtpFecNac.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(274, 207);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(215, 25);
            txtTelefono.TabIndex = 4;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(274, 145);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(215, 25);
            txtDni.TabIndex = 2;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(496, 207);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(215, 25);
            txtMail.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(496, 83);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(215, 25);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(275, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 25);
            txtNombre.TabIndex = 0;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(496, 310);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(38, 19);
            lblTipo.TabIndex = 12;
            lblTipo.Text = "Tipo:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenero.Location = new Point(276, 374);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(57, 19);
            lblGenero.TabIndex = 11;
            lblGenero.Text = "Genero:";
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblBarrio.Location = new Point(274, 310);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(48, 19);
            lblBarrio.TabIndex = 10;
            lblBarrio.Text = "Barrio:";
            // 
            // lblNro
            // 
            lblNro.AutoSize = true;
            lblNro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNro.Location = new Point(496, 247);
            lblNro.Name = "lblNro";
            lblNro.Size = new Size(35, 19);
            lblNro.TabIndex = 9;
            lblNro.Text = "Nro:";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalle.Location = new Point(274, 247);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(41, 19);
            lblCalle.TabIndex = 8;
            lblCalle.Text = "Calle:";
            // 
            // lblFecNac
            // 
            lblFecNac.AutoSize = true;
            lblFecNac.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecNac.Location = new Point(496, 123);
            lblFecNac.Name = "lblFecNac";
            lblFecNac.Size = new Size(139, 19);
            lblFecNac.TabIndex = 7;
            lblFecNac.Text = "Fecha de Nacimiento:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(274, 185);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(63, 19);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Telefono:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.Location = new Point(496, 185);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(38, 19);
            lblMail.TabIndex = 5;
            lblMail.Text = "Mail:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(274, 123);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(36, 19);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(275, 61);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 19);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(496, 61);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(61, 19);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(440, 17);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 15;
            label1.Text = "Nuevo cliente";
            // 
            // frmClienteAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(label1);
            Controls.Add(chkBaja);
            Controls.Add(btnCancelar);
            Controls.Add(txtDni);
            Controls.Add(btnAceptar);
            Controls.Add(lblApellido);
            Controls.Add(cboTiposClientes);
            Controls.Add(lblNombre);
            Controls.Add(rbtMujer);
            Controls.Add(lblDni);
            Controls.Add(rbtHombre);
            Controls.Add(lblMail);
            Controls.Add(cboBarrios);
            Controls.Add(lblTelefono);
            Controls.Add(txtNro);
            Controls.Add(lblFecNac);
            Controls.Add(txtCalle);
            Controls.Add(lblCalle);
            Controls.Add(dtpFecNac);
            Controls.Add(lblNro);
            Controls.Add(txtTelefono);
            Controls.Add(lblBarrio);
            Controls.Add(lblGenero);
            Controls.Add(txtMail);
            Controls.Add(lblTipo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmClienteAM";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rbtMujer;
        private RadioButton rbtHombre;
        private ComboBox cboBarrios;
        private TextBox txtNro;
        private TextBox txtCalle;
        private DateTimePicker dtpFecNac;
        private TextBox txtTelefono;
        private TextBox txtDni;
        private TextBox txtMail;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblTipo;
        private Label lblGenero;
        private Label lblBarrio;
        private Label lblNro;
        private Label lblCalle;
        private Label lblFecNac;
        private Label lblTelefono;
        private Label lblMail;
        private Label lblDni;
        private Label lblNombre;
        private Label lblApellido;
        private ComboBox cboTiposClientes;
        private Button btnAceptar;
        private Button btnCancelar;
        private CheckBox chkBaja;
        private Label label1;
    }
}