using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_inventario
    {
        CD_inventario oCD_inventario = new CD_inventario();

        public DataTable BuscarInventario()//Mostramos todos los Clientes
        {
            DataTable dt= new DataTable();
            dt = oCD_inventario.BuscarInventario();
            return dt;
        }
    }
}
