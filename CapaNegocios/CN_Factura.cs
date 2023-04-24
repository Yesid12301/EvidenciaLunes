using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Factura
    {
        CD_Factura oCD_Factura = new CD_Factura();
        public int BuscarFactura()
        {
            return oCD_Factura.BuscarFactura();
        }
        public void InsertarFactura(CE_Factura oInsertarFac)
        {
            oCD_Factura.InsertarFactura(oInsertarFac);
        }
    }
    
}
