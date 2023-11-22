namespace CineFront
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            nuevoClienteToolStripMenuItem = new ToolStripMenuItem();
            consultarClientesToolStripMenuItem = new ToolStripMenuItem();
            comprobantesToolStripMenuItem = new ToolStripMenuItem();
            nuevoComprobanteToolStripMenuItem = new ToolStripMenuItem();
            consultarComprobantesToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, comprobantesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoClienteToolStripMenuItem, consultarClientesToolStripMenuItem });
            clientesToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(69, 23);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            nuevoClienteToolStripMenuItem.Size = new Size(168, 22);
            nuevoClienteToolStripMenuItem.Text = "Nuevo cliente";
            nuevoClienteToolStripMenuItem.Click += nuevoClienteToolStripMenuItem_Click;
            // 
            // consultarClientesToolStripMenuItem
            // 
            consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            consultarClientesToolStripMenuItem.Size = new Size(168, 22);
            consultarClientesToolStripMenuItem.Text = "Consultar clientes";
            consultarClientesToolStripMenuItem.Click += consultarClientesToolStripMenuItem_Click;
            // 
            // comprobantesToolStripMenuItem
            // 
            comprobantesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoComprobanteToolStripMenuItem, consultarComprobantesToolStripMenuItem });
            comprobantesToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comprobantesToolStripMenuItem.Name = "comprobantesToolStripMenuItem";
            comprobantesToolStripMenuItem.Size = new Size(112, 23);
            comprobantesToolStripMenuItem.Text = "Comprobantes";
            // 
            // nuevoComprobanteToolStripMenuItem
            // 
            nuevoComprobanteToolStripMenuItem.Name = "nuevoComprobanteToolStripMenuItem";
            nuevoComprobanteToolStripMenuItem.Size = new Size(205, 22);
            nuevoComprobanteToolStripMenuItem.Text = "Nuevo comprobante";
            nuevoComprobanteToolStripMenuItem.Click += nuevoComprobanteToolStripMenuItem_Click;
            // 
            // consultarComprobantesToolStripMenuItem
            // 
            consultarComprobantesToolStripMenuItem.Name = "consultarComprobantesToolStripMenuItem";
            consultarComprobantesToolStripMenuItem.Size = new Size(205, 22);
            consultarComprobantesToolStripMenuItem.Text = "Consultar comprobantes";
            consultarComprobantesToolStripMenuItem.Click += consultarComprobantesToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(435, 220);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 1;
            label1.Text = "Menú Principal";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem comprobantesToolStripMenuItem;
        private ToolStripMenuItem nuevoComprobanteToolStripMenuItem;
        private ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private ToolStripMenuItem consultarClientesToolStripMenuItem;
        private ToolStripMenuItem consultarComprobantesToolStripMenuItem;
        private Label label1;
    }
}