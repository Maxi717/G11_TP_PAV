namespace G11_TP_PAV.Informes
{
    partial class Frm_ListadoEdificios
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
            this.RV_edificios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_limSuperior = new System.Windows.Forms.TextBox();
            this.txt_limInferior = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RV_edificios
            // 
            this.RV_edificios.LocalReport.ReportEmbeddedResource = "G11_TP_PAV.Formularios.Edificios.InformeReporteEdificios.rdlc";
            this.RV_edificios.Location = new System.Drawing.Point(12, 131);
            this.RV_edificios.Name = "RV_edificios";
            this.RV_edificios.ServerReport.BearerToken = null;
            this.RV_edificios.Size = new System.Drawing.Size(728, 469);
            this.RV_edificios.TabIndex = 0;
            this.RV_edificios.Load += new System.EventHandler(this.RV_edificios_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado edificios segun candidad de Departamentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Limite Inferior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Limite Superior";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(541, 77);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_limSuperior
            // 
            this.txt_limSuperior.Location = new System.Drawing.Point(369, 79);
            this.txt_limSuperior.Name = "txt_limSuperior";
            this.txt_limSuperior.Size = new System.Drawing.Size(100, 20);
            this.txt_limSuperior.TabIndex = 7;
            // 
            // txt_limInferior
            // 
            this.txt_limInferior.Location = new System.Drawing.Point(134, 79);
            this.txt_limInferior.Name = "txt_limInferior";
            this.txt_limInferior.Size = new System.Drawing.Size(100, 20);
            this.txt_limInferior.TabIndex = 8;
            // 
            // Frm_ListadoEdificios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 612);
            this.Controls.Add(this.txt_limInferior);
            this.Controls.Add(this.txt_limSuperior);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RV_edificios);
            this.Name = "Frm_ListadoEdificios";
            this.Text = "Listado Edificios";
            this.Load += new System.EventHandler(this.Frm_ListadoEdificios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_edificios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_limSuperior;
        private System.Windows.Forms.TextBox txt_limInferior;
    }
}