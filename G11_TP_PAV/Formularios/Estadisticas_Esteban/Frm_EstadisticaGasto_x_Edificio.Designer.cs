
namespace G11_TP_PAV.Formularios.Estadisticas_Esteban
{
    partial class Frm_EstadisticaGasto_x_Edificio
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
            this.Rv_GanXBarrio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // Rv_GanXBarrio
            // 
            this.Rv_GanXBarrio.Location = new System.Drawing.Point(12, 12);
            this.Rv_GanXBarrio.Name = "Rv_GanXBarrio";
            this.Rv_GanXBarrio.ServerReport.BearerToken = null;
            this.Rv_GanXBarrio.Size = new System.Drawing.Size(973, 524);
            this.Rv_GanXBarrio.TabIndex = 0;
            // 
            // Frm_EstadisticaGasto_x_Edificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 548);
            this.Controls.Add(this.Rv_GanXBarrio);
            this.Name = "Frm_EstadisticaGasto_x_Edificio";
            this.Text = "Gastos por Edificio";
            this.Load += new System.EventHandler(this.Frm_EstadisticaGasto_x_Edificio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rv_GanXBarrio;
    }
}