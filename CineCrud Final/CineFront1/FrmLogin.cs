using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineBack.Datos;
using CineBack.Dominio;
using CineBack.Servicios;
using CineBack.Servicios.Interfaz;
using CineFront.ClienteSing;

namespace CineFront
{
    public partial class frmLogin : Form
    {
        private IServicio serv;

        public frmLogin()
        {
            InitializeComponent();
            txtContra.UseSystemPasswordChar = true;
        }

        private void btnAccion_Click_1(object sender, EventArgs e)
        {
            bool inicioExitoso = false;
            var oUsuario = "admin";
            var oContra = "12345";
            frmPrincipal frm = new frmPrincipal();

            if (txtUsuario.Text == oUsuario && txtContra.Text == oContra)
            {
                frm.ShowDialog();
                inicioExitoso = true;
                this.Close();
            }

            if (inicioExitoso == false && txtContra.Text != string.Empty && txtUsuario.Text != string.Empty)
            {
                MessageBox.Show("Datos incorrectos.");
            }
            if (txtContra.Text == string.Empty && txtUsuario.Text == string.Empty && inicioExitoso == false)
            {
                MessageBox.Show("Ingrese nombre y contraseña.");
            }
        }
    }
}
