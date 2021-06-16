namespace G11_TP_PAV.Informes
{
    partial class Frm_ListadoPublicidades
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
            this.RV_publicidades = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.date_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.date_final = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RV_publicidades
            // 
            this.RV_publicidades.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.Publicidades.informeReportePublicidades.rdlc";
            this.RV_publicidades.Location = new System.Drawing.Point(12, 125);
            this.RV_publicidades.Name = "RV_publicidades";
            this.RV_publicidades.ServerReport.BearerToken = null;
            this.RV_publicidades.Size = new System.Drawing.Size(776, 428);
            this.RV_publicidades.TabIndex = 0;
            this.RV_publicidades.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado Publicidades";
            // 
            // date_inicio
            // 
            this.date_inicio.Location = new System.Drawing.Point(127, 71);
            this.date_inicio.Name = "date_inicio";
            this.date_inicio.Size = new System.Drawing.Size(200, 20);
            this.date_inicio.TabIndex = 2;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(660, 71);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // date_final
            // 
            this.date_final.Location = new System.Drawing.Point(433, 71);
            this.date_final.Name = "date_final";
            this.date_final.Size = new System.Drawing.Size(200, 20);
            this.date_final.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Final";
            // 
            // Frm_ListadoPublicidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_final);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.date_inicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RV_publicidades);
            this.Name = "Frm_ListadoPublicidades";
            this.Text = "Listado Publicidades";
            this.Load += new System.EventHandler(this.Frm_ListadoPublicidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_publicidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_inicio;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DateTimePicker date_final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}