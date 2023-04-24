using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Detalle_Factura
    {
        CD_Detalle_Factura oFactura= new CD_Detalle_Factura(); //SE INSTANCIA LA CAPA DATOS DETALLE FACTURA, SE CREA EL OBJETO
        public void Insertar_DetalleFactura(CE_Factura_Detalles oInsertarFac)
        {
            oFactura.Insertar_DetalleFactura(oInsertarFac);
        }
    }
}
