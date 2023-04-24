using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Naturista
{
    public partial class Gestion_Vendedores : Form
    {
        public Gestion_Vendedores()
        {
            InitializeComponent();
        }
        CN_Vendedores oCN_Vendedores = new CN_Vendedores();
        CE_Vendedores vendedores = new CE_Vendedores();
        CN_Vendedores oCN_Vendedores2 = new CN_Vendedores();

        private void BtnGuardarVen_Click_1(object sender, EventArgs e)
        {
            vendedores.Codigo = Convert.ToInt32(TxtInsertarVen.Text);
            vendedores.Usuario = (TxtUsuarioVen.Text.Trim());
            vendedores.Contraseña = Encriptacion.GetSHA256(TxtContraseñaven.Text.Trim());
            vendedores.Nombre = (TxtNombreVen.Text.Trim());
            try
            {
                oCN_Vendedores.InsertarVendedores(vendedores);
                MessageBox.Show("Vendedor Ingresado Corrrectamente");
                DgvConsultarVen.DataSource = oCN_Vendedores.Buscar_vendedores();
                Buscarvendedores();
            }
            catch (Exception)
            {
                MessageBox.Show("No Ingreso a nadie");
            }
           (TxtInsertarVen.Text) = String.Empty;
            (TxtUsuarioVen.Text) = String.Empty;
            (TxtContraseñaven.Text) = String.Empty;
            (TxtNombreVen.Text) = String.Empty;
        }

        private void BtnLimpiarVen_Click_1(object sender, EventArgs e)
        {
            (TxtInsertarVen.Text) = String.Empty;
            (TxtUsuarioVen.Text) = String.Empty;
            (TxtContraseñaven.Text) = String.Empty;
            (TxtNombreVen.Text) = String.Empty;
        }
        private void Gestion_Vendedores_Load_1(object sender, EventArgs e)
        {
            DgvConsultarVen.DataSource = oCN_Vendedores.Buscar_vendedores();
            DgvConsultarVen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvConsultarVen.Columns[2].Visible = false;
            Buscarvendedores();
            BtnGuardarVen.Enabled= false;
            BtnGuardarCambModifVen.Enabled = false;
        }
        private void Buscarvendedores()
        {
            CbxConsultarVen.DataSource = oCN_Vendedores2.Buscar_vendedores();
            CbxConsultarVen.ValueMember = "Codigo";
            CbxConsultarVen.DisplayMember = "Usuario";

            CbxUsuarioElimiVen.DataSource = oCN_Vendedores2.Buscar_vendedores();
            CbxUsuarioElimiVen.ValueMember = "Codigo";
            CbxUsuarioElimiVen.DisplayMember = "Usuario";

            CbxModifVen.DataSource = oCN_Vendedores2.Buscar_vendedores();
            CbxModifVen.ValueMember = "Codigo";
            CbxModifVen.DisplayMember = "Usuario";
        }
       
        private void BtnConsultarVen_Click_1(object sender, EventArgs e)
        {
            vendedores.Codigo = Convert.ToInt32(CbxConsultarVen.SelectedValue.ToString());
            DgvConsultarVen.DataSource = oCN_Vendedores.BuscarUnvendedor(vendedores);
        }

        private void BtnMostrarTodoVen_Click_1(object sender, EventArgs e)
        {
            DgvConsultarVen.DataSource = oCN_Vendedores.Buscar_vendedores();
        }  

        private void BtnConsultarModifven_Click_1(object sender, EventArgs e)
        {
            vendedores.Codigo = Convert.ToInt32(CbxModifVen.SelectedValue.ToString());
            DataTable vende = oCN_Vendedores.BuscarUnvendedor(vendedores);
            TxtCodigoModifVen.Text = vende.Rows[0]["Codigo"].ToString();
            TxtUsuarioModifVen.Text = vende.Rows[0]["Usuario"].ToString();
            TxtContraModifVen.Text = string.Empty;
            TxtNombreModifVen.Text = vende.Rows[0]["Nombre"].ToString();
        }

        private void BtnGuardarCambModifVen_Click_1(object sender, EventArgs e)
        {
            vendedores.Codigo = Convert.ToInt32(TxtCodigoModifVen.Text);
            vendedores.Usuario = (TxtUsuarioModifVen.Text.Trim());
            vendedores.Contraseña = Encriptacion.GetSHA256(TxtContraModifVen.Text.Trim());
            vendedores.Nombre = (TxtNombreModifVen.Text.Trim());
            try
            {
                oCN_Vendedores.EditarVendedores(vendedores);
                MessageBox.Show("Vendedor Editado Corrrectamente");
                DgvConsultarVen.DataSource = oCN_Vendedores.Buscar_vendedores();
            }
            catch (Exception)
            {
                MessageBox.Show("No se Edito nada");
            }
            (TxtCodigoModifVen.Text) = String.Empty;
            (TxtUsuarioModifVen.Text) = String.Empty;
            (TxtContraModifVen.Text) = String.Empty;
            (TxtNombreModifVen.Text) = String.Empty;
        }

        private void BtnEliminarUsuario_Click_1(object sender, EventArgs e)
        {
            vendedores.Codigo = Convert.ToInt32(CbxUsuarioElimiVen.SelectedValue.ToString());            
            oCN_Vendedores.EliminarVendedor(vendedores);
            Buscarvendedores();
            DgvConsultarVen.DataSource = oCN_Vendedores.Buscar_vendedores();
        }

        private void TxtInsertarVen_TextChanged(object sender, EventArgs e)
        {
            validacionUsuario(TxtInsertarVen, TxtUsuarioVen, TxtContraseñaven, TxtNombreVen);
        }

        private void TxtUsuarioVen_TextChanged(object sender, EventArgs e)
        {
            validacionUsuario(TxtInsertarVen, TxtUsuarioVen, TxtContraseñaven, TxtNombreVen);
        }

        private void TxtContraseñaven_TextChanged(object sender, EventArgs e)
        {
            validacionUsuario(TxtInsertarVen, TxtUsuarioVen, TxtContraseñaven, TxtNombreVen);
        }

        private void TxtNombreVen_TextChanged(object sender, EventArgs e)
        {
            validacionUsuario(TxtInsertarVen, TxtUsuarioVen, TxtContraseñaven, TxtNombreVen);
        }


        private void validacionUsuario(TextBox TxtInsertarVen, TextBox TxtUsuarioVen, TextBox TxtContraseñaven, TextBox TxtNombreVen)
        {
            if (validacionNumero(TxtInsertarVen) == false)
            {
                if (validacionVacio(TxtUsuarioVen) == false)
                {
                    if (validacionVacio(TxtContraseñaven) == false)
                    {
                        if (validacionletra(TxtNombreVen) == false)
                        {                           
                            BtnGuardarVen.Enabled = true;                            
                        }
                        else { BtnGuardarVen.Enabled = false; }
                    }
                    else { BtnGuardarVen.Enabled = false; }
                }
                else { BtnGuardarVen.Enabled = false; }
            }
            else { BtnGuardarVen.Enabled = false; }
        }

        //metodos para validacion
        private bool validacionNumero(object cajastxt)
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
            if (string.IsNullOrEmpty(cajita.Text)) { error = true; }

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

        private void TxtUsuarioModifVen_TextChanged(object sender, EventArgs e)
        {
            validacionModificaion(TxtUsuarioModifVen, TxtContraModifVen, TxtNombreModifVen);
        }

        private void TxtContraModifVen_TextChanged(object sender, EventArgs e)
        {
            validacionModificaion(TxtUsuarioModifVen, TxtContraModifVen, TxtNombreModifVen);
        }

        private void TxtNombreModifVen_TextChanged(object sender, EventArgs e)
        {
            validacionModificaion(TxtUsuarioModifVen, TxtContraModifVen, TxtNombreModifVen);
        }
        private void validacionModificaion(TextBox TxtUsuarioModifVen, TextBox TxtContraModifVen, TextBox TxtNombreModifVen)
        {
            if (validacionVacio(TxtUsuarioModifVen) == false)
            {
                if (validacionVacio(TxtContraModifVen) == false)
                {
                    if (validacionletra(TxtNombreModifVen) == false)
                    {
                        BtnGuardarCambModifVen.Enabled = true;
                    }
                    else { BtnGuardarCambModifVen.Enabled = false; }
                }
                else { BtnGuardarCambModifVen.Enabled = false; }
            }
            else { BtnGuardarCambModifVen.Enabled = false; }
        }           
    }
}
