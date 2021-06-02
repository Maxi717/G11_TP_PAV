
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_DesignCatastral = new System.Windows.Forms.Button();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Escribano = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_FechaActual = new System.Windows.Forms.Button();
            this.gdr_CompraVenta = new System.Windows.Forms.DataGridView();
            this.Id_CompraVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propiedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_RegistrarVenta = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txt_Escribano = new G11_TP_PAV.Clases.TextBoxHeredado();
            this.txt_Cliente = new G11_TP_PAV.Clases.TextBoxHeredado();
            this.txt_DesignCatastral = new G11_TP_PAV.Clases.TextBoxHeredado();
            this.cmb_TipoMoneda = new G11_TP_PAV.Clases.ComboBoxHeredadaE();
            this.txt_Monto = new G11_TP_PAV.Clases.MaskedTextBoxHeredado();
            this.txt_FechaPago = new G11_TP_PAV.Clases.MaskedTextBoxHeredado();
            this.txt_FechaActual = new G11_TP_PAV.Clases.MaskedTextBoxHeredado();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_CompraVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registro de CompraVenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Monto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo de Moneda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Designacion Catastral:";
            // 
            // btn_DesignCatastral
            // 
            this.btn_DesignCatastral.Location = new System.Drawing.Point(291, 138);
            this.btn_DesignCatastral.Name = "btn_DesignCatastral";
            this.btn_DesignCatastral.Size = new System.Drawing.Size(77, 23);
            this.btn_DesignCatastral.TabIndex = 12;
            this.btn_DesignCatastral.Text = "Buscar";
            this.btn_DesignCatastral.UseVisualStyleBackColor = true;
            this.btn_DesignCatastral.Click += new System.EventHandler(this.btn_DesignCatastral_Click);
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.Location = new System.Drawing.Point(291, 107);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(77, 23);
            this.btn_Cliente.TabIndex = 15;
            this.btn_Cliente.Text = "Buscar";
            this.btn_Cliente.UseVisualStyleBackColor = true;
            this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cliente:";
            // 
            // btn_Escribano
            // 
            this.btn_Escribano.Location = new System.Drawing.Point(291, 290);
            this.btn_Escribano.Name = "btn_Escribano";
            this.btn_Escribano.Size = new System.Drawing.Size(77, 23);
            this.btn_Escribano.TabIndex = 18;
            this.btn_Escribano.Text = "Buscar";
            this.btn_Escribano.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Escribano:";
            // 
            // btn_FechaActual
            // 
            this.btn_FechaActual.Location = new System.Drawing.Point(291, 55);
            this.btn_FechaActual.Name = "btn_FechaActual";
            this.btn_FechaActual.Size = new System.Drawing.Size(71, 46);
            this.btn_FechaActual.TabIndex = 19;
            this.btn_FechaActual.Text = "Fecha Actual";
            this.btn_FechaActual.UseVisualStyleBackColor = true;
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
            this.gdr_CompraVenta.Location = new System.Drawing.Point(403, 55);
            this.gdr_CompraVenta.Name = "gdr_CompraVenta";
            this.gdr_CompraVenta.ReadOnly = true;
            this.gdr_CompraVenta.Size = new System.Drawing.Size(693, 255);
            this.gdr_CompraVenta.TabIndex = 20;
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
            this.btn_RegistrarVenta.Location = new System.Drawing.Point(185, 413);
            this.btn_RegistrarVenta.Name = "btn_RegistrarVenta";
            this.btn_RegistrarVenta.Size = new System.Drawing.Size(195, 23);
            this.btn_RegistrarVenta.TabIndex = 21;
            this.btn_RegistrarVenta.Text = "Registrar CompraVenta";
            this.btn_RegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(613, 413);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Modificar CompraVenta";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(924, 413);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(167, 23);
            this.button7.TabIndex = 23;
            this.button7.Text = "Eliminar CompraVenta";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // txt_Escribano
            // 
            this.txt_Escribano.Location = new System.Drawing.Point(185, 290);
            this.txt_Escribano.Name = "txt_Escribano";
            this.txt_Escribano.Pp_MensajeError = null;
            this.txt_Escribano.Pp_NombreCampo = null;
            this.txt_Escribano.Pp_NombreTabla = null;
            this.txt_Escribano.Pp_Validable = false;
            this.txt_Escribano.Size = new System.Drawing.Size(100, 23);
            this.txt_Escribano.TabIndex = 16;
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Location = new System.Drawing.Point(185, 107);
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
            this.txt_DesignCatastral.Location = new System.Drawing.Point(185, 138);
            this.txt_DesignCatastral.Name = "txt_DesignCatastral";
            this.txt_DesignCatastral.Pp_MensajeError = null;
            this.txt_DesignCatastral.Pp_NombreCampo = null;
            this.txt_DesignCatastral.Pp_NombreTabla = null;
            this.txt_DesignCatastral.Pp_Validable = false;
            this.txt_DesignCatastral.Size = new System.Drawing.Size(100, 23);
            this.txt_DesignCatastral.TabIndex = 10;
            this.txt_DesignCatastral.TextChanged += new System.EventHandler(this.textBoxHeredado1_TextChanged);
            // 
            // cmb_TipoMoneda
            // 
            this.cmb_TipoMoneda.FormattingEnabled = true;
            this.cmb_TipoMoneda.Location = new System.Drawing.Point(185, 248);
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
            this.cmb_TipoMoneda.TabIndex = 8;
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(185, 166);
            this.txt_Monto.Mask = "99999999.99";
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Pp_MaskxDefecto = null;
            this.txt_Monto.Pp_MensajeError = null;
            this.txt_Monto.Pp_NombreCampo = null;
            this.txt_Monto.Pp_NombreTabla = null;
            this.txt_Monto.Pp_Validable = false;
            this.txt_Monto.Size = new System.Drawing.Size(72, 23);
            this.txt_Monto.TabIndex = 7;
            this.txt_Monto.ValidatingType = typeof(System.DateTime);
            // 
            // txt_FechaPago
            // 
            this.txt_FechaPago.Location = new System.Drawing.Point(185, 207);
            this.txt_FechaPago.Mask = "99/99/9999";
            this.txt_FechaPago.Name = "txt_FechaPago";
            this.txt_FechaPago.Pp_MaskxDefecto = null;
            this.txt_FechaPago.Pp_MensajeError = null;
            this.txt_FechaPago.Pp_NombreCampo = null;
            this.txt_FechaPago.Pp_NombreTabla = null;
            this.txt_FechaPago.Pp_Validable = false;
            this.txt_FechaPago.Size = new System.Drawing.Size(72, 23);
            this.txt_FechaPago.TabIndex = 5;
            this.txt_FechaPago.ValidatingType = typeof(System.DateTime);
            // 
            // txt_FechaActual
            // 
            this.txt_FechaActual.Location = new System.Drawing.Point(185, 67);
            this.txt_FechaActual.Mask = "99/99/9999";
            this.txt_FechaActual.Name = "txt_FechaActual";
            this.txt_FechaActual.Pp_MaskxDefecto = null;
            this.txt_FechaActual.Pp_MensajeError = null;
            this.txt_FechaActual.Pp_NombreCampo = null;
            this.txt_FechaActual.Pp_NombreTabla = null;
            this.txt_FechaActual.Pp_Validable = false;
            this.txt_FechaActual.Size = new System.Drawing.Size(72, 23);
            this.txt_FechaActual.TabIndex = 3;
            this.txt_FechaActual.ValidatingType = typeof(System.DateTime);
            // 
            // Frm_CompraVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 480);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_RegistrarVenta);
            this.Controls.Add(this.gdr_CompraVenta);
            this.Controls.Add(this.btn_FechaActual);
            this.Controls.Add(this.btn_Escribano);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Escribano);
            this.Controls.Add(this.btn_Cliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.btn_DesignCatastral);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_DesignCatastral);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_TipoMoneda);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_FechaPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_FechaActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_CompraVenta";
            this.Text = "Frm_CompraVenta";
            this.Load += new System.EventHandler(this.Frm_CompraVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdr_CompraVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}