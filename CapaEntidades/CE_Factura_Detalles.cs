using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_Factura_Detalles   //CAPA ENTIDADES FACTURA DETALLE , SE TRAE IGUAL DESDE LA BD
    {
        public int Numero_Factura {get; set;}
        public int Codigo_Productos { get; set;}
        public int Cantidad { get; set;}
        public int Valor_Unidad { get; set;}
    }
}

 

