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
    public class CD_Clientes
    {
        CD_Conexion conexion = new CD_Conexion();

        SqlDataReader Leer;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        public DataTable MostrarClientes()//Mostramos todos los Clientes
        {
            Tabla.Clear();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SP_BUSCARCLIENTE";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable BuscarUnCliente(CE_Clientes Cliente)
        {
            Tabla.Clear();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "BuscarUnCliente";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Docu", Cliente.Documento);
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }
        public void Insertar(CE_Clientes clientes)
        {
            Comando.Parameters.Clear();
            Comando.Connection=conexion.AbrirConexion();
            Comando.CommandText = "SP_INSERTARCLIENT";
            Comando.CommandType= CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Docu", clientes.Documento);
            Comando.Parameters.AddWithValue("@Nombre", clientes.Nombre);
            Comando.Parameters.AddWithValue("@Direccion", clientes.Direccion);
            Comando.Parameters.AddWithValue("@Tel", clientes.Telefono);
            Comando.Parameters.AddWithValue("@Corr", clientes.Correo);
            Comando.ExecuteNonQuery();
            conexion.CerrarConexion();            
        }
        public void SP_ELIMINARCLIENT(CE_Clientes clientes)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SP_ELIMINARCLIENT";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Docu", clientes.Documento);
            Comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void Editar(CE_Clientes clientes)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SP_ACTUALCLIENT";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Docu", clientes.Documento);
            Comando.Parameters.AddWithValue("@DocuNew", clientes.Documento);
            Comando.Parameters.AddWithValue("@Nombre", clientes.Nombre);
            Comando.Parameters.AddWithValue("@Direccion", clientes.Direccion);
            Comando.Parameters.AddWithValue("@Tel", clientes.Telefono);
            Comando.Parameters.AddWithValue("@Corr", clientes.Correo);
            Comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
