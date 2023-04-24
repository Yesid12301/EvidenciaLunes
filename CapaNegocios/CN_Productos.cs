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
    public class CN_Productos  // En esta capa Mostramos,Editamos,Insertamos,eliminamos Productos
    {
        CD_Prodcutos oCD_Productos = new CD_Prodcutos();
        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = oCD_Productos.MostrarProductos();
            return tabla;
        }
        public DataTable MostrarUnProductos(CE_Productos productos)
        {
            DataTable tabla = new DataTable();
            tabla = oCD_Productos.MostrarUnProductos(productos);
            return tabla;
        }
        public void INSERTARPRODUCT(CE_Productos productos)
        {
            oCD_Productos.INSERTARPRODUCT(productos);
        }

        public void ACTUALIZARPROD(CE_Productos productos)
        {
            oCD_Productos.ACTUALIZARPROD(productos);
        }
        public void ELIMINARPROD(CE_Productos productos)
        {
            oCD_Productos.ELIMINARPROD(productos);
        }
    }
}
