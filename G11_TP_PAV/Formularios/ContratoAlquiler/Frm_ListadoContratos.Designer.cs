namespace G11_TP_PAV.Formularios.ContratoAlquiler
{
    partial class Frm_ListadoContratos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_deshacer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_desde = new System.Windows.Forms.DateTimePicker();
            this.dt_hasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.ContratoAlquiler.Reporte_Alquileres.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 122);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(763, 316);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_deshacer
            // 
            this.btn_deshacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deshacer.Location = new System.Drawing.Point(662, 80);
            this.btn_deshacer.Name = "btn_deshacer";
            this.btn_deshacer.Size = new System.Drawing.Size(113, 23);
            this.btn_deshacer.TabIndex = 7;
            this.btn_deshacer.Text = "Deshacer Filtro";
            this.btn_deshacer.UseVisualStyleBackColor = true;
            this.btn_deshacer.Click += new System.EventHandler(this.btn_deshacer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_filtrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dt_desde);
            this.groupBox1.Controls.Add(this.dt_hasta);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 62);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desde:";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(600, 24);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(145, 28);
            this.btn_filtrar.TabIndex = 4;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta:";
            // 
            // dt_desde
            // 
            this.dt_desde.Location = new System.Drawing.Point(79, 26);
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Size = new System.Drawing.Size(200, 20);
            this.dt_desde.TabIndex = 1;
            // 
            // dt_hasta
            // 
            this.dt_hasta.Location = new System.Drawing.Point(354, 26);
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Size = new System.Drawing.Size(200, 20);
            this.dt_hasta.TabIndex = 2;
            // 
            // Frm_ListadoContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_deshacer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_ListadoContratos";
            this.Text = "Frm_ListadoContratos";
            this.Load += new System.EventHandler(this.Frm_ListadoContratos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_deshacer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_desde;
        private System.Windows.Forms.DateTimePicker dt_hasta;
    }
}