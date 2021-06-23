
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
            this.chk_Filtro = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_mesActual = new System.Windows.Forms.Button();
            this.txt_mesFiltro = new System.Windows.Forms.MaskedTextBox();
            this.rd_mesAño = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rv_ReciboExpensas
            // 
            this.rv_ReciboExpensas.Location = new System.Drawing.Point(13, 150);
            this.rv_ReciboExpensas.Margin = new System.Windows.Forms.Padding(4);
            this.rv_ReciboExpensas.Name = "rv_ReciboExpensas";
            this.rv_ReciboExpensas.ServerReport.BearerToken = null;
            this.rv_ReciboExpensas.Size = new System.Drawing.Size(714, 301);
            this.rv_ReciboExpensas.TabIndex = 3;
            // 
            // btn_Generar
            // 
            this.btn_Generar.Location = new System.Drawing.Point(613, 115);
            this.btn_Generar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(112, 32);
            this.btn_Generar.TabIndex = 0;
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
            // chk_Filtro
            // 
            this.chk_Filtro.AutoSize = true;
            this.chk_Filtro.Location = new System.Drawing.Point(349, 121);
            this.chk_Filtro.Name = "chk_Filtro";
            this.chk_Filtro.Size = new System.Drawing.Size(68, 22);
            this.chk_Filtro.TabIndex = 1;
            this.chk_Filtro.Text = "Filtrar ";
            this.chk_Filtro.UseVisualStyleBackColor = true;
            this.chk_Filtro.CheckedChanged += new System.EventHandler(this.chk_Filtro_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_mesActual);
            this.groupBox1.Controls.Add(this.txt_mesFiltro);
            this.groupBox1.Controls.Add(this.rd_mesAño);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(13, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(329, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btn_mesActual
            // 
            this.btn_mesActual.Enabled = false;
            this.btn_mesActual.Location = new System.Drawing.Point(240, 16);
            this.btn_mesActual.Name = "btn_mesActual";
            this.btn_mesActual.Size = new System.Drawing.Size(59, 54);
            this.btn_mesActual.TabIndex = 1;
            this.btn_mesActual.Text = "Mes actual";
            this.btn_mesActual.UseVisualStyleBackColor = true;
            this.btn_mesActual.Click += new System.EventHandler(this.btn_mesActual_Click);
            // 
            // txt_mesFiltro
            // 
            this.txt_mesFiltro.Enabled = false;
            this.txt_mesFiltro.Location = new System.Drawing.Point(172, 33);
            this.txt_mesFiltro.Mask = "00/0000";
            this.txt_mesFiltro.Name = "txt_mesFiltro";
            this.txt_mesFiltro.Size = new System.Drawing.Size(62, 24);
            this.txt_mesFiltro.TabIndex = 0;
            this.txt_mesFiltro.ValidatingType = typeof(System.DateTime);
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
            // Frm_ListadoRecibosExpensas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 464);
            this.Controls.Add(this.chk_Filtro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Generar);
            this.Controls.Add(this.rv_ReciboExpensas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_ListadoRecibosExpensas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Recibos ";
            this.Load += new System.EventHandler(this.Frm_ListadoRecibosExpensas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_ReciboExpensas;
        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_Filtro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_mesActual;
        private System.Windows.Forms.MaskedTextBox txt_mesFiltro;
        private System.Windows.Forms.RadioButton rd_mesAño;
    }
}