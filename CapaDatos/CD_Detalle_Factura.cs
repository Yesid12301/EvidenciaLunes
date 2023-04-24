using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class CD_Detalle_Factura
    {
        CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        
        public void Insertar_DetalleFactura(CE_Factura_Detalles oDetalleFact)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_AGGFACTDETA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDFac", oDetalleFact.Numero_Factura);
            comando.Parameters.AddWithValue("@CodProd", oDetalleFact.Codigo_Productos);
            comando.Parameters.AddWithValue("@Cant", oDetalleFact.Cantidad);
            comando.Parameters.AddWithValue("@ValUnidad", oDetalleFact.Valor_Unidad);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
