using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class CN_Clientes
    {
        CD_Clientes oCD_Clientes = new CD_Clientes(); //SE INSTANCIA DESDE CAPA DATOS CLIENTES Y SE CREA EL OBJETO.
       
        public DataTable MostrarClientes() 
        {
            DataTable tabla = new DataTable(); //SE CREA LA TABLA MOSTRAR CLIENTES 
            tabla = oCD_Clientes.MostrarClientes(); //LA TABLA ES IGUAL AL OBJETO.MOSTRARCLIENTES
            return tabla;
        }

        public DataTable BuscarUnCliente(CE_Clientes Clientes)
        {
            DataTable tabla = new DataTable();
            tabla = oCD_Clientes.BuscarUnCliente(Clientes);
            return tabla;
        }

        public void Insertar(CE_Clientes clientes)
        {

            oCD_Clientes.Insertar(clientes);

        }
        public void SP_ELIMINARCLIENT(CE_Clientes clientes)
        {
            oCD_Clientes.SP_ELIMINARCLIENT(clientes);
        }
        public void Editar(CE_Clientes clientes)
        {
            oCD_Clientes.Editar(clientes);
        }



    }
}
