namespace G11_TP_PAV.Formularios.EmaContratoAlquiler
{
    partial class Frm_ContratoAlquiler
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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.NroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propiedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.Escribano = new System.Windows.Forms.Label();
            this.DT_duracion = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_escribano = new G11_TP_PAV.Clases.ComboBox1();
            this.cmb_cliente = new G11_TP_PAV.Clases.ComboBox1();
            this.cmb_Propiedad = new G11_TP_PAV.Clases.ComboBox1();
            this.cmb_tipoMoneda = new G11_TP_PAV.Clases.ComboBox1();
            this.txt_monto = new G11_TP_PAV.Clases.TextBox01();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroFactura,
            this.Propiedad,
            this.Cliente,
            this.Comision,
            this.Monto,
            this.FechaDePago});
            this.DataGrid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGrid.Location = new System.Drawing.Point(393, 95);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(549, 259);
            this.DataGrid.TabIndex = 0;
            // 
            // NroFactura
            // 
            this.NroFactura.HeaderText = "NroFactura";
            this.NroFactura.Name = "NroFactura";
            // 
            // Propiedad
            // 
            this.Propiedad.HeaderText = "Propiedad";
            this.Propiedad.Name = "Propiedad";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Comision
            // 
            this.Comision.HeaderText = "Comision";
            this.Comision.Name = "Comision";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "MontoComision";
            this.Monto.Name = "Monto";
            // 
            // FechaDePago
            // 
            this.FechaDePago.HeaderText = "FechaDePago";
            this.FechaDePago.Name = "FechaDePago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha de Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Duracion de Contrato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo de Moneda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(9, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Propiedad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(9, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cliente";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "Generar Contrato y Factura";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(375, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "Resetear Campos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DT_inicio
            // 
            this.DT_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_inicio.Location = new System.Drawing.Point(182, 95);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(205, 23);
            this.DT_inicio.TabIndex = 18;
            this.DT_inicio.Value = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            this.DT_inicio.ValueChanged += new System.EventHandler(this.DT_inicio1_ValueChanged);
            // 
            // Escribano
            // 
            this.Escribano.AutoSize = true;
            this.Escribano.BackColor = System.Drawing.Color.Teal;
            this.Escribano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Escribano.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Escribano.Location = new System.Drawing.Point(9, 277);
            this.Escribano.Name = "Escribano";
            this.Escribano.Size = new System.Drawing.Size(80, 17);
            this.Escribano.TabIndex = 19;
            this.Escribano.Text = "Escribano";
            // 
            // DT_duracion
            // 
            this.DT_duracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_duracion.Location = new System.Drawing.Point(182, 126);
            this.DT_duracion.Name = "DT_duracion";
            this.DT_duracion.Size = new System.Drawing.Size(205, 23);
            this.DT_duracion.TabIndex = 21;
            this.DT_duracion.Value = new System.DateTime(2022, 5, 25, 0, 0, 0, 0);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(407, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(549, 40);
            this.button3.TabIndex = 22;
            this.button3.Text = "Consultar Facturas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(580, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "Formulario de Contrato de Alquileres y Facturas";
            // 
            // cmb_escribano
            // 
            this.cmb_escribano.FormattingEnabled = true;
            this.cmb_escribano.Location = new System.Drawing.Point(182, 274);
            this.cmb_escribano.Name = "cmb_escribano";
            this.cmb_escribano.Pp_Conseleccion = false;
            this.cmb_escribano.Pp_descripcion = "Apellido";
            this.cmb_escribano.Pp_descripcion2 = "Nombre";
            this.cmb_escribano.Pp_Pk = "matricula";
            this.cmb_escribano.Pp_tabla = "escribanos";
            this.cmb_escribano.Size = new System.Drawing.Size(205, 24);
            this.cmb_escribano.TabIndex = 20;
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(182, 244);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Pp_Conseleccion = false;
            this.cmb_cliente.Pp_descripcion = "nombre";
            this.cmb_cliente.Pp_descripcion2 = "apellido";
            this.cmb_cliente.Pp_Pk = "numero_documento";
            this.cmb_cliente.Pp_tabla = "clientes";
            this.cmb_cliente.Size = new System.Drawing.Size(205, 24);
            this.cmb_cliente.TabIndex = 6;
            // 
            // cmb_Propiedad
            // 
            this.cmb_Propiedad.FormattingEnabled = true;
            this.cmb_Propiedad.Location = new System.Drawing.Point(182, 214);
            this.cmb_Propiedad.Name = "cmb_Propiedad";
            this.cmb_Propiedad.Pp_Conseleccion = false;
            this.cmb_Propiedad.Pp_descripcion = "calle";
            this.cmb_Propiedad.Pp_descripcion2 = "numero";
            this.cmb_Propiedad.Pp_Pk = "designacion_catastral";
            this.cmb_Propiedad.Pp_tabla = "propiedades";
            this.cmb_Propiedad.Size = new System.Drawing.Size(205, 24);
            this.cmb_Propiedad.TabIndex = 5;
            // 
            // cmb_tipoMoneda
            // 
            this.cmb_tipoMoneda.FormattingEnabled = true;
            this.cmb_tipoMoneda.Location = new System.Drawing.Point(182, 184);
            this.cmb_tipoMoneda.Name = "cmb_tipoMoneda";
            this.cmb_tipoMoneda.Pp_Conseleccion = false;
            this.cmb_tipoMoneda.Pp_descripcion = "nombre";
            this.cmb_tipoMoneda.Pp_descripcion2 = null;
            this.cmb_tipoMoneda.Pp_Pk = "id_moneda";
            this.cmb_tipoMoneda.Pp_tabla = "tipo_moneda";
            this.cmb_tipoMoneda.Size = new System.Drawing.Size(205, 24);
            this.cmb_tipoMoneda.TabIndex = 4;
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(182, 155);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Pp_campo = null;
            this.txt_monto.Pp_MensajeError = null;
            this.txt_monto.Pp_tabla = null;
            this.txt_monto.Pp_validable = false;
            this.txt_monto.Size = new System.Drawing.Size(205, 23);
            this.txt_monto.TabIndex = 3;
            // 
            // Frm_ContratoAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(971, 460);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DT_duracion);
            this.Controls.Add(this.cmb_escribano);
            this.Controls.Add(this.Escribano);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.cmb_Propiedad);
            this.Controls.Add(this.cmb_tipoMoneda);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.DataGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ContratoAlquiler";
            this.Text = "Frm_ContratoAlquiler";
            this.Load += new System.EventHandler(this.Frm_ContratoAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private Clases.TextBox01 txt_monto;
        private Clases.ComboBox1 cmb_tipoMoneda;
        private Clases.ComboBox1 cmb_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.Label Escribano;
        private Clases.ComboBox1 cmb_escribano;
        private System.Windows.Forms.DateTimePicker DT_duracion;
        private System.Windows.Forms.Button button3;
        private Clases.ComboBox1 cmb_Propiedad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDePago;
    }
}