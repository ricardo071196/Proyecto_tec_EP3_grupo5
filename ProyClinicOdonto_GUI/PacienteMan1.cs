﻿using ProyClinicOdonto_BE;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProyClinicOdonto_GUI
{
    public partial class PacienteMan1 : Form
    {
        PacienteBL objPacienteBL = new PacienteBL();
        DataView dtv;
        public PacienteMan1()
        {
            InitializeComponent();
        }


        private void dtgPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                PacienteMan3 objPacien3 = new PacienteMan3();
                objPacien3.Codigo = dtgPaciente.CurrentRow.Cells[0].Value.ToString();
                // Codifique
                objPacien3.ShowDialog();
                //Refrescar datagrid
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                PacienteMan2 objOdon2 = new PacienteMan2();
                objOdon2.ShowDialog();
                //Refrescar datagrid
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void PacienteMan1_Load_1(object sender, EventArgs e)
        {
            CargarDatos("");
        }
        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objPacienteBL.ListarPacientes());
            dtv.RowFilter = "Nombres like '%" + strFiltro + "%'";
            dtgPaciente.DataSource = dtv;
            lblRegistros.Text = dtgPaciente.Rows.Count.ToString();

        }
        private void dtgPaciente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFiltro_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                PacienteMan3 objPaci3 = new PacienteMan3();
                objPaci3.Codigo = dtgPaciente.CurrentRow.Cells[0].Value.ToString();
                // Codifique
                objPaci3.ShowDialog();
                //Refrescar datagrid
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.Close();

            ReservaMan1 objReserva1 = new ReservaMan1();
            objReserva1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            VistaEquipo objVistaEquipo1 = new VistaEquipo();
            objVistaEquipo1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            VistaOdontologo objVistaOdontologo1 = new VistaOdontologo();
            objVistaOdontologo1.Show();
        }
    }
}
