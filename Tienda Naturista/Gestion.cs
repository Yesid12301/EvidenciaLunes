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
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(Form formulario)
        {
            this.panel1.Controls.Clear();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(formulario);
            formulario.Show();
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirFormulario(new Gestion_Productos());
        }      
        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Factura());
        }
        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Gestion_Inventario());
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Gestion_Clientes());
        }
        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Gestion_Vendedores());
        }

        private void inicioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSecionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
