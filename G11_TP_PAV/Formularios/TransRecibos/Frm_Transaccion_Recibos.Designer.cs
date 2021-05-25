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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cmb_edificios = new G11_TP_PAV.Clases.ComboBoxHeredadaG();
            this.cmb_departamentos = new G11_TP_PAV.Clases.ComboBoxHeredadaG();
            this.cmb_fecha = new G11_TP_PAV.Clases.ComboBoxHeredadaG();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(153, 224);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(103, 23);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(295, 224);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(106, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cmb_edificios
            // 
            this.cmb_edificios.FormattingEnabled = true;
            this.cmb_edificios.Location = new System.Drawing.Point(34, 67);
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
            // cmb_departamentos
            // 
            this.cmb_departamentos.FormattingEnabled = true;
            this.cmb_departamentos.Location = new System.Drawing.Point(294, 67);
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
            this.cmb_fecha.Location = new System.Drawing.Point(34, 165);
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
            this.cmb_fecha.Size = new System.Drawing.Size(367, 21);
            this.cmb_fecha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione un edificio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de expensa:";
            // 
            // Frm_Transaccion_Recibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 283);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.cmb_edificios);
            this.Controls.Add(this.cmb_departamentos);
            this.Controls.Add(this.cmb_fecha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Transaccion_Recibos";
            this.Text = "Generador de recibos";
            this.Load += new System.EventHandler(this.Frm_Transaccion_Recibos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.ComboBoxHeredadaG cmb_fecha;
        private Clases.ComboBoxHeredadaG cmb_edificios;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private Clases.ComboBoxHeredadaG cmb_departamentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}