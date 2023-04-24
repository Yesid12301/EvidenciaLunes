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
    public partial class Gestion_Inventario : Form
    {
        public Gestion_Inventario()
        {
            InitializeComponent();
        }
        CN_inventario oCN_inventario = new CN_inventario();
        private void Gestion_Inventario_Load(object sender, EventArgs e)
        {
            dtgInventario.DataSource= oCN_inventario.BuscarInventario();
            dtgInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            buscarInventario();
        }
        private void buscarInventario()
        {
            CbxProductoInventario.DataSource = oCN_inventario.BuscarInventario();
            CbxProductoInventario.DisplayMember = "Descripción";  
        }
    }
}
