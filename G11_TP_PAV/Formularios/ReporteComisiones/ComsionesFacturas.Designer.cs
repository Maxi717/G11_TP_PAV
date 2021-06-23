namespace G11_TP_PAV.ReporteEma
{
    partial class ComisionesFacturas
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
            this.button1 = new System.Windows.Forms.Button();
            this.DT_desde = new System.Windows.Forms.DateTimePicker();
            this.DT_hasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 183);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(676, 246);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 75;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Visualizar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DT_desde
            // 
            this.DT_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_desde.Location = new System.Drawing.Point(122, 38);
            this.DT_desde.Name = "DT_desde";
            this.DT_desde.Size = new System.Drawing.Size(99, 20);
            this.DT_desde.TabIndex = 1;
            this.DT_desde.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DT_desde.ValueChanged += new System.EventHandler(this.DT_desde_ValueChanged);
            // 
            // DT_hasta
            // 
            this.DT_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_hasta.Location = new System.Drawing.Point(122, 78);
            this.DT_hasta.Name = "DT_hasta";
            this.DT_hasta.Size = new System.Drawing.Size(99, 20);
            this.DT_hasta.TabIndex = 2;
            this.DT_hasta.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.DT_hasta.ValueChanged += new System.EventHandler(this.DT_hasta_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(503, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Listado Facturas de Comisiones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DT_hasta);
            this.groupBox1.Controls.Add(this.DT_desde);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 115);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel Reporte";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ComisionesFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComisionesFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComisionesFacturas";
            this.Load += new System.EventHandler(this.ReporteVencimientoContrato_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DT_desde;
        private System.Windows.Forms.DateTimePicker DT_hasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}