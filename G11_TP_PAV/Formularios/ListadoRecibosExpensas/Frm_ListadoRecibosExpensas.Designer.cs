
namespace G11_TP_PAV.Formularios.ListadoRecibosExpensas
{
    partial class Frm_ListadoRecibosExpensas
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
            this.rv_ReciboExpensas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Generar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rv_ReciboExpensas
            // 
            this.rv_ReciboExpensas.Location = new System.Drawing.Point(13, 149);
            this.rv_ReciboExpensas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rv_ReciboExpensas.Name = "rv_ReciboExpensas";
            this.rv_ReciboExpensas.ServerReport.BearerToken = null;
            this.rv_ReciboExpensas.Size = new System.Drawing.Size(714, 342);
            this.rv_ReciboExpensas.TabIndex = 0;
            // 
            // btn_Generar
            // 
            this.btn_Generar.Location = new System.Drawing.Point(615, 109);
            this.btn_Generar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(112, 32);
            this.btn_Generar.TabIndex = 1;
            this.btn_Generar.Text = "Generar Listado";
            this.btn_Generar.UseVisualStyleBackColor = true;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de recibos y expensas asociadas";
            // 
            // Frm_ListadoRecibosExpensas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Generar);
            this.Controls.Add(this.rv_ReciboExpensas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_ListadoRecibosExpensas";
            this.Text = "Frm_ListadoRecibosExpensas";
            this.Load += new System.EventHandler(this.Frm_ListadoRecibosExpensas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_ReciboExpensas;
        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.Label label1;
    }
}