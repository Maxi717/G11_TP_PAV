using System;

namespace G11_TP_PAV.Formularios.TransRecibos
{
    partial class Frm_Transaccion_Recibos
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_recibo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_meses = new G11_TP_PAV.Clases.ComboBoxHeredada();
            this.cmb_departamentos_R = new G11_TP_PAV.Clases.ComboBoxHeredadaG();
            this.cmb_edificios_R = new G11_TP_PAV.Clases.ComboBoxHeredadaG();
            this.cmb_departamentos = new G11_TP_PAV.Clases.ComboBoxHeredadaG();
            this.cmb_fecha = new G11_TP_PAV.Clases.ComboBoxHeredadaG();
            this.cmb_edificios = new G11_TP_PAV.Clases.ComboBoxHeredadaG();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(274, 114);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(103, 23);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Consultar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_recibo
            // 
            this.btn_recibo.Location = new System.Drawing.Point(271, 95);
            this.btn_recibo.Name = "btn_recibo";
            this.btn_recibo.Size = new System.Drawing.Size(106, 23);
            this.btn_recibo.TabIndex = 5;
            this.btn_recibo.Text = "Generar expensa";
            this.btn_recibo.UseVisualStyleBackColor = true;
            this.btn_recibo.Click += new System.EventHandler(this.btn_recibo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione un edificio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de expensa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_aceptar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_departamentos);
            this.groupBox1.Controls.Add(this.cmb_fecha);
            this.groupBox1.Controls.Add(this.cmb_edificios);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 150);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_anio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmb_meses);
            this.groupBox2.Controls.Add(this.btn_recibo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmb_departamentos_R);
            this.groupBox2.Controls.Add(this.cmb_edificios_R);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(25, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 149);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo recibo";
            // 
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(128, 97);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(100, 20);
            this.txt_anio.TabIndex = 9;
            this.txt_anio.TextChanged += new System.EventHandler(this.Txt_anio_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mes a liquidar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Departamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccione un edificio:";
            // 
            // cmb_meses
            // 
            this.cmb_meses.FormattingEnabled = true;
            this.cmb_meses.Location = new System.Drawing.Point(9, 97);
            this.cmb_meses.Name = "cmb_meses";
            this.cmb_meses.Pp_combinada01 = null;
            this.cmb_meses.Pp_combinada02 = null;
            this.cmb_meses.Pp_descripcion = "nombre";
            this.cmb_meses.Pp_Pk = "id_mes";
            this.cmb_meses.Pp_tabla_origen = "meses";
            this.cmb_meses.Size = new System.Drawing.Size(95, 21);
            this.cmb_meses.TabIndex = 7;
            // 
            // cmb_departamentos_R
            // 
            this.cmb_departamentos_R.FormattingEnabled = true;
            this.cmb_departamentos_R.Location = new System.Drawing.Point(270, 37);
            this.cmb_departamentos_R.Name = "cmb_departamentos_R";
            this.cmb_departamentos_R.Pp_campo = null;
            this.cmb_departamentos_R.Pp_combinada01 = "piso";
            this.cmb_departamentos_R.Pp_combinada02 = "denominacion";
            this.cmb_departamentos_R.Pp_Conseleccion = false;
            this.cmb_departamentos_R.Pp_descripcion = null;
            this.cmb_departamentos_R.Pp_MensajeError = null;
            this.cmb_departamentos_R.Pp_NombreTabla = null;
            this.cmb_departamentos_R.Pp_Pk = "id_departamento";
            this.cmb_departamentos_R.Pp_Tabla = "departamento";
            this.cmb_departamentos_R.Pp_Validable = false;
            this.cmb_departamentos_R.Pp_valorSelec = null;
            this.cmb_departamentos_R.Size = new System.Drawing.Size(107, 21);
            this.cmb_departamentos_R.TabIndex = 1;
            this.cmb_departamentos_R.SelectedIndexChanged += new System.EventHandler(this.cmb_departamentos_R_SelectedIndexChanged);
            // 
            // cmb_edificios_R
            // 
            this.cmb_edificios_R.FormattingEnabled = true;
            this.cmb_edificios_R.Location = new System.Drawing.Point(9, 37);
            this.cmb_edificios_R.Name = "cmb_edificios_R";
            this.cmb_edificios_R.Pp_campo = null;
            this.cmb_edificios_R.Pp_combinada01 = null;
            this.cmb_edificios_R.Pp_combinada02 = null;
            this.cmb_edificios_R.Pp_Conseleccion = false;
            this.cmb_edificios_R.Pp_descripcion = "domicilio";
            this.cmb_edificios_R.Pp_MensajeError = null;
            this.cmb_edificios_R.Pp_NombreTabla = null;
            this.cmb_edificios_R.Pp_Pk = "id";
            this.cmb_edificios_R.Pp_Tabla = "edificios";
            this.cmb_edificios_R.Pp_Validable = false;
            this.cmb_edificios_R.Pp_valorSelec = null;
            this.cmb_edificios_R.Size = new System.Drawing.Size(222, 21);
            this.cmb_edificios_R.TabIndex = 0;
            this.cmb_edificios_R.SelectedIndexChanged += new System.EventHandler(this.cmb_edificios_R_SelectedIndexChanged);
            // 
            // cmb_departamentos
            // 
            this.cmb_departamentos.FormattingEnabled = true;
            this.cmb_departamentos.Location = new System.Drawing.Point(270, 49);
            this.cmb_departamentos.Name = "cmb_departamentos";
            this.cmb_departamentos.Pp_campo = null;
            this.cmb_departamentos.Pp_combinada01 = "piso";
            this.cmb_departamentos.Pp_combinada02 = "denominacion";
            this.cmb_departamentos.Pp_Conseleccion = false;
            this.cmb_departamentos.Pp_descripcion = null;
            this.cmb_departamentos.Pp_MensajeError = null;
            this.cmb_departamentos.Pp_NombreTabla = null;
            this.cmb_departamentos.Pp_Pk = "id_departamento";
            this.cmb_departamentos.Pp_Tabla = "departamento";
            this.cmb_departamentos.Pp_Validable = false;
            this.cmb_departamentos.Pp_valorSelec = null;
            this.cmb_departamentos.Size = new System.Drawing.Size(107, 21);
            this.cmb_departamentos.TabIndex = 1;
            this.cmb_departamentos.SelectedIndexChanged += new System.EventHandler(this.cmb_departamentos_SelectedIndexChanged);
            // 
            // cmb_fecha
            // 
            this.cmb_fecha.FormattingEnabled = true;
            this.cmb_fecha.Location = new System.Drawing.Point(9, 116);
            this.cmb_fecha.Name = "cmb_fecha";
            this.cmb_fecha.Pp_campo = null;
            this.cmb_fecha.Pp_combinada01 = "mes";
            this.cmb_fecha.Pp_combinada02 = "anio";
            this.cmb_fecha.Pp_Conseleccion = false;
            this.cmb_fecha.Pp_descripcion = null;
            this.cmb_fecha.Pp_MensajeError = null;
            this.cmb_fecha.Pp_NombreTabla = null;
            this.cmb_fecha.Pp_Pk = "numero_recibo";
            this.cmb_fecha.Pp_Tabla = "recibos";
            this.cmb_fecha.Pp_Validable = false;
            this.cmb_fecha.Pp_valorSelec = null;
            this.cmb_fecha.Size = new System.Drawing.Size(248, 21);
            this.cmb_fecha.TabIndex = 2;
            // 
            // cmb_edificios
            // 
            this.cmb_edificios.FormattingEnabled = true;
            this.cmb_edificios.Location = new System.Drawing.Point(9, 49);
            this.cmb_edificios.Name = "cmb_edificios";
            this.cmb_edificios.Pp_campo = null;
            this.cmb_edificios.Pp_combinada01 = null;
            this.cmb_edificios.Pp_combinada02 = null;
            this.cmb_edificios.Pp_Conseleccion = false;
            this.cmb_edificios.Pp_descripcion = "domicilio";
            this.cmb_edificios.Pp_MensajeError = null;
            this.cmb_edificios.Pp_NombreTabla = null;
            this.cmb_edificios.Pp_Pk = "id";
            this.cmb_edificios.Pp_Tabla = "edificios";
            this.cmb_edificios.Pp_Validable = false;
            this.cmb_edificios.Pp_valorSelec = null;
            this.cmb_edificios.Size = new System.Drawing.Size(222, 21);
            this.cmb_edificios.TabIndex = 0;
            this.cmb_edificios.SelectedIndexChanged += new System.EventHandler(this.cmb_edificios_SelectedIndexChanged);
            // 
            // Frm_Transaccion_Recibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Transaccion_Recibos";
            this.Text = "Generador de recibos";
            this.Load += new System.EventHandler(this.Frm_Transaccion_Recibos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void txt_anio_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Clases.ComboBoxHeredadaG cmb_fecha;
        private Clases.ComboBoxHeredadaG cmb_edificios;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_recibo;
        private Clases.ComboBoxHeredadaG cmb_departamentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private Clases.ComboBoxHeredadaG cmb_departamentos_R;
        private Clases.ComboBoxHeredadaG cmb_edificios_R;
        private System.Windows.Forms.Label label4;
        private Clases.ComboBoxHeredada cmb_meses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.Label label7;
    }
}