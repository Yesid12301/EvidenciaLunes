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
    public partial class Gestion_Clientes : Form
    {
        public Gestion_Clientes()
        {           
            InitializeComponent();
        }
        CN_Clientes oCN_Clientes = new CN_Clientes();
        CE_Clientes Cliente = new CE_Clientes();
        CN_Clientes oCN_Clientes2 = new CN_Clientes();
        private void BtnGuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente.Documento = Convert.ToInt32(TxtDocumentoIngresarCli.Text);
            Cliente.Nombre = TxtNombreIngresarCli.Text;
            Cliente.Direccion = TxtDireccionIngresarCli.Text;
            Cliente.Telefono = TxtTelefonoIngresarCli.Text;
            Cliente.Correo = TxtCorreoIngresarCli.Text;
            try
            {
                oCN_Clientes.Insertar(Cliente);
                MessageBox.Show("Cliente Ingresado Corrrectamente");
                DgvConsultarCliente.DataSource = oCN_Clientes.MostrarClientes();
                MostrarCliente();
            }
            catch (Exception)
            {
                MessageBox.Show("No Ingreso a nadie");
            }
            (TxtDocumentoIngresarCli.Text) = String.Empty;
            (TxtNombreIngresarCli.Text) = String.Empty;
            (TxtDireccionIngresarCli.Text) = String.Empty;
            (TxtTelefonoIngresarCli.Text) = String.Empty;
            (TxtCorreoIngresarCli.Text) = String.Empty;
        }
        private void Gestion_Clientes_Load(object sender, EventArgs e)
        {
            DgvConsultarCliente.DataSource = oCN_Clientes.MostrarClientes();
            MostrarCliente();

        }
        private void MostrarCliente()
        {
            CbxClienteConsultar.DataSource = oCN_Clientes2.MostrarClientes();
            CbxClienteConsultar.ValueMember = "Documento";
            CbxClienteConsultar.DisplayMember = "Nombre";

            CbxEliminarCliente.DataSource = oCN_Clientes2.MostrarClientes();
            CbxEliminarCliente.ValueMember = "Documento";
            CbxEliminarCliente.DisplayMember = "Nombre";

            CbxEditarCliente.DataSource = oCN_Clientes2.MostrarClientes();
            CbxEditarCliente.ValueMember = "Documento";
            CbxEditarCliente.DisplayMember = "Nombre";
        }

        private void BtnLimpiarCliente_Click_1(object sender, EventArgs e)
        {
            (TxtDocumentoIngresarCli.Text) = String.Empty;
            (TxtNombreIngresarCli.Text) = String.Empty;
            (TxtDireccionIngresarCli.Text) = String.Empty;
            (TxtTelefonoIngresarCli.Text) = String.Empty;
            (TxtCorreoIngresarCli.Text) = String.Empty;
        }
        private void BtnMostrarTodoConsultar_Click_1(object sender, EventArgs e)
        {
            DgvConsultarCliente.DataSource = oCN_Clientes.MostrarClientes();
        }
        private void BtnConsultarCliente_Click_1(object sender, EventArgs e)
        {
            Cliente.Documento = Convert.ToInt32(CbxClienteConsultar.SelectedValue.ToString());
            DgvConsultarCliente.DataSource = oCN_Clientes.BuscarUnCliente(Cliente);
        }
        private void BtnEliminarCliente_Click_1(object sender, EventArgs e)
        {
            Cliente.Documento = Convert.ToInt32(CbxEliminarCliente.SelectedValue.ToString());
            oCN_Clientes.SP_ELIMINARCLIENT(Cliente);
            DgvConsultarCliente.DataSource = oCN_Clientes.MostrarClientes();
            MostrarCliente();
        }
        private void BtnConsultarEditarCli_Click_1(object sender, EventArgs e)
        {
            Cliente.Documento = Convert.ToInt32(CbxEditarCliente.SelectedValue.ToString());
            DataTable clientes = oCN_Clientes.BuscarUnCliente(Cliente);
            TxtDocEditatrCli.Text = clientes.Rows[0]["Documento"].ToString();
            TxtNomEditarCli.Text = clientes.Rows[0]["Nombre"].ToString();
            TxtDirecEditarCli.Text = clientes.Rows[0]["Direccion"].ToString();
            TxtTelEditarCli.Text = clientes.Rows[0]["Telefono"].ToString();
            TxtCorreoEditarCli.Text = clientes.Rows[0]["Correo"].ToString();
        }

        private void BtnGuardarEdiatrCli_Click_1(object sender, EventArgs e)
        {
            Cliente.Documento = Convert.ToInt32(TxtDocEditatrCli.Text);
            Cliente.Nombre = (TxtNomEditarCli.Text);
            Cliente.Direccion = (TxtDirecEditarCli.Text);
            Cliente.Telefono = (TxtTelEditarCli.Text);
            Cliente.Correo = (TxtCorreoEditarCli.Text);
            try
            {
                oCN_Clientes.Editar(Cliente);
                MessageBox.Show("Cliente Editado Corrrectamente");
                DgvConsultarCliente.DataSource = oCN_Clientes.MostrarClientes();
                MostrarCliente();
            }
            catch (Exception)
            {
                MessageBox.Show("No se Edito nada");
            }
            (TxtDocEditatrCli.Text) = String.Empty;
            (TxtNomEditarCli.Text) = String.Empty;
            (TxtDirecEditarCli.Text) = String.Empty;
            (TxtTelEditarCli.Text) = String.Empty;
            (TxtCorreoEditarCli.Text) = String.Empty;
            (TxtCorreoEditarCli.Text) = "asda";
        }

        
    }
}
