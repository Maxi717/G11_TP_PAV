namespace G11_TP_PAV.Formularios.Publicidades
{
    partial class Frm_Estadistica_Publicidades
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
            this.SuspendLayout();
            // 
            // RV_publicidades
            // 
            this.RV_publicidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RV_publicidades.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.Publicidades.informeEstadisticasPublicidades.rdlc";
            this.RV_publicidades.Location = new System.Drawing.Point(0, 0);
            this.RV_publicidades.Name = "RV_publicidades";
            this.RV_publicidades.ServerReport.BearerToken = null;
            this.RV_publicidades.Size = new System.Drawing.Size(636, 450);
            this.RV_publicidades.TabIndex = 0;
            // 
            // Frm_Estadistica_Publicidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.RV_publicidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Estadistica_Publicidades";
            this.ShowIcon = false;
            this.Text = "Estadistica Pubicidades";
            this.Load += new System.EventHandler(this.Frm_Estadistica_Publicidades_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_publicidades;
    }
}