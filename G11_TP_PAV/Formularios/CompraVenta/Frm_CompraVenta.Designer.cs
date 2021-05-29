
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
            this.maskedTextBoxHeredado1 = new G11_TP_PAV.Clases.MaskedTextBoxHeredado();
            this.maskedTextBoxHeredado2 = new G11_TP_PAV.Clases.MaskedTextBoxHeredado();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxHeredado3 = new G11_TP_PAV.Clases.MaskedTextBoxHeredado();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxHeredadaE1 = new G11_TP_PAV.Clases.ComboBoxHeredadaE();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHeredado1 = new G11_TP_PAV.Clases.TextBoxHeredado();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHeredado2 = new G11_TP_PAV.Clases.TextBoxHeredado();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxHeredado3 = new G11_TP_PAV.Clases.TextBoxHeredado();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_CompraVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propiedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // maskedTextBoxHeredado1
            // 
            this.maskedTextBoxHeredado1.Location = new System.Drawing.Point(185, 67);
            this.maskedTextBoxHeredado1.Mask = "99/99/9999";
            this.maskedTextBoxHeredado1.Name = "maskedTextBoxHeredado1";
            this.maskedTextBoxHeredado1.Pp_MaskxDefecto = null;
            this.maskedTextBoxHeredado1.Pp_MensajeError = null;
            this.maskedTextBoxHeredado1.Pp_NombreCampo = null;
            this.maskedTextBoxHeredado1.Pp_NombreTabla = null;
            this.maskedTextBoxHeredado1.Pp_Validable = false;
            this.maskedTextBoxHeredado1.Size = new System.Drawing.Size(72, 23);
            this.maskedTextBoxHeredado1.TabIndex = 3;
            this.maskedTextBoxHeredado1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxHeredado2
            // 
            this.maskedTextBoxHeredado2.Location = new System.Drawing.Point(185, 207);
            this.maskedTextBoxHeredado2.Mask = "99/99/9999";
            this.maskedTextBoxHeredado2.Name = "maskedTextBoxHeredado2";
            this.maskedTextBoxHeredado2.Pp_MaskxDefecto = null;
            this.maskedTextBoxHeredado2.Pp_MensajeError = null;
            this.maskedTextBoxHeredado2.Pp_NombreCampo = null;
            this.maskedTextBoxHeredado2.Pp_NombreTabla = null;
            this.maskedTextBoxHeredado2.Pp_Validable = false;
            this.maskedTextBoxHeredado2.Size = new System.Drawing.Size(72, 23);
            this.maskedTextBoxHeredado2.TabIndex = 5;
            this.maskedTextBoxHeredado2.ValidatingType = typeof(System.DateTime);
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
            // maskedTextBoxHeredado3
            // 
            this.maskedTextBoxHeredado3.Location = new System.Drawing.Point(185, 166);
            this.maskedTextBoxHeredado3.Mask = "99999999.99";
            this.maskedTextBoxHeredado3.Name = "maskedTextBoxHeredado3";
            this.maskedTextBoxHeredado3.Pp_MaskxDefecto = null;
            this.maskedTextBoxHeredado3.Pp_MensajeError = null;
            this.maskedTextBoxHeredado3.Pp_NombreCampo = null;
            this.maskedTextBoxHeredado3.Pp_NombreTabla = null;
            this.maskedTextBoxHeredado3.Pp_Validable = false;
            this.maskedTextBoxHeredado3.Size = new System.Drawing.Size(72, 23);
            this.maskedTextBoxHeredado3.TabIndex = 7;
            this.maskedTextBoxHeredado3.ValidatingType = typeof(System.DateTime);
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
            // comboBoxHeredadaE1
            // 
            this.comboBoxHeredadaE1.FormattingEnabled = true;
            this.comboBoxHeredadaE1.Location = new System.Drawing.Point(185, 248);
            this.comboBoxHeredadaE1.Name = "comboBoxHeredadaE1";
            this.comboBoxHeredadaE1.Pp_Conseleccion = false;
            this.comboBoxHeredadaE1.Pp_descripcion = null;
            this.comboBoxHeredadaE1.Pp_MensajeError = null;
            this.comboBoxHeredadaE1.Pp_NombreCampo = null;
            this.comboBoxHeredadaE1.Pp_NombreTabla = null;
            this.comboBoxHeredadaE1.Pp_Pk = null;
            this.comboBoxHeredadaE1.Pp_tabla_origen = null;
            this.comboBoxHeredadaE1.Pp_Validable = false;
            this.comboBoxHeredadaE1.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHeredadaE1.TabIndex = 8;
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
            // textBoxHeredado1
            // 
            this.textBoxHeredado1.Location = new System.Drawing.Point(185, 138);
            this.textBoxHeredado1.Name = "textBoxHeredado1";
            this.textBoxHeredado1.Pp_MensajeError = null;
            this.textBoxHeredado1.Pp_NombreCampo = null;
            this.textBoxHeredado1.Pp_NombreTabla = null;
            this.textBoxHeredado1.Pp_Validable = false;
            this.textBoxHeredado1.Size = new System.Drawing.Size(100, 23);
            this.textBoxHeredado1.TabIndex = 10;
            this.textBoxHeredado1.TextChanged += new System.EventHandler(this.textBoxHeredado1_TextChanged);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
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
            // textBoxHeredado2
            // 
            this.textBoxHeredado2.Location = new System.Drawing.Point(185, 107);
            this.textBoxHeredado2.Name = "textBoxHeredado2";
            this.textBoxHeredado2.Pp_MensajeError = null;
            this.textBoxHeredado2.Pp_NombreCampo = null;
            this.textBoxHeredado2.Pp_NombreTabla = null;
            this.textBoxHeredado2.Pp_Validable = false;
            this.textBoxHeredado2.Size = new System.Drawing.Size(100, 23);
            this.textBoxHeredado2.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
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
            // textBoxHeredado3
            // 
            this.textBoxHeredado3.Location = new System.Drawing.Point(185, 290);
            this.textBoxHeredado3.Name = "textBoxHeredado3";
            this.textBoxHeredado3.Pp_MensajeError = null;
            this.textBoxHeredado3.Pp_NombreCampo = null;
            this.textBoxHeredado3.Pp_NombreTabla = null;
            this.textBoxHeredado3.Pp_Validable = false;
            this.textBoxHeredado3.Size = new System.Drawing.Size(100, 23);
            this.textBoxHeredado3.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(291, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 46);
            this.button4.TabIndex = 19;
            this.button4.Text = "Fecha Actual";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_CompraVenta,
            this.Fecha,
            this.Cliente,
            this.Propiedad,
            this.MontoTotal,
            this.Moneda,
            this.Factura});
            this.dataGridView1.Location = new System.Drawing.Point(403, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(693, 255);
            this.dataGridView1.TabIndex = 20;
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(185, 413);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Registrar CompraVenta";
            this.button5.UseVisualStyleBackColor = true;
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
            // Frm_CompraVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 480);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxHeredado3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxHeredado2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxHeredado1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxHeredadaE1);
            this.Controls.Add(this.maskedTextBoxHeredado3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBoxHeredado2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBoxHeredado1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_CompraVenta";
            this.Text = "Frm_CompraVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clases.MaskedTextBoxHeredado maskedTextBoxHeredado1;
        private Clases.MaskedTextBoxHeredado maskedTextBoxHeredado2;
        private System.Windows.Forms.Label label4;
        private Clases.MaskedTextBoxHeredado maskedTextBoxHeredado3;
        private System.Windows.Forms.Label label5;
        private Clases.ComboBoxHeredadaE comboBoxHeredadaE1;
        private System.Windows.Forms.Label label6;
        private Clases.TextBoxHeredado textBoxHeredado1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private Clases.TextBoxHeredado textBoxHeredado2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private Clases.TextBoxHeredado textBoxHeredado3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_CompraVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}