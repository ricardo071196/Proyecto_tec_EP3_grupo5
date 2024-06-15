using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyClinicOdonto_ADO;
using ProyClinicOdonto_BE;

namespace ProyClinicOdonto_BL
{
    public class GuiaRemisionBL
    {
        GuiaRemisionADO objGuiaRemisionADO = new GuiaRemisionADO();
        public Boolean InsertarGuia(GuiaRemisionBE objGuiaRemisionBE)
        {
            return objGuiaRemisionADO.InsertarGuia(objGuiaRemisionBE);
        }
        public GuiaRemisionVistaBE ConsultarGuia(String strCodigo)
        {
            return objGuiaRemisionADO.ConsultarGuia(strCodigo);
        }
    }
}
