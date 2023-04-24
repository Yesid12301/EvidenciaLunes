using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Naturista
{
    public partial class Using : Form
    {
        public Using()
        {
            InitializeComponent();
        }
        CE_Vendedores oCE_Vendedores= new CE_Vendedores();
        CN_Vendedores oCN_Vendedores= new CN_Vendedores();
        private void BtnIngresar_Click(object sender, EventArgs e)
        {   
            oCE_Vendedores.Usuario= TxtUsuario.Text;    
            oCE_Vendedores.Contraseña = Encriptacion.GetSHA256(TxtContraseña.Text);
            if (oCN_Vendedores.Buscarvendedores(oCE_Vendedores) == true)
            {
                Gestion gestion = new Gestion();
                gestion.ShowDialog();
                TxtUsuario.Text = string.Empty;
                TxtContraseña.Text = string.Empty;
                
            }

            else
            {
                MessageBox.Show("Datos incorrectos");

            }
        }
        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
