namespace ProyClinicOdonto_GUI
{
    partial class ReservaMan3
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
            grpDatos = new GroupBox();
            groupBox1 = new GroupBox();
            optInactivo = new RadioButton();
            optActivo = new RadioButton();
            label10 = new Label();
            cboOdontologosac = new ComboBox();
            txtHORA = new TextBox();
            label4 = new Label();
            txtDetalle = new TextBox();
            label3 = new Label();
            dtpFechaReserac = new DateTimePicker();
            label9 = new Label();
            lblIdreserva = new Label();
            lblNumSerie = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label2 = new Label();
            label1 = new Label();
            lblDni = new Label();
            grpDatos.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblDni);
            grpDatos.Controls.Add(groupBox1);
            grpDatos.Controls.Add(label10);
            grpDatos.Controls.Add(cboOdontologosac);
            grpDatos.Controls.Add(txtHORA);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(txtDetalle);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(dtpFechaReserac);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(lblIdreserva);
            grpDatos.Controls.Add(lblNumSerie);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatos.ForeColor = SystemColors.ButtonHighlight;
            grpDatos.Location = new Point(105, 20);
            grpDatos.Margin = new Padding(4, 3, 4, 3);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4, 3, 4, 3);
            grpDatos.Size = new Size(604, 547);
            grpDatos.TabIndex = 2;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optInactivo);
            groupBox1.Controls.Add(optActivo);
            groupBox1.Location = new Point(207, 311);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(214, 40);
            groupBox1.TabIndex = 53;
            groupBox1.TabStop = false;
            // 
            // optInactivo
            // 
            optInactivo.AutoSize = true;
            optInactivo.Location = new Point(116, 18);
            optInactivo.Margin = new Padding(3, 2, 3, 2);
            optInactivo.Name = "optInactivo";
            optInactivo.Size = new Size(80, 21);
            optInactivo.TabIndex = 1;
            optInactivo.TabStop = true;
            optInactivo.Text = "Inactivo";
            optInactivo.UseVisualStyleBackColor = true;
            // 
            // optActivo
            // 
            optActivo.AutoSize = true;
            optActivo.Location = new Point(16, 18);
            optActivo.Margin = new Padding(3, 2, 3, 2);
            optActivo.Name = "optActivo";
            optActivo.Size = new Size(69, 21);
            optActivo.TabIndex = 0;
            optActivo.TabStop = true;
            optActivo.Text = "Activo";
            optActivo.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 324);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(134, 17);
            label10.TabIndex = 52;
            label10.Text = "Estado de Reserva.";
            // 
            // cboOdontologosac
            // 
            cboOdontologosac.BackColor = SystemColors.ScrollBar;
            cboOdontologosac.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOdontologosac.FormattingEnabled = true;
            cboOdontologosac.Location = new Point(207, 115);
            cboOdontologosac.Margin = new Padding(3, 2, 3, 2);
            cboOdontologosac.Name = "cboOdontologosac";
            cboOdontologosac.Size = new Size(222, 25);
            cboOdontologosac.TabIndex = 50;
            cboOdontologosac.UseWaitCursor = true;
            // 
            // txtHORA
            // 
            txtHORA.Cursor = Cursors.IBeam;
            txtHORA.Location = new Point(207, 214);
            txtHORA.Margin = new Padding(4, 3, 4, 3);
            txtHORA.Name = "txtHORA";
            txtHORA.Size = new Size(93, 24);
            txtHORA.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 259);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 47;
            label4.Text = "Detalle:";
            // 
            // txtDetalle
            // 
            txtDetalle.Cursor = Cursors.IBeam;
            txtDetalle.Location = new Point(207, 259);
            txtDetalle.Margin = new Padding(4, 3, 4, 3);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(244, 24);
            txtDetalle.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 216);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 45;
            label3.Text = "Hora cita:";
            // 
            // dtpFechaReserac
            // 
            dtpFechaReserac.Location = new Point(207, 164);
            dtpFechaReserac.Margin = new Padding(3, 2, 3, 2);
            dtpFechaReserac.Name = "dtpFechaReserac";
            dtpFechaReserac.Size = new Size(324, 24);
            dtpFechaReserac.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 171);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(84, 17);
            label9.TabIndex = 44;
            label9.Text = "Fecha cita:";
            // 
            // lblIdreserva
            // 
            lblIdreserva.BorderStyle = BorderStyle.FixedSingle;
            lblIdreserva.Location = new Point(207, 28);
            lblIdreserva.Margin = new Padding(4, 0, 4, 0);
            lblIdreserva.Name = "lblIdreserva";
            lblIdreserva.Size = new Size(100, 20);
            lblIdreserva.TabIndex = 0;
            lblIdreserva.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumSerie
            // 
            lblNumSerie.AutoSize = true;
            lblNumSerie.Location = new Point(36, 29);
            lblNumSerie.Name = "lblNumSerie";
            lblNumSerie.Size = new Size(77, 17);
            lblNumSerie.TabIndex = 0;
            lblNumSerie.Text = "IdReserva:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Location = new Point(426, 438);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 38);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(263, 438);
            btnGrabar.Margin = new Padding(3, 2, 3, 2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(105, 38);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 117);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 17);
            label2.TabIndex = 4;
            label2.Text = "Odontologo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 17);
            label1.TabIndex = 2;
            label1.Text = "Dni:";
            // 
            // lblDni
            // 
            lblDni.BorderStyle = BorderStyle.FixedSingle;
            lblDni.Location = new Point(207, 66);
            lblDni.Margin = new Padding(4, 0, 4, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(100, 20);
            lblDni.TabIndex = 54;
            lblDni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReservaMan3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(819, 585);
            Controls.Add(grpDatos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReservaMan3";
            Text = "ReservaMan3";
            Load += ReservaMan3_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        internal Label lblIdreserva;
        private Label lblNumSerie;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label2;
        private Label label1;
        private TextBox txtHORA;
        private Label label4;
        private TextBox txtDetalle;
        private Label label3;
        private DateTimePicker dtpFechaReserac;
        private Label label9;
        private ComboBox cboOdontologosac;
        private GroupBox groupBox1;
        private RadioButton optInactivo;
        private RadioButton optActivo;
        private Label label10;
        internal Label lblDni;
    }
}