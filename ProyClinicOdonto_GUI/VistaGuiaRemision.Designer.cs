namespace ProyClinicOdonto_GUI
{
    partial class VistaGuiaRemision
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
            label1 = new Label();
            txtCodEquipo = new TextBox();
            groupBox1 = new GroupBox();
            lblCantidad = new Label();
            label17 = new Label();
            lblUMedida = new Label();
            label16 = new Label();
            lblNombre = new Label();
            label14 = new Label();
            lblCodEquipo = new Label();
            label13 = new Label();
            lblDistrito = new Label();
            label11 = new Label();
            lblDireccion = new Label();
            label10 = new Label();
            lblTelefono = new Label();
            label8 = new Label();
            lblRuc = new Label();
            label9 = new Label();
            lblProveedor = new Label();
            label7 = new Label();
            lblFecLlegada = new Label();
            label6 = new Label();
            lblFecPartida = new Label();
            label5 = new Label();
            lblFecEmision = new Label();
            label4 = new Label();
            lblNumGuia = new Label();
            N = new Label();
            btnInsertar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 44);
            label1.Name = "label1";
            label1.Size = new Size(285, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el codigo del equipo:";
            // 
            // txtCodEquipo
            // 
            txtCodEquipo.Location = new Point(323, 48);
            txtCodEquipo.Name = "txtCodEquipo";
            txtCodEquipo.Size = new Size(125, 27);
            txtCodEquipo.TabIndex = 1;
            txtCodEquipo.KeyPress += txtcod_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnInsertar);
            groupBox1.Controls.Add(lblCantidad);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(lblUMedida);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(lblCodEquipo);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(lblDistrito);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lblDireccion);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lblTelefono);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lblRuc);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblProveedor);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblFecLlegada);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblFecPartida);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblFecEmision);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblNumGuia);
            groupBox1.Controls.Add(N);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1497, 517);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la guia de remision:";
            // 
            // lblCantidad
            // 
            lblCantidad.BorderStyle = BorderStyle.FixedSingle;
            lblCantidad.ForeColor = SystemColors.ActiveCaptionText;
            lblCantidad.Location = new Point(1347, 201);
            lblCantidad.Margin = new Padding(5, 0, 5, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(126, 32);
            lblCantidad.TabIndex = 26;
            lblCantidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1251, 210);
            label17.Name = "label17";
            label17.Size = new Size(88, 23);
            label17.TabIndex = 25;
            label17.Text = "Cantidad:";
            // 
            // lblUMedida
            // 
            lblUMedida.BorderStyle = BorderStyle.FixedSingle;
            lblUMedida.ForeColor = SystemColors.ActiveCaptionText;
            lblUMedida.Location = new Point(919, 200);
            lblUMedida.Margin = new Padding(5, 0, 5, 0);
            lblUMedida.Name = "lblUMedida";
            lblUMedida.Size = new Size(324, 193);
            lblUMedida.TabIndex = 24;
            lblUMedida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(637, 209);
            label16.Name = "label16";
            label16.Size = new Size(274, 23);
            label16.TabIndex = 23;
            label16.Text = "Unidad de medida - Descripcion:";
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.ForeColor = SystemColors.ActiveCaptionText;
            lblNombre.Location = new Point(469, 197);
            lblNombre.Margin = new Padding(5, 0, 5, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(163, 32);
            lblNombre.TabIndex = 22;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(294, 206);
            label14.Name = "label14";
            label14.Size = new Size(167, 23);
            label14.TabIndex = 21;
            label14.Text = "Nombre de equipo:";
            // 
            // lblCodEquipo
            // 
            lblCodEquipo.BorderStyle = BorderStyle.FixedSingle;
            lblCodEquipo.ForeColor = SystemColors.ActiveCaptionText;
            lblCodEquipo.Location = new Point(183, 200);
            lblCodEquipo.Margin = new Padding(5, 0, 5, 0);
            lblCodEquipo.Name = "lblCodEquipo";
            lblCodEquipo.Size = new Size(100, 32);
            lblCodEquipo.TabIndex = 20;
            lblCodEquipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 206);
            label13.Name = "label13";
            label13.Size = new Size(159, 23);
            label13.TabIndex = 19;
            label13.Text = "Codigo de equipo:";
            // 
            // lblDistrito
            // 
            lblDistrito.BorderStyle = BorderStyle.FixedSingle;
            lblDistrito.ForeColor = SystemColors.ActiveCaptionText;
            lblDistrito.Location = new Point(1296, 117);
            lblDistrito.Margin = new Padding(5, 0, 5, 0);
            lblDistrito.Name = "lblDistrito";
            lblDistrito.Size = new Size(126, 32);
            lblDistrito.TabIndex = 18;
            lblDistrito.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1212, 123);
            label11.Name = "label11";
            label11.Size = new Size(76, 23);
            label11.TabIndex = 17;
            label11.Text = "Distrito:";
            // 
            // lblDireccion
            // 
            lblDireccion.BorderStyle = BorderStyle.FixedSingle;
            lblDireccion.ForeColor = SystemColors.ActiveCaptionText;
            lblDireccion.Location = new Point(897, 117);
            lblDireccion.Margin = new Padding(5, 0, 5, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(305, 32);
            lblDireccion.TabIndex = 16;
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(799, 126);
            label10.Name = "label10";
            label10.Size = new Size(90, 23);
            label10.TabIndex = 15;
            label10.Text = "Direccion:";
            // 
            // lblTelefono
            // 
            lblTelefono.BorderStyle = BorderStyle.FixedSingle;
            lblTelefono.ForeColor = SystemColors.ActiveCaptionText;
            lblTelefono.Location = new Point(634, 117);
            lblTelefono.Margin = new Padding(5, 0, 5, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(158, 32);
            lblTelefono.TabIndex = 14;
            lblTelefono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(543, 122);
            label8.Name = "label8";
            label8.Size = new Size(83, 23);
            label8.TabIndex = 13;
            label8.Text = "Telefono:";
            // 
            // lblRuc
            // 
            lblRuc.BorderStyle = BorderStyle.FixedSingle;
            lblRuc.ForeColor = SystemColors.ActiveCaptionText;
            lblRuc.Location = new Point(369, 117);
            lblRuc.Margin = new Padding(5, 0, 5, 0);
            lblRuc.Name = "lblRuc";
            lblRuc.Size = new Size(161, 32);
            lblRuc.TabIndex = 12;
            lblRuc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(311, 123);
            label9.Name = "label9";
            label9.Size = new Size(49, 23);
            label9.TabIndex = 11;
            label9.Text = "RUC:";
            // 
            // lblProveedor
            // 
            lblProveedor.BorderStyle = BorderStyle.FixedSingle;
            lblProveedor.ForeColor = SystemColors.ActiveCaptionText;
            lblProveedor.Location = new Point(107, 117);
            lblProveedor.Margin = new Padding(5, 0, 5, 0);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(176, 32);
            lblProveedor.TabIndex = 10;
            lblProveedor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 123);
            label7.Name = "label7";
            label7.Size = new Size(98, 23);
            label7.TabIndex = 9;
            label7.Text = "Proveedor:";
            // 
            // lblFecLlegada
            // 
            lblFecLlegada.BorderStyle = BorderStyle.FixedSingle;
            lblFecLlegada.ForeColor = SystemColors.ActiveCaptionText;
            lblFecLlegada.Location = new Point(1117, 43);
            lblFecLlegada.Margin = new Padding(5, 0, 5, 0);
            lblFecLlegada.Name = "lblFecLlegada";
            lblFecLlegada.Size = new Size(129, 32);
            lblFecLlegada.TabIndex = 8;
            lblFecLlegada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(960, 52);
            label6.Name = "label6";
            label6.Size = new Size(149, 23);
            label6.TabIndex = 7;
            label6.Text = "Fecha de llegada:";
            // 
            // lblFecPartida
            // 
            lblFecPartida.BorderStyle = BorderStyle.FixedSingle;
            lblFecPartida.ForeColor = SystemColors.ActiveCaptionText;
            lblFecPartida.Location = new Point(793, 40);
            lblFecPartida.Margin = new Padding(5, 0, 5, 0);
            lblFecPartida.Name = "lblFecPartida";
            lblFecPartida.Size = new Size(129, 32);
            lblFecPartida.TabIndex = 6;
            lblFecPartida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(645, 52);
            label5.Name = "label5";
            label5.Size = new Size(149, 23);
            label5.TabIndex = 5;
            label5.Text = "Fecha de partida:";
            // 
            // lblFecEmision
            // 
            lblFecEmision.BorderStyle = BorderStyle.FixedSingle;
            lblFecEmision.ForeColor = SystemColors.ActiveCaptionText;
            lblFecEmision.Location = new Point(469, 40);
            lblFecEmision.Margin = new Padding(5, 0, 5, 0);
            lblFecEmision.Name = "lblFecEmision";
            lblFecEmision.Size = new Size(129, 32);
            lblFecEmision.TabIndex = 4;
            lblFecEmision.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 52);
            label4.Name = "label4";
            label4.Size = new Size(152, 23);
            label4.TabIndex = 3;
            label4.Text = "Fecha de emision:";
            // 
            // lblNumGuia
            // 
            lblNumGuia.BorderStyle = BorderStyle.FixedSingle;
            lblNumGuia.ForeColor = Color.Red;
            lblNumGuia.Location = new Point(182, 44);
            lblNumGuia.Margin = new Padding(5, 0, 5, 0);
            lblNumGuia.Name = "lblNumGuia";
            lblNumGuia.Size = new Size(129, 32);
            lblNumGuia.TabIndex = 2;
            lblNumGuia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // N
            // 
            N.AutoSize = true;
            N.Location = new Point(1, 49);
            N.Name = "N";
            N.Size = new Size(173, 23);
            N.TabIndex = 0;
            N.Text = "Guia de Remision N°";
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.ForestGreen;
            btnInsertar.ForeColor = SystemColors.ButtonHighlight;
            btnInsertar.Location = new Point(1280, 456);
            btnInsertar.Margin = new Padding(5, 4, 5, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(209, 54);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar Nueva Guia";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // VistaGuiaRemision
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1521, 624);
            Controls.Add(groupBox1);
            Controls.Add(txtCodEquipo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            Name = "VistaGuiaRemision";
            Text = "VistaGuiaRemision";
            Load += VistaGuiaRemision_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodEquipo;
        private GroupBox groupBox1;
        private Label N;
        internal Label lblCantidad;
        private Label label17;
        internal Label lblUMedida;
        private Label label16;
        internal Label lblNombre;
        private Label label14;
        internal Label lblCodEquipo;
        private Label label13;
        internal Label lblDistrito;
        private Label label11;
        internal Label lblDireccion;
        private Label label10;
        internal Label lblTelefono;
        private Label label8;
        internal Label lblRuc;
        private Label label9;
        internal Label lblProveedor;
        private Label label7;
        internal Label lblFecLlegada;
        private Label label6;
        internal Label lblFecPartida;
        private Label label5;
        internal Label lblFecEmision;
        private Label label4;
        internal Label lblNumGuia;
        private Button btnInsertar;
    }
}