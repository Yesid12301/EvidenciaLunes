﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_Vendedores //CAPA ENTIDADES VENDEDORES , SE TRAE IGUAL DESDE LA BD
    {
        public int Codigo { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
    }
}