namespace G11_TP_PAV.Formularios
{
    partial class Frm_Altas_Gastos
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.cmb_edificio = new G11_TP_PAV.Clases.ComboBoxHeredadaG();
            this.num_importe = new G11_TP_PAV.Clases.NumericHeredada();
            this.num_comprobante = new G11_TP_PAV.Clases.NumericHeredada();
            this.txt_proveedor = new G11_TP_PAV.Clases.TextBoxHeredada();
            this.txt_concepto = new G11_TP_PAV.Clases.TextBoxHeredada();
            this.date_gastos = new G11_TP_PAV.Clases.DateTimeHeredada();
            ((System.ComponentModel.ISupportInitialize)(this.num_importe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_comprobante)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Altas de Gastos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Numero de Comprobante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha Transacción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Concepto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Importe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Proveedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Id del edificio";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(359, 399);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(183, 399);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // cmb_edificio
            // 
            this.cmb_edificio.FormattingEnabled = true;
            this.cmb_edificio.Location = new System.Drawing.Point(183, 336);
            this.cmb_edificio.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_edificio.Name = "cmb_edificio";
            this.cmb_edificio.Pp_campo = "id_edificio";
            this.cmb_edificio.Pp_Conseleccion = false;
            this.cmb_edificio.Pp_descripcion = "domicilio";
            this.cmb_edificio.Pp_MensajeError = "Falta id edificio";
            this.cmb_edificio.Pp_NombreTabla = null;
            this.cmb_edificio.Pp_Pk = "id";
            this.cmb_edificio.Pp_Tabla = "edificios";
            this.cmb_edificio.Pp_Validable = false;
            this.cmb_edificio.Size = new System.Drawing.Size(175, 24);
            this.cmb_edificio.TabIndex = 5;
            // 
            // num_importe
            // 
            this.num_importe.Location = new System.Drawing.Point(183, 244);
            this.num_importe.Margin = new System.Windows.Forms.Padding(4);
            this.num_importe.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.num_importe.Name = "num_importe";
            this.num_importe.Pp_campo = "importe";
            this.num_importe.Pp_MensajeError = "Falta importe";
            this.num_importe.Pp_tabla = null;
            this.num_importe.Pp_Validable = false;
            this.num_importe.Size = new System.Drawing.Size(176, 22);
            this.num_importe.TabIndex = 3;
            // 
            // num_comprobante
            // 
            this.num_comprobante.Location = new System.Drawing.Point(183, 100);
            this.num_comprobante.Margin = new System.Windows.Forms.Padding(4);
            this.num_comprobante.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.num_comprobante.Name = "num_comprobante";
            this.num_comprobante.Pp_campo = "numero_comprobante";
            this.num_comprobante.Pp_MensajeError = "Falta numero de comprobante";
            this.num_comprobante.Pp_tabla = null;
            this.num_comprobante.Pp_Validable = false;
            this.num_comprobante.Size = new System.Drawing.Size(154, 22);
            this.num_comprobante.TabIndex = 0;
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Location = new System.Drawing.Point(183, 292);
            this.txt_proveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Pp_campo = "proveedor";
            this.txt_proveedor.Pp_MensajeError = "Falta proveedor";
            this.txt_proveedor.Pp_tabla = null;
            this.txt_proveedor.Pp_Validable = false;
            this.txt_proveedor.Size = new System.Drawing.Size(132, 22);
            this.txt_proveedor.TabIndex = 4;
            // 
            // txt_concepto
            // 
            this.txt_concepto.Location = new System.Drawing.Point(183, 198);
            this.txt_concepto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Pp_campo = "concepto";
            this.txt_concepto.Pp_MensajeError = "Falta concepto";
            this.txt_concepto.Pp_tabla = null;
            this.txt_concepto.Pp_Validable = false;
            this.txt_concepto.Size = new System.Drawing.Size(132, 22);
            this.txt_concepto.TabIndex = 2;
            // 
            // date_gastos
            // 
            this.date_gastos.CustomFormat = "dd-MM-yyyy";
            this.date_gastos.Location = new System.Drawing.Point(183, 151);
            this.date_gastos.MaxDate = new System.DateTime(2150, 12, 31, 0, 0, 0, 0);
            this.date_gastos.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.date_gastos.Name = "date_gastos";
            this.date_gastos.Pp_campo = "fecha";
            this.date_gastos.Pp_MensajeError = "Falta fecha de transacción";
            this.date_gastos.Pp_tabla = null;
            this.date_gastos.Pp_Validable = false;
            this.date_gastos.Size = new System.Drawing.Size(280, 22);
            this.date_gastos.TabIndex = 1;
            // 
            // Frm_Altas_Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 481);
            this.ControlBox = false;
            this.Controls.Add(this.date_gastos);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_edificio);
            this.Controls.Add(this.num_importe);
            this.Controls.Add(this.num_comprobante);
            this.Controls.Add(this.txt_proveedor);
            this.Controls.Add(this.txt_concepto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Altas_Gastos";
            this.Load += new System.EventHandler(this.Frm_Altas_Gastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_importe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_comprobante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBoxHeredada txt_concepto;
        private Clases.TextBoxHeredada txt_proveedor;
        private Clases.NumericHeredada num_comprobante;
        private Clases.NumericHeredada num_importe;
        private Clases.ComboBoxHeredadaG cmb_edificio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private Clases.DateTimeHeredada date_gastos;
    }
}