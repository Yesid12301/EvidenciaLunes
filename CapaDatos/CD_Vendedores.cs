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
    public class CD_Vendedores
    {
        CD_Conexion conexion = new CD_Conexion();
        SqlDataReader Leer;
        SqlCommand Comando = new SqlCommand();
        DataTable Tabla = new DataTable();
        public DataTable Buscarvendedores(CE_Vendedores vendedor) //PARA BUSCAR VENDEDORES DESDE LA CAPA ENTIDADES VENDEDORES
        {
            Tabla.Clear();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "Buscarvendedores";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Usuario", vendedor.Usuario);
            Comando.Parameters.AddWithValue("@Contraseña", vendedor.Contraseña);
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable Buscar_vendedores() //PARA BUSCAR VENDEDORES DESDE LA CAPA ENTIDADES VENDEDORES
        {
            Tabla.Clear();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "Buscar_vendedores";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable BuscarUnvendedor(CE_Vendedores vendedores) //PARA BUSCAR VENDEDORES DESDE LA CAPA ENTIDADES VENDEDORES
        {
            Tabla.Clear();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "BuscarUnvendedores";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Codigo", vendedores.Codigo);
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }
        public void InsertarVendedores(CE_Vendedores vendedores)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "InsertarVendedores";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Codigo", vendedores.Codigo);
            Comando.Parameters.AddWithValue("@Usuario", vendedores.Usuario);
            Comando.Parameters.AddWithValue("@Contraseña", vendedores.Contraseña);
            Comando.Parameters.AddWithValue("@Nombre", vendedores.Nombre);
            Comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void EditarVendedores(CE_Vendedores vendedores)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "EditarVendedores";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Codigo", vendedores.Codigo);
            Comando.Parameters.AddWithValue("@Usuario", vendedores.Usuario);
            Comando.Parameters.AddWithValue("@Contraseña", vendedores.Contraseña);
            Comando.Parameters.AddWithValue("@Nombre", vendedores.Nombre);
            Comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void EliminarVendedor(CE_Vendedores vendedores)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "EliminarVendedor";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Codigo", vendedores.Codigo);
            Comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
