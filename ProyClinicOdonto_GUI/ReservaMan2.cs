using ProyClinicOdonto_BE;
using ProyClinicOdonto_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyClinicOdonto_GUI
{
    public partial class ReservaMan2 : Form
    {

        ReservaBL objReservaBL = new ReservaBL();
        ReservaBE objReservaBE = new ReservaBE();
        OdontologosListaBL objOdontologosListaBL = new OdontologosListaBL();
        public ReservaMan2()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                Boolean activo;
                if (chkActivo.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }

                DateTime fechaIng = dtpFechaReser.Value;
                //Codifique}
                //Validamos
                if (mskPACIENTE.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa un dni porfavor");
                }
                //if (txtIDODONTO.Text.Trim() == String.Empty)
                // {
                //throw new Exception("Ingresa un odontologo porfavor:");
                //}
                if (txtHORA.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa una hora porfavor");
                }
                if (txtDetalle.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa un detalle porfavor:");
                }
                objReservaBE.idpaciente = mskPACIENTE.Text;
                objReservaBE.idodontologo = cboOdontologos.SelectedValue.ToString();
                // objReservaBE.idodontologo = txtIDODONTO.Text;
                objReservaBE.HoraCita = txtHORA.Text;
                objReservaBE.detalle = txtDetalle.Text;
                objReservaBE.Estado = activo;
                objReservaBE.diaCita = fechaIng;

                if (objReservaBL.InsertarReserva(objReservaBE) == true)
                {
                    this.Close();
                }
                else
                {

                    throw new Exception("Disculpa la molestia, trabajaremos para mejorar nuestro sistema.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ReservaMan2_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objOdontologosListaBL.OdontologosLista();
                DataRow dr;
                dr = dt.NewRow();
                dr["Idodontologo"] = 0;
                dr["Odontologo"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboOdontologos.DataSource = dt;
                cboOdontologos.DisplayMember = "Odontologo";
                cboOdontologos.ValueMember = "Idodontologo";
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
