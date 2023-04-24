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
    public partial class Gestion_Productos : Form
    {
        public Gestion_Productos()
        {
            InitializeComponent();
        }
        CN_Productos oCN_Productos= new CN_Productos();
        CN_Productos oCN_Productos2 = new CN_Productos();
        CE_Productos productos= new CE_Productos();
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            productos.Codigo = Convert.ToInt32(TxtCodigo.Text);
            productos.Descri =(TxtDescripcion.Text);
            productos.ValUnd =Convert.ToInt32(TxtValor.Text);
            productos.Cantida = Convert.ToInt32(TxtCantidad.Text);
            try
            {
                oCN_Productos.INSERTARPRODUCT(productos);
                MessageBox.Show("Producto Ingresado Corrrectamente");
                BuscarProductos();
                DgvProductos.DataSource = oCN_Productos.MostrarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Inserto NADAAAA");
            }
            TxtCodigo.Text = String.Empty;
            TxtDescripcion.Text = String.Empty;
            TxtValor.Text = String.Empty;
            TxtCantidad.Text = String.Empty;
        }
        private void Gestion_Productos_Load(object sender, EventArgs e)
        {
            DgvProductos.DataSource = oCN_Productos.MostrarProductos();
            BuscarProductos();
            BtnGuardar.Enabled = false;
            BtnGuardarCambios.Enabled = false;
        }
        private void BuscarProductos()
        {
            CbxProductos.DataSource= oCN_Productos2.MostrarProductos();
            CbxProductos.ValueMember= "Codigo";
            CbxProductos.DisplayMember = "Descripción";

            CbxProductoModificar.DataSource = oCN_Productos2.MostrarProductos();
            CbxProductoModificar.ValueMember = "Codigo";
            CbxProductoModificar.DisplayMember = "Descripción";

            CbxEliminar.DataSource = oCN_Productos2.MostrarProductos();
            CbxEliminar.ValueMember = "Codigo";
            CbxEliminar.DisplayMember = "Descripción";
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            productos.Codigo = Convert.ToInt32(CbxProductos.SelectedValue.ToString());
            DgvProductos.DataSource = oCN_Productos.MostrarUnProductos(productos);
        }
        private void BtnMostrarTodo_Click(object sender, EventArgs e)
        {
            DgvProductos.DataSource = oCN_Productos.MostrarProductos();
            BuscarProductos();
        }
        private void BtnConsultarModifi_Click(object sender, EventArgs e)
        {
            productos.Codigo=Convert.ToInt32(CbxProductoModificar.SelectedValue.ToString());
            DataTable dtProductos = oCN_Productos.MostrarUnProductos(productos);
            TxtCodigoModificar.Text=productos.Codigo.ToString();
            TxtDescripcionModificar.Text = dtProductos.Rows[0]["Descripción"].ToString();
            TxtValorModificar.Text= dtProductos.Rows[0]["Valor_Unidad"].ToString() ;
            TxtCantidadModificar.Text = dtProductos.Rows[0]["Cantidad"].ToString();
        }
        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            productos.Codnew = Convert.ToInt32(TxtCodigoModificar.Text);
            productos.Descri = (TxtDescripcionModificar.Text);
            productos.ValUnd = Convert.ToInt32(TxtValorModificar.Text);
            productos.Cantida = Convert.ToInt32(TxtCantidadModificar.Text);
                        
            try
            {
                oCN_Productos.ACTUALIZARPROD(productos);
                MessageBox.Show("Producto Editado Corrrectamente");
                BuscarProductos();
                DgvProductos.DataSource = oCN_Productos.MostrarProductos();
            }
            catch (Exception)
            {
                MessageBox.Show("No se Edito NADAAAA");
            }
            TxtCodigoModificar.Text = String.Empty;
            TxtDescripcionModificar.Text = String.Empty;
            TxtValorModificar.Text = String.Empty;
            TxtCantidadModificar.Text = String.Empty;
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            productos.Codigo= Convert.ToInt32(CbxEliminar.SelectedValue.ToString());
            oCN_Productos.ELIMINARPROD(productos);
            BuscarProductos();
            DgvProductos.DataSource = oCN_Productos.MostrarProductos();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCodigo.Text=String.Empty;
            TxtDescripcion.Text=String.Empty;
            TxtValor.Text=String.Empty;
            TxtCantidad.Text=String.Empty;
        }
        //Validacion de los campos de ingresar productos
        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            validacionInsertar(TxtCodigo, TxtValor, TxtCantidad, TxtDescripcion);
        }
        private void TxtValor_TextChanged(object sender, EventArgs e)
        {
            validacionInsertar(TxtCodigo, TxtValor, TxtCantidad, TxtDescripcion);
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            validacionInsertar(TxtCodigo, TxtValor, TxtCantidad, TxtDescripcion);
        }
        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            validacionInsertar(TxtCodigo, TxtValor, TxtCantidad, TxtDescripcion);
        }
        
        private void validacionInsertar(TextBox TxtCodigo, TextBox TxtValor, TextBox TxtCantidad, TextBox TxtDescripcion)
        {
            if (validacionNumero(TxtCodigo) == false)
            {
                if (validacionNumero(TxtValor) == false)
                {
                    if (validacionNumero(TxtCantidad) == false)
                    {
                        if (validacionletra(TxtDescripcion) == false)
                        {
                            BtnGuardar.Enabled = true;
                        }
                        else
                        {
                            BtnGuardar.Enabled = false;
                        }
                    }
                    else
                    {
                        BtnGuardar.Enabled = false;
                    }
                }
                else
                {
                    BtnGuardar.Enabled = false;
                }
            }
            else
            {
                BtnGuardar.Enabled = false;
            }
        }

        //validacion de los campos de editar productos
        private void TxtCodigoModificar_TextChanged(object sender, EventArgs e)
        {
            validacionEditar(TxtCodigoModificar, TxtValorModificar, TxtCantidadModificar, TxtDescripcionModificar);
        }

        private void TxtDescripcionModificar_TextChanged(object sender, EventArgs e)
        {
            validacionEditar(TxtCodigoModificar, TxtValorModificar, TxtCantidadModificar, TxtDescripcionModificar);
        }

        private void TxtValorModificar_TextChanged(object sender, EventArgs e)
        {
            validacionEditar(TxtCodigoModificar, TxtValorModificar, TxtCantidadModificar, TxtDescripcionModificar);
        }

        private void TxtCantidadModificar_TextChanged(object sender, EventArgs e)
        {
            validacionEditar(TxtCodigoModificar, TxtValorModificar, TxtCantidadModificar, TxtDescripcionModificar);
        }
        private void validacionEditar(TextBox TxtCodigo, TextBox TxtValor, TextBox TxtCantidad, TextBox TxtDescripcion)
        {
            if (validacionNumero(TxtCodigo) == false)
            {
                if (validacionNumero(TxtValor) == false)
                {
                    if (validacionNumero(TxtCantidad) == false)
                    {
                        if (validacionletra(TxtDescripcion) == false)
                        {
                            BtnGuardarCambios.Enabled = true;
                        }
                        else
                        {
                            BtnGuardarCambios.Enabled = false;
                        }
                    }
                    else
                    {
                        BtnGuardarCambios.Enabled = false;
                    }
                }
                else
                {
                    BtnGuardarCambios.Enabled = false;
                }
            }
            else
            {
                BtnGuardarCambios.Enabled = false;
            }
        }


        //dos metodos para validar numero y letras
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
                if (!char.IsLetter(c))
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

    }
}
