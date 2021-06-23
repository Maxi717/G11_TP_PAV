namespace G11_TP_PAV.Formularios.ReporteGanancias
{
    partial class Frm_estadisticaGananciasPorTipoPropiedad
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
            this.RV_ganancias = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RV_ganancias
            // 
            this.RV_ganancias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RV_ganancias.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.ReporteGanancias.informeGananciasPorTipoPropiedad.rdlc";
            this.RV_ganancias.Location = new System.Drawing.Point(0, 0);
            this.RV_ganancias.Name = "RV_ganancias";
            this.RV_ganancias.ServerReport.BearerToken = null;
            this.RV_ganancias.Size = new System.Drawing.Size(645, 450);
            this.RV_ganancias.TabIndex = 0;
            this.RV_ganancias.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Frm_estadisticaGananciasPorTipoPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.RV_ganancias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_estadisticaGananciasPorTipoPropiedad";
            this.ShowIcon = false;
            this.Text = "Ganancias por tipo propiedad";
            this.Load += new System.EventHandler(this.Frm_estadisticaGananciasPorTipoPropiedad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_ganancias;
    }
}