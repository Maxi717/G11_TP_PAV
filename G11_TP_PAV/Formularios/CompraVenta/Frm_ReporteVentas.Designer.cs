
namespace G11_TP_PAV.Formularios.CompraVenta
{
    partial class Frm_ReporteVentas
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
            this.rv1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_mesActual = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hasta = new System.Windows.Forms.MaskedTextBox();
            this.txt_desde = new System.Windows.Forms.MaskedTextBox();
            this.txt_mesFiltro = new System.Windows.Forms.MaskedTextBox();
            this.rd_periodo = new System.Windows.Forms.RadioButton();
            this.rd_mesAño = new System.Windows.Forms.RadioButton();
            this.btn_GenerarReporte = new System.Windows.Forms.Button();
            this.chk_Filtro = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rv1
            // 
            this.rv1.Location = new System.Drawing.Point(13, 208);
            this.rv1.Margin = new System.Windows.Forms.Padding(4);
            this.rv1.Name = "rv1";
            this.rv1.ServerReport.BearerToken = null;
            this.rv1.Size = new System.Drawing.Size(1006, 300);
            this.rv1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(380, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte de Ventas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_mesActual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_hasta);
            this.groupBox1.Controls.Add(this.txt_desde);
            this.groupBox1.Controls.Add(this.txt_mesFiltro);
            this.groupBox1.Controls.Add(this.rd_periodo);
            this.groupBox1.Controls.Add(this.rd_mesAño);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(13, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(494, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btn_mesActual
            // 
            this.btn_mesActual.Enabled = false;
            this.btn_mesActual.Location = new System.Drawing.Point(240, 16);
            this.btn_mesActual.Name = "btn_mesActual";
            this.btn_mesActual.Size = new System.Drawing.Size(59, 54);
            this.btn_mesActual.TabIndex = 7;
            this.btn_mesActual.Text = "Mes actual";
            this.btn_mesActual.UseVisualStyleBackColor = true;
            this.btn_mesActual.Click += new System.EventHandler(this.btn_mesActual_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(344, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(169, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desde:";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Enabled = false;
            this.txt_hasta.Location = new System.Drawing.Point(396, 77);
            this.txt_hasta.Mask = "00/00/0000";
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(80, 24);
            this.txt_hasta.TabIndex = 4;
            this.txt_hasta.ValidatingType = typeof(System.DateTime);
            // 
            // txt_desde
            // 
            this.txt_desde.Enabled = false;
            this.txt_desde.Location = new System.Drawing.Point(232, 77);
            this.txt_desde.Mask = "00/00/0000";
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(83, 24);
            this.txt_desde.TabIndex = 3;
            this.txt_desde.ValidatingType = typeof(System.DateTime);
            // 
            // txt_mesFiltro
            // 
            this.txt_mesFiltro.Enabled = false;
            this.txt_mesFiltro.Location = new System.Drawing.Point(172, 33);
            this.txt_mesFiltro.Mask = "00/0000";
            this.txt_mesFiltro.Name = "txt_mesFiltro";
            this.txt_mesFiltro.Size = new System.Drawing.Size(62, 24);
            this.txt_mesFiltro.TabIndex = 2;
            this.txt_mesFiltro.ValidatingType = typeof(System.DateTime);
            // 
            // rd_periodo
            // 
            this.rd_periodo.AutoSize = true;
            this.rd_periodo.Location = new System.Drawing.Point(31, 77);
            this.rd_periodo.Name = "rd_periodo";
            this.rd_periodo.Size = new System.Drawing.Size(76, 22);
            this.rd_periodo.TabIndex = 1;
            this.rd_periodo.TabStop = true;
            this.rd_periodo.Text = "periodo";
            this.rd_periodo.UseVisualStyleBackColor = true;
            this.rd_periodo.CheckedChanged += new System.EventHandler(this.rd_periodo_CheckedChanged);
            // 
            // rd_mesAño
            // 
            this.rd_mesAño.AutoSize = true;
            this.rd_mesAño.Location = new System.Drawing.Point(31, 34);
            this.rd_mesAño.Name = "rd_mesAño";
            this.rd_mesAño.Size = new System.Drawing.Size(95, 22);
            this.rd_mesAño.TabIndex = 0;
            this.rd_mesAño.TabStop = true;
            this.rd_mesAño.Text = "mes y año";
            this.rd_mesAño.UseVisualStyleBackColor = true;
            this.rd_mesAño.CheckedChanged += new System.EventHandler(this.rd_mesAño_CheckedChanged);
            // 
            // btn_GenerarReporte
            // 
            this.btn_GenerarReporte.Location = new System.Drawing.Point(941, 141);
            this.btn_GenerarReporte.Name = "btn_GenerarReporte";
            this.btn_GenerarReporte.Size = new System.Drawing.Size(78, 55);
            this.btn_GenerarReporte.TabIndex = 4;
            this.btn_GenerarReporte.Text = "Generar Reporte";
            this.btn_GenerarReporte.UseVisualStyleBackColor = true;
            this.btn_GenerarReporte.Click += new System.EventHandler(this.btn_GenerarReporte_Click);
            // 
            // chk_Filtro
            // 
            this.chk_Filtro.AutoSize = true;
            this.chk_Filtro.Location = new System.Drawing.Point(514, 164);
            this.chk_Filtro.Name = "chk_Filtro";
            this.chk_Filtro.Size = new System.Drawing.Size(68, 22);
            this.chk_Filtro.TabIndex = 5;
            this.chk_Filtro.Text = "Filtrar ";
            this.chk_Filtro.UseVisualStyleBackColor = true;
            this.chk_Filtro.CheckedChanged += new System.EventHandler(this.chk_Filtro_CheckedChanged);
            // 
            // Frm_ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 511);
            this.Controls.Add(this.chk_Filtro);
            this.Controls.Add(this.btn_GenerarReporte);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rv1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.Frm_ReporteVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_mesActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_hasta;
        private System.Windows.Forms.MaskedTextBox txt_desde;
        private System.Windows.Forms.MaskedTextBox txt_mesFiltro;
        private System.Windows.Forms.RadioButton rd_periodo;
        private System.Windows.Forms.RadioButton rd_mesAño;
        private System.Windows.Forms.Button btn_GenerarReporte;
        private System.Windows.Forms.CheckBox chk_Filtro;
    }
}