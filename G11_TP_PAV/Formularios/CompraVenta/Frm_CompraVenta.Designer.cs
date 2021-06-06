
namespace G11_TP_PAV.Formularios.CompraVenta
{
    partial class Frm_CompraVenta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_DesignCatastral = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Escribano = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.gdr_CompraVenta = new System.Windows.Forms.DataGridView();
            this.Id_CompraVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propiedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_RegistrarVenta = new System.Windows.Forms.Button();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.btn_FechaActual = new System.Windows.Forms.Button();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.txt_FechaActual = new G11_TP_PAV.Clases.MaskedTextBoxHeredado();
            this.txt_FechaPago = new G11_TP_PAV.Clases.MaskedTextBoxHeredado();
            this.txt_Escribano = new G11_TP_PAV.Clases.TextBoxHeredado();
            this.txt_Monto = new G11_TP_PAV.Clases.MaskedTextBoxHeredado();
            this.cmb_TipoMoneda = new G11_TP_PAV.Clases.ComboBoxHeredadaE();
            this.txt_Cliente = new G11_TP_PAV.Clases.TextBoxHeredado();
            this.txt_DesignCatastral = new G11_TP_PAV.Clases.TextBoxHeredado();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_CompraVenta)).BeginInit();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registro de CompraVenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Monto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo de Moneda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Designacion Catastral:";
            // 
            // btn_DesignCatastral
            // 
            this.btn_DesignCatastral.BackgroundImage = global::G11_TP_PAV.Properties.Resources.search_buscar;
            this.btn_DesignCatastral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_DesignCatastral.Location = new System.Drawing.Point(290, 105);
            this.btn_DesignCatastral.Name = "btn_DesignCatastral";
            this.btn_DesignCatastral.Size = new System.Drawing.Size(29, 23);
            this.btn_DesignCatastral.TabIndex = 2;
            this.btn_DesignCatastral.UseVisualStyleBackColor = true;
            this.btn_DesignCatastral.Click += new System.EventHandler(this.btn_DesignCatastral_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cliente:";
            // 
            // btn_Escribano
            // 
            this.btn_Escribano.BackgroundImage = global::G11_TP_PAV.Properties.Resources.search_buscar;
            this.btn_Escribano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Escribano.Location = new System.Drawing.Point(290, 257);
            this.btn_Escribano.Name = "btn_Escribano";
            this.btn_Escribano.Size = new System.Drawing.Size(29, 23);
            this.btn_Escribano.TabIndex = 6;
            this.btn_Escribano.UseVisualStyleBackColor = true;
            this.btn_Escribano.Click += new System.EventHandler(this.btn_Escribano_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Escribano:";
            // 
            // gdr_CompraVenta
            // 
            this.gdr_CompraVenta.AllowUserToAddRows = false;
            this.gdr_CompraVenta.AllowUserToDeleteRows = false;
            this.gdr_CompraVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_CompraVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_CompraVenta,
            this.Fecha,
            this.Cliente,
            this.Propiedad,
            this.MontoTotal,
            this.Moneda,
            this.Factura});
            this.gdr_CompraVenta.Location = new System.Drawing.Point(438, 55);
            this.gdr_CompraVenta.Name = "gdr_CompraVenta";
            this.gdr_CompraVenta.ReadOnly = true;
            this.gdr_CompraVenta.Size = new System.Drawing.Size(693, 304);
            this.gdr_CompraVenta.TabIndex = 2;
            // 
            // Id_CompraVenta
            // 
            this.Id_CompraVenta.HeaderText = "ID";
            this.Id_CompraVenta.Name = "Id_CompraVenta";
            this.Id_CompraVenta.ReadOnly = true;
            this.Id_CompraVenta.Width = 50;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Propiedad
            // 
            this.Propiedad.HeaderText = "Propiedad";
            this.Propiedad.Name = "Propiedad";
            this.Propiedad.ReadOnly = true;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "MontoTotal";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura Asociada";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            // 
            // btn_RegistrarVenta
            // 
            this.btn_RegistrarVenta.Location = new System.Drawing.Point(157, 365);
            this.btn_RegistrarVenta.Name = "btn_RegistrarVenta";
            this.btn_RegistrarVenta.Size = new System.Drawing.Size(195, 23);
            this.btn_RegistrarVenta.TabIndex = 1;
            this.btn_RegistrarVenta.Text = "Registrar CompraVenta";
            this.btn_RegistrarVenta.UseVisualStyleBackColor = true;
            this.btn_RegistrarVenta.Click += new System.EventHandler(this.btn_RegistrarVenta_Click);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.btn_FechaActual);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Controls.Add(this.btn_Cliente);
            this.groupBoxDatos.Controls.Add(this.txt_FechaActual);
            this.groupBoxDatos.Controls.Add(this.btn_Escribano);
            this.groupBoxDatos.Controls.Add(this.label4);
            this.groupBoxDatos.Controls.Add(this.label9);
            this.groupBoxDatos.Controls.Add(this.txt_FechaPago);
            this.groupBoxDatos.Controls.Add(this.txt_Escribano);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Controls.Add(this.txt_Monto);
            this.groupBoxDatos.Controls.Add(this.label8);
            this.groupBoxDatos.Controls.Add(this.cmb_TipoMoneda);
            this.groupBoxDatos.Controls.Add(this.txt_Cliente);
            this.groupBoxDatos.Controls.Add(this.label6);
            this.groupBoxDatos.Controls.Add(this.btn_DesignCatastral);
            this.groupBoxDatos.Controls.Add(this.txt_DesignCatastral);
            this.groupBoxDatos.Controls.Add(this.label7);
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 55);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(420, 304);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Ingreso de Datos";
            // 
            // btn_FechaActual
            // 
            this.btn_FechaActual.BackgroundImage = global::G11_TP_PAV.Properties.Resources.date_fechaActual;
            this.btn_FechaActual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FechaActual.Location = new System.Drawing.Point(290, 29);
            this.btn_FechaActual.Name = "btn_FechaActual";
            this.btn_FechaActual.Size = new System.Drawing.Size(29, 32);
            this.btn_FechaActual.TabIndex = 0;
            this.btn_FechaActual.UseVisualStyleBackColor = true;
            this.btn_FechaActual.Click += new System.EventHandler(this.btn_FechaActual_Click);
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.BackgroundImage = global::G11_TP_PAV.Properties.Resources.search_buscar;
            this.btn_Cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cliente.Location = new System.Drawing.Point(290, 74);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(29, 25);
            this.btn_Cliente.TabIndex = 1;
            this.btn_Cliente.UseVisualStyleBackColor = true;
            this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
            // 
            // txt_FechaActual
            // 
            this.txt_FechaActual.Enabled = false;
            this.txt_FechaActual.Location = new System.Drawing.Point(184, 34);
            this.txt_FechaActual.Mask = "99/99/9999";
            this.txt_FechaActual.Name = "txt_FechaActual";
            this.txt_FechaActual.Pp_MaskxDefecto = null;
            this.txt_FechaActual.Pp_MensajeError = "\"No Hay Fecha Actual\"";
            this.txt_FechaActual.Pp_NombreCampo = "Fecha Actual";
            this.txt_FechaActual.Pp_NombreTabla = null;
            this.txt_FechaActual.Pp_Validable = false;
            this.txt_FechaActual.Size = new System.Drawing.Size(72, 23);
            this.txt_FechaActual.TabIndex = 0;
            this.txt_FechaActual.ValidatingType = typeof(System.DateTime);
            // 
            // txt_FechaPago
            // 
            this.txt_FechaPago.Location = new System.Drawing.Point(184, 174);
            this.txt_FechaPago.Mask = "99/99/9999";
            this.txt_FechaPago.Name = "txt_FechaPago";
            this.txt_FechaPago.Pp_MaskxDefecto = null;
            this.txt_FechaPago.Pp_MensajeError = null;
            this.txt_FechaPago.Pp_NombreCampo = null;
            this.txt_FechaPago.Pp_NombreTabla = null;
            this.txt_FechaPago.Pp_Validable = false;
            this.txt_FechaPago.Size = new System.Drawing.Size(72, 23);
            this.txt_FechaPago.TabIndex = 4;
            this.txt_FechaPago.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Escribano
            // 
            this.txt_Escribano.Enabled = false;
            this.txt_Escribano.Location = new System.Drawing.Point(184, 257);
            this.txt_Escribano.Name = "txt_Escribano";
            this.txt_Escribano.Pp_MensajeError = null;
            this.txt_Escribano.Pp_NombreCampo = null;
            this.txt_Escribano.Pp_NombreTabla = null;
            this.txt_Escribano.Pp_Validable = false;
            this.txt_Escribano.Size = new System.Drawing.Size(100, 23);
            this.txt_Escribano.TabIndex = 16;
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(184, 133);
            this.txt_Monto.Mask = "99999999.99";
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Pp_MaskxDefecto = null;
            this.txt_Monto.Pp_MensajeError = null;
            this.txt_Monto.Pp_NombreCampo = null;
            this.txt_Monto.Pp_NombreTabla = null;
            this.txt_Monto.Pp_Validable = false;
            this.txt_Monto.Size = new System.Drawing.Size(83, 23);
            this.txt_Monto.TabIndex = 3;
            this.txt_Monto.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_TipoMoneda
            // 
            this.cmb_TipoMoneda.FormattingEnabled = true;
            this.cmb_TipoMoneda.Location = new System.Drawing.Point(184, 215);
            this.cmb_TipoMoneda.Name = "cmb_TipoMoneda";
            this.cmb_TipoMoneda.Pp_Conseleccion = false;
            this.cmb_TipoMoneda.Pp_descripcion = "nombre";
            this.cmb_TipoMoneda.Pp_MensajeError = null;
            this.cmb_TipoMoneda.Pp_NombreCampo = null;
            this.cmb_TipoMoneda.Pp_NombreTabla = null;
            this.cmb_TipoMoneda.Pp_Pk = "id_moneda";
            this.cmb_TipoMoneda.Pp_tabla_origen = "tipo_moneda";
            this.cmb_TipoMoneda.Pp_Validable = false;
            this.cmb_TipoMoneda.Size = new System.Drawing.Size(121, 24);
            this.cmb_TipoMoneda.TabIndex = 5;
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Enabled = false;
            this.txt_Cliente.Location = new System.Drawing.Point(184, 74);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Pp_MensajeError = null;
            this.txt_Cliente.Pp_NombreCampo = null;
            this.txt_Cliente.Pp_NombreTabla = null;
            this.txt_Cliente.Pp_Validable = false;
            this.txt_Cliente.Size = new System.Drawing.Size(100, 23);
            this.txt_Cliente.TabIndex = 13;
            // 
            // txt_DesignCatastral
            // 
            this.txt_DesignCatastral.Enabled = false;
            this.txt_DesignCatastral.Location = new System.Drawing.Point(184, 105);
            this.txt_DesignCatastral.Name = "txt_DesignCatastral";
            this.txt_DesignCatastral.Pp_MensajeError = null;
            this.txt_DesignCatastral.Pp_NombreCampo = null;
            this.txt_DesignCatastral.Pp_NombreTabla = null;
            this.txt_DesignCatastral.Pp_Validable = false;
            this.txt_DesignCatastral.Size = new System.Drawing.Size(100, 23);
            this.txt_DesignCatastral.TabIndex = 10;
            this.txt_DesignCatastral.TextChanged += new System.EventHandler(this.textBoxHeredado1_TextChanged);
            // 
            // Frm_CompraVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 411);
            this.Controls.Add(this.btn_RegistrarVenta);
            this.Controls.Add(this.gdr_CompraVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_CompraVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de CompraVenta";
            this.Load += new System.EventHandler(this.Frm_CompraVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdr_CompraVenta)).EndInit();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clases.MaskedTextBoxHeredado txt_FechaActual;
        private Clases.MaskedTextBoxHeredado txt_FechaPago;
        private System.Windows.Forms.Label label4;
        private Clases.MaskedTextBoxHeredado txt_Monto;
        private System.Windows.Forms.Label label5;
        private Clases.ComboBoxHeredadaE cmb_TipoMoneda;
        private System.Windows.Forms.Label label6;
        private Clases.TextBoxHeredado txt_DesignCatastral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_DesignCatastral;
        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.Label label8;
        private Clases.TextBoxHeredado txt_Cliente;
        private System.Windows.Forms.Button btn_Escribano;
        private System.Windows.Forms.Label label9;
        private Clases.TextBoxHeredado txt_Escribano;
        private System.Windows.Forms.Button btn_FechaActual;
        private System.Windows.Forms.DataGridView gdr_CompraVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_CompraVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.Button btn_RegistrarVenta;
        private System.Windows.Forms.GroupBox groupBoxDatos;
    }
}