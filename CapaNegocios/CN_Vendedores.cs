using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Vendedores
    {
        CD_Vendedores oCD_Vendedores = new CD_Vendedores();


        public bool Buscarvendedores(CE_Vendedores vendedor) //creamos una tabla buscar vendedores
        {
            DataTable tabla = new DataTable();

            tabla = oCD_Vendedores.Buscarvendedores(vendedor);
            if (tabla.Rows.Count > 0)
            {
                return true;
            }

            else
                return false;
        }
        public DataTable Buscar_vendedores() //PARA BUSCAR VENDEDORES DESDE LA CAPA ENTIDADES VENDEDORES
        {
            DataTable tabla = new DataTable();
            tabla = oCD_Vendedores.Buscar_vendedores();
            return tabla;
            
        }
        public DataTable BuscarUnvendedor(CE_Vendedores vendedores) //PARA BUSCAR VENDEDORES DESDE LA CAPA ENTIDADES VENDEDORES
        {
            DataTable tabla = new DataTable();
            tabla = oCD_Vendedores.BuscarUnvendedor(vendedores);
            return tabla;
            
        }
        public void InsertarVendedores(CE_Vendedores vendedores)
        {
            oCD_Vendedores.InsertarVendedores(vendedores);
        }
        public void EliminarVendedor(CE_Vendedores vendedores)
        {
            oCD_Vendedores.EliminarVendedor(vendedores);
        }
        public void EditarVendedores(CE_Vendedores vendedores)
        {
            oCD_Vendedores.EditarVendedores(vendedores);
        }
    }
}
