using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Prodcutos
    {

        CD_Conexion conexion = new CD_Conexion();
        SqlDataReader Leer;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();
        public DataTable MostrarProductos()//Mostramos todos los productos
        {
            Tabla.Clear();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "BuscarTodosproductos";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable MostrarUnProductos(CE_Productos Productos)// se muestra de un solo producto
        {
            Tabla.Clear();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "BuscarUnproducto";
            Comando.Parameters.AddWithValue("@Codigo",Productos.Codigo);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public void INSERTARPRODUCT(CE_Productos Productos) //Insertamos Productos
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SP_INSERTARPRODUCT";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Codigo", Productos.Codigo);
            Comando.Parameters.AddWithValue("@Descri", Productos.Descri);
            Comando.Parameters.AddWithValue("@ValUnd", Productos.ValUnd);
            Comando.Parameters.AddWithValue("@Cantida", Productos.Cantida);
            Comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void ACTUALIZARPROD(CE_Productos Productos)// Actualizar productos
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SP_ACTUALIZARPROD";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Cod",Productos.Codigo);
            Comando.Parameters.AddWithValue("@CodNew",Productos.Codnew);
            Comando.Parameters.AddWithValue("@Descri",Productos.Descri);
            Comando.Parameters.AddWithValue("@ValUnd",Productos.ValUnd);
            Comando.Parameters.AddWithValue("@Cant",Productos.Cantida);
            Comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void ELIMINARPROD(CE_Productos Productos)//Eliminamos Productos
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SP_ELIMINARPROD";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue ("@Cod",Productos.Codigo);
            Comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

    }
}
