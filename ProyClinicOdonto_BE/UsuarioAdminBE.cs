﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_BE
{
   public class UsuarioAdminBE
    {
        public String Login_Usuario { get; set; }
        public String Pass_Usuario { get; set; }

        public Int16 Niv_Usuario { get; set; }

        public Int16 Est_Usuario { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_Registro { get; set; }
    }
}
