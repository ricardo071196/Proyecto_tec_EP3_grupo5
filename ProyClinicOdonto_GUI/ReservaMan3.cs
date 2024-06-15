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
    public partial class ReservaMan3 : Form
    {
        OdontologoBL objOdontologoBL = new OdontologoBL();
        ReservaBE objReservaBE = new ReservaBE();
        ReservaBL objReservaBL = new ReservaBL();
        public ReservaMan3()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }
        private void ReservaMan3_Load(object sender, EventArgs e)
        {


            try
            {
                // Primero, asigna los datos al ComboBox cboDistrito
                DataTable dt = objOdontologoBL.ListarOdontologos();
                DataRow dr = dt.NewRow();
                dr["Idodontologo"] = 0;
                dr["Nombres"] = "--Seleccionar--";
                dt.Rows.InsertAt(dr, 0);
                cboOdontologosac.DataSource = dt;
                cboOdontologosac.DisplayMember = "Nombres";
                cboOdontologosac.ValueMember = "Idodontologo";


                objReservaBE = objReservaBL.ConsultarReserva(this.Codigo);

                // Asigna los valores de los controles
                lblIdreserva.Text = Codigo;
                lblDni.Text = objReservaBE.idpaciente;
                cboOdontologosac.SelectedValue = objReservaBE.idodontologo;
                dtpFechaReserac.Text = Convert.ToDateTime(objReservaBE.diaCita).ToString();
                txtHORA.Text = objReservaBE.HoraCita;
                //objOdontologoBE.IdDist = cboDistrito.SelectedValue.ToString();
                txtDetalle.Text = objReservaBE.detalle;

                if (objReservaBE.Estado == true)
                {
                    optActivo.Checked = true;
                }
                else
                {
                    optInactivo.Checked = true;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {


                Boolean activo;
                if (optActivo.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }
                //Pasamos valores alas propiedades de la instancia...

                objReservaBE.idodontologo = cboOdontologosac.SelectedValue.ToString();
                objReservaBE.diaCita = Convert.ToDateTime(dtpFechaReserac.Text);
                objReservaBE.HoraCita = txtHORA.Text;
                objReservaBE.detalle = txtDetalle.Text;
               objReservaBE.Estado = activo;

                //objprofesorBE.FecIng = fechaIng;
                //objprofesorBE.Id_Ubi = cboDep.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                //    cboDistrito.SelectedValue.ToString();
                if (objReservaBL.ActualizarReserva(objReservaBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se insertaron los datos correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    }
