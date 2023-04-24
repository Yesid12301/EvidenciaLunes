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
    public class CD_Factura
    {
        CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader Leer;
        DataTable Tabla = new DataTable();

        public int BuscarFactura()//Mostramos todas las Facturas
        {
            int numfactura = 0;
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarFactura";
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader Leer = comando.ExecuteReader();
            try
            {
                if (Leer.Read())
                {
                    numfactura= Convert.ToInt32(Leer["IdFactu"].ToString());
                }
            }
            catch (Exception) 
            {
                numfactura = 0;
            }
            conexion.CerrarConexion();
            return numfactura;
        }
        public void InsertarFactura(CE_Factura oFactura)//INSERTAMOS DATOS A LA FACTURA
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_AGGFACT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fech",oFactura.Fecha);
            comando.Parameters.AddWithValue("@DoClient", oFactura.Documento_Cliente);
            comando.Parameters.AddWithValue("@CodVende", oFactura.Codigo_Vendedor);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
