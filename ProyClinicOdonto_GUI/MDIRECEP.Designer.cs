﻿namespace ProyClinicOdonto_GUI
{
    partial class MDIRECEP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            lblEquipo = new ToolStripStatusLabel();
            lblTiempo = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            accionesToolStripMenuItem = new ToolStripMenuItem();
            MantenimientoPaciente = new ToolStripMenuItem();
            verEquiposToolStripMenuItem = new ToolStripMenuItem();
            verOdontologosToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoCitasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEquipo, lblTiempo, lblUsuario });
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblEquipo
            // 
            lblEquipo.BackColor = SystemColors.ActiveCaptionText;
            lblEquipo.ForeColor = SystemColors.ButtonHighlight;
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(59, 20);
            lblEquipo.Text = "Equipo:";
            // 
            // lblTiempo
            // 
            lblTiempo.BackColor = SystemColors.ControlDark;
            lblTiempo.ForeColor = SystemColors.ControlLightLight;
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(63, 20);
            lblTiempo.Text = "Tiempo:";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = SystemColors.ControlDarkDark;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(18, 20);
            lblUsuario.Text = "...";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accionesToolStripMenuItem, consultaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            accionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MantenimientoPaciente, verEquiposToolStripMenuItem, verOdontologosToolStripMenuItem, mantenimientoCitasToolStripMenuItem, salirToolStripMenuItem });
            accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            accionesToolStripMenuItem.Size = new Size(82, 24);
            accionesToolStripMenuItem.Text = "Acciones";
            // 
            // MantenimientoPaciente
            // 
            MantenimientoPaciente.Name = "MantenimientoPaciente";
            MantenimientoPaciente.Size = new Size(258, 26);
            MantenimientoPaciente.Text = "Mantenimiento Pacientes";
            MantenimientoPaciente.Click += mantenimientoEquiposToolStripMenuItem_Click;
            // 
            // verEquiposToolStripMenuItem
            // 
            verEquiposToolStripMenuItem.Name = "verEquiposToolStripMenuItem";
            verEquiposToolStripMenuItem.Size = new Size(258, 26);
            verEquiposToolStripMenuItem.Text = "Ver Equipos";
            verEquiposToolStripMenuItem.Click += verEquiposToolStripMenuItem_Click;
            // 
            // verOdontologosToolStripMenuItem
            // 
            verOdontologosToolStripMenuItem.Name = "verOdontologosToolStripMenuItem";
            verOdontologosToolStripMenuItem.Size = new Size(258, 26);
            verOdontologosToolStripMenuItem.Text = "Ver Odontologos";
            verOdontologosToolStripMenuItem.Click += verOdontologosToolStripMenuItem_Click;
            // 
            // mantenimientoCitasToolStripMenuItem
            // 
            mantenimientoCitasToolStripMenuItem.Name = "mantenimientoCitasToolStripMenuItem";
            mantenimientoCitasToolStripMenuItem.Size = new Size(258, 26);
            mantenimientoCitasToolStripMenuItem.Text = "Mantenimiento Citas";
            mantenimientoCitasToolStripMenuItem.Click += mantenimientoCitasToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(258, 26);
            salirToolStripMenuItem.Text = "Cerrar Sesion";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(14, 24);
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MDIRECEP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.consultorio_medico_vacio_equipos_e_instrumentos_482257_27314;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 451);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Name = "MDIRECEP";
            Text = "MDIRECEP";
            WindowState = FormWindowState.Maximized;
            Load += MDIRECEP_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblEquipo;
        private ToolStripStatusLabel lblTiempo;
        private ToolStripStatusLabel lblUsuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem accionesToolStripMenuItem;
        private ToolStripMenuItem MantenimientoPaciente;
        private ToolStripMenuItem mantenimientoCitasToolStripMenuItem;
        private ToolStripMenuItem verEquiposToolStripMenuItem;
        private ToolStripMenuItem verOdontologosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}