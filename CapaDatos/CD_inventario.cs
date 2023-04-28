using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_inventario
    {
        CD_Conexion conexion = new CD_Conexion();
        SqlDataReader Leer;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        public DataTable BUSCARINVENTARIOS()//Mostramos todos los Clientes
        {
            Tabla.Clear();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SP_BUSCARINVENTARIOS";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable BUSCARINVENTARIO(int codigo)//Mostramos todos los Clientes
        {
            Tabla.Clear();
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "SP_BUSCARINVENTARIO";
            Comando.Parameters.AddWithValue("@Prod", codigo);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }


    }
}
