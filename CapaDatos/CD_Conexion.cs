using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        SqlConnection conexion = new SqlConnection("Server =YESID\\YESIDSQL; DataBase =NaturVida; Integrated Security=true;");//Se inicia la conexion 
        //con la base de datos 
        public SqlConnection AbrirConexion()
        {
            if (conexion.State ==System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
