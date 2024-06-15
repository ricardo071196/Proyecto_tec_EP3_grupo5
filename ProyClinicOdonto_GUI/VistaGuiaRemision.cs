using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyClinicOdonto_BE;
using ProyClinicOdonto_BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyClinicOdonto_GUI
{
    public partial class VistaGuiaRemision : Form
    {
        //Declaramos las instancias
        GuiaRemisionBL GuiaRemisionBL = new GuiaRemisionBL();
        GuiaRemisionVistaBE GuiaRemisionVistaBE = new GuiaRemisionVistaBE();
        DataView dv = new DataView();

        public VistaGuiaRemision()
        {
            InitializeComponent();
        }

        private void VistaGuiaRemision_Load(object sender, EventArgs e)
        {
        }

        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    GuiaRemisionVistaBE = GuiaRemisionBL.ConsultarGuia(txtCodEquipo.Text);
                    //Preguntamos si se devolvio un resultado
                    if (GuiaRemisionVistaBE != null)
                    {
                        lblNumGuia.Text = GuiaRemisionVistaBE.NumGuia;
                        lblFecEmision.Text = GuiaRemisionVistaBE.FechaEmision.ToString("dd/MM/yyyy");
                        lblFecPartida.Text = GuiaRemisionVistaBE.FechaPartida.ToString("dd/MM/yyyy");
                        lblFecLlegada.Text = GuiaRemisionVistaBE.FechaLlegada.ToString("dd/MM/yyyy");
                        lblProveedor.Text = GuiaRemisionVistaBE.Proveedor;
                        lblRuc.Text = GuiaRemisionVistaBE.Ruc;
                        lblTelefono.Text = GuiaRemisionVistaBE.Telefono;
                        lblDireccion.Text = GuiaRemisionVistaBE.Direccion;
                        lblDistrito.Text = GuiaRemisionVistaBE.NombreDistrito;
                        lblCodEquipo.Text = GuiaRemisionVistaBE.Idequipo;
                        lblNombre.Text = GuiaRemisionVistaBE.NombreEquipo;
                        lblUMedida.Text = GuiaRemisionVistaBE.UdMedidaDescripcion;
                        lblCantidad.Text = GuiaRemisionVistaBE.Cantidad;

                    }
                    else
                    {
                        //Limpiamos los label de resultado...
                        foreach (Control miControl in groupBox1.Controls)
                        {
                            if (miControl.Name.StartsWith("lbl"))
                            {
                                miControl.Text = String.Empty;
                            }
                        }
                        throw new Exception("Medico no existe");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            try
            {
                // Codifique
               GuiaRemisionMan objGuiaRemisionMan = new GuiaRemisionMan();
                objGuiaRemisionMan.ShowDialog();
                //Refrescar datagrid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
