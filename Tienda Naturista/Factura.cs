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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }
        int total = 0;
        CN_Clientes oCN_Clientes= new CN_Clientes();
        CN_Productos oCN_Productos= new CN_Productos();
        CN_Productos oCN_Productos2 = new CN_Productos();
        CN_Factura oCN_Factura= new CN_Factura();
        CN_Detalle_Factura oCN_Detalle = new CN_Detalle_Factura();

        CE_Factura oCE_Factura = new CE_Factura();
        CE_Productos oCE_Productos = new CE_Productos();
        CE_Factura_Detalles oCE_FactDetalle = new CE_Factura_Detalles();
        public void BuscarCliente()
        {
            CbxCliente.DataSource = oCN_Clientes.MostrarClientes();
            CbxCliente.ValueMember = "Documento";
            CbxCliente.DisplayMember = "Nombre";
        }
        public void BuscarProductos()
        {
            CbxProductos.DataSource = oCN_Productos.MostrarProductos();
            CbxProductos.ValueMember = "Codigo";
            CbxProductos.DisplayMember = "Descripción";
        }
        private void Factura_Load(object sender, EventArgs e)
        {
            BuscarCliente();
            BuscarProductos();
            TxtFactura.Text=(oCN_Factura.BuscarFactura()+1).ToString();
            //DgvFacturaproductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DtpFactura.Enabled=false;
            BtnAgregarProducto.Enabled=false;
            BtnTerminarFact.Enabled = false;
        }
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TxtCantidad.Text) > 0)
            {
                oCE_Productos.Codigo = Convert.ToInt32(CbxProductos.SelectedValue);
                DataTable dtProducto; dtProducto = oCN_Productos2.MostrarUnProductos(oCE_Productos);
                oCE_Productos.Descri = dtProducto.Rows[0]["Descripción"].ToString();
                oCE_Productos.ValUnd = Convert.ToInt32(dtProducto.Rows[0]["Valor_Unidad"].ToString());

                DgvFacturaproductos.Rows.Add(oCE_Productos.Codigo,
                    oCE_Productos.Descri,
                    oCE_Productos.ValUnd,
                    Convert.ToInt32(TxtCantidad.Text),
                    oCE_Productos.ValUnd * Convert.ToInt32(TxtCantidad.Text));


                total += Convert.ToInt32(TxtCantidad.Text) * oCE_Productos.ValUnd;
                TxtTotalFact.Text = total.ToString();
                CbxCliente.Enabled = false;
                TxtCantidad.Text = string.Empty;
                BtnTerminarFact.Enabled = true;
            }
            else
                MessageBox.Show("La vcantidad debe ser mayor a 0");;
        }
        private void BtnTerminarFact_Click(object sender, EventArgs e)
        {
            oCE_Factura.IdFactu=Convert.ToInt32(TxtFactura.Text);
            oCE_Factura.Fecha = DtpFactura.Value;
            oCE_Factura.Documento_Cliente = Convert.ToInt32(CbxCliente.SelectedValue);
            oCE_Factura.Codigo_Vendedor = 1212;
            oCN_Factura.InsertarFactura(oCE_Factura);
            foreach (DataGridViewRow Filas in DgvFacturaproductos.Rows)
            {
                oCE_FactDetalle.Numero_Factura = Convert.ToInt32(TxtFactura.Text);
                oCE_FactDetalle.Codigo_Productos= Convert.ToInt32(Filas.Cells[0].Value.ToString());
                oCE_FactDetalle.Cantidad = Convert.ToInt32(Filas.Cells[3].Value.ToString());
                oCE_FactDetalle.Valor_Unidad = Convert.ToInt32(Filas.Cells[2].Value.ToString());
                oCN_Detalle.Insertar_DetalleFactura(oCE_FactDetalle);
            }
            TxtFactura.Text = (Convert.ToInt32(TxtFactura.Text)+1).ToString();
            TxtTotalFact.Text=string.Empty;

            DgvFacturaproductos.Rows.Clear();
            BtnTerminarFact.Enabled = false;

        }
        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            TextBox cajita = TxtCantidad as TextBox;
            bool error = false;
            foreach (char c in cajita.Text)
            {
                if (!char.IsDigit(c))
                {
                    error = true;
                    break;
                }
            }
            if (error == true)
            {
                BtnAgregarProducto.Enabled = false;
            }
            else
            {
                if (TxtCantidad.Text == string.Empty)
                {
                    BtnAgregarProducto.Enabled = false;
                }
                else
                {
                    BtnAgregarProducto.Enabled = true;
                }
            }          
        }
        private void validacionNumero(object cajastxt)
        {
            TextBox cajita = cajastxt as TextBox;
            bool error = false;
            foreach (char c in cajita.Text)
            {
                if (!char.IsDigit(c))
                {
                    error = true;
                    break;
                }
            }
            if (error == true)
            {
                BtnAgregarProducto.Enabled = false;
            }
            else
            {
                BtnAgregarProducto.Enabled = true;
            }
        }
      
    }
}
