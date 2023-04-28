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
        SqlConnection conexion = new SqlConnection("Server =BUCDFPCSEFSD019; DataBase =NaturVida; Integrated Security=true;");//Se inicia la conexion 
        //con la base de datos 
        //SqlConnection conexion = new SqlConnection("Data Source=SQL8005.site4now.net;Initial Catalog=db_a9822f_naturvida;User Id=db_a9822f_naturvida_admin;Password=adso2500695");
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
