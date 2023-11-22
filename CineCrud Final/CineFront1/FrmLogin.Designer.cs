namespace CineFront
{
    partial class frmLogin
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
            txtUsuario = new TextBox();
            txtContra = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label7 = new Label();
            btnAccion = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(12, 81);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(260, 25);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "admin";
            // 
            // txtContra
            // 
            txtContra.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtContra.Location = new Point(12, 155);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(260, 25);
            txtContra.TabIndex = 1;
            txtContra.Tag = "";
            txtContra.Text = "12345";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(92, 17);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 1;
            label6.Text = "Iniciar sesión";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(127, 19);
            label1.TabIndex = 6;
            label1.Text = "Nombre de usuario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 133);
            label7.Name = "label7";
            label7.Size = new Size(79, 19);
            label7.TabIndex = 7;
            label7.Text = "Contraseña";
            // 
            // btnAccion
            // 
            btnAccion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccion.Location = new Point(105, 204);
            btnAccion.Name = "btnAccion";
            btnAccion.Size = new Size(75, 25);
            btnAccion.TabIndex = 10;
            btnAccion.Text = "¡Acción!";
            btnAccion.UseVisualStyleBackColor = true;
            btnAccion.Click += btnAccion_Click_1;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(284, 248);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(label7);
            Controls.Add(txtContra);
            Controls.Add(btnAccion);
            Controls.Add(label6);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContra;
        private Button btnVer;
        private Label label6;
        private Label label7;
        private Label label1;
        private Button btnAccion;
    }
}