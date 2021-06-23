
namespace G11_TP_PAV.Formularios.Estadisticas_Esteban
{
    partial class Frm_Estadistica_cantFacturasXEscribano
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
            this.RV_FacturaXEscribano = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RV_FacturaXEscribano
            // 
            this.RV_FacturaXEscribano.Location = new System.Drawing.Point(12, 12);
            this.RV_FacturaXEscribano.Name = "RV_FacturaXEscribano";
            this.RV_FacturaXEscribano.ServerReport.BearerToken = null;
            this.RV_FacturaXEscribano.Size = new System.Drawing.Size(776, 521);
            this.RV_FacturaXEscribano.TabIndex = 0;
            // 
            // Frm_Estadistica_cantFacturasXEscribano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.RV_FacturaXEscribano);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_Estadistica_cantFacturasXEscribano";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas de Comisiones Facturadas Por Escribano";
            this.Load += new System.EventHandler(this.Frm_Estadistica_cantFacturasXEscribano_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_FacturaXEscribano;
    }
}