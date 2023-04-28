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
using System.Text.RegularExpressions;

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
            Cliente.Nombre = TxtNombreIngresarCli.Text.Trim();
            Cliente.Direccion = TxtDireccionIngresarCli.Text.Trim();
            Cliente.Telefono = TxtTelefonoIngresarCli.Text;
            Cliente.Correo = TxtCorreoIngresarCli.Text.Trim();
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
            DgvConsultarCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            MostrarCliente();
            BtnGuardarCliente.Enabled = false;
            BtnGuardarEdiatrCli.Enabled = false;
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
            Cliente.Nombre = TxtNomEditarCli.Text.Trim();
            Cliente.Direccion = (TxtDirecEditarCli.Text.Trim());
            Cliente.Telefono = (TxtTelEditarCli.Text);
            Cliente.Correo = (TxtCorreoEditarCli.Text.Trim());
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
        }


        //dos metodos para validar numero y letras
        private bool validacionNumero(object cajastxt)
        {
            TextBox cajita = cajastxt as TextBox;
            bool error = false;
            if (string.IsNullOrEmpty(cajita.Text)) { error = true; }
            foreach (char c in cajita.Text)
            {
                if (!char.IsDigit(c))
                {
                    error = true;
                    break;
                }
            }
            if  (error == true)
            {
                errorProvider1.SetError(cajita, " solo numeros");
            }
            else
            {
                errorProvider1.SetError(cajita, "");
            }
            return error;
        }
        private bool validacionletra(object cajastxt)
        {
            TextBox cajita = cajastxt as TextBox;
            bool error = false;
            foreach (char c in cajita.Text)
            {
                if (!Char.IsLetter(c) && !Char.IsWhiteSpace(c))
                {
                    error = true;
                    break;
                }
            }
            if (error == true)
            {
                errorProvider1.SetError(cajita, " solo digite letra ");
            }
            else
            {
                errorProvider1.SetError(cajita, "");
            }
            return error;
        }
        private bool validacionVacio(object cajastxt)
        {
            TextBox cajita = cajastxt as TextBox;
            bool error = false;            
            if (string.IsNullOrEmpty(cajita.Text)) {error = true;}

            if (error == true)
            {
                errorProvider1.SetError(cajita, " No dejar vacio ");
            }
            else
            {
                errorProvider1.SetError(cajita, "");
            }
            return error;
        }
        private bool validarCorreo(object cajastxt)
        {
            TextBox cajita = cajastxt as TextBox;
            bool error = false;

            if (!Regex.IsMatch(cajita.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) { error = true; }

            if (error == true)
            {
                errorProvider1.SetError(cajita, " Solo correos ");
            }
            else
            {
                errorProvider1.SetError(cajita, "");
            }
            return error;
        }

        //validacion al ingresar un usuario
        private void TxtDocumentoIngresarCli_TextChanged(object sender, EventArgs e)
        {
            validacionGuardar(TxtDocumentoIngresarCli, TxtNombreIngresarCli, TxtDireccionIngresarCli, TxtTelefonoIngresarCli, TxtCorreoIngresarCli);
        }

        private void TxtNombreIngresarCli_TextChanged(object sender, EventArgs e)
        {
            validacionGuardar(TxtDocumentoIngresarCli, TxtNombreIngresarCli, TxtDireccionIngresarCli, TxtTelefonoIngresarCli, TxtCorreoIngresarCli);
        }

        private void TxtDireccionIngresarCli_TextChanged(object sender, EventArgs e)
        {
            validacionGuardar(TxtDocumentoIngresarCli, TxtNombreIngresarCli, TxtDireccionIngresarCli, TxtTelefonoIngresarCli, TxtCorreoIngresarCli);
        }

        private void TxtTelefonoIngresarCli_TextChanged(object sender, EventArgs e)
        {
            validacionGuardar(TxtDocumentoIngresarCli, TxtNombreIngresarCli, TxtDireccionIngresarCli, TxtTelefonoIngresarCli, TxtCorreoIngresarCli);
        }

        private void TxtCorreoIngresarCli_TextChanged(object sender, EventArgs e)
        {
            validacionGuardar(TxtDocumentoIngresarCli, TxtNombreIngresarCli, TxtDireccionIngresarCli, TxtTelefonoIngresarCli, TxtCorreoIngresarCli);
        }
        private void validacionGuardar(TextBox TxtDocumentoIngresarCli, TextBox TxtNombreIngresarCli, TextBox TxtDireccionIngresarCli, TextBox TxtTelefonoIngresarCli, TextBox TxtCorreoIngresarCli)
        {
            //string.IsNullOrEmpty(Textbox1.Text)
            if (validacionNumero(TxtDocumentoIngresarCli) == false)
            {
                if (validacionletra(TxtNombreIngresarCli) == false)
                {
                    if (validacionVacio(TxtDireccionIngresarCli) == false)
                    {
                        if (validacionNumero(TxtTelefonoIngresarCli) == false)
                        {
                            if (validarCorreo(TxtCorreoIngresarCli) == false)
                            {
                                BtnGuardarCliente.Enabled = true;
                            }
                            else {BtnGuardarCliente.Enabled = false;}
                        }
                        else {BtnGuardarCliente.Enabled = false;}
                    }
                    else {BtnGuardarCliente.Enabled = false;}
                }
                else {BtnGuardarCliente.Enabled = false;}
            }
            else {BtnGuardarCliente.Enabled = false;}
        }
        // validacion de la ediccion del cliente
        private void TxtNomEditarCli_TextChanged(object sender, EventArgs e)
        {
            validacionEditar(TxtNomEditarCli, TxtNomEditarCli, TxtTelEditarCli, TxtCorreoEditarCli);
        }
        private void TxtDirecEditarCli_TextChanged(object sender, EventArgs e)
        {
            validacionEditar(TxtNomEditarCli, TxtNomEditarCli, TxtTelEditarCli, TxtCorreoEditarCli);
        }
        private void TxtTelEditarCli_TextChanged(object sender, EventArgs e)
        {
            validacionEditar(TxtNomEditarCli, TxtNomEditarCli, TxtTelEditarCli, TxtCorreoEditarCli);
        }

        private void TxtCorreoEditarCli_TextChanged(object sender, EventArgs e)
        {
            validacionEditar(TxtNomEditarCli, TxtNomEditarCli, TxtTelEditarCli, TxtCorreoEditarCli);
        }
        private void validacionEditar(TextBox TxtNomEditarCli, TextBox TxtDirecEditarCli, TextBox TxtTelEditarCli, TextBox TxtCorreoEditarCli)
        {
            if (validacionletra(TxtNomEditarCli) == false)
            {
                if (validacionVacio(TxtDirecEditarCli) == false)
                {
                    if (validacionNumero(TxtTelEditarCli) == false)
                    {
                        if (validarCorreo(TxtCorreoEditarCli) == false)
                        {
                            BtnGuardarEdiatrCli.Enabled = true;
                        }
                        else { BtnGuardarEdiatrCli.Enabled = false; }
                    }
                    else { BtnGuardarEdiatrCli.Enabled = false; }
                }
                else { BtnGuardarEdiatrCli.Enabled = false; }
            }
            else { BtnGuardarEdiatrCli.Enabled = false; }            
        }

        
    }
}
