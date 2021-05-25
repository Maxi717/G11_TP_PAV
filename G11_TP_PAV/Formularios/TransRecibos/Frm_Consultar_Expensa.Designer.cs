namespace G11_TP_PAV.Formularios.TransRecibos
{
    partial class Frm_Consultar_Expensa
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
            this.grid_expensas = new System.Windows.Forms.DataGridView();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_expensas)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_expensas
            // 
            this.grid_expensas.AllowUserToAddRows = false;
            this.grid_expensas.AllowUserToDeleteRows = false;
            this.grid_expensas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_expensas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.piso,
            this.denominacion,
            this.importe,
            this.mes,
            this.anio,
            this.id_departamento});
            this.grid_expensas.Location = new System.Drawing.Point(12, 47);
            this.grid_expensas.Name = "grid_expensas";
            this.grid_expensas.ReadOnly = true;
            this.grid_expensas.Size = new System.Drawing.Size(649, 74);
            this.grid_expensas.TabIndex = 4;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(505, 141);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(103, 23);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // piso
            // 
            this.piso.HeaderText = "Piso";
            this.piso.Name = "piso";
            this.piso.ReadOnly = true;
            this.piso.Width = 30;
            // 
            // denominacion
            // 
            this.denominacion.HeaderText = "Departamento";
            this.denominacion.Name = "denominacion";
            this.denominacion.ReadOnly = true;
            this.denominacion.Width = 75;
            // 
            // importe
            // 
            this.importe.HeaderText = "Expensas";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            this.importe.Width = 150;
            // 
            // mes
            // 
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            // 
            // anio
            // 
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            // 
            // id_departamento
            // 
            this.id_departamento.HeaderText = "Edificio";
            this.id_departamento.Name = "id_departamento";
            this.id_departamento.ReadOnly = true;
            this.id_departamento.Width = 150;
            // 
            // Frm_Consultar_Expensa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 179);
            this.ControlBox = false;
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.grid_expensas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Consultar_Expensa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Consultar_Expensa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_expensas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_expensas;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_departamento;
    }
}